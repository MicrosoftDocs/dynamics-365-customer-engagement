---
title: Use Search knowledge articles tool
description: Learn how to use the Search Knowledge Articles capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Use Search knowledge articles tool

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to find relevant knowledge articles from your organization's knowledge base directly in chat.

## What it does
The assistant searches your Dynamics 365 knowledge base for articles that match your question or topic. It returns matching articles with titles, summaries, keywords, article numbers, and links to the full content. The top results are shown with citation links so you can reference them immediately.

This is useful when you need to find a procedure, look up a policy, or find solution steps documented in your knowledge base while working on a case.

## Try prompts like
- "Search knowledge base for password reset procedure"
- "Find articles about unauthorized transactions"
- "How do I handle a refund request?"
- "Search for published articles about billing"
- "What's the process for account closure?"
- "Find KB articles about login issues"
- "Search knowledge articles about SLA policies"
- "Look up the return policy"

## What you see in chat
The assistant returns matching knowledge articles directly in chat. Each result can include the article title, summary, keywords, article number, and a Dynamics 365 link when one is available. Citation links in the narration point to the most relevant articles.

## Helpful tips
- Use natural language to describe what you're looking for. The search matches across article titles, summaries, and keywords.
- You can filter by article status: say "search published articles about..." to see only published articles, or "search draft articles" for articles still in review.
- If you know the specific article number (e.g. KA-01001), ask for it directly instead of searching.
- The assistant shows the top 3 results in the summary. If you need more, say "show more results" or "search with a higher limit."
- Pair knowledge search with case context: "search the knowledge base for solutions to this case's issue."

> [!TIP]
> After finding a helpful article, you can ask "send this article to the customer" or "use this to draft a reply."

## What happens next
After finding articles, you can continue with prompts like:

- "Open article KA-01001"
- "Show me the full content of the first article"
- "Send this article to the customer"
- "Draft a reply using this knowledge article"
- "Create a knowledge article from this case resolution"

## Does this change data?

No. This doesn't change data.

Searching the knowledge base is read-only. No articles or records are modified.

## What you can do from the app-in-chat component
From the knowledge article list in chat, you can:

- Browse matching articles with titles, summaries, and article numbers
- Select an article to read its full content in the viewer
- Open an article directly in Dynamics 365
- Use follow-up prompts to refine the search or ask about a specific article

## Prerequisites
This tool requires the following:

- Knowledge management

Learn more in [Configure knowledge management](/dynamics365/customer-service/administer/set-up-knowledge-management-embedded-knowledge-search).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Search Knowledge Articles |
| Internal tool name | `search_knowledge_articles` |
| Purpose | Lists or browses knowledge articles matching a query and renders a visual widget of article cards (title, summary, KA-number, metadata) the user can click to view details |

## Tool behavior
Lists or browses knowledge articles matching a query and renders a visual widget of article cards (title, summary, KA-number, metadata) the user can click to view details. Each result surfaces its KA-number and Dynamics deep-link in `structuredContent`, shown as markdown citations in the narration. Use when the user wants to **see, list, browse, or visually inspect** articles (e.g. "show me articles about…", "list articles on…", "what articles do we have on…"). For a direct answer to an informational, procedural, or "how do I…" question, prefer `answer_knowledge_question`, which synthesizes an answer with citations. For a specific article by KA-number or GUID use `get_knowledge_article`; to draft a new article from a case resolution use `draft_knowledge_article`.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | Not set | Default behavior (reads knowledge base). |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Search query

| Input | Description | Required |
|---|---|---|
| `query` | `query` (optional). Free-text search across article titles, summaries, and keywords. | No |

### Status filter

| Input | Description | Required |
|---|---|---|
| `status` | `status` (optional). Filter articles by publication status: `published`, `draft`, or `archived`. | No |

### Result limit

| Input | Description | Required |
|---|---|---|
| `top` | `top` (optional). Maximum number of articles to return, up to 200. Defaults to 10. | No |

## Response and UI behavior
This MCP tool is supported by an MCP App. 

### Response type

Text-only response in chat

The response returns matching knowledge articles with titles, summaries, article numbers, and citation links. The top 3 results are surfaced in `structuredContent.articles`; `totalCount` indicates the total matches bounded by `top`.

## Routing notes
Use `search_knowledge_articles` when:

- The user wants to **see, list, browse, or visually inspect** articles (e.g. "show me articles about...", "list articles on...", "what articles do we have on...")
- The user asks to search the knowledge base to see what's available

Don't use `search_knowledge_articles` when:

- The user asks a direct **question** ("how do I...", "what is...") - route to `answer_knowledge_question`, which synthesizes an answer with citations
- The user knows a specific article number - route to `get_knowledge_article`
- The user wants to **create a new article** - route to `draft_knowledge_article`
- The user's question is about Dataverse data, not knowledge content - route to `answer_service_question`

## Related tools

| Tool | Relationship |
|------|-------------|
| [`answer_knowledge_question`](answer_knowledge_question.md) | Synthesizes answers to informational/procedural questions. Use for question/answer intent; use `search_knowledge_articles` for browse/inspect intent. |
| [`get_knowledge_article`](get_knowledge_article.md) | Retrieves full details for a single article by ID or number. Use after `search_knowledge_articles` for drill-down |
| [`draft_knowledge_article`](draft_knowledge_article.md) | Creates a new draft article. Use to convert case resolutions into KB content |
| [`summarize_case_actions`](summarize_case_actions.md) | Lists case resolution steps. Output can inform knowledge article creation |

## Data mutation classification
Read-only.

Searches the knowledge base without modification.
