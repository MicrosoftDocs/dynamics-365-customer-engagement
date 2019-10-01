// <snippetsetstateworkflow2>


 SetStateRequest deactivateRequest = new SetStateRequest
 {
     EntityMoniker = 
         new EntityReference(Workflow.EntityLogicalName, _workflowId),
     State = new OptionSetValue((int)WorkflowState.Draft),
     Status = new OptionSetValue((int)workflow_statuscode.Draft)
 };
 _serviceProxy.Execute(deactivateRequest);

// </snippetsetstateworkflow2>