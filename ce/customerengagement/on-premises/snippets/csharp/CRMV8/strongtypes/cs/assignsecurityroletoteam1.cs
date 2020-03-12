// <snippetassignsecurityroletoteam1>



 // Retrieve a role from CRM.
 QueryExpression query = new QueryExpression
 {
     EntityName = Role.EntityLogicalName,
     ColumnSet = new ColumnSet("roleid"),
     Criteria = new FilterExpression
     {
         Conditions =
     {
         // You would replace the condition below with an actual role
         // name, or skip this query if you had a role id.
         new ConditionExpression
         {
             AttributeName = "name",
             Operator = ConditionOperator.Equal,
             Values = {_roleName}
         }
     }
     }
 };

 Role role = _service.RetrieveMultiple(query).Entities.
     Cast<Role>().First();


 // Add the role to the team.
 _service.Associate(
        Team.EntityLogicalName,
        _teamId,
        new Relationship("teamroles_association"),
        new EntityReferenceCollection() { new EntityReference(Role.EntityLogicalName, _roleId) });

 Console.WriteLine("Assigned role to team");

// </snippetassignsecurityroletoteam1>