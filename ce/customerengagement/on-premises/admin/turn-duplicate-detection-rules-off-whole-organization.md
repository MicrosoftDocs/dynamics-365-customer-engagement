---
title: "Turn duplicate detection rules on or off for the whole organization for Dynamics 365 for Customer Engagement apps | MicrosoftDocs"
ms.custom: 
ms.date: 09/30/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 8c34ccb0-333f-4e03-8faa-e241dbadbbba
caps.latest.revision: 40
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin

---
# Turn duplicate detection rules on or off for the whole organization

*This content also applies to the on-premises version.*

To maintain the integrity of your data, it’s a good idea to set up duplicate detection rules to reduce duplicate records in the system. Remember that after you create duplicate detection rules, you need to turn them on.  
  
1. [!INCLUDE[proc_permissions_mgr_vp_sys_admin_sys_cust](../includes/proc-permissions-mgr-vp-sys-admin-sys-cust.md)]  
  
    Check your security role  
  
   1. [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   2. Don’t have the correct permissions? Contact your system administrator.  
  
2. [!INCLUDE[proc_settings_datamanagement](../includes/proc-settings-datamanagement.md)]  
  
3. Choose **Duplicate Detection Settings**.  
  
4. Select or clear the **Enable duplicate detection** check box.  
  
   > [!NOTE]
   >  If your system contains a large number of records, checking for duplicates can impact performance.  
  
5. If you’re turning duplicate detection on, select or clear the check boxes to set when duplicates are detected:  
  
   - **When a record is created or updated**  
  
        The system checks for duplicates when a user enters or updates records.  
  
       > [!IMPORTANT]
       >  Duplicates aren’t detected when a user merges two records, activates or deactivates a record, or saves a completed activity.  
  
   - **When [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps for [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)] goes from offline to online**  
  
        For users of [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps for [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)], the system detects duplicates when the user synchronizes their data after working offline, as long as users have enabled duplicate detection in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)]. To enable duplicate detection in [!INCLUDE[pn_Outlook_short](../includes/pn-outlook-short.md)], choose **File** > **Dynamics 365**  > **Options**. Choose the **Local Data** tab, and then select the **Enable duplicate detection during offline to online synchronization** check box.  
  
   - **During data import**  
  
        When you use the Import Data wizard to bring in contacts, leads, accounts, or other types of data, the wizard detects any duplicate records as long as you enable duplicate detection in the wizard. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Import accounts, leads, or other data](../basics/import-accounts-leads-other-data.md)  
  
6. Choose **OK**.  
  
### See also  
 [Set up duplicate detection rules to keep your data clean](../admin/set-up-duplicate-detection-rules-keep-data-clean.md)   
 [Frequently asked questions about synchronizing records between Microsoft Dynamics 365 for Customer Engagement apps and Microsoft Outlook](frequently-asked-questions-synchronizing-records-dynamics-365-and-outlook.md)   
 [Run bulk system jobs to detect duplicate records](../admin/run-bulk-system-jobs-detect-duplicate-records.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]