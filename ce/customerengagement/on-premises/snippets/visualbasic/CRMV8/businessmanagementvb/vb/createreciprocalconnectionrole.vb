' <snippetcreatereciprocalconnectionrole>


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
    ''' This Sample shows how to create a reciprocal connection role.
    ''' </summary>
    Public Class CreateReciprocalConnectionRole
#Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy

        ' Define the IDs needed for this sample.
        Public _connectionRole1Id As Guid
        Public _connectionRole2Id As Guid

#End Region ' Class Level Members

#Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Create the connection role instances.
        ''' Associate the connection roles.
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

                    ' Create the Connection Role 1
                    Dim newConnectionRole1 As ConnectionRole =
                        New ConnectionRole With
                        {
                            .Name = "Example Connection Role 1",
                            .Category =
                            New OptionSetValue(CInt(Fix(connectionrole_category.Business)))
                        }

                    _connectionRole1Id = _serviceProxy.Create(newConnectionRole1)
                    Console.WriteLine("Created {0}.", newConnectionRole1.Name)

                    ' Create a related Connection Role Object Type Code record for Account
                    Dim newAccountConnectionRole1TypeCode As ConnectionRoleObjectTypeCode =
                        New ConnectionRoleObjectTypeCode With
                        {
                            .ConnectionRoleId =
                            New EntityReference(ConnectionRole.EntityLogicalName,
                                                                    _connectionRole1Id),
                            .AssociatedObjectTypeCode = Account.EntityLogicalName
                        }

                    _serviceProxy.Create(newAccountConnectionRole1TypeCode)
                    Console.WriteLine("Created a related Connection Role 1 Object Type Code record for Account.")

                    ' Create a related Connection Role Object Type Code record for Contact
                    Dim newContactConnectionRole1TypeCode As ConnectionRoleObjectTypeCode =
                        New ConnectionRoleObjectTypeCode With
                        {
                            .ConnectionRoleId =
                            New EntityReference(ConnectionRole.EntityLogicalName,
                                                                    _connectionRole1Id),
                            .AssociatedObjectTypeCode = Contact.EntityLogicalName
                        }

                    _serviceProxy.Create(newContactConnectionRole1TypeCode)
                    Console.WriteLine("Created a related Connection Role 1 Object Type Code record for Contact.")

                    ' Create the Connection Role 2
                    Dim newConnectionRole2 As ConnectionRole =
                        New ConnectionRole With
                        {
                            .Name = "Example Connection Role 2",
                            .Category =
                            New OptionSetValue(CInt(Fix(connectionrole_category.Business)))
                        }

                    _connectionRole2Id = _serviceProxy.Create(newConnectionRole2)
                    Console.WriteLine("Created {0}.", newConnectionRole2.Name)

                    ' Create a related Connection Role 2 Object Type Code record for Account
                    Dim newAccountConnectionRole2TypeCode As ConnectionRoleObjectTypeCode =
                        New ConnectionRoleObjectTypeCode With
                        {
                            .ConnectionRoleId =
                            New EntityReference(ConnectionRole.EntityLogicalName,
                                                                    _connectionRole2Id),
                            .AssociatedObjectTypeCode = Account.EntityLogicalName
                        }

                    _serviceProxy.Create(newAccountConnectionRole2TypeCode)
                    Console.WriteLine("Created a related Connection Role 2 Object Type Code record for Account.")

                    ' Create a related Connection Role 2 Object Type Code record for Contact
                    Dim newContactConnectionRole2TypeCode As ConnectionRoleObjectTypeCode =
                        New ConnectionRoleObjectTypeCode With
                        {
                            .ConnectionRoleId =
                            New EntityReference(ConnectionRole.EntityLogicalName,
                                                _connectionRole2Id),
                            .AssociatedObjectTypeCode = Contact.EntityLogicalName
                        }

                    _serviceProxy.Create(newContactConnectionRole2TypeCode)
                    Console.WriteLine("Created a related Connection Role 2 Object Type Code record for Contact.")
                    ' Associate the connection roles
                    Dim associateConnectionRoles As AssociateRequest =
                        New AssociateRequest With
                        {
                            .Target = New EntityReference(ConnectionRole.EntityLogicalName,
                                                          _connectionRole1Id),
                            .RelatedEntities =
                            New EntityReferenceCollection() From
                            {
                                New EntityReference(ConnectionRole.EntityLogicalName,
                                                    _connectionRole2Id)
                            },
                            .Relationship =
                            New Relationship() With
                            {
                                .PrimaryEntityRole = EntityRole.Referencing,
                                .SchemaName = "connectionroleassociation_association"
                            }
                        }
                    ' The name of the relationship connection role association 
                    ' relationship in MS CRM

                    _serviceProxy.Execute(associateConnectionRoles)
                    Console.WriteLine("Associated the connection roles.")

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
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim toBeDeleted As Boolean = True

            If prompt Then
                ' Ask the user if the created entities should be deleted.
                Console.Write(vbLf &amp; "Do you want these entity records deleted? (y/n) [y]: ")
                Dim answer As String = Console.ReadLine()
                If answer.StartsWith("y") OrElse answer.StartsWith("Y") OrElse answer = String.Empty Then
                    toBeDeleted = True
                Else
                    toBeDeleted = False
                End If
            End If

            If toBeDeleted Then
                _serviceProxy.Delete(ConnectionRole.EntityLogicalName, _connectionRole1Id)
                _serviceProxy.Delete(ConnectionRole.EntityLogicalName, _connectionRole2Id)

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

                Dim app As New CreateReciprocalConnectionRole()
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

' </snippetcreatereciprocalconnectionrole>