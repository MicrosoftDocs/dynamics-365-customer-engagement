---
title: "Marketing settings tab in Dynamics 365 Customer Engagement (on-premises)"
description: "From the System Settings Marketing tab in Dynamics 365 Customer Engagement (on-premises), set options related to how users run marketing campaigns via email."
keywords: 

ms.custom: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 873c4108-7757-4b38-b734-8b1d5ceddc58
author: shubhadaj
ms.author: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 11
topic-status: Drafting
search.audienceType: 
  - admin
---

# Configure system settings from the Marketing tab

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

Use the settings on this page to configure marketing settings for Dynamics 365 Customer Engagement (on-premises).  

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
|                                           Create campaign responses for incoming email                                            |                     Default: Yes. If Yes, Customer Engagement (on-premises) creates campaign response records automatically when email messages are received in response to a specific marketing campaign.                     |
|                        **Set the auto-unsubscribe options (Available only if Email tracking is enabled)**                         |                                                                                                                                                                                                                                                          |
|                          Set "Do Not Send Marketing Material" option when unsubscribe email is received                           |                         Default: No. If Yes, when an unsubscribe email is received, the preference setting for the account, contact, or lead from the marketing list gets updated automatically to not send marketing materials.                         |
|                                      Send acknowledgement to customers when they unsubscribe                                      |                                                 If the previous setting **Set “Do Not Send Marketing Material”** is Yes, you can use this setting to send a response to customers when they unsubscribe.                                                 |
|                                                Template for Acknowledgement Email                                                 |                                                              If the two previous settings are Yes, you must specify an email template to use to respond to customers when they unsubscribe.                                                              |



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
