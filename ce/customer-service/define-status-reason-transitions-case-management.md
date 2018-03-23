---
title: "Define status reason transitions for case management (Dynamics 365 for Customer Service) | MicrosoftDocs"
ms.custom: ""
ms.date: 09/15/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: "shubhadaj"
ms.assetid: bdaec3df-f08e-4d2a-b2bc-f9706a853c69
caps.latest.revision: 20
ms.author: "shujoshi"
manager: "sakudes"
---
# Define status reason transitions for case management (Customer Service)

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

If you’re in charge of incident management for an organization, it’s important to provide a simple model for customer service representatives responsible for entering and updating case status. In [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], there are two fields in the Case entity (record type) that work together to provide information about case status: the **Status** field and the **Status Reason** field. The **Status** field for the **Case** entity has three possible values: **Active**, **Resolved**, or **Canceled**. The **Status Reason** field stores a reason for a specific status value. For example, for a case with an **Active** status, a status reason could be **In Progress**, **On Hold**, **Waiting for Details**, or **Researching**.  

> [!IMPORTANT]
> This feature was introduced in [!INCLUDE[pn_crm_online_2016_update_shortest](../includes/pn-crm-online-2016-update-shortest.md)]. 

 Big organizations often have a large number of combinations for the **Status** and **Status Reason** fields. This can make it difficult for customer service reps to choose the correct next status reason. You can define status reason transitions to add another level of filtering for what the status reason value can be changed to for each status reason. Limiting these values to just allowed status reasons can help customer service representatives make the right choices.  
  
 ![Screenshot of status transition values on form](../customer-service/media/crm-ua-status-transition-value-overview.PNG "Screenshot of status transition values on form")  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
2. [!INCLUDE[proc_settings_customization](../includes/proc-settings-customization.md)]  
  
3.  Click **Customize the System**.  
  
4.  In the solution explorer, in the left navigation pane, expand **Entities**, expand the **Case** entity, and then double-click **Fields**.  
  
5.  Go to the second page of fields, and then open the **statuscode** (Status Reason of Case) field.  
  
6.  In the **Field: Status Reason** dialog box, click **Edit Status Reason Transitions** at the top of the dialog box.  
  
 ![Screenshot of status reason transitions dialog](../customer-service/media/crm-ua-admin-status-reason-transition.PNG "Screenshot of status reason transitions dialog")  
  
7.  In the **Status Reason Transitions** dialog box, under **New Status Reasons**, click one of the **Enter Value** buttons ![Enter Value button in Status Reason dialog box](../customer-service/media/crm-ua-enter-value-button-status-reason-transition.PNG "Enter Value button in Status Reason dialog box") corresponding with one of the existing status reasons.  
  
8.  In the **Select Status Reason** dialog box, in the **Available Values** list, select the values you want to add, and then click the chevron button ![Screenshot of chevron button to move items](../customer-service/media/crm-ua-chevron-button-status-reason-transition.PNG "Screenshot of chevron button to move items") to add to the **Selected Values** list. Click **OK** when you’re done with that status reason.  
  
9. Click another **Enter Value** button ![Enter Value button in Status Reason dialog box](../customer-service/media/crm-ua-enter-value-button-status-reason-transition.PNG "Enter Value button in Status Reason dialog box") to modify other status reasons. When you’re done, click **OK**.  
  
    > [!NOTE]
    >  Each status reason option for an active status must allow at least one path to an inactive status. Otherwise, you could create a condition where it would not be possible to resolve or cancel a case.  
  
10. In the **Status Reason Transitions** dialog box, select the **Enable Status Reason Transitions** check box to apply the defined status reason transitions to case records. The list of available status reasons will be filtered for each case record based on the defined transitions.  
  
### See also  
 [Define status reason transitions](../customize/define-status-reason-transitions.md)   
 [Create or edit entity fields](../customize/create-edit-fields.md)
