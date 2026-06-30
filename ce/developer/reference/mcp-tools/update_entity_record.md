---
title: Update Entity Record
description: Learn how to use the Update Entity Record capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Update Entity Record

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to change a field value on any Dataverse record directly from chat.

## What it does
The assistant updates one or more fields on a record you specify. This works for any entity type, including accounts, contacts, opportunities, leads, and custom tables. You tell the assistant which record to update and what fields to change, and it applies the update directly in Dynamics 365.

For case-specific updates, the assistant uses a dedicated case update tool that has richer validation. This tool is the general-purpose fallback for all other entity types.

## Try prompts like
- "Update the phone number on the Contoso account"
- "Change Jordan's job title to Senior Engineer"
- "Set the estimated revenue on this opportunity to 50000"
- "Update the email address on this contact"
- "Change the status on this lead to qualified"
- "Set the description field on this record"

## What you'll see in chat
The assistant displays the updated record as an interactive form in chat, showing the fields after the update has been applied.

## Helpful tips
- Be specific about which field to change and what the new value should be.
- The assistant asks for confirmation before applying updates.
- You can update multiple fields in a single request, for example "change the phone to 555-0100 and the city to Seattle."
- For case updates, just describe the change naturally. The assistant picks the right tool.

> [!TIP]
> After the update is applied, the assistant shows you the updated record so you can verify the change.

## What happens next
After the update is applied, you can continue with prompts like:

- "Show this record again"
- "Update another field"
- "List records for this entity type"
- "Open this record in Dynamics 365"

## Does this change data?
**Yes, this updates Dataverse record data.**

The assistant applies the field changes directly to the Dataverse record. The assistant asks for confirmation before making changes.

## What you can do from the app-in-chat component
From the updated record form in chat, you can:

- Confirm the update was applied correctly
- Review the record's current field values
- Continue working with the record in chat using follow-up prompts

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Update Entity Record |
| Internal tool name | `update_entity_record` |
| Purpose | Updates one or more fields on any Dataverse entity record by GUID |

## Tool behavior
Updates one or more fields on any Dataverse entity record by GUID. Use when domain-specific update tools (such as `update_case`) do not cover the requested field or entity, or when the entity has no dedicated update tool. Works for accounts, contacts, opportunities, leads, custom tables, and any other Dataverse entity.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | This tool updates data without hard-delete behavior. |
| `idempotentHint` | `true` | Repeated calls with the same input have the same final effect. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Entity type

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | `entityLogicalName` (string, required). The Dataverse entity logical name (e.g. `account`, `contact`, `opportunity`). | Yes |

### Record identifier

| Input | Description | Required |
|---|---|---|
| `recordId` | `recordId` (string, required). The record GUID to update. | Yes |

### Field updates

| Input | Description | Required |
|---|---|---|
| `fields` | `fields` (key-value map, required). A map of field logical names to new values. Example: `{ "telephone1": "555-0100", "jobtitle": "Senior Engineer" }`. | Yes |

## Response and UI behavior
This tool renders an interactive app-in-chat form showing the updated record.

This MCP tool is supported by an MCP App. 

### Response type

Interactive form (detail view)

The form displays the record after the update has been applied.

## Routing notes
Use `update_entity_record` for:

- Updating fields on any entity type without a dedicated update tool
- Updating fields not covered by domain-specific update tools

Don't use `update_entity_record` when:

- **Updating case fields** - prefer `update_case` for case-specific fields
- **Deleting a record** - route to `delete_entity_record`

## Related tools
| Tool | Relationship |
|---|---|
| [`get_entity_record`](get_entity_record.md) | View a record before or after updating |
| [`get_account`](get_account.md) | View an account record before or after updating |
| [`get_contact`](get_contact.md) | View a contact record before or after updating |
| [`delete_entity_record`](delete_entity_record.md) | Deletes a record instead of updating it |
| [`update_case`](update_case.md) | Dedicated case update tool with case-specific logic |

## Data mutation classification
Write operation (non-destructive, idempotent).

This tool modifies data. Updates are applied directly to the Dataverse record. The operation is idempotent; repeated calls with the same input produce the same result.
