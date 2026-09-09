---
title: How to migrate from Salesforce to Dynamics 365 (preview)
description: Get a high-level overview of the end-to-end process for migrating Salesforce data to Dynamics 365 using Dynamics 365 Activate, with links to detailed setup and configuration articles.
ms.date: 09/09/2026
ms.update-cycle: 180-days
ms.topic: overview
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: zobanyai
ai-usage: ai-assisted
---

# How to migrate from Salesforce to Dynamics 365 (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

This article describes the end-to-end process for migrating your Salesforce data to Dynamics 365 using Dynamics 365 Activate. Use it as a roadmap to understand the sequence of phases, what happens in each one, and where to find detailed instructions.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Before you begin the migration steps, set up your workspace and project.

A **workspace** groups one or more migration projects for a team. A **project** stores the credentials, discovery results, and mappings for a single migration engagement. Set up both before you connect to any source or target system.

- Create a workspace and invite team members with the appropriate roles (Administrator, Contributor, or Reader).
- Create a migration project inside the workspace.

For details, see [Manage workspaces](manage-workspaces.md) and [Access and set up Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-access-setup.md).

## Migration steps

The migration process involves the following steps:

| Step | Action |
|---|---|
| [Step 1 - Set up Bring Your Own Storage (optional)](#step-1---set-up-bring-your-own-storage-optional) | Bring your own Azure Storage to keep migration data in your subscription. The default is Microsoft-managed Azure Storage. |
| [Step 2 - Connect to Salesforce and run discovery](#step-2---connect-to-salesforce-and-run-discovery) | Set up the Salesforce connection and assess your org. |
| [Step 3 - Connect to Dynamics 365 and run target discovery](#step-3---connect-to-dynamics-365-and-run-target-discovery) | Set up the Dynamics 365 connection and scan your target environment. |
| [Step 4 - Map objects and fields](#step-4---map-objects-and-fields) | Map Salesforce objects and fields to Dynamics 365 tables and columns. |
| [Step 5 - Map users](#step-5---map-users) | Map Salesforce users to existing Dataverse users before migrating records. |
| [Step 6 - Deploy the solution](#step-6---deploy-the-solution) | Generate and import a Dynamics 365 solution for any new schema. |
| [Step 7 - Migrate data and verify results](#step-7---migrate-data-and-verify-results) | Run the data migration, monitor progress, and reconcile record counts. |
| [Step 8 - Clean up](#step-8---clean-up) | Revoke credentials and remove project data when migration is complete. |

## Step 1 - Set up Bring Your Own Storage (optional)

By default, Dynamics 365 Activate uses Microsoft-managed Azure Storage to stage migration records temporarily. If your organization requires data to stay in your own Azure subscription, configure Bring Your Own Storage (BYOS) before you run discovery.

> [!IMPORTANT]
> The migration service writes discovery results and mappings to the project database selected at discovery time. If you connect a different project database after discovery, you must run discovery again.

For details, see [Set up your own storage and database for Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-byos.md).

## Step 2 - Connect to Salesforce and run discovery

Discovery scans your Salesforce org in read-only mode and produces a migration readiness assessment. The application uses a dedicated integration user you configure with the minimum required permissions.

- Set up a Salesforce External Client App and a least-privilege integration user.
- Connect the application to your Salesforce org and save the credentials.
- Run discovery across the key categories: objects and relationships, flows and automation, Apex code, ISV packages, and usage and tech debt.
- Review assessment results and download a shareable report.

For details, see [Connect to Salesforce and run discovery](migrate-salesforce-to-dynamics-365-connect-salesforce.md).

## Step 3 - Connect to Dynamics 365 and run target discovery

The application also connects to your target Dynamics 365 environment to understand the existing schema and validate migration readiness.

- Create a Microsoft Entra app registration and a Dataverse application user with the minimum required permissions.
- Connect the application to your Dynamics 365 environment.
- Run target discovery to identify existing tables, columns, and relationships.

For details, see [Connect to Dynamics 365 and run discovery](migrate-salesforce-to-dynamics-365-connect-dynamics.md).

## Step 4 - Map objects and fields

Mapping defines how your Salesforce data model translates to Dynamics 365. The application auto-generates starting-point mappings for standard Sales and Customer Service objects.

- Review and adjust auto-generated object and field mappings. Map each Salesforce object to an existing Dynamics 365 table or define a new one.
- Map individual fields to existing Dynamics 365 columns or create new ones as needed.
- Resolve all validation errors and low-confidence mappings before proceeding to user mapping.

For details, see [Map Salesforce objects and fields to Dynamics 365](migrate-salesforce-to-dynamics-365-object-mapping.md).

## Step 5 - Map users

Dynamics 365 Activate uses user mapping to connect Salesforce users to existing users in Microsoft Dataverse. Configure user mapping before you migrate records that contain user references.

- Run user discovery to automatically match Salesforce users to Dataverse users by email or username.
- Manually map any users that weren't matched automatically.
- Validate that all Salesforce users referenced in your migration scope are mapped before starting data migration.

For details, see [Map Salesforce users to Dynamics 365 users](migrate-salesforce-to-dynamics-365-user-mapping.md).

## Step 6 - Deploy the solution

If your mappings include new tables or columns, the application generates a Dynamics 365 solution and imports it into your environment to create the required schema before data migration begins. If all your mappings use existing Dynamics 365 schema, you can skip this phase.

- Generate the solution package from your confirmed mappings.
- Deploy the solution to your target Dynamics 365 environment.
- Verify the deployment status before starting data migration.

For details, see [Deploy the Dynamics 365 schema for migration](migrate-salesforce-to-dynamics-365-solution-deployment.md).

## Step 7 - Migrate data and verify results

After the application confirms connections and deploys the schema, run the data migration. The application supports trial runs, full migrations, and delta runs for incremental updates.

- Select a migration mode for each table: **Trial 100** (up to 100 records), **Full** (all records), or **Delta** (records changed since the last successful run).
- Start the migration and monitor progress in real time. Migration runs in the background.
- After migration completes, run reconciliation to compare source and target record counts.
- Review errors, drill into logs, and re-run specific tables as needed.

For details, see [Migrate data and verify results](migrate-salesforce-to-dynamics-365-migration-verification.md).

## Step 8 - Clean up

After migration and verification are complete, remove credentials and project data you no longer need.

- Revoke the Salesforce External Client App credentials and remove the integration user's migration-specific permissions.
- Revoke the Dynamics 365 app registration credentials and remove the application user.
- Delete staging data from Microsoft-managed or customer-owned storage.
- Remove the project from Dynamics 365 Activate.

For details, see [Clean up after a Salesforce migration](migrate-salesforce-to-dynamics-365-cleanup.md).

## Related information

- [Overview of Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-overview.md)
- [Manage workspaces](manage-workspaces.md)
- [Access and set up Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-access-setup.md)
- [Security and data handling for Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-security.md)