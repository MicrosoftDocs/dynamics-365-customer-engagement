---
title: Clone Opportunity
description: Learn how to use the Clone Opportunity capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ladirohit
ms.author: ladirohit
ms.reviewer: tmanchanda
---

# Clone Opportunity

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller wants to start a new deal from an existing opportunity instead of entering everything from scratch.

## What it does

The assistant clones an existing Dynamics 365 Sales opportunity into a new opportunity, copying its fields, product line items, and stakeholders. The new opportunity starts in the **Open** state, owned by the current user. The price list, discounts, actual revenue, and close data aren't carried over, so the seller can set fresh pricing and targets. You provide the source opportunity's GUID and, optionally, a name for the copy.

## Try prompts like

- Clone this opportunity
- Make a copy of the Contoso renewal deal
- Duplicate this opportunity and call it "FY27 Renewal"
- Copy this deal so I can rework it for a second business unit

## What you'll see in chat

The assistant displays a text response confirming that the opportunity was cloned, including the new opportunity's name. There is no interactive app-in-chat component for this capability.

## Helpful tips

- Cloning is best when the new deal closely resembles an existing one — the product lines and stakeholders come along automatically.
- Supply `name` to title the copy yourself; otherwise it's named "Copy of {source name}".
- Set a price list and refresh estimated values on the clone before working it, since pricing and actuals aren't carried over.

## What happens next

- Summarize the new opportunity
- Add or update products on the clone
- Advance the new opportunity's stage

## Does this change data?

**Yes, this creates a new record.**

## Prerequisites

This tool requires permission to read the source opportunity and to create opportunities in the selected Dynamics 365 environment. Copying the source's product lines and stakeholders is governed by your Dynamics 365 permissions on those records.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Clone Opportunity |
| Internal tool name | `clone_opportunity` |
| Purpose | Duplicate an opportunity, including its products and stakeholders, into a new open opportunity. |

## Tool behavior

The tool creates a new opportunity and copies the source opportunity's fields, product line items, and stakeholders onto it through the platform's Copy Opportunity operation. The clone is set to the Open state and owned by the current user; the business process flow stage, actual revenue, actual close date, price list, and discounts are intentionally not copied. It doesn't modify the source opportunity, and it doesn't create quotes, orders, or follow-up activities.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `false` | This tool creates data. |
| `destructiveHint` | `false` | Cloning creates a new record; the source isn't changed or deleted. |
| `idempotentHint` | `false` | Each call creates a new opportunity, so it isn't a repeatable no-op. |
| `openWorldHint` | Not set | Uses default behavior. |

## Input concepts

### Source and name

| Input | Description | Required |
|---|---|---|
| `opportunityId` | Dataverse GUID of the source opportunity to clone. | Yes |
| `name` | Optional name for the new opportunity. Defaults to "Copy of {source opportunity name}". | No |

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered.

## Routing notes

Use `clone_opportunity` when the user wants to duplicate an existing opportunity — including its products and stakeholders — into a new deal. Don't use `clone_opportunity` to create a net-new opportunity from scratch (use `create_entity_record`), to summarize a deal (use `get_opportunity_summary`), or to reopen a closed deal (use `reopen_opportunity`).

## Related tools

| Tool | Relationship |
|---|---|
| [`create_entity_record`](create_entity_record.md) | Creates a net-new opportunity from scratch. |
| [`get_opportunity_summary`](get_opportunity_summary.md) | Reviews the source deal before cloning. |
| [`close_opportunity`](close_opportunity.md) | Closes an opportunity as won or lost. |

## Data mutation classification

Write / mutation.

The tool changes Dataverse data when it creates the new opportunity and copies the product lines and stakeholders onto it. It creates a new record on each call, so it isn't marked idempotent, and it leaves the source opportunity unchanged.
