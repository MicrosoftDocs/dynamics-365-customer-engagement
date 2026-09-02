---
title: Update opportunity products
description: Learn how to update Dynamics 365 Sales opportunity product lines.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Update opportunity products

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller confirms changes to existing opportunity product lines.

## What it does

The assistant updates one or more opportunity product lines (`opportunityproduct` rows) — such as quantity, unit, product, unit price, discount, or line description — and then refreshes and returns the opportunity totals in the same response.

## Try prompts like

- Change the Microsoft 365 E5 line to 250 users.
- Update this opportunity product line with a manual discount.
- Change the product line description.

## What you'll see in chat

The assistant displays a text response directly in chat. The assistant doesn't display an interactive app-in-chat component.

## Helpful tips

- Confirm the exact product line before updating it.
- Use `opportunityId` to verify updates are scoped to the intended opportunity.

## What happens next

The opportunity totals are refreshed automatically and returned with the response — no separate `recalculate_opportunity_price` call is required.

## Does this change data?

**Yes.** This tool updates opportunity product lines and refreshes the opportunity totals.

## Prerequisites

This tool requires read/write access to opportunity product lines and read/write access to the opportunity.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Update opportunity products |
| Internal tool name | `update_opportunity_products` |
| Purpose | Update opportunity product lines and refresh totals. |

## Tool behavior

The tool patches existing opportunity product lines, recalculates the opportunity price, and returns the refreshed line summaries and opportunity totals.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `false` | This tool changes data. |
| `destructiveHint` | `false` | It updates lines; it doesn't delete data. |
| `idempotentHint` | `true` | Repeating the same update leaves the same values. |

## Input concepts

| Input | Description | Required |
|---|---|---|
| `opportunityId` | Optional opportunity GUID to verify line ownership and target the totals refresh. | No |
| `updates` | Array of product-line updates keyed by `opportunityProductId`. | Yes |

## Related tools

| Tool | Relationship |
|---|---|
| [`add_opportunity_product`](add_opportunity_product.md) | Adds a new product line. |
| [`recalculate_opportunity_price`](recalculate_opportunity_price.md) | Standalone totals refresh (folded into this tool automatically). |

## Routing notes

Use `update_opportunity_products` for existing opportunity product lines. Use `add_opportunity_product` to create a new line.

## Response and UI behavior

This tool returns a text-only response with structured content and no app-in-chat component.

## Data mutation classification

Updates existing opportunity product lines and refreshes opportunity totals.
