---
title: Get product
description: Learn how to view Dynamics 365 Sales product catalog details.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Get product

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs to read a product's catalog details.

## What it does

The assistant reads a product record's catalog details — name, product number, description, and default unit — for a product you identify by `productId`. To find a product from a name, SKU, or natural-language description, use [`search_entities`](search_entities.md) with the `product` entity. For a product's price-list rows and unit price, use [`get_product_pricing`](get_product_pricing.md).

## Try prompts like

- Show details for Microsoft 365 E5.
- Find the product number for Microsoft 365 E5.
- What unit is this product sold in?

## What you'll see in chat

The assistant displays a text response directly in chat. The assistant doesn't display an interactive app-in-chat component.

## Helpful tips

- When the seller names a product in natural language, the assistant first resolves it with [`search_entities`](search_entities.md), which uses relevance-ranked search and returns each match's id.
- That id is passed to this tool to read the product's catalog details.
- For what a product costs in a price list, use [`get_product_pricing`](get_product_pricing.md).

## What happens next

After details appear, use `add_opportunity_product` to add the product to an opportunity.

## Does this change data?

**No.** This tool is read-only.

## Prerequisites

This tool requires access to Dynamics 365 Sales product records.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Get product |
| Internal tool name | `get_product` |
| Purpose | Read a product's catalog details. |

## Tool behavior

The tool reads one product record's catalog details by `productId`. Catalog discovery by text is handled by `search_entities`.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | This tool doesn't modify data. |

## Input concepts

| Input | Description | Required |
|---|---|---|
| `productId` | Resolved product GUID. | Yes |

## Related tools

| Tool | Relationship |
|---|---|
| [`search_entities`](search_entities.md) | Finds a product by name, SKU, or keyword and returns its id. |
| [`get_product_pricing`](get_product_pricing.md) | Reads a product's price-list rows and unit price. |
| [`add_opportunity_product`](add_opportunity_product.md) | Adds a resolved product to an opportunity. |
| [`get_price_list`](get_price_list.md) | Reads a price list and the products on it. |

## Routing notes

Use `get_product` to read catalog details for a product the seller has already identified. Use `search_entities` with the `product` entity to find a product from a name, description, or keyword. Use `get_product_pricing` for a named product's price-list rows and unit price. Use `get_price_list` when the seller asks for the contents of a named price list rather than for one product.

## Response and UI behavior

This tool returns a text-only response with structured content and no app-in-chat component.

## Data mutation classification

Read-only.
