---
title: "Choose the records to synchronize between Dynamics 365 Customer Engagement and Outlook or Exchange | MicrosoftDocs"
ms.custom: ""
ms.date: 10/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 413db37c-1f03-4fc0-aaf1-b13c12407c6c
caps.latest.revision: 53
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# Choose the records to synchronize between Dynamics 365 and Exchange 

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] uses online synchronization filters to determine which records to synchronize between [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] and [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] (using [!INCLUDE[cc_server_side_synch](../includes/cc-server-side-synch.md)]). You can modify the existing online synchronization filters or create new filters to synchronize certain types of records. You can also delete, deactivate, or activate filters.  
  
 Email is not included in the synchronization filters because email is controlled by when the email is created in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], whether the user is on the recipient list or not.   
  
## Create or modify online synchronization filters  
  
1. In the web app, in the upper-right corner of the screen, click the **Settings** button ![User profile Settings button](../outlook-app/media/priv-user.gif "User profile Settings button") > **Options**.  
  
2. In the **Set Personal Options** dialog box, click the **Synchronization** tab.  
  
3. Under **Synchronize [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] items with Outlook or Exchange**, click the **filters** link.  
  
   [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] displays the **Synchronization Settings for [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] or [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)]** dialog box with the **User Filters** tab selected. You can use this tab to create or edit a filter, or to delete, activate, or deactivate a filter.  
  
   ![Online synchronization filters](../outlook-app/media/online-sync-filters-dialog-box.PNG "Online synchronization filters")  
  
   > [!NOTE]
   > If you’re a system administrator, you can create or modify organization-wide filters (system filters) through the SDK. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Tell me more about system filters](../developer/outlook-client/offline-outlook-filters-templates.md) 
  
4. Do one of the following:  
  
   -   To open an existing filter, click the filter.  
  
   -   To create a new filter, click **New**.  
  
## Create or modify filter criteria  
 You use a criteria row to create or modify criteria in an offline synchronization filter. Each criteria row contains three values: the field to use in the filter (for example, **City**), an operator (for example, **Equals** or **Contains**), and the value to filter on (for example, **WA**).  
  
 ![Sync or offline filters criteria grid in Dynamics 365](../outlook-app/media/sync-filters-criteria-row.png "Sync or offline filters criteria grid in Dynamics 365")  
  
#### Add a criteria row  
  
1.  In the **Look for** list, select a record type.  
  
2.  Point to **Select** in the criteria grid, and then select the field to filter on from the list.  
  
3.  Select an operator from the list.  
  
4.  Enter a value to filter on.  
  
#### Group rows of criteria  
  
1. For each row you want to group, click the down arrow to the left of the field name, and then click **Select Row**.  
  
    To remove a row from a group, click the down arrow to the left of the field name, and then click **Delete**. To clear all rows from the criteria grid, click **Clear**.  
  
2. Click **Group AND** or **Group OR**.  
  
   After creating a group, you can click the down arrow next to the **And** or **Or** to select from different options. You can select a group, ungroup the group, change a Group AND to a Group OR or vice versa, add a clause, or delete a group.  
  
   ![Sync filters dialog box showing grouped criteria](../outlook-app/media/sync-filters-group-criteria.png "Sync filters dialog box showing grouped criteria")  
  
### See also  
 [Frequently asked questions about synchronizing records between Microsoft Dynamics 365 and Microsoft Outlook](frequently-asked-questions-synchronizing-records-dynamics-365-and-outlook.md) 

