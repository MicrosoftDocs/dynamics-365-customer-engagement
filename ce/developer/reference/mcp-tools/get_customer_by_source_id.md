---
title: Resolve customer by source ID
description: Learn how to use the Resolve customer by source ID capability in Dynamics 365 Customer Insights.
ms.date: 09/02/2026
ms.topic: reference
ms.service: dynamics-365-customer-insights
ms.custom: mcp-enabled-namespaces=customer-insights
author: Scott-Stabbert
ms.author: demazuro
ms.reviewer: demazuro
---

# Resolve customer by source ID

**Applies to:** Dynamics 365 Customer Insights

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you hold a record identifier from a source system and want the unified Customer Insights customer it was stitched into.

## What it does

Customer Insights ingests records from many source systems—for example a loyalty program or an ERP—and stitches them into one unified profile. This capability takes a source entity name and a source record ID and returns the unified customer ID that record maps to.

Use it when you have an ID from an ingested source table and need the Customer 360 ID before reading a customer's details, segments, measures, or predictions. If no unified profile maps to that source record, the assistant tells you nothing was found.

## Try prompts like

- Which unified customer does this loyalty record map to in Customer Insights?
- Map a source lead record to its unified Customer Insights customer.
- We ingested a record from marketing—resolve which stitched Customer Insights profile it became.
- Resolve an ERP customer record to its Customer Insights customer ID.
- Find the unified profile for this source-system record.

## What you'll see in chat

The assistant replies with the unified customer ID that the source record maps to. If no unified profile is linked to that record, it tells you the customer wasn't found.

## Helpful tips

- Provide both the source entity name (the logical name of the ingested table, such as `contact` or `loyaltymember`) and the source record's key value.
- If you have a Dataverse contact ID specifically, use `get_customer_by_contact`—it's the shortcut for contacts.
- Once you have the customer ID, continue with "show everything about this customer" or ask for segments, measures, or predictions.

## What happens next

After the customer resolves, you can continue with prompts like:

- Show me everything Customer Insights knows about this customer.
- Which segments is this customer in?
- What's this customer's churn risk?

## Does this change data?

**No, resolving a customer by source ID doesn't change data.**

This capability only reads the source-to-unified mapping from Customer Insights. It never creates, updates, or deletes records.

## Prerequisites

This tool is available on the Dynamics 365 Customer Insights MCP server. See the availability note at the top of this page for details. Customer Insights must be configured for your environment with the relevant source data ingested, and you need permission to read the source-to-unified key mapping.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Resolve Customer By Source ID |
| Internal tool name | `get_customer_by_source_id` |
| Purpose | Resolves a unified Customer Insights customer ID from a source-system record identifier |

## Tool behavior

Resolves a Customer Insights unified customer ID from a source-system record identifier (`msdynci_alternatekey`). Pass the source entity's logical name and the source record's key value; the tool returns the matching unified customer ID, or reports not found when no unified profile maps to that source record.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | Read-only; this tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Customer Insights through Dataverse). |

## Input concepts

### Source record

| Input | Description | Required |
|---|---|---|
| `entityName` | The source entity's logical name as ingested into Customer Insights (for example `contact` or `loyaltymember`). Maximum 256 characters. | Yes |
| `sourceId` | The source record's alternate-key value to resolve. Maximum 256 characters. | Yes |

## Response and UI behavior

This tool returns a text response.

This MCP tool is not backed by an app-in-chat component.

### Response type

Unified customer ID (or not found).

The response contains the unified customer ID the source record maps to, or a not-found result when no unified profile is linked to it.

## Routing notes

Use `get_customer_by_source_id` for:

- A prompt that provides a source-system record ID (loyalty, ERP, or another ingested table) and needs the unified Customer Insights customer.

Don't use `get_customer_by_source_id` when the prompt provides:

- **A person's name**—route to `find_customer`.
- **A Dataverse contact ID**—route to `get_customer_by_contact`.
- **An already-resolved customer ID and a request for their data**—route to `get_customer_details` or a specialist reader.

## Related tools

| Tool | Relationship |
|---|---|
| [`find_customer`](find_customer.md) | Resolves a unified customer from a name |
| [`get_customer_by_contact`](get_customer_by_contact.md) | Resolves a unified customer from a Dataverse contact |
| [`get_customer_details`](get_customer_details.md) | Returns the full Customer 360 for a resolved customer |
| [`list_data_sources`](list_data_sources.md) | Lists the ingested data sources and their source entity names |

## Data mutation classification

Read-only.

This tool only reads the source-to-unified key mapping from Customer Insights and never changes data.
