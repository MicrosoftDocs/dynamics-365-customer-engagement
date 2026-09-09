---
title: Security and data handling for Dynamics 365 Activate (preview)
description: Learn how Dynamics 365 Activate accesses, protects, and retains your Salesforce and Dynamics 365 data during discovery and migration.
ms.date: 09/09/2026
ms.update-cycle: 180-days
ms.topic: concept-article
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Security and data handling for Dynamics 365 Activate (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

This article describes how Dynamics 365 Activate accesses your data, how it's protected, and how long it's retained.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

> [!NOTE]
> **Third-party services**: When you connect to a third-party service such as Salesforce, use of that service and the data stored there is governed by third-party terms and data handling practices. It's your responsibility to comply with applicable third-party terms and to ensure that third-party data handling practices meet your organization's requirements.

## What data is accessed

### Discovery phase — metadata only

During discovery and assessment, the application connects to your Salesforce org by using standard Salesforce APIs (REST, Metadata, applicationing, and Describe). The application enforces read-only behavior by blocking all write operations at the application level. Configure the Salesforce integration user with the minimum permissions required for your discovery scope. See [Connect to Salesforce and run discovery](migrate-salesforce-to-dynamics-365-connect-salesforce.md).

During discovery, the application retrieves:

- **Object and field definitions**: Names, types, relationships, and picklist values.
- **Automation configurations**: Flows, workflow rules, Process Builder processes, and Apex class and trigger source code.
- **Lightning page layouts**: Component structure and page configurations.
- **Org configuration**: Installed packages, languages, currency settings, and license usage.
- **Aggregate statistics**: Record counts per object, field population rates, and user counts by profile.

> [!NOTE]
> AI features are disabled in production. No Apex source code is sent to an AI model in production environments. In development or testing environments where AI is enabled, analysis prompts might include a marked excerpt of up to 1,500 characters.

### Migration phase — business records

When you start a migration, the application reads the standard data table records from your Salesforce org for the objects and fields you selected. The application:

1. Extracts the records by using the standard Salesforce REST API.
1. Temporarily stages the records in Azure Blob Storage for transformation.
1. Writes the records to your target Dynamics 365 environment.

The application supports only structured table data. It doesn't migrate attachments, files, documents, or binary content. You can access record data only after you review and confirm the consent summary that shows the objects, estimated record count, and migration mode.

### Dynamics 365

If you connect a target Dynamics 365 environment, the application reads table and column definitions for mapping purposes. During migration, the application writes records to Dynamics 365 as you direct.

### What the application never accesses

- Salesforce data beyond the objects and fields you explicitly select for migration.
- Attachments, files, documents, or binary content.
- Salesforce user passwords or security tokens.

> [!IMPORTANT]
> Read-only behavior applies to the Salesforce source system only. The migration process writes data to the target Dynamics 365 environment as directed by the user. Validation and testing of migration outcomes in Dynamics 365 remain the customer's responsibility.

## How data is protected

### Encryption

| Layer | Protection |
|---|---|
| **Credentials at rest** | Salesforce and Dynamics 365 connection details are encrypted with AES-256-GCM using per-user keys. The master encryption key is stored in Azure Key Vault and is never written to disk or logs. Only the credentials needed to establish a fresh connection are persisted—short-lived tokens such as refresh tokens aren't stored. |
| **Data in transit** | All connections use HTTPS with TLS 1.2 minimum. |
| **Database** | Azure SQL Database with Transparent Data Encryption (TDE) enabled. |

### Authentication and access control

- Users authenticate via **Microsoft Entra ID**. All API requests require a valid JWT.
- Users can access only projects they own or projects explicitly shared with them through project membership. The system enforces project authorization on every API request.
- Administrative access uses a two-tier role hierarchy: environment-level super-admins configured at deployment, and database-managed admins added through the admin interface. Administrators can delete data on behalf of users, with a confirmation step.
- Salesforce connections use OAuth 2.0 Client Credentials Flow.

### Infrastructure

The application runs on Azure App Service. Microsoft manages supporting resources such as SQL Database, Key Vault, and Storage Account. All data remains within Microsoft Azure. The application doesn't send data to third-party services or external endpoints.

### Staging storage (Azure Blob Storage)

The Azure Blob Storage account used to temporarily stage migration data is secured with the following controls:

- **No public or anonymous access**: You can't reach the staging storage anonymously or from the public internet. The service disables anonymous blob access and shared-key/SAS authentication. Access requires Microsoft Entra ID authentication through the managed identities held by the Migrate web app and Azure Data Factory.
- **Firewall-restricted access**: The storage account firewall denies all traffic by default. Only the Migrate web app's outbound IPs and the dedicated Azure Data Factory instance are permitted.
- **Encrypted in transit**: All connections require HTTPS with TLS 1.2 minimum.
- **Encrypted at rest**: Azure Storage Service Encryption (AES-256, Microsoft-managed keys) is enabled for every byte written.
- **Per-run data isolation**: Each migration run writes to its own GUID-scoped blob path (for example, `staging/{runId}/`), so data from different customers and runs never shares a path and can't be enumerated across projects.
- **In-region**: Staging data stays in the Azure region where the application is deployed.

For customers who want stronger data isolation, use the [Bring Your Own Storage (BYOS)](migrate-salesforce-to-dynamics-365-byos.md) option to stage migration data in a storage account inside your own Azure subscription.

## AI features

AI-enhanced analysis capabilities are available in development and testing environments only. In production, all AI features are disabled:

- No Azure OpenAI or other model inference is active in production.
- No customer data is sent to any AI service in production.
- All migration recommendations in production are generated using rule-based analysis only.

## Limitations and billing

### Limitations

This application is provided as a preview and has known limitations. Validate results before relying on them:

- **Incomplete data migration**: The application only supports structured standard and custom table records for the objects and fields you select. It doesn't migrate attachments, files, documents, or binary content. The application might skip records if they fail validation against the target Dynamics 365 schema.
- **Formatting and transformation changes**: Field types, picklist values, and formatting might differ between Salesforce and Dynamics 365. The application transforms values to fit the target schema, which can change how data appears or is interpreted.
- **Latency**: Discovery and migration run times depend on org size, record volume, and external API throughput. Large migrations might take significant time, and third-party API rate limits can introduce delays or require retries.
- **Automation and code aren't migrated**: The application analyzes flows, Process Builder, workflow rules, and Apex for assessment only. It doesn't convert or migrate these components.

Always perform post-migration validation and reconciliation before using migrated data in production.

### Billing

There's no charge for the migration application itself during the preview. However, use of the application might still result in charges in your own Microsoft and third-party subscriptions. For example, you might incur charges for Dynamics 365 and Dataverse capacity and storage consumed by migrated data, and for any Salesforce or other third-party API usage governed by your agreements with those providers. Review your applicable subscription terms before running a migration.

## Data lifecycle and retention

### Staging data

During data migration, the application temporarily stages records in Azure Blob Storage before writing them to Dynamics 365. A scheduled cleanup job automatically deletes staging data for failed, stopped, or errored migrations within 24 hours. The application clears staging data for successfully completed migrations at the start of the next run. Failed or abandoned migrations don't result in indefinite data retention.

### Migration consent

Before the application begins any migration, you must review and confirm a consent summary that shows the number of objects, estimated record count, and migration mode. The application persists this consent for audit purposes.

### Migration metadata

The application stores discovery results, object mappings, field mappings, and migration run history in Azure SQL Database. It retains this data for the lifetime of the project and deletes it when you delete the project or use the **Delete All My Data** option.

### Credential cleanup

The system automatically removes credentials for inactive projects after 28 days of inactivity. You can also manually delete credentials for any project at any time from the project settings.

### Customer-initiated deletion

Select your name > **Delete All My Data** to permanently remove all your projects, credentials, discovery results, analysis data, staging blobs, and your user record. An administrator can also perform this action on your behalf with a confirmation step.

After deletion, the system retains only a summary audit record (containing counts of items deleted—no user identifiers or personal data).

### Retention summary

| Data type | Storage | Retention | How it's removed |
|---|---|---|---|
| Staging blobs | Azure Blob Storage | Within 24 hours of run failure or stop; next run for completed migrations | Automatic |
| Migration metadata | Azure SQL | Project lifetime | User-initiated or admin |
| Credentials | Azure SQL (encrypted) | Project lifetime or 28 days of inactivity | Automatic, user-initiated, or admin |
| Application logs | Application Insights | 30 days (configurable) | Per workspace policy |
| Audit trail | Azure SQL | Indefinite (no personal data) | Not deleted |

## Audit logging

The system records all user actions to a security audit trail, including authentication attempts, authorization decisions, project creation and deletion, credential management, migration lifecycle events, discovery operations, and administrative actions. Each audit entry captures timestamp, user identity, action, result, IP address, and user agent.

The system redacts email addresses from application logs by using cryptographic hashing to protect user privacy while preserving correlation capability.

All API calls made by the application to your Salesforce org are standard Salesforce API operations and are visible in your Salesforce org's API usage metrics and Event Monitoring logs. Your Salesforce administrators retain full visibility into what was accessed and when.

## Frequently asked questions

**Does this application copy any of our Salesforce data?**  
During discovery, no—it reads only schema definitions, configuration, and aggregate counts. During migration, yes—the application reads the business records you explicitly select, stages them temporarily in Azure Blob Storage, and writes them to your target Dynamics 365 environment. The application automatically cleans up staging data. See [Data lifecycle and retention](#data-lifecycle-and-retention).

**Does our data leave Microsoft Azure?**  
No. The application and all its supporting services run within Microsoft Azure. The application doesn't send data to third-party services or public AI endpoints.

**Is the staging storage publicly reachable? How is our data isolated from other customers?**  
The staging Blob Storage account has no public or anonymous endpoints, shared-key authentication is disabled, and a firewall restricts access to only the Migrate web app and Azure Data Factory by using Microsoft Entra ID identities. Every migration run writes to its own GUID-scoped path so customers' data never shares a path or mixes. Data is encrypted at rest with AES-256 and stays in-region. See [Staging storage](#staging-storage-azure-blob-storage) for the full set of controls.

**What Salesforce permissions does the application need?**  
For discovery, the integration user needs metadata read access. For migration, the user also needs record read access for the selected objects and fields. For a detailed breakdown, see [Discovery permissions by area](migrate-salesforce-to-dynamics-365-connect-salesforce.md#discovery-permissions-by-area).

**Can we verify what was accessed?**  
Yes. All API activity appears in Salesforce's standard API usage logs and Event Monitoring. The application's audit log records every action performed within the application.

**Can we delete all our data after the assessment or migration?**  
Yes. Select your name > **Delete All My Data** to permanently remove all stored data in a single operation. See [Clean up after a Salesforce migration](migrate-salesforce-to-dynamics-365-cleanup.md).

**Can we run this application without AI features?**  
Yes. AI features are currently disabled in all production environments. All analysis in production uses rule-based logic only.

## Related information

- [Overview of Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-overview.md)
- [Connect to Salesforce and run discovery](migrate-salesforce-to-dynamics-365-connect-salesforce.md)
- [Set up Bring Your Own Storage for migration data](migrate-salesforce-to-dynamics-365-byos.md)
- [Clean up after a Salesforce migration](migrate-salesforce-to-dynamics-365-cleanup.md)
