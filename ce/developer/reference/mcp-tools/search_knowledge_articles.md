---
title: Search knowledge articles in chat
description: Learn how to use the Search knowledge articles in chat capability in Dynamics 365 Customer Service and Field Service.
ms.date: 11/19/2026
ms.topic: reference
ai-usage: ai-assisted
ms.custom: mcp-enabled-namespaces=service,field-service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Search knowledge articles in chat

**Applies to:** Dynamics 365 Customer Service and Dynamics 365 Field Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability to find relevant knowledge articles from your organization's knowledge base directly in chat.

## What it does

The assistant searches your Dynamics 365 knowledge base for articles that match your question or topic. It returns matching articles with titles, summaries, keywords, article numbers, and links to the full content. The top results are shown with citation links so you can reference them immediately.

This is useful when you need to find a procedure, look up a policy, or find solution steps documented in your knowledge base while working on a case.

## Try prompts like

- Search knowledge base for password reset procedure.
- Find articles about unauthorized transactions.
- How do I handle a refund request?
- Search for published articles about billing.
- What's the process for account closure?
- Find KB articles about login issues.
- Search knowledge articles about SLA policies.
- Look up the return policy.

## What you'll see in chat

The assistant returns matching knowledge articles directly in chat. Each result can include the article title, summary, keywords, article number, and a Dynamics 365 link when one is available. Citation links in the narration point to the most relevant articles.

## Helpful tips

- Use natural language to describe what you're looking for. The search matches across article titles, summaries, and keywords.
- You can filter by article status: say "search published articles about..." to see only published articles, or "search draft articles" for articles still in review.
- If you know the specific article number (for example, KA-01001), ask for it directly instead of searching.
- The assistant shows the top 3 results in the summary. If you need more, say "show more results" or "search with a higher limit." Up to 200 articles can be requested at once; where your administrator enables expanded results, up to 5,000 can be requested, and large result sets can arrive in several parts that the assistant continues automatically when asked.
- Search results include each article's summary. The full article body opens when you select an article or ask for it by number.
- Pair knowledge search with case context: "search the knowledge base for solutions to this case's issue."

> [!TIP]
> After finding a helpful article, you can ask "send this article to the customer" or "use this to draft a reply."

## What happens next

After finding articles, you can continue with prompts like:

- Open article KA-01001.
- Show me the full content of the first article.
- Send this article to the customer.
- Draft a reply using this knowledge article.
- Create a knowledge article from this case resolution.

## Does this change data?

**No, this doesn't change data.**

Searching the knowledge base is read-only. No articles or records are modified.

## What you can do from the app-in-chat component

From the knowledge article list in chat, you can:

- Browse matching articles with titles, summaries, and article numbers.
- Select an article to read its full content in the viewer.
- Open an article directly in Dynamics 365.
- Use follow-up prompts to refine the search or ask about a specific article.

## Prerequisites

This tool requires the following:

- Knowledge management

Learn more in [Configure knowledge management](/dynamics365/customer-service/administer/set-up-knowledge-management-embedded-knowledge-search).

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Search knowledge articles |
| Internal tool name | `search_knowledge_articles` |
| Purpose | Lists or browses knowledge articles matching a query and renders a visual widget of article cards (title, summary, KA-number, metadata) the user can select to view details |

## Tool behavior

Lists or browses knowledge articles matching a query and renders a visual widget of article cards (title, summary, KA-number, metadata) the user can select to view details. Each result surfaces its KA-number and Dynamics deep-link in `structuredContent`, shown as markdown citations in the narration. Use when the user wants to **see, list, browse, or visually inspect** articles (for example, "show me articles about…", "list articles on…", "what articles do we have on…"). For a direct answer to an informational, procedural, or "how do I…" question, prefer `answer_knowledge_question`, which synthesizes an answer with citations. For a specific article by KA-number or GUID use `get_knowledge_article`; to draft a new article from a case resolution use `draft_knowledge_article`.

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

When you provide a search query, results default to published articles. Specify
`draft` or `archived` to search those states instead. The same status selection
applies when Dataverse Search is unavailable and the tool uses its fallback query.
The fallback matches article titles, summaries, and keywords, including matches
that appear only in the summary.
When browsing without a query, omitting `status` keeps all readable article states;
providing `status` limits the list to that state.

### Result limit

| Input | Description | Required |
|---|---|---|
| `top` | `top` (optional). Maximum number of articles to return. Defaults to the organization's knowledge page size setting (10 unless configured). The normal maximum is 200; where expanded results are enabled, up to 5,000. A response can carry fewer articles than `top` when it reaches its size limit. | No |

### Continuation

| Input | Description | Required |
|---|---|---|
| `cursor` | `cursor` (optional). The opaque `pageInfo.nextCursor` from a previous response. Repeat the same `query`, `status`, and `top`. Only expanded results return a cursor. | No |

## Response and UI behavior

This MCP tool is supported by an MCP app.

### Response type

Text-only response in chat

The response returns matching knowledge articles with titles, summaries, article numbers, and citation links. The response has one of two shapes:

- **Without `pageInfo`** (expanded results not configured): the top 3 results are surfaced in `structuredContent.articles`, and `totalCount` indicates the total matches bounded by `top`.
- **With `pageInfo`** (result capacity configured): every delivered article is surfaced in `structuredContent.articles`, and only the first 3 carry their article body; open an article to read the rest. `totalCount` counts the articles delivered in this response, not every match. `pageInfo` is the completeness authority: when `pageInfo.hasMore` is true, more articles match. Continue with `pageInfo.nextCursor` when it's present; otherwise refine the query.

## Routing notes

Use `search_knowledge_articles` when:

- The user wants to **see, list, browse, or visually inspect** articles (for example, "show me articles about...", "list articles on...", "what articles do we have on...")
- The user asks to search the knowledge base to see what's available.

Don't use `search_knowledge_articles` when:

- The user asks a direct **question** ("how do I...", "what is...")—route to `answer_knowledge_question`, which synthesizes an answer with citations.
- The user knows a specific article number—route to `get_knowledge_article`.
- The user wants to **create a new article**—route to `draft_knowledge_article`.
- The user's question is about Dataverse data, not knowledge content—route to `answer_service_question`.

## Related tools

| Tool | Relationship |
|------|-------------|
| [`answer_knowledge_question`](answer_knowledge_question.md) | Synthesizes answers to informational/procedural questions. Use for question/answer intent; use `search_knowledge_articles` for browse/inspect intent. |
| [`get_knowledge_article`](get_knowledge_article.md) | Retrieves full details for a single article by ID or number. Use after `search_knowledge_articles` for drill-down. |
| [`draft_knowledge_article`](draft_knowledge_article.md) | Creates a new draft article. Use to convert case resolutions into KB content. |
| [`aggregate_case_actions`](summarize_case_actions.md) | Lists case resolution steps. Output can inform knowledge article creation. |

## Data mutation classification

Read-only.

Searches the knowledge base without modification.
