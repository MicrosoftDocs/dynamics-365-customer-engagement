' <snippetsharequeue>


Imports System.Threading
Imports System.ServiceModel
Imports System.ServiceModel.Description

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Query
Imports Microsoft.Xrm.Sdk.Discovery
Imports Microsoft.Xrm.Sdk.Messages
Imports Microsoft.Xrm.Sdk.Client

' This namespace is found in Microsoft.Crm.Sdk.Proxy.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Crm.Sdk.Messages

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' This Sample shows how to share a queue to the team.
    ''' </summary>
    Public Class ShareQueue

        #Region "Class Level Members"


        ' Define the IDs needed for this sample.
        Private _queueId As Guid
        Private _teamId As Guid
        Private _roleId As Guid
        Private _serviceProxy As OrganizationServiceProxy

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' Create and configure the organization service proxy.
        ''' Initiate the method to create any data that this sample requires.
        ''' Share a queue to the team.
        ''' Optionally delete any entity records that were created for this sample.
        ''' <param name="serverConfig">Contains server connection information.</param>
        ''' <param name="promptforDelete">When True, the user will be prompted to delete all
        ''' created entities.</param>
        ''' </summary>

        Public Sub Run(ByVal serverConfig As ServerConnection.Configuration, ByVal promptForDelete As Boolean)
            Try
                ' Connect to the Organization service. 
                ' The using statement assures that the service proxy will be properly disposed.
                _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
                Using _serviceProxy
                    ' This statement is required to enable early-bound type support.
                    _serviceProxy.EnableProxyTypes()

                    CreateRequiredRecords()


                    ' Grant the team Read and AppendTo access to the queue.  
                    ' Having Read and AppendTo privileges gives a team a full access 
                    ' to the queue items, but only read access to the queue. For 
                    ' example, team members can’t change the queue name, but they 
                    ' can make any modifications to the queue items.
                    Dim grantAccessRequest As GrantAccessRequest = New GrantAccessRequest With {.PrincipalAccess = _
                        New PrincipalAccess With {.Principal = New EntityReference(Team.EntityLogicalName, _teamId), _
                                                  .AccessMask = AccessRights.ReadAccess Or AccessRights.AppendToAccess}, _
                                                  .Target = New EntityReference(Queue.EntityLogicalName, _queueId)}

                    _serviceProxy.Execute(grantAccessRequest)


                    Console.WriteLine("Queue has been shared to the team.")

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
        ''' Create a queue record.
        ''' Create a team record.
        ''' Create a role and add queue privileges.
        ''' Assign role to team.
        ''' </summary>
        Public Sub CreateRequiredRecords()
            ' Create a queue instance and set its property values.
            Dim newQueue As Queue = New Queue With {.Name = "Example Queue", .Description = "This is an example queue."}

            ' Create a new queue and store its returned GUID in a variable for later use.
            _queueId = _serviceProxy.Create(newQueue)
            Console.WriteLine("Created {0}", newQueue.Name)

            ' Retrieve the default business unit for the creation of the team and role.
            Dim queryDefaultBusinessUnit As QueryExpression = New QueryExpression With _
                {.EntityName = BusinessUnit.EntityLogicalName, .ColumnSet = New ColumnSet("businessunitid")}
            queryDefaultBusinessUnit.Criteria = New FilterExpression()
            queryDefaultBusinessUnit.Criteria.AddCondition(New ConditionExpression() With _
                {.AttributeName = "parentbusinessunitid", .Operator = ConditionOperator.Null})

            Dim defaultBusinessUnit As BusinessUnit = _
                CType(_serviceProxy.RetrieveMultiple(queryDefaultBusinessUnit).Entities(0), BusinessUnit)

            ' Create a new example team.
            Dim setupTeam As Team = New Team With {.Name = "Example Team", .BusinessUnitId = _
                New EntityReference(BusinessUnit.EntityLogicalName, defaultBusinessUnit.BusinessUnitId.Value)}

            _teamId = _serviceProxy.Create(setupTeam)
            Console.WriteLine("Created {0}", setupTeam.Name)

            ' Create a new example role.
            Dim setupRole As Role = New Role With {.Name = "Example Role", .BusinessUnitId = _
                New EntityReference(BusinessUnit.EntityLogicalName, defaultBusinessUnit.BusinessUnitId.Value)}

            _roleId = _serviceProxy.Create(setupRole)
            Console.WriteLine("Created {0}", setupRole.Name)

            ' Retrieve the prvReadQueue and prvAppendToQueue privileges.
            Dim queryQueuePrivileges As QueryExpression = New QueryExpression With _
                {.EntityName = Privilege.EntityLogicalName, .ColumnSet = New ColumnSet("privilegeid", "name")}
            queryQueuePrivileges.Criteria = New FilterExpression()
            queryQueuePrivileges.Criteria.AddCondition("name", ConditionOperator.In, {"prvReadQueue", "prvAppendToQueue"})

            Dim retrievedQueuePrivileges As DataCollection(Of Entity) = _serviceProxy.RetrieveMultiple(queryQueuePrivileges).Entities

            Console.WriteLine("Retrieved prvReadQueue and prvAppendToQueue privileges.")

            ' Define a list to hold the RolePrivileges we'll need to add
            Dim rolePrivileges As New List(Of RolePrivilege)()

            For Each privilege As Privilege In retrievedQueuePrivileges
                Dim rolePrivilege As New RolePrivilege(CInt(PrivilegeDepth.Local), privilege.PrivilegeId.Value)
                rolePrivileges.Add(rolePrivilege)
            Next privilege

            ' Add the prvReadQueue and prvAppendToQueue privileges to the example role.
            Dim addPrivilegesRequest As AddPrivilegesRoleRequest = New AddPrivilegesRoleRequest With _
                {.RoleId = _roleId, .Privileges = rolePrivileges.ToArray()}
            _serviceProxy.Execute(addPrivilegesRequest)
            Console.WriteLine("Retrieved privileges are added to {0}.", setupRole.Name)


            ' Add the example role to the example team.
            _serviceProxy.Associate(Team.EntityLogicalName, _teamId, New Relationship("teamroles_association"), _
                                    New EntityReferenceCollection() From {New EntityReference(Role.EntityLogicalName, _roleId)})

            ' It takes some time for the privileges to propogate to the team.  
            ' Verify this is complete before continuing.

            Dim teamLacksPrivilege As Boolean = True
            Do While teamLacksPrivilege
                Dim retrieveTeamPrivilegesRequest As RetrieveTeamPrivilegesRequest = _
                    New RetrieveTeamPrivilegesRequest With {.TeamId = _teamId}

                Dim retrieveTeamPrivilegesResponse As RetrieveTeamPrivilegesResponse = _
                    CType(_serviceProxy.Execute(retrieveTeamPrivilegesRequest), RetrieveTeamPrivilegesResponse)

                If retrieveTeamPrivilegesResponse.RolePrivileges.Any(Function(rp) rp.PrivilegeId = _
                        rolePrivileges(0).PrivilegeId) AndAlso _
                        retrieveTeamPrivilegesResponse.RolePrivileges.Any(Function(rp) rp.PrivilegeId = rolePrivileges(1).PrivilegeId) Then
                    teamLacksPrivilege = False
                Else
                    Thread.Sleep(1000)
                End If
            Loop

            Console.WriteLine("{0} has been added to {1}", setupRole.Name, setupTeam.Name)
            Return
        End Sub

        ''' <summary>
        ''' Deletes any entity records that were created for this sample.
        ''' <param name="prompt">Indicates whether to prompt the user to 
        ''' delete the records created in this sample.</param>
        ''' </summary>
        Public Sub DeleteRequiredRecords(ByVal prompt As Boolean)
            Dim deleteRecords As Boolean = True

            If prompt Then
                Console.WriteLine(vbLf &amp; "Do you want these entity records deleted? (y/n)")
                Dim answer As String = Console.ReadLine()

                deleteRecords = (answer.StartsWith("y") OrElse answer.StartsWith("Y"))
            End If

            If deleteRecords Then
                _serviceProxy.Delete(Queue.EntityLogicalName, _queueId)
                _serviceProxy.Delete(Team.EntityLogicalName, _teamId)
                _serviceProxy.Delete(Role.EntityLogicalName, _roleId)

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

                Dim app As New ShareQueue()
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

                    Dim fe As FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault) = TryCast(ex.InnerException,  _
                        FaultException(Of Microsoft.Xrm.Sdk.OrganizationServiceFault))
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

' </snippetsharequeue>