---
title: Edit Draft Email
description: Learn how to use the Edit Draft Email capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Edit Draft Email

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you have a draft email you started earlier and want to pick up where you left off. The assistant opens the existing draft in a compose form so you can continue editing, then save or send it.

## What it does
The assistant finds your most recent draft email on a case (or a specific draft you reference) and opens it in the compose form. The subject, body, recipients, and case context load from the saved draft. Any edits you make update the same draft record - no duplicate drafts are created.

## Try prompts like
- "Open my draft email"
- "Edit the draft on this case"
- "Resume my email draft"
- "Open the latest draft"
- "Edit my draft for case CAS-01010-A0A0A0"
- "Continue working on my draft"

## What you'll see in chat
The assistant displays the email compose form as an app-in-chat component, pre-filled with the draft's existing subject, body, and recipients. You can continue editing from where you left off.

## Helpful tips
- If you have multiple drafts, specify which one by mentioning the case or topic.
- Only your own drafts are shown - you can't edit another agent's draft.
- Only unsent drafts can be opened this way. If the email was already sent, use "view email" instead.
- Saving updates the same draft record - it won't create a duplicate.

> [!TIP]
> If you want to start a brand-new email instead of editing an existing draft, say "draft a new email" instead.

## What happens next
After the draft opens, you can continue with prompts like:

- "Send it now"
- "Save the draft"
- "Add a paragraph about the resolution"
- "Change the subject"

## Does this change data?

This step opens an existing draft but doesn't change data by itself.

Saving or sending the email from the compose form updates the draft record in Dynamics 365.

## What you can do from the app-in-chat component
From the compose form in chat, you can:

- Edit the email subject and body
- Add or remove recipients
- Save the updated draft
- Send the email directly
- Open the full email form in Dynamics 365

## Prerequisites
This tool requires the following:

- Copilot email features

Learn more in [Manage Copilot features in Customer Service](/dynamics365/customer-service/administer/configure-copilot-features).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Edit Draft Email |
| Internal tool name | `edit_email_draft` |
| Purpose | Opens an existing draft email in the compose form so the user can resume editing |

## Tool behavior
Opens an existing draft email in the compose form so the user can resume editing. Loads the subject, body, recipients, and regarding record from Dataverse and pre-fills the form. Save and Send operations update the same draft record — no duplicate drafts are created. Rejects non-draft emails (statecode != 0).

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | Microsoft 365 Copilot skips the confirmation prompt. The widget manages persistence. |
| `destructiveHint` | Not set | Not applicable (opens existing draft for editing). |
| `idempotentHint` | Not set | Not applicable (each call opens a compose session). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Specific draft

| Input | Description | Required |
|---|---|---|
| `activityId` | `activityId` (email activity GUID of the draft to open). Use when the user references a specific draft, such as clicking the Edit button on a draft row in the timeline. Enforces owner-equality check. | No |

### Latest draft on record

| Input | Description | Required |
|---|---|---|
| `entityId`, `entityType`, `incident` | `entityId` (parent record GUID, typically a case), `entityType` (entity logical name, defaults to `incident`). Returns the most-recently-modified draft owned by the current user on that record. | No |

### Mutual exclusivity

| Input | Description | Required |
|---|---|---|
| `activityId`, `entityId` | `activityId` and `entityId` are mutually exclusive — passing both is rejected by the handler. Exactly one must be set. | No |

## Response and UI behavior
This tool renders an interactive email compose form.

This MCP tool is supported by an MCP app.

### Response type

Interactive component (app-in-chat)

The compose form loads the draft's existing content — subject, body, recipients, and regarding context — for continued editing.

## Routing notes
Use `edit_email_draft` for:

- "Open my draft", "resume my draft", "edit the draft"
- Clicking the pencil Edit button on a draft row in the timeline
- "Open the latest draft on case X"

Don't use `edit_email_draft` when:

- The user wants to compose a new email — use `draft_email`
- The user wants to view a received or sent email (not a draft) — use `view_email`
- The user wants to send an email immediately — use `send_email`

## Related tools
| Tool | Relationship |
|---|---|
| [`draft_email`](draft_email.md) | Creates a new email draft (new compose session) |
| [`send_email`](send_email.md) | Sends an email immediately without compose review |
| [`view_email`](view_email.md) | Displays a received or sent email read-only |
| [`get_activity_timeline`](get_activity_timeline.md) | Shows the activity timeline where drafts appear |

## Data mutation classification
Read-only entry point with downstream mutation potential.

The tool is marked `readOnlyHint: true`. The compose widget manages save and send operations — updates are applied to the same draft record in Dataverse when the user selects **Save** or **Send**.
