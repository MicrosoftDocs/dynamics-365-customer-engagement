' <snippetsetstateworkflow3>


 Dim workflow As New Workflow() With
     {
         .Name = "CreateTaskXAML",
         .Type = New OptionSetValue(CInt(Fix(WorkflowType.Definition))),
         .Category = New OptionSetValue(CInt(Fix(WorkflowCategory.Workflow))),
         .Scope = New OptionSetValue(CInt(Fix(WorkflowScope.User))),
         .LanguageCode = 1033,
         .TriggerOnCreate = True,
         .OnDemand = True,
         .PrimaryEntity = Lead.EntityLogicalName,
         .Description = "Test workflow for the SetStateWorkflow SDK sample",
         .Xaml = xamlWF
     }
 _workflowId = _serviceProxy.Create(workflow)

' </snippetsetstateworkflow3>