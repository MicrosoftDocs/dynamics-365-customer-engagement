---
title: "Troubleshooting: User needs read-write access to the Dynamics 365 for Customer Engagement apps organization | MicrosoftDocs"
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
ms.assetid: 516100e9-cc32-4e3a-bdff-1820f260ea41
caps.latest.revision: 8
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Troubleshooting: User needs read-write access

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc_applies_to_on-prem-9_0_0](../includes/cc_applies_to_on-prem-9_0_0.md)]

You don’t have sufficient permissions to access [!INCLUDE[pn_microsoftcrm](../includes/pn-dynamics-crm.md)] apps. A [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps system administrator will need to do the following in the [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps:  
  
1. [!INCLUDE[proc_settings_security](../includes/proc-settings-security.md)]  
  
2. Choose **Users**.  
  
3. Open the user record.  
  
4. Choose **More Commands** (![More commands button](../admin/media/not-available.gif "More commands button")) > **Manage Roles**.  
  
5. Make note of the role assigned to the user. If appropriate, select a different security role. Close the Manage User Roles dialog box.  
  
6. Choose **Security** > **Security Roles**.  
  
7. Choose the security role from step 4.  
  
8. Choose **Core Records**.  
  
9. Confirm that the **Read** permission for **User Entity UI Settings** is set to the User level (a yellow circle with a wedge-shaped segment).  
  
     If the security role is missing this permission, the system administrator will need to change this setting by clicking or tapping on it.  
  
   ![User Entity UI settings](../admin/media/user-entity.png "User Entity UI settings")  
  
> [!NOTE]
>  If you have multiple security roles assigned, confirm that at least one assigned role has the User Entity UI Settings privilege set to the User level.  
  
### See also  
 [Manage security, users and teams](../admin/manage-security-users-and-teams.md)
