---
title: "Create custom business logic through processes with Dynamics 365 Customer Engagement (on-premises) | MicrosoftDocs"
description: "Learn about the different types of business logic you can use in your app"
ms.custom: 
ms.date: 01/23/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: get-started-article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
ms.assetid: 0b4e6602-5701-4859-81cc-6f6fe50901b2
caps.latest.revision: 44
author: Mattp123
ms.author: matp
manager: kvivek
search.audienceType: 
  - customizer

---
# Create custom business logic through processes

[!INCLUDE [applies-to-on-premises](../includes/applies-to-on-premises.md)] [Apply custom business logic with business rules and flows in model-driven apps](/powerapps/maker/model-driven-apps/guide-staff-through-common-tasks-processes)

Defining and enforcing consistent business processes is one of the main reasons people use Dynamics 365 Customer Engagement (on-premises). Consistent processes help make sure people using the system can focus on their work and not on remembering to perform a set of manual steps. Processes can be simple or complex and can change over time.  

Dynamics 365 Customer Engagement (on-premises) includes four types of processes, each designed for a different purpose:  
  
- Business process flows  
  
- Mobile task flows  
  
- Workflows  
  
- Actions  
  
  Similar to processes, you can also create  business rules and recommendations. For more information, see [Create business rules and recommendations to apply logic in a form](../customize/create-business-rules-recommendations-apply-logic-form.md)  

<!-- >> [!NOTE]
>  Using processes can impact the license requirements for Dynamics 365 Customer Engagement (on-premises) and flows. For more information, see [Entity license requirements](/powerapps/maker/common-data-service/data-platform-entity-licenses).  -->


<a name="BKMK_BP"></a>   
## When to use business process flows

 Use a business process flow when you want staff to move through the same stages and follow the same steps to interact with a customer. For example, use a business process flow if you want everyone to handle customer service requests the same way, or to require staff to gain approval for an invoice before submitting an order.  
  
 Your environment includes several ready-to-use business process flows for common sales, service, and marketing tasks that you can use with little or no changes required. Or, you can create your own. See the following topics for more information on business process flows:  
  
-   [Create a business process flow](../customize/create-business-process-flow.md)  
  
  
-   [Add ready-to-use business processes](../customize/add-ready-use-business-processes.md)    
  
<a name="BKMK_TF"></a>   
## When to use mobile task flows

 You can also design a type of business process flow called a task flow in [!INCLUDE[pn_Mobile_Express_short](../includes/pn-mobile-express-short.md)] or [!INCLUDE[pn_moca_short](../includes/pn-moca-short.md)] based on common tasks your users perform. For example, if they need to regularly perform a series of follow-up steps after client meetings, create a task flow. When users tap the new task in their mobile app, it will lead them through from start to finish so they don't forget an important step. For more information on task flows, see the following topics:  
  
-   [Create a mobile task flow](../customize/create-mobile-task-flow.md)   
  
<a name="BKMK_WF"></a>   
## When to use workflows  
 Use workflows to automate business processes behind the scenes. Workflows are typically initiated by system events so the user doesn't need to be aware that they are running. Workflows that operate in the background are "asynchronous." Workflows can also be configured for people to manually initiate them. when you want to automate common tasks, such as automatically sending a confirmation email to a customer when an order ships. Workflows that operate in real time are "synchronous." For more information on workflows, see  [Workflow processes](../customize/workflow-processes.md)  

<a name="BKMK_Actions"></a>   
## When to use Actions  
 Use Actions when you want to automate a series of commands in the system. Actions expand the vocabulary available for developers to express business processes. With core verbs like Create, Update, Delete, and Assign provided by the system, a Action uses those core verbs to create more expressive verbs like Approve, Escalate, Route, or Schedule. If the definition of a business process changes, someone who isn’t a developer can edit the Action so the code doesn’t need to be changed.  For more information on Actions, see  [Actions](../customize/actions.md)  
  
<a name="useMSFlow"></a>   
## When to use Power Automate  
 Use Power Automate when you need to create automated workflows that perform actions between your environment and favorite app or service, such as [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], [!INCLUDE[tn_twitter](../includes/tn-twitter.md)], Dropbox, Google services, Microsoft 365, and [!INCLUDE[pn_SharePoint_short](../includes/pn-sharepoint-short.md)]. You can trigger a flow based on a specific action, or invoke from within your app. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Use Power Automate to automate processes across services](/powerapps/user/use-flows)  
  
<a name="BKMK_Where"></a>   
## Where do I go to create processes?  
 There are two paths to navigate to processes:  
  
- **Settings>Processes.** in Dynamics 365 Customer Engagement (on-premises) this path is easiest to access and allows you to use views defined for the Process entity, including any custom views.  
  
- In solution explorer. **Components > Processes.** This path provides convenient access when you are doing other customization work in the customization tools.  
  
  Individual business process flows can also be edited using the **Edit Process** button in the command bar for the form where the business process flow is active.  
  
<a name="BKMK_WhoCreate"></a>   
## Who can create processes?  
 Only people with the System Administrator, System Customizer, or CEO-Business Manager security role can create processes that apply to the whole organization. People with other roles can create processes with limited access level. For example, people with the User access level can create workflows for their own use with records they own.  
  
 The following table shows the access level of processes based on default security roles.  
  
|**Security role**|**Access level**|  
|-|-|  
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
## More about workflows and Actions  
 Processes can check conditions, apply branching logic, and perform actions. They perform these actions in a series of steps. The following table describes the available steps in workflow and action processes. For more detail see the topics for each type of process.  
  
|Step|Process type|Description|  
|----------|------------------|-----------------|  
|**Stage**|Workflow, Action|Stages make the workflow logic easier to read, and explain the workflow logic. However, stages don’t affect the logic or behavior of workflows. If a process has stages, all the steps in the process must be contained with a stage.|  
|**Check Condition**|Workflow, Action|A logical "if-\<condition> then" statement.<br /><br /> You can check values for the record that the workflow is running on, any of the records linked to that record in an N:1 relationship, or any records created by earlier steps. Based on these values you can define additional steps when the condition is `true`.|  
|**Conditional Branch**|Workflow, Action|A logical "else-if-then" statement, the editor uses the text “Otherwise, if \<condition> then:”<br /><br /> Select a check condition you have previously defined and you can add a conditional branch to define additional steps when the check condition returns `false`.|  
|**Default Action**|Workflow, Action|A logical "else" statement. the editor uses the text “Otherwise:”<br /><br /> Select a check condition, conditional branch, wait condition, or parallel wait branch that you have previously defined and you can use a default action to define steps for all cases that don’t match the criteria defined in condition or branch elements.|  
|**Wait Condition**|Background Workflow Only|Enables a background workflow to pause itself until the criteria defined by the condition have been met. The workflow starts again automatically when the criteria in the wait condition have been met.|  
|**Parallel Wait Branch**|Background Workflow Only|Defines an alternative wait condition for a background workflow with a corresponding set of additional steps that are performed only when the initial criterion is met. You can use parallel wait branches to create time limits in your workflow logic. They help prevent the workflow from waiting indefinitely until the criteria defined in a wait condition have been met.|  
|**Assign Value**|Action|Sets a value to a variable or output parameter in the process.|  
|**Create Record**|Workflow, Action|Creates a new record for an entity and assigns values to attributes.|  
|**Update Record**|Workflow, Action|You can update the record that the workflow is running on, any of the records linked to that record in an N:1 relationship, or any records created by earlier steps.|  
|**Assign Record**|Workflow, Action|You can assign the record that the workflow is running on, any of the records linked to that record with an N:1 relationship, or any records created by earlier steps.|  
|**Send Email**|Workflow, Action|Sends an email. You can choose to create a new email message or use an email template configured for the entity of the record that the workflow is running on or any entities that have an N:1 relationship with the entity, or the entity for any records created by earlier steps.|  
|**Start Child Workflow**|Workflow, Action|Starts a workflow process that has been configured as a child workflow.|  
|**Change Status**|Workflow, Action|Changes the status of the record that the process is running on, any of the records linked to that record with an N:1 relationship, or any records created by earlier steps.|  
|**Stop Workflow**|Workflow, Action|Stops the current workflow or action. You can set a status of either **Succeeded** or **Canceled** and specify a status message.|  
|**Custom Step**|Workflow, Action|Provides extensions to the logical elements available by default. Steps can include conditions, actions, other steps, or a combination of these elements. Developers can create custom workflow steps. By default, there are no custom steps available.|

For more information for developers, see the Developer Guide topic [Automate your business processes in Customer Engagement apps](../developer/automate-business-processes-customer-engagement.md).
  
### See also  
 [Business process flows overview](../customize/business-process-flows-overview.md)   
 [Create a business process flow](../customize/create-business-process-flow.md)   
 [Create a mobile task flow](../customize/create-mobile-task-flow.md)   
 [Workflow processes](../customize/workflow-processes.md)   
 [Actions](../customize/actions.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]