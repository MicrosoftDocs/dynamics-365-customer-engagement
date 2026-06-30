---
title: Ask questions from knowledge articles
description: Learn how to use the Ask questions from knowledge articles capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Ask questions from knowledge articles

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want the assistant to help with ask questions from knowledge articles from chat.

## What it does
Searches published knowledge articles and answers informational, procedural, or troubleshooting questions with citations.

## Try prompts like
- "How do I reset a customer password?"
- "What is the process for escalating a billing case?"
- "Troubleshoot error code 0x80040216"
- "Walk me through creating a knowledge article"

## What you see in chat
The assistant returns a text answer synthesized from published knowledge articles, with citations when matching articles are available.

## Helpful tips
- Ask one clear question at a time for the best match.
- Include product names, error text, or the process you are working on.
- Ask follow-up questions in the same chat when you want to refine the answer.

## What happens next
- "Ask for more detail on one cited step"
- "Open the cited knowledge article if you need the full source"
- "Ask a follow-up question using the same context"

## Does this change data?
No. Asking a knowledge question doesn't change data.

## What you can do from the app-in-chat component
From the knowledge answer component in chat, you can:

- Read the AI-generated answer with inline citations linking to source articles
- Select a citation to open the referenced knowledge article
- Expand source article summaries without leaving chat
- Use follow-up prompts to refine the answer or ask about a related topic

## Prerequisites
This tool requires the following:

- Ask a question capability in the Copilot help pane

Learn more in [Configure knowledge management](/dynamics365/customer-service/administer/set-up-knowledge-management-embedded-knowledge-search), and [Enable features in Copilot pane](/dynamics365/contact-center/administer/copilot-enable-help-pane).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Query Knowledge Agent |
| Internal tool name | `answer_knowledge_question` |
| Purpose | Searches the org's published knowledge articles and synthesizes a natural-language answer with citations for informational, procedural, or 'how do I...' questions |

## Tool behavior
Searches the organization's published knowledge articles and synthesizes a natural-language answer with citations for informational, procedural, or 'how do I...' questions. Returns a text answer with citations from matching articles. Use when the user asks a question that is likely answered by the knowledge base. For browsing or listing articles visually, use `search_knowledge_articles`.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Question

| Input | Description | Required |
|---|---|---|
| `question` | `question` (required). The natural-language question to answer. | Yes |

### Conversation history

| Input | Description | Required |
|---|---|---|
| `messages` | `messages` (optional). Prior conversation turns for multi-turn context. Pass the full history from previous `answer_knowledge_question` responses to maintain continuity. | No |

### Language

| Input | Description | Required |
|---|---|---|
| `language` | `language` (optional). BCP 47 language code for the response (for example, `en-us`). Defaults to `en-us`. | No |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns a synthesized text answer drawn from published knowledge articles, with citations when matching articles are found.

## Routing notes
Use `answer_knowledge_question` when:

- The user asks an informational, procedural, or troubleshooting question that is likely answered in the knowledge base
- The user asks 'how do I...', 'what is...', 'explain...', or similar question-style prompts

Don't use `answer_knowledge_question` when:

- The user wants to **browse or list articles** - route to `search_knowledge_articles`
- The user wants to **view a specific article** - route to `get_knowledge_article`
- The user wants to **create an article** - route to `draft_knowledge_article` or `harvest_knowledge_article`

## Related tools
| Tool | Relationship |
|---|---|
| [`search_knowledge_articles`](search_knowledge_articles.md) | Lists and browses articles visually. Use for browse/inspect intent; use `answer_knowledge_question` for question/answer intent |
| [`get_knowledge_article`](get_knowledge_article.md) | Retrieves full detail for a single article by KA-number or GUID |
| [`draft_knowledge_article`](draft_knowledge_article.md) | Creates a new draft article |

## Data mutation classification
**Read-only.** Doesn't create or modify any records.
