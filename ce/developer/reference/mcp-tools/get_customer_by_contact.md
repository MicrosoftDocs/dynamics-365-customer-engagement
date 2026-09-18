---
title: Resolve customer by contact
description: Learn how to use the Resolve customer by contact capability in Dynamics 365 Customer Insights.
ms.date: 09/02/2026
ms.topic: reference
ms.service: dynamics-365-customer-insights
ms.custom: mcp-enabled-namespaces=customer-insights
author: Scott-Stabbert
ms.author: demazuro
ms.reviewer: demazuro
---

# Resolve customer by contact

**Applies to:** Dynamics 365 Customer Insights

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you already have a Dynamics 365 contact and want the unified Customer Insights profile it was stitched into.

## What it does

When you're working from a CRM contact—for example the primary contact on a case—this capability resolves that contact's ID to the matching Customer Insights unified customer ID. It's a shortcut for the common case of a Dataverse contact, so you don't have to specify the source entity name yourself.

Use it to bridge from a contact to Customer Insights before reading the customer's details, segments, measures, or predictions. If the contact has no unified profile, the assistant tells you nothing was found.

## Try prompts like

- What's the Customer Insights customer for this contact?
- Resolve this CRM contact to its unified Customer Insights profile.
- Given this contact, which unified Customer Insights customer were they stitched into?
- Find the Customer 360 profile ID for this contact.
- Look up the Customer Insights customer behind this contact.

## What you'll see in chat

The assistant replies with the unified customer ID that the contact maps to. If the contact isn't linked to a unified profile, it tells you the customer wasn't found.

## Helpful tips

- Provide the contact's Dynamics 365 ID (GUID). The assistant validates it before resolving.
- This is the contact-specific shortcut; for records from other source systems, use `get_customer_by_source_id`.
- Once you have the customer ID, continue with the customer's full 360, segments, measures, or predictions.

## What happens next

After the customer resolves, you can continue with prompts like:

- Show me everything Customer Insights knows about this customer.
- Which segments is this customer in?
- What's this customer's total purchases and average order value?

## Does this change data?

**No, resolving a customer by contact doesn't change data.**

This capability only reads the contact-to-unified mapping from Customer Insights. It never creates, updates, or deletes records.

## Prerequisites

This tool is available on the Dynamics 365 Customer Insights MCP server. See the availability note at the top of this page for details. Customer Insights must be configured for your environment with contacts ingested as a source, and you need permission to read the source-to-unified key mapping.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Resolve Customer By Contact |
| Internal tool name | `get_customer_by_contact` |
| Purpose | Resolves a unified Customer Insights customer ID from a Dynamics 365 contact |

## Tool behavior

Resolves a Customer Insights unified customer ID from a Dataverse contact ID (`msdynci_alternatekey`, entity `contact`). Pass the contact ID; the tool returns the matching unified customer ID, or reports not found when the contact has no unified profile. It's a convenience shortcut over `get_customer_by_source_id` for the contact entity.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | Read-only; this tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Customer Insights through Dataverse). |

## Input concepts

### Contact

| Input | Description | Required |
|---|---|---|
| `contactId` | The Dynamics 365 contact's ID (GUID) to resolve to a unified customer ID. | Yes |

## Response and UI behavior

This tool returns a text response.

This MCP tool is not backed by an app-in-chat component.

### Response type

Unified customer ID (or not found).

The response contains the unified customer ID the contact maps to, or a not-found result when the contact has no unified profile.

## Routing notes

Use `get_customer_by_contact` for:

- A prompt that provides a Dynamics 365 contact and needs the matching unified Customer Insights customer.

Don't use `get_customer_by_contact` when the prompt provides:

- **A person's name**—route to `find_customer`.
- **A source-system record ID from another ingested table**—route to `get_customer_by_source_id`.
- **An already-resolved customer ID and a request for their data**—route to `get_customer_details` or a specialist reader.

## Related tools

| Tool | Relationship |
|---|---|
| [`find_customer`](find_customer.md) | Resolves a unified customer from a name |
| [`get_customer_by_source_id`](get_customer_by_source_id.md) | Resolves a unified customer from a source-system record ID |
| [`get_customer_details`](get_customer_details.md) | Returns the full Customer 360 for a resolved customer |
| [`get_customer_segments`](get_customer_segments.md) | Lists the segments a resolved customer belongs to |

## Data mutation classification

Read-only.

This tool only reads the contact-to-unified key mapping from Customer Insights and never changes data.
