' <snippetconvertanappointmenttorecurringappointment>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery
Imports Microsoft.Xrm.Sdk.Messages

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' This sample shows how to convert an appointment to a
    ''' recurring appointment.
    ''' </summary>
    Public Class ConvertAnAppointmenttoRecurringAppointment
        #Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy

        ' Define the IDs as well as strings needed for this sample.
        Public _appointmentId As Guid
        Public __recurringAppointmentMasterId As Guid

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Initiate the method to create any data that this sample requires.
        ''' Convert an appointment to a recurring appointment.
        ''' Optionally delete any entity records that were created for this sample.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
            Try

                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()


                    ' Call the method to create any data that this sample requires.
                    CreateRequiredRecords()


                    ' Specify the recurrence information that needs to be added to the
                    ' existing appointment.
                    ' 1.  Define an anonymous type to define the possible recurrence pattern values.
                    Dim RecurrencePatternTypes = New With {Key .Daily = 0, Key .Weekly = 1, Key .Monthly = 2, Key .Yearly = 3}

                    ' 2.  Define an anonymous type to define the possible values for days 
                    ' of the week
                    Dim DayOfWeek = New With {Key .Sunday = &amp;H1, Key .Monday = &amp;H2, Key .Tuesday = &amp;H4, Key .Wednesday = &amp;H8, _
                                              Key .Thursday = &amp;H10, Key .Friday = &amp;H20, Key .Saturday = &amp;H40}

                    ' 3.  Define an anonymous type to define the possible values  
                    ' for the recurrence rule pattern end type.
                    Dim RecurrenceRulePatternEndType = New With {Key .NoEndDate = 1, Key .Occurrences = 2, Key .PatternEndDate = 3}

                    ' 4.  Finally, use a recurring appointment master object to specify
                    '     the recurrence information. Other appointment details such as
                    '     'subject' and 'location' are copied from the existing appointment
                    '     to the recurring appointment master object.

                    Dim newRecurringAppointmentInfo As RecurringAppointmentMaster = New RecurringAppointmentMaster With { _
                        .StartTime = Date.Now.AddHours(2), .EndTime = Date.Now.AddHours(3), .RecurrencePatternType = _
                        New OptionSetValue(RecurrencePatternTypes.Weekly), .Interval = 1, .DaysOfWeekMask = DayOfWeek.Thursday, _
                        .PatternStartDate = Date.Today, .PatternEndType = _
                        New OptionSetValue(RecurrenceRulePatternEndType.Occurrences), .Occurrences = 5}


                    ' Use the AddRecurrence message to convert the existing appointment
                    ' object to a recurring appointment master object. The existing
                    ' appointment object is deleted thereafter.

                    Dim recurringInfoRequest As AddRecurrenceRequest = New AddRecurrenceRequest With { _
                        .Target = newRecurringAppointmentInfo, .AppointmentId = _appointmentId}

                    Dim recurringInfoResponse As AddRecurrenceResponse = _
                        CType(_serviceProxy.Execute(recurringInfoRequest), AddRecurrenceResponse)
                    __recurringAppointmentMasterId = recurringInfoResponse.id

                    ' Verify that the newly created recurring appointment master has same 'subject' 
                    ' as the existing appointment.

                    Dim retrievedMasterAppointment As RecurringAppointmentMaster = _
                        CType(_serviceProxy.Retrieve(RecurringAppointmentMaster.EntityLogicalName, __recurringAppointmentMasterId, _
                                                     New ColumnSet(True)), RecurringAppointmentMaster)
                    If retrievedMasterAppointment.Subject = "Sample Appointment" Then
                        Console.WriteLine("Sample Appointment is converted to a recurring appointment.")
                    End If


                    DeleteRequiredRecords(promptForDelete)

                End Using
            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' This method creates any entity records that this sample requires.
        ''' Create a new recurring appointment.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            ' Create an appointment
            Dim newAppointment As Appointment = New Appointment With {.Subject = "Sample Appointment", .Location = "Office", _
                                                        .ScheduledStart = Date.Now.AddHours(1), .ScheduledEnd = Date.Now.AddHours(2)}

            _appointmentId = _serviceProxy.Create(newAppointment)
            Console.WriteLine("Created {0}", newAppointment.Subject)

            Return
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user to delete 
        ''' the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want these entity records to be deleted? (y/n)")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
            End If

            If deleteRecords Then
                _serviceProxy.Delete(RecurringAppointmentMaster.EntityLogicalName, __recurringAppointmentMasterId)

                Console.WriteLine("Entity records have been deleted.")
            End If
        End Sub

        #End Region ' How To Sample Code

        #Region "Main"
        ''' <summary>
        ''' Standard Main() method used by most SDK samples.
        ''' </summary>
        ''' <param name="args"></param>
        Public Shared Sub Main(ByVal args() As String)
            Try
                ' Obtain the target organization's Web address and client logon 
                ' credentials from the user.
                Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

                Dim app As New ConvertAnAppointmenttoRecurringAppointment()
                app.Run(config, True)

            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
            Catch ex As TimeoutException
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Message: {0}", ex.Message)
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}", If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
            Catch ex As Exception
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine(ex.Message)

                ' Display the details of the inner exception.
                If ex.InnerException IsNot Nothing Then
                    Console.WriteLine(ex.InnerException.Message)

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) = _
                        TryCast(ex.InnerException, FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
                    If fe IsNot Nothing Then
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
                        Console.WriteLine("Message: {0}", fe.Detail.Message)
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}", If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
                    End If
                End If
            ' Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
            ' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.

            Finally

                Console.WriteLine("Press <Enter> to exit.")
                Console.ReadLine()
            End Try

        End Sub
        #End Region ' Main
    End Class
End Namespace

' </snippetconvertanappointmenttorecurringappointment>