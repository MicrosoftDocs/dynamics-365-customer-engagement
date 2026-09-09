---
title: Salesforce to Dynamics 365 migration overview (preview)
description: Learn about Dynamics 365 Activate, which helps you migrate your existing CRM data to Dynamics 365 Sales. Understand its capabilities, supported scenarios, and architecture.
ms.date: 09/09/2026
ms.update-cycle: 180-days
ms.topic: overview
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
---

# Salesforce to Dynamics 365 migration overview (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Dynamics 365 Activate is a web-based application that helps you assess your Salesforce org and migrate CRM data to Dynamics 365 Sales and Dynamics 365 Customer Service. It automates the analysis and transformation of your Salesforce configuration - including objects, fields, relationships, automation, and code - and guides you through the migration journey from discovery through schema deployment, data migration, and reconciliation in Dynamics 365.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Supported scenarios

The application supports migration from **Salesforce** to **Dynamics 365 Sales and Customer Service**, including:

- **Discovery and assessment**: Scan a Salesforce org to catalog all objects, fields, flows, Apex classes, Lightning pages, ISV packages, integrations, localization settings, and licenses.

- **Object and field mapping**: Map Salesforce objects and fields to Dataverse tables and columns, with prebuilt standard mappings for common Sales and Customer Service data, including accounts, contacts, leads, opportunities, cases, case comments, entitlements, activities, and knowledge articles.  
- **Schema creation**: Create tables, columns, choice columns (option sets), and relationships in Dynamics 365 based on your mappings.
- **Data migration**: Transfer structured data records from Salesforce to Dynamics 365 Sales and Customer Service with progress tracking and post-migration reconciliation.  
- **Reconciliation**: Verify that record counts match between source and target after migration.

> [!NOTE]
> Automation and code (flows, Process Builder, workflow rules, Apex classes) are analyzed and assessed for migration effort, but aren't automatically converted or migrated by this application. In addition to structured table records, the application supports migration of selected binary content, including Salesforce Files, ContentNotes, classic Attachments, email attachments, and supported record images. The application skips and reports files that exceed the target Dataverse environment’s maximum upload size, don't have a supported migrated parent, or belong to an unsupported scenario.

## Key capabilities

### Automated discovery

The application connects to Salesforce in read-only mode and scans the supported metadata, configuration, and data that the configured Salesforce integration user can see:

| Discovery category | What the application discovers |
|---|---|
| **Objects & Relationships** | Standard and custom objects, fields, relationships, dependency chains, data volume and freshness, complexity scoring, migration recommendations |
| **Flows & Automation** | Flows, Process Builder processes, automation complexity |
| **Apex Code** | Classes, triggers, test coverage, code complexity scores |
| **Business Processes** | Workflow rules, field updates, approval processes |
| **Lightning Pages** | Page layouts, components, and Dynamics 365 app recommendations |
| **ISV Packages** | Installed managed packages with Microsoft ecosystem alternatives |
| **Integrations** | Connected apps, named credentials, external data sources, platform events |
| **Localization & Currency** | Languages, translations, multi-currency configuration |
| **Licenses & Users** | License types, user profiles, usage patterns |
| **Usage & Tech Debt** | Low-usage objects and fields, inactive automations, cleanup opportunities |

> [!NOTE]
> Discovery includes supported, queryable Salesforce objects. Discovery and migration don't include unsupported object categories, including Salesforce Big Objects (`__b`) and External Objects (`__x`). The configured integration user's permissions determine which metadata, fields, and records the application can access.

### Migration readiness report

After discovery, you can download a PDF, Word, or JSON report containing complexity scores, migration readiness ratings, recommended migration approaches, and transformation recommendations. Share this report with stakeholders and project teams.

### Visual object mapping

Use the visual mapping interface to map Salesforce objects to existing or new Dynamics 365 tables, and individual fields to existing or new columns. Use prebuilt mappings for standard Sales and Customer Service objects (Account, Contact, Opportunity, Lead, and so on) as a starting point.  

### User, team, ownership, and access mapping

Map Salesforce users to Dataverse users and configure how to handle inactive or unmatched users. The application also supports mapping Salesforce profiles and permission sets to Dataverse security roles, mapping role hierarchy information to business units, creating or linking teams and queues, transferring supported record ownership, and preserving supported audit information. Review all generated mappings before migration because Salesforce and Dataverse use different security and ownership models.  

### Solution deployment

For custom objects and fields, the application generates a Dynamics 365 solution package. The application can automatically import this package into your target environment to create the required schema before data migration begins.

### Monitoring and reconciliation

Track migration progress with detailed logs. Drill into errors, and run automated reconciliation to compare source record counts against migrated record counts in Dynamics 365.

## Data security

- **Credentials at rest**: Salesforce, Dynamics 365, and BYOS connection credentials are encrypted by using AES-256-GCM. In hosted environments, credentials use envelope encryption backed by a Microsoft-managed key-encryption key in Azure Key Vault and are cryptographically scoped to the associated user or project.  
- **Data in transit**: All connections use HTTPS with TLS 1.2 minimum.
- **Staging data**: Migration records are temporarily staged in Microsoft-managed Azure Blob Storage or, when Bring Your Own Storage (BYOS) is configured, in a customer-owned Azure Storage account before being written to Dataverse. A scheduled cleanup runs every 24 hours for failed, stopped, completed-with-errors, and rolled-back runs. Files from completed runs are removed when the next non-resumed migration run begins. By using BYOS, service cleanup requires the saved SAS and network connection to remain valid, and the customer’s storage lifecycle and deletion policies provide the final retention controls.  
- **Authentication**: Users authenticate through Microsoft Entra ID. All API requests require a valid JWT.
- **Salesforce access**: The application enforces read-only access to the Salesforce source org at the application level. It blocks all write, update, and delete operations against Salesforce.
- **Data residency**: All data remains within Microsoft Azure. The application doesn't send any customer data to third-party services.

For more information, see [Security and data handling for Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-security.md).

## Limitations

Be aware of the following limitations in the current preview release:

- **Automation not migrated**: The application assesses but doesn't convert or migrate flows, Process Builder, workflow rules, and Apex.
- **Binary content has scoped support**: You can migrate Salesforce Files, ContentNotes, classic Attachments, email attachments, and supported record images. The application doesn't migrate files that exceed the Dataverse maximum upload size or attachments in unsupported scenarios, such as Omnichannel conversation-entry attachments.  
- **Schema transformations**: Field types, picklist values, and formatting might differ between Salesforce and Dynamics 365. The application transforms values to fit the target schema, which might change how data appears.
- **External API rate limits**: Salesforce API rate limits can affect large migrations and introduce delays.

## Related information

- [Quick start guide for Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-quick-start.md)
- [Access and set up Dynamics 365 Activate](migrate-salesforce-to-dynamics-365-access-setup.md)
- [Connect to Salesforce and run discovery](migrate-salesforce-to-dynamics-365-connect-salesforce.md)
- [Connect to Dynamics 365 and run discovery](migrate-salesforce-to-dynamics-365-connect-dynamics.md)
