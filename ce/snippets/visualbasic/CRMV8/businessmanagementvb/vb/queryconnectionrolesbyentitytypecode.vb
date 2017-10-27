' <snippetqueryconnectionrolesbyentitytypecode>


Imports System.ServiceModel

' These namespaces are found in the Microsoft.Xrm.Sdk.dll assembly
' found in the SDK\bin folder.
Imports Microsoft.Xrm.Sdk
Imports Microsoft.Xrm.Sdk.Client
Imports Microsoft.Xrm.Sdk.Query

Namespace Microsoft.Crm.Sdk.Samples
    ''' <summary>
    ''' This sample shows how to find connection roles by object type code.
    ''' </summary>
    Public Class QueryConnectionRolesByEntityTypeCode
        #Region "Class Level Members"

        ''' <summary>
        ''' Stores the organization service proxy.
        ''' </summary>
        Private _serviceProxy As OrganizationServiceProxy

        ' Define the IDs needed for this sample.
        Private _connectionRoleId As Guid

        #End Region ' Class Level Members

        #Region "How To Sample Code"
        ''' <summary>
        ''' This sample creates a role that is not linked to any entity type. All
        ''' connection roles that apply to all are found and shown. Then the role is
        ''' linked to the account entity and it is demonstrated that the role only works
        ''' for accounts at this point, not for all. Subsequently the link to the account
        ''' entity is removed and it is shown that the role is now applicable to all 
        ''' entities again.
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

                    ' Define some anonymous types to define the range 
                    ' of possible connection property values.
                    Dim Categories = New With {Key .Business = 1, Key .Family = 2, Key .Social = 3, Key .Sales = 4, Key .Other = 5}

                    ' Create a Connection Role.
                    Dim setupConnectionRole As ConnectionRole = New ConnectionRole With { _
                        .Name = "Example Connection Role", .Category = New OptionSetValue(Categories.Business)}

                    _connectionRoleId = _serviceProxy.Create(setupConnectionRole)
                    setupConnectionRole.Id = _connectionRoleId

                    Console.WriteLine("Created {0}.", setupConnectionRole.Name)

                    ' Query for all Connection Roles.
                    Dim allQuery As QueryExpression = New QueryExpression With { _
                        .EntityName = ConnectionRole.EntityLogicalName, _
                        .ColumnSet = New ColumnSet("connectionroleid", "name"), .Distinct = True}

                    allQuery.AddLink(ConnectionRoleObjectTypeCode.EntityLogicalName, "connectionroleid", "connectionroleid").LinkCriteria() = _
                        New FilterExpression()
                    allQuery.LinkEntities(0).LinkCriteria().AddCondition("associatedobjecttypecode", ConditionOperator.Equal, {0})
                    allQuery.LinkEntities(0).LinkCriteria().FilterOperator = LogicalOperator.And
                                    ' Set a condition to only get connection roles  
                                    ' related to all entities (object type code = 0).

                    Dim results As EntityCollection = _serviceProxy.RetrieveMultiple(allQuery)

                    ' Here you could perform operations on all of 
                    ' the connectionroles found by the query.

                    Console.WriteLine("Retrieved {0} unassociated connectionrole instance(s).", results.Entities.Count)

                    ' Query to find roles which apply only to accounts.
                    Dim accountQuery As QueryExpression = New QueryExpression With { _
                        .EntityName = ConnectionRole.EntityLogicalName, _
                        .ColumnSet = New ColumnSet("connectionroleid", "name"), .Distinct = True}
                    accountQuery.AddLink(ConnectionRoleObjectTypeCode.EntityLogicalName, "connectionroleid", "connectionroleid").LinkCriteria = _
                        New FilterExpression()
                    accountQuery.LinkEntities(0).LinkCriteria.AddCondition("associatedobjecttypecode", ConditionOperator.In, _
                                                                           {Account.EntityLogicalName})
                    accountQuery.LinkEntities(0).LinkCriteria.FilterOperator = LogicalOperator.And
                    ' Set a condition to only get connection roles  
                                    ' related to accounts (object type code = 1).

                    results = _serviceProxy.RetrieveMultiple(accountQuery)

                    Console.WriteLine("Retrieved {0} account-only connectionrole instance(s).", results.Entities.Count)

                    ' Create a related Connection Role Object Type Code record for 
                    ' Account.
                    Dim setupAccountConnectionRoleTypeCode As ConnectionRoleObjectTypeCode = _
                        New ConnectionRoleObjectTypeCode With {.ConnectionRoleId = _
                            New EntityReference(ConnectionRole.EntityLogicalName, _connectionRoleId), _
                                                               .AssociatedObjectTypeCode = Account.EntityLogicalName}

                    setupAccountConnectionRoleTypeCode.Id = _serviceProxy.Create(setupAccountConnectionRoleTypeCode)

                    Console.Write("Created a related Connection Role Object Type Code")
                    Console.Write(" record for Account.")

                    ' Run the query to find unassociated connectionroles again.
                    results = _serviceProxy.RetrieveMultiple(allQuery)

                    Console.WriteLine("Retrieved {0} unassociated connectionrole instance(s).", results.Entities.Count)

                    ' Run the account-only query again.
                    results = _serviceProxy.RetrieveMultiple(accountQuery)

                    Console.WriteLine("Retrieved {0} account-only connectionrole instance(s).", results.Entities.Count)

                    ' Remove the link from account entity.
                    _serviceProxy.Delete(ConnectionRoleObjectTypeCode.EntityLogicalName, setupAccountConnectionRoleTypeCode.Id)

                    Console.WriteLine("Removed link from connectionrole to account entity.")

                    ' Run the query to find unassociated connectionroles again.
                    results = _serviceProxy.RetrieveMultiple(allQuery)

                    Console.WriteLine("Retrieved {0} unassociated connectionrole instance(s).", results.Entities.Count)

                    ' Run the account-only query again.
                    results = _serviceProxy.RetrieveMultiple(accountQuery)

                    Console.WriteLine("Retrieved {0} account-only connectionrole instance(s).", results.Entities.Count)

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
                ' Delete all records created in this sample.
                _serviceProxy.Delete(ConnectionRole.EntityLogicalName, _connectionRoleId)

                Console.WriteLine("Entity record(s) have been deleted.")
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

                Dim app As New QueryConnectionRolesByEntityTypeCode()
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

' </snippetqueryconnectionrolesbyentitytypecode>