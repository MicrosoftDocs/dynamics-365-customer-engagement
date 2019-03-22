---
title: "What's an Office 365 user ID and why do Dynamics 365 for Customer Engagement apps (online) users need one? | MicrosoftDocs"
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
ms.assetid: 548d5ef8-d391-4ae2-b768-a7e741383e33
caps.latest.revision: 4
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# What's an Office 365 user ID and why do users need one?

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Each user signs in to [!INCLUDE[pn_CRM_Online](../includes/pn-crm-online.md)] apps with an [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] user ID (more precisely, an [!INCLUDE[pn_azure_active_directory](../includes/pn-azure-active-directory.md)] user ID, see the Note later in this topic). Access to Customer Engagement apps is controlled through the [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] user ID.  
  
 The user ID is in this format: `username@yourcompany.onmicrosoft.com`. Please note that although it resembles an email address, **this is a sign-in ID and not an email address**. It can be used as an email address, but only if you have an [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] subscription with [Exchange Online](http://products.office.com/exchange/exchange-online).  
  
 Many companies would like to use their own domain name, such as contoso.com, instead of onmicrosoft.com for user accounts. You can configure [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] to use your domain name so your [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps users can sign in with a format like `username@yourcompany.com` instead of `username@yourcompany.onmicrosoft.com`. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Verify your domain in Office 365](https://support.office.com/article/Verify-your-domain-in-Office-365-6383f56d-3d09-4dcb-9b41-b5f5a5efd611)  
  
 To manage [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] user IDs, sign in to the [!INCLUDE[pn_office_365_admin_center](../includes/pn-office-365-admin-center.md)] ([https://admin.microsoft.com](https://admin.microsoft.com)). Here, you can do all sorts of administrative tasks such as create users, assign licenses, and maintain passwords.  
  
 ![Office 365 user ID and Dynamics 365 for Customer Engagement apps (online)](../admin/media/o365-user-id.png "Office 365 user ID and Dynamics 365 for Customer Engagement apps (online)")  
  
> [!NOTE]
> Customer Engagement apps uses [Azure Active Directory](https://docs.microsoft.com/azure/active-directory/active-directory-whatis) as its identity provider. You access Customer Engagement apps through an [!INCLUDE[pn_azure_active_directory](../includes/pn-azure-active-directory.md)] user ID that’s created and managed in the [!INCLUDE[pn_office_365_admin_center](../includes/pn-office-365-admin-center.md)]. For simplicity, we will refer to the [!INCLUDE[pn_azure_active_directory](../includes/pn-azure-active-directory.md)] user ID as the [!INCLUDE[pn_Office_365](../includes/pn-office-365.md)] user ID in this documentation.  
  
 If you company uses on-premises [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] for user identity, you have options that can simplify user management such as providing a single sign-on experience for your users. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage user account synchronization](../admin/manage-user-account-synchronization.md)  
  
### See also  
 [What is my user ID and why do I need it for Office 365?](https://support.office.com/article/What-is-my-user-ID-and-why-do-I-need-it-for-Office-365-37da662b-5da6-4b56-a091-2731b2ecc8b4)   
 [Use the Microsoft 365 admin center to manage your Dynamics 365 for Customer Engagement apps (online) subscription](../admin/use-office-365-admin-center-manage-subscription.md)   
 [Create users and assign security roles](create-users-assign-online-security-roles.md)
