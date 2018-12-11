---
title: "System Settings dialog box - Mobile Client tab for Dynamics 365 for Customer Engagement apps | MicrosoftDocs"
ms.custom: 
ms.date: 04/20/2018
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 625c1d05-91d1-4239-b68a-7b08919c8d57
caps.latest.revision: 1
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# System Settings dialog box - Mobile Client tab

[!INCLUDE[cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]

Use the settings on this page to...

## Open the System Settings dialog box (if it’s not already open)  

1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  

    Check your security role  

   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  

   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  

2. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  

3. Choose the **System Settings** > **Mobile Client** tab.  

> [!NOTE]
> - In Dynamics 365 for Customer Engagement, version 8.2, the tab is **Mobile**. 
> - At the time of writing, Dynamics 365 for Customer Engagement, version 9.0.1 does not have this setting. Version 9.0.2 does.

|                           Settings                            |                                                                                                                                                                                                                                         Description                                                                                                                                                                                                                                          |
|---------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Set conflict detection for mobile offline synchronization** |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
|      Enable conflict for mobile offline synchronization       | If Yes, sync conflict detection will be enabled during the play back of actions after an offline device comes back online. If No, the default, no conflict detection is done while playing back actions after an offline device comes back online. The changes done offline will overwrite any changes done in Dynamics 365 for Customer Engagement.<br/>For more information, see "Sync conflict resolution" in [Work offline with Dynamics 365 for Customer Engagement apps for phones and tablets](../mobile-app/v8/go-mobile/work-offline.md) |

