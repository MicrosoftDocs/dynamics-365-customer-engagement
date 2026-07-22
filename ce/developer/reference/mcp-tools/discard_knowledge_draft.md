---
title: Discard a knowledge article draft
description: Learn how to use the Discard a knowledge article draft capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Discard a knowledge article draft

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]
- "Delete the draft knowledge article"
- "I do not want to keep this draft"

## What you'll see in chat
The assistant confirms that the draft was discarded, or reports that it was already gone.

## Helpful tips
- Use this only after confirming the user wants to discard the draft.
- Discarding removes the draft instead of publishing it.
- Already-discarded drafts return success without creating a new error.

## What happens next
- "Harvest a new draft if the source still needs an article"
- "Open another draft to review"
- "Ask for an existing article check before drafting again"

## Does this change data?
**Yes, discarding a draft deletes the draft knowledge article record.**

## Prerequisites
This tool requires the following:

- Knowledge management

Learn more in [Configure knowledge management](/dynamics365/customer-service/administer/set-up-knowledge-management-embedded-knowledge-search).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Discard Knowledge Article Draft |
| Internal tool name | `discard_knowledge_draft` |
| Purpose | Removes a draft Knowledge Article entirely so it never enters the knowledge base |

## Tool behavior
Removes a draft Knowledge Article entirely so it never enters the knowledge base. Use when the user confirms abandoning a draft in the harvest widget (Discard button + inline confirm) or explicitly asks to discard a draft.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `true` | This tool may remove or destroy data. |
| `idempotentHint` | `true` | Repeated calls with the same input produce the same result. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Article ID

| Input | Description | Required |
|---|---|---|
| `articleId` | `articleId` (GUID, required). The ID of the draft knowledge article to discard. | Yes |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns confirmation that the draft was discarded and removed from the knowledge base.

## Routing notes
Use `discard_knowledge_draft` when:

- The user confirms abandoning a draft via the harvest widget Discard button
- The user explicitly asks to 'discard', 'throw away', or 'delete' a draft article

Don't use `discard_knowledge_draft` when:

- The user wants to **save changes** - route to `save_knowledge_draft`
- The user wants to **publish** the article - route to `publish_knowledge_article`

## Related tools
| Tool | Relationship |
|---|---|
| [`harvest_knowledge_article`](harvest_knowledge_article.md) | Creates the draft that this tool discards |
| [`save_knowledge_draft`](save_knowledge_draft.md) | Saves edits to the draft instead of discarding |
| [`publish_knowledge_article`](publish_knowledge_article.md) | Publishes the draft instead of discarding |

## Data mutation classification
**Destructive write.** Permanently deletes the draft Knowledge Article record from Dataverse.
