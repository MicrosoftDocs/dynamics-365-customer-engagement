---
title: "Troubleshoot read-write access in Dynamics 365 Customer Engagement (on-premises)"
description: "If a user doesn't have sufficient permissions, a system administrator must follow these steps to ensure that Read permission is set for User Entity UI Settings."
ms.custom: 
ms.date: 10/01/2019
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 516100e9-cc32-4e3a-bdff-1820f260ea41
caps.latest.revision: 8
author: Mattp123
ms.author: matp
search.audienceType: 
  - admin
---
# Troubleshoot read-write access for a user

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

If you don’t have sufficient permissions to access Dynamics 365 Customer Engagement (on-premises), a system administrator will need to do the following:  
  
1. [!INCLUDE[proc_settings_security](../includes/proc-settings-security.md)]  
  
2. Choose **Users**.  
  
3. Open the user record.  
  
4. Choose **More Commands** (![More commands button.](../admin/media/not-available.gif "More commands button")) > **Manage Roles**.  
  
5. Make note of the role assigned to the user. If appropriate, select a different security role. Close the Manage User Roles dialog box.  
  
6. Choose **Security** > **Security Roles**.  
  
7. Choose the security role from step 4.  
  
8. Choose **Core Records**.  
  
9. Confirm that the **Read** permission for **User Entity UI Settings** is set to the User level (a yellow circle with a wedge-shaped segment).  
  
     If the security role is missing this permission, the system administrator will need to change this setting by clicking or tapping on it.  
  
   ![User Entity UI settings.](../admin/media/user-entity.png "User Entity UI settings")  
  
> [!NOTE]
>  If you have multiple security roles assigned, confirm that at least one assigned role has the User Entity UI Settings privilege set to the User level.  
  
### See also  
 [Manage security, users and teams](../admin/manage-security-users-and-teams.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
