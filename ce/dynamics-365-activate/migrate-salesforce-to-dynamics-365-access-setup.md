---
title: Access and set up Dynamics 365 Activate (preview)
description: Learn how to access Dynamics 365 Activate, meet account and role requirements, and create, secure, and manage migration projects.
ms.date: 09/09/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: zbanyai
ms.collection: bap-ai-copilot
---

# Access and set up Dynamics 365 Activate (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

This article explains how to access Dynamics 365 Activate and create and manage migration workspaces and projects for a Salesforce to Dynamics 365 migration.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

To use the application, you need a Microsoft Entra work account. If you don't have one, contact your IT administrator.

## Request access to Dynamics 365 Activate

1. Go to the [Dynamics 365 Activate sign-up page](https://migrate.dynamics.cloud.microsoft/signup).  
1. Select **Sign up**.  
1. Sign in with your Microsoft Entra work account.  
1. Complete the access-request form:  
    :::image type="content" source="media/create-workspace.png" alt-text="Screenshot of the create workspace and project form":::
    -  **Project type:** Currently, Legacy System Migration is supported.  
    -  **Legacy source:** Currently, Salesforce is supported.  
    - **Dynamics 365 migration to:** Currently, Customer Service and Sales are supported.  
    -  **Name:** Enter the name to use for your workspace. For example, "Salesforce Dev Migration Workspace".
    - **Description:** Optionally, describe the migration engagement.  
    - **Account type:** Select Customer, Partner, or Internal depending on your organization's relationship with Microsoft.
    -  **Region:** Select **US**. Other regions aren't supported at this time.  
    -  **Purpose:** Select Production, Dev, or Test depending on the intended use of the workspace.

1. Select **Submit**.

After you select **Submit**, what happens depends on whether you're a new or existing user:

**New users - request pending approval**

You see a **Sign-up request received** confirmation. Your request is submitted and waiting for review. Microsoft typically reviews requests within three business days. When it's approved, you receive a notification with a link to your workspace in [Dynamics 365 Activate](https://migrate.dynamics.cloud.microsoft/).

If the request is rejected, the rejection reason appears on the sign-up page. Update the request details and resubmit.

**Existing users - workspace auto-approved**

If you already have access to Dynamics 365 Activate, your new workspace is auto-approved. You see a **Workspace Found** confirmation. Select **Dynamics 365 Activate** to go to your Workspace and Projects page.

The projects page opens with **All Workspaces** selected. Your new workspace appears in the Workspace picker alongside any existing projects. Existing projects and their data aren't deleted or modified. You can create new projects inside the workspace or add eligible existing projects to it.

## Sign in to Dynamics 365 Activate

Go to the [Dynamics 365 Activate website](https://migrate.dynamics.cloud.microsoft/) and select **Sign up** or sign in with your Microsoft Entra work account. What appears after sign-in depends on your access:  
 
- If you don’t belong to a workspace, the access-request form appears.
- If your request is pending, the page shows **Sign-up request received**.
- If your request was rejected, the rejection reason appears and you can update and resubmit the request.
- If your request is approved and a workspace was provisioned, select **Dynamics 365 Activate** to open it.
- If a workspace administrator invited you to an existing workspace, that workspace appears after you sign in and claim the invitation.

After you have workspace access, the **Migration Projects** page opens.

To add members, assign roles, and manage access, see [Manage workspaces](manage-workspaces.md#manage-workspace-access).

## Create a project

A **project** represents an individual migration engagement within a workspace. Each project holds its own Salesforce and Dynamics 365 connections, discovery results, mappings, solution configuration, and migration history. Use separate projects for different Salesforce orgs, target Dataverse environments, or migration phases. A project remains in the workspace in which you create it.

For details about workspaces and roles, see [Manage workspaces](manage-workspaces.md).

1. On the **Migration Projects** page, select **New Project**.
1. Enter a **Project Name**. Use a name that clearly identifies the migration scope, for example, *Contoso Sales CRM - Q3 Migration*.
1. If you can create projects in more than one workspace, select the destination **Workspace**. You can't later move a project to another workspace through the standard project-editing experience.
1. Optionally, add a description with more context.
1. Select **Create Project**.
   The **Configuration** page opens, allowing you to set up connections and manage project settings.
   :::image type="content" source="media/new-project-configuration.png" alt-text="Screenshot of the project configuration page":::

## Manage existing projects

From the **Migration Projects** page, you can:

- **Open a project**: Select the project name to open it.
- **View project details**: Each project card shows the last activity date and connection status.
- **Delete a project**: On the **Migration Projects** page, hover over a project card to reveal the project actions and select **Delete Project**. Only the project owner can delete it. The project is removed from the dashboard immediately, and the application purges its data in the background.
    - If the project uses Microsoft-hosted storage, the application handles cleanup automatically.
    - If the project uses your own storage (BYOS), delete the staging blobs or confirm that an appropriate customer-managed lifecycle policy removed them before revoking the SAS or deleting the project. Customer-managed backups, snapshots, versions, replicas, exports, and legal holds remain the customer's responsibility.

## Project settings and credentials

Inside each project, use the **Configuration** tab to manage connections. You can:

- Update Salesforce credentials
- Update Dynamics 365 credentials
- Test connections at any time
- Delete credentials for a project

Learn more in [How to migrate from Salesforce to Dynamics 365 (preview)](migrate-salesforce-to-dynamics-365-quick-start.md)

> [!IMPORTANT]
> The application encrypts Salesforce, Dynamics 365, and BYOS connection credentials by using AES-256-GCM and stores them as encrypted project data in the active project database. In hosted environments, a Microsoft-managed key-encryption key in Azure Key Vault backs the envelope encryption. Credentials are cryptographically scoped to the associated user or project.  
> After 28 days of project inactivity, the application automatically removes credentials for inactive projects. The cleanup process runs every 24 hours. You can also manually clear a project's saved credentials from the **Migration Projects** page.

## Next steps

- [Connect to Salesforce and run discovery](migrate-salesforce-to-dynamics-365-connect-salesforce.md)
- [Connect to Dynamics 365 and run discovery](migrate-salesforce-to-dynamics-365-connect-dynamics.md)
- [How to migrate from Salesforce to Dynamics 365 (preview)](migrate-salesforce-to-dynamics-365-quick-start.md)
