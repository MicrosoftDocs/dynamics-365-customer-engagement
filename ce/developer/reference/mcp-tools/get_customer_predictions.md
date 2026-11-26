---
title: Get customer predictions
description: Learn how to use the Get customer predictions capability in Dynamics 365 Customer Insights.
ms.date: 09/02/2026
ms.topic: reference
ms.service: dynamics-365-customer-insights
ms.custom: mcp-enabled-namespaces=customer-insights
author: Scott-Stabbert
ms.author: demazuro
ms.reviewer: demazuro
---

# Get customer predictions

**Applies to:** Dynamics 365 Customer Insights

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you have a customer's unified ID and want the machine-learning scores Customer Insights has computed for them.

## What it does

For one unified customer, this capability returns the machine-learning predictions Customer Insights models have scored for them—such as churn probability, predicted lifetime value, propensity, and next-best product suggestions. Each result shows the model that produced it, the model's provider, and the scored value.

Predictions are forward-looking scores. For descriptive KPIs like total purchases or order counts, use measures instead. Resolve the customer ID first with `find_customer`, `get_customer_by_contact`, or `get_customer_by_source_id`. If the customer has never been scored, the assistant returns an empty list.

## Try prompts like

- What's this customer's churn risk?
- Show the Customer Insights predictions for this customer.
- How likely is this customer to churn, and what's their predicted lifetime value?
- What's this customer's propensity score?
- What products does Customer Insights recommend for this customer?

## What you'll see in chat

The assistant replies with a text list of the customer's prediction scores, each with its originating model, the model's provider, and the scored value. If the customer has never been scored, it tells you the list is empty.

## Helpful tips

- Resolve the customer ID first with `find_customer`, `get_customer_by_contact`, or `get_customer_by_source_id`.
- Predictions are forward-looking scores (churn, predicted lifetime value, propensity)—for descriptive KPIs like total spend, ask for measures.
- For predictions alongside segments and measures in one view, ask for the full Customer 360.

## What happens next

You can keep working with the same customer:

- What's this customer's total purchases and average order value?
- Which segments is this customer in?
- Show me everything Customer Insights knows about this customer.

## Does this change data?

**No, reading a customer's predictions doesn't change data.**

This capability only reads model scores from Customer Insights. It never creates, updates, or deletes records.

## Prerequisites

This tool is available on the Dynamics 365 Customer Insights MCP server. See the availability note at the top of this page for details. Customer Insights must be configured for your environment with prediction models scored, and you need permission to read customer predictions.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Get Customer Predictions |
| Internal tool name | `get_customer_predictions` |
| Purpose | Returns the machine-learning scores Customer Insights models compute for one unified customer |

## Tool behavior

Returns the machine-learning scores Customer Insights models compute per unified customer (`msdynci_prediction`): churn probability, predicted lifetime value, propensity, and next-best product suggestions. Each row carries the originating model, its provider, and a scored numeric result. Use it for forward-looking risk and opportunity figures, not descriptive traits. Returns an empty list when the customer has never been scored.

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

Text list of prediction scores.

Each entry includes the model, its provider, and the scored value; the list is empty when the customer has never been scored.

## Routing notes

Use `get_customer_predictions` for:

- A request about a known customer's forward-looking risk or opportunity (churn, predicted lifetime value, propensity, recommendations).

Don't use `get_customer_predictions` when:

- The prompt hasn't identified a customer—resolve first with `find_customer`, `get_customer_by_contact`, or `get_customer_by_source_id`.
- The user wants descriptive KPIs (total spend, order counts)—route to `get_customer_measures`.
- The user wants the full customer picture—route to `get_customer_details`.

## Related tools

| Tool | Relationship |
|---|---|
| [`get_customer_measures`](get_customer_measures.md) | Returns aggregated KPIs instead of forward-looking scores |
| [`get_customer_details`](get_customer_details.md) | Returns predictions alongside the full Customer 360 |
| [`get_customer_segments`](get_customer_segments.md) | Lists the customer's segment memberships |
| [`find_customer`](find_customer.md) | Resolves the customer ID this tool needs |

## Data mutation classification

Read-only.

This tool only reads model prediction scores from Customer Insights and never changes data.
