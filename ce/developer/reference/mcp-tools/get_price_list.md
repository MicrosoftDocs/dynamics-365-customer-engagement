---
title: Get price list
description: Learn how to view Dynamics 365 Sales price lists.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Get price list

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs details or product prices from a price list.

## What it does

The assistant reads a price list by GUID or unambiguous name and can include product price rows from that price list. When you resolve a price list by name, the assistant returns the list valid on a given date (today by default).

## Try prompts like

- Show me the Microsoft Eval Price List.
- Which products are on this price list?
- Get price list details before adding a product.
- Show the Microsoft Eval Price List valid on July 1, 2026.

## What you'll see in chat

The assistant displays a text response directly in chat. The assistant doesn't display an interactive app-in-chat component.

## Helpful tips

- Use `priceListId` when available; name resolution requires an unambiguous match.
- Limit returned products with `top` when the price list is large.
- By default, name lookups return the price list valid today. Pass `asOfDate` (for example, `2026-07-01`) to select the list valid on a specific date. `asOfDate` is ignored when you provide `priceListId`.

## What happens next

After price list details appear, use `get_product_pricing` for a product's price rows, or product-line tools as needed.

## Does this change data?

**No.** This tool is read-only.

## Prerequisites

This tool requires read access to price lists. Returning product price rows (`includeProducts` is true by default) additionally requires access to product price-list records, which Dataverse enforces at call time.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Get price list |
| Internal tool name | `get_price_list` |
| Purpose | Read price list details and product prices. |

## Tool behavior

The tool resolves one price list and optionally returns bounded product price rows.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | This tool doesn't modify data. |

## Input concepts

| Input | Description | Required |
|---|---|---|
| `priceListId` | Resolved price list GUID. | No |
| `priceListName` | Name to resolve when the GUID is not known. | No |
| `includeProducts` | Include product price rows. | No |
| `top` | Maximum product price rows to return. | No |

## Related tools

| Tool | Relationship |
|---|---|
| [`add_opportunity_product`](add_opportunity_product.md) | Adds products after pricing is confirmed. |

## Routing notes

Use `get_price_list` for price-list-level details. Use `get_product_pricing` for one product's price rows.

## Response and UI behavior

This tool returns a text-only response with structured content and no app-in-chat component.

## Data mutation classification

Read-only.
