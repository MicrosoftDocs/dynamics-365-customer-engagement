---
title: List Opportunity Competitors
description: Learn how to list the competitors linked to a Dynamics 365 Sales opportunity.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: ridarbar
ms.author: ridarbar
ms.reviewer: tmanchanda
---

# List Opportunity Competitors

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when the seller asks who they are competing against on a deal.

## What it does
The assistant lists up to 50 competitors linked to a Dynamics 365 Sales opportunity, with each competitor's name and SWOT notes. When the opportunity has more linked competitors, the response says that it is showing the first 50.

## Try prompts like
- Who are we competing against on this deal?
- List the competitors on the Northpeak opportunity.

## What you'll see in chat
The assistant displays a text response directly in chat. There is no interactive app-in-chat component.

## Helpful tips
- To add a competitor, use `link_competitor_to_opportunity` after resolving it with `search_entities` (entity `competitor`).

## What happens next
After reviewing the competitors, use [`link_competitor_to_opportunity`](link_competitor_to_opportunity.md) to add or remove one.

## Does this change data?
**No.** This tool is read-only.

## Prerequisites
This tool requires read access to Dynamics 365 Sales opportunities and competitor records.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | List Opportunity Competitors |
| Internal tool name | `list_opportunity_competitors` |
| Purpose | List a deal's linked competitors. |

## Tool behavior
The tool traverses the opportunity's competitor association and returns up to 50 linked competitor records. Its structured response sets `truncated` to `true` when the bounded page might not contain every linked competitor.

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
| [`link_competitor_to_opportunity`](link_competitor_to_opportunity.md) | Adds or removes a competitor on the deal. |
| [`search_entities`](search_entities.md) | Resolves a competitor by name (entity `competitor`, relevance-ranked). |

## Routing notes
Use `list_opportunity_competitors` to read a deal's competitors. Use `link_competitor_to_opportunity` to change them.

## Response and UI behavior
This tool returns a text-only response with structured content and no app-in-chat component.

## Data mutation classification
Read-only.
