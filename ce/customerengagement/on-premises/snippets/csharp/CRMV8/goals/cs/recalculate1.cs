// <snippetrecalculate1>


 // Calculate roll-up of goals.
 RecalculateRequest recalculateRequest = new RecalculateRequest()
 {
     Target = new EntityReference(Goal.EntityLogicalName, _parentGoalId)
 };
 _serviceProxy.Execute(recalculateRequest);

// </snippetrecalculate1>