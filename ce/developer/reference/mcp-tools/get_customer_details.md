---
title: Get customer details
description: Learn how to use the Get customer details capability in Dynamics 365 Customer Insights.
ms.date: 09/02/2026
ms.topic: reference
ms.service: dynamics-365-customer-insights
ms.custom: mcp-enabled-namespaces=customer-insights
author: Scott-Stabbert
ms.author: demazuro
ms.reviewer: demazuro
---

# Get customer details

**Applies to:** Dynamics 365 Customer Insights

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you have a customer's unified ID and want the full Customer 360—everything Customer Insights knows about them in one place.

## What it does

For one unified customer, this capability assembles a complete Customer 360: the core profile (name, email, city, country/region, postal code), the segments they belong to, all of their measures, cluster (household) memberships, machine-learning predictions, and the source records that stitched into the profile. For each source record it also shows the field-level mapping—which source system won each unified value—so you can see why the profile shows a particular value.

The segments, measures, clusters, and predictions come from the same readers the specialist tools use, so this overview never disagrees with the dedicated tools for the same customer. Resolve the customer ID first with `find_customer`, `get_customer_by_contact`, or `get_customer_by_source_id`. If you only need one of those areas, call the specialist tool instead.

## Try prompts like

- Show me everything Customer Insights knows about this customer.
- Give me the full Customer 360 for this customer—profile, segments, measures, and sources.
- I'm prepping for a call; assemble a complete Customer Insights brief on this customer.
- Why does this customer's profile show this email address?
- Which source records built this customer's unified profile?

## What you'll see in chat

The assistant replies with a consolidated summary of the customer: their core profile, segment memberships, measures, clusters, predictions, and the source records behind the profile with their field-level provenance. If the core profile can't be found, the request fails rather than returning a partial picture; optional areas (such as clusters or predictions) report "none" when the customer has no data there.

## Helpful tips

- Resolve the customer ID first with `find_customer`, `get_customer_by_contact`, or `get_customer_by_source_id`.
- Ask for the full picture when prepping for a call; ask a specialist tool when you only need segments, measures, predictions, or clusters.
- To understand a specific value, ask why the profile shows it—the source provenance explains which system won that field.

> [!TIP]
> If the full 360 is more than you need, ask a narrower follow-up like "just this customer's segments" or "just this customer's churn risk."

## What happens next

You can narrow the focus with prompts like:

- Which segments is this customer in?
- What's this customer's total purchases and average order value?
- What's this customer's churn risk?
- Who is in this customer's household?

## Does this change data?

**No, getting customer details doesn't change data.**

This capability only reads profile, segment, measure, cluster, prediction, and source data from Customer Insights. It never creates, updates, or deletes records.

## Prerequisites

This tool is available on the Dynamics 365 Customer Insights MCP server. See the availability note at the top of this page for details. Customer Insights must be configured for your environment, and you need permission to read unified profiles and their related Customer Insights data (segments, measures, clusters, predictions, and source records).

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Get Customer Details |
| Internal tool name | `get_customer_details` |
| Purpose | Returns a full Customer 360 for one unified customer—profile, segments, measures, clusters, predictions, and source provenance |

## Tool behavior

Returns a Customer 360 overview for one unified customer ID: core profile, segment memberships, all measures, cluster memberships, machine-learning predictions, and the source records that stitched into the profile with a field-level attribute mapping showing which source won each unified value. The segments, measures, clusters, and predictions match what the dedicated tools return for the same customer. A missing core profile fails the call rather than returning a partial view; optional sections report "none" when their data is absent.

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
| `customerId` | The Customer Insights unified customer ID (32-character hex) to fetch. | Yes |

### Projection

| Input | Description | Required |
|---|---|---|
| `select` | An optional comma-separated list of `msdynci_*` columns to restrict the profile projection. Omit it for the full profile. | No |

## Response and UI behavior

This tool returns a text response.

This MCP tool is not backed by an app-in-chat component.

### Response type

Consolidated Customer 360 summary.

The response includes the core profile, segments, measures, clusters, predictions, and the source records with field-level provenance.

## Routing notes

Use `get_customer_details` for:

- A request for the full picture of a known customer, or for why the profile shows a particular value.

Don't use `get_customer_details` when:

- The prompt hasn't identified a customer yet—resolve first with `find_customer`, `get_customer_by_contact`, or `get_customer_by_source_id`.
- The user only wants one area—route to `get_customer_segments`, `get_customer_measures`, `get_customer_predictions`, or `get_cluster_information`.

## Related tools

| Tool | Relationship |
|---|---|
| [`find_customer`](find_customer.md) | Resolves the customer ID this tool needs |
| [`get_customer_segments`](get_customer_segments.md) | Returns just the customer's segments |
| [`get_customer_measures`](get_customer_measures.md) | Returns just the customer's measures |
| [`get_customer_predictions`](get_customer_predictions.md) | Returns just the customer's predictions |
| [`get_cluster_information`](get_cluster_information.md) | Returns just the customer's cluster or household |

## Data mutation classification

Read-only.

This tool only reads profile and related Customer Insights data and never changes data.
