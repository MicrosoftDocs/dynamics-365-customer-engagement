---
title: Save edits to a knowledge article draft
description: Learn how to use the Save edits to a knowledge article draft capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Save edits to a knowledge article draft

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want the assistant to help with save edits to a knowledge article draft from chat.

## What it does
Persists inline edits to an existing draft knowledge article while keeping the article in draft state.

## Try prompts like
- "Save this as a draft"
- "Save my article edits"
- "Keep these changes in the draft"
- "Update the draft with this title and content"

## What you'll see in chat
The assistant confirms the draft was saved or shows a stale-state message if the draft was deleted or already published.

## Helpful tips
- Use this from the harvest widget after editing title or body content.
- Saving does not publish the article.
- If the draft is stale, refresh the harvest card before editing again.

## What happens next
- "Continue editing the draft"
- "Publish the draft after final review"
- "Discard the draft if it is no longer needed"

## Does this change data?
**Yes, saving a draft updates the draft knowledge article title and content.**

## Prerequisites
This tool requires the following:

- Knowledge management

Learn more in [Configure knowledge management](/dynamics365/customer-service/administer/set-up-knowledge-management-embedded-knowledge-search).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Save Knowledge Article Draft |
| Internal tool name | `save_knowledge_draft` |
| Purpose | Saves edited title and content back to an existing draft Knowledge Article |

## Tool behavior
Saves edited title and content back to an existing draft Knowledge Article. Use when the user confirms inline edits in the harvest widget (Save as Draft button) or asks to save their changes to a draft.

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
| `articleId` | `articleId` (GUID, required). The ID of the draft knowledge article to update. | Yes |

### Title

| Input | Description | Required |
|---|---|---|
| `title` | `title` (required). The updated article title. | Yes |

### Content

| Input | Description | Required |
|---|---|---|
| `content` | `content` (required). The updated article body content. | Yes |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns confirmation that the draft edits were saved.

## Routing notes
Use `save_knowledge_draft` when:

- The user confirms saving inline edits in the harvest widget
- The user asks to 'save my edits', 'keep my changes', or 'save as draft' on a knowledge article

Don't use `save_knowledge_draft` when:

- The user wants to **publish** the article - route to `publish_knowledge_article`
- The user wants to **discard** the draft - route to `discard_knowledge_draft`

## Related tools
| Tool | Relationship |
|---|---|
| [`harvest_knowledge_article`](harvest_knowledge_article.md) | Creates the draft that this tool updates |
| [`publish_knowledge_article`](publish_knowledge_article.md) | Publishes the saved draft |
| [`discard_knowledge_draft`](discard_knowledge_draft.md) | Abandons the draft instead of saving |

## Data mutation classification
**Write.** Updates the title and content of an existing draft Knowledge Article in Dataverse.
