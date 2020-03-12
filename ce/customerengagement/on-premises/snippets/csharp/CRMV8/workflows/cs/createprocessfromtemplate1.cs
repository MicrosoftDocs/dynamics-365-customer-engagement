// <snippetcreateprocessfromtemplate1>


 // Connect to the Organization service. 
 // The using statement assures that the service proxy will be properly disposed.
 using (_serviceProxy = new OrganizationServiceProxy(serverConfig.OrganizationUri, serverConfig.HomeRealmUri,
                                                      serverConfig.Credentials, serverConfig.DeviceCredentials))
 {
     // This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes();

     OrganizationServiceContext _orgContext = new OrganizationServiceContext(_serviceProxy);

     CreateRequiredRecords();

     CreateWorkflowFromTemplateRequest request = new CreateWorkflowFromTemplateRequest()
     {
         WorkflowName = "Workflow From Template",
         WorkflowTemplateId = _processTemplateId
     };

     // Execute request.
     CreateWorkflowFromTemplateResponse response = (CreateWorkflowFromTemplateResponse)_serviceProxy.Execute(request);
     _processId = response.Id;

     // Verify success.
     // Retrieve the name of the workflow.
     ColumnSet cols = new ColumnSet("name");
     Workflow newWorkflow = (Workflow)_serviceProxy.Retrieve(Workflow.EntityLogicalName, response.Id, cols);
     if (newWorkflow.Name == "Workflow From Template")
     {
         Console.WriteLine("Created {0}.", request.WorkflowName);
     }

     DeleteRequiredRecords(promptforDelete);
 }

// </snippetcreateprocessfromtemplate1>