---
title: Create quote from opportunity
description: Learn how to generate a draft Dynamics 365 Sales quote from an opportunity.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Create quote from opportunity

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller is ready to turn an opportunity into quote paperwork.

## What it does

The assistant generates a new draft Dynamics 365 Sales quote from an opportunity, copying its products, price list, customer, and currency into the new quote.

## Try prompts like

- Create a quote from this opportunity.
- Generate a draft quote for the Northpeak Manufacturing opportunity.
- Turn this opportunity into a quote so I can prepare paperwork.

## What you'll see in chat

The assistant displays a text response directly in chat. There is no interactive app-in-chat component.

## Helpful tips

- Make sure the opportunity's products and pricing are ready before generating the quote.
- Each call creates a new draft quote; call it once per opportunity unless you intend to create multiple quotes.

## What happens next

After the draft quote is generated, review it, adjust products or pricing if needed, then activate it with `set_quote_active` when it's ready for the customer.

## Does this change data?

**Yes.** This tool creates a new quote record.

## Prerequisites

This tool requires read access to the opportunity and create/read access to quotes.

## Tool summary

| Property           | Value                                       |
| ------------------ | ------------------------------------------- |
| User-facing name   | Create Quote from Opportunity                |
| Internal tool name | `create_quote_from_opportunity`              |
| Purpose            | Generate a draft quote from an opportunity. |

## Tool behavior

The tool runs the Dynamics 365 quote-generation action for the opportunity and returns the created draft quote summary.

## Annotations

| Annotation        | Value   | Meaning                                      |
| ----------------- | ------- | -------------------------------------------- |
| `readOnlyHint`    | `false` | This tool changes data.                      |
| `destructiveHint` | `false` | It creates a quote; it does not delete data. |
| `idempotentHint`  | `false` | Each call creates a new quote.               |

## Input concepts

| Input           | Description                | Required |
| --------------- | -------------------------- | -------- |
| `opportunityId` | Resolved opportunity GUID. | Yes      |

## Related tools

| Tool                                      | Relationship                                    |
| ----------------------------------------- | ----------------------------------------------- |
| [`set_quote_active`](set_quote_active.md) | Activates the draft quote once it's ready.      |
| [`add_opportunity_product`](add_opportunity_product.md) | Adds opportunity product lines before generating the quote. |
| [`get_price_list`](get_price_list.md)     | Reviews the price list applied to the quote.    |

## Routing notes

Use `create_quote_from_opportunity` only to generate a new draft quote from an opportunity. Use `set_quote_active` to activate an existing draft quote.

## Response and UI behavior

This tool returns a text-only response with structured content and no app-in-chat component.

## Data mutation classification

Creates a new draft quote record from an opportunity.
