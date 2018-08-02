---
title: "Create or edit a security role for Dynamics 365 Customer Engagement | MicrosoftDocs"
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
ms.assetid: 6c72559d-28a6-49ae-bb88-7a3eea6db611
caps.latest.revision: 33
author: "Mattp123"
ms.author: "matp"
manager: "brycho"
---
# Create or edit a security role to manage access

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../includes/cc_applies_to_update_8_2_0.md)]

You can create new security roles to accommodate changes in your business requirements or you can edit the privileges associated with an existing security role.  
  
 If you need to back up your security role changes, or export security roles for use in a different implementation of [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)], you can export them as part of exporting customizations. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Export your customizations as a solution](../customize/use-solutions-for-your-customizations.md)  
  
## Create a security role  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    Check your security role  
  
    - [!INCLUDE[proc_check_your_security_role](../includes/proc-check-your-security-role.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_security](../includes/proc-settings-security.md)]  
  
3.  Click **Security Roles**.  
  
4.  On the Actions toolbar, click **New**.  
  
5.  Set the privileges on each tab.  
  
     To change the access level for a privilege, click the symbol until you see the symbol you want. The possible access levels depend on whether the record type is organization-owned or user-owned.  
  
    > [!TIP]
    >  To cycle through the access levels, you can also click the privilege column heading, or click the record type multiple times.  
    >  There are a set of minimum privileges that are required in order for the new security role to be used - see below Minimum Privileges for common tasks.
  
6.  When you have finished configuring the security role, on the toolbar, click or tap **Save and Close**.  
  
## Create a security role by Copy Role

1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    Check your security role  
  
    - [!INCLUDE[proc_check_your_security_role](../includes/proc-check-your-security-role.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_security](../includes/proc-settings-security.md)]  
  
3.  Click **Security Roles**.  
  
4.  Click on the Security role you want to copy from.

5.  On the Actions toolbar, click **Copy Role**.  

6.  Enter the New Role Name, and check the box for **Open the new security role when copying is complete**.

7.  Click the OK button.
  
8.  When Copying Role is complete, navigate to each tab, ie Core Records, Business Management, Customization, etc.

9.  Set the privileges on each tab.

> [!TIP]
    >  To cycle through the access levels, you can also click the privilege column heading, or click the record type multiple times.  
    >  There are a set of minimum privileges that are required in order for the new security role to be used - see below Minimum Privileges for common tasks.

## Edit a security role  
 Before you edit an existing security role, make sure that you understand the principles of data access. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Controlling Data Access](../admin/security-roles-privileges.md)  
  
> [!NOTE]
>  You can’t edit the System Administrator security role. To create a security role similar to the System Administrator security role, copy the System Administrator security role, and make changes to the new role.  
  
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    Check your security role  
  
    - [!INCLUDE[proc_check_your_security_role](../includes/proc-check-your-security-role.md)]  
  
    - [!INCLUDE[proc_dont_have_correct_permissions](../includes/proc-dont-have-correct-permissions.md)]  
  
2. [!INCLUDE[proc_settings_security](../includes/proc-settings-security.md)]  
  
3.  Click **Security Roles**.  
  
4.  In the list of security roles, double-click or tap a name to open the page associated with that security role.  
  
5.  Set the privileges on each tab.  
  
     To change the access level for a privilege, click the symbol until you see the symbol you want. The possible access levels depend on whether the record type is organization-owned or user-owned.  
  
    > [!TIP]
    >  To cycle through the access levels, you can also click the privilege column heading, or click the record type multiple times.  
    >  There are a set of minimum privileges that are required in order for the new security role to be used - see below Minimum Privileges for common tasks. 
    
6.  When you have finished configuring the security role, on the toolbar, click or tap **Save and Close**.  
  
## Minimum privileges for common tasks  
 It's helpful to keep in mind the minimum privileges that are needed for some common tasks. These include:  
  
-   When logging in to [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)]:  
  
    -   Assign the following privileges on the Customization tab: Read Customizations, Read Process, Read System Form, Read View, and Read Web Resource.
  
    -   To render an entity grid (that is, to view lists of records and other data), assign the following privileges on the Core Records tab: Read privilege on the entity, Read Saved View, Create/Read/Write User Entity UI Settings
        and assign the following privilege on the Business Management tab: Read User   
  
-   When running PowerApps

-   When logging in to [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)]:  
  
    -   To render navigation for [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] and all [!INCLUDE[pn_dynamics_crm](../includes/pn-dynamics-crm.md)] buttons: Read Entity and Read View on the Customizations tab  
  
    -   To render an entity grid: Read privilege on the entity, Read Customizations and Read Web Resource on the Customization tab,  and Read Saved View on the Core Records tab  
  
    -   To render entities: Read privilege on the entity, Read System Form on the Customization tab, and Create, Read, and Write User Entity UI Settings on the Core Records tab  
  
## Privacy notices  
[!INCLUDE[cc_privacy_crm_for_phones](../includes/cc-privacy-crm-for-phones.md)]
  
[!INCLUDE[cc_privacy_crm_for_tablets](../includes/cc-privacy-crm-for-tablets.md)]
  
[!INCLUDE[cc_privacy_crm_go_offline_in_outlook](../includes/cc-privacy-crm-go-offline-in-outlook.md)]
  
[!INCLUDE[cc_privacy_crm_sync_to_outlook](../includes/cc-privacy-crm-sync-to-outlook.md)]
  
 [!INCLUDE[cc_privacy_export_to_excel](../includes/cc-privacy-export-to-excel.md)]
  
 [!INCLUDE[cc_privacy_crm_print](../includes/cc-privacy-crm-print.md)]
  
### See also  
 [Security concepts for Dynamics 365](../admin/security-concepts.md)   
 [Manage security, users and teams](../admin/manage-security-users-and-teams.md)   
 [Copy a security role](../admin/copy-security-role.md)
