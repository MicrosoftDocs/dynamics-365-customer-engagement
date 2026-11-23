---
title: Access and set up Dynamics 365 Activate
description: Learn how to access Dynamics 365 Activate, meet account and role requirements, and create, secure, and manage migration projects.
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

# Access and set up Dynamics 365 Activate

This article explains how to access Dynamics 365 Activate and create and manage migration workspaces and projects for a Salesforce to Dynamics 365 migration.

## Prerequisites

To use the application, you need a Microsoft Entra work account. If you don't have one, contact your IT administrator.

English is the only supported language.

For a shared migration engagement, designate one user to administer the workspace and provide access. That administrator can add colleagues and partners to the workspace rather than having each person create a separate workspace. If you're joining an existing workspace, [sign in first](#sign-in-to-dynamics-365-activate), then ask its administrator to add you.

## Sign up and create a workspace

You can sign up and create a workspace without approval from Microsoft. Access to an existing workspace and its projects still depends on workspace membership and project sharing.

1. Go to the [Dynamics 365 Activate sign-up page](https://migrate.dynamics.cloud.microsoft/signup).  
2. Select **Sign up**.
3. Sign in with your Microsoft Entra work account.
4. Complete the workspace creation form:
    :::image type="content" source="media/create-workspace.png" alt-text="Screenshot of the create workspace and project form":::
    -  **Project type:** Currently, Legacy System Migration is supported.  
    -  **Legacy source:** Currently, Salesforce is supported.  
    - **Dynamics 365 migration to:** Currently, Customer Service and Sales are supported.  
    -  **Name:** Enter the name to use for your workspace. For example, "Salesforce Dev Migration Workspace".
    - **Description:** Optionally, describe the migration engagement.  
    - **Account type:** Select Customer, Partner, or Internal depending on your organization's relationship with Microsoft.
    -  **Region:** Select **US**. Other regions aren't supported at this time.  
    -  **Purpose:** Select Production, Dev, or Test depending on the intended use of the workspace.

5. Select **Submit**.

After you create the workspace, open [Dynamics 365 Activate](https://migrate.dynamics.cloud.microsoft/). On the **Migration Projects** page, select your workspace in the **Workspace** picker. Creating a workspace doesn't delete or modify existing projects or their data.

## Sign in to Dynamics 365 Activate

Go to the [Dynamics 365 Activate website](https://migrate.dynamics.cloud.microsoft/) and sign in with your Microsoft Entra work account.
 
- If you don't belong to a workspace, [create a workspace](#sign-up-and-create-a-workspace), or ask an existing workspace's administrator to add you.
- If a workspace administrator invited you to an existing workspace, that workspace appears after you sign in and claim the invitation.

After you have workspace access, the **Migration Projects** page opens.

To add members, assign roles, and manage access, see [Manage workspaces](manage-workspaces.md#manage-workspace-access).

> [!IMPORTANT]
> Sign in at least once with your Microsoft Entra work account before an administrator adds you to a workspace or a project owner shares a project with you. Workspace membership alone doesn't give Contributors or Readers access to existing projects; the project owner must also [share the project](#share-a-project).

## Create a project

A **project** represents an individual migration engagement within a workspace. Each project holds its own Salesforce and Dynamics 365 connections, discovery results, mappings, solution configuration, and migration history. Use separate projects for different Salesforce orgs, target Dataverse environments, or migration phases. A project remains in the workspace in which you create it.

For details about workspaces and roles, see [Manage workspaces](manage-workspaces.md).

1. On the **Migration Projects** page, select **New Project**.
2. Enter a **Project Name**. Use a name that clearly identifies the migration scope, for example, *Contoso Sales CRM - Q3 Migration*.
3. If you can create projects in more than one workspace, select the destination **Workspace**. You can't later move a project to another workspace through the standard project-editing experience.
4. Optionally, add a description with more context.
5. Select **Create Project**.
   The **Configuration** page opens, allowing you to set up connections and manage project settings.
   :::image type="content" source="media/new-project-configuration.png" alt-text="Screenshot of the project configuration page":::

Next, [configure the Salesforce External Client App, connect to Salesforce, and run discovery](migrate-salesforce-to-dynamics-365-connect-salesforce.md). To collaborate on the assessment and migration, [share the project](#share-a-project) with the colleagues and partners who need access.

## Share a project

Share a project so that colleagues and partners can review discovery results or contribute to the migration. 

Before you share a project:

- Ask a workspace Administrator to [add the user to the project's workspace](manage-workspaces.md#add-a-user) as a **Contributor** or **Reader**, depending on whether they need to make changes or only view information.
- Ask each person to sign in to [Dynamics 365 Activate](https://migrate.dynamics.cloud.microsoft/) at least once with their Microsoft Entra work account.

As the project owner:

1. On the **Migration Projects** page, find the project you want to share.
2. Hover over the project and select the **Share** icon.
3. Enter the work email address of the user, select the user from the list, and confirm sharing.
4. Ask the person to sign in with the same account and open the shared project.

If you see **User not found**, ask the person to complete their first sign-in to Dynamics 365 Activate, then try again with the same email address. If a workspace member can't see a project, check that the project was shared with them, not just that they were added to the workspace.

## Manage existing projects

From the **Migration Projects** page, you can:

- **Open a project**: Select the project name to open it.
- **View project details**: Each project card shows the last activity date and connection status.
- **Delete a project**: On the **Migration Projects** page, hover over a project card to reveal the project actions and select **Delete Project**. Only the project owner can delete it. The project is removed from the dashboard immediately, and the application purges its data in the background.
    - If the project uses Microsoft-hosted storage, the application handles cleanup automatically.
    - If the project uses your own storage (BYOS), delete the staging blobs or confirm that an appropriate customer-managed lifecycle policy removed them before revoking the SAS or deleting the project. Customer-managed backups, snapshots, versions, replicas, exports, and legal holds remain the customer's responsibility.

## Project settings and credentials

Inside each project, use the **Configuration** tab to manage connections. You can:

- Update Salesforce credentials.
- Update Dynamics 365 credentials.
- Test connections at any time.
- Delete credentials for a project.

Learn more in [How to migrate from Salesforce to Dynamics 365](migrate-salesforce-to-dynamics-365-quick-start.md).

> [!IMPORTANT]
> The application encrypts Salesforce, Dynamics 365, and BYOS connection credentials by using AES-256-GCM and stores them as encrypted project data in the active project database. In hosted environments, a Microsoft-managed key-encryption key in Azure Key Vault backs the envelope encryption. Credentials are cryptographically scoped to the associated user or project.  
> After 28 days of project inactivity, the application automatically removes credentials for inactive projects. The cleanup process runs every 24 hours. You can also manually clear a project's saved credentials from the **Migration Projects** page.

## Next steps

- [Connect to Salesforce and run discovery](migrate-salesforce-to-dynamics-365-connect-salesforce.md)
- [Connect to Dynamics 365 and run discovery](migrate-salesforce-to-dynamics-365-connect-dynamics.md)
- [How to migrate from Salesforce to Dynamics 365](migrate-salesforce-to-dynamics-365-quick-start.md)
