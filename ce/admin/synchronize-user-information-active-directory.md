---
title: "Synchronize user information between Dynamics 365 Customer Engagement and Active Directory | MicrosoftDocs"
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
author: "jimholtz"
ms.assetid: 137b4aa7-2c90-4584-a2bd-38c812788121
caps.latest.revision: 23
ms.author: "rdubois"
manager: "brycho"
---
# Synchronize user information with Active Directory

[!INCLUDE[pn-dyn-365-op](../includes/pn-dyn-365-op.md)]

[!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] supports two methods for authenticating users:  
  
-   Integrated [!INCLUDE[pn_Windows_Authentication](../includes/pn-windows-authentication.md)]  
  
-   Claims-based authentication  
  
By default, customers who purchase [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] and deploy it on-premises use [!INCLUDE[pn_Windows_Authentication](../includes/pn-windows-authentication.md)]. These customers also can set up claims-based authentication for Internet-facing deployments (IFDs) of the product.  
  
With integrated [!INCLUDE[pn_Windows_Authentication](../includes/pn-windows-authentication.md)], each user record in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] must be associated with a user account in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] to enable log on to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. When the user records are associated, [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] automatically reads and stores other information about the user record (including the first and last name, the email address, and the globally unique identifier, or GUID) from the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] directory service.  
  
However, changes to the [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] information associated with a specific user can create discrepancies with the information maintained in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], thereby preventing the user from accessing [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)]. Specifically, if value of the **User SamAccountName logon** attribute in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] changes for a user, the corresponding user information in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] won’t match and the user won’t be able log on..  
  
To ensure that the user can successfully log on to [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)], you must update the information in the [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] user record so that it matches the detail in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)].  
  
Before you start, be sure to record the value of the **User SamAccountName logon** attribute for the affected user before updating the corresponding user record in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
> [!NOTE]
>  For information about synchronizing [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] with [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)], see the blog post [How to Synchronize CRM Online with your Active Directory](http://blogs.msdn.com/b/crm/archive/2013/07/18/how-to-synchronize-crm-online-with-your-active-directory.aspx).  
  
1. [!INCLUDE[proc_settings_security](../includes/proc-settings-security.md)]  
  
2.  Choose **Users**.  
  
3.  In the list of users, choose to select the user record you want to update, and then choose **Edit**.  
  
4.  In the **User Name** text box, type an [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] user name that isn’t used by any [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] user record.  
  
    > [!IMPORTANT]
    >  If you specify a user name that already exists in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)], [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] will try to map the user to the updated user in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)], and when it locates an existing record with the same GUID, the mapping will fail.  
  
     If all the user accounts in [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] are used by [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] user records, create a temporary [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] user account.  
  
5.  Save the user record, and then in the **User Name** text box, type in the **User SamAccountName logon** value that appears for the user [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)], which you recorded prior to starting this procedure.  
  
6.  Choose **Save and Close**.  
  
### See also  
 [Manage security, users and teams](../admin/manage-security-users-and-teams.md)   
 [Add or remove territory members](../admin/add-remove-territory-members.md)
