---
title: "Create a mobile task flow (Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 046480e6-f2ff-4c56-9e03-f642c982ff7d
caps.latest.revision: 12
author: "rdubois"
ms.author: "rdubois"
manager: "brycho"
---
# Create a mobile task flow

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Design a flow in [!INCLUDE[pn_Mobile_Express_long](../includes/pn-mobile-express-long.md)] or [!INCLUDE[pn_moca_full](../includes/pn-moca-full.md)] based on common tasks your users perform. For example, if they need to regularly perform a series of follow-up steps after client meetings, create a task flow. When users tap the new task in their mobile app, it will lead them through from start to finish so they don't forget an important step.  
  
 Task flows can use multi-entity forms and logic, and can have form logic that runs across the task flow pages.  
  
## Create a task flow
  
1. [!INCLUDE[proc_permissions_mgr_vp_ceo_busmgr_sysadmin_syscust](../includes/proc-permissions-mgr-vp-ceo-busmgr-sysadmin-syscust.md)]  
  
    #### Check your security role  
  
   1. [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   2. [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_processes](../includes/proc-settings-processes.md)]  
  
3. On the **Actions** toolbar, click **New**.  
  
4. In the **Create Process** dialog box, complete the required fields:  
  
   -   Enter a process name.  
  
   -   In the **Category** list, select **Business Process Flow**.  
  
   -   In the **Entity** list, select the entity you want.  
  
5. Click the **Run process as a task flow (Mobile online)** option.  
  
6. [!INCLUDE[proc_click_or_tap_ok](../includes/proc-click-or-tap-ok.md)]  
  
     The task flow designer opens in a new window.  
  
   ![Task flow designer window](../customize/media/task-flow-designer-window.png "Task flow designer window")  
  
7. If your users will progress from one page to another in order, drag the **Page** component from the **Components** tab on the right side of the screen and drop it on the + sign in the appropriate spot. To add a name for a page, click the page, click the **Properties** tab, type a new name, and then click **Apply**.  
  
8. To add a branch to the task flow, drag the **Condition** component from the **Components** tab and drop it on the + sign in the appropriate spot. To set properties for the condition, click the condition, set the properties in the **Properties** tab, and then click **Apply**.  
  
   > [!NOTE]
   >  As you add pages and conditions to the task flow, you'll see a minimap in the lower-left corner of the window that shows all the pages and conditions in the task flow.  
  
9. To add a field, label,  or section label  to a page, drag **Field**, **Label**, or **Section Label** from the **Components** tab to the appropriate page. To change the properties for one of these items, click the item, set the properties in the **Properties** tab, and then click **Apply**.  
  
10. To validate the task flow, click **Validate** on the action bar.  
  
11. To save the process as a draft, click **Save** at the top of the screen. (As long as a process is a draft, people won’t be able to use it.)  
  
12. To activate the task flow so that people can use it, click **Activate**.  
  
> [!TIP]
>  Here are a few tips to keep in mind as you work on your task flow in the designer window:  
>   
> -  To take a snapshot of everything in the task flow window, click **Snapshot** on the action bar.  
> -  To connect a valid component to another valid component in the designer, click **Connector** on the action bar.  
> -  You can make the images on the screen larger or smaller by clicking the **Increase the zoom level** or **Decrease the zoom level** buttons in the upper-right corner of the screen. Click the **Fit to canvas** button to blow the images up to the largest size that fits on the screen.  
  
### See also  
 [Create a business process flow](../customize/create-business-process-flow.md)   
 [Create business rules and recommendations to apply logic in a form](../customize/create-business-rules-recommendations-apply-logic-form.md) <br/>
 [Create custom business logic with processes](../customize/guide-staff-through-common-tasks-processes.md)
