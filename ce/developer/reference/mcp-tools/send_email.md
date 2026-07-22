---
title: Send Email
description: Learn how to use the Send Email capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Send Email

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you have a finalized email and want to send it immediately without opening the compose form first. The assistant sends the email directly through Dynamics 365.

## What it does
The assistant sends an email right away using the subject, body, and recipients you provide or that were prepared in a previous step. This is for cases where you've already reviewed the content and just want it sent. No compose form opens. For replies, the email is threaded into the original conversation in Dynamics 365.

## Try prompts like
- "Send it now"
- "Just send the email"
- "Fire that off"
- "Send a reply saying we resolved the issue"
- "Send the email about the status update"

## What you see in chat

The assistant shows a text confirmation that the email was sent, including the subject and recipients. No compose form or interactive component appears.

## Helpful tips
- Use this only when the email content is ready to go. If you want to review or edit first, say "draft an email" instead.
- The assistant asks for your confirmation before sending.
- For replies, the sent email automatically threads into the existing email conversation on the case timeline.
- If you change your mind, you can't unsend an email after it's been sent.

> [!TIP]
> If you're not sure the email is ready, say "draft an email" to preview it in the compose form before sending.

## What happens next
After the email is sent, you can continue with prompts like:

- "Show the timeline for this case"
- "Add a note that I emailed the customer"
- "Close this case"
- "What's the next case?"

## Does this change data?
Yes. This sends an email.

The email is sent through Dynamics 365 and recorded as a sent activity on the case timeline. The assistant asks for confirmation before sending.

## Prerequisites
This tool requires the following:

- Email to be configured. The user must have send email privileges in Dataverse.

Learn more in [Configure email](/dynamics365/customer-service/administer/customer-service-hub-user-guide-email-admin).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Send Email |
| Internal tool name | `send_email` |
| Purpose | Sends an email immediately through Dynamics 365 without opening the compose form for review |

## Tool behavior
Sends an email immediately through Dynamics 365 without opening the compose form for review. Use only when the subject and body are already finalized and the user explicitly requests immediate send. For compose-and-review flows, use `draft_email` instead.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool sends an email — Microsoft 365 Copilot prompts for confirmation. |
| `destructiveHint` | `false` | Sending is not destructive (email can be viewed after sending). |
| `idempotentHint` | `false` | Each call sends a new email — not safe to retry. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Record context

| Input | Description | Required |
|---|---|---|
| `entityId`, `entityType` | `entityId` (record GUID to associate the email with, required), `entityType` (entity logical name). | Yes |

### Reply threading

| Input | Description | Required |
|---|---|---|
| `regardingActivityId` | `regardingActivityId` (source email's activityId for reply threading — D365 uses this to thread the sent email into the original conversation). | No |

### Recipients

| Input | Description | Required |
|---|---|---|
| `to`, `id`, `logicalName`, `displayName`, `cc`, `bcc` | `to` (required, at least one recipient — array of entity references with `id`, `logicalName`, `displayName`), `cc` (optional), `bcc` (optional). | Varies |

### Content

| Input | Description | Required |
|---|---|---|
| `subject`, `body` | `subject` (required, non-empty), `body` (required, email body text). | Yes |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. The tool returns a confirmation message with the sent email's details.

## Routing notes
Use `send_email` for:

- "Send it", "just send", "fire that off" — when content is finalized
- Immediate send without compose review

Don't use `send_email` when:

- The user wants to compose and review before sending — use `draft_email`
- The user wants to edit an existing draft — use `edit_email_draft`
- The user wants to view an email — use `view_email`

## Related tools
| Tool | Relationship |
|---|---|
| [`draft_email`](draft_email.md) | Opens compose form for review before sending |
| [`edit_email_draft`](edit_email_draft.md) | Resumes editing an existing draft |
| [`view_email`](view_email.md) | Displays a received or sent email read-only |
| [`generate_email_content`](generate_email_content.md) | Generates AI content that can feed into send_email |

## Data mutation classification
Write / mutation.

This tool sends an email through Dynamics 365 immediately. The email is created as a sent activity record in Dataverse. Microsoft 365 Copilot prompts the user for confirmation before sending.
