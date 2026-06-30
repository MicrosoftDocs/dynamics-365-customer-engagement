---
title: Activity Quick-Create Form
description: Learn how to use the Activity Quick-Create Form capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Activity Quick-Create Form

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to see what fields are available on an activity form before creating an activity. This is helpful when you want to know what information you can include on a task, phone call, or appointment.

## What it does
The assistant retrieves the form layout for a specific activity type and shows the available fields, sections, and options. This tells you what information you can fill in when creating that type of activity. For example, a task form shows fields like subject, due date, and priority, while a phone call form shows fields like phone number, direction, and duration.

## Try prompts like
- "What fields can I set on a task?"
- "Show me the phone call form fields"
- "What fields are available on an appointment?"
- "What does the task form look like?"

## What you'll see in chat
The assistant displays the form layout as an app-in-chat component within the timeline widget, showing the available fields and options for the requested activity type.

## Helpful tips
- This is most useful when you want to know exactly what details you can capture before creating an activity.
- You don't need to use this before creating an activity - you can always say "create a task" directly and the assistant guides you through the required fields.
- The available fields may vary depending on your organization's Dynamics 365 configuration.

> [!TIP]
> If you already know what activity you want to create, skip this step and say "create a task" or "log a phone call" directly.

## What happens next
After seeing the form fields, you can continue with prompts like:

- "Create a task with those fields"
- "Log a phone call"
- "Schedule an appointment"

## Does this change data?
**No, viewing form fields does not change data.**

This only shows the form layout and available fields. Creating an activity is a separate step.

## What you can do from the app-in-chat component
From the quick-create form in chat, you can:

- Fill in the activity details (subject, description, due date, priority)
- Select the activity type (task, phone call, appointment)
- Save the new activity directly from the form without opening Dynamics 365
- Continue working in chat immediately after saving

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Activity Quick-Create Form |
| Internal tool name | `get_activity_quick_create_form` |
| Purpose | Returns quick-create form metadata (sections, fields, option sets) for a Dynamics 365 activity type |

## Tool behavior
Returns quick-create form metadata (sections, fields, option sets) for a Dynamics 365 activity type. The `get_activity_timeline` widget calls this to render dynamic forms for creating activities. Use when the user explicitly asks what fields are available on a specific activity type in their organization.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool only returns metadata - no data is modified. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Activity type

| Input | Description | Required |
|---|---|---|
| `activityType` | `activityType` (required - activity type logical name, e.g. `phonecall`, `task`, `appointment`, or any tenant-provisioned activity type). | Yes |

### Regarding context

| Input | Description | Required |
|---|---|---|
| `regardingId`, `entityId`, `regardingType`, `entityType` | `regardingId` or `entityId` (record GUID), `regardingType` or `entityType` (entity logical name). Both naming pairs are accepted. Optional - provides context for form rendering. | No |

## Response and UI behavior
This tool renders form metadata within the activity timeline widget.

This MCP tool is supported by an MCP App. 

### Response type

Interactive component (app-in-chat)

The widget displays the quick-create form layout with fields, sections, and option sets for the requested activity type.

## Routing notes
Use `get_activity_quick_create_form` for:

- "What fields can I set on a [activity type]?"
- Internal widget use - the timeline widget calls this to render dynamic forms

Don't use `get_activity_quick_create_form` when:

- The user wants to create an activity directly - use `create_activity`
- The user wants to view the timeline - use `get_activity_timeline`

## Related tools
| Tool | Relationship |
|---|---|
| [`create_activity`](create_activity.md) | Creates an activity using the fields defined by this form metadata |
| [`get_activity_timeline`](get_activity_timeline.md) | Displays the timeline and hosts the quick-create form |

## Data mutation classification
Read-only.

This tool only returns form metadata. No data is modified.
