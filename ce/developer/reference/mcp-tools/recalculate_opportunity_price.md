---
title: Recalculate opportunity price
description: Learn how to recalculate Dynamics 365 Sales opportunity pricing totals.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Recalculate opportunity price

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability after product-line changes when a seller needs refreshed opportunity totals.

## What it does

The assistant calls Dynamics 365 Sales price calculation for the opportunity and returns updated totals.

## Try prompts like

- Recalculate pricing for this opportunity.
- Refresh totals after adding the product.
- What's the new opportunity total?

## What you'll see in chat

The assistant displays a text response directly in chat. The assistant doesn't display an interactive app-in-chat component.

## Helpful tips

- Recalculate after adding or updating product lines when the seller asks for totals.
- This tool doesn't choose products or prices; it refreshes current opportunity totals.

## What happens next

Use the returned totals in the seller response or continue with product-line updates.

## Does this change data?

**Yes.** This tool updates calculated opportunity pricing totals.

## Prerequisites

This tool requires read/write access to the opportunity.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Recalculate opportunity price |
| Internal tool name | `recalculate_opportunity_price` |
| Purpose | Refresh opportunity pricing totals. |

## Tool behavior

The tool invokes Dynamics 365 Sales price calculation for the opportunity and returns updated totals.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `false` | This tool updates calculated data. |
| `destructiveHint` | `false` | It doesn't delete data. |
| `idempotentHint` | `true` | Repeating the call recalculates the same current lines. |

## Input concepts

| Input | Description | Required |
|---|---|---|
| `opportunityId` | Resolved opportunity GUID. | Yes |

## Related tools

| Tool | Relationship |
|---|---|
| [`add_opportunity_product`](add_opportunity_product.md) | Adds lines. Does not refresh totals itself, so call this tool afterwards when the seller wants updated numbers. |
| [`update_opportunity_products`](update_opportunity_products.md) | Updates lines and refreshes the opportunity totals automatically — a separate recalculation is not needed after it. |
| [`delete_opportunity_product`](delete_opportunity_product.md) | Removes a line and refreshes the opportunity totals automatically — a separate recalculation is not needed after it. |

## Routing notes

Use `recalculate_opportunity_price` only for opportunity pricing totals. Use `get_product` to inspect catalog pricing.

## Response and UI behavior

This tool returns a text-only response with structured content and no app-in-chat component.

## Data mutation classification

Updates calculated opportunity pricing totals.
