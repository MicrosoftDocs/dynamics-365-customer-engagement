' <snippetsendbulkemailandmonitor>


Imports Microsoft.VisualBasic
Imports System
Imports System.ServiceModel
Imports System.Collections.Generic

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Client

' These namespaces are found in the Microsoft.Crm.Sdk.Proxy.dll assembly
' located in the SDK\bin folder of the SDK download.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    Public Class SendBulkEmailAndMonitor
#Region "Class Level Members"

        Private _serviceProxy As OrganizationServiceProxy
        Private _contactsIds As New List(Of Guid)()
        Private Const ARBITRARY_MAX_POLLING_TIME As Integer = 60

#End Region ' Class Level Members

#Region "How To Sample Code"
        ''' <summary>
        ''' This sample shows how to send a bulk email and monitor its progress.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user is prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptforDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy is properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    CreateRequiredRecords()

                    '				#Region "Create and send SendBulkEmail"

                    Console.WriteLine()
                    Console.WriteLine("Creating and sending SendBulkEmail.")

                    ' Get a system user to use as the sender.
                    Dim emailSenderRequest As New WhoAmIRequest()
                    Dim emailSenderResponse As WhoAmIResponse =
                        TryCast(_serviceProxy.Execute(emailSenderRequest), WhoAmIResponse)

                    ' Set trackingId for bulk mail request.
                    Dim trackingId As Guid = Guid.NewGuid()

                    ' Create a query expression for the bulk operation to use to retrieve 
                    ' the contacts in the email list.                    
                    Dim condition As New ConditionExpression("contactid", ConditionOperator.In, _contactsIds)

                    Dim filterExpression_Renamed As New FilterExpression()
                    filterExpression_Renamed.AddCondition(condition)

                    Dim returnColumns As New ColumnSet()
                    returnColumns.AddColumn("contactid")

                    Dim queryRequest As New QueryExpression() With
                        {
                            .ColumnSet = returnColumns,
                            .EntityName = Contact.EntityLogicalName,
                            .Criteria = filterExpression_Renamed
                        }

                    ' Set the Sender.
                    ' Set the RegardingId - this field is required.
                    ' Use a built-in Microsoft Dynamics CRM email template.
                    ' NOTE: The email template's "template type" must match the type of 
                    ' customers in the email list.  Our list contains contacts, so our 
                    ' template must be for contacts.
                    Dim bulkMailRequest As New SendBulkMailRequest() With
                        {
                            .Query = queryRequest,
                            .Sender = New EntityReference(SystemUser.EntityLogicalName,
                                                          emailSenderResponse.UserId),
                            .RegardingId = Guid.Empty,
                            .RegardingType = SystemUser.EntityLogicalName,
                            .TemplateId = New Guid("07B94C1D-C85F-492F-B120-F0A743C540E6"),
                            .RequestId = trackingId
                        }

                    ' Execute the async bulk email request.
                    Dim resp As SendBulkMailResponse =
                        CType(_serviceProxy.Execute(bulkMailRequest), SendBulkMailResponse)

                    Console.WriteLine("  Sent Bulk Email.")
                    '				#End Region

                    '				#Region "Monitoring SendBulkEmail"

                    Console.WriteLine()
                    Console.WriteLine("Starting monitoring process..")

                    ' Now that we've executed the bulk operation, we need to retrieve it 
                    ' using our tracking Id.

                    Dim bulkQuery As New QueryByAttribute() With
                        {
                            .EntityName = AsyncOperation.EntityLogicalName,
                            .ColumnSet = New ColumnSet(New String() {"requestid", "statecode"})
                        }
                    bulkQuery.AddAttributeValue("requestid", trackingId)

                    ' Retrieve the bulk email async operation.
                    Dim aResponse As EntityCollection = _serviceProxy.RetrieveMultiple(bulkQuery)

                    Console.WriteLine("  Retrieved Bulk Email Async Operation.")

                    ' Monitor the async operation via polling.
                    Dim secondsTicker As Integer = ARBITRARY_MAX_POLLING_TIME

                    Dim createdBulkMailOperation As AsyncOperation = Nothing

                    Console.WriteLine("  Checking operation's state for " _
                                      &amp; ARBITRARY_MAX_POLLING_TIME &amp; " seconds.")
                    Console.WriteLine()

                    Do While secondsTicker > 0
                        ' Make sure the async operation was retrieved.
                        If aResponse.Entities.Count > 0 Then
                            ' Grab the one bulk operation that has been created.
                            createdBulkMailOperation = CType(aResponse.Entities(0), AsyncOperation)

                            ' Check the operation's state.
                            If createdBulkMailOperation.StateCode.Value <> AsyncOperationState.Completed Then
                                ' The operation has not yet completed. 
                                ' Wait a second for the status to change.
                                System.Threading.Thread.Sleep(1000)
                                secondsTicker -= 1

                                ' Retrieve a fresh version of the bulk delete operation.
                                aResponse = _serviceProxy.RetrieveMultiple(bulkQuery)
                            Else
                                ' Stop polling because the operation's state is now complete.
                                secondsTicker = 0
                            End If
                        Else
                            ' Wait a second for the async operation to activate.
                            System.Threading.Thread.Sleep(1000)
                            secondsTicker -= 1

                            ' Retrieve the entity again.
                            aResponse = _serviceProxy.RetrieveMultiple(bulkQuery)
                        End If
                    Loop

                    ' When the bulk email operation has completed, all sent emails will 
                    ' have a status of "Pending Send" and will be picked up by your email 
                    ' router.  Alternatively, you can then use BackgroundSendEmail to download
                    ' all the emails created with the SendBulkEmail message. 
                    ' See the BackgroundSendEmail sample for an example.
                    '				#End Region

                    '				#Region "Check success"

                    ' Validate that the async operation succeeded.
                    If createdBulkMailOperation.StateCode.Value = AsyncOperationState.Completed Then
                        Console.WriteLine("Operation Completed.")
                    Else
                        Console.WriteLine("Operation not completed yet.")
                    End If

                    '				#End Region

                    DeleteRequiredRecords(promptforDelete)
                End Using
                ' Catch any service fault exceptions that Microsoft Dynamics CRM throws.
            Catch fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                ' You can handle an exception here or pass it back to the calling method.
                Throw
            End Try
        End Sub

        ''' <summary>
        ''' Creates any entity records that this sample requires.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            Console.WriteLine("Creating contacts records...")

            Dim emailContact1 As New Contact() With
                {
                    .FirstName = "Adam",
                    .LastName = "Carter",
                    .EMailAddress1 = "someone@example.com"
                }

            ' Create the contact1.
            _contactsIds.Add(_serviceProxy.Create(emailContact1))
            Console.WriteLine("Contact1 created.")

            Dim emailContact2 As New Contact() With
                {
                    .FirstName = "Adina",
                    .LastName = "Hagege",
                    .EMailAddress1 = "someone@example.com"
                }

            ' Create the contact2.
            _contactsIds.Add(_serviceProxy.Create(emailContact2))
            Console.WriteLine("Contact2 created.")

        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                ' Ask the user if the created entities should be deleted.
                Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse
                                 answer.StartsWith("Y") OrElse
                                 answer = String.Empty)
            End If

            If deleteRecords Then
                ' Delete the contacts.
                For Each contactId In _contactsIds
                    _serviceProxy.Delete(Contact.EntityLogicalName, contactId)
                Next contactId
                Console.WriteLine("Contacts have been deleted.")
            End If
        End Sub
#End Region ' How To Sample Code

#Region "Main method"

        ''' <summary>
        ''' Standard Main() method used by most SDK samples.
        ''' </summary>
        ''' <param name="args"></param>
        Public Shared Sub Main(ByVal args() As String)
            Try
                ' Obtain the target organization's web address and client logon 
                ' credentials from the user.
                Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

                Dim app As New SendBulkEmailAndMonitor()
                app.Run(config, True)

            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
                Console.WriteLine("Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
            Catch ex As TimeoutException
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Message: {0}", ex.Message)
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
            Catch ex As Exception
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine(ex.Message)

                ' Display the details of the inner exception.
                If ex.InnerException IsNot Nothing Then
                    Console.WriteLine(ex.InnerException.Message)

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) =
                        TryCast(ex.InnerException, 
                            FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
                    If fe IsNot Nothing Then
                        Console.WriteLine("Timestamp: {0}", fe.Detail.Timestamp)
                        Console.WriteLine("Code: {0}", fe.Detail.ErrorCode)
                        Console.WriteLine("Message: {0}", fe.Detail.Message)
                        Console.WriteLine("Trace: {0}", fe.Detail.TraceText)
                        Console.WriteLine("Inner Fault: {0}",
                                          If(Nothing Is fe.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
                    End If
                End If
                ' Additional exceptions to catch: SecurityTokenValidationException, ExpiredSecurityTokenException,
                ' SecurityAccessDeniedException, MessageSecurityException, and SecurityNegotiationException.
            Finally
                Console.WriteLine("Press <Enter> to exit.")
                Console.ReadLine()
            End Try
        End Sub
#End Region ' Main method
    End Class
End Namespace

' </snippetsendbulkemailandmonitor>