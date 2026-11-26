---
title: Get cluster information
description: Learn how to use the Get cluster information capability in Dynamics 365 Customer Insights.
ms.date: 09/02/2026
ms.topic: reference
ms.service: dynamics-365-customer-insights
ms.custom: mcp-enabled-namespaces=customer-insights
author: Scott-Stabbert
ms.author: demazuro
ms.reviewer: demazuro
---

# Get cluster information

**Applies to:** Dynamics 365 Customer Insights

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you have a customer's unified ID and want to know who they're grouped with—their household or another Customer Insights cluster.

## What it does

For one unified customer, this capability returns the Customer Insights clusters the customer belongs to—for example a household—and, for each cluster, the co-members who share that assignment, each with an affinity score. The cluster columns are discovered from Customer Insights model metadata, so it works for any cluster type your environment defines.

To interpret membership, rely on the member count and member list: a member count greater than one means the customer shares the cluster (such as a household). The customer's own affinity score can be empty even when co-members exist, so an empty score doesn't mean the customer is alone. Resolve the customer ID first with `find_customer`, `get_customer_by_contact`, or `get_customer_by_source_id`. If the customer belongs to no cluster, the assistant returns an empty list.

## Try prompts like

- Who is in this customer's household?
- Show the Customer Insights cluster and household for this customer.
- Which household cluster does this customer belong to, and who shares it?
- Who is this customer grouped with in Customer Insights?
- List the co-members of this customer's cluster.

## What you'll see in chat

The assistant replies with a text list of the customer's clusters. For each cluster it shows the cluster type, the number of members, and the co-members with their affinity scores. If the customer belongs to no cluster, it tells you the list is empty.

## Helpful tips

- Resolve the customer ID first with `find_customer`, `get_customer_by_contact`, or `get_customer_by_source_id`.
- Use the member count and member list to judge shared membership—an empty affinity score doesn't mean the customer is alone.
- For clusters alongside segments, measures, and predictions in one view, ask for the full Customer 360.

## What happens next

You can keep working with the same customer:

- Which segments is this customer in?
- What's this customer's churn risk?
- Show me everything Customer Insights knows about this customer.

## Does this change data?

**No, reading cluster information doesn't change data.**

This capability only reads cluster memberships from Customer Insights. It never creates, updates, or deletes records.

## Prerequisites

This tool is available on the Dynamics 365 Customer Insights MCP server. See the availability note at the top of this page for details. Customer Insights must be configured for your environment with clustering models defined, and you need permission to read unified profiles and Customer Insights model metadata.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Get Cluster Information |
| Internal tool name | `get_cluster_information` |
| Purpose | Returns a unified customer's Customer Insights cluster (household) memberships and co-members |

## Tool behavior

Returns Customer Insights cluster membership for one unified customer: for each cluster the customer belongs to (such as a household), the co-members that share the same assignment, each with an affinity score. Cluster columns are discovered from Customer Insights model metadata, so it covers any cluster type. A member count greater than one means the customer shares the cluster; the customer's own score may be empty even when co-members exist. Returns an empty list when the customer belongs to no cluster.

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
| `customerId` | The Customer Insights unified customer ID (32-character hex) whose cluster membership to read. | Yes |

## Response and UI behavior

This tool returns a text response.

This MCP tool is not backed by an app-in-chat component.

### Response type

Text list of clusters.

Each cluster shows its type, member count, and co-members with affinity scores; the list is empty when the customer belongs to no cluster.

## Routing notes

Use `get_cluster_information` for:

- A request about who a known customer is grouped with—their household, cluster, or shared audience.

Don't use `get_cluster_information` when:

- The prompt hasn't identified a customer—resolve first with `find_customer`, `get_customer_by_contact`, or `get_customer_by_source_id`.
- The user wants marketing segments rather than model clusters—route to `get_customer_segments`.
- The user wants the full customer picture—route to `get_customer_details`.

## Related tools

| Tool | Relationship |
|---|---|
| [`get_customer_segments`](get_customer_segments.md) | Lists marketing segments rather than model clusters |
| [`get_customer_details`](get_customer_details.md) | Returns clusters alongside the full Customer 360 |
| [`get_customer_predictions`](get_customer_predictions.md) | Returns the customer's machine-learning predictions |
| [`find_customer`](find_customer.md) | Resolves the customer ID this tool needs |

## Data mutation classification

Read-only.

This tool only reads cluster memberships from Customer Insights and never changes data.
