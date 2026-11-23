---
title: Update entity record
description: Learn how to use the Update entity record capability in Dynamics 365 Customer Service, Sales, and Field Service.
ms.date: 11/19/2026
ms.topic: reference
ai-usage: ai-assisted
ms.custom: mcp-enabled-namespaces=service,sales,field-service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Update entity record

**Applies to:** Dynamics 365 Customer Service, Dynamics 365 Sales, and Dynamics 365 Field Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to change a field value on any Dataverse record directly from chat.

## What it does

The assistant updates one or more fields on a record you specify. This works for any entity type, including accounts, contacts, opportunities, leads, and custom tables. You tell the assistant which record to update and what fields to change, and it applies the update directly in Dynamics 365.

For case-specific updates, the assistant uses a dedicated case update tool that has richer validation. This tool is the general-purpose fallback for all other entity types.

## Try prompts like

- Update the phone number on the Contoso account.
- Change Jordan's job title to Senior Engineer.
- Set the estimated revenue on this opportunity to 50000.
- Update the email address on this contact.
- Change the status on this lead to qualified.
- Set the description field on this record.
- Set the parent account of this contact to Contoso.

## What you'll see in chat

The assistant confirms the update with a readable receipt. When saved details are available, the receipt identifies the record, includes related context, and shows the saved values of changed fields.

The receipt is not a full record form. If a label or saved value can't be read, the confirmation says that detail is unavailable rather than treating your requested value as proof it was saved. Large updates can omit details to keep the confirmation bounded. An unavailable or omitted detail doesn't mean the update failed.
A saved-update warning explains when refreshed values couldn't be retrieved. Some missing details can instead appear as unavailable placeholders without a warning. Don't repeat the update to retrieve confirmation; show the record again to see the latest values.

## Helpful tips

- Be specific about which field to change and what the new value should be.
- The assistant asks for confirmation before applying updates.
- You can update multiple fields in a single request, for example "change the phone to 555-0100 and the city to Seattle."
- For case updates, just describe the change naturally. The assistant picks the right tool.

> [!TIP]
> After the update is applied, review the saved details in the receipt. To inspect every field, ask the assistant to show the record again or open it in Dynamics 365. Don't repeat an update just to retrieve missing confirmation details.

## What happens next

After the update is applied, you can continue with prompts like:

- Show this record again.
- Update another field.
- List records for this entity type.
- Open this record in Dynamics 365.

## Does this change data?

**Yes, this updates Dataverse record data.**

The assistant applies the field changes directly to the Dataverse record. The assistant asks for confirmation before making changes.

## What you can do from the app-in-chat component

From the confirmation in chat, you can:

- Review the readable saved values of changed fields when they are available.
- See record and related-record context when readable details are available.
- Continue working with the record in chat using follow-up prompts.

Ask to show the record again to open its full detail view. Missing saved-field details use unavailable placeholders; unreadable related references might not appear. Omitted details are identified as omitted, not displayed as complete.

If refreshed values are unavailable after a completed update, the component tells you to retrieve the record again. It doesn't repeat the update automatically.

## Prerequisites

This tool is available for the products listed in the Applies to line at the top of this page. No additional configuration is required.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Update entity record |
| Internal tool name | `update_entity_record` |
| Purpose | Updates one or more fields on any Dataverse entity record by GUID |

## Tool behavior

Updates one or more fields on any Dataverse entity record by GUID. Use when domain-specific update tools (such as `update_case`) don't cover the requested field or entity, or when the entity has no dedicated update tool. Works for accounts, contacts, opportunities, leads, custom tables, and any other Dataverse entity.

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
| `entityLogicalName` | `entityLogicalName` (string, required). The Dataverse entity logical name (for example, `account`, `contact`, `opportunity`). | Yes |

### Record identifier

| Input | Description | Required |
|---|---|---|
| `recordId` | `recordId` (string, required). The record GUID to update. | Yes |

### Field updates

| Input | Description | Required |
|---|---|---|
| `fields` | `fields` (key-value map, required). A map of field logical names to new values. Example: `{ "telephone1": "555-0100", "jobtitle": "Senior Engineer" }`. Pass `{}` when only lookups change. | Yes |

### Lookup updates

| Input | Description | Required |
|---|---|---|
| `lookups` | `lookups` (key-value map, optional). A map of lookup column logical names to a related record name or GUID. Example: `{ "parentcustomerid": "Contoso" }`. Names are resolved to related records. If a name matches more than one record, nothing is saved and the candidates are returned so the assistant can ask which one you mean. If a name matches no record, or a lookup value is empty, nothing is saved; retry with a corrected name or the record's GUID. A lookup supplied through `lookups`, or as a bare lookup column in `fields`, can't be cleared; the editable record form can clear an optional lookup, which it sends as an `@odata.bind` field. A lookup column written in `fields` with a record GUID or name is usually resolved the same way; if Dataverse rejects it instead, the error names the lookup column so the assistant can send it in `lookups`. The owner and audit columns can't be set here; use `assign_entity` to change the owner. | No |

## Response and UI behavior

This tool renders a bounded app-in-chat confirmation of a completed update. The confirmation can include a readable record name, related context, and verified saved values for changed fields.

A reported readback warning or unavailable-value placeholder explains missing details without treating requested values as verified saved values.

This MCP tool is supported by an MCP app.

### Response type

Update confirmation receipt

Saved field values in the receipt come from readback under the signed-in user's access. Field and table labels come from shared organization metadata and can appear in a different language from the current user's preference. The receipt doesn't return every field of the updated record. Unavailable details are not replaced with raw IDs or technical field names, and a requested value is never substituted for a saved value that couldn't be read.

For large updates, the receipt keeps the first changed-field entries that fit and identifies omitted details. Later entries or individual oversized values can be left out; unavailable values aren't presented as verified. To inspect all current values, use a record-view capability such as `get_entity_record` or open the record in Dynamics 365. If no fields changed, the confirmation says so.

## Routing notes

Use `update_entity_record` for:

- Updating fields on any entity type without a dedicated update tool.
- Updating fields not covered by domain-specific update tools.

Don't use `update_entity_record` when:

- **Updating case fields**—prefer `update_case` for case-specific fields.
- **Deleting a record**—route to `delete_entity_record`.

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
