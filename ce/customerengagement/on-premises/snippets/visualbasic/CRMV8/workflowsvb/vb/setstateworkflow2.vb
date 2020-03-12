' <snippetsetstateworkflow2>


 Dim deactivateRequest As SetStateRequest =
     New SetStateRequest With
     {
         .EntityMoniker = New EntityReference(Workflow.EntityLogicalName, _workflowId),
         .State = New OptionSetValue(CInt(Fix(WorkflowState.Draft))),
         .Status = New OptionSetValue(CInt(Fix(workflow_statuscode.Draft)))
     }
 _serviceProxy.Execute(deactivateRequest)

' </snippetsetstateworkflow2>