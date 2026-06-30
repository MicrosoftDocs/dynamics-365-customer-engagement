---
title: View Email
description: Learn how to use the View Email capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# View Email

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to read the full content of an email - its subject, body, sender, and recipients - directly in chat.

## What it does
The assistant fetches a specific email from Dynamics 365 and displays it inside chat. You can see the full email body, who sent it, who received it, and which customer account it's linked to. A link to the email in Dynamics 365 is also provided.

## Try prompts like
- "Open the email from the customer"
- "Show me that email"
- "What does the email say?"
- "View the email about the login issue"
- "Read the latest email on this case"
- "Open the unlinked email"

## What you see in chat

The assistant displays the email as an app-in-chat component showing the full email body, subject, sender, recipients, and timestamps. A direct link to the email in Dynamics 365 is included.

## Helpful tips
- If you don't know which email to open, say "show me the email about [topic]" or "find the email from [person]" to search first.
- You can reply directly from the email view - just say "reply to this email."
- If the email body appears empty, it means the original email was sent without body content.

> [!TIP]
> After viewing an email, you can take action on it. Say "reply to this email", "link this to the case", or "create a case from this email."

## What happens next
After the email appears, you can continue with prompts like:

- "Reply to this email"
- "Forward this to my manager"
- "Link this email to the case"
- "Create a case from this email"
- "Summarize this email"

## Does this change data?

No. Viewing an email doesn't change data.

This only reads and displays the email content. Replying, forwarding, or linking are separate actions that may change data.

## What you can do from the app-in-chat component
From the email view in chat, you can:

- Read the full email body and metadata
- See sender and recipient details
- Open the email in Dynamics 365
- Reply, reply all, or forward the email
- Link the email to a case or create a case from it

## Prerequisites
This tool requires the following:

- Email is configured.

Learn more in [Configure email](/dynamics365/customer-service/administer/customer-service-hub-user-guide-email-admin).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | View Email |
| Internal tool name | `view_email` |
| Purpose | Fetches and displays the full content of a Dataverse email activity — subject, body, sender, recipients, and linked customer account |

## Tool behavior
Fetches and displays the full content of a Dataverse email activity — subject, body, sender, recipients, and linked customer account. Returns the body as plain text in `structuredContent.body` and a direct Dynamics 365 deep link in `structuredContent.deepLink`. Use for reading or reviewing any email by its activityId GUID.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Email identifier

| Input | Description | Required |
|---|---|---|
| `activityId` | `activityId` (the Dataverse email activity GUID to view, required). | Yes |

## Response and UI behavior
This tool renders an interactive email view.

This MCP tool is supported by an MCP app.

### Response type

Interactive component (app-in-chat)

The widget displays the email subject, body, sender, recipients, timestamps, and linked customer context. A Dynamics 365 deep link is provided for navigating to the full email form.

## Routing notes
Use `view_email` for:

- "Open the email", "show me the email", "what does the email say"
- Viewing any email by activityId
- Reading an email before replying or forwarding

Don't use `view_email` when:

- The user wants to search for emails without a known activityId — use `list_emails`
- The user wants to compose a new email — use `draft_email`
- The user wants to edit a draft — use `edit_email_draft`

## Related tools
| Tool | Relationship |
|---|---|
| [`list_emails`](list_emails.md) | Searches emails by subject or sender to find the activityId |
| [`draft_email`](draft_email.md) | Opens compose form for a new email |
| [`edit_email_draft`](edit_email_draft.md) | Opens an existing draft for editing |
| [`send_email`](send_email.md) | Sends an email immediately |
| [`link_email_to_case`](link_email_to_case.md) | Links the viewed email to an existing case |
| [`create_case_from_email`](create_case_from_email.md) | Creates a new case from the viewed email |
| [`match_cases`](match_cases.md) | Finds existing cases that may match the email |

## Data mutation classification
Read-only.

This tool only reads and displays email data. No data is modified.
