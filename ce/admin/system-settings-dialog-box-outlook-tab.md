---
title: "System Settings dialog box - Outlook tab for Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: f9b49c8f-c434-41d3-aa4c-365a4498b4f7
caps.latest.revision: 13
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# System Settings dialog box - Outlook tab

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

Use the settings on this page to configure how [!INCLUDE[pn_MS_Outlook_Short](../includes/pn-ms-outlook-short.md)] interacts with [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  

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
|                                                       Send pending Dynamics 365 email every                                                        |                                         Default: 10 minutes. Sends pending [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] email on the specified interval.                                         |
|         **Set whether users can schedule synchronization in [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)]**          |                                                                                                                                                                                                                 |
|                                                         Users can schedule synchronization                                                         | Default: Yes. If Yes, users can set whether or not [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] synchronizes with [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. |
|                                                       Minimum Time between synchronizations                                                        |   Default: 15 minutes. Synchronizes [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] and [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] on the specified interval.    |
| **Set whether users can update their local data in the background in [!INCLUDE[pn_crm_for_outlook_full](../includes/pn-crm-for-outlook-full.md)]** |                                                                                                                                                                                                                 |
|                                              Users can schedule background local data synchronization                                              |                                                        Default: Yes. If Yes, users can update the data that is stored on their computer to use offline.                                                         |
|                                            Minimum time between background local data synchronizations                                             |                                   Default: 15 minutes. Local data is synchronized with [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] on the specified interval.                                   |
|                                   **Set schedule for address book synchronization in Dynamics 365 for Outlook**                                    |                                                                                                                                                                                                                 |
|                                             Users can schedule background address book synchronization                                             |                                                    Default: Yes. If Yes, users can update the address book that is stored on their computer to use offline.                                                     |
|                                                 Minimum time between address book synchronizations                                                 |                               Default: 1 hour. The local address book is synchronized with [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] on the specified interval.                               |
|                                              **Set whether users see Microsoft Dynamics 365 message**                                              |                                                                                                                                                                                                                 |
|         Users see “Get [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)]” option displayed in the message bar          |                                 Default: Yes. If Yes, the **Get Dynamics 365 for Outlook** button is displayed in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].                                  |

