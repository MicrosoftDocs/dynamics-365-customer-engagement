// <snippetassignvisualizationtouser1>



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
         LogicalName = UserQueryVisualization.EntityLogicalName,
         Id = _userOwnedVisualizationId
     }
 };
 _serviceProxy.Execute(assignRequest);

 Console.WriteLine("The user visualization has been assigned to Kevin Cook.");

// </snippetassignvisualizationtouser1>