// <snippetcreaterealtimeworkflow1>


 // Create a real-time workflow. 
 // The workflow should execute after a new opportunity is created
 // and run in the context of the logged on user.
 Workflow workflow = new Workflow()
 {
     // These properties map to the New Process form settings in the web application.
     Name = "Set closeprobability on opportunity create (real-time)",
     Type = new OptionSetValue((int)WorkflowType.Definition),       
     Category = new OptionSetValue((int)WorkflowCategory.Workflow),
     PrimaryEntity = Opportunity.EntityLogicalName,
     Mode = new OptionSetValue((int)WorkflowMode.Realtime),

     // Additional settings from the second New Process form.
     Description = @"When an opportunity is created, this workflow" +
         " sets the closeprobability field of the opportunity record to 40%.",
     OnDemand = false,
     Subprocess = false,
     Scope = new OptionSetValue((int)WorkflowScope.User),
     RunAs = new OptionSetValue((int)workflow_runas.CallingUser),
     SyncWorkflowLogOnFailure = true,
     TriggerOnCreate = true,
     CreateStage = new OptionSetValue((int)workflow_stage.Postoperation),
     Xaml = xamlWF,

     // Other properties not in the web forms.
     LanguageCode = 1033,  // U.S. English
 };
 _workflowId = _serviceProxy.Create(workflow);

// </snippetcreaterealtimeworkflow1>