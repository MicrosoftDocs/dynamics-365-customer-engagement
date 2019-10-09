// <snippetassignrecordtoteam1>


 // Assign the account to a team.                
 AssignRequest assignRequest = new AssignRequest()
 {
     Assignee = new EntityReference
     {
         LogicalName = Team.EntityLogicalName,
         Id = _teamId
     },

     Target = new EntityReference(Account.EntityLogicalName, _accountId)
 };

 _service.Execute(assignRequest);

// </snippetassignrecordtoteam1>