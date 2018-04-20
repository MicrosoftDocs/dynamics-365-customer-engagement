---
title: "System Settings dialog box - Mobile Client tab for Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 04/20/2018
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 625c1d05-91d1-4239-b68a-7b08919c8d57
caps.latest.revision: 1
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# System Settings dialog box - Mobile Client tab

[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

Use the settings on this page to...
  
## Open the System Settings dialog box (if it’s not already open)  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  
  
3.  Choose the **System Settings** > **Mobile Client** tab.  
  
> [!NOTE]
> - In Dynamics 365, version 8.2, the tab is **Mobile**. 
> - At the time of writing, Dynamics 365, version 9.0.1 does not have this setting. Version 9.0.2 does.

|Settings|Description|  
|--------------|-----------------|  
|**Set conflict detection for mobile offline synchronization**||
|Enable conflict for mobile offline synchronization|If Yes, sync conflict detection will be enabled during playback of actions after an offline device comes back online. If No, the default, no conflict detection is done while playing back actions after an offline device comes back online. The changes done offline will overwrite any changes done in Dynamics 365.<br/>For more information, see "Sync conflict resolution" in [Work offline with Dynamics 365 for phones and tablets](../mobile-app/v8/go-mobile/work-offline.md)|.