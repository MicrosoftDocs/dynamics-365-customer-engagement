---
title: Load Customer Service vocabulary
description: The Service Agent loads your organization's glossary terms and column synonyms so it understands your wording when answering data questions.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Load Customer Service vocabulary

**Applies to:** Dynamics 365 Customer Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability so the assistant understands your organization's own words for cases, fields, and concepts when it answers data questions.

## What it does

This capability returns your organization-specific vocabulary on demand. The assistant may load it as an optional aid—for example, to inspect what's configured or to confirm a jargon-heavy question is in scope. The vocabulary has three parts:

- Glossary terms—your internal words and what they mean (for example, "P1" or "deflection").
- Column synonyms—alternate names your team uses for a field, mapped to the real Dataverse column (for example, "handler" means the case owner).
- In-scope tables—the tables the Customer Service data question tool can answer from.

The assistant can use this vocabulary to confirm a question is in scope before it routes to the Customer Service data question tool. Translating your wording into the correct table and column names happens inside that tool—the Customer Service data question skill applies the same glossary and synonyms server-side—so the assistant doesn't need to rewrite your question first.

## Try prompts like

- What Customer Service glossary terms are configured?
- Which column synonyms are set up for the data question skill?
- Show me the Customer Service vocabulary.
- What tables can the Customer Service data question tool answer from?

These inspection prompts let the assistant load and report the configured vocabulary. Everyday data questions—like "How many open tickets does Maria have?" or "Who's the handler on case CAS-01024-7O8P9Q?"—are answered by the Customer Service data question tool, which applies your glossary and synonyms server-side, so you don't need to load the vocabulary first.

## What you'll see in chat

The assistant may briefly note that it loaded your vocabulary (a short summary such as the number of glossary terms and synonyms), or it may apply the vocabulary silently—this depends on the chat host. Either way, you notice the benefit when the assistant correctly understands your organization's terminology—for example, treating "ticket" as a case, or "handler" as the case owner—which the Customer Service data question tool applies server-side.

## Helpful tips

- Use your organization's own terms freely. If an administrator has defined them, the assistant recognizes them.
- If the assistant misunderstands a term, ask your administrator to add it to the glossary or synonyms for the Customer Service data question skill.
- Newly added terms take effect once your administrator saves them—the Customer Service data question tool applies the latest vocabulary server-side when it answers.

## What happens next

Continue with normal data questions. The Customer Service data question capability applies your glossary and synonyms server-side and answers using your wording. For example:

- List cases that are waiting on the customer.
- How many high urgency tickets are still open?

## Does this change data?

**No, loading vocabulary doesn't change data.**

This capability only reads configuration your organization has set up. It never creates, updates, or deletes records.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details.

The vocabulary comes from your organization's Customer Service data question (CustomerServiceQnA) configuration. If no glossary terms or synonyms are configured, the assistant still answers questions using its general understanding—it just has no organization-specific terms to apply.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Load Customer Service vocabulary |
| Internal tool name | `get_service_glossary_synonyms` |
| Purpose | Returns organization-specific glossary terms, column synonyms, and in-scope tables for the CustomerServiceQnA skill as an optional routing/inspection hint. `answer_service_question` applies the same vocabulary server-side, so a pre-load isn't required for correct answers. |

## Tool behavior

Reads the glossary terms and column synonyms linked to the CustomerServiceQnA data-question skill, plus the list of tables in that skill's scope. Returns them so the agent can inspect the configured vocabulary or confirm a query is in-domain before routing to the data-question tool. Rewriting the user's wording isn't required—`answer_service_question` applies the same glossary and synonyms server-side. Takes no parameters; the skill is scoped to the caller's selected environment. When the skill isn't provisioned, it returns an empty vocabulary rather than an error.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | Read-only; this tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | `true` | Reads configuration from Dataverse. |

## Input concepts

This tool takes no input parameters. It loads the vocabulary for the caller's selected environment.

## Response and UI behavior

This tool returns a text result only; it doesn't render an app-in-chat component. The result contains three lists—glossary terms, column synonyms (each scoped to a table), and in-scope tables—that the assistant keeps in context for the rest of the conversation.

### Response type

Text (no interactive component)

## Routing notes

This is an optional routing/inspection hint—`answer_service_question` applies the glossary and synonyms server-side on its own, so a pre-load isn't required for correct answers. The assistant may call it on demand to inspect the configured vocabulary or to confirm a jargon-heavy question is in scope. It isn't called directly in response to a normal user prompt.

Use `get_service_glossary_synonyms` when:

- You want to inspect the glossary terms, column synonyms, and in-scope tables configured for the environment.
- You want to confirm a jargon-heavy question is in domain before routing to `answer_service_question`.

Don't use `get_service_glossary_synonyms` to answer a data question directly—use [`answer_service_question`](answer_service_question.md), which applies the glossary and synonyms server-side on its own.

## Related tools

| Tool | Relationship |
|---|---|
| [`answer_service_question`](answer_service_question.md) | Answers a data question, applying the glossary and synonyms server-side |
| [`manage_customer_service_dv_qna`](manage_customer_service_dv_qna.md) | Manages which tables the Customer Service data question skill can answer from |

## Data mutation classification

Read-only.

This capability only reads configuration. It never changes data.
