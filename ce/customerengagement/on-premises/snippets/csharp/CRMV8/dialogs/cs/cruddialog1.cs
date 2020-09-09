// <snippetcruddialog1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     CreateRequiredRecords();
     
     // Define an anonymous type to define the possible values for 
     // workflow category
     var WorkflowCategory = new
     {
         Workflow = 0,
         Dialog = 1
     };
     
     // Instantiate a Workflow object.
     // See the Entity Metadata topic in the SDK documentation to determine 
     // which attributes must be set for each entity.
     Workflow sampleDialog = new Workflow
     {
         Category = new OptionSetValue((int)WorkflowCategory.Dialog),
         Name = "Sample Dialog: Call Categorization",
         PrimaryEntity = PhoneCall.EntityLogicalName,

         //Language code for U.S. English
         LanguageCode = 1033,
         Xaml = File.ReadAllText(pathToXAML)
     };

     // Create a dialog record.
     _dialogId = _serviceProxy.Create(sampleDialog);
     Console.Write("{0} created,", sampleDialog.Name);

     // Activate the dialog.
     SetStateRequest activateRequest = new SetStateRequest
     {
         EntityMoniker = new EntityReference(Workflow.EntityLogicalName, _dialogId),
         State = new OptionSetValue((int)WorkflowState.Activated),
         Status = new OptionSetValue(2)
     };
     _serviceProxy.Execute(activateRequest);
     Console.WriteLine(" and activated.");

     // Retrieve the dialog containing several of its attributes.
     ColumnSet cols = new ColumnSet("name", "statecode", "statuscode");

     Workflow retrievedDialog = (Workflow)_serviceProxy.Retrieve(Workflow.EntityLogicalName, _dialogId, cols);
     Console.Write("Retrieved,");

     // Update the dialog.
     // Deactivate the dialog before you can update it.
     SetStateRequest deactivateRequest = new SetStateRequest
     {
         EntityMoniker = new EntityReference(Workflow.EntityLogicalName, _dialogId),
         State = new OptionSetValue((int)WorkflowState.Draft),
         Status = new OptionSetValue(1)

     };
     _serviceProxy.Execute(deactivateRequest);

     // Retrieve the dialog record again to get the unpublished 
     // instance in order to update.
     Workflow retrievedDialogDeactivated = (Workflow)_serviceProxy.Retrieve(Workflow.EntityLogicalName, _dialogId, cols);

     // Update the dialog.
     retrievedDialogDeactivated.Name = "Updated Dialog: Call Categorization";
     _serviceProxy.Update(retrievedDialogDeactivated);

     Console.Write(" updated,");

     // Activate the dialog.
     SetStateRequest updateActivateRequest = new SetStateRequest
     {
         EntityMoniker = new EntityReference(Workflow.EntityLogicalName, _dialogId),
         State = new OptionSetValue((int)WorkflowState.Activated),
         Status = new OptionSetValue(2)
     };
     _serviceProxy.Execute(updateActivateRequest);
     Console.WriteLine(" and activated again.");

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetcruddialog1>