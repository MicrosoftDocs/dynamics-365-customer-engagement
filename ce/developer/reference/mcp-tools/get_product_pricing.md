---
title: Get product pricing
description: Learn how to read Dynamics 365 Sales product price-list rows.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Get product pricing

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs to know what a specific product costs across price lists.

## What it does
The assistant reads the price-list rows (`productpricelevel` records) for one product — the unit price or pricing method, the price list, unit, currency, and commercial terms. Pass `productId`, and optionally `priceListId` to scope the rows to a single price list.

## Try prompts like
- What does Microsoft 365 E5 cost?
- Show the pricing for this product on the Microsoft Eval Price List.
- What's the unit price for this product?

## What you'll see in chat
The assistant displays a text response directly in chat. There is no interactive app-in-chat component.

## Helpful tips
- Resolve the product first with `search_entities` (entity `product`) to obtain its `productId`.
- Pass `priceListId` only after the price list is resolved, to scope the rows to one list.

## What happens next
After pricing appears, use `add_opportunity_product` to add the product to an opportunity.

## Does this change data?
**No.** This tool is read-only.

## Prerequisites
This tool requires read access to Dynamics 365 Sales price-list items.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Get Product Pricing |
| Internal tool name | `get_product_pricing` |
| Purpose | Read a product's price-list rows. |

## Tool behavior
The tool returns bounded product price-list rows for the given product, optionally filtered to one price list.

## Annotations
| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | This tool does not modify data. |

## Input concepts
| Input | Description | Required |
|---|---|---|
| `productId` | Resolved product GUID whose pricing you want. | Yes |
| `priceListId` | Optional price list GUID to scope the pricing rows. | No |
| `top` | Maximum pricing rows to return (default 20). Max 50. | No |

## Related tools
| Tool | Relationship |
|---|---|
| [`get_product`](get_product.md) | Reads one product's catalog details by `productId`. |
| [`get_price_list`](get_price_list.md) | Reads a whole price list and every product row on it. |
| [`add_opportunity_product`](add_opportunity_product.md) | Adds a resolved product to an opportunity. |

## Routing notes
Use `get_product_pricing` for a named product's price-list rows and unit price. Use `get_product` for catalog details (name, number, default unit). Use `get_price_list` for every product row in a named price list.

## Response and UI behavior
This tool returns a text-only response with structured content and no app-in-chat component.

## Data mutation classification
Read-only.
