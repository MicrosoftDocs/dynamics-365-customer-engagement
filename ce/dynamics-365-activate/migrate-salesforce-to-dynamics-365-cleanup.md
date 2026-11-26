---
title: Clean up after a Salesforce migration (preview)
description: Learn how to revoke Salesforce and Dynamics 365 access, delete project data, and clean up Azure resources after completing a migration with Dynamics 365 Activate.
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

# Step 8: Clean up after a Salesforce migration (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

After your migration is complete, revoke the access credentials you granted during setup and remove any data you no longer need from Dynamics 365 Activate. This article describes the cleanup steps for each component.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Revoke Salesforce access

Deactivate or delete the Salesforce External Client App that you created for discovery and migration after the project is complete.

1. In Salesforce Setup, search for and open **External Client App Manager**.
1. Find the **D365 Migrate Discovery** app (or whatever name you gave it).
1. To temporarily disable access, open **Policies**, turn off **Client Credentials Flow**, and save.
1. To remove access entirely, delete the app from **External Client App Manager**.

You can also deactivate the dedicated integration user you created for the migration to prevent any further API access by using those credentials.

## Revoke Dynamics 365 access

Remove the Azure app registration and application user that the application used to connect to your Dynamics 365 environment.

1. **Remove the application user from Dynamics 365**:
   1. Go to [Power Platform Admin Center](https://admin.powerplatform.microsoft.com).
   1. Select your environment > **Settings** > **Users + permissions** > **Application users**.
   1. Find and delete the application user created for the migration.

1. **Delete the client secret from Azure**:
   1. Go to the [Azure portal](https://portal.azure.com).
   1. Navigate to **Microsoft Entra ID** > **App registrations**.
   1. Open the app registration used for the migration.
   1. Go to **Certificates & secrets** and delete the client secret.

1. **Delete the app registration** (if you no longer need it):
   1. In Azure portal > **App registrations**, select the registration and delete it.

## Delete migration data from the application

To permanently remove all data stored in Dynamics 365 Activate for your account:

1. Select your name in the top-right corner of the application.
1. Select **Delete All My Data**.
1. Confirm the deletion.

This action permanently removes all your projects, credentials, discovery results, object mappings, and migration history. For compliance purposes, only a summary audit record that contains no personal data is retained.

To delete a single project without removing all account data:

1. Open the project.
1. Go to **Settings**.
1. Select **Delete Project** and confirm.

## Clean up Bring Your Own Storage (if configured)

If you configured [Bring Your Own Storage (BYOS)](migrate-salesforce-to-dynamics-365-byos.md), remove the access grant from your storage account:

1. Open your storage account in the [Azure portal](https://portal.azure.com).
1. Select **Access Control (IAM)**.
1. Find the role assignment for Dynamics 365 Activate service principal.
1. Select **Remove** to revoke access.

You can then delete the `sf2dv-staging` container or the storage account itself if you no longer need it.

## Data lifecycle reference

The following table summarizes how long the application retains different types of data and how it removes them.

| Data type | Storage | Retention | How it's removed |
|---|---|---|---|
| Staging blobs (migration data) | Azure Blob Storage | Cleared at start of next run (success); within 24 hours (failed or stopped run) | Automatic |
| Migration metadata (discovery results, mappings, run history) | Azure SQL | Project lifetime | User-initiated or admin |
| Credentials | Azure SQL (encrypted) | Project lifetime or 28 days of inactivity | Automatic, user-initiated, or admin |
| Application logs | Application Insights | 30 days | Per workspace policy |
| Audit trail | Azure SQL | Indefinite (no personal data) | Not deleted |

## Related information

- [Overview of Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-overview.md)
- [Migration and verification](migrate-salesforce-to-dynamics-365-migration-verification.md)
- [Set up Bring Your Own Storage for migration data](migrate-salesforce-to-dynamics-365-byos.md)
