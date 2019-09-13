' <snippetassignsecurityroletoteam>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery
Imports Microsoft.Xrm.Sdk.Client

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages



Namespace Microsoft.Crm.Sdk.Samples

    ''' <summary>
    ''' Demonstrates how to assign a security role to a team.
    ''' </summary>
    Public Class AssignSecurityRoleToTeam
        #Region "Class Level Members"


        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy
        Private _service As IOrganizationService

        ' Define the IDs needed for this sample.
        Private _teamId As Guid
        Private _roleId As Guid
        Public Const _roleName As String = "An Example Role"

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Retrieve a role from CRM.
        ''' Assign that role to a team.
        ''' <param name="organizationFriendlyName">The friendly name of 
        ''' the target organization.</param>
        ''' <param name="discoveryServer">The name of the discovery server.</param>
        ''' <param name="promptForDelete">Indicates whether to prompt the user 
        ''' to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    _service = CType(_serviceProxy, IOrganizationService)

                    ' Call the method to create any data that this sample requires.
                    CreateRequiredRecords()


                    ' Retrieve a role from CRM.
                    Dim query As QueryExpression = New QueryExpression With { _
                        .EntityName = Role.EntityLogicalName, .ColumnSet = New ColumnSet("roleid")}
                    query.Criteria = New FilterExpression()
                    query.Criteria.AddCondition("name", ConditionOperator.Equal, {_roleName})
                            ' You would replace the condition below with an actual role
                            ' name, or skip this query if you had a role id.

                    Dim role_renamed As Role = _service.RetrieveMultiple(query).Entities.Cast(Of Role)().First()


                    ' Add the role to the team.
                    _service.Associate(Team.EntityLogicalName, _teamId, New Relationship("teamroles_association"), _
                                       New EntityReferenceCollection() From {New EntityReference(Role.EntityLogicalName, _roleId)})

                    Console.WriteLine("Assigned role to team")

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
        ''' Creates a team and a role.
        ''' </summary>
        Public Sub CreateRequiredRecords()

            ' Retrieve the default business unit needed to create the team and role.
            Dim query As QueryExpression = New QueryExpression With {.EntityName = BusinessUnit.EntityLogicalName, _
                                                                     .ColumnSet = New ColumnSet("businessunitid")}
            query.Criteria.AddCondition(New ConditionExpression("parentbusinessunitid", ConditionOperator.Null))

            Dim defaultBusinessUnit As BusinessUnit = _service.RetrieveMultiple(query).Entities.Cast(Of BusinessUnit)().FirstOrDefault()

            ' Instantiate a team entity record and set its property values.
            ' See the Entity Metadata topic in the SDK documentation  
            ' to determine which attributes must be set for each entity.
            Dim setupTeam As Team = New Team With { _
                .Name = "An Example Team", .BusinessUnitId = New EntityReference(BusinessUnit.EntityLogicalName, defaultBusinessUnit.Id)}

            ' Create a team record.
            _teamId = _service.Create(setupTeam)
            Console.WriteLine("Created team '{0}'", setupTeam.Name)

            ' Instantiate a role entity record and set its property values.
            ' See the Entity Metadata topic in the SDK documentation  
            ' to determine which attributes must be set for each entity.
            Dim setupRole As Role = New Role With { _
                .Name = _roleName, .BusinessUnitId = New EntityReference(BusinessUnit.EntityLogicalName, defaultBusinessUnit.Id)}

            ' Create the role record. 
            _roleId = _service.Create(setupRole)
            Console.WriteLine("Created role '{0}'", setupRole.Name)

            ' Define an array listing the privileges that we want to add to the role
            Dim privilegesToAdd() As String = { "prvReadContact", "prvCreateContact", "prvReadAccount", "prvCreateAccount" }

            ' Query for the privileges we want to add to the role
            Dim queryPrivileges As QueryExpression = New QueryExpression With { _
                .EntityName = Privilege.EntityLogicalName, .ColumnSet = New ColumnSet("privilegeid", "name"), _
                .Criteria = New FilterExpression()}
            queryPrivileges.Criteria.AddCondition("name", ConditionOperator.In, privilegesToAdd)

            Dim returnedPrivileges As DataCollection(Of Entity) = _service.RetrieveMultiple(queryPrivileges).Entities
            Console.WriteLine("Retrieved privileges to add to role")

            ' Define a list to hold the RolePrivileges we'll need to add
            Dim rolePrivileges As New List(Of RolePrivilege)()

            For Each privilege As Privilege In returnedPrivileges
                Dim rolePrivilege As New RolePrivilege(CInt(PrivilegeDepth.Local), privilege.PrivilegeId.Value)
                rolePrivileges.Add(rolePrivilege)
            Next privilege

            ' Add the retrieved privileges to the example role.
            Dim addPrivilegesRequest As AddPrivilegesRoleRequest = New AddPrivilegesRoleRequest With { _
                .RoleId = _roleId, .Privileges = rolePrivileges.ToArray()}
            _service.Execute(addPrivilegesRequest)
            Console.WriteLine("Added privileges to role")
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user 
        ''' to delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n)")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
            End If

            If deleteRecords Then
                _service.Delete(Team.EntityLogicalName, _teamId)
                _service.Delete(Role.EntityLogicalName, _roleId)

                Console.WriteLine("Entity records have been deleted.")
            End If
        End Sub

        #End Region ' How To Sample Code

        #Region "Main"
        ''' <summary>
        ''' Main. Runs the sample and provides error output.
        ''' <param name="args">Array of arguments to Main method.</param>
        ''' </summary>
        Public Shared Sub Main(ByVal args() As String)

            Try
                ' Obtain the target organization's Web address and client logon 
                ' credentials from the user.
                Dim serverConnect As New ServerConnection()
                Dim config As ServerConnection.Configuration = serverConnect.GetServerConfiguration()

                Dim app As New AssignSecurityRoleToTeam()
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

' </snippetassignsecurityroletoteam>