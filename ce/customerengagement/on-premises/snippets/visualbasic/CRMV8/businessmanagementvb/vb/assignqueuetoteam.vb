' <snippetassignqueuetoteam>


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
    ''' Demonstrates how to assign a queue to a team.
    ''' If you want to run this sample repeatedly, you have the option to 
    ''' delete all the records created at the end of execution.
    ''' </summary>
    Public Class AssignQueueToTeam
        #Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service interface.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy

        ' Define the IDs needed for this sample.
        Public _teamId As Guid
        Public _queueId As Guid
        Public _roleId As Guid

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Create a team, a queue and a role.
        ''' Add read queue privileges to the role.
        ''' Assign the role to the team so that they can read the queue.
        ''' Assign the queue to the team.
        ''' Optionally delete any entity records that were created for this sample.
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



                    ' Call the method to create any data that this sample requires.
                    CreateRequiredRecords()


                    ' Assign the queue to a team.
                    _serviceProxy.Associate(Queue.EntityLogicalName, _queueId, New Relationship("queue_team"), _
                                            New EntityReferenceCollection() From {New EntityReference(Team.EntityLogicalName, _teamId)})




                    Console.WriteLine("The queue is owned by the team.")

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
            ' Instantiate a queue entity record and set its property values.
            ' See the Entity Metadata topic in the SDK documentatio to determine 
            ' which attributes must be set for each entity.
            Dim setupQueue As Queue = New Queue With {.Name = "Example Queue", .Description = "This is an example queue."}

            ' Create the queue record.
            _queueId = _serviceProxy.Create(setupQueue)
            Console.WriteLine("Created {0}", setupQueue.Name)

            ' Retrieve the default business unit needed to create the team and role.
            Dim queryDefaultBusinessUnit As QueryExpression = New QueryExpression With { _
                .EntityName = BusinessUnit.EntityLogicalName, .ColumnSet = New ColumnSet("businessunitid"), _
                .Criteria = New FilterExpression()}

            queryDefaultBusinessUnit.Criteria.AddCondition("parentbusinessunitid", ConditionOperator.Null)

            Dim defaultBusinessUnit As BusinessUnit = _
                CType(_serviceProxy.RetrieveMultiple(queryDefaultBusinessUnit).Entities(0), BusinessUnit)

            ' Instantiate a team entity record and set its property values.
            ' See the Entity Metadata topic in the SDK documentatio to determine 
            ' which attributes must be set for each entity.
            Dim setupTeam As Team = New Team With { _
                .Name = "Example Team", .BusinessUnitId = New EntityReference(BusinessUnit.EntityLogicalName, defaultBusinessUnit.Id)}

            ' Create a team record.
            _teamId = _serviceProxy.Create(setupTeam)
            Console.WriteLine("Created {0}", setupTeam.Name)

            ' Instantiate a role entity record and set its property values.
            ' See the Entity Metadata topic in the SDK documentatio to determine 
            ' which attributes must be set for each entity.
            Dim setupRole As Role = New Role With { _
                .Name = "Example Role", .BusinessUnitId = New EntityReference(BusinessUnit.EntityLogicalName, defaultBusinessUnit.Id)}

            ' Create a role record. Typically you would use an exisitng role that has the
            ' the correct privileges. For this sample we need to be sure the role has
            ' at least the privilege to read queue records.
            _roleId = _serviceProxy.Create(setupRole)
            Console.WriteLine("Created {0}", setupRole.Name)

            ' Create a query expression to find the prvReadQueuePrivilege.
            Dim queryReadQueuePrivilege As QueryExpression = New QueryExpression With { _
                .EntityName = Privilege.EntityLogicalName, .ColumnSet = New ColumnSet("privilegeid", "name"), _
                .Criteria = New FilterExpression()}
            queryReadQueuePrivilege.Criteria.AddCondition("name", ConditionOperator.Equal, "prvReadQueue")

            ' Retrieve the prvReadQueue privilege.
            Dim readQueuePrivilege As Privilege = CType(_serviceProxy.RetrieveMultiple(queryReadQueuePrivilege).Entities(0), Privilege)
            Console.WriteLine("Retrieved {0}", readQueuePrivilege.Name)

            ' Add the prvReadQueue privilege to the example role.
            Dim addPrivilegesRequest As AddPrivilegesRoleRequest = New AddPrivilegesRoleRequest With { _
                .RoleId = _roleId, .Privileges = New Microsoft.Crm.Sdk.Messages.RolePrivilege() { _
                    New Microsoft.Crm.Sdk.Messages.RolePrivilege With {.PrivilegeId = readQueuePrivilege.Id}}}
                        ' Grant prvReadQueue privilege.
            _serviceProxy.Execute(addPrivilegesRequest)
            Console.WriteLine("Added privilege to role")

            ' Add the role to the team.
            _serviceProxy.Associate(Team.EntityLogicalName, _teamId, New Relationship("teamroles_association"), _
                                    New EntityReferenceCollection() From {New EntityReference(Role.EntityLogicalName, _roleId)})

            Console.WriteLine("Assigned team to role")

            ' It takes some time for the privileges to propogate to the team. Delay the
            ' application until the privilege has been assigned.
            Dim teamLacksPrivilege As Boolean = True
            Do While teamLacksPrivilege
                Dim retrieveTeamPrivilegesRequest As RetrieveTeamPrivilegesRequest = _
                    New RetrieveTeamPrivilegesRequest With {.TeamId = _teamId}

                Dim retrieveTeamPrivilegesResponse As RetrieveTeamPrivilegesResponse = _
                    CType(_serviceProxy.Execute(retrieveTeamPrivilegesRequest), RetrieveTeamPrivilegesResponse)

                For Each rp As Microsoft.Crm.Sdk.Messages.RolePrivilege In retrieveTeamPrivilegesResponse.RolePrivileges
                    If retrieveTeamPrivilegesResponse.RolePrivileges(0).PrivilegeId = readQueuePrivilege.Id Then
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
                _serviceProxy.Delete("queue", _queueId)
                _serviceProxy.Delete("team", _teamId)
                _serviceProxy.Delete("role", _roleId)

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
                Dim app As New AssignQueueToTeam()

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

' </snippetassignqueuetoteam>