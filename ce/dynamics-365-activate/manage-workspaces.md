---
title: Manage workspaces
description: Learn how to create and manage workspaces in Dynamics 365 Activate.
ms.date: 11/18/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: zobanyai
ai-usage: ai-assisted
---

# Manage workspaces

A workspace is a shared area where your team can organize and manage Salesforce migration projects. Each workspace can contain multiple projects and has its own members, roles, and access settings.

Workspaces help you:

- Organize related migration projects in one place.
- Collaborate with other members of your organization.
- Control who can view or manage projects.
- Separate projects that require different teams or access permissions.

You can sign up and create a workspace without approval from Microsoft. To create your first workspace, see [Access and set up Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-access-setup.md#sign-up-and-create-a-workspace). Joining an existing workspace still requires its administrator to add you.

## Workspace roles

| Role | What the user can do | Which projects they can see |
|----|----|----|
| **Administrator** | Manage the workspace, members, roles, and access. Create and work on projects. | Every project in the workspace. |
| **Contributor** | Create projects and make changes, including running migrations. | Projects they created or that were shared with them. |
| **Reader** | View information without making changes. | Projects shared with them. |

Workspace membership and project sharing work together. Adding someone as a Contributor or Reader doesn't automatically show them every project. A project owner must [share the projects that the users need access to](migrate-salesforce-to-dynamics-365-access-setup.md#share-a-project). Administrators can see all projects in the workspace.

## Enable or disable Bring your Own Storage (BYOS) for a workspace

By default, Bring your Own Storage (BYOS) is enabled for the workspace, so you can use your own storage for migration assessment and staging data. However, you can disable BYOS at the workspace level to allow the use of only Microsoft-hosted storage for all projects in the workspace.

1. On the **Migration Projects** page, select the workspace from the **Workspace** drop-down.
2. Select **Access management** at the top of the page.
3. Turn on **Enable Microsoft-hosted storage for migration assessment and staging data.** to disable BYOS for the workspace. Turn off this option to enable BYOS.
4. Select **Save changes**.
   After you disable BYOS, the **Configure storage** option shows that projects in the workspace can use only Microsoft-managed storage.
   :::image type="content" source="media/byos-disabled.png" alt-text="Screenshot of the Configure storage option showing Microsoft-managed only":::

## Create projects in a workspace

Every new project must belong to a workspace. Select the appropriate workspace when you [create a project](migrate-salesforce-to-dynamics-365-access-setup.md#create-a-project). You can't move the project to another workspace through the standard project-editing experience.

## Manage workspace access

You must be a workspace Administrator to manage workspace access. 

### Add a user

Add a user to the workspace so they can access the workspace and its projects according to the role you assign to them.

1. Select the workspace in the **Workspace** drop-down.
2. Select **Access management**.
3. Under **Role assignments**, select **Add user**.
4. Enter the Microsoft Entra work email address of the user.
5. Select a role: **Administrator**, **Contributor**, or **Reader**. To learn more, see [workspace roles](#workspace-roles).
6. Select **Add user**.
1. Notify the user to sign in to [Dynamics 365 Activate](https://migrate.dynamics.cloud.microsoft/) with their Microsoft Entra work account so that you can [share projects](migrate-salesforce-to-dynamics-365-access-setup.md#share-a-project) with them.

### Manage a member's role and access

1. In **Access management**, find the member under **Role assignments**.
2. Select the new role or change the member's access toggle as needed.
3. Select **Save changes**.


> [!NOTE]
> The portal uses a reversible access switch instead of a permanent **Remove member** action. A workspace must always have at least one enabled Administrator who signs in. An unaccepted invitation doesn't count.


## Best practices

- Create one shared workspace for a team working on the same migration initiative.
- Add all relevant team members, then give each person the lowest role that supports their work.
- Create separate projects inside that workspace to execute, validate, and test different migration scenarios.
- Use separate projects when migrating different Salesforce areas or groups of objects.
- Avoid creating a workspace for every small project unless isolation is required.

## Current project limit

- You can create up to three projects.
- Projects shared with you don't count toward your limit.
- An administrator can set the allowance to a different number.