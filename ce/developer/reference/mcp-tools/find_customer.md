---
title: Find customer
description: Learn how to use the Find customer capability in Dynamics 365 Customer Insights.
ms.date: 09/02/2026
ms.topic: reference
ms.service: dynamics-365-customer-insights
ms.custom: mcp-enabled-namespaces=customer-insights
author: Scott-Stabbert
ms.author: demazuro
ms.reviewer: demazuro
---

# Find customer

**Applies to:** Dynamics 365 Customer Insights

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to find a customer's unified Customer Insights profile by name directly in chat.

## What it does

The assistant searches your Customer Insights unified profiles by first or last name and returns the matching customers, each with a unified customer ID plus name and email. Use it as the first step when someone names a person and you need their customer ID before pulling details, segments, measures, or predictions.

When a multi-word name doesn't match any single field, the assistant automatically matches every word across the name fields and tells you that this broader match ran, so you know the results are best-effort rather than exact.

## Try prompts like

- Find the customer profile for Maria Garcia.
- Look up the unified Customer Insights profile for a shopper named Jane Doe.
- Search Customer Insights for a customer named Alex Wilber.
- Who is the unified customer for the name Nguyen?
- Find customers with the last name Garcia.
- List the Customer Insights profiles.

## What you'll see in chat

The assistant replies with a short text list of the customers that matched your search. Each entry shows the customer's name and the unified customer ID you can use in follow-up requests. If the broader word-by-word match ran, the assistant notes that alongside the results. If nothing matched, the assistant tells you no unified profile was found.

## Helpful tips

- Give a first name, a last name, or both. More of the name usually narrows the results.
- If you don't provide a name, the assistant pages through the full profile list.
- If too many customers match, add more of the name and search again.
- Once you have the right customer, continue with "show everything about this customer" to get the full Customer 360.

> [!TIP]
> After you find the right customer, ask a follow-up like "what segments is this customer in?" or "what's this customer's churn risk?" to keep working with the same profile.

## What happens next

After the matching customers appear, you can continue with prompts like:

- Show me everything Customer Insights knows about this customer.
- Which segments is this customer in?
- What's this customer's total purchases and average order value?
- What's this customer's churn risk?

## Does this change data?

**No, finding a customer doesn't change data.**

This capability only reads unified profiles from Customer Insights. It never creates, updates, or deletes records.

## Prerequisites

This tool is available on the Dynamics 365 Customer Insights MCP server. See the availability note at the top of this page for details. Customer Insights must be configured for your environment, and you need permission to read unified customer profiles.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Find Customer |
| Internal tool name | `find_customer` |
| Purpose | Searches Customer Insights unified profiles by name and returns matching customer IDs with name and email |

## Tool behavior

Searches Customer Insights unified profiles (`msdynci_customerprofile`) by first or last name and returns each matching customer's unified customer ID plus name and email. A multi-word name that matches no single field falls back to matching every word across the name fields, and a search note flags when that fallback ran. Omit the name to page the full profile list. Returns at most `top` rows (default 10, maximum 200) with a `hasMore` flag for paging through `skip`.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | Read-only; this tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Customer Insights through Dataverse). |

## Input concepts

### Search term

| Input | Description | Required |
|---|---|---|
| `searchName` | A name fragment matched against the first or last name (contains match). Omit it to list all profiles. Maximum 256 characters. | No |

### Paging

| Input | Description | Required |
|---|---|---|
| `top` | Maximum number of rows to return. Default 10, maximum 200. | No |
| `skip` | Number of rows to skip for paging. Default 0. | No |

### Projection

| Input | Description | Required |
|---|---|---|
| `select` | An optional comma-separated list of `msdynci_*` columns to override the default profile projection. | No |

## Response and UI behavior

This tool returns a text response.

This MCP tool is not backed by an app-in-chat component.

### Response type

Text list of matched customers.

The response lists each matched customer with a unified customer ID, name, and email, plus a `hasMore` flag when more rows are available and a search note when the broader word-by-word match ran.

## Routing notes

Use `find_customer` for:

- Find the customer profile for a named person, look up a customer by name, or search Customer Insights for a shopper.
- Any prompt that names a person and needs their Customer Insights customer ID.

Don't use `find_customer` when the prompt provides:

- **A source-system record ID** (for example a loyalty or ERP record)—route to `get_customer_by_source_id`.
- **A Dataverse contact**—route to `get_customer_by_contact`.
- **An already-identified customer and a request for their full profile**—route to `get_customer_details`.

## Related tools

| Tool | Relationship |
|---|---|
| [`get_customer_by_source_id`](get_customer_by_source_id.md) | Resolves a unified customer from a source-system record ID |
| [`get_customer_by_contact`](get_customer_by_contact.md) | Resolves a unified customer from a Dataverse contact |
| [`get_customer_details`](get_customer_details.md) | Returns the full Customer 360 for a resolved customer |
| [`get_customer_segments`](get_customer_segments.md) | Lists the segments a resolved customer belongs to |
| [`get_customer_measures`](get_customer_measures.md) | Returns a resolved customer's measures and KPIs |

## Data mutation classification

Read-only.

This tool only reads unified profiles from Customer Insights and never changes data.
