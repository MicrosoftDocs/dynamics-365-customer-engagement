' <snippetretrieverecordsfromanintersecttable1>


 '					#Region "Retrieve records from an intersect table via QueryExpression"

 'Create Query Expression.
 Dim query As New QueryExpression() With
     {
         .EntityName = "role",
         .ColumnSet = New ColumnSet("name")
     }

 Dim queryLinkEntity As New LinkEntity With
     {
         .LinkToEntityName = SystemUserRoles.EntityLogicalName,
         .LinkFromAttributeName = "roleid",
         .LinkToAttributeName = "roleid"
     }
 queryLinkEntity.LinkCriteria().AddCondition(
     "systemuserid",
     ConditionOperator.Equal,
     _userId)
 queryLinkEntity.LinkCriteria().FilterOperator = LogicalOperator.And
 query.LinkEntities().Add(queryLinkEntity)

 ' Obtain results from the query expression.
 Dim ec As EntityCollection = _serviceProxy.RetrieveMultiple(query)

 ' Display results.
 For i As Integer = 0 To ec.Entities.Count - 1
     Console.WriteLine("Query Expression Retrieved: {0}",
                       (CType(ec.Entities(i), Role)).Name)
 Next i

 '					#End Region

' </snippetretrieverecordsfromanintersecttable1>