' <snippetqueryconnectionrolesbyentitytypecode1>


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

' </snippetqueryconnectionrolesbyentitytypecode1>