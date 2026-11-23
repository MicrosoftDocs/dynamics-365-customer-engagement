---
title: Create note
description: Learn how to create record notes and use the observation preview and Save flow in Dynamics 365 Customer Service, Sales, and Field Service.
ms.date: 11/19/2026
ms.topic: reference
ai-usage: ai-assisted
ms.custom: mcp-enabled-namespaces=service,sales,field-service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Create note

**Applies to:** Dynamics 365 Customer Service, Dynamics 365 Sales, and Dynamics 365 Field Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to add a note to a case, account, or other record. Notes are free-form text entries that appear on the record's timeline.

## What it does

The assistant creates a note (annotation) and attaches it to the record you specify. The note appears on the record's activity timeline alongside emails, phone calls, and tasks. Notes are useful for recording internal observations, customer interactions, or follow-up reminders.

For Field Service work orders and bookings, an add-note request first prepares an editable [field observation preview](format_field_observation.md). Review its content and destination, then select **Save** in the preview to create the note. Preparation, proofreading, and destination selection don't save it. By default, replying "save it" or "looks good" in chat doesn't replace the preview's **Save** action.

## Try prompts like

- Add a note to this case.
- Log a note that the customer called back.
- Save a note saying we need to follow up.
- Add a note: contacted the customer through phone, issue is with SSO login.
- Record a note on this account.
- Note: customer confirmed the workaround is working.

## What you'll see in chat

After a note is created, the assistant can display the activity timeline as an app-in-chat component with the saved note. In the Field Service preview flow, the editable observation appears before the note is saved; review the preview's save result rather than treating preparation as confirmation that a note was created.

## Helpful tips

- Describe the note content naturally. For a Field Service work order or booking, review the prepared observation and select **Save** to persist it.
- You can include a title by saying something like "add a note titled 'Follow-up needed' with text..."
- Notes are different from tasks. If you need a trackable action item with a due date, say "create a task" instead.
- Notes are attached to the current record context. If you need to add a note to a different record, specify which one.

> [!TIP]
> After creating a note, you can update it later by saying "update the note" or "fix the typo in my note."

## What happens next

After the note is created, you can continue with prompts like:

- Add another note.
- Create a follow-up task.
- Show the timeline.
- Draft an email to the customer.

## Does this change data?

**Yes, this creates a note.**

A successful `create_note` call creates a new note (annotation) in Dynamics 365 and attaches it to the record. For the default Field Service preview flow, the preview's **Save** action invokes this write. Preparing the observation with `format_field_observation` doesn't create the annotation. Other record-note flows use their applicable confirmation experience.

## What you can do from the app-in-chat component

From the timeline in chat, you can:

- See your new note alongside other activities.
- Browse the full activity timeline.
- Select any activity to view its details.
- Open the full record form in Dynamics 365.

For a Field Service observation, use the editable preview to review the note and its destination before selecting **Save**. Follow the preview's success or error result to determine whether the write completed.

## Prerequisites

This tool is available for the products listed in the Applies to line at the top of this page, subject to the selected agent context and your permissions to create a note and attach it to the target record. The Field Service preview flow also requires the field observation capability to be available.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Create Note |
| Internal tool name | `create_note` |
| Purpose | Creates a note (annotation) on a Dynamics 365 record |

## Tool behavior

Creates a note (annotation) on a Dynamics 365 record. Annotations are free-form text entries attached to a record's timeline. Use when the user asks to add a note, log a note, or save text as a note on a case, account, or other entity. For tasks, emails, phone calls, or appointments, use `create_activity` instead—those are timeline activities, not annotations.

In the default Field Service context, route new-note requests through `format_field_observation` and let the preview's **Save** action invoke `create_note`. In a combined service context, this preview flow applies to work orders and bookings; other record types can retain the direct note-creation flow. A chat request to prepare a Field Service note isn't permission to skip its review and save step.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool creates data. Use the applicable confirmation or preview Save flow before writing. |
| `destructiveHint` | `false` | Creating a note is additive, not destructive. |
| `idempotentHint` | `false` | Each call creates a new note—not safe to retry. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Record context

| Input | Description | Required |
|---|---|---|
| `entityId`, `entityType`, `incident`, `account` | `entityId` (record GUID to attach the note to, required), `entityType` (entity logical name such as `incident` or `account`). | Yes |

### Note content

| Input | Description | Required |
|---|---|---|
| `notetext`, `subject` | `notetext` (note body text, required), `subject` (optional short title for the note). | Varies |

## Response and UI behavior

This tool renders the activity timeline to confirm the note was created.

This MCP tool is supported by an MCP app.

### Response type

Interactive component (app-in-chat)

The timeline widget refreshes to show the newly created note in the activity feed.

## Routing notes

Use `create_note` for:

- Add a note, log a note, save a note.
- Free-form text annotations attached to a record.

These are direct creation routes outside the Field Service preview flow. For a new note on a Field Service work order or booking, use `format_field_observation` first and save from its preview.

Don't use `create_note` when:

- The user wants to create a task, phone call, appointment, or email—use `create_activity`.
- The user wants to update an existing note—use `update_note`.
- The user wants to view the timeline—use `get_activity_timeline`.
- The user is preparing a new Field Service observation rather than saving a reviewed preview. Use `format_field_observation`.

## Related tools

| Tool | Relationship |
|---|---|
| [`update_note`](update_note.md) | Updates the text of an existing note |
| [`create_activity`](create_activity.md) | Creates timeline activities (tasks, phone calls, appointments, emails) |
| [`get_activity_timeline`](get_activity_timeline.md) | Retrieves the full activity timeline for a record |
| [`format_field_observation`](format_field_observation.md) | Prepares the Field Service observation preview whose Save action creates the note. |

## Data mutation classification

Write / mutation.

This tool creates a new annotation record in Dataverse. In the default Field Service flow, the user reviews the observation and selects **Save** before the write. Configuration can affect the available save experience, but preparing a preview never creates the note.
