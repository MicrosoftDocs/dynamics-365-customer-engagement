---
title: Draft Knowledge Article
description: Learn how to draft a new knowledge article from chat in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Draft Knowledge Article

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to create a new draft knowledge article in your organization's knowledge base directly from chat.

## What it does
The assistant creates a new draft knowledge article in Dynamics 365 with the title, content, and keywords you provide. The article is created in draft status, so it needs to be reviewed and published separately through the Dynamics 365 knowledge management interface.

This is especially useful after resolving a case - you can convert your resolution steps into a reusable knowledge article so other agents can benefit from the solution.

## Try prompts like
- "Create a knowledge article from this case resolution"
- "Draft a KB article about password reset procedure"
- "Turn these resolution steps into a knowledge article"
- "Create an article titled 'How to reset MFA' with these steps"
- "Save this solution as a knowledge article"
- "Draft a knowledge article about handling refund requests"

## What you'll see in chat
The assistant confirms that the draft article was created and provides the new article ID along with a link to edit the draft in Dynamics 365.

## Helpful tips
- Provide a clear, descriptive title that other agents can search for.
- Include detailed steps in the content - the more complete your content, the more useful the article will be.
- Add keywords to make the article easier to find in searches (e.g. "password", "reset", "MFA", "authentication").
- The article is created as a draft. You or a knowledge manager must review and publish it before other agents can find it in searches.
- Before creating a new article, search the knowledge base first to avoid duplicates.
- Use "summarize the resolution steps for this case" first to get a clean summary, then use that as the article content.

> [!TIP]
> A great workflow: resolve a case, ask for a summary of the resolution steps, then say "create a knowledge article from that summary." This turns one-time solutions into reusable knowledge.

## What happens next
After the draft is created, you can continue with prompts like:

- "Open the article I just created"
- "Search knowledge articles to check for similar content"
- "Summarize another case"
- "Go back to my cases"

## Does this change data?
**Yes, this creates a new record.**

A new draft knowledge article is created in Dynamics 365. The article is in draft status and must be published separately before other agents can see it in knowledge searches.

## Prerequisites
This tool requires the following:

- Knowledge management to be configured. Users must have the knowledge author role to create articles

Learn more in [Configure knowledge management](/dynamics365/customer-service/administer/set-up-knowledge-management-embedded-knowledge-search).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Draft Knowledge Article |
| Internal tool name | `draft_knowledge_article` |
| Purpose | Creates a draft knowledge article in the Dataverse knowledge base |

## Tool behavior
Creates a draft knowledge article in the Dataverse knowledge base. Typically used after `summarize_case_actions` to convert case resolution steps into a reusable knowledge article. Returns the new article ID and a link to edit the draft in Dynamics 365.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool creates a new record. |
| `destructiveHint` | `false` | Creates a draft; does not delete or overwrite existing articles. |
| `idempotentHint` | `false` | Each call creates a new draft article. |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Title

| Input | Description | Required |
|---|---|---|
| `title` | `title` (required). Title for the new knowledge article draft. | Yes |

### Content

| Input | Description | Required |
|---|---|---|
| `content` | `content` (required). Body content for the article. Accepts plain text or basic HTML. | Yes |

### Keywords

| Input | Description | Required |
|---|---|---|
| `keywords` | `keywords` (optional). List of keywords to tag the article with for improved searchability. | No |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. The response confirms article creation with the new article ID and provides a link to edit the draft in Dynamics 365.

## Routing notes
Use `draft_knowledge_article` when:

- The user asks to create, draft, or write a knowledge article
- The user wants to convert case resolution steps into a reusable article
- After `summarize_case_actions` provides structured resolution content

Don't use `draft_knowledge_article` when:

- The user wants to **search existing articles** - route to `search_knowledge_articles`
- The user wants to **view an article** - route to `get_knowledge_article`
- The user wants to **format notes** without creating an article - route to `format_case_note`

## Related tools
| Tool | Relationship |
|---|---|
| [`summarize_case_actions`](summarize_case_actions.md) | Lists resolution steps taken on a case. Output is ideal input for drafting a KB article |
| [`search_knowledge_articles`](search_knowledge_articles.md) | Searches existing articles. Check for duplicates before drafting a new article |
| [`get_knowledge_article`](get_knowledge_article.md) | Retrieves a single article. Use to review the newly created draft |
| [`format_case_note`](format_case_note.md) | Formats raw notes. Can prepare content before drafting an article |

## Data mutation classification
Write / mutation.

Creates a new draft knowledge article record in Dataverse. The article is created in draft status and must be published separately through the Dynamics 365 interface.
