---
title: "Goals settings tab in Dynamics 365 Customer Engagement (on-premises)"
description: "From the System Settings Goals tab in Dynamics 365 Customer Engagement (on-premises), Set the duration and frequency of the automatic rollup of goals."
keywords: 
ms.date: 09/13/2021

ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 14c34660-19df-40cb-bf84-3878dcfa3787
author: Mattp123
ms.author: matp
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 12
---
# Define system settings from the Goals tab

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

Set the duration and frequency of the automatic rollup of goals. These settings only affect the automatic handling of all goals set in Dynamics 365 Customer Engagement (on-premises). You can always perform a manual rollup for any goal at any time.  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
   - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. If you are using a Sales web application, go to **Settings** > **Administration** > **System Settings**, and then select the **Goals** tab.

   OR

   If you are using the Sales Hub App, select the Site map icon ![Site map icon](../../../sales/media/site-map-icon.png "Site map icon"), then select ellipsis ![Ellipsis to open more options](../../../sales/media/ellipsis-more-options.png "Ellipsis to open more options") , then select **App Settings**, and then select **Goals Settings**.
  
  
|                            Settings                            |                                                                                  Description                                                                                   |
|----------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Set the roll-up expiration time and the roll-up frequency.** |                                                                                                                                                                                |
|     Days after the goal end date when the rollup will stop     | Set the number of days after the ending date of a goal for Customer Engagement (on-premises) to stop including a goal in a rollup. <br> **Default:** 30 days. |
|                  Roll-up recurrence frequency                  |                                                     Set the number of hours between each goal rollup.<br>**Default**: 24 <br>**Limits**: Must be greater than or equal to 24 hours                                                      |
  
### See also  
 [Administrator and Sales Manager Guide](../../../sales/admin-guide.yml)  
 [Progress Against Goals report](../basics/sales-insights-reports.md#BKMK_ProgressGoals)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
