---
title: "Administer teams of users (Dynamics 365 for Marketing) | Microsoft Docs"
description: "Organize users into teams and apply roles to teams in Dynamics 365 for Marketing"
keywords: administration; organization settings; user; team; role; permission; fiscal year
ms.date: 06/21/2019
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement (online)
  - Dynamics 365 for Customer Engagement Version 9.x
ms.assetid: edc9a748-f08f-484c-ae86-0c20d20c1f6c
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

# Manage teams

[!INCLUDE[cc_applies_to_update_9_0_0](../includes/cc_applies_to_update_9_0_0.md)]

A team is a group of users who share and collaborate on business records. A user can be associated with multiple teams.

## Create a team

To create a new team:

1. Go to **Settings** > **Advanced settings** > **Organization** > **Team management**. 
1. Select the **Add Team** button in the heading of the page.
1. The **Add new team** fly-out slides in from the side of the page. Enter the following details.
    - **Team name**: Give the team a name
    - **Business unit name**: This read-only value is your organization name.
    - **Team sescription**: Describe the team.
    - **Team administrator**: Select the person who will perform administrative tasks for the team, such as adding or removing members.
1. Select the **Add** button at the bottom of the fly-out.

## Add or remove members to the team

1. Go to **Settings** > **Advanced settings** > **Organization** > **Team management**.
1. Find and open the team in the list that you want to edit.
1. The team record opens. Use the **Team members** section here to view and edit the team members as follows:
    - To add a member, select the **Add existing user** button at the top of the **Team members** section and then select one or more existing users to add.
    - To remove a member, select the target member to highlight it, then select the **Remove** button at the top of the **Team members** section.
1. Save your settings.

## Manage roles for a team

You can assign any number of security roles to each team. When a team is assigned a role, all team members inherit the privileges associated with that role so long as they remain on that team.

To apply security roles to teams, and to customize each role:

1. Open the **Settings** menu ![The Settings menu icon](media/settings-icon.png "The Settings menu icon") at the top of the page and select **Advanced settings**. The [!INCLUDE[pn-microsoftcrm](../includes/pn-microsoftcrm.md)] advanced-settings area then opens in a new browser tab. Note that this area uses a horizontal navigator at the top of the page instead of a side navigator.
1. Navigate to **Settings** > **System** > **Security**.
1. Work with the **Users**, **Security roles**, and **Teams** items here as needed.

For more information about managing teams and working with security roles, see [Manage security, users, and team](../admin/manage-security-users-and-teams.md) and [Create or edit a security role](../admin/create-edit-security-role.md).

For more information about the security roles included with the [!INCLUDE[pn-marketing-business-app-module-name](../includes/pn-marketing-business-app-module-name.md)], see [Manage user accounts, licenses, and roles](admin-users-licenses-roles.md).

### See also

[Manage security, users, and teams](../admin/manage-security-users-and-teams.md)  
[Manage users](manage-users.md)
