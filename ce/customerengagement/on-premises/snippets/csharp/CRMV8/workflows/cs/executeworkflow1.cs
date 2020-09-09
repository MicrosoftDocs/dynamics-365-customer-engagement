// <snippetexecuteworkflow1>


 // Create an ExecuteWorkflow request.
 ExecuteWorkflowRequest request = new ExecuteWorkflowRequest()
 {
     WorkflowId = _workflowId,
     EntityId = _leadId
 };
 Console.Write("Created ExecuteWorkflow request, ");

 // Execute the workflow.
 ExecuteWorkflowResponse response =
     (ExecuteWorkflowResponse)_serviceProxy.Execute(request);
 Console.WriteLine("and sent request to service.");

// </snippetexecuteworkflow1>