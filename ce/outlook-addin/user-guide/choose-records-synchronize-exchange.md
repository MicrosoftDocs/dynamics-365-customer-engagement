---
title: "Choose the records to synchronize between Dynamics 365 apps and Outlook or Exchange | MicrosoftDocs"
ms.custom: 
ms.date: 01/11/2016
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 apps 
  - Dynamics 365 apps (on-premises)
  - Dynamics CRM 2013
  - Dynamics CRM 2015
  - Dynamics CRM 2016
  - Dynamics CRM Online
ms.assetid: 413db37c-1f03-4fc0-aaf1-b13c12407c6c
caps.latest.revision: 55
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---
# Choose the records to synchronize between Dynamics 365 apps and Outlook or Exchange
[!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] uses online synchronization filters to determine which records to synchronize between [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] and [!INCLUDE[pn_MS_Outlook_Short](../../includes/pn-ms-outlook-short.md)] (using [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)]), or [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] (using [!INCLUDE[cc_server_side_synch](../../includes/cc-server-side-synch.md)]). You can modify the existing online synchronization filters or create new filters to synchronize certain types of records. You can also delete, deactivate, or activate filters. You use the same set of filters (accessed through [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]) whether you’re synchronizing through [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)] or [!INCLUDE[cc_server_side_synch](../../includes/cc-server-side-synch.md)].  
  
 Email is not included in the synchronization filters because email is controlled by when the email is created in [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)], whether the user is on the recipient list or not. This is true for all email processing methods: [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)], [!INCLUDE[cc_server_side_synch](../../includes/cc-server-side-synch.md)], or [!INCLUDE[pn_emailrouter](../../includes/pn-emailrouter.md)].  
  
> [!TIP]
>  [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] also includes offline synchronization filters that you can use to choose records to work with offline in [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Choose records to work with offline in Dynamics 365 for Outlook](choose-records-work-offline.md)  
  
## Create or modify online synchronization filters  
  
1. Go to **Options**:  
  
   - In the web app: In the upper-right corner of the screen, click the **Settings** button ![User profile Settings button](../media/priv-user.gif "User profile Settings button") > **Options**.  
  
   - In [!INCLUDE[pn_crm_for_outlook_short](../../includes/pn-crm-for-outlook-short.md)]: Click **File** > **Dynamics 365 apps** > **Options**.  
  
2. In the **Set Personal Options** dialog box, click the **Synchronize** tab.  
  
3. Under **Synchronize [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] items with Outlook or Exchange**, click the **filters** link.  
  
    [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] displays the **Synchronization Settings for [!INCLUDE[pn_Outlook_short](../../includes/pn-outlook-short.md)] or [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)]** dialog box with the **User Filters** tab selected. You can use this tab to create or edit a filter, or to delete, activate, or deactivate a filter.  
  
    ![Online synchronization filters](../media/online-sync-filters-dialog-box.PNG "Online synchronization filters")  
  
   > [!NOTE]
   >  If you’re a system administrator, you can create or modify organization-wide filters (system filters) through the SDK. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [MSDN: Tell me more about system filters](https://msdn.microsoft.com/library/gg328205.aspx)  
  
4. Do one of the following:  
  
   -   To open an existing filter, click the filter.  
  
   -   To create a new filter, click **New**.  
  
## Create or modify filter criteria  
 You use a criteria row to create or modify criteria in an offline synchronization filter. Each criteria row contains three values: the field to use in the filter (for example, **City**), an operator (for example, **Equals** or **Contains**), and the value to filter on (for example, **WA**).  
  
 ![Sync or offline filters criteria grid in Dynamics 365 apps](../media/sync-filters-criteria-row.png "Sync or offline filters criteria grid in Dynamics 365 apps")  
  
### Add a criteria row  
  
1.  In the **Look for** list, select a record type.  
  
2.  Point to **Select** in the criteria grid, and then select the field to filter on from the list.  
  
3.  Select an operator from the list.  
  
4.  Enter a value to filter on.  
  
### Group rows of criteria  
  
1. For each row you want to group, click the down arrow to the left of the field name, and then click **Select Row**.  
  
    To remove a row from a group, click the down arrow to the left of the field name, and then click **Delete**. To clear all rows from the criteria grid, click **Clear**.  
  
2. Click **Group AND** or **Group OR**.  
  
   After creating a group, you can click the down arrow next to the **And** or **Or** to select from different options. You can select a group, ungroup the group, change a Group AND to a Group OR or vice versa, add a clause, or delete a group.  
  
   ![Sync filters dialog box showing grouped criteria](../media/sync-filters-group-criteria.png "Sync filters dialog box showing grouped criteria")  
  
### See also  
 [Choose records to work with offline in Dynamics 365 for Outlook](choose-records-work-offline.md)   


[!INCLUDE[footer-include](../../includes/footer-banner.md)]