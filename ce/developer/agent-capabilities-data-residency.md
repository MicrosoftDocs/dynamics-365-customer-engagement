---
title: Data residency for agent capabilities in Dynamics 365
description: Learn about data storage, caches, and processing boundaries for agents in Dynamics 365 Customer Service, Sales, Customer Insights, and Field Service.
ms.date: 11/23/2026
ms.topic: concept-article
ms.service: dynamics-365
author: elopezanaya
ms.author: elopezanaya
ms.reviewer: laalexan
ai-usage: ai-assisted
---

# Data residency for agent capabilities in Dynamics 365

**Applies to:** Dynamics 365 Customer Service, Dynamics 365 Sales, Dynamics 365 Customer Insights, and Dynamics 365 Field Service

<!-- DRAFT REVIEW: Obtain source-owner and privacy approval before publication. Confirm effective deployment locations, cache placement and persistence, telemetry ingestion and downstream transfers, retention, and geographic commitments. This article doesn't establish a live deployment footprint or a preview eligibility matrix. -->

Agent capabilities use Dataverse business records, supporting services, caches, and diagnostics. Review these data boundaries when you plan access, integrations, and compliance for your organization.

This guidance applies to the listed products in the commercial public cloud. Field Service capabilities are in preview. Workforce Engagement Management capabilities are covered under Customer Service. The guidance doesn't establish availability or residency commitments for sovereign clouds.

> [!IMPORTANT]
> Dataverse storage, agent processing, shared caches, and diagnostics have distinct boundaries. The selected Dataverse geography doesn't by itself establish the processing or storage location of every supporting service. For governing commitments, see [Dynamics 365 and Power Platform availability](/dynamics365/get-started/availability), [Power Platform and Dynamics 365 macro regions](/power-platform/admin/macro-regions), and the [Microsoft Product Terms](https://www.microsoft.com/licensing/terms/product/PrivacyandSecurityTerms/all).

## Where data is stored

Agents read and update Dataverse by using the signed-in user's permissions. Dataverse remains the system of record for business records and staged Field Service change plans.

| Data or operation | Boundary |
|---|---|
| Business records, attachments, feedback, agent configuration, and Field Service change plans | Stored in your Dataverse environment under its storage, backup, and recovery policies. |
| Tool requests and responses | Processed by the agent service and returned to the calling client. Responses can contain data the signed-in user can access. |
| Access tokens | Held in process memory within this service, rather than its distributed cache. Microsoft Entra ID handles token exchanges. |
| Local caches | Hold short-lived identity, authorization, configuration, metadata, and record references. Local entries are lost when a process restarts. |
| Shared caches | Azure Managed Redis can retain metadata, configuration, identity mappings, license entitlements, and authorization outcomes until their configured expiration. Shared entries can survive a process restart. |
| Telemetry and logs | Can contain tenant, organization, user-linked, conversation, and record identifiers, along with performance and usage information. Diagnostic storage is separate from Dataverse. |
| Microsoft services | Entra ID, Dataverse, Dataverse MCP, and Power Platform process authentication and request data. The Experimentation and Configuration Service (ECS) can receive the unhashed tenant ID for tenant-specific feature configuration; the returned configuration can be cached. |
| Optional extensions | Registered MCP servers or Copilot Studio agents can receive request data and an on-behalf-of token. Their own data-handling terms apply. |

## Understand cache and diagnostic data

Identity-related caches can use shared partitions rather than per-organization partitions. Their keys include hashed tenant and user identifiers, but cached values can still contain Dataverse user and organization IDs. These entries and operational identifiers aren't anonymous simply because keys are hashed.

Cache expiration doesn't establish physical-erasure timing for persistent cache media or diagnostic copies. Dataverse backup and recovery policies don't automatically apply to these stores.

Initial telemetry ingestion, downstream forwarding, and retained diagnostic copies can have different locations and retention policies. Review the applicable service policies for those boundaries; local log rotation or cache expiration doesn't establish them.

## Understand processing locations

Customers select a Dynamics 365 or Power Platform geography for their environment. Agent service routing can select a healthy processing deployment, and transient processing can occur outside the geography selected for Dataverse.

Review processing, cache, diagnostic, and failover locations against the applicable service commitments. The Dataverse geography alone doesn't identify the location of every supporting service.

## Review data transfers

Data can leave the selected Dynamics geography in these cases:

- Automatic global routing sends a request to a healthy service-processing deployment in another supported commercial-cloud geography.
- Microsoft-operated diagnostic systems receive and can forward operational identifiers and measurements under their applicable policies.
- Microsoft Entra ID, Microsoft Dataverse MCP, and Power Platform services process the minimum data needed to authenticate or complete a requested operation.
- ECS receives the tenant identifier when the service requests tenant-specific feature configuration. Hashing a cache key doesn't anonymize this outbound identifier.
- An organization maker or admin configures an external MCP endpoint or Copilot Studio agent. The configured destination can receive Customer Content or identifiable information supplied in the tool arguments or message.
- Microsoft support or security operations access diagnostic data under Microsoft access-control and support processes.

The [EU Data Boundary](/privacy/eudb/eu-data-boundary-learn) describes Microsoft's commitments for EU customers and the limited circumstances in which data can be transferred outside the EU Data Boundary.

## Review availability

Select the environment geography when you create the Dynamics 365 or Power Platform environment. This choice doesn't select an individual Azure region for each agent request.

Use the [Dynamics 365 and Power Platform availability page](/dynamics365/get-started/availability) to review current product and geography availability.
