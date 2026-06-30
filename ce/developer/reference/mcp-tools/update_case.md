---
title: Update Case
description: Learn how to use the Update Case capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Update Case

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to change a field on a support case, such as its priority, title, description, or other details.

## What it does
The assistant updates one or more fields on a case record. You can change the priority level using plain language, or update any other case field by specifying what you want to change. The assistant confirms which fields were updated after the change is applied.

## Try prompts like
- "Set the priority of CAS-01010-A0A0A0 to high"
- "Change the title of this case to Login issue"
- "Update the description on this case"
- "Set priority to low"
- "Mark this case as waiting for details"
- "Change the customer on case CAS-01010-A0A0A0"

## What you see in chat
The assistant confirms the update with a text response listing the fields that were changed. No interactive component is displayed for this action.

## Helpful tips
- You can refer to the case by its case number (for example, CAS-01010-A0A0A0) or let the assistant use the case you're already working with.
- For priority changes, use "high", "normal", or "low".
- You can update multiple fields in a single request.
- If you want to close a case, use "close this case" instead - that's a separate action with a resolution record.

> [!TIP]
> Open the case first with "show me case CAS-01010-A0A0A0" to review the current fields before updating.

## What happens next
After updating, you can continue with prompts like:

- "Show me this case"
- "Summarize this case"
- "What's the SLA status on this case?"
- "Reassign this case to Alex"

## Does this change data?

Yes. This changes data.

The case record is updated in Dynamics 365. The change takes effect immediately.

## Prerequisites

This tool requires the following:

- Customer service representative role

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Update Case |
| Internal tool name | `update_case` |
| Purpose | Updates one or more fields on a support case |

## Tool behavior
Updates one or more fields on a support case. Supports typed shortcuts for common fields like priority, and a generic `fields` map for arbitrary Dataverse logical-name to value updates including title, description, customer, and status reason.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | The update is non-destructive (fields are overwritten, not deleted). |
| `idempotentHint` | `true` | Calling with the same inputs produces the same result. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Case identifier

| Input | Description | Required |
|---|---|---|
| `incidentId`, `caseNumber` | `incidentId` (GUID) or `caseNumber` (e.g. CAS-01010-A0A0A0). At least one is required. When `caseNumber` is provided, the server resolves it to a GUID. | Yes |

### Priority shortcut

| Input | Description | Required |
|---|---|---|
| `priority`, `high`, `normal`, `low` | `priority` (enum: `high`, `normal`, `low`). Convenience parameter for the most common field update. | No |

### Arbitrary fields

| Input | Description | Required |
|---|---|---|
| `fields` | `fields` (record of Dataverse logical-name to value pairs). Used by the form widget for inline editing of individual fields, or for any field not covered by the typed shortcuts. | No |

## Response and UI behavior
This MCP tool is supported by an MCP app.

### Response type

Text confirmation

The tool returns a text confirmation of the updated fields. No interactive component is rendered.

## Routing notes
Use `update_case` for:

- Any field change on a case record (priority, title, description, status reason, custom fields)
- Inline edits from the case form widget

Don't use `update_case` when:

- **Closing/resolving a case** - route to `close_case` (uses the Dataverse CloseIncident action)
- **Reassigning a case** - route to `reassign_case` (handles ownership transfer and handover notes)
- **Updating a non-case entity** - route to `update_entity_record`

## Related tools
| Tool | Relationship |
|---|---|
| [`get_case`](get_case.md) | Opens the case form for inspection before editing |
| [`close_case`](close_case.md) | Resolves and closes a case (uses CloseIncident, not a field update) |
| [`reassign_case`](reassign_case.md) | Reassigns a case to another user, team, or queue |
| [`list_cases`](list_cases.md) | Lists cases to find the one to update |
| [`summarize_case`](summarize_case.md) | Opens the case with an AI summary for triage before editing |

## Data mutation classification
Write / mutation.

Updates one or more fields on the case record in Dataverse. The operation is idempotent - calling with the same inputs produces the same result.
