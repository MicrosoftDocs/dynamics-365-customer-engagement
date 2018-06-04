---
title: "Manage users (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Manage user accounts and assign security roles in Dynamics 365 for Marketing"
keywords: "administration; organization settings; users; roles; permissions"
ms.date: 04/01/2018
ms.service:
  - "dynamics-365-marketing"
ms.custom:
  - "dyn365-admin"
  - "dyn365-marketing"
ms.topic: article
applies_to:
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 095057aa-5a0f-4e9e-a434-c7ff7f4fad21
author: kamaybac
ms.author: kamaybac
manager: sakudes
ms.reviewer: renwe
topic-status: Drafting
---

# Manage users

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

Create an account for each user that requires access to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

## Create a user account and assign licenses

User accounts and licensing in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] work the same way as they do for other [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] customer engagement apps. Use [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] admin center to create a new user and then purchase and assign licenses for [!INCLUDE[pn-ms-office-365](../includes/pn-ms-office-365.md)] and [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] to the user as needed. Once you have done this, you'll see the new user listed on the **Settings** > **Advanced Settings** > **Organization** > **User Management** page.

 [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Purchase and assign Dynamics 365 (online) licenses](../admin/purchase-assign-online-licenses.md).

<a name="assign-role"></a>

## Assign a security role to a user

Security roles control a user's access to data through a set of access levels and privileges. The combination of access levels and privileges that are included in a specific security role sets limits on the user's view of data and on what actions the user can perform with that data.

You can assign more than one security role to a user. The effect of multiple security roles is cumulative, which means that the user has the permissions associated with all security roles assigned to the user.

> [!IMPORTANT]
> You must assign at least one security role to every user. The service does not allow access to any user who does not have at least one security role.

In [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]:

1. Go to **Settings** > **Advanced Settings** > **Organization** > **User Management**.
1. Open the record for the user you want to assign a role to. To open the record, either double-click on it or select it in the list and then press the enter key.
1. On the command bar, select **Manage Roles**.
1. In the **Manage User Roles** flyout, select the check box for each relevant security role snd then select **OK**.

> [!NOTE]
> [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] offers limited user-management functionality, and provides access to just a few of the security roles available on your [!INCLUDE[pn-dynamics-365](../includes/pn-dynamics-365.md)] system. To grant access to all types of security roles, and to customize each role, you must work in the [!INCLUDE[pn-custom-app-module](../includes/pn-custom-app-module.md)] app. For details about how to open this app, see [Move between apps](navigation.md#move-between-apps). [!INCLUDE[proc-more-information](../includes/proc-more-information.md)] [Manage security, users, and team](../admin/manage-security-users-and-teams.md)

## Security roles added by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

Security roles enable administrators to control which users have access to which features of [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. Several security roles are common to almost all [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] applications, while others are more specialized. This topic describes the specialized roles added specifically by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

### Event Management security roles

The event management solution adds the following security roles:

- **Event Administrator**: Can create, read, write, delete, assign, and share any Event Management record. Can also access the administration settings for Event Management.
- **Event Planner**: Can create, read, write, and share any type of Event Management record, but can only delete and assign Event Management records that they own.

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
- **[!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen S2S Inbound**: an internal security role used by the solution to sync data

### Surveys security roles

The surveys package adds the following security roles:

- Survey Administrator
- Survey Designer
- Survey Feedback Publisher
- Survey Service
- Survey User

## Use privileges to customize access to [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] features for each security role

Each security role established in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] is created by assigning various levels of access to each of a wide selection of privileges. Administrators can customize each role as needed by modifying the set of privileges it contains.

> [!NOTE]
> To customize security roles, you must work in the [!INCLUDE[pn-custom-app-module](../includes/pn-custom-app-module.md)] app. For details about how to open this app, see [Move between apps](navigation.md#move-between-apps). For more information about how to customize security roles, see [Create or edit a security role](../admin/create-edit-security-role.md)

When you are creating and customizing security roles, you'll find most of the user privileges added by the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app on the **Custom Entities** tab of the **Security Role** dialog.

### See also

[Manage security, users, and teams](../admin/manage-security-users-and-teams.md)  
[Manage teams](manage-teams.md)
