---
title: Manage Customer Service DV QnA tables
description: Learn how to use the Manage Customer Service DV QnA tables capability in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Manage Customer Service DV QnA tables

**Applies to:** Dynamics 365 Customer Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to see, add, or remove the Dataverse tables that Customer Service DV QnA can answer questions from.

## What it does

The assistant opens an admin view that lists every Dataverse table currently in scope for the Customer Service DV QnA skill. From that view you can add a custom table so the skill can answer questions about it, or remove a table you previously added. Built-in tables that ship with the product are shown but locked so they can't be removed.

## Try prompts like

- Manage customer service DV QnA.
- Which tables can DV QnA answer from?
- Add a table to DV QnA.
- Let DV QnA answer from my callback queue table.
- Show the Customer Service DV QnA tables.

## What you'll see in chat

The assistant returns an interactive panel showing the tables in scope, with a short summary in the message text. Each row shows the table's display name and logical name; out-of-the-box tables are marked as built-in.

## Helpful tips

- Built-in tables are locked—only tables you added can be removed.
- Before adding a table, the panel validates that it exists and is enabled for search.
- A table that isn't enabled for the Dataverse search index can't be added until you enable it.
- You need the Service Agent Maker Customize privilege to manage tables.

## What happens next

After reviewing the list you can continue with prompts like:

- Test the cr4ae_callbackqueue table.
- Add cr4ae_callbackqueue to DV QnA.
- Remove a table from DV QnA.

## Does this change data?

**This step is read-only, but follow-up actions from it may change data.**

Opening the management panel doesn't change data. Adding or removing a table from within the panel does change which tables the skill can answer from.

## What you can do from the app-in-chat component

From the management panel in chat, you can:

- Review every table the DV QnA skill can answer from.
- Type a custom table's logical name, validate it, and add it.
- Select one or more of your added tables and remove them.
- See which tables are built-in (locked) versus customer-added (removable).

## Prerequisites

This tool requires the following:

- Dynamics 365 Customer Service MCP server to be configured. Makers using this tool need the `prvmsdyn_ServiceAgentMakerCustomize` privilege.
- The `CustomerServiceQnA` Dataverse search skill provisioned in the environment.

Learn more in [Connect to Dynamics 365 Customer Service MCP Server](/dynamics365/customer-service/administer/configure-customer-service-mcp-server).

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Manage Customer Service DV QnA tables |
| Internal tool name | `manage_customer_service_dv_qna` |
| Purpose | Opens the admin UI listing the Dataverse tables bound to the CustomerServiceQnA structured-data QnA skill |

## Tool behavior

Resolves the `CustomerServiceQnA` skill, lists the `dvtablesearchentity` rows bound to it, enriches each row with a localized table display name, and returns the scope plus a rendered admin widget. With `action: "list"` it returns the same data as a text summary without the widget. Out-of-the-box (managed) rows are flagged so the widget can lock them from removal.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Action

| Input | Description | Required |
|---|---|---|
| `action` | `open` (default) or `list`. `open` renders the management widget; `list` returns a text summary of the bound tables. | No |

## Response and UI behavior

This tool renders an interactive table-management widget.

This MCP tool is supported by an MCP app.

### Response type

App-in-chat component (action `open`) or text summary (action `list`)

The `open` action renders an interactive widget listing the bound tables with add, validate, and remove controls. The `structuredContent` carries the skill id, the bound entities (id, logical name, display name, managed flag), and the soft cap.

## Routing notes

Use `manage_customer_service_dv_qna` when:

- The user wants to view, add, or remove the tables DV QnA answers from.
- The user says "manage customer service DV QnA" or "add a table to DV QnA".

Don't use `manage_customer_service_dv_qna` when:

- The user asks a data question to be answered—route to `answer_service_question`.
- The user wants to create the custom table itself. That is done in the maker portal.

## Related tools

| Tool | Relationship |
|---|---|
| [`test_dv_qna_table`](test_dv_qna_table.md) | Validates a table before it is added |
| [`add_dv_qna_table`](add_dv_qna_table.md) | Binds a validated table to the skill |
| [`remove_dv_qna_table`](remove_dv_qna_table.md) | Removes added tables from the skill scope |
| [`answer_service_question`](answer_service_question.md) | Answers questions using the skill's bound tables |

## Data mutation classification

Read-only entry point with downstream mutation potential.

Listing the scope doesn't change data. Mutations happen only through the companion `add_dv_qna_table` and `remove_dv_qna_table` tools invoked from the widget.
