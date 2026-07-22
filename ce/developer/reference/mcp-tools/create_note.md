---
title: Create Note
description: Learn how to use the Create Note capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Create Note

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to add a note to a case, account, or other record. Notes are free-form text entries that appear on the record's timeline.

## What it does
The assistant creates a note (annotation) and attaches it to the record you specify. The note appears on the record's activity timeline alongside emails, phone calls, and tasks. Notes are useful for recording internal observations, customer interactions, or follow-up reminders.

## Try prompts like
- "Add a note to this case"
- "Log a note that the customer called back"
- "Save a note saying we need to follow up"
- "Add a note: contacted the customer via phone, issue is with SSO login"
- "Record a note on this account"
- "Note: customer confirmed the workaround is working"

## What you see in chat

The assistant displays the activity timeline as an app-in-chat component, refreshed to show your newly created note in context with other activities on the record.

## Helpful tips
- Just type the note content naturally - the assistant creates the note with your text.
- You can include a title by saying something like "add a note titled 'Follow-up needed' with text..."
- Notes are different from tasks. If you need a trackable action item with a due date, say "create a task" instead.
- Notes are attached to the current record context. If you need to add a note to a different record, specify which one.

> [!TIP]
> After creating a note, you can update it later by saying "update the note" or "fix the typo in my note."

## What happens next

After the note is created, you can continue with prompts like:

- "Add another note"
- "Create a follow-up task"
- "Show the timeline"
- "Draft an email to the customer"

## Does this change data?

Yes. This creates a note.

A new note (annotation) is created in Dynamics 365 and attached to the record. The assistant asks for confirmation before creating the note.

## What you can do from the app-in-chat component
From the timeline in chat, you can:

- See your new note alongside other activities
- Browse the full activity timeline
- Select any activity to view its details
- Open the full record form in Dynamics 365

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Create Note |
| Internal tool name | `create_note` |
| Purpose | Creates a note (annotation) on a Dynamics 365 record |

## Tool behavior
Creates a note (annotation) on a Dynamics 365 record. Annotations are free-form text entries attached to a record's timeline. Use when the user asks to add a note, log a note, or save text as a note on a case, account, or other entity. For tasks, emails, phone calls, or appointments, use `create_activity` instead — those are timeline activities, not annotations.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool creates data — Microsoft 365 Copilot prompts for confirmation. |
| `destructiveHint` | `false` | Creating a note is additive, not destructive. |
| `idempotentHint` | `false` | Each call creates a new note — not safe to retry. |
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

- "Add a note", "log a note", "save a note"
- Free-form text annotations attached to a record

Don't use `create_note` when:

- The user wants to create a task, phone call, appointment, or email — use `create_activity`
- The user wants to update an existing note — use `update_note`
- The user wants to view the timeline — use `get_activity_timeline`

## Related tools
| Tool | Relationship |
|---|---|
| [`update_note`](update_note.md) | Updates the text of an existing note |
| [`create_activity`](create_activity.md) | Creates timeline activities (tasks, phone calls, appointments, emails) |
| [`get_activity_timeline`](get_activity_timeline.md) | Retrieves the full activity timeline for a record |

## Data mutation classification
Write / mutation.

This tool creates a new annotation record in Dataverse. Microsoft 365 Copilot prompts the user for confirmation before it runs.
