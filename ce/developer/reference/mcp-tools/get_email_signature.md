---
title: Email Signature
description: Learn how to use the Email Signature capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Email Signature

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]
- "Show my email signature"
- "What does my email signature look like?"
- "Preview my signature"
- "Get my email signature"

## What you see in chat
The assistant displays your email signature as an app-in-chat component, showing the formatted signature content as it appears in outgoing emails.

## Helpful tips
- You don't need to retrieve your signature before drafting an email — the compose form includes it automatically.
- If your signature appears empty, check that a default signature is configured in your Dynamics 365 personal options.
- You can retrieve a specific signature by ID if you have multiple signatures configured.

## What happens next
After viewing your signature, you can continue with prompts like:

- "Draft an email to the customer"
- "Apply a template to this case"
- "Show my active cases"

## Does this change data?

No. Retrieving your email signature doesn't change data.**

This is a read-only preview of your existing signature configuration.

## What you can do from the app-in-chat component
From the signature preview in chat, you can take the following actions:

- Review your current email signature
- Verify the signature content and formatting

> [!NOTE]
> To change your email signature, update it in Dynamics 365 Settings. The assistant can't edit signatures directly.

## Prerequisites
This tool requires the following:

- Email

Learn more in [Configure email](/dynamics365/customer-service/administer/customer-service-hub-user-guide-email-admin).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Email Signature |
| Internal tool name | `get_email_signature` |
| Purpose | Retrieves the current user's email signature from Dynamics 365 by calling the RetrieveEmailSignature Custom API |

## Tool behavior
Retrieves the current user's email signature from Dynamics 365 by calling the RetrieveEmailSignature Custom API. Returns the signature body for preview. Email composition tools like `draft_email` auto-append the signature, so direct calls are only needed when the user explicitly asks to see their signature.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Specific signature

| Input | Description | Required |
|---|---|---|
| `signatureId` | `signatureId` (GUID of a specific signature to retrieve). If omitted, returns the user's default signature. | No |

### Sender context

| Input | Description | Required |
|---|---|---|
| `senderId`, `senderType`, `systemuser`, `queue` | `senderId` (GUID of the sender whose signature to retrieve - if omitted, defaults to the current user), `senderType` (logical name: `systemuser` for a user or `queue` for a queue). | No |

## Response and UI behavior
This tool renders the email signature in a preview widget.

This MCP tool is supported by an MCP app.

### Response type

Interactive component (app-in-chat)

The widget displays the formatted email signature body.

## Routing notes
Use `get_email_signature` for:

- "Show my signature", "preview my email signature"
- Explicit signature retrieval requests

Don't use `get_email_signature` when:

- The user is composing an email - `draft_email` auto-appends the signature
- The user wants to edit their signature - signature editing is done in Dynamics 365 settings

## Related tools
| Tool | Relationship |
|---|---|
| [`draft_email`](draft_email.md) | Auto-appends the signature during composition |
| [`send_email`](send_email.md) | Sends email (signature is managed by Dataverse) |

## Data mutation classification
Read-only.

This tool only retrieves and displays the email signature. No data is modified.
