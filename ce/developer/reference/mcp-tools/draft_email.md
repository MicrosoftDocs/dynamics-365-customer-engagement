---
title: Draft Email
description: Learn how to use the Draft Email capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Draft Email

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to compose an email to a customer directly from chat. The assistant can use AI to generate the email body based on your intent, apply a template, or open a blank compose form.

## What it does
The assistant opens an email compose form inside chat. When you describe what the email should be about (for example, "draft a closure email" or "write a follow-up"), the assistant uses AI to generate a relevant subject and body based on the case context and any matching templates. You can edit the content, change recipients, and send or save as a draft.

For replies and forwards, the assistant pre-fills recipients and threads the email into the existing conversation.

## Try prompts like
- "Draft an email to the customer on this case"
- "Write a case closure email"
- "Reply to the last email on this case"
- "Draft an apology email"
- "Compose a follow-up email about next steps"
- "Forward the customer's email to my manager"
- "Write a thank you email to the customer"
- "Draft a resolution email"

## What you see in chat
The assistant displays an email compose form as an app-in-chat component. The form shows the generated or pre-filled subject, body, and recipients. If AI generated the content, you'll see a template banner showing which template was used.

## Helpful tips
- Describe your intent naturally - say "draft a closure email" or "write an apology" and the assistant generates appropriate content.
- For replies, the recipients auto-fill from the case customer. You don't need to specify them.
- The AI-generated content is a starting point. Always review and edit before sending.
- If you want to compose without AI, just say "draft a blank email" or "open the email form."
- Your email signature is automatically appended.

> [!TIP]
> After the compose form appears, you can still ask the assistant for help. For example, "make it more formal" or "add a paragraph about the refund process."

## What happens next
After the compose form appears, you can continue with prompts like:

- "Send it"
- "Save as draft"
- "Add Sarah to CC"
- "Make it shorter"
- "Change the subject to 'Case Resolution'"

## Does this change data?

This step opens a compose form but does not send the email automatically.

The compose form may auto-save a draft to Dynamics 365 so it appears on the timeline. Sending the email or saving the final draft are actions you take from within the form. The assistant asks for confirmation before sending.

## What you can do from the app-in-chat component

From the compose form in chat, you can:

- Edit the email subject and body
- Add or remove recipients (To, CC, BCC)
- Switch between recommended templates using the banner dropdown
- View knowledge article sources cited by the AI
- Save the email as a draft
- Send the email directly
- Open the full email form in Dynamics 365

## Prerequisites
This tool requires the following:

- Copilot email features

Learn more in [Manage Copilot features in Customer Service](/dynamics365/customer-service/administer/configure-copilot-features).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Draft Email |
| Internal tool name | `draft_email` |
| Purpose | Opens the email compose form with AI-generated content, a template-based body, or blank fields for the user to author a new email |

## Tool behavior
Opens the email compose form with AI-generated content, a template-based body, or blank fields for the user to author a new email. The primary flow passes the user's intent phrase as `aiComposeKeywords`, which triggers server-side template matching and AI-enhanced body generation in a single round-trip. The widget auto-saves the draft to Dataverse so it appears on the record's timeline immediately.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | Microsoft 365 Copilot skips the confirmation prompt. The compose widget manages draft persistence internally. |
| `destructiveHint` | Not set | Not applicable (no destructive side effects). |
| `idempotentHint` | Not set | Not applicable (each call opens a new compose session). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Record context

| Input | Description | Required |
|---|---|---|
| `entityId`, `entityType`, `incident` | `entityId` (record GUID to associate the email with), `entityType` (entity logical name such as `incident`). For reply flows, `entityId` can be omitted when `regardingActivityId` is provided — the parent record is resolved server-side from the source email. | No |

### Reply context

| Input | Description | Required |
|---|---|---|
| `regardingActivityId`, `replyMode`, `reply`, `replyAll`, `forward` | `regardingActivityId` (the source email's activityId for reply/forward flows), `replyMode` (`reply`, `replyAll`, or `forward`). Recipients auto-fill from the case customer in reply mode. | No |

### Recipients

| Input | Description | Required |
|---|---|---|
| `to`, `cc`, `bcc`, `id`, `logicalName`, `displayName` | `to`, `cc`, `bcc` (arrays of entity references with `id`, `logicalName`, `displayName`). Pre-fill recipient fields. | No |

### Content pre-fill

| Input | Description | Required |
|---|---|---|
| `subject`, `body`, `<p>`, `<br>`, `<strong>`, `<em>`, `<ul>`, `<li>` | `subject` (fallback subject when AI returns none), `body` (fallback HTML body — uses `<p>`, `<br>`, `<strong>`, `<em>`, `<ul>`, `<li>` — no markdown). | No |

### AI compose

| Input | Description | Required |
|---|---|---|
| `aiComposeKeywords` | `aiComposeKeywords` (strongly preferred on every fresh call — the user's intent phrase verbatim, e.g. `close standard`, `apology`, `next steps`). Server matches templates by keyword and AI-enhances the body. If omitted, server derives a keyword from `subject`. If neither produces a keyword, AI compose is skipped. | No |

### Template context

| Input | Description | Required |
|---|---|---|
| `templateTitle`, `templates`, `generate_email_content`, `knowledgeSources` | `templateTitle` (template name for the compose banner), `templates` (ranked list from `generate_email_content` for template-switching dropdown), `knowledgeSources` (knowledge articles cited by AI for a Sources panel). | No |

## Response and UI behavior
This tool renders an interactive email compose form.

This MCP tool is supported by an MCP app.

### Response type

Interactive component (app-in-chat)

The compose form shows the AI-generated or template-based email body with subject, recipients, and a template banner. The user can edit content, switch templates, review knowledge sources, and send or save the draft.

## Routing notes
Use `draft_email` for:

- Any "compose", "draft", "write an email" prompt
- Reply, reply-all, or forward flows from the timeline
- AI-composed emails where the user provides an intent phrase
- Template-based email composition

Don't use `draft_email` when:

- The user wants to send immediately without review — use `send_email`
- The user wants to resume editing an existing draft — use `edit_email_draft`
- The user wants to browse template options before composing — use `recommend_email_templates` then `apply_email_template`
- The user wants AI-generated content for a specific intent without opening compose — use `generate_email_content`

## Related tools
| Tool | Relationship |
|---|---|
| [`send_email`](send_email.md) | Sends an email immediately without opening compose |
| [`edit_email_draft`](edit_email_draft.md) | Opens an existing draft for continued editing |
| [`view_email`](view_email.md) | Displays a received or sent email read-only |
| [`generate_email_content`](generate_email_content.md) | Generates AI email content for a specific intent |
| [`recommend_email_templates`](recommend_email_templates.md) | Returns ranked template recommendations for a case |
| [`apply_email_template`](apply_email_template.md) | Applies a specific template and opens compose |
| [`get_email_signature`](get_email_signature.md) | Retrieves the user's email signature (auto-appended by compose) |
| [`list_emails`](list_emails.md) | Searches emails by subject or sender |

## Data mutation classification
Read-only entry point with downstream mutation potential.

The tool itself is marked `readOnlyHint: true` — M365 Copilot does not prompt for confirmation. The compose widget auto-saves the draft to Dataverse, and the user can send from the widget, which triggers a write operation. The draft auto-save is a UX convenience initiated by the user's explicit compose request.
