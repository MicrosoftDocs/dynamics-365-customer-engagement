---
title: List / Search Emails
description: Learn how to use the List / Search Emails capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# List / Search Emails

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]
- "Show me the email about login failures"
- "Find the email from Sarah"
- "List emails on this case"
- "Show recent emails"
- "Find the email with subject billing inquiry"
- "Show emails from the customer"
- "Check my inbox"
- "Show emails from last week"

## What you see in chat

If one email matches, the assistant opens it directly as an email view. If multiple emails match, the assistant shows a selection grid with email subjects, senders, and dates. Select an email from the list to view its full content.

## Helpful tips
- Search by subject works even when the email has a "RE:" or "FWD:" prefix - those are stripped automatically.
- Say "emails on this case" to see only emails linked to the current case.
- If you're looking for a specific email and get multiple results, narrow your search by adding more details like the sender or a date range.
- With no search criteria, you'll see the 10 most recent emails.

> [!TIP]
> After finding an email in the list, select it to view the full content. Then you can reply, forward, or link it to a case.

## What happens next

After finding an email, you can continue with prompts like:

- "Open the first email"
- "View the email from Sarah"
- "Reply to that email"
- "Link this email to the case"
- "Create a case from this email"

## Does this change data?

No. Searching emails doesn't change data.

This only searches and displays email data. Actions you take after finding an email, such as replying, forwarding, and linking, might change data.

## What you can do from the app-in-chat component
From the email list in chat, you can:

- Browse emails with subject, sender, date, and direction (inbound/outbound)
- Select an email to read its full content in the email viewer
- Open an email in Dynamics 365
- Use follow-up prompts to filter by date, sender, or link emails to a case

## Prerequisites
This tool requires the following:

- Email

Learn more in [Configure email](/dynamics365/customer-service/administer/customer-service-hub-user-guide-email-admin).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | List / Search Emails |
| Internal tool name | `list_emails` |
| Purpose | Searches Dynamics 365 email activities by subject or sender with automatic reply-chain deduplication |

## Tool behavior
Searches Dynamics 365 email activities by subject or sender with automatic reply-chain deduplication. RE:/FWD: prefixes are stripped and the most recent email per thread is kept. A single match returns the full `view_email` widget directly; multiple matches return a selection grid for disambiguation. With no filters, returns the 10 most recent emails.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Subject search

| Input | Description | Required |
|---|---|---|
| `subject` | `subject` (partial, case-insensitive match — RE:/FWD: prefixes are stripped automatically). | No |

### Sender filter

| Input | Description | Required |
|---|---|---|
| `from` | `from` (partial match on sender display name or email address). | No |

### Record scope

| Input | Description | Required |
|---|---|---|
| `entityId`, `entityType`, `incident` | `entityId` (GUID of a case or record to scope results to), `entityType` (entity logical name, defaults to `incident`). Pass `entityId` whenever the user asks about emails from a specific case. | No |

### Result limit

| Input | Description | Required |
|---|---|---|
| `top` | `top` (maximum unique email threads to return after deduplication, defaults to 10). | No |

### Date range

| Input | Description | Required |
|---|---|---|
| `dateFrom`, `dateTo` | `dateFrom` and `dateTo` (ISO 8601 dates to constrain the time window). | No |

## Response and UI behavior
This tool renders an interactive email selection grid or a single email view.

This MCP tool is supported by an MCP app.

### Response type

Interactive component (app-in-chat)

Single match: returns the full `view_email` widget directly. Multiple matches: returns a selection grid — wait for the user to choose, then call `view_email` with the selected activityId. No results: returns an empty state.

## Routing notes
Use `list_emails` for:

- "Show me the email from [person]", "find the email about [topic]"
- Any time you need an email but lack an activityId
- Searching both sent and received emails
- Scoping email search to a specific case via `entityId`

Don't use `list_emails` when:

- The user already has an activityId and wants to read it — use `view_email`
- The user wants to see the full activity timeline (not just emails) — use `get_activity_timeline`

## Related tools
| Tool | Relationship |
|---|---|
| [`view_email`](view_email.md) | Opens a specific email by activityId (called after selection from the grid) |
| [`draft_email`](draft_email.md) | Composes a new email |
| [`get_activity_timeline`](get_activity_timeline.md) | Shows all activity types on a record, not just emails |
| [`link_email_to_case`](link_email_to_case.md) | Links an email found via search to a case |
| [`create_case_from_email`](create_case_from_email.md) | Creates a case from a found email |

## Data mutation classification
Read-only.

This tool only searches and displays email data. No data is modified.
