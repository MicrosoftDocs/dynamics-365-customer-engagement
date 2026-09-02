---
title: Set quote active
description: Learn how to activate a Dynamics 365 Sales quote.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Set quote active

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller confirms a draft quote is ready to send to the customer.

## What it does

The assistant activates a draft Dynamics 365 Sales quote. Activation moves the quote from draft to active and locks the quote amount from further pricing edits.

## Try prompts like

- Activate this quote.
- Set the Northpeak quote active so I can send it to the customer.
- Mark quote QUO-01001 as active.

## What you'll see in chat

The assistant displays a text response directly in chat. There is no interactive app-in-chat component.

## Helpful tips

- Activate only after quote details, products, and pricing are ready for the customer.
- To change pricing after activation, revise the quote instead of editing the active quote directly.

## What happens next

After activation, the quote is ready to send to the customer. To change pricing later, revise the quote instead of editing the active quote directly.

## Does this change data?

**Yes.** This tool changes a quote's state.

## Prerequisites

This tool requires read and write access to quotes.

## Tool summary

| Property           | Value                   |
| ------------------ | ----------------------- |
| User-facing name   | Set Quote Active        |
| Internal tool name | `set_quote_active`      |
| Purpose            | Activate a draft quote. |

## Tool behavior

The tool validates the quote is still in draft state, activates it, and returns the activated quote summary.

## Annotations

| Annotation        | Value   | Meaning                                    |
| ----------------- | ------- | ------------------------------------------ |
| `readOnlyHint`    | `false` | This tool changes data.                    |
| `destructiveHint` | `false` | It changes state; it does not delete data. |
| `idempotentHint`  | `true`  | The target end state is active.            |

## Input concepts

| Input     | Description                | Required |
| --------- | -------------------------- | -------- |
| `quoteId` | Resolved draft quote GUID. | Yes      |

## Related tools

| Tool                                                                | Relationship                                                    |
| ------------------------------------------------------------------- | --------------------------------------------------------------- |
| [`add_opportunity_product`](add_opportunity_product.md)             | Adds opportunity product lines before quote activation.         |
| [`update_opportunity_products`](update_opportunity_products.md)     | Updates opportunity product lines before quote activation.      |
| [`recalculate_opportunity_price`](recalculate_opportunity_price.md) | Refreshes opportunity pricing before quote creation/activation. |

## Routing notes

Use `set_quote_active` only for activating a draft quote. Do not use it to revise, close, or convert quotes to orders.

## Response and UI behavior

This tool returns a text-only response with structured content and no app-in-chat component.

## Data mutation classification

Changes the quote state from draft to active.
