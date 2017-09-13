---
title: "Guide staff through common tasks with processes in Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 08/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 0b4e6602-5701-4859-81cc-6f6fe50901b2
caps.latest.revision: 44
author: "brycho"
ms.author: "brycho"
manager: "brycho"
---
# Guide staff through common tasks with different types of processes
Defining and enforcing consistent business processes is one of the main reasons people use [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. Consistent processes help make sure people using the system can focus on their work and not on remembering to perform a set of manual steps. Processes can be simple or complex and can change over time.  
  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] includes five  types of processes, each designed for a different purpose:  
  
-   Business process flows  
  
-   Mobile task flows  
  
-   Workflows  
  
-   Dialogs  
  
-   Actions  
  
> [!NOTE]
>  For information on creating business rules and recommendations, see [Create business rules and recommendations to apply logic in a form](../customize/create-business-rules-recommendations-apply-logic-form.md)  
    
<a name="BKMK_BP"></a>   
## When to use business process flows  
 Use a business process flow when you want staff to move through the same stages and follow the same steps to interact with a customer. For example, use a business process flow if you want everyone to handle customer service requests the same way, or to require staff to gain approval for an invoice before submitting an order.  
  
 [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] includes several ready-to-use business process flows for common sales, service, and marketing tasks that you can use with little or no changes required. Or, you can create your own. See the following topics for more information on business process flows:  
  
-   [Create a business process flow](../customize/create-business-process-flow.md)  
  
-   [Activate a business process flow or a task flow](../customize/activate-business-process-flow-task-flow.md)  
  
-   [Add ready-to-use business processes](../customize/add-ready-use-business-processes.md)  
  
-   [Assign a security role to a business process flow](../customize/assign-security-role-business-process-flow.md)  
  
- [![Reader button](../customize/media/reader-button.png "Reader button")](http://go.microsoft.com/fwlink/p/?LinkID=321480) [eBook: Intro to business processes in Dynamics CRM](http://go.microsoft.com/fwlink/p/?LinkID=321480)  
  
- [![Reader button](../customize/media/reader-button.png "Reader button")](http://go.microsoft.com/fwlink/p/?LinkID=386368) [eBook: Customize a business process in Dynamics CRM](http://go.microsoft.com/fwlink/p/?LinkID=386368)  
  
> [!TIP]
>  If you have the December 2016 update, you can use a drag-and-drop designer to create your business process flows.  
  
<a name="BKMK_TF"></a>   
## When to use mobile task flows  
 You can also design a type of business process flow called a task flow in [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] or [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] based on common tasks your users perform. For example, if they need to regularly perform a series of follow-up steps after client meetings, create a task flow. When users tap the new task in their mobile app, it will lead them through from start to finish so they don't forget an important step. For more information on task flows, see the following topics:  
  
-   [Create a mobile task flow](../customize/create-mobile-task-flow.md)  
  
-   [Activate a business process flow or a task flow](../customize/activate-business-process-flow-task-flow.md)  
  
> [!TIP]
>  If you have the December 2016 update, you can use a drag-and-drop designer to create your task flows.  
  
<a name="BKMK_WF"></a>   
## When to use workflows  
 Use workflows to automate business processes behind the scenes. Workflows are typically initiated by system events so the user doesn't need to be aware that they are running. Workflows that operate in the background are "asynchronous." Workflows can also be configured for people to manually initiate them. when you want to automate common tasks, such as automatically sending a confirmation email to a customer when an order ships. Workflows that operate in real time are "synchronous." For more information on workflows, see  [Workflow processes](https://technet.microsoft.com/library/dn531067.aspx)  
  
<a name="BKMK_Dialogs"></a>   
## When to use Dialogs  
 Use a Dialog when you have a step-by-step script you want staff to read through when talking to customers. For example, create a dialog to guide customer service reps through a customer call to resolve a case. For more information on Dialogs, see [Dialogs](https://technet.microsoft.com/library/dn531092.aspx)  
  
<a name="BKMK_Actions"></a>   
## When to use Actions  
 Use Actions when you want to automate a series of commands in the system. Actions expand the vocabulary available for developers to express business processes. With core verbs like Create, Update, Delete, and Assign provided by the system, a Action uses those core verbs to create more expressive verbs like Approve, Escalate, Route, or Schedule. If the definition of a business process changes, someone who isn’t a developer can edit the Action so the code doesn’t need to be changed.  For more information on Actions, see  [Actions](https://technet.microsoft.com/library/dn531060.aspx)  
  
<a name="useMSFlow"></a>   
## When to use Microsoft Flow  
 Use Microsoft Flow when you need to create automated workflows that perform actions between [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and your favorite apps and services, such as [!INCLUDE[tn_twitter](../includes/tn-twitter.md)], Dropbox, Google services, [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)], and [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)]. You can trigger a flow based on a specific action, or invoke from within [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use Microsoft Flow to automate processes across services](Use%20Microsoft%20Flow%20to%20automate%20processes%20across%20services.md)  
  
<a name="BKMK_Where"></a>   
## Where do I go to create processes?  
 There are two paths to navigate to processes in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]:  
  
- **Settings>Processes.** This path is easiest to access and allows you to use views defined for the Process entity, including any custom views.  
  
- **Settings > Customizations > Customize the System > Components > Processes.** This path provides convenient access when you are doing other customization work in the customization tools.  
  
 Individual business process flows can also be edited using the **Edit Process** button in the command bar for the form where the business process flow is active.  
  
<a name="BKMK_WhoCreate"></a>   
## Who can create processes?  
 Only people with the System Administrator, System Customizer, or CEO-Business Manager security role can create processes that apply to the whole organization. People with other roles can create processes with limited access level. For example, people with the User access level can create workflows for their own use with records they own.  
  
 The following table shows the access level of processes based on default security roles.  
  
|||  
|-|-|  
|**Security role**|**Access level**|  
|CEO-Business Manager|Organization|  
|System Administrator|Organization|  
|System Customizer|Organization|  
|Vice President of Marketing|Parent: Child Business Units|  
|Vice President of Sales|Parent: Child Business Units|  
|Service Manager|Business Unit|  
|Marketing Manager|Business Unit|  
|Sales Manager|Business Unit|  
|Schedule Manager|Business Unit|  
|Customer Service Representative|User|  
|Marketing Professional|User|  
|Salesperson|User|  
|Scheduler|User|  
  
> [!NOTE]
>  While people may be able to create business process flow, real-time workflow, or action processes, they’ll need to have the **Activate Business Process Flows** or **Activate Real-time Processes** privileges to activate them.  
  
<a name="BKMK_WhatCanProcessesDo"></a>   
## More about workflows, Dialogs, and Actions  
 Processes can check conditions, apply branching logic, and perform actions. They perform these actions in a series of steps. The following table describes the available steps in workflow, dialog, and action processes. For more detail see the topics for each type of process.  
  
|Step|Process type|Description|  
|----------|------------------|-----------------|  
|**Stage**|Workflow, Dialog, Action|Stages make the workflow logic easier to read, and explain the workflow logic. However, stages don’t affect the logic or behavior of workflows. If a process has stages, all the steps in the process must be contained with a stage.|  
|**Check Condition**|Workflow, Dialog, Action|A logical "if-\<condition> then" statement.<br /><br /> You can check values for the record that the workflow is running on, any of the records linked to that record in an N:1 relationship, or any records created by earlier steps. Based on these values you can define additional steps when the condition is `true`.|  
|**Conditional Branch**|Workflow, Dialog, Action|A logical "else-if-then" statement, the editor uses the text “Otherwise, if \<condition> then:”<br /><br /> Select a check condition you have previously defined and you can add a conditional branch to define additional steps when the check condition returns `false`.|  
|**Default Action**|Workflow, Dialog, Action|A logical "else" statement. the editor uses the text “Otherwise:”<br /><br /> Select a check condition, conditional branch, wait condition, or parallel wait branch that you have previously defined and you can use a default action to define steps for all cases that don’t match the criteria defined in condition or branch elements.|  
|**Wait Condition**|Background Workflow Only|Enables a background workflow to pause itself until the criteria defined by the condition have been met. The workflow starts again automatically when the criteria in the wait condition have been met.|  
|**Parallel Wait Branch**|Background Workflow Only|Defines an alternative wait condition for a background workflow with a corresponding set of additional steps that are performed only when the initial criterion is met. You can use parallel wait branches to create time limits in your workflow logic. They help prevent the workflow from waiting indefinitely until the criteria defined in a wait condition have been met.|  
|**Assign Value**|Dialog, Action|Sets a value to a variable or output parameter in the process.|  
|**Create Record**|Workflow, Dialog, Action|Creates a new record for an entity and assigns values to attributes.|  
|**Update Record**|Workflow, Dialog, Action|You can update the record that the workflow is running on, any of the records linked to that record in an N:1 relationship, or any records created by earlier steps.|  
|**Assign Record**|Workflow, Dialog, Action|You can assign the record that the workflow is running on, any of the records linked to that record with an N:1 relationship, or any records created by earlier steps.|  
|**Send Email**|Workflow, Dialog, Action|Sends an email. You can choose to create a new email message or use an email template configured for the entity of the record that the workflow is running on or any entities that have an N:1 relationship with the entity, or the entity for any records created by earlier steps.|  
|**Start Child Workflow**|Workflow, Dialog, Action|Starts a workflow process that has been configured as a child workflow.|  
|**Change Status**|Workflow, Dialog, Action|Changes the status of the record that the process is running on, any of the records linked to that record with an N:1 relationship, or any records created by earlier steps.|  
|**Stop Workflow**/**Stop Dialog**|Workflow, Dialog, Action|Stops the current workflow, dialog, or action. You can set a status of either **Succeeded** or **Canceled** and specify a status message.|  
|**Page**|Dialog|A container for prompt and response steps in a dialog.|  
|**Prompt and Response**|Dialog|Displays a prompt in a dialog page and may provide a field to capture data from a response.|  
|**Query Dynamics 365 Data**|Dialog|Defines a query that returns data to provide options for a response in a prompt and response step of a dialog.|  
|**Link Child Dialog**|Dialog|Starts a dialog process that has been configured as a child dialog.|  
|**Custom Step**|Workflow, Dialog, Action|Provides extensions to the logical elements available by default in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. Steps can include conditions, actions, other steps, or a combination of these elements. Developers can create custom workflow steps. By default, there are no custom steps available in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. For more information for developers, see the [!INCLUDE[pn_sdk](../includes/pn-sdk.md)] topic [MSDN: Custom workflow activities (workflow assemblies)](https://msdn.microsoft.com/library/gg309745.aspx).|  
  
### See also  
 [Business process flows overview](../customize/business-process-flows-overview.md)   
 [Create a business process flow](../customize/create-business-process-flow.md)   
 [Create a mobile task flow](../customize/create-mobile-task-flow.md)   
 [Workflow processes](https://technet.microsoft.com/library/dn531067.aspx)   
 [Dialogs](https://technet.microsoft.com/library/dn531092.aspx)   
 [Actions](https://technet.microsoft.com/library/dn531060.aspx)
