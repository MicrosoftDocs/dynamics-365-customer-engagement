---
title: "System Settings dialog box - Outlook tab  | MicrosoftDocs"
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: f9b49c8f-c434-41d3-aa4c-365a4498b4f7
caps.latest.revision: 13
author: jimholtz
ms.author: jimholtz
search.audienceType: 
  - admin
---
# System Settings dialog box - Outlook tab

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

Use the settings on this page to configure how [!INCLUDE[pn_MS_Outlook_Short](../includes/pn-ms-outlook-short.md)] interacts with Dynamics 365 Customer Engagement (on-premises).  

## Open the System Settings dialog box (if it’s not already open)  

1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  

    Check your security role  

   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  

   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  

2. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  

3. Choose **System Settings** > **Outlook** tab.  

|                                                                      Settings                                                                      |                                                                                                   Description                                                                                                   |
|----------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                  **Set email promotion options for [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)]**                   |                                                                                                                                                                                                                 |
|                                                      Perform checks as new email is received                                                       |                                                                   Default: Yes. If Yes, email is checked for tracking as soon as it arrives.                                                                    |
|                                                            Promote incoming email every                                                            |                                                               Default: 10 minutes. Looks for and links incoming email on the specified interval.                                                                |
|                                                       Send pending Dynamics 365 for Customer Engagement apps email every                                                        |                                         Default: 10 minutes. Sends pending Customer Engagement (on-premises) email on the specified interval.                                         |
|         **Set whether users can schedule synchronization in [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)]**          |                                                                                                                                                                                                                 |
|                                                         Users can schedule synchronization                                                         | Default: Yes. If Yes, users can set whether or not [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] synchronizes with Customer Engagement (on-premises). |
|                                                       Minimum Time between synchronizations                                                        |   Default: 15 minutes. Synchronizes [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] and Customer Engagement (on-premises) on the specified interval.    |
| **Set whether users can update their local data in the background in [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)]** |                                                                                                                                                                                                                 |
|                                              Users can schedule background local data synchronization                                              |                                                        Default: Yes. If Yes, users can update the data that is stored on their computer to use offline.                                                         |
|                                            Minimum time between background local data synchronizations                                             |                                   Default: 15 minutes. Local data is synchronized with Customer Engagement (on-premises) on the specified interval.                                   |
|                                   **Set schedule for address book synchronization in Dynamics 365 for Outlook**                                    |                                                                                                                                                                                                                 |
|                                             Users can schedule background address book synchronization                                             |                                                    Default: Yes. If Yes, users can update the address book that is stored on their computer to use offline.                                                     |
|                                                 Minimum time between address book synchronizations                                                 |                               Default: 1 hour. The local address book is synchronized with Customer Engagement (on-premises) on the specified interval.                               |
|                                              **Set whether users see Microsoft Dynamics 365 for Customer Engagement apps message**                                              |                                                                                                                                                                                                                 |
|         Users see “Get [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)]” option displayed in the message bar          |                                 Default: Yes. If Yes, the **Get Dynamics 365 for Outlook** button is displayed in Customer Engagement (on-premises).                                  |



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]