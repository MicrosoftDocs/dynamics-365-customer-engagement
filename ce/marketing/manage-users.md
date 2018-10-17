---
title: "Manage users (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Manage user accounts and assign security roles in Dynamics 365 for Marketing"
keywords: "administration; organization settings; users; roles; permissions"
ms.date: 04/01/2018
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 (online)
  - Dynamics 365 Version 9.x
ms.assetid: 095057aa-5a0f-4e9e-a434-c7ff7f4fad21
author: kamaybac
ms.author: kamaybac
manager: shellyha
ms.reviewer:
topic-status: Drafting
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Manage users

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

Create an account for each user that requires access to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

## Create a user account and assign licenses

User accounts and licensing in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] work the same way as they do for other [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] customer engagement apps. Use [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] admin center to create a new user and then purchase and assign licenses for [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] and [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] to the user as needed. Once you have done this, you'll see the new user listed on the **Settings** > **Advanced Settings** > **Organization** > **User Management** page.

 [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Purchase and assign Dynamics 365 (online) licenses](../admin/purchase-assign-online-licenses.md).

<a name="assign-role"></a>

## Assign and customize a security roles for users

Security roles control users' access to data through a set of access levels and privileges. The combination of access levels and privileges that are included in a specific security role sets limits on each user's view of data and on what actions the user can perform with that data.

Each security role is created by assigning various levels of access to each of a wide selection of privileges. Administrators can customize each role as needed by modifying the set of privileges it contains.

You can assign more than one security role to a user. The effect of multiple security roles is cumulative, which means that the user has the permissions associated with all security roles assigned to the user.

> [!IMPORTANT]
> You must assign at least one security role to every user. The service does not allow access to any user who does not have at least one security role.

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] provides a read-only view of users who are licensed to use the system. To apply security roles to users, and to customize each role, you must work in the [!INCLUDE[pn-custom-app-module](../includes/pn-custom-app-module.md)] app. For details about how to open this app, see [Move between apps](navigation.md#move-between-apps). For more information about managing users and working with security roles in the custom app, see [Manage security, users, and team](../admin/manage-security-users-and-teams.md) and [Create or edit a security role](../admin/create-edit-security-role.md).

When you are creating and customizing security roles in the custom app, you'll find most of the user privileges added by the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app on the **Custom Entities** tab of the **Security Role** dialog.

## Security roles added by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

Security roles enable administrators to control which users have access to which features of [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. Several security roles are common to almost all [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] applications, while others are more specialized. This topic describes the specialized roles added specifically by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

### Event Management security roles

The event management solution adds the following security roles:

- **Event Administrator**: Can create, read, write, delete, assign, and share any Event Management record. Can also access the administration settings for Event Management.
- **Event Planner**: Can create, read, write, and share any type of Event Management record, but can only delete and assign Event Management records that they own.
- **EventManagement S2S Inbound**: an internal security role used by the solution to sync data.

### Core marketing security roles

The core marketing execution and automation solution adds the following security roles:

- Marketing Services User
- Marketing Manager - Business
- Marketing Professional - Business
- Marketing, Business App Access

### Lead management security roles

The lead-management solution adds the following security roles:

- Demand Generator
- Lead Score Modeler
- Lead Score Viewer

### [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen security roles

The [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen package adds the following security roles:

- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen Forms Administrator**: Users with this role can configure lead matching strategies, [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] field mapping, and solution settings for [!INCLUDE[cc-linkedin-solution](../includes/cc-linkedin-solution.md)].
- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen Forms Salesperson**: These users can authorize [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] user profiles to sync data to [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)], and view details about the synced submissions.
- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] LeadGen S2SInbound**: an internal security role used by the solution to sync data

### Surveys security roles

The surveys package adds the following security roles:

- Survey Administrator
- Survey Designer
- Survey Feedback Publisher
- Survey Service
- Survey User

## Don't modify or remove the Marketing service user

[!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] includes a preconfigured user called **MarketingServices ApplicationUser**, which must have the following security roles:

- EventManagement S2SInbound
- [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] LeadGen S2SInbound
- Marketing Services User
- Marketing, Business App Access

The system uses this account when performing important internal tasks, and [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] will stop working correctly if you remove the user or any of these required roles. Be sure not to remove or modify this user.

### See also

[Manage security, users, and teams](../admin/manage-security-users-and-teams.md)  
[Manage teams](manage-teams.md)
