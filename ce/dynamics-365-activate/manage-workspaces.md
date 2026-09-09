---
title: Manage workspaces (preview)
description: Learn how to create and manage workspaces in Dynamics 365 Activate.
ms.date: 09/09/2026
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

# Manage workspaces (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

A workspace is a shared area where your team can organize and manage Salesforce migration projects. Each workspace can contain multiple projects and has its own members, roles, and access settings.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Workspaces help you:

- Organize related migration projects in one place.
- Collaborate with other members of your organization.
- Control who can view or manage projects.
- Separate projects that require different teams or access permissions.

Microsoft provisions a workspace when it approves your access request. To request access and create your first workspace, see [Access and set up Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-access-setup.md).

## Workspace roles

| Role | What the user can do | Which projects they can see |
|----|----|----|
| **Administrator** | Manage the workspace, members, roles, and access. Create and work on projects. | Every project in the workspace. |
| **Contributor** | Create projects and make changes, including running migrations. | Projects they created or that were shared with them. |
| **Reader** | View information without making changes. | Projects shared with them. |

Workspace membership and project sharing work together. Adding someone as a Contributor or Reader doesn't automatically show them every project. A project owner must share projects that the users need access to. Administrators can see all projects in the workspace.

## Enable or disable Bring your Own Storage (BYOS) for a workspace

By default, Bring your Own Storage (BYOS) is enabled for the workspace, so you can use your own storage for migration assessment and staging data. However, you can disable BYOS at the workspace level to allow the use of only Microsoft-hosted storage for all projects in the workspace.

1. On the **Migration Projects** page, select the workspace from the **Workspace** drop-down.
1. Select **Access management** at the top of the page.
1. Turn on **Enable Microsoft-hosted storage for migration assessment and staging data.** to disable BYOS for the workspace. Turn off this option to enable BYOS.
1. Select **Save changes**.
   After you disable BYOS, the **Configure storage** option shows that projects in the workspace can use only Microsoft-managed storage.
   :::image type="content" source="media/byos-disabled.png" alt-text="Screenshot of the Configure storage option showing Microsoft-managed only":::

## Add an existing project to a workspace

Add related projects to a workspace to keep them organized and accessible to the appropriate team members.

> [!NOTE]
> You can add a project to only one workspace. Once you add it to a workspace, you can't move it to a different workspace.

1. On the [Migration Projects](https://migrate.dynamics.cloud.microsoft/) page, select **All Workspaces** from the **Workspace** drop-down.
   You see projects across all workspaces.
1. Find the project that you want to add to a workspace. If the project isn't already in a workspace, it's marked as **Not in a workspace**.
1. Select **Add to workspace**.
1. Select the workspace you want to add it to, then confirm.

## Manage workspace access

You must be a workspace Administrator to manage workspace access. 

### Add a member

1. Select the workspace in the **Workspace** drop-down.
1. Select **Access management**.
1. Under **Role assignments**, select **Add user**.
1. Enter the person's work email address.
1. Select a role: **Administrator**, **Contributor**, or **Reader**. To learn more, see [workspace roles](#workspace-roles).
1. Select **Add user**.

The person receives access when they next sign in with that email address.

### Change a member's role

1. In **Access management**, find the member under **Role assignments**.
1. Select the new role.
1. Select **Save changes**.

### Remove or restore access

1. In **Access management**, find the member under **Role assignments**.
1. Use the member's **Access** toggle:
   - Turn it **off** to disable access.
   - Turn it **on** to restore access.
1. Select **Save changes**.

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