---
title: Knowledge Article Detail
description: Learn how to view a specific knowledge article by article number or ID in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Knowledge Article Detail

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to view the full content of a specific knowledge article when you know its article number or ID.

## What it does
The assistant retrieves the complete details of a single knowledge article, including the full body content, author, ratings, keywords, and metadata. This is useful when you already know which article you need - for example, from a search result or a colleague's reference.

You can look up an article by its article number (e.g. KA-01001) or by its internal GUID.

## Try prompts like
- "Open knowledge article KA-01001"
- "Show me the details for article KA-01001"
- "Get knowledge article KA-02050"
- "What does article KA-01001 say?"
- "Read KB article KA-01001"
- "Show the full content of this knowledge article"

## What you'll see in chat
The assistant returns the article details directly in chat. The response includes the article title, article number, publication status, body content, metadata, and a link to open the article in Dynamics 365 when a link is available.

## Helpful tips
- Use the article number (KA-XXXXX) for the most direct lookup. You can find article numbers in search results or in the Dynamics 365 knowledge base.
- If you don't know the article number, use "search knowledge articles" first to find it.
- The article content is shown in full, so you can read it directly in chat without opening Dynamics 365.
- You can use the article content to draft a reply to a customer by asking "draft a reply using this article."

> [!TIP]
> If a colleague mentioned an article number, you can look it up directly: "show me article KA-01001."

## What happens next
After viewing the article, you can continue with prompts like:

- "Draft a reply using this article"
- "Send this article link to the customer"
- "Search for more articles on this topic"
- "Summarize this article"

## Does this change data?
**No, this does not change data.**

Viewing a knowledge article is read-only. No records are modified.

## What you can do from the app-in-chat component
From the knowledge article viewer in chat, you can:

- Read the full article body including all sections and formatted content
- See article metadata (article number, status, publication date)
- Open the article in Dynamics 365 for editing or sharing
- Use follow-up prompts to ask questions about the article content

## Prerequisites
This tool requires the following:

- Knowledge management

Learn more in [Configure knowledge management](/dynamics365/customer-service/administer/set-up-knowledge-management-embedded-knowledge-search).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Knowledge Article Detail |
| Internal tool name | `get_knowledge_article` |
| Purpose | Retrieves the full detail record for a single knowledge article by article ID (GUID) or article number (e.g |

## Tool behavior
Retrieves the full detail record for a single knowledge article by article ID (GUID) or article number (e.g. `KA-01001`). Returns the complete article body, author, ratings, metadata, and a Dynamics 365 deep-link. Use when the user names a specific article; for free-text search, use `search_knowledge_articles`.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | Not set | Default behavior (reads a single article). |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Article identifier

| Input | Description | Required |
|---|---|---|
| `articleId`, `articleNumber` | At least one of `articleId` (GUID, max 38 characters) or `articleNumber` (e.g. `KA-01001`, max 64 characters) is required. When both are supplied, `articleId` takes precedence. | Yes |

## Response and UI behavior
This MCP tool is supported by an MCP App. 

### Response type

Text-only response in chat

The response returns the full article with body content, author, ratings, keywords, metadata, and a Dynamics 365 link when one is available.

## Routing notes
Use `get_knowledge_article` when:

- The user names a specific article by number (e.g. `KA-01001`)
- The user wants full details on a known article
- Drilling down from `search_knowledge_articles` results

Don't use `get_knowledge_article` when:

- The user wants to **search across articles** - route to `search_knowledge_articles`
- The user wants to **create a new article** - route to `draft_knowledge_article`

## Related tools
| Tool | Relationship |
|---|---|
| [`search_knowledge_articles`](search_knowledge_articles.md) | Searches the knowledge base by query. Use for discovery; use `get_knowledge_article` for a known article |
| [`draft_knowledge_article`](draft_knowledge_article.md) | Creates a new draft article |

## Data mutation classification
Read-only.

Retrieves article data without modification.
