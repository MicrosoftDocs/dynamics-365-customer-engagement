---
title: Save a glossary term
description: Add or update a Customer Service glossary term—a company word and its plain-language definition—used by the question-answering skill.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Save a glossary term

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to add a new glossary term or update an existing one for the Customer Service question-answering skill.

## What it does

Creates a glossary term (a company word plus its definition) or updates an existing one. Adding a definition helps the assistant understand your organization's wording when it answers data questions.

## Try prompts like

- Add a glossary term for P1.
- Update the definition of deflection.

## What you'll see in chat

This action is normally used from the Manage Customer Service vocabulary editor. After a save, the editor refreshes and the assistant confirms the term was saved.

## Helpful tips

- Omit the id to create a new term; include it to update an existing one.
- You can only edit your own (unmanaged) terms. Out-of-the-box managed terms are read-only.
- Keep definitions short and specific so the assistant can apply them reliably.

## What happens next

The saved term is used the next time the assistant interprets a data question. You can continue managing vocabulary from the editor.

## Does this change data?

**Yes.** Saving a glossary term creates or updates a configuration record in Dataverse.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. It requires the maker customize privilege (`prvmsdyn_ServiceAgentMakerCustomize`) and a provisioned CustomerServiceQnA skill.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Save a glossary term |
| Internal tool name | `save_glossary_term` |
| Purpose | Creates or updates a glossary term (term + definition) for the CustomerServiceQnA skill |

## Tool behavior

Creates a `copilotglossaryterm` when no id is supplied, or updates the named term when an id is supplied. Refuses to update out-of-the-box managed terms. Typically invoked by the Manage Customer Service vocabulary editor.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | Writes configuration data. |
| `destructiveHint` | `false` | Creates or updates; doesn't delete. |
| `idempotentHint` | `false` | Omitting `id` creates a new row on each call, so repeating the request is not guaranteed to yield the same result. |
| `openWorldHint` | Not set | Uses default (writes to Dataverse). |

## Input concepts

### Term identity

| Input | Description | Required |
|---|---|---|
| `id` | copilotglossarytermid to update; omit to create a new term. | No |

### Content

| Input | Description | Required |
|---|---|---|
| `term` | The term as users say it. | Yes |
| `description` | Plain-language definition of the term. | Yes |

## Response and UI behavior

This tool returns a text result indicating success and the saved id. It doesn't render its own app-in-chat component; it's used by the Manage Customer Service vocabulary editor.

### Response type

Text (success + id)

## Routing notes

Use `save_glossary_term` to add or edit a glossary term. To delete terms use [`remove_glossary_terms`](remove_glossary_terms.md); to edit synonyms use [`save_synonym`](save_synonym.md).

## Related tools

| Tool | Relationship |
|---|---|
| [`manage_service_vocabulary`](manage_service_vocabulary.md) | Opens the editor these saves come from |
| [`remove_glossary_terms`](remove_glossary_terms.md) | Deletes glossary terms |

## Data mutation classification

Write.

Creates or updates a glossary configuration record. It never deletes.
