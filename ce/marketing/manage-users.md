---
title: "Manage users in Dynamics 365 for Marketing | Microsoft Docs"
description: "Manage user accounts and assign security roles in Dynamics 365 for Marketing"
keywords: "administration; organization settings; users; roles; permissions"
author: kamaybac
ms.author: kamaybac
manager: sakudes
applies_to: 
- Dynamics 365 (online)
- Dynamics 365 Version 9.x
ms.date: 10/20/2017
ms.service: crm-online
ms.topic: article
ms.assetid: 095057aa-5a0f-4e9e-a434-c7ff7f4fad21
ms.reviewer: renwe
---
# Manage users

[!INCLUDE[Pre-release disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Create an account for each user that requires access to [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

## Create a user account

To create a user:

1. Make sure you have the global administrator role in [!INCLUDE[pn-office-365](../includes/pn-office-365.md)] and the System Administrator role in [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

1. Go to **Settings** > **Organization** > **User Management**.

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

## Assign a security role to a user

Security roles control a user's access to data through a set of access levels and privileges. The combination of access levels and privileges that are included in a specific security role sets limits on the user's view of data and on what actions the user can perform with that data.

You can assign more than one security role to a user. The effect of multiple security roles is cumulative, which means that the user has the permissions associated with all security roles assigned to the user.

> [!IMPORTANT]
> You must assign at least one security role to every user. The service does not allow access to any user who does not have at least one security role.

In [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]:

1. Go to **Settings** > **Organization** > **User Management**.
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

## Security roles added by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)]

Security roles enable administrators to control which users have access to which features of [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)]. Several security roles are common to almost all [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] applications, while others are more specialized. This topic describes the specialized roles added specifically by [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)].

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

- [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] LeadGen S2SInbound
- [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen Forms Connector Administrator
- [!INCLUDE[pn-linkedin](../includes/pn-linkedin.md)] Lead Gen Forms Connector Salesperson

### Surveys security roles

The surveys package adds the following security roles:

- Survey Administrator
- Survey Designer
- Survey Feedback Publisher
- Survey Service
- Survey User
