---
title: List Entity Records
description: Learn how to use the List Entity Records capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# List Entity Records

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to browse records for any Dataverse entity type that does not have its own dedicated list command, such as opportunities, leads, queue items, or custom tables.

## What it does
The assistant shows a list of records for the entity type you specify. You can search by name and limit the number of results. This is the general-purpose record listing tool that works for any entity type in your Dynamics 365 environment.

For accounts, contacts, and cases, the assistant uses specialized tools that offer richer filtering. This tool is the fallback for everything else.

## Try prompts like
- "Show all queue items"
- "List opportunities"
- "List leads"
- "Show my custom entity records"
- "Browse open opportunities"
- "List all appointments"
- "Show task records"

## What you'll see in chat
The assistant displays an interactive record list as an app-in-chat component. The list shows matching records with their primary name and key columns.

## Helpful tips
- You need to specify the entity type, for example "list opportunities" or "show leads."
- Use a name to search for specific records, for example "list opportunities for Project Alpha."
- For accounts, say "list accounts" instead. For contacts, say "list contacts." For cases, say "list cases."
- The maximum number of results is 200.

> [!TIP]
> After the record list appears, you can ask follow-up questions about any record shown. For example, "open the first record" or "update this record."

## What happens next
After the list appears, you can continue with prompts like:

- "Open the first record"
- "Show details for this record"
- "Update a field on this record"
- "Delete this record"

## Does this change data?
**No, listing records does not change data.**

The record list is read-only. Follow-up actions from the list, such as updating or deleting a record, can change data. The assistant asks for confirmation before making changes.

## What you can do from the app-in-chat component
From the record list in chat, you can:

- Scan and review matching records in a sortable grid
- Select a record to see more details
- Open the full record form in Dynamics 365
- Continue working with the record in chat using follow-up prompts

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | List Entity Records |
| Internal tool name | `list_entity_records` |
| Purpose | Retrieves records for any Dataverse entity in a sortable, filterable grid |

## Tool behavior
Retrieves records for any Dataverse entity in a sortable, filterable grid. Use for entity types that do not have a dedicated list tool, such as opportunities, leads, queue items, or custom tables. For core entity types (account, contact, case, knowledge), use the named list tool instead.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | Not set | Read-only in practice; this tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Entity type

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | `entityLogicalName` (string, required). The Dataverse entity logical name (e.g. `opportunity`, `lead`, `queueitem`). | Yes |

### Search

| Input | Description | Required |
|---|---|---|
| `search` | `search` (string, optional). Free-text search across the primary name attribute of the entity. | No |

### Result limit

| Input | Description | Required |
|---|---|---|
| `top` | `top` (integer, optional). Maximum records to return. Defaults to the org page-size setting (25 unless an admin changed it), max 200. | No |

## Response and UI behavior
This tool renders an interactive app-in-chat entity grid.

This MCP tool is supported by an MCP App. 

### Response type

Interactive grid (list view)

The grid displays records with their primary name and key columns. Users can select a row to drill into record detail via `get_entity_record`.

## Routing notes
Use `list_entity_records` for:

- Any entity type without a dedicated list tool (opportunities, leads, queue items, custom tables)
- "list [entity type]" where [entity type] is not account, contact, case, knowledge, or evaluation

Don't use `list_entity_records` when the prompt explicitly says:

- **Accounts** - route to `list_accounts`
- **Contacts** - route to `list_contacts`
- **Cases** - route to `list_cases`
- **Knowledge articles** - route to `search_knowledge_articles`
- **Evaluations** - route to `list_evaluations`
- **Free-text search across entities** - route to `search_entities`
- **A single record's form view** - route to `get_entity_record`

## Related tools
| Tool | Relationship |
|---|---|
| [`get_entity_record`](get_entity_record.md) | Opens the form view for a single record from the grid |
| [`update_entity_record`](update_entity_record.md) | Updates fields on any entity record |
| [`delete_entity_record`](delete_entity_record.md) | Deletes any entity record |
| [`search_entities`](search_entities.md) | Free-text search across entity types |
| [`list_accounts`](list_accounts.md) | Dedicated account list with account-specific filters |
| [`list_contacts`](list_contacts.md) | Dedicated contact list with contact-specific filters |
| [`list_cases`](list_cases.md) | Dedicated case list with case-specific filters |

## Data mutation classification
Read-only entry point with downstream mutation potential.

The listing itself does not change data. Follow-up actions from the grid (update, delete) can trigger write operations via separate tools.
