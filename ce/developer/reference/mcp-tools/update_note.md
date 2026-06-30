---
title: Update Note
description: Learn how to use the Update Note capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Update Note

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to fix a typo, add information, or revise an existing note on a case or other record.

## What it does
The assistant finds an existing note by its identifier and updates the text with your new content. The updated note replaces the previous version on the record's timeline. This is useful for correcting mistakes or adding details to a note you created earlier.

## Try prompts like
- "Fix the typo in my note"
- "Update the note to say the customer confirmed the workaround"
- "Change the note on this case"
- "Revise my last note"
- "Update the note text to include the new phone number"

## What you'll see in chat
The assistant displays the activity timeline as an app-in-chat component, refreshed to show the updated note content.

## Helpful tips
- The assistant needs to know which note to update. If there are multiple notes, specify by content or title.
- You can say "update the note" and then provide the new text, or include everything in one prompt.
- Only notes you own can be updated.
- If you want to add a completely new note instead of editing an existing one, say "add a note."

> [!TIP]
> View the timeline first to see existing notes, then tell the assistant which one to update.

## What happens next
After the note is updated, you can continue with prompts like:

- "Show the timeline"
- "Add another note"
- "Draft an email to the customer"
- "What else needs to be done on this case?"

## Does this change data?
**Yes, this updates an existing note.**

The note text is replaced with the new content you provide. The assistant asks for confirmation before making the change.

## What you can do from the app-in-chat component
From the timeline in chat, you can:

- See the updated note in context
- Browse the full activity timeline
- Select any activity to view its details
- Open the full record form in Dynamics 365

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Update Note |
| Internal tool name | `update_note` |
| Purpose | Updates the text of an existing note (annotation) in Dynamics 365 by its annotation GUID |

## Tool behavior
Updates the text of an existing note (annotation) in Dynamics 365 by its annotation GUID. Use when the user wants to fix a typo, revise, or amend an existing note. The `annotationId` can be obtained from the `get_activity_timeline` response.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data - Microsoft 365 Copilot prompts for confirmation. |
| `destructiveHint` | `false` | Updating a note replaces content but is not destructive. |
| `idempotentHint` | `true` | Calling with the same inputs produces the same result - safe to retry. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Note identifier

| Input | Description | Required |
|---|---|---|
| `annotationId` | `annotationId` (annotation GUID to update, required). Obtain from `get_activity_timeline`. | Yes |

### Updated content

| Input | Description | Required |
|---|---|---|
| `notetext`, `subject` | `notetext` (updated note body text, required), `subject` (optional updated title). | Varies |

## Response and UI behavior
This tool renders the activity timeline to confirm the note was updated.

This MCP tool is supported by an MCP App. 

### Response type

Interactive component (app-in-chat)

The timeline widget refreshes to show the updated note content.

## Routing notes
Use `update_note` for:

- "Fix the note", "update the note", "revise the note"
- Any edit to an existing annotation's text or title

Don't use `update_note` when:

- The user wants to create a new note - use `create_note`
- The user wants to update a timeline activity (task, phone call, etc.) - use `create_activity` with `activityId`

## Related tools
| Tool | Relationship |
|---|---|
| [`create_note`](create_note.md) | Creates a new note on a record |
| [`get_activity_timeline`](get_activity_timeline.md) | Retrieves timeline including notes (source of annotationId) |
| [`create_activity`](create_activity.md) | Creates timeline activities (not annotations) |

## Data mutation classification
Write / mutation.

This tool updates an existing annotation record in Dataverse. M365 Copilot prompts the user for confirmation before execution. The operation is idempotent - retrying with the same inputs produces the same result.
