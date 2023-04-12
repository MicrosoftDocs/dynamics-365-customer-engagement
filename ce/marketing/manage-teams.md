---
title: "Administer teams of users (Dynamics 365 Marketing) | Microsoft Docs"
description: "Organize users into teams and apply roles to teams in Dynamics 365 Marketing."
ms.date: 03/25/2021

ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Manage and apply roles to teams

A team is a group of users who share and collaborate on business records. A user can be associated with multiple teams.

## Create a team

To create a new team:

1. Go to **Settings** ![The Settings menu icon.](media/settings-icon.png "The Settings menu icon") > **Advanced settings**.
1. A new window titled **Business management** will open. Go to **Settings** at the top of the new window, then **System** > **Security** > **Teams**.
1. Select **New** on the command bar.
1. The **Add new team** page opens. Enter the following details.
    - **Team name**: Give the team a name
    - **Business unit**: Select the business unit that members of this team belong to.
    - **Administrator**: Select the person who will perform administrative tasks for the team, such as adding or removing members. The team admin does not have access to team-owned records. To access team-owned records, the team admin needs to be added as a team member. 

        The following lists the required privileges for a team admin to add or remove team members:
       
        **Team** table = **Append** and **Append To**
        
        **User** table = **Append** and **Append To**
        
        The privilege depth of these tables is dependent on the team membership of Team. Use **Organization** depth if Team members can be from different business units otherwise use **Business Unit** depth if Team members are only from the same business unit as the team admin.
        
    - **Team type**: Select the type of team you are creating. For details about the various types, see [Manage teams](/power-platform/admin/manage-teams).
    - **Azure AD object ID for a group**: If you are using an AAD-related **Team type**, then specify the relevant Azure AD object ID here.
    - **Description**: Describe the team.
1. Select **Save** on the command bar.
1. The page reloads, now showing a **Team members** table. Use the settings here to view, add, or remove  members for the team.

## Add or remove members to the team

1. Go to **Settings** ![The Settings menu icon.](media/settings-icon.png "The Settings menu icon") > **Advanced settings**.
1. A new window titled **Business management** will open. Go to **Settings** at the top of the new window, then **System** > **Security** > **Teams**.
1. Find and open the team in the list that you want to edit.
1. The team record opens. Use the **Team members** section here to view and edit the team members as follows:
    - To add a member, select the **Add existing user** button at the top of the **Team members** section and then select one or more existing users to add.
    - To remove a member, select the target member to highlight it, then select the **Remove** button at the top of the **Team members** section.
1. Save your settings.

## Manage roles for a team

You can assign any number of security roles to each team. When a team is assigned a role, all team members inherit the privileges associated with that role so long as they remain on that team.

To apply security roles to teams, and to customize each role:

1. Open the **Settings** menu ![The Settings menu icon.](media/settings-icon.png "The Settings menu icon") at the top of the page and select **Advanced settings**. The advanced-settings area then opens in a new browser tab. Note that this area uses a horizontal navigator at the top of the page instead of a side navigator.
1. Navigate to **Settings** > **System** > **Security**.
1. Work with the **Users**, **Security roles**, and **Teams** items here as needed.

For more information about managing teams and working with security roles, see [Manage teams](/power-platform/admin/manage-teams) and [Security roles and privileges](/power-platform/admin/security-roles-privileges).

For more information about the security roles included with the Dynamics 365 Marketing, see [Manage user accounts, licenses, and roles](admin-users-licenses-roles.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
