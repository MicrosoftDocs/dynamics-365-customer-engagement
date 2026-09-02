---
title: Convert Quote To Order
description: Learn how to use the Convert Quote To Order capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Convert Quote To Order

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability after a customer accepts a quote and the seller wants to create the sales order.

## What it does

The assistant converts an accepted Dynamics 365 Sales quote to a sales order with the ConvertQuoteToSalesOrder message. If the quote is still active, provide close metadata so Dataverse can win the quote before creating the order.

## Try prompts like

- Convert this accepted quote to an order
- Create an order from this quote with today's close date
- Turn this won quote into a sales order

## What you'll see in chat

The assistant displays a text response confirming that the quote was converted to an order. There is no interactive app-in-chat component for this capability.

## Helpful tips

- Confirm the customer accepted the quote before converting it.
- Provide `closeDate` when the quote is still active so Dataverse can close the quote as won before creating the order.
- Omit close metadata when the quote is already won.

## What happens next

- Open the created sales order
- Review the related opportunity or account
- Prepare fulfillment or handoff steps

## Does this change data?

**Yes, this can change data.**

## Prerequisites

This tool requires the Dataverse privileges documented for ConvertQuoteToSalesOrder, including read access to the quote and order, append access across quote, order, contact, and product records, create access for the order, and read access to attribute/entity maps in the selected Dynamics 365 environment.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Convert Quote To Order |
| Internal tool name | `convert_quote_to_order` |
| Purpose | Convert an accepted quote to a sales order. |

## Tool behavior

The tool invokes ConvertQuoteToSalesOrder. For an active quote, Dataverse can win the quote using the supplied close metadata, then create the sales order, copy quote line items, and trigger pricing calculations. It doesn't close lost or canceled quotes.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | Conversion creates an order and updates lifecycle state; records aren't deleted. |
| `idempotentHint` | `false` | Converting the same quote again can create duplicate work or fail depending on state. |
| `openWorldHint` | Not set | Uses default behavior. |

## Input concepts

### Quote and close metadata

| Input | Description | Required |
|---|---|---|
| `quoteId` | Dataverse GUID of the accepted quote to convert. | Yes |
| `closeDate` | Optional quote close date as an ISO 8601 string. Required by Dataverse when the quote is still active; omit for an already-won quote. | No |
| `description` | Optional quote close note used if Dataverse must win the active quote before creating the order. | No |
| `subject` | Optional quote close subject. Defaults to `Quote won` when close metadata is supplied. | No |
| `statusCode` | Optional quote close status reason override. Defaults to Won (4). | No |

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered.

## Routing notes

Use `convert_quote_to_order` when the customer accepted the quote and an order should be created. Use `close_quote` for quotes that were lost, canceled, or revised.

## Related tools

| Tool | Relationship |
|---|---|
| [`close_quote`](close_quote.md) | Closes a quote that wasn't accepted. |
| [`close_opportunity`](close_opportunity.md) | Closes the related opportunity as won or lost. |
| [`get_entity_record`](get_entity_record.md) | Reviews the quote or order record. |

## Data mutation classification

Write / mutation.

The tool changes Dataverse data when it wins an active quote as needed, creates the sales order, and creates order product rows from quote line items.
