---
title: Get customer measures
description: Learn how to use the Get customer measures capability in Dynamics 365 Customer Insights.
ms.date: 09/02/2026
ms.topic: reference
ms.service: dynamics-365-customer-insights
ms.custom: mcp-enabled-namespaces=customer-insights
author: Scott-Stabbert
ms.author: demazuro
ms.reviewer: demazuro
---

# Get customer measures

**Applies to:** Dynamics 365 Customer Insights

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you have a customer's unified ID and want their Customer Insights measures—the KPIs computed for that customer.

## What it does

For one unified customer, this capability returns the measures (KPIs) Customer Insights has computed for them—for example lifetime value, order counts, or engagement scores. Customer Insights can store measures in two different layouts; this capability merges both into a single list so you don't have to know how they're stored.

Resolve the customer ID first with `find_customer`, `get_customer_by_contact`, or `get_customer_by_source_id`. If the customer has no measures, the assistant returns an empty list.

## Try prompts like

- What's this customer's total purchases and average order value?
- Show this customer's Customer Insights measures and KPIs.
- Pull this customer's lifetime spend and order KPIs from Customer Insights.
- What's this customer's engagement score?
- List every measure Customer Insights computed for this customer.

## What you'll see in chat

The assistant replies with a text list of the customer's measures, each with its name and values. Measures from the shared blob are listed first, then measures hydrated into their own tables. If the customer has no measures, it tells you the list is empty.

## Helpful tips

- Resolve the customer ID first with `find_customer`, `get_customer_by_contact`, or `get_customer_by_source_id`.
- Measures are aggregated KPIs (such as lifetime value or order count), not forward-looking scores—for churn risk or predicted lifetime value, ask for predictions.
- For a single view of measures alongside segments and predictions, ask for the full Customer 360.

## What happens next

You can keep working with the same customer:

- What's this customer's churn risk?
- Which segments is this customer in?
- Show me everything Customer Insights knows about this customer.

## Does this change data?

**No, reading a customer's measures doesn't change data.**

This capability only reads computed measures from Customer Insights. It never creates, updates, or deletes records.

## Prerequisites

This tool is available on the Dynamics 365 Customer Insights MCP server. See the availability note at the top of this page for details. Customer Insights must be configured for your environment with measures defined, and you need permission to read customer measures and measure metadata.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Get Customer Measures |
| Internal tool name | `get_customer_measures` |
| Purpose | Returns the aggregated Customer Insights measures (KPIs) computed for one unified customer |

## Tool behavior

Returns the aggregated Customer Insights measures (KPIs) computed for one unified customer—for example lifetime value, order counts, or engagement scores. It merges both Dataverse layouts (the shared attribute-measure blob and per-customer measures hydrated into their own tables) into one collection. Each measure carries a name, a measure ID when known, the entity for measures hydrated to their own table, and its values. Returns an empty list when the customer has no measures.

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

Text list of measures.

Each measure includes its name and values; blob measures are listed before hydrated measures, and the list is empty when the customer has none.

## Routing notes

Use `get_customer_measures` for:

- A request for a known customer's KPIs, metrics, or measures (lifetime value, order counts, engagement).

Don't use `get_customer_measures` when:

- The prompt hasn't identified a customer—resolve first with `find_customer`, `get_customer_by_contact`, or `get_customer_by_source_id`.
- The user wants forward-looking scores (churn, predicted lifetime value)—route to `get_customer_predictions`.
- The user wants the full customer picture—route to `get_customer_details`.

## Related tools

| Tool | Relationship |
|---|---|
| [`get_customer_predictions`](get_customer_predictions.md) | Returns forward-looking scores instead of aggregated measures |
| [`get_customer_details`](get_customer_details.md) | Returns measures alongside the full Customer 360 |
| [`get_customer_segments`](get_customer_segments.md) | Lists the customer's segment memberships |
| [`find_customer`](find_customer.md) | Resolves the customer ID this tool needs |

## Data mutation classification

Read-only.

This tool only reads computed measures from Customer Insights and never changes data.
