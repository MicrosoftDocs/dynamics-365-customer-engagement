---
title: Create Activity
description: Learn how to use the Create Activity capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Create Activity

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to log a phone call, create a task, or schedule an appointment on a case or other record.

## What it does
The assistant creates a timeline activity on the record you specify. Supported activity types include:

- **Tasks** - to-do items with a subject, due date, and priority
- **Phone calls** - logged calls with direction (incoming/outgoing), duration, and notes
- **Appointments** - scheduled meetings with a start time, end time, and location
- **Emails** - quick emails (for full compose-and-review, use "draft an email" instead)

The activity appears on the record's timeline alongside notes, emails, and other activities.

## Try prompts like
- "Create a follow-up task on this case"
- "Log a phone call with the customer"
- "Schedule an appointment for next Tuesday"
- "Add a task to call the customer back by Friday"
- "Log an incoming call - 15 minutes, discussed billing issue"
- "Create a task to review the escalation"
- "Schedule a meeting with the customer at 2 PM tomorrow"
- "Log an outgoing call about the refund request"

## What you see in chat
The assistant displays the activity timeline as an app-in-chat component, refreshed to show the newly created activity in context.

## Helpful tips
- For tasks, just say the subject and due date - for example, "create a task to follow up by Friday."
- For phone calls, specify the direction (incoming or outgoing). The assistant asks for the call duration if you don't mention it.
- For appointments, include the date and time. You can also add a location.
- If you want to add a plain text note (not an activity), say "add a note" instead.
- Activities are always linked to the current record. The assistant uses the active case context.

> [!TIP]
> You can create multiple activities in sequence. After creating a task, say "also log a phone call" to add another activity.

## What happens next
After the activity is created, you can continue with prompts like:

- "Show the timeline"
- "Create another task"
- "Draft an email to the customer"
- "What tasks are open on this case?"
- "Update the case status"

## Does this change data?

Yes. This creates an activity.**

A new activity record (task, phone call, appointment, or email) is created in Dynamics 365 and linked to the record. The assistant asks for confirmation before creating the activity.

## What you can do from the app-in-chat component
From the activity timeline in chat, you can:

- See the newly created activity alongside other recent case activities
- Browse the activity history in chronological order
- Expand an activity to view its details
- Open the activity in Dynamics 365 for further editing

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Create Activity |
| Internal tool name | `create_activity` |
| Purpose | Creates a timeline activity (email, task, appointment, or phone call) associated with a Dynamics 365 record |

## Tool behavior
Creates a timeline activity (email, task, appointment, or phone call) associated with a Dynamics 365 record. Supports all standard Dataverse activity types plus tenant-provisioned custom activity types. Always associates the activity with the currently active record via `entityId`/`entityType`.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool creates data - Microsoft 365 Copilot prompts for confirmation. |
| `destructiveHint` | `false` | Creating an activity is additive, not destructive. |
| `idempotentHint` | `false` | Each call creates a new activity - not safe to retry. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Record context

| Input | Description | Required |
|---|---|---|
| `entityId`, `regardingId`, `entityType`, `regardingType`, `incident` | `entityId` or `regardingId` (record GUID, required - always pass from the active case), `entityType` or `regardingType` (entity logical name such as `incident`). Both naming pairs are accepted. | Yes |

### Activity type

| Input | Description | Required |
|---|---|---|
| `activityType` | `activityType` (required - e.g. `phonecall`, `task`, `appointment`, `email`, or any tenant-provisioned Dataverse activity logical name). | Yes |

### Common fields

| Input | Description | Required |
|---|---|---|
| `subject`, `description` | `subject` (activity subject line), `description` (body/description). | No |

### Task-specific

| Input | Description | Required |
|---|---|---|
| `dueDate`, `priority`, `low`, `normal`, `high` | `dueDate` (ISO 8601), `priority` (`low`, `normal`, `high`). | No |

### Phone call-specific

| Input | Description | Required |
|---|---|---|
| `phoneNumber`, `direction`, `incoming`, `outgoing`, `duration` | `phoneNumber`, `direction` (`incoming` or `outgoing`), `duration` (minutes - always confirm with user if not specified). | No |

### Appointment-specific

| Input | Description | Required |
|---|---|---|
| `scheduledStart`, `scheduledEnd`, `location` | `scheduledStart` and `scheduledEnd` (ISO 8601), `location`. | No |

### Email-specific

| Input | Description | Required |
|---|---|---|
| `to`, `cc`, `bcc`, `send` | `to`, `cc`, `bcc` (arrays of entity references or email strings), `send` (true to send immediately, false for draft). | No |

### Draft update

| Input | Description | Required |
|---|---|---|
| `activityId`, `fieldValues` | `activityId` (existing activity GUID for updates), `fieldValues` (additional field values from quick-create form). | No |

## Response and UI behavior
This tool renders the activity timeline to confirm the activity was created.

This MCP tool is supported by an MCP app.

### Response type

Interactive component (app-in-chat)

The timeline widget refreshes to show the newly created activity in the feed.

## Routing notes
Use `create_activity` for:

- "Create a task", "log a call", "schedule an appointment"
- Any timeline activity creation (phone call, task, appointment, email)
- Custom activity types provisioned in the tenant

Don't use `create_activity` when:

- The user wants to add a plain text note - use `create_note` (`note` is not a valid activityType)
- The user wants to compose and review an email before sending - use `draft_email`
- The user wants to send an email immediately - use `send_email`

## Related tools
| Tool | Relationship |
|---|---|
| [`create_note`](create_note.md) | Creates a note (annotation) - not a timeline activity |
| [`get_activity_timeline`](get_activity_timeline.md) | Retrieves the full activity timeline for a record |
| [`get_activity_quick_create_form`](get_activity_quick_create_form.md) | Returns form metadata for activity types |
| [`draft_email`](draft_email.md) | Opens email compose for review (preferred for email flows) |
| [`send_email`](send_email.md) | Sends email immediately |

## Data mutation classification
Write / mutation.

This tool creates a new activity record in Dataverse. Microsoft Copilot prompts the user for confirmation before execution.
