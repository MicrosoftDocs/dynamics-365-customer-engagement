---
title: Close Quote
description: Learn how to use the Close Quote capability in Dynamics 365 Sales.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Close Quote

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a customer doesn't accept a quote and the seller wants to close it as lost, canceled, or revised.

## What it does

The assistant closes a Dynamics 365 Sales quote with the CloseQuote message. It records the quote close outcome, close date, and optional notes on the quote close activity. You provide the quote GUID and the outcome.

## Try prompts like

- Close this quote as lost
- Mark this quote as canceled with today's date
- Close this quote as revised and note that we need a new version

## What you'll see in chat

The assistant displays a text response confirming the quote close outcome. There is no interactive app-in-chat component for this capability.

## Helpful tips

- Confirm the quote shouldn't be converted to an order before closing it.
- Use `revised` when the seller needs a new quote version.
- Use `lost` or `canceled` only after the seller confirms that the current quote won't proceed.

## What happens next

- Convert an accepted quote to an order
- Create a revised quote when the seller needs a new version
- Review the related opportunity or account

## Does this change data?

**Yes, this can change data.**

## Prerequisites

This tool requires permission to write the quote and to create the quote close activity in the selected Dynamics 365 environment.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Close Quote |
| Internal tool name | `close_quote` |
| Purpose | Close a quote as lost, canceled, or revised. |

## Tool behavior

The tool invokes CloseQuote, creating the quote close activity with the supplied close date and note, and setting the quote's closed status reason. It doesn't create orders or revised quote records.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | Closing is a state transition; the record isn't deleted. |
| `idempotentHint` | `false` | Closing an already-closed quote isn't a repeatable no-op. |
| `openWorldHint` | Not set | Uses default behavior. |

## Input concepts

### Quote and outcome

| Input | Description | Required |
|---|---|---|
| `quoteId` | Dataverse GUID of the quote to close. | Yes |
| `status` | Close outcome: `lost`, `canceled`, or `revised`. | Yes |
| `closeDate` | Optional close date as an ISO 8601 string. Defaults to now. | No |
| `description` | Optional closure note recorded on the quote close activity. | No |
| `statusCode` | Optional status reason override; must be a valid CloseQuote reason (5 = Lost, 6 = Canceled, 7 = Revised). Defaults by outcome: lost = 5, canceled = 6, revised = 7. | No |

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered.

## Routing notes

Use `close_quote` for non-accepted quotes. Don't use `close_quote` for an accepted quote that should become an order; use `convert_quote_to_order` instead.

## Related tools

| Tool | Relationship |
|---|---|
| [`convert_quote_to_order`](convert_quote_to_order.md) | Converts an accepted quote to a sales order. |
| [`close_opportunity`](close_opportunity.md) | Closes the related opportunity as won or lost. |
| [`get_entity_record`](get_entity_record.md) | Reviews the quote record before closing. |

## Data mutation classification

Write / mutation.

The tool changes Dataverse data when it closes the quote and creates the quote close activity.
