---
title: Create competitor
description: Learn how to create a Dynamics 365 Sales competitor record.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# Create competitor

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when the seller names a competitor that isn't in the catalog yet.

## What it does
The assistant creates a new competitor record in Dynamics 365 Sales. Only the name is required; overview, strengths, weaknesses, key product, and website are optional.

## Try prompts like
- Create a competitor called Contoso.
- Add a new competitor Northwind Traders with a note about their strengths.

## What you'll see in chat
The assistant displays a text response directly in chat. There is no interactive app-in-chat component.

## Helpful tips
- Search first with `search_entities` (entity `competitor`) to avoid creating a duplicate.
- The returned `competitorId` can be passed to `link_competitor_to_opportunity`.

## What happens next
After creating the competitor, use [`link_competitor_to_opportunity`](link_competitor_to_opportunity.md) to attach it to a deal.

## Does this change data?
**Yes.** This tool creates a competitor record.

## Prerequisites
This tool requires create access to Dynamics 365 Sales competitor records.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Create Competitor |
| Internal tool name | `create_competitor` |
| Purpose | Create a competitor record. |

## Tool behavior
The tool creates a competitor and returns its new `competitorId`.

## Annotations
| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `false` | This tool changes data. |
| `destructiveHint` | `false` | It creates a record; it does not delete data. |
| `idempotentHint` | `false` | Repeating the call can create another competitor. |

## Input concepts
| Input | Description | Required |
|---|---|---|
| `name` | Competitor company or business name. | Yes |
| `overview` | Business overview or notes. | No |
| `strengths` | Competitor strengths. | No |
| `weaknesses` | Competitor weaknesses. | No |
| `keyProduct` | Competitor's primary product or service. | No |
| `websiteUrl` | Competitor website URL. | No |

## Related tools
| Tool | Relationship |
|---|---|
| [`search_entities`](search_entities.md) | Finds existing competitors before creating (entity `competitor`, relevance-ranked). |
| [`link_competitor_to_opportunity`](link_competitor_to_opportunity.md) | Attaches the new competitor to a deal. |

## Routing notes
Use `create_competitor` only after `search_entities` (entity `competitor`) finds no match and the seller confirms creation.

## Response and UI behavior
This tool returns a text-only response with structured content and no app-in-chat component.

## Data mutation classification
Creates a competitor record.
