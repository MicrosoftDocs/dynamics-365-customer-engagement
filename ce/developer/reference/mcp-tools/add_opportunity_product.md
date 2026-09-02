---
title: Add opportunity product
description: Learn how to add product lines to a Dynamics 365 Sales opportunity.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Add opportunity product

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller has confirmed the opportunity, product, and quantity to add.

## What it does

The assistant creates an opportunity product line (an `opportunityproduct` row) in Dynamics 365 Sales — a line item on the deal, not a catalog product. It can use the product default unit and lets Dataverse price the line unless the seller explicitly provides a unit-price override.

## Try prompts like

- Add 200 Microsoft 365 Copilot seats to this opportunity.
- Add the selected product to the Northpeak E5 Rollout opportunity.
- Add this product with a price override of 360.

## What you'll see in chat

The assistant displays a text response directly in chat. The assistant doesn't display an interactive app-in-chat component.

## Helpful tips

- Confirm the product, opportunity, and quantity before calling this tool.
- Omit price overrides unless the seller explicitly provides them.
- If the product line is created but an optional description update can't be confirmed, review or update the returned line. Don't repeat the add because that can create a duplicate line.
- If Dynamics 365 rejects the description update, review permissions or required fields and update the returned line. Don't repeat the add.
- If line creation itself can't be confirmed, check the returned client-assigned line before taking any action. Don't repeat the add.
- If the line is created but its final details can't be read back, check the returned line before taking any action. Don't repeat the add.

## What happens next

After adding a line, use `recalculate_opportunity_price` when updated opportunity totals are needed.

## Does this change data?

**Yes.** This tool creates an opportunity product line.

## Prerequisites

This tool requires write access to opportunity product lines plus read access to the opportunity and product.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Add opportunity product |
| Internal tool name | `add_opportunity_product` |
| Purpose | Add a product line to an opportunity. |

## Tool behavior

The tool creates an opportunity product line and returns the created line summary. `creationStatus` reports `created` or `unconfirmed`; an unconfirmed create returns the client-assigned line id for reconciliation and must not be repeated blindly. `readbackStatus` reports whether final server details were confirmed. For an optional description, `descriptionStatus` reports `applied`, `rejected`, or `unconfirmed`. A rejected or unconfirmed update returns the line as a partial result instead of deleting it or claiming complete success. Review or update that returned line; don't repeat the add.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `false` | This tool changes data. |
| `destructiveHint` | `false` | It adds a line; it doesn't delete data. |
| `idempotentHint` | `false` | Repeating the call can create another line. |

## Input concepts

| Input | Description | Required |
|---|---|---|
| `opportunityId` | Resolved opportunity GUID. | Yes |
| `productId` | Resolved product GUID. | Yes |
| `quantity` | Quantity to add. | No |
| `unitId` | Unit GUID; omit to use the product default unit. | No |
| `pricePerUnit` | Unit price override. | No |
| `manualDiscountAmount` | Manual discount amount. | No |
| `description` | Optional line description. | No |

## Related tools

| Tool | Relationship |
|---|---|
| [`get_product`](get_product.md) | Finds products to add. |
| [`recalculate_opportunity_price`](recalculate_opportunity_price.md) | Refreshes totals after adding a line. |

## Routing notes

Use `add_opportunity_product` only for confirmed product-line creation. Use `update_opportunity_products` for existing lines.

## Response and UI behavior

This tool returns a text-only response with structured content and no app-in-chat component.

## Data mutation classification

Creates an opportunity product line.
