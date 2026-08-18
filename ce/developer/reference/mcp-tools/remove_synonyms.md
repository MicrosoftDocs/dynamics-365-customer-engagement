---
title: Remove synonyms
description: Delete one or more Customer Service column synonyms from the question-answering skill. Out-of-the-box managed synonyms can't be removed.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Remove synonyms

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to delete column synonyms you no longer want the Customer Service question-answering skill to use.

## What it does

Deletes one or more column synonyms. Out-of-the-box managed synonyms can't be removed and are skipped.

## Try prompts like

- Delete this synonym.
- Remove the synonyms for the owner column.

## What you'll see in chat

This action is normally used from the Manage Customer Service vocabulary editor. After a delete, the editor refreshes and the assistant reports how many synonyms were removed.

## Helpful tips

- Select the synonyms in the editor and confirm the delete.
- Managed (out-of-the-box) synonyms are skipped and reported as not removed.
- Deleting a synonym can't be undone.

## What happens next

The assistant stops using the removed synonyms. Continue managing vocabulary from the editor.

## Does this change data?

**Yes.** Removing synonyms deletes configuration records in Dataverse.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. It requires the maker customize privilege (`prvmsdyn_ServiceAgentMakerCustomize`) and a provisioned CustomerServiceQnA skill.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Remove synonyms |
| Internal tool name | `remove_synonyms` |
| Purpose | Deletes one or more column synonyms from the CustomerServiceQnA skill |

## Tool behavior

Deletes the `copilotsynonyms` rows for the supplied ids, protecting out-of-the-box managed rows (reported as not removed). Typically invoked by the Manage Customer Service vocabulary editor.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | Deletes configuration data. |
| `destructiveHint` | `true` | Permanently deletes the selected synonyms. |
| `idempotentHint` | `false` | Deleting an already-deleted synonym reports it as not found. |
| `openWorldHint` | Not set | Uses default (writes to Dataverse). |

## Input concepts

### Synonyms to remove

| Input | Description | Required |
|---|---|---|
| `ids` | One or more copilotsynonymsid values to delete (up to 25). | Yes |

## Response and UI behavior

This tool returns a text result with a per-id outcome (deleted, managed-protected, or not found). It doesn't render its own app-in-chat component; it's used by the Manage Customer Service vocabulary editor.

### Response type

Text (per-id outcomes)

## Routing notes

Use `remove_synonyms` to delete synonyms. To add or edit synonyms use [`save_synonym`](save_synonym.md).

## Related tools

| Tool | Relationship |
|---|---|
| [`manage_service_vocabulary`](manage_service_vocabulary.md) | Opens the editor these deletes come from |
| [`save_synonym`](save_synonym.md) | Adds or updates a synonym |

## Data mutation classification

Destructive write.

Permanently deletes synonym configuration records. Managed rows are protected.
