' <snippetqueryconnectionrolesbyreciprocalrole1>


 ' This query retrieves all connection roles that have this role
 ' listed as a reciprocal role.
 Dim query As QueryExpression = New QueryExpression With { _
     .EntityName = ConnectionRole.EntityLogicalName, .ColumnSet = New ColumnSet("connectionroleid")}

 query.AddLink("connectionroleassociation", "connectionroleid", "connectionroleid", JoinOperator.Inner).LinkCriteria = _
     New FilterExpression()
 query.LinkEntities(0).LinkCriteria.AddCondition("associatedconnectionroleid", ConditionOperator.Equal, _
                                                 {_reciprocalConnectionRoleId})
 query.LinkEntities(0).LinkCriteria.FilterOperator = LogicalOperator.And

 Dim results As EntityCollection = _serviceProxy.RetrieveMultiple(query)

 ' TODO: Here you would perform some operation on the retrieved
 ' roles.

' </snippetqueryconnectionrolesbyreciprocalrole1>