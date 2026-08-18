---
title: Save a synonym
description: Add or update a Customer Service column synonym—alternate words that map to a Dataverse column on an in-scope table.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Save a synonym

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to add a new column synonym or update an existing one for the Customer Service question-answering skill.

## What it does

Creates a synonym (alternate words that map to a Dataverse column on a specific in-scope table) or updates an existing one. Synonyms help the assistant translate your team's wording into the right column when it answers data questions.

## Try prompts like

- Add a synonym: handler means the owner column on cases.
- Update the synonyms for the status column.

## What you'll see in chat

This action is normally used from the Manage Customer Service vocabulary editor. After a save, the editor refreshes and the assistant confirms the synonym was saved.

## Helpful tips

- Pick the table first, then the column, then type the alternate words (comma-separated).
- The table must already be in the question-answering scope. Use "manage customer service dv qna" to add tables.
- You can only edit your own (unmanaged) synonyms.

## What happens next

The saved synonym is used the next time the assistant interprets a data question against that table. Continue managing vocabulary from the editor.

## Does this change data?

**Yes.** Saving a synonym creates or updates a configuration record in Dataverse.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. It requires the maker customize privilege (`prvmsdyn_ServiceAgentMakerCustomize`) and a provisioned CustomerServiceQnA skill. The target table must already be in the skill's scope.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Save a synonym |
| Internal tool name | `save_synonym` |
| Purpose | Creates or updates a column synonym for the CustomerServiceQnA skill |

## Tool behavior

Resolves the table to its in-scope entry, then creates a `copilotsynonyms` row when no id is supplied or updates the named synonym when an id is supplied. Rejects tables that aren't in scope and refuses to update managed rows. Typically invoked by the Manage Customer Service vocabulary editor.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | Writes configuration data. |
| `destructiveHint` | `false` | Creates or updates; doesn't delete. |
| `idempotentHint` | `false` | Omitting `id` creates a new row on each call, so repeating the request is not guaranteed to yield the same result. |
| `openWorldHint` | Not set | Uses default (writes to Dataverse). |

## Input concepts

### Synonym identity

| Input | Description | Required |
|---|---|---|
| `id` | copilotsynonymsid to update; omit to create a new synonym. | No |

### Mapping

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | Logical name of an in-scope table the column belongs to. | Yes |
| `columnLogicalName` | Logical name of the column the synonyms resolve to. | Yes |
| `synonyms` | Comma-separated alternate phrasings. | Yes |

## Response and UI behavior

This tool returns a text result indicating success and the saved id. It doesn't render its own app-in-chat component; it's used by the Manage Customer Service vocabulary editor.

### Response type

Text (success + id)

## Routing notes

Use `save_synonym` to add or edit a column synonym. To delete synonyms use [`remove_synonyms`](remove_synonyms.md); to edit glossary terms use [`save_glossary_term`](save_glossary_term.md).

## Related tools

| Tool | Relationship |
|---|---|
| [`manage_service_vocabulary`](manage_service_vocabulary.md) | Opens the editor these saves come from |
| [`remove_synonyms`](remove_synonyms.md) | Deletes synonyms |

## Data mutation classification

Write.

Creates or updates a synonym configuration record. It never deletes.
