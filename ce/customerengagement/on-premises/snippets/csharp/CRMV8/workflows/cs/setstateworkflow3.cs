// <snippetsetstateworkflow3>


 Workflow workflow = new Workflow()
 {
     Name = "CreateTaskXAML",
     Type = new OptionSetValue((int)WorkflowType.Definition),
     Category = new OptionSetValue((int)WorkflowCategory.Workflow),
     Scope = new OptionSetValue((int)WorkflowScope.User),
     LanguageCode = 1033,                // U.S. English
     TriggerOnCreate = true,
     OnDemand = true,
     PrimaryEntity = Lead.EntityLogicalName,
     Description =
         "Test workflow for the SetStateWorkflow SDK sample",
     Xaml = xamlWF
 };
 _workflowId = _serviceProxy.Create(workflow);

// </snippetsetstateworkflow3>