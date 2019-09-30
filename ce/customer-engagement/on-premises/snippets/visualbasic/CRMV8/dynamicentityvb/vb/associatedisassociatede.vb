' <snippetassociatedisassociatede>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    Public Class AssociateDisassociateDE
        #Region "Class Level Members"
        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy
        Private _service As IOrganizationService

        ' Define the IDs needed for this sample.
        Private _contactId As Guid
        Private _account1Id As Guid
        Private _account2Id As Guid
        Private _account3Id As Guid

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Create a team, a queue and a role.
        ''' Add read queue privileges to the role.
        ''' Assign the role to the team so that they can read the queue.
        ''' Assign the queue to the team.
        ''' Optionally delete any entity records that were created for this sample.
         ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptForDelete">When True, the user will be prompted to delete
        ''' all created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    _service = CType(_serviceProxy, IOrganizationService)

                    ' Call the method to create any data that this sample requires.
                    CreateRequiredRecords()

                    ' The account ID would typically be passed in as an argument or determined by a query.
                    ' The contact ID would typically be passed in as an argument or determined by a query.
                    ' Associate the accounts to the contact record.

                    'Create a collection of the entity ids that will be associated to the contact.
                    Dim relatedEntities As New EntityReferenceCollection()
                    relatedEntities.Add(New EntityReference("account", _account1Id))
                    relatedEntities.Add(New EntityReference("account", _account2Id))
                    relatedEntities.Add(New EntityReference("account", _account3Id))

                    ' Create an object that defines the relationship between the contact and account.
                    Dim relationship As New Relationship("account_primary_contact")

                    'Associate the contact with the 3 accounts.
                    _service.Associate("contact", _contactId, relationship, relatedEntities)

                    Console.WriteLine("The entities have been associated.")

                    'Disassociate the records.
                    _service.Disassociate("contact", _contactId, relationship, relatedEntities)


                    Console.WriteLine("The entities have been disassociated.")

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
        ''' Create a team, a queue and a role.
        ''' Add read queue privileges to the role.
        ''' Assign the role to the team so that they can read the queue.
        ''' Assign the queue to the team.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            ' Instantiate a contact entity record and set its property values.
            ' See the Entity Metadata topic in the SDK documentatio to determine 
            ' which attributes must be set for each entity.
            Dim setupContact As New Entity("contact")
            setupContact("firstname") = "John"
            setupContact("lastname") = "Doe"

            _contactId = _service.Create(setupContact)
            Console.WriteLine("Created {0} {1}", setupContact("firstname"), setupContact("lastname"))

            ' Instantiate an account entity record and set its property values.
            Dim setupAccount1 As New Entity("account")
            setupAccount1("name") = "Example Account 1"

            _account1Id = _service.Create(setupAccount1)
            Console.WriteLine("Created {0}", setupAccount1("name"))

            Dim setupAccount2 As New Entity("account")
            setupAccount2("name") = "Example Account 2"

            _account2Id = _service.Create(setupAccount2)
            Console.WriteLine("Created {0}", setupAccount2("name"))

            Dim setupAccount3 As New Entity("account")
            setupAccount3("name") = "Example Account 3"

            _account3Id = _service.Create(setupAccount3)
            Console.WriteLine("Created {0}", setupAccount3("name"))
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty)
            End If

            If deleteRecords Then
                _service.Delete("account", _account1Id)
                _service.Delete("account", _account2Id)
                _service.Delete("account", _account3Id)

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

                Dim app As New AssignQueueToTeamDE()
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

' </snippetassociatedisassociatede>