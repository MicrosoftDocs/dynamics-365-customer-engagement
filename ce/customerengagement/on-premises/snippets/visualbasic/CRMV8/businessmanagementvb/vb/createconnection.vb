' <snippetcreateconnection>


Imports Microsoft.VisualBasic
Imports System
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
    ''' This sample shows how to create a connection between two entities.
    ''' </summary>
    Public Class CreateConnection
#Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy

        ' Define the IDs needed for this sample.
        Public _connectionRoleId As Guid
        Public _connectionId As Guid
        Public _accountId As Guid
        Public _contactId As Guid

#End Region ' Class Level Members

#Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Call the method to create any data that this sample requires.
        ''' Create a new connection between the account and the contact.
        ''' Optionally delete any entity records that were created for this sample.
        ''' </summary>
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration,
                       ByVal promptForDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()


                    ' Call the method to create any data that this sample requires.
                    CreateRequiredRecords()

                    ' Create a connection between the account and the contact.
                    ' Assign a connection role to a record.
                    Dim newConnection As Connection =
                        New Connection With
                        {
                            .Record1Id =
                            New EntityReference(Account.EntityLogicalName,
                                                             _accountId),
                            .Record1RoleId =
                            New EntityReference(ConnectionRole.EntityLogicalName,
                                                _connectionRoleId),
                            .Record2RoleId =
                            New EntityReference(ConnectionRole.EntityLogicalName,
                                                _connectionRoleId),
                            .Record2Id =
                            New EntityReference(Contact.EntityLogicalName,
                                                             _contactId)
                        }

                    _connectionId = _serviceProxy.Create(newConnection)

                    Console.WriteLine("Created a connection between the account and the contact.")

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
        ''' Create a new connectionrole instance. 
        ''' Create related Connection Role Object Type Code records
        ''' for the account and the contact entities.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            ' Create a Connection Role for account and contact
            Dim newConnectionRole As ConnectionRole =
                New ConnectionRole With
                {
                    .Name = "Example Connection Role",
                    .Category =
                    New OptionSetValue(CInt(Fix(connectionrole_category.Business)))
                }

            _connectionRoleId = _serviceProxy.Create(newConnectionRole)
            Console.WriteLine("Created {0}.", newConnectionRole.Name)

            ' Create a related Connection Role Object Type Code record for Account
            Dim newAccountConnectionRoleTypeCode As ConnectionRoleObjectTypeCode =
                New ConnectionRoleObjectTypeCode With
                {
                    .ConnectionRoleId =
                    New EntityReference(ConnectionRole.EntityLogicalName,
                                        _connectionRoleId),
                    .AssociatedObjectTypeCode = Account.EntityLogicalName
                }

            _serviceProxy.Create(newAccountConnectionRoleTypeCode)
            Console.WriteLine("Created a related Connection Role Object Type Code record for Account.")

            ' Create a related Connection Role Object Type Code record for Contact
            Dim newContactConnectionRoleTypeCode As ConnectionRoleObjectTypeCode =
                New ConnectionRoleObjectTypeCode With
                {
                    .ConnectionRoleId =
                    New EntityReference(ConnectionRole.EntityLogicalName,
                                                            _connectionRoleId),
                    .AssociatedObjectTypeCode = Contact.EntityLogicalName
                }

            _serviceProxy.Create(newContactConnectionRoleTypeCode)
            Console.WriteLine("Created a related Connection Role Object Type Code record for Contact.")

            ' Associate the connection role with itself.
            Dim associateConnectionRoles As AssociateRequest =
                New AssociateRequest With
                {
                    .Target = New EntityReference(ConnectionRole.EntityLogicalName,
                                                  _connectionRoleId),
                    .RelatedEntities =
                    New EntityReferenceCollection() From
                    {
                        New EntityReference(ConnectionRole.EntityLogicalName, _connectionRoleId)
                    },
                    .Relationship = New Relationship() With
                                    {
                                        .PrimaryEntityRole = EntityRole.Referencing,
                                        .SchemaName = "connectionroleassociation_association"
                                    }
                }
            ' The name of the relationship connection role association 
            ' relationship in MS CRM.

            _serviceProxy.Execute(associateConnectionRoles)
            Console.WriteLine("Associated the connection role with itself.")

            ' Create an Account
            Dim setupAccount As Account = New Account With {.Name = "Example Account"}
            _accountId = _serviceProxy.Create(setupAccount)
            Console.WriteLine("Created {0}.", setupAccount.Name)

            ' Create a Contact
            Dim setupContact As Contact = New Contact With {.LastName = "Example Contact"}
            _contactId = _serviceProxy.Create(setupContact)
            Console.WriteLine("Created {0}.", setupContact.LastName)

            Return
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim toBeDeleted As Boolean = True

            If prompt Then
                ' Ask the user if the created entities should be deleted.
                Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") _
                    OrElse answer.StartsWith("Y") _
                    OrElse answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
            End If

            If toBeDeleted Then
                _serviceProxy.Delete(Connection.EntityLogicalName, _connectionId)
                _serviceProxy.Delete(Account.EntityLogicalName, _accountId)
                _serviceProxy.Delete(Contact.EntityLogicalName, _contactId)
                _serviceProxy.Delete(ConnectionRole.EntityLogicalName, _connectionRoleId)

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
                Dim config As ServerConnection.Configuration =
                    serverConnect.GetServerConfiguration()

                Dim app As New CreateConnection()
                app.Run(config, True)

            Catch ex As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault)
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Timestamp: {0}", ex.Detail.Timestamp)
                Console.WriteLine("Code: {0}", ex.Detail.ErrorCode)
                Console.WriteLine("Message: {0}", ex.Detail.Message)
                Console.WriteLine("Plugin Trace: {0}", ex.Detail.TraceText)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.Detail.InnerFault, "No Inner Fault", "Has Inner Fault"))
            Catch ex As System.TimeoutException
                Console.WriteLine("The application terminated with an error.")
                Console.WriteLine("Message: {0}", ex.Message)
                Console.WriteLine("Stack Trace: {0}", ex.StackTrace)
                Console.WriteLine("Inner Fault: {0}",
                                  If(Nothing Is ex.InnerException.Message, "No Inner Fault", ex.InnerException.Message))
            Catch ex As System.Exception
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
                        Console.WriteLine("Plugin Trace: {0}", fe.Detail.TraceText)
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
#End Region ' Main
    End Class
End Namespace

' </snippetcreateconnection>