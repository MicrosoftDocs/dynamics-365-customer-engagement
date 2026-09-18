---
title: Load Customer Service vocabulary
description: Loads organization-specific terms and synonyms so the Service Agent can interpret unfamiliar terminology and choose the right tool.
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

Use this capability so the assistant can map your organization's own words for cases, fields, and concepts to the appropriate Customer Service tool.

## What it does

This capability returns your organization-specific vocabulary on demand. The assistant may load it to inspect what's configured, interpret an unfamiliar term before selecting a dedicated tool, or recover after a term-based data question returns an empty or unexpected result. The vocabulary has three parts:

- Glossary terms—your internal words and what they mean (for example, "P1" or "deflection").
- Column synonyms—alternate names your team uses for a field, mapped to the real Dataverse column (for example, "handler" means the case owner).
- In-scope tables—the tables the Customer Service data question tool can answer from.

For standard terminology, the assistant can route directly to the Customer Service data question tool, which applies the same glossary and synonyms server-side without rewriting your question. For an unfamiliar organization-specific term, the assistant can load the vocabulary, map the term to a table, and then use the dedicated tool that covers the request. If no dedicated tool applies, it can use the data question tool as the fallback.

## Try prompts like

- What Customer Service glossary terms are configured?
- Which column synonyms are set up for the data question skill?
- Show me the Customer Service vocabulary.
- What tables can the Customer Service data question tool answer from?

These inspection prompts let the assistant load and report the configured vocabulary. Everyday data questions that use standard terminology can go directly to the Customer Service data question tool, which applies your glossary and synonyms server-side. When a term is unfamiliar, or a term-based data question returns an empty or unexpected result, the assistant can load the vocabulary before selecting the appropriate dedicated tool or retrying with the data question fallback.

## What you'll see in chat

The assistant may briefly note that it loaded your vocabulary, including a short summary such as the number of glossary terms and synonyms. It then uses the mapped entity and intent to select an available dedicated tool, or falls back to the Customer Service data question tool when no dedicated tool covers the request.

## Helpful tips

- Use your organization's own terms freely. If a term isn't initially recognized, the assistant can load the configured vocabulary to resolve it.
- If the assistant misunderstands a term, ask your administrator to add it to the glossary or synonyms for the Customer Service data question skill.
- Newly added terms take effect once your administrator saves them—the Customer Service data question tool applies the latest vocabulary server-side when it answers.

## What happens next

Continue with normal data questions. Standard terms can go directly to the Customer Service data question capability. For unfamiliar terms, the assistant loads the vocabulary and routes to a dedicated tool when one covers the mapped entity and intent; otherwise, it retries through the data question capability using your wording. For example:

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
| Purpose | Returns organization-specific glossary terms, column synonyms, and in-scope tables to inspect vocabulary, resolve unfamiliar terms before dedicated-tool selection, or recover from an empty term-based QnA result. |

## Tool behavior

Reads the glossary terms and column synonyms linked to the CustomerServiceQnA data-question skill, plus the list of tables in that skill's scope. The assistant uses the vocabulary to map an unfamiliar term to a known table and select an available dedicated tool. `answer_service_question` applies the same glossary and synonyms server-side without rewriting the user's wording, so it remains the fallback when no dedicated tool covers the request. Takes no parameters; the skill is scoped to the caller's selected environment. When the skill isn't provisioned, it returns an empty vocabulary rather than an error.

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

This is a routing and inspection tool. `answer_service_question` applies the glossary and synonyms server-side on its own, so standard vocabulary doesn't require a pre-load. The assistant may load the vocabulary when an unfamiliar org-specific term needs to be mapped before it selects a dedicated tool, or after a term-based `answer_service_question` call returns an empty or unexpected result.

Use `get_service_glossary_synonyms` when:

- You want to inspect the glossary terms, column synonyms, and in-scope tables configured for the environment.
- A request contains an unfamiliar org-specific term that must be mapped to a known table before selecting the appropriate dedicated tool.
- A term-based `answer_service_question` call returned an empty or unexpected result and the vocabulary should be checked before retrying.

Don't use `get_service_glossary_synonyms` to answer a data question directly. After loading the vocabulary, use the dedicated tool that covers the mapped entity and intent; use [`answer_service_question`](answer_service_question.md) only when no dedicated tool applies.

## Related tools

| Tool | Relationship |
|---|---|
| [`answer_service_question`](answer_service_question.md) | Answers a data question, applying the glossary and synonyms server-side |
| [`manage_customer_service_dv_qna`](manage_customer_service_dv_qna.md) | Manages which tables the Customer Service data question skill can answer from |

## Data mutation classification

Read-only.

This capability only reads configuration. It never changes data.
