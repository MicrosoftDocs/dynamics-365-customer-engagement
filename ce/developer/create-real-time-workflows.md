---
title: "Create real-time workflows (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about real-time workflows that can be used to model and automate real world business processes. Real-time workflows are for business users, for example business analysts, to implement similar functionality to synchronous plug-ins without requiring .NET Framework programming experience."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
    - "Dynamics 365 (online)"
ms.assetid: a026a102-7854-42de-ab77-e5bbb556bb2c
caps.latest.revision: 24
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Create real-time workflows

[!INCLUDE[](../includes/cc_applies_to_update_9_0_0.md)]

Similar to asynchronous workflows, real-time workflows can be used to model and automate real world business processes. They can optionally require user input, can start automatically based on specified event conditions, or can be started manually by a user. Real-time workflows are for business users, for example business analysts, to implement similar functionality to synchronous plug-ins without requiring [!INCLUDE[pn_NET_Framework](../includes/pn-net-framework.md)] programming experience. You can create asynchronous or real-time workflows in the [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] Customer Engagement web application or in code.  
  
 Some key points about a real-time workflow include the following items:  
  
- Defined by using a `Workflow` entity record, similar to an asynchronous workflow.  
  
- Executes in a stage of the event execution pipeline, similar to synchronous plug-ins. The real-time workflow can execute before (pre-operation), after (post-operation), or during the core operation. A real-time workflow that is executed during the core operation is the implementation of a custom action. Real-time workflows can be ranked within a stage just like you can do with plug-ins. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Pipeline Stages](event-execution-pipeline.md#bkmk_PipelineStages)  
  
- Whether configured to run on-demand or in response to an event, a real-time workflow runs immediately rather than being queued to run at a later time.  
  
- Can run in the security context of the logged on user or owner of the workflow. However, workflows set to run on-demand always run under the security context of the logged on user.  
  
- Can’t contain any delay or wait activities.  
  
- Only logs errors, and only when logging is enabled.  
  
- Executes in the current transaction. All activities in the workflow and any child workflows, except asynchronous workflows, are part of a single transaction. Asynchronous child workflows are queued and execute in a separate transaction.  
  
- Can be converted to asynchronous workflow and back to real-time.  
  
<a name="bkmk_security"></a>   
## Required security privileges  
 A security privilege named Activate Real-time Processes (`prvActivateSynchronousWorkflow`) is required to activate real-time workflows so that they can be executed. The Execute Workflow Job (`prvWorkflowExecution`) privilege is required to start the workflow. Because a real-time workflow impacts the core system operation, it is recommended that only a small experienced group of users are granted the activate privilege.  
   
<a name="bkmk_create"></a>   
## Create a real-time workflow in code  
[!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)]  
 
 While [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] does support real-time workflows, they must be created interactively in the web application. XAML based workflows, discussed in this section, are only supported by an on-premises or IFD server.  
  
 You can create a real-time workflow in code by creating a `Workflow` entity record. Review the `Workflow` entity’s attribute metadata by using the Metadata Browser tool. [!INCLUDE[metadata_browser](../includes/metadata-browser.md)]  
  
 The following example compares code that creates an asynchronous workflow to code that creates a real-time workflow.  
  
 [!code-csharp[Workflows#createaworkflow1](../snippets/csharp/CRMV8/workflows/cs/createaworkflow1.cs#createaworkflow1)]  
  
 [!code-csharp[Workflows#createrealtimeworkflow1](../snippets/csharp/CRMV8/workflows/cs/createrealtimeworkflow1.cs#createrealtimeworkflow1)]  
  
 The real-time workflow has some additional properties set that the asynchronous workflow doesn’t:  
  
|Workflow attribute|Description|  
|------------------------|-----------------|  
|`Category`|Set to `WorkflowCategory.Workflow`.|  
|`RunAs`|Specifies to execute the workflow under the security context of the workflow owner (`workflow_runas.Owner`), or logged on user (`workflow_runas.CallingUser`).|  
|`SyncWorkflowLogOnError`|When `true`, errors are logged to `ProcessSession` records. Unlike asynchronous workflows, real-time workflow execution isn’t logged to `System Job` records.|  
|`CreateStage`, `DeleteStage`, or `UpdateStage`|Identifies the stage in the event execution pipeline where the workflow is to run: before the core operation (`workflow_stage.Preoperation`), or after (`workflow_stage.Postoperation`). You must match the stage to the trigger event for the intended operation. For example, if `TriggerOnUpdate` is `true`, you must also set `UpdateStage`.<br /><br /> Real-time workflows can’t be executed on retrieves. Other than retrieves, the rest of the supported web services messages map to one of these three supported events. For example, an assign or set state operation ultimately is the same as an update.|  
|`Mode`|This is the execution mode. Set this to `WorkflowMode.Realtime`.|  
|`Rank`|You can order the execution of plug-ins and real-time workflows within a stage by setting a rank. All plug-ins or real-time workflows with a rank of 1 execute before those with a rank of 2, and so on.|  
|`Xaml`|Set to the XAML code that defines your real-time workflow.|  
  
 You can see the complete sample code for creating a real-time workflow in the topic [Sample: Create a real-time workflow in code](sample-create-real-time-workflow-code.md).  
  
<a name="bkmk_convert"></a>   
## Convert an asynchronous workflow to real-time and back  
 You can convert workflows from asynchronous to real-time and back using <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> without the need to rewrite the workflow, as long as the asynchronous workflow doesn’t contain any wait or delay activities. You can also do the conversion interactively by using the web application. The workflow must be in a draft state (not-activated) before the conversion is performed.  
  
#### Convert an asynchronous workflow to real-time  
  
1.  Create an <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> for the workflow.  
  
2.  Set the workflow’s `Mode` property to `WorkflowMode.Realtime`.  
  
3.  Set the workflow’s `CreateStage`, `UpdateStage`, or `DeleteStage` as appropriate. For example, if your workflow has `TriggerOnDelete` set, then also set the `DeleteStage` property.  
  
4.  Call the <xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method passing the update request as a parameter.  
  
#### Convert a real-time workflow to asynchronous  
  
1.  Create an <xref:Microsoft.Xrm.Sdk.Messages.UpdateRequest> for the workflow.  
  
2.  Set the workflow’s `Mode` property to `WorkflowMode.Background`.  
  
3.  Call the <xref:Microsoft.Xrm.Sdk.IOrganizationService.Execute*> method passing the update request as a parameter.  
  
<a name="bkmk_errors"></a>   
## Error handling and rollback  
 Any workflow activity that executes during the database transaction and that passes an exception back to the platform cancels the core operation. This results in a rollback of the core operation if it’s already occurred. In addition, any pre-event or post-event registered plug-ins or real-time workflows that haven’t executed yet. Any asynchronous workflows that are triggered by the same event won’t execute.  
  
 If you include a stop workflow ([TerminateWorkflow class](https://msdn.microsoft.com/library/system.activities.statements.terminateworkflow\(v=vs.100\).aspx))  activity with the cancelled option in your workflow, you can add a custom status message (`Reason` property) to that activity containing a single line of text to be displayed to the user in the **Business Process Error** dialog.  
  
 When `SyncWorkflowLogOnError` is set to `true`, real-time workflow errors are logged in `ProcessSession` entity records.  
  
<a name="bkmk_package"></a>   
## Package a real-time workflow for distribution  
 To distribute your workflow so that it can be imported into a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] organization, add your workflow to a [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] solution. This is easily done using the web application by navigating to **SETTINGS > CUSTOMIZATIONS > Solutions**. You can also write code to create the solution. For more information about solutions, see [Package and distribute extensions](package-distribute-extensions-use-solutions.md).  
  
### See also  
 [Write Workflows to Automate Business Processes](automate-business-processes-customer-engagement.md)   
 [Create your own actions](create-own-actions.md)   
 [Event Execution Pipeline](event-execution-pipeline.md)   
 [Write Plug-Ins to Extend Business Processes](write-plugin-extend-business-processes.md)
