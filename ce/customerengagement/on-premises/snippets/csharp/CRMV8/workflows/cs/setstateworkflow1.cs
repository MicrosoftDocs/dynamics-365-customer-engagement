// <snippetsetstateworkflow1>


 var activateRequest = new SetStateRequest
 {
     EntityMoniker = new EntityReference
         (Workflow.EntityLogicalName, _workflowId),
     State = new OptionSetValue((int)WorkflowState.Activated),
     Status = new OptionSetValue((int)workflow_statuscode.Activated)
 };
 _serviceProxy.Execute(activateRequest);

// </snippetsetstateworkflow1>