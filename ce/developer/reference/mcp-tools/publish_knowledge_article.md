---
title: Publish a knowledge article draft
description: Learn how to use the Publish a knowledge article draft capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Publish a knowledge article draft

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want the assistant to help with publish a knowledge article draft from chat.

## What it does
Transitions a draft knowledge article to published after the user explicitly confirms it should go live.

## Try prompts like
- "Publish this article"
- "Make this knowledge article live"
- "Publish the draft"
- "This draft is ready to publish"

## What you'll see in chat
The assistant confirms that the draft is published, or reports that it was already published.

## Helpful tips
- Review the title and content before publishing.
- Use this only after explicit user confirmation.
- Already-published articles return success without repeating the transition.

## What happens next
- "Open the published article in Dynamics 365"
- "Share the article with agents who need it"
- "Harvest another article from a different source"

## Does this change data?
**Yes, publishing changes the draft article state to published.**

## Prerequisites
This tool requires the following:

- Knowledge management

Learn more in [Configure knowledge management](/dynamics365/customer-service/administer/set-up-knowledge-management-embedded-knowledge-search).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Publish Knowledge Article |
| Internal tool name | `publish_knowledge_article` |
| Purpose | Publishes a draft Knowledge Article so it goes live in the knowledge base and becomes visible to all users |

## Tool behavior
Publishes a draft Knowledge Article so it goes live in the knowledge base and becomes visible to all users. Use when the user confirms publishing in the harvest widget (Publish button + inline confirm) or explicitly asks to publish. The operation is idempotent - already-published articles return success without re-transitioning.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | Updates data but does not delete records. |
| `idempotentHint` | `true` | Repeated calls with the same input produce the same result. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Article ID

| Input | Description | Required |
|---|---|---|
| `articleId` | `articleId` (GUID, required). The ID of the draft knowledge article to publish. | Yes |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns confirmation that the article was published and is now live in the knowledge base.

## Routing notes
Use `publish_knowledge_article` when:

- The user confirms publishing via the harvest widget Publish button
- The user explicitly asks to publish, make live, or release a draft article

Don't use `publish_knowledge_article` when:

- The user wants to **edit** the draft first - route to `save_knowledge_draft`
- The user wants to **discard** the draft - route to `discard_knowledge_draft`

## Related tools
| Tool | Relationship |
|---|---|
| [`harvest_knowledge_article`](harvest_knowledge_article.md) | Creates the draft that this tool publishes |
| [`save_knowledge_draft`](save_knowledge_draft.md) | Saves edits before publishing |
| [`discard_knowledge_draft`](discard_knowledge_draft.md) | Abandons the draft instead of publishing |

## Data mutation classification
**Write.** Transitions the Knowledge Article record from Draft to Published state in Dataverse.
