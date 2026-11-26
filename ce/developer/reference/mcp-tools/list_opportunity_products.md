---
title: List opportunity products
description: Learn how to list the product lines on a Dynamics 365 Sales opportunity.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# List opportunity products

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when the seller wants to see what products are on a deal, or before changing a product line.

## What it does
The assistant lists the product lines (`opportunityproduct` rows) on a Dynamics 365 Sales opportunity, each with its `opportunityProductId`, product, quantity, unit price, discount, and extended amount.

## Try prompts like
- What products are on this opportunity?
- Show the line items on the Northpeak deal.
- List the products before I change the quantity.

## What you'll see in chat
The assistant displays a text response directly in chat. There is no interactive app-in-chat component.

## Helpful tips
- Use the returned `opportunityProductId` with `update_opportunity_products` to change a specific line.

## What happens next
After listing lines, use `update_opportunity_products` to change a line by its `opportunityProductId`, or `add_opportunity_product` to add a new line.

## Does this change data?
**No.** This tool is read-only.

## Prerequisites
This tool requires read access to Dynamics 365 Sales opportunities and opportunity product lines.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | List Opportunity Products |
| Internal tool name | `list_opportunity_products` |
| Purpose | List an opportunity's product lines. |

## Tool behavior
The tool returns bounded opportunity product-line summaries for the given opportunity, up to a maximum of 50 lines per call.

## Annotations
| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | This tool does not modify data. |

## Input concepts
| Input | Description | Required |
|---|---|---|
| `opportunityId` | Resolved opportunity GUID. | Yes |

## Related tools
| Tool | Relationship |
|---|---|
| [`add_opportunity_product`](add_opportunity_product.md) | Adds a new product line. |
| [`update_opportunity_products`](update_opportunity_products.md) | Updates a line by its `opportunityProductId`. |
| [`recalculate_opportunity_price`](recalculate_opportunity_price.md) | Refreshes opportunity totals. |

## Routing notes
Use `list_opportunity_products` to read a deal's product lines and obtain an `opportunityProductId`. Use `update_opportunity_products` to change a line, `add_opportunity_product` to add one.

## Response and UI behavior
This tool returns a text-only response with structured content and no app-in-chat component.

## Data mutation classification
Read-only.
