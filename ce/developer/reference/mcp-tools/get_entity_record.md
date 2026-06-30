---
title: View Entity Record
description: Learn how to use the View Entity Record capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# View Entity Record

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to see the full details of a specific record for any Dataverse entity type that does not have its own dedicated view command.

## What it does
The assistant opens a detailed form view for the record you specify. You can see all record fields, edit supported fields inline, and navigate to the full form in Dynamics 365. This works for any entity type, including opportunities, leads, queue items, and custom tables.

For accounts, contacts, and cases, the assistant uses specialized tools with richer behavior. This tool is the fallback for everything else.

## Try prompts like
- "Open opportunity for Contoso deal"
- "Show lead details for Maria Garcia"
- "View the queue item record"
- "Open this appointment record"
- "Show me the custom entity record"
- "View this task"

## What you'll see in chat
The assistant displays an interactive record form as an app-in-chat component. The form shows the record's fields as defined by the Dynamics 365 system form configuration.

## Helpful tips
- You can use a record name or GUID to open a specific record.
- You need to specify the entity type, for example "open opportunity for Project Alpha."
- For accounts, say "open account Contoso" instead. For contacts, say "open contact Jordan." For cases, say "open case CAS-01010-A0A0A0."

> [!TIP]
> After the record form appears, you can ask follow-up questions like "update this record" or "delete this record."

## What happens next
After the record form appears, you can continue with prompts like:

- "Update a field on this record"
- "Delete this record"
- "List more records like this"
- "Search for related records"

## Does this change data?
**No, viewing a record does not change data.**

The record form is read-only by default. Inline edits from the form can change data. The assistant asks for confirmation before making changes.

## What you can do from the app-in-chat component
From the record form in chat, you can:

- Review all record form fields
- Edit supported fields inline
- Open the full record form in Dynamics 365
- Continue working with the record in chat using follow-up prompts

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | View Entity Record |
| Internal tool name | `get_entity_record` |
| Purpose | Retrieves a single record for any Dataverse entity in a form-driven detail view with inline editing |

## Tool behavior
Retrieves a single record for any Dataverse entity in a form-driven detail view with inline editing. Use for entity types not covered by `get_account`, `get_contact`, or `get_case`, such as opportunities, leads, or custom tables.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | Not set | Read-only in practice; this tool does not modify data directly. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Entity type

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | `entityLogicalName` (string, required). The Dataverse entity logical name. | Yes |

### Record identifier

| Input | Description | Required |
|---|---|---|
| `recordId` | `recordId` (string, required). Record GUID or primary name to search for. | Yes |

### Form selection

| Input | Description | Required |
|---|---|---|
| `formId` | `formId` (string, optional). A system form GUID to use for rendering. | No |

## Response and UI behavior
This tool renders an interactive app-in-chat entity form.

This MCP tool is supported by an MCP App. 

### Response type

Interactive form (detail view)

The form displays the record's fields as defined by the selected system form.

## Routing notes
Use `get_entity_record` for:

- Any entity type without a dedicated detail tool
- "open [entity type] [name]", "show [entity type] details"

Don't use `get_entity_record` when the prompt explicitly says:

- **An account** - route to `get_account`
- **A contact** - route to `get_contact`
- **A case** - route to `get_case`
- **"List" records** - route to `list_entity_records`

## Related tools
| Tool | Relationship |
|---|---|
| [`list_entity_records`](list_entity_records.md) | Lists records for the same entity type |
| [`update_entity_record`](update_entity_record.md) | Updates fields on any entity record |
| [`delete_entity_record`](delete_entity_record.md) | Deletes any entity record |
| [`get_account`](get_account.md) | Dedicated account detail tool |
| [`get_contact`](get_contact.md) | Dedicated contact detail tool |
| [`get_case`](get_case.md) | Dedicated case detail tool |

## Data mutation classification
Read-only entry point with downstream mutation potential.

The form view itself does not change data. Inline edits trigger write operations via `update_entity_record`.
