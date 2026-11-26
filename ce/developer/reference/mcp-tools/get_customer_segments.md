---
title: Get customer segments
description: Learn how to use the Get customer segments capability in Dynamics 365 Customer Insights.
ms.date: 09/02/2026
ms.topic: reference
ms.service: dynamics-365-customer-insights
ms.custom: mcp-enabled-namespaces=customer-insights
author: Scott-Stabbert
ms.author: demazuro
ms.reviewer: demazuro
---

# Get customer segments

**Applies to:** Dynamics 365 Customer Insights

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you have a customer's unified ID and want the list of Customer Insights segments they belong to.

## What it does

For one unified customer, this capability lists the Customer Insights segments (audiences) the customer is a member of. Each segment is shown with its friendly display name and its segment ID, so you can use it for targeting or reference.

Resolve the customer ID first with `find_customer`, `get_customer_by_contact`, or `get_customer_by_source_id`. If the customer isn't in any segments, the assistant returns an empty list.

## Try prompts like

- Which segments is this customer in?
- List the Customer Insights segments this customer belongs to.
- For targeting, tell me every segment membership this customer has.
- What audiences does this customer belong to?
- Show this customer's segment memberships with their display names.

## What you'll see in chat

The assistant replies with a text list of the customer's segments, each with a friendly name and segment ID. If the customer belongs to no segments, it tells you the list is empty.

## Helpful tips

- Resolve the customer ID first with `find_customer`, `get_customer_by_contact`, or `get_customer_by_source_id`.
- Segment names shown are the marketer-facing display names; the internal name is used when a segment has no display name.
- For the customer's full picture including segments, measures, and predictions together, ask for the full Customer 360.

## What happens next

You can keep working with the same customer:

- What's this customer's total purchases and average order value?
- What's this customer's churn risk?
- Show me everything Customer Insights knows about this customer.

## Does this change data?

**No, listing a customer's segments doesn't change data.**

This capability only reads segment memberships from Customer Insights. It never creates, updates, or deletes records.

## Prerequisites

This tool is available on the Dynamics 365 Customer Insights MCP server. See the availability note at the top of this page for details. Customer Insights must be configured for your environment with segments defined, and you need permission to read segment memberships and segment metadata.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Get Customer Segments |
| Internal tool name | `get_customer_segments` |
| Purpose | Lists the Customer Insights segments a unified customer belongs to, with display names and IDs |

## Tool behavior

Lists the Customer Insights segments a unified customer belongs to, pairing each segment name with its friendly (display) name and segment ID (`msdynci_segmentmembership` joined to `mscipriv_segmentmetadata`). The friendly name falls back to the internal name when the metadata has none. Returns an empty list when the customer has no segment memberships.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | Read-only; this tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Customer Insights through Dataverse). |

## Input concepts

### Customer

| Input | Description | Required |
|---|---|---|
| `customerId` | The Customer Insights unified customer ID (32-character hex). | Yes |

## Response and UI behavior

This tool returns a text response.

This MCP tool is not backed by an app-in-chat component.

### Response type

Text list of segments.

Each entry pairs a segment name with its friendly display name and segment ID; the list is empty when the customer is in no segments.

## Routing notes

Use `get_customer_segments` for:

- A request for which segments or audiences a known customer belongs to.

Don't use `get_customer_segments` when:

- The prompt hasn't identified a customer yet—resolve first with `find_customer`, `get_customer_by_contact`, or `get_customer_by_source_id`.
- The user wants the full customer picture—route to `get_customer_details`.
- The user wants measures, predictions, or household—route to the matching specialist tool.

## Related tools

| Tool | Relationship |
|---|---|
| [`get_customer_details`](get_customer_details.md) | Returns segments alongside the full Customer 360 |
| [`get_customer_measures`](get_customer_measures.md) | Returns the customer's measures and KPIs |
| [`get_customer_predictions`](get_customer_predictions.md) | Returns the customer's machine-learning predictions |
| [`find_customer`](find_customer.md) | Resolves the customer ID this tool needs |

## Data mutation classification

Read-only.

This tool only reads segment memberships from Customer Insights and never changes data.
