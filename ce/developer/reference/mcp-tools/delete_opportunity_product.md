---
title: Delete Opportunity Product
description: Learn how to remove a product line from a Dynamics 365 Sales opportunity.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Delete Opportunity Product

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when the seller confirms a product line should be removed from a deal.

## What it does
The assistant removes a product line (`opportunityproduct` row) from a Dynamics 365 Sales opportunity and refreshes the opportunity totals.

## Try prompts like
- Remove this product line from the opportunity.
- Delete the Microsoft 365 E5 line from the deal.

## What you'll see in chat
The assistant displays a text response directly in chat. There is no interactive app-in-chat component.

## Helpful tips
- Resolve the `opportunityProductId` first with `list_opportunity_products`.
- Confirm with the seller before removing a line — this cannot be undone from chat.

## What happens next
The opportunity totals are refreshed automatically. Use `list_opportunity_products` to review the remaining lines.

## Does this change data?
**Yes.** This tool deletes an opportunity product line.

## Prerequisites
This tool requires delete access to opportunity product lines and write access to the opportunity.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Delete Opportunity Product |
| Internal tool name | `delete_opportunity_product` |
| Purpose | Remove a product line from an opportunity. |

## Tool behavior
The tool deletes the specified opportunity product line and returns the refreshed opportunity totals.

## Annotations
| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `false` | This tool changes data. |
| `destructiveHint` | `true` | It deletes a product line. |
| `idempotentHint` | `false` | A repeat delete of an already-removed line fails, because the line can no longer be resolved. |

## Input concepts
| Input | Description | Required |
|---|---|---|
| `opportunityProductId` | The opportunity product line GUID to remove. | Yes |

## Related tools
| Tool | Relationship |
|---|---|
| [`list_opportunity_products`](list_opportunity_products.md) | Resolves the `opportunityProductId` to remove. |
| [`add_opportunity_product`](add_opportunity_product.md) | Adds a product line. |
| [`update_opportunity_products`](update_opportunity_products.md) | Updates a line instead of removing it. |

## Routing notes
Use `delete_opportunity_product` only to remove a line. Use `update_opportunity_products` to change a line, `add_opportunity_product` to add one.

## Response and UI behavior
This tool returns a text-only response with structured content and no app-in-chat component.

## Data mutation classification
Deletes an opportunity product line.
