---
title: Delete Entity Record
description: Learn how to use the Delete Entity Record capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Delete Entity Record

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you need to permanently remove a record from Dynamics 365, such as a note, email, task, or other entity.

## What it does
The assistant deletes a specific record from Dynamics 365. This works for any entity type, including notes, emails, phone calls, tasks, appointments, and custom entities. The assistant asks for confirmation before deleting.

> [!IMPORTANT]
> This is a hard delete. There is no undo. Once a record is deleted, it cannot be recovered.

## Try prompts like
- "Delete this note"
- "Remove the email record"
- "Delete the phone call activity"
- "Remove this task"
- "Delete the appointment"
- "Remove this record"

## What you'll see in chat
The assistant confirms the record was deleted with a confirmation message in chat.

## Helpful tips
- The assistant always asks for confirmation before deleting.
- Make sure you have the right record before confirming. Deletion cannot be undone.
- You must have delete privileges on the entity type in Dynamics 365.
- If you want to deactivate a record instead of deleting it, say "deactivate this record" instead.

> [!TIP]
> If you are unsure about deleting, view the record first by saying "show this record" to confirm it is the right one.

## What happens next
After the record is deleted, you can continue with prompts like:

- "List records for this entity type"
- "Create a new note"
- "Show my cases"

## Does this change data?
**Yes, this permanently deletes data.**

The record is removed from Dynamics 365 and cannot be recovered. The assistant asks for confirmation before proceeding.

## What you can do from the app-in-chat component
After deletion, the component shows a confirmation. No further actions are available on the deleted record.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Delete Entity Record |
| Internal tool name | `delete_entity_record` |
| Purpose | Deletes a Dataverse record by entity logical name and record ID |

## Tool behavior
Deletes a Dataverse record by entity logical name and record ID. Works for notes, emails, phone calls, tasks, appointments, and any other entity type. This is a hard delete with no undo. The user must have delete privileges on the record's owning entity.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `true` | This tool performs a hard delete. |
| `idempotentHint` | `true` | Repeated calls with the same input have the same final effect. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Entity type

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | `entityLogicalName` (string, required). The Dataverse entity logical name (e.g. `annotation`, `email`, `task`, `phonecall`, `appointment`). | Yes |

### Record identifier

| Input | Description | Required |
|---|---|---|
| `recordId` | `recordId` (string, required). The record GUID to delete. | Yes |

## Response and UI behavior
This tool renders a confirmation in the app-in-chat component.

This MCP tool is supported by an MCP App. 

### Response type

Confirmation message

The response confirms the record was deleted. The deleted record cannot be recovered.

## Routing notes
Use `delete_entity_record` for:

- Any prompt that explicitly asks to delete, remove, or discard a record
- Inline delete actions from grid or form widgets

Don't use `delete_entity_record` when:

- **Closing a case** - route to `close_case`
- **Deactivating a record** - use `update_entity_record` to set state code
- **Updating or editing** - route to `update_entity_record`

## Related tools
| Tool | Relationship |
|---|---|
| [`get_entity_record`](get_entity_record.md) | View a record before deleting |
| [`update_entity_record`](update_entity_record.md) | Update a record instead of deleting |
| [`create_note`](create_note.md) | Creates a note; delete reverses this action |
| [`create_activity`](create_activity.md) | Creates an activity; delete reverses this action |

## Data mutation classification
Write operation (destructive, idempotent).

This tool performs a hard delete on the Dataverse record. There is no undo. The operation is idempotent; deleting an already-deleted record has no additional effect.
