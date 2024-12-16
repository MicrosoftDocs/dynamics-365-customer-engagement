---
title: "Reporting settings tab in Dynamics 365 Customer Engagement (on-premises)"
description: "From the System Settings Reporting tab in Dynamics 365 Customer Engagement (on-premises), specify report categories and allow Power BI embedding."
ms.custom: 
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 79a9aa1f-6e5d-4b68-86f7-230b4f68fa60
caps.latest.revision: 11
author: Mattp123
ms.author: matp
search.audienceType: 
  - admin
---
# Specify system settings from the Reporting tab

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

Use the settings on this page to configure reporting settings for Dynamics 365 Customer Engagement (on-premises).  

## Open the Reporting System Settings dialog box (if it’s not already open)  

1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  

    Check your security role  

   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  

   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  

2. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  

3. Choose **System Settings** > **Reporting** tab.  

|                     Settings                     |                                                                                                                                                                                                                                                                                                                                                                 Description                                                                                                                                                                                                                                                                                                                                                                  |
|--------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|          **Specify report categories**           |                                                                                                                                                                                     Default categories:<br /><br /> -   Sales reports<br />-   Service reports<br />-   Marketing reports<br />-   Administrative reports **Note:**  If you add a new category or change existing categories, you should also change the default views available for the Report record type. Otherwise, users won't have a way to see all reports in the new categories.                                                                                                                                                                                     |
|                  Default value                   |                                                                                                                                                                                                                                                                                                                                               Unassigned. Select the default report category.                                                                                                                                                                                                                                                                                                                                                |

### See also  
 [System Settings dialog box - General tab](../admin/system-settings-dialog-box-general-tab.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
