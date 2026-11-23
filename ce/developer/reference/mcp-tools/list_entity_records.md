---
title: List entity records
description: Learn how to use the List entity records capability in Dynamics 365 Customer Service, Sales, and Field Service.
ms.date: 11/19/2026
ms.topic: reference
ai-usage: ai-assisted
ms.custom: mcp-enabled-namespaces=service,sales,field-service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# List entity records

**Applies to:** Dynamics 365 Customer Service, Dynamics 365 Sales, and Dynamics 365 Field Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to browse records for any Dataverse entity type that doesn't have its own dedicated list command, such as opportunities, leads, queue items, or custom tables.

## What it does

The assistant shows a list of records for the entity type you specify. You can search by name, limit the number of results, scope the list to records related to another record, or select a named Dataverse saved view. These capabilities are available across the products in the **Applies to** line, subject to tool availability, your privileges, and Dataverse metadata. The agent discovers the tool's inputs at runtime; Field Service doesn't require a separate static manifest update for relationship or saved-view prompting.

For accounts, contacts, and cases, the assistant uses specialized tools that offer richer filtering. This tool is the fallback for everything else.

## Try prompts like

- Show all queue items.
- List opportunities.
- List leads.
- Show my custom entity records.
- Browse open opportunities.
- Show visa applications related to this contact.
- List inspections related to this asset.
- List all appointments.
- Show task records.
- Show the "My Open Opportunities" view of opportunities.

## What you'll see in chat

The assistant displays an interactive record list as an app-in-chat component. The list shows matching records with their primary name and key columns.

## Helpful tips

- You need to specify the entity type, for example "list opportunities" or "show leads."
- Use a name to search for specific records, for example "list opportunities for Project Alpha."
- To list related records, identify the source record and the target table, for example "show visa applications related to this contact." The assistant resolves the relationship from your Dataverse metadata.
- If more than one relationship connects the tables, the assistant asks which relationship to use instead of guessing.
- For a self-referential relationship, the result includes both immediate sides of that relationship: the source record's parent and its direct children.
- Give a saved view's name, for example "show the Active Leads view of leads." The view must be visible to you. If a system view and a personal view share the name, the assistant asks which one you mean. If no view matches, the assistant says so instead of showing the default list.
- A view's own filters, sort order, and columns are used. If column metadata is unavailable or can't fit the request budget, the list keeps the view's filters and sort order but shows the primary name only when the view selects it without an alias; otherwise, it uses a record ID column. A name search can't be combined with a view.
- A saved view and a relationship scope can't be used together. Choose the saved view or ask for records related to another record.
- Additional readable columns, whether requested or configured, must already be selected by the saved view. Otherwise, choose columns the view selects, edit the view, or omit the view selector; the assistant won't rewrite the view to add columns.
- For accounts, say "list accounts" instead. For contacts, say "list contacts." For cases, say "list cases."
- The default is your organization's page-size setting (25 unless configured otherwise), bounded to 1–200 even when guarded capacity is enabled.
- The usual maximum is 200. When guarded capacity is enabled and finite delivery budgets are configured, eligible standard Dataverse tables support requests up to 5,000 records. Elastic, virtual, and unclassified tables retain the usual maximum.
- When `viewName` or `viewId` selects a saved view, the maximum remains 200 even when guarded capacity is enabled. A lower row limit configured in the view still applies. Selected saved views don't support server continuation.
- A response can contain fewer records than requested because of delivery budgets. When `pageInfo.nextCursor` is present and guarded capacity is enabled, use it with the same entity, relationship scope, search, columns, and result limit to continue.

### Saved-view selection problems

The assistant reports a selection problem instead of silently showing the default list:

| Selection problem | Recovery |
|---|---|
| `ambiguous` — several caller-visible views match the name | Choose a returned view ID and retry. |
| `inaccessible` — neither saved-view source is readable | Check your access with an administrator, or omit the view selector for ordinary listing. |
| `mismatched` — the name and ID don't identify the same view | Use the correct matching pair, or provide only the name or ID. |
| `not_found` — no caller-visible view matches | Check the entity type, exact view name or GUID, and your access. |
| `unusable` — the view has no usable FetchXML, columns, or record IDs | Choose another view, or ask an administrator to repair it. Views that omit record IDs can't support record actions in the grid. |

> [!TIP]
> After the record list appears, you can ask follow-up questions about any record shown. For example, "open the first record" or "update this record."

## What happens next

After the list appears, you can continue with prompts like:

- Open the first record.
- Show details for this record.
- Update a field on this record.
- Delete this record.

## Does this change data?

**No, listing records doesn't change data.**

The record list is read-only. Follow-up actions from the list, such as updating or deleting a record, can change data. The assistant asks for confirmation before making changes.

## What you can do from the app-in-chat component

From the record list in chat, you can:

- Scan and review matching records in a sortable grid.
- Select a record to see more details.
- Open the full record form in Dynamics 365.
- Continue working with the record in chat using follow-up prompts.

## Prerequisites

This tool is available for the products listed in the Applies to line at the top of this page. Ordinary listing within the usual 200-record maximum requires no additional configuration.

Requests above 200 records require an administrator to enable guarded capacity, configure complete finite delivery budgets, and configure the server's continuation-cursor signing secret. Expanded retrieval applies only to eligible standard Dataverse tables.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | List entity records |
| Internal tool name | `list_entity_records` |
| Purpose | Retrieves records for any Dataverse entity in a sortable, filterable grid |

## Tool behavior

Retrieves records for any Dataverse entity in a sortable, filterable grid. Use for entity types that don't have a dedicated list tool, such as opportunities, leads, queue items, or custom tables. For core entity types (account, contact, case, knowledge), use the named list tool instead.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | Not set | Read-only in practice; this tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Entity type

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | `entityLogicalName` (string, required). The Dataverse entity logical name (for example, `opportunity`, `lead`, `queueitem`). | Yes |

### Search

| Input | Description | Required |
|---|---|---|
| `search` | `search` (string, optional). Free-text search across the primary name attribute of the entity. | No |

### Saved view

| Input | Description | Required |
|---|---|---|
| `viewName` | `viewName` (string, optional). Exact name of a system or personal saved view for the entity. Can't be combined with `search`. | No |
| `viewId` | `viewId` (string, optional). GUID of a system or personal saved view visible to the caller, for example `11111111-1111-4111-8111-111111111111`. When both `viewName` and `viewId` are given, they must identify the same view. | No |

### Result limit

| Input | Description | Required |
|---|---|---|
| `top` | `top` (integer, optional). Maximum records to return, minimum 1. Defaults to the organization page-size setting (25 unless changed). Maximum 200 normally, or 5,000 for eligible standard tables when guarded capacity and delivery budgets are configured. Selected saved views remain capped at 200; a lower FetchXML `count` or `top` defined by the view takes precedence. | No |

### Business columns

| Input | Description | Required |
|---|---|---|
| `columns` | Up to 50 attribute logical names to include alongside configured columns. The combined identity, view and requested projection cannot exceed 100 unique attributes. Unknown or unreadable attributes are omitted; lookup names are normalized. Secured null or masked values aren't returned. | No |

### Related record scope

| Input | Description | Required |
|---|---|---|
| `relatedTo.entityLogicalName` | Source table logical name, such as `contact` or a custom table logical name. | Yes, when `relatedTo` is provided |
| `relatedTo.recordId` | GUID of the source record whose related target records should be listed. | Yes, when `relatedTo` is provided |
| `relatedTo.relationshipSchemaName` | Dataverse relationship schema name. Supply this only when more than one relationship connects the source and target tables. | No |

The server validates the table names and GUID, then resolves the lookup relationship
from Dataverse metadata. Raw OData filters, expansions, and navigation paths aren't
accepted. The initial contract supports one-hop lookup-backed 1:N and N:1
relationships. N:N relationships aren't supported.

### Continuation

| Input | Description | Required |
|---|---|---|
| `cursor` | Opaque value from `pageInfo.nextCursor`. Keep the entity, relationship scope, search, columns, and result limit unchanged. Requires guarded capacity; the cursor is scoped to the caller, organization, and query. Can't be combined with `viewName` or `viewId`. | No |

## Response and UI behavior

This tool renders an interactive app-in-chat entity grid.

This MCP tool is supported by an MCP app.

### Response type

Interactive grid (list view)

The grid displays records with their primary name and key columns. Users can select a row to drill into record detail through `get_entity_record`.

Model-visible rows include identifiers, names, and the authorized selected business
fields, so callers without a widget can use the same result.

| Response field | Meaning |
|---|---|
| `rows[].fields` | Authorized selected scalar values. Numbers, booleans, nulls, GUIDs in identifier or lookup fields, and valid DateTime strings remain raw; other strings are fenced for model consumption. |
| `rows[].displayFields` | Authorized formatted labels, such as lookup names and choice labels, separately fenced for model consumption. |
| `returnedCount` | Records in the delivered window, not the matching collection total. |
| `pageInfo` | Delivered counts and continuation for guarded standard-table responses when expansion is enabled. |

The widget uses "Records returned: {count}" for the delivered window.
Disabling guarded capacity rejects continuation requests
even when delivery budgets remain configured. Initial legacy-size reads retain
those safeguards but never split into an unusable continuation: a window that
exceeds the response budget fails explicitly.

Capacity depends on readable table and field metadata. A missing or invalid
delivery budget rejects guarded requests rather than silently dropping records.
Support for 5,000 is a request maximum, not a guarantee that every payload fits in
one response or every host.

If a custom table's descriptor lookup confirms that the table doesn't exist,
the tool stops before reading records and asks you to check the table name.
This guidance also takes precedence when an expanded-capacity metadata check
fails before the descriptor lookup finishes.
Failures reading optional view or column metadata don't establish that a table
is missing. Other descriptor failures retain the usual listing fallback; the
compact three-request path requires complete, readable descriptor and column
metadata; optional view metadata can degrade.

## Routing notes

Use `list_entity_records` for:

- Any entity type without a dedicated list tool (opportunities, leads, queue items, custom tables).
- Records from one table that are related to a specific record from another standard or custom table.
- list [entity type] where [entity type] is not account, contact, case, knowledge, or evaluation.

Don't use `list_entity_records` when the prompt explicitly says:

- **Accounts**—route to `list_accounts`.
- **Contacts**—route to `list_contacts`.
- **Cases**—route to `list_cases`.
- **Knowledge articles**—route to `search_knowledge_articles`.
- **Evaluations**—route to `list_evaluations`.
- **Free-text search across entities**—route to `search_entities`.
- **A single record's form view**—route to `get_entity_record`.

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

The listing itself doesn't change data. Follow-up actions from the grid (update, delete) can trigger write operations through separate tools.
