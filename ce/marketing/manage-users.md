---
title: "Manage users (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Manage user accounts and assign security roles in Dynamics 365 for Marketing"
keywords: "administration; organization settings; users; roles; permissions"
ms.date: 12/15/2017
ms.service: crm-online
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

## Create a user account

To create a user:

1. Make sure you have the global administrator role in [!INCLUDE[pn-office-365](../includes/pn-office-365.md)] and the System Administrator role in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

1. Go to **Settings** > **Advanced Settings** > **Organization** > **User Management**.

1. Select **Add Users**.

1. Follow the instructions in the **Confirm user account creation** dialog box.

1. The **Add New User** pane appears. Enter the following details:

    - First name
    - Last name
    - Display name: This is automatically populated based on the first name and last name, and can be changed.
    - Username: This must be a unique name. A domain name, which is usually the organization name, is appended to the username (for example, xyz@contoso.com).
    - User email address

1. In the **Role** drop-down list, select a role that you want to assign to the user. You must assign at least one role.

    > [!IMPORTANT]
    > Assign a role with only the privileges the user needs.

1. Under **Password**, select the **Make this user change the password when they first sign in** check box to have the user enter a new password when they sign in.

1. Select **Contact information** to provide more details about the user.

1. Select **Add**.

> [!NOTE]
> If there's a single license type for your organization, a license will be automatically assigned to the user. If there are no licenses left, the user will be created but no license will be assigned.

<a name="assign-role"></a>

## Assign a security role to a user

Security roles control a user's access to data through a set of access levels and privileges. The combination of access levels and privileges that are included in a specific security role sets limits on the user's view of data and on what actions the user can perform with that data.

You can assign more than one security role to a user. The effect of multiple security roles is cumulative, which means that the user has the permissions associated with all security roles assigned to the user.

> [!IMPORTANT]
> You must assign at least one security role to every user. The service does not allow access to any user who does not have at least one security role.

In [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]:

1. Go to **Settings** > **Advanced Settings** > **Organization** > **User Management**.
1. Select the user you want to assign a role to, and then on the command bar, select **Manage Roles**.
1. In the **Manage User Roles** dialog box, select the security role or roles you want for the user or users, and then select **OK**.

## Join a team

Teams are a collection of users. Teams let users across an organization collaborate and share information. To add users to a team:

1. Select the users you want to add to the team, and then on the command bar, select **Join Teams**.
1. In the **Join Team** dialog box, select the teams you want to add the users to, and then select **OK**.

## Change the manager

Assign a manager or change an existing manager. The manager is responsible for administering the work of a group of users.

1. Select the users whose manager you want to change, and then on the command bar, select **Change Manager**.
1. In the **Change Manager** dialog box, select the Lookup button to choose a manager, and then select **OK**.

## Use privileges to grant access to [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] and [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] features

Each security role established in [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] is created by assigning various levels of access to each of a wide selection of privileges. Administrators can customize each role as needed by modifying the set of privileges it contains.

> [!NOTE]
> To customize security roles, you must work in the [!INCLUDE[pn-custom-app-module](../includes/pn-custom-app-module.md)] app. For details about how to open this app, see [Move between apps](navigation.md#move-between-apps). For more information about how to customize security roles, see [Create or edit a security role](../admin/create-edit-security-role.md)

When you are creating and customizing security roles, you'll find most of the user privileges added by the [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)] app on the **Custom Entities** tab of the **Security Role** dialog.

You can control access to [!INCLUDE[pn-customer-insights-full](../includes/pn-customer-insights-full.md)] information (such as when working with segments and related insights) from the **Custom Entities** tab by using the **[!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] Information** entity listed here. [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)] coordinates with [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] in the background to grant the required access, so you don't need to make any additional settings in [!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] to enable it. Add the **[!INCLUDE[pn-customer-insights-short](../includes/pn-customer-insights-short.md)] Information** entity to each relevant user role applied to users who require access to these features from [!INCLUDE[pn-marketing-app-module](../includes/pn-marketing-app-module.md)].

## Security roles added by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

Security roles enable administrators to control which users have access to which features of [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)]. Several security roles are common to almost all [!INCLUDE[pn-microsoftcrm](../includes/pn-dynamics-365.md)] applications, while others are more specialized. This topic describes the specialized roles added specifically by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

### Event Management security roles

The event management solution adds the following security roles:

- **Event Administrator**: Can create, read, write, delete, assign, and share any Event Management record. Can also access the administration settings for Event Management.
- **Event Planner**: Can create, read, write, and share any type of Event Management record, but can only delete and assign Event Management records that they own.

### Core marketing security roles

The core marketing execution and automation solution adds the following security roles:

- Marketing Services User
- SMB Marketing Manager
- SMB Marketing Professional

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

### See also

[Manage security, users, and teams](../admin/manage-security-users-and-teams.md)  
[Manage teams](manage-teams.md)