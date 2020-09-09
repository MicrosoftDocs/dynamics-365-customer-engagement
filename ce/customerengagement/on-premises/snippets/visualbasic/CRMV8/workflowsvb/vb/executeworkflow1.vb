' <snippetexecuteworkflow1>


 ' Create an ExecuteWorkflow request.
 Dim request As New ExecuteWorkflowRequest() With
     {
         .WorkflowId = _workflowId,
         .EntityId = _leadId
     }
 Console.Write("Created ExecuteWorkflow request, ")

 ' Execute the workflow.
 Dim response As ExecuteWorkflowResponse =
     CType(_serviceProxy.Execute(request), ExecuteWorkflowResponse)
 Console.WriteLine("and sent request to service.")

' </snippetexecuteworkflow1>