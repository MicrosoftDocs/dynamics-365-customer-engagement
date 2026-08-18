---
title: Manage Customer Service vocabulary
description: Admins open an in-chat editor to add, edit, or delete the glossary terms and column synonyms the Customer Service question-answering skill uses.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Manage Customer Service vocabulary

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you administer how the assistant interprets your organization's wording—the glossary terms and column synonyms behind the Customer Service question-answering skill.

## What it does

The assistant opens an in-chat admin view with two tabs:

- **Glossary**—company terms and their plain-language definitions (for example, "P1" or "deflection").
- **Synonyms**—alternate words that map to a specific Dataverse column on an in-scope table (for example, "handler" means the case owner).

From the view you can add new entries, edit your own entries, and delete them. Out-of-the-box managed entries are shown but can't be changed.

## Try prompts like

- Manage Customer Service vocabulary.
- Add a glossary term.
- Edit a synonym.
- Which glossary terms are defined?

## What you'll see in chat

The assistant displays an interactive editor as an app-in-chat component with a Glossary tab and a Synonyms tab. Each tab lists the current entries in a table with edit and delete actions, plus an Add button.

## Helpful tips

- Use your organization's real terms—the assistant recognizes them after you add them.
- Managed (out-of-the-box) entries show a lock badge and can't be edited or deleted.
- Add synonyms only for tables that are already in the question-answering scope. Use "manage customer service dv qna" to change which tables are in scope.

## What happens next

After you add or change vocabulary, the assistant uses it the next time someone asks a data question. Continue with prompts like:

- Add a synonym for the owner column.
- Delete the P1 glossary term.

## Does this change data?

**Opening the editor doesn't change data. Saving or deleting an entry does.**

Adding, editing, or deleting glossary terms and synonyms writes to configuration in Dataverse. The assistant asks for confirmation before deleting.

## What you can do from the app-in-chat component

From the editor in chat, you can:

- Switch between the Glossary and Synonyms tabs.
- Add a new glossary term or synonym.
- Edit one of your own (unmanaged) entries.
- Delete your own (unmanaged) entries—one at a time.
- See which entries are managed and read-only.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. Editing vocabulary requires the maker customize privilege (`prvmsdyn_ServiceAgentMakerCustomize`). The Customer Service question-answering (CustomerServiceQnA) skill must be set up in the environment; otherwise there's nothing to manage.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Manage Customer Service vocabulary |
| Internal tool name | `manage_service_vocabulary` |
| Purpose | Opens the maker admin widget (or returns a text summary) for the glossary terms and column synonyms bound to the CustomerServiceQnA skill |

## Tool behavior

Loads the glossary terms, column synonyms, and in-scope tables for the CustomerServiceQnA skill and renders them in an editor. Read-only itself; the add/edit/delete actions call the companion save and remove tools. Takes an optional `action` (`open` renders the widget, `list` returns a text summary).

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | The launcher itself only reads; edits happen through the companion tools. |
| `destructiveHint` | Not set | Not applicable (read-only launcher). |
| `idempotentHint` | Not set | Not applicable (read-only launcher). |
| `openWorldHint` | Not set | Uses default (reads configuration from Dataverse). |

## Input concepts

### Action

| Input | Description | Required |
|---|---|---|
| `action` | `open` (default) renders the editor widget; `list` returns a text summary of the vocabulary. | No |

## Response and UI behavior

This tool renders an interactive app-in-chat editor.

This MCP tool is supported by an MCP app.

### Response type

Interactive editor (tabbed tables)

The editor shows the glossary terms and synonyms with add, edit, and delete actions.

## Routing notes

Use `manage_service_vocabulary` when an admin wants to view or change glossary terms or synonyms.

Don't use `manage_service_vocabulary` for:

- Answering a data question—use [`answer_service_question`](answer_service_question.md).
- Changing which tables are in scope—use [`manage_customer_service_dv_qna`](manage_customer_service_dv_qna.md).

## Related tools

| Tool | Relationship |
|---|---|
| [`save_glossary_term`](save_glossary_term.md) | Adds or updates a glossary term |
| [`remove_glossary_terms`](remove_glossary_terms.md) | Deletes glossary terms |
| [`save_synonym`](save_synonym.md) | Adds or updates a column synonym |
| [`remove_synonyms`](remove_synonyms.md) | Deletes synonyms |
| [`manage_customer_service_dv_qna`](manage_customer_service_dv_qna.md) | Manages which tables the skill can answer from |

## Data mutation classification

Read-only entry point with downstream mutation potential.

Opening the editor doesn't change data. The add, edit, and delete actions from the editor write configuration through separate tools.
