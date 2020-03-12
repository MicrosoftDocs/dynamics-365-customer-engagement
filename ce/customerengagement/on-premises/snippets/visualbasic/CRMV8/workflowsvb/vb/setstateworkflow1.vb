' <snippetsetstateworkflow1>


 Dim activateRequest = New SetStateRequest With
                       {
                           .EntityMoniker = New EntityReference(Workflow.EntityLogicalName,
                                                                _workflowId),
                           .State = New OptionSetValue(CInt(Fix(WorkflowState.Activated))),
                           .Status = New OptionSetValue(CInt(Fix(workflow_statuscode.Activated)))
                       }
 _serviceProxy.Execute(activateRequest)

' </snippetsetstateworkflow1>