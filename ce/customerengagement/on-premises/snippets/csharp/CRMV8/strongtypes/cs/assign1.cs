// <snippetassign1>


 // Create the Request Object and Set the Request Object's Properties
 AssignRequest assign = new AssignRequest
     {
         Assignee = new EntityReference(SystemUser.EntityLogicalName,
             _otherUserId),
         Target = new EntityReference(Account.EntityLogicalName,
             _accountId)
     };


 // Execute the Request
 _service.Execute(assign);

// </snippetassign1>