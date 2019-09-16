' <snippetlinkcustomattributesbetweenseriesandinstances>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Discovery
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Metadata

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' This sample shows how to custom attribute created for 
    ''' recurring appointment series with a custom attribute 
    ''' created for the appointment instances.
    ''' </summary>
    Public Class LinkCustomAttributesBetweenSeriesandInstances
        #Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy

        ' Define the IDs as well as strings needed for this sample.
        Public _instanceAttributeID As Guid
        Public _seriesAttributeID As Guid

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Initiate the method to create any data that this sample requires.
        ''' Link the custom attributes.
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



                    ' Create a custom string attribute for the appointment instance
                    Dim customAppointmentInstanceAttribute As StringAttributeMetadata = _
                        New StringAttributeMetadata With {.LogicalName = "new_customAppInstanceAttribute", .DisplayName = _
                            New Label("CustomAppInstanceAttribute", 1033), .Description = _
                            New Label("Sample Custom Appointment Instance Attribute", 1033), .MaxLength = 500, .RequiredLevel = _
                            New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None), .SchemaName = "new_customAppInstanceAttribute"}

                    Dim instanceAttributeRequest As CreateAttributeRequest = _
                        New CreateAttributeRequest With {.Attribute = customAppointmentInstanceAttribute, .EntityName = "appointment"}

                    Dim instanceAttributeResponse As CreateAttributeResponse = _
                        CType(_serviceProxy.Execute(instanceAttributeRequest), CreateAttributeResponse)
                    _instanceAttributeID = instanceAttributeResponse.AttributeId

                    ' Create a custom string attribute for the recurring appointment master (series)
                    Dim customAppointmentSeriesAttribute As StringAttributeMetadata = _
                        New StringAttributeMetadata With {.LogicalName = "new_customAppSeriesAttribute", .DisplayName = _
                            New Label("CustomAppSeriesAttribute", 1033), .Description = _
                            New Label("Sample Custom Appointment Series Attribute", 1033), .MaxLength = 500, .RequiredLevel = _
                            New AttributeRequiredLevelManagedProperty(AttributeRequiredLevel.None), _
                                        .SchemaName = "new_customAppSeriesAttribute", .LinkedAttributeId = _instanceAttributeID}

                    Dim seriesAttributeRequest As CreateAttributeRequest = New CreateAttributeRequest With { _
                        .Attribute = customAppointmentSeriesAttribute, .EntityName = "recurringappointmentmaster"}

                    Dim seriesAttributeResponse As CreateAttributeResponse = _
                        CType(_serviceProxy.Execute(seriesAttributeRequest), CreateAttributeResponse)
                    _seriesAttributeID = seriesAttributeResponse.AttributeId

                    ' Publish all the changes to the solution.
                    Dim createRequest As New PublishAllXmlRequest()
                    _serviceProxy.Execute(createRequest)

                    Console.WriteLine("Created a custom string attribute, {0}, for the appointment.", _
                                      customAppointmentInstanceAttribute.LogicalName)
                    Console.WriteLine("Created a custom string attribute, {0}, for the recurring appointment, and linked it with {1}.", _
                                      customAppointmentSeriesAttribute.LogicalName, customAppointmentInstanceAttribute.LogicalName)


                    DeleteRequiredRecords(promptForDelete)

                End Using
            ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
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
                Dim delSeriesAttribute As DeleteAttributeRequest = New DeleteAttributeRequest With { _
                    .LogicalName = "new_customappseriesattribute", .EntityLogicalName = RecurringAppointmentMaster.EntityLogicalName}
                _serviceProxy.Execute(delSeriesAttribute)

                Dim delInstanceAttribute As DeleteAttributeRequest = New DeleteAttributeRequest With { _
                    .LogicalName = "new_customappinstanceattribute", .EntityLogicalName = Appointment.EntityLogicalName}
                _serviceProxy.Execute(delInstanceAttribute)

                ' Publish all the changes to the solution.
                Dim delRequest As New PublishAllXmlRequest()
                _serviceProxy.Execute(delRequest)

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

                Dim app As New LinkCustomAttributesBetweenSeriesandInstances()
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

' </snippetlinkcustomattributesbetweenseriesandinstances>