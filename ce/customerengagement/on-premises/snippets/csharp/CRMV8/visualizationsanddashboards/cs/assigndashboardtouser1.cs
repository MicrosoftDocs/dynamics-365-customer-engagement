// <snippetassigndashboardtouser1>


 AssignRequest assignRequest = new AssignRequest
 {
     Assignee = new EntityReference
     {
         LogicalName = SystemUser.EntityLogicalName,
         // Here we could assign the visualization to the newly created user
         Id = _otherUserId
     },

     Target = new EntityReference
     {
         LogicalName = UserForm.EntityLogicalName,
         Id = _userDashboardId
     }
 };
 _serviceProxy.Execute(assignRequest);

 Console.WriteLine("The user dashboard has been assigned to Kevin Cook.");

// </snippetassigndashboardtouser1>