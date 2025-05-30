---
title: "Use synchronization filters in Dynamics 365 Customer Engagement (on-premises)"
description: "Create or modify online synchronization filters to determine which records are synced between Customer Engagement (on-premises) and Exchange."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: how-to
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 413db37c-1f03-4fc0-aaf1-b13c12407c6c
caps.latest.revision: 53
author: Mattp123
ms.author: matp
search.audienceType: 
  - admin

---
# Use filters to synchronize records between Customer Engagement (on-premises) and Exchange

Dynamics 365 Customer Engagement (on-premises) uses online synchronization filters to determine which records to synchronize between Customer Engagement (on-premises) and [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)] (using [!INCLUDE[cc_server_side_synch](../includes/cc-server-side-synch.md)]). You can modify the existing online synchronization filters or create new filters to synchronize certain types of records. You can also delete, deactivate, or activate filters.  
  
 Email is not included in the synchronization filters because email is controlled by when the email is created in Customer Engagement (on-premises), whether the user is on the recipient list or not.   
  
## Create or modify online synchronization filters  
  
1. In the web app, in the upper-right corner of the screen, click the **Settings** button ![User profile Settings button.](media/priv-user.gif "User profile Settings button") > **Options**. 
  
2. In the **Set Personal Options** dialog box, click the **Synchronization** tab.  
  
3. Under **Synchronize [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps items with Outlook or Exchange**, click the **filters** link.  
  
   Customer Engagement (on-premises) displays the **Synchronization Settings for [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] or [!INCLUDE[pn_Exchange](../includes/pn-exchange.md)]** dialog box with the **User Filters** tab selected. You can use this tab to create or edit a filter, or to delete, activate, or deactivate a filter.  
  
   ![Online synchronization filters.](media/online-sync-filters-dialog-box.PNG "Online synchronization filters")  
  
   > [!NOTE]
   > If you’re a system administrator, you can create or modify organization-wide filters (system filters) through the SDK. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Tell me more about system filters](../developer/outlook-client/offline-outlook-filters-templates.md) 
  
4. Do one of the following:  
  
   -   To open an existing filter, click the filter.  
  
   -   To create a new filter, click **New**.  
  
## Create or modify filter criteria  
 You use a criteria row to create or modify criteria in an offline synchronization filter. Each criteria row contains three values: the field to use in the filter (for example, **City**), an operator (for example, **Equals** or **Contains**), and the value to filter on (for example, **WA**).  
  
 ![Sync or offline filters criteria grid.](media/sync-filters-criteria-row.png "Sync or offline filters criteria grid")  
  
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
  
   ![Sync filters dialog box showing grouped criteria.](media/sync-filters-group-criteria.png "Sync filters dialog box showing grouped criteria")  
  
### See also  
 [Frequently asked questions about synchronizing records between Customer Engagement (on-premises) and Microsoft Outlook](frequently-asked-questions-synchronizing-records-dynamics-365-and-outlook.yml) 



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
