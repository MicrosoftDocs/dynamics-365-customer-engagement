' <snippetassignsecurityroletoteam1>



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

' </snippetassignsecurityroletoteam1>