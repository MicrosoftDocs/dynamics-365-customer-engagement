' <snippetvalidate>


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
    Public Class Validate
        #Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy

        ' Define the IDs needed for this sample.
        Private _contactId As Guid
        Private _appointmentId As Guid

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Initiate the method to create any data that this sample requires.
        ''' Verify whether an appointment has valid resources for the appointment activity.        
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


                    ' Retrieve the appointment to be validated
                    Dim cols As New ColumnSet("scheduledstart", "scheduledend", "statecode", "statuscode")
                    Dim retrievedAppointment As Appointment = _
                        CType(_serviceProxy.Retrieve(Appointment.EntityLogicalName, _appointmentId, cols), Appointment)

                    ' Use the Validate message
                    Dim validatedReq As New ValidateRequest()
                    validatedReq.Activities = New EntityCollection()
                    validatedReq.Activities.Entities.Add(retrievedAppointment)
                    validatedReq.Activities.MoreRecords = False
                    validatedReq.Activities.PagingCookie = ""
                    validatedReq.Activities.EntityName = Appointment.EntityLogicalName

                    Dim validateResp As ValidateResponse = CType(_serviceProxy.Execute(validatedReq), ValidateResponse)

                    ' Verify success
                    If (validateResp.Result IsNot Nothing) AndAlso (validateResp.Result.Length > 0) Then
                        Console.WriteLine("Validated the appointment.")
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
            ' Create a contact
            Dim newContact As Contact = New Contact With {.FirstName = "Lisa", .LastName = "Andrews", .EMailAddress1 = "lisa@contoso.com"}
            _contactId = _serviceProxy.Create(newContact)
            Console.WriteLine("Created contact: {0}.", newContact.FirstName &amp; " " &amp; newContact.LastName)

            ' Create ab activity party
            Dim requiredAttendee As ActivityParty = New ActivityParty With { _
                .PartyId = New EntityReference(Contact.EntityLogicalName, _contactId)}

            ' Create an appointment
            Dim newAppointment As Appointment = New Appointment With { _
                .Subject = "Test Appointment", .Description = "Test Appointment", .ScheduledStart = Date.Now.AddHours(1), _
                .ScheduledEnd = Date.Now.AddHours(2), .Location = "Office", _
                .RequiredAttendees = New ActivityParty() {requiredAttendee}}
            _appointmentId = _serviceProxy.Create(newAppointment)
            Console.WriteLine("Created {0}.", newAppointment.Subject)
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
                _serviceProxy.Delete(Appointment.EntityLogicalName, _appointmentId)
                _serviceProxy.Delete(Contact.EntityLogicalName, _contactId)
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

                Dim app As New Validate()
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

' </snippetvalidate>