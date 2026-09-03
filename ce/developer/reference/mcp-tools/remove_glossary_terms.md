---
title: Remove glossary terms
description: Delete one or more Customer Service glossary terms from the question-answering skill. Out-of-the-box managed terms can't be removed.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Remove glossary terms

**Applies to:** Dynamics 365 Customer Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability to delete glossary terms you no longer want the Customer Service question-answering skill to use.

## What it does

Deletes one or more glossary terms. Out-of-the-box managed terms can't be removed and are skipped.

## Try prompts like

- Delete the P1 glossary term.
- Remove these glossary terms.

## What you'll see in chat

This action is normally used from the Manage Customer Service vocabulary editor. After a delete, the editor refreshes and the assistant reports how many terms were removed.

## Helpful tips

- Select the terms in the editor and confirm the delete.
- Managed (out-of-the-box) terms are skipped and reported as not removed.
- Deleting a term can't be undone.

## What happens next

The assistant stops using the removed terms. Continue managing vocabulary from the editor.

## Does this change data?

**Yes.** Removing glossary terms deletes configuration records in Dataverse.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. It requires the maker customize privilege (`prvmsdyn_ServiceAgentMakerCustomize`) and a provisioned CustomerServiceQnA skill.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Remove glossary terms |
| Internal tool name | `remove_glossary_terms` |
| Purpose | Deletes one or more glossary terms from the CustomerServiceQnA skill |

## Tool behavior

Deletes the `copilotglossaryterm` rows for the supplied ids, protecting out-of-the-box managed rows (reported as not removed). Typically invoked by the Manage Customer Service vocabulary editor.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | Deletes configuration data. |
| `destructiveHint` | `true` | Permanently deletes the selected terms. |
| `idempotentHint` | `false` | Deleting an already-deleted term reports it as not found. |
| `openWorldHint` | Not set | Uses default (writes to Dataverse). |

## Input concepts

### Terms to remove

| Input | Description | Required |
|---|---|---|
| `ids` | One or more copilotglossarytermid values to delete (up to 25). | Yes |

## Response and UI behavior

This tool returns a text result with a per-id outcome (deleted, managed-protected, or not found). It doesn't render its own app-in-chat component; it's used by the Manage Customer Service vocabulary editor.

### Response type

Text (per-id outcomes)

## Routing notes

Use `remove_glossary_terms` to delete glossary terms. To add or edit terms use [`save_glossary_term`](save_glossary_term.md).

## Related tools

| Tool | Relationship |
|---|---|
| [`manage_service_vocabulary`](manage_service_vocabulary.md) | Opens the editor these deletes come from |
| [`save_glossary_term`](save_glossary_term.md) | Adds or updates a glossary term |

## Data mutation classification

Destructive write.

Permanently deletes glossary configuration records. Managed rows are protected.
