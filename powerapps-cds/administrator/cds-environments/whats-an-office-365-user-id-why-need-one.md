---
title: What's an Office 365 user ID and why do users need one? | Microsoft Docs
description: In this quickstart, you learn how to download a list of apps created in your environments
services: 'powerapps'
suite: powerapps
documentationcenter: na
author: jimholtz
manager: kfile
editor: ''
tags: ''

ms.service: powerapps
ms.devlang: na
ms.topic: article
ms.tgt_pltfrm: na
ms.workload: na
ms.date: 03/21/2018
ms.author: jimholtz

---
# What's an Office 365 user ID and why do users need one?

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE[cc-applies-to-update-8-2-0](../../includes/cc_applies_to_update_8_2_0.md)]

Each user signs in to [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] with an [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] user ID (more precisely, an [!INCLUDE[pn_azure_active_directory](../../includes/pn-azure-active-directory.md)] user ID, see the Note later in this topic). Access to [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] is controlled through the [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] user ID.  
  
 The user ID is in this format: `username@yourcompany.onmicrosoft.com`. Please note that although it resembles an email address, **this is a sign-in ID and not an email address**. It can be used as an email address, but only if you have an [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] subscription with [Exchange Online](http://products.office.com/exchange/exchange-online).  
  
 Many companies would like to use their own domain name, such as contoso.com, instead of onmicrosoft.com for user accounts. You can configure [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] to use your domain name so your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] users can sign in with a format like `username@yourcompany.com` instead of `username@yourcompany.onmicrosoft.com`. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Verify your domain in Office 365](https://support.office.com/article/Verify-your-domain-in-Office-365-6383f56d-3d09-4dcb-9b41-b5f5a5efd611)  
  
 To manage [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] user IDs, sign in to the [!INCLUDE[pn_office_365_admin_center](../../includes/pn-office-365-admin-center.md)] ([https://portal.office.com](https://portal.office.com)). Here, you can do all sorts of administrative tasks such as create users, assign licenses, and maintain passwords.  
  
 ![Office 365 user ID and Dynamics 365 (online)](../admin/media/o365-user-id.png "Office 365 user ID and Dynamics 365 (online)")  
  
> [!NOTE]
> [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] uses [Azure Active Directory](https://docs.microsoft.com/azure/active-directory/active-directory-whatis) as its identity provider. You access [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] through an [!INCLUDE[pn_azure_active_directory](../../includes/pn-azure-active-directory.md)] user ID that’s created and managed in the [!INCLUDE[pn_office_365_admin_center](../../includes/pn-office-365-admin-center.md)]. For simplicity, we will refer to the [!INCLUDE[pn_azure_active_directory](../../includes/pn-azure-active-directory.md)] user ID as the [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] user ID in this documentation.  
  
 If you company uses on-premises [!INCLUDE[pn_Active_Directory](../../includes/pn-active-directory.md)] for user identity, you have options that can simplify user management such as providing a single sign-on experience for your users. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage user account synchronization](../admin/manage-user-account-synchronization.md)  
  
### See also  
 [What is my user ID and why do I need it for Office 365?](https://support.office.com/article/What-is-my-user-ID-and-why-do-I-need-it-for-Office-365-37da662b-5da6-4b56-a091-2731b2ecc8b4)   
 [Use the Office 365 admin center to manage your Dynamics 365 (online) subscription](../admin/use-office-365-admin-center-manage-subscription.md)   
 [Create users and assign security roles](create-users-assign-online-security-roles.md)
