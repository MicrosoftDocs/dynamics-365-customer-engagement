' <snippetcreateprocessfromtemplate1>


 ' Connect to the Organization service. 
 ' The using statement assures that the service proxy will be properly disposed.
 _serviceProxy = ServerConnection.GetOrganizationProxy(serverConfig)
 Using _serviceProxy
     ' This statement is required to enable early-bound type support.
     _serviceProxy.EnableProxyTypes()

     Dim _orgContext As New OrganizationServiceContext(_serviceProxy)

     CreateRequiredRecords()

     Dim request As New CreateWorkflowFromTemplateRequest() With
         {
             .WorkflowName = "Workflow From Template",
             .WorkflowTemplateId = _processTemplateId
         }

     ' Execute request.
     Dim response As CreateWorkflowFromTemplateResponse =
         CType(_serviceProxy.Execute(request), CreateWorkflowFromTemplateResponse)
     _processId = response.Id

     ' Verify success.
     ' Retrieve the name of the workflow.
     Dim cols As New ColumnSet("name")
     Dim newWorkflow As Workflow =
         CType(
             _serviceProxy.Retrieve(
                 Workflow.EntityLogicalName,
                 response.Id,
                 cols), 
             Workflow)
     If newWorkflow.Name = "Workflow From Template" Then
         Console.WriteLine("Created {0}.", request.WorkflowName)
     End If

     DeleteRequiredRecords(promptforDelete)
 End Using

' </snippetcreateprocessfromtemplate1>