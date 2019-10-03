' <snippetassignrecordtoteam>


Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery


Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Crm.Sdk.Messages



Namespace Microsoft.Crm.Sdk.Samples

    ''' <summary>
    ''' Demonstrates how to assign a record to a team.
    ''' If you want to run this sample repeatedly, you have the option to 
    ''' delete all the records created at the end of execution.
    ''' </summary>
    Public Class AssignRecordToTeam
        #Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service interface.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy
        Private _service As IOrganizationService

        ' Define the IDs needed for this sample.
        Public _accountId As Guid
        Public _teamId As Guid
        Public _roleId As Guid

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Create a team, an account and a role.
        ''' Add read account privileges to the role.
        ''' Assign the role to the team so that they can read the account.
        ''' Assign the account to the team.
        ''' Optionally delete the account, team and role records.
        ''' <para name="organizationFriendlyName">The friendly name of 
        ''' the target organization.</para>
        ''' <para name="discoveryServer">The name of the discovery server.</para>
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

                    ' Assign the account to a team.                
                    Dim assignRequest As New AssignRequest() With {.Assignee = New EntityReference With { _
                            .LogicalName = Team.EntityLogicalName, .Id = _teamId}, _
                            .Target = New EntityReference(Account.EntityLogicalName, _accountId)}

                    _service.Execute(assignRequest)

                    Console.WriteLine("The account is owned by the team.")

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
        ''' Create a team, an account and a role.
        ''' Add read account privileges to the role.
        ''' Assign the role to the team so that they can read the account.
        ''' Assign the account to the team.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            ' Instantiate an account entity record and set its property values.
            ' See the Entity Metadata topic in the SDK documentation to determine 
            ' which attributes must be set for each entity.
            Dim setupAccount As Account = New Account With {.Name = "Example Account"}

            ' Create the account record.
            _accountId = _service.Create(setupAccount)
            Console.WriteLine("Created {0}", setupAccount.Name)

            ' Retrieve the default business unit needed to create the team and role.
            Dim queryDefaultBusinessUnit As QueryExpression = New QueryExpression With { _
                .EntityName = BusinessUnit.EntityLogicalName, .ColumnSet = New ColumnSet("businessunitid"), _
                .Criteria = New FilterExpression()}

            queryDefaultBusinessUnit.Criteria.AddCondition("parentbusinessunitid", ConditionOperator.Null)

            Dim defaultBusinessUnit As BusinessUnit = _
                CType(_service.RetrieveMultiple(queryDefaultBusinessUnit).Entities(0), BusinessUnit)

            ' Instantiate a team entity record and set its property values.
            ' See the Entity Metadata topic in the SDK documentation to determine 
            ' which attributes must be set for each entity.
            Dim setupTeam As Team = New Team With
                                    {
                                        .Name = "Example Team",
                                        .BusinessUnitId = New EntityReference(BusinessUnit.EntityLogicalName,
                                                                              defaultBusinessUnit.Id)
                                    }

            ' Create a team record.
            _teamId = _service.Create(setupTeam)
            Console.WriteLine("Created {0}", setupTeam.Name)

            ' Instantiate a role entity record and set its property values.
            ' See the Entity Metadata topic in the SDK documentation to determine 
            ' which attributes must be set for each entity.
            Dim setupRole As Role = New Role With
                                    {
                                        .Name = "Example Role",
                                        .BusinessUnitId = New EntityReference(BusinessUnit.EntityLogicalName,
                                                                              defaultBusinessUnit.Id)
                                    }

            ' Create a role record. Typically you would use an existing role that has the
            ' the correct privileges. For this sample we need to be sure the role has
            ' at least the privilege to read account records.
            _roleId = _service.Create(setupRole)
            Console.WriteLine("Created {0}", setupRole.Name)

            ' Create a query expression to find the prvReadAccountPrivilege.
            Dim queryReadAccountPrivilege As QueryExpression = New QueryExpression With { _
                .EntityName = Privilege.EntityLogicalName, .ColumnSet = New ColumnSet("privilegeid", "name"), _
                .Criteria = New FilterExpression()}
            queryReadAccountPrivilege.Criteria.AddCondition("name", ConditionOperator.Equal, "prvReadAccount")

            ' Retrieve the prvReadAccount privilege.
            Dim readAccountPrivilege As Entity = _service.RetrieveMultiple(queryReadAccountPrivilege)(0)
            Console.WriteLine("Retrieved {0}", readAccountPrivilege.Attributes("name"))

            ' Add the prvReadAccount privilege to the example roles to assure the
            ' team can read accounts.
            Dim addPrivilegesRequest As AddPrivilegesRoleRequest = New AddPrivilegesRoleRequest With { _
                .RoleId = _roleId, .Privileges = {New RolePrivilege With {.PrivilegeId = readAccountPrivilege.Id}}}
                    ' Grant prvReadAccount privilege.
            _service.Execute(addPrivilegesRequest)

            Console.WriteLine("Added privilege to role")

            ' Add the role to the team.
            _service.Associate(Team.EntityLogicalName, _teamId, New Relationship("teamroles_association"), _
                               New EntityReferenceCollection() From {New EntityReference(Role.EntityLogicalName, _roleId)})

            Console.WriteLine("Assigned team to role")

            ' It takes some time for the privileges to propagate to the team. Delay the
            ' application until the privilege has been assigned.
            Dim teamLacksPrivilege As Boolean = True
            Do While teamLacksPrivilege
                Dim retrieveTeamPrivilegesRequest As RetrieveTeamPrivilegesRequest = _
                    New RetrieveTeamPrivilegesRequest With {.TeamId = _teamId}

                Dim retrieveTeamPrivilegesResponse As RetrieveTeamPrivilegesResponse = _
                    CType(_service.Execute(retrieveTeamPrivilegesRequest), RetrieveTeamPrivilegesResponse)

                For Each rp As RolePrivilege In retrieveTeamPrivilegesResponse.RolePrivileges
                    If rp.PrivilegeId = readAccountPrivilege.Id Then
                        teamLacksPrivilege = False
                        Exit For
                    Else
                        System.Threading.Thread.CurrentThread.Join(500)
                    End If
                Next rp
            Loop

            Return
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
                _service.Delete("account", _accountId)
                _service.Delete("team", _teamId)
                _service.Delete("role", _roleId)


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

                Dim app As New AssignRecordToTeam()
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
            Finally

                Console.WriteLine("Press <Enter> to exit.")
                Console.ReadLine()
            End Try

        End Sub
        #End Region ' Main

    End Class
End Namespace

' </snippetassignrecordtoteam>