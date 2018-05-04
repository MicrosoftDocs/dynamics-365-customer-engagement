---
title:  Use the service admin role to manage your tenant  | Microsoft Docs
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
# Use the service admin role to manage your tenant

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE [cc_applies_to_update_8_2_0](../../includes/cc_applies_to_update_8_2_0.md)]

To help you administer [!INCLUDE[pn_dyn_365_online](../../includes/pn-crm-online.md)], you can assign users to manage [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] at the tenant level without having to assign the more powerful [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] global admin privileges.  
  
 Users with the [!INCLUDE[pn_dyn_365_online](../../includes/pn-crm-online.md)] service admin role can:  
  
-   Sign in to and manage  multiple [!INCLUDE[pn_dyn_365_online](../../includes/pn-crm-online.md)] instances. If an instance uses a security group, a service administrator would need to be added to the security group in order to manage that instance.  
  
-   Perform admin functions in [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] because they have the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] system admin role. The service admin must be assigned a [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] license.  
  
A [!INCLUDE[pn_dyn_365_online](../../includes/pn-crm-online.md)] service admin cannot do functions restricted to the [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] global admin such as manage user accounts, manage subscriptions, access settings for [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] apps like [!INCLUDE[pn_Exchange](../../includes/pn-exchange.md)] or [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)].  
  
> [!NOTE]
> The [!INCLUDE[pn_dyn_365_online](../../includes/pn-crm-online.md)] service admin can manage instances of version 8.1 ([!INCLUDE[pn_crm_8_1_0_online](../../includes/pn-crm-8-1-0-online.md)]) or later.  
  
 ![Dynamics 365 service admin](../admin/media/dynamics-365-service-admin.png "Dynamics 365 service admin")  
  
 Here's a matrix of what's available with the various [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] roles.  
  
|Office 365 role / feature|Backup & restore|Sandbox copy|Configure new instances|Manage an instance|Add Dynamics 365 licenses|Approve Dynamics 365 emails<sup>1</sup>|Access support requests|Access Service health|Access Message center|  
|--------------------------------|----------------------|------------------|-----------------------------|------------------------|-------------------------------|---------------------------------|-----------------------------|---------------------------|---------------------------|  
|Office 365 global admin|Yes|Yes|Yes|Yes|Yes|Yes|Yes|Yes|Yes|  
|Exchange admin|n/a|n/a|n/a|n/a|n/a|No|n/a|Yes|Yes|  
|Office 365 service admin|No|No|No|No|No|No|Yes|Yes|Yes|  
|Office 365 user|No|No|No|No|No|No|No|No|No|  
|Dynamics 365 service admin|Yes|Yes|Yes|Yes|No|Yes|Yes|Yes|Yes|  

<sup>1</sup>You can manually assign the right to approve emails. In [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)], go to **Settings** > **Security** > **Security Roles**. Select a security role, and then select the **Business Management** tab. Under **Miscellaneous Privileges**, set the privilege level for **Approve Email Addresses for Users or Queues**.

Users with the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] system admin role or with the **Approve Email Addresses for Users or Queues** privilege can approve [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] email addresses.
  
### See also  
 [Manage Microsoft Dynamics 365 (online) instances](../admin/manage-online-instances.md)   
 [Manage subscriptions, licenses, and user accounts](../admin/manage-subscriptions-licenses-user-accounts.md)
