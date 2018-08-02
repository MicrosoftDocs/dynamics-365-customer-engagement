---
title: "System Settings dialog box - Marketing tab for Dynamics 365 Customer Engagement | MicrosoftDocs"
description: ""
keywords: ""
ms.date: 09/30/2017
ms.service: crm-online
ms.custom: 
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 873c4108-7757-4b38-b734-8b1d5ceddc58
author: shubhadaj
ms.author: shujoshi
manager: sakudes
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 11
topic-status: Drafting
---

# System Settings dialog box - Marketing tab

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

Use the settings on this page to configure marketing settings for [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  

## Open the Marketing System Settings dialog box (if it isn’t already open)  

1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  

    Check your security role  

   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  

   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  

2. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  

3. Choose **System Settings** > **Marketing** tab.  

|                                                             Settings                                                              |                                                                                                                       Description                                                                                                                        |
|-----------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                              **Set whether direct email through mail merge is enabled in campaigns**                              |                                                                                                                                                                                                                                                          |
|                                                Enable Direct Email via Mail Merge                                                 | Default: Yes. If Yes, users can send email as a campaign activity using the mail merge feature. **Note:**  To enable this option, the security role assigned to users for whom you want to enable mail merge must also include the Mail Merge privilege. |
| **Set whether campaign responses are created for incoming campaign activity email (Available only if Email tracking is enabled)** |                                                                                                                                                                                                                                                          |
|                                           Create campaign responses for incoming email                                            |                     Default: Yes. If Yes, [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] creates campaign response records automatically when email messages are received in response to a specific marketing campaign.                     |
|                        **Set the auto-unsubscribe options (Available only if Email tracking is enabled)**                         |                                                                                                                                                                                                                                                          |
|                          Set "Do Not Send Marketing Material" option when unsubscribe email is received                           |                         Default: No. If Yes, when an unsubscribe email is received, the preference setting for the account, contact, or lead from the marketing list gets updated automatically to not send marketing materials.                         |
|                                      Send acknowledgement to customers when they unsubscribe                                      |                                                 If the previous setting **Set “Do Not Send Marketing Material”** is Yes, you can use this setting to send a response to customers when they unsubscribe.                                                 |
|                                                Template for Acknowledgement Email                                                 |                                                              If the two previous settings are Yes, you must specify an email template to use to respond to customers when they unsubscribe.                                                              |

