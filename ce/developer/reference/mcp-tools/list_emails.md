---
title: List / search emails
description: Learn how to use the List / search emails capability in Dynamics 365 Customer Service, Sales, and Field Service.
ms.date: 11/19/2026
ms.topic: reference
ai-usage: ai-assisted
ms.custom: mcp-enabled-namespaces=service,sales,field-service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# List / search emails

**Applies to:** Dynamics 365 Customer Service, Dynamics 365 Sales, and Dynamics 365 Field Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to find a specific email or browse recent emails on a case or in your mailbox.

## What it does

The assistant searches your Dynamics 365 emails by subject, sender, or date range. It groups reply and forward prefixes by normalized subject, preferring an email linked to a record, then the newest email within that group. This is subject-based grouping, not conversation-ID grouping. The list returns headers only; opening an email retrieves its body and attachment details separately.

You can also scope the search to a specific case to see only emails linked to that case.

## Try prompts like

- Show me the email about login failures.
- Find the email from Sarah.
- List emails on this case.
- Show recent emails.
- Find the email with subject billing inquiry.
- Show emails from the customer.
- Check my inbox.
- Show emails from last week.

## What you'll see in chat

The assistant shows a selection grid with email subjects, senders, and dates. Select an email to view its full content. In legacy mode, a single match instead directs the assistant to open that email.

## Helpful tips

- Search by subject works even when the email has a "RE:" or "FWD:" prefix—those are stripped automatically.
- Say "emails on this case" to see only emails linked to the current case.
- If you're looking for a specific email and get multiple results, narrow your search by adding more details like the sender or a date range.
- The default is 10 unique subject-based threads. With expanded capacity enabled, linked emails appear first, then unlinked emails, newest first within each group.
- An empty response can still have more source emails to check. It doesn't necessarily mean your search has no more unique threads.

> [!TIP]
> After finding an email in the list, select it to view the full content. Then you can reply, forward, or link it to a case.

## What happens next

After finding an email, you can continue with prompts like:

- Open the first email.
- View the email from Sarah.
- Reply to that email.
- Link this email to the case.
- Create a case from this email.

## Does this change data?

**No, searching emails doesn't change data.**

This only searches and displays email data. Actions you take after finding an email (replying, forwarding, linking) may change data.

## What you can do from the app-in-chat component

From the email list in chat, you can:

- Browse emails with subject, sender, and date.
- Select an email to read its full content in the email viewer.
- Open an email in Dynamics 365.
- Use follow-up prompts to filter by date, sender, or link emails to a case.

## Prerequisites

This tool requires the following:

- Email

Learn more in [Configure email](/dynamics365/customer-service/administer/customer-service-hub-user-guide-email-admin).

## Tool summary

| Property | Value |
|---|---|
| User-facing name | List / search emails |
| Internal tool name | `list_emails` |
| Purpose | Searches Dynamics 365 email activities by subject or sender with automatic reply-chain deduplication |

## Tool behavior

Searches Dynamics 365 email headers with automatic subject-based deduplication.
Expanded capacity retains a default of 10 and accepts `top` up to 5,000 when enabled
by the server operator. Linked emails are traversed first, then unlinked emails,
each ordered newest first with activity ID breaking timestamp ties. This preserves
linked-email preference across source pages. Blank subjects use activity ID rather
than collapsing unrelated messages.

The optional maximum is not a delivery guarantee. Response bytes, upstream-body
bytes, request count and time budgets remain finite. When a response is partial,
repeat the same filters and `top` with `pageInfo.nextCursor`. `hasMore` means more
source emails remain to inspect; it doesn't guarantee additional unique threads.
`totalFound` and `returnedCount` describe this response, not an exact mailbox total.
`sourceReadCount` counts fetched messages, including replayed pages;
`sourceConsumedCount` counts inspected messages, including duplicates.

Continuation is signed, bound to the caller, organization and query, and expires
15 minutes after traversal begins. Its deduplication state has a finite size limit.
If a row or continuation cannot fit, narrow the search rather than treating the
result as complete. Records are reauthorized and reread on every call; a changed
mailbox can invalidate a replay position. This is not a mailbox snapshot or an
unbounded export.

Legacy mode retains its 50-source-email fetch cap and rejects cursors and `top`
above 50. Expanded delivery requires operator enablement and qualified finite
budgets; callers cannot enable it with an input parameter.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Subject search

| Input | Description | Required |
|---|---|---|
| `subject` | `subject` (partial, case-insensitive match—RE:/FWD: prefixes are stripped automatically). | No |

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
| `top` | Maximum unique subject-based threads in this response, default 10, maximum 5,000 when expanded capacity is enabled. Legacy mode accepts at most 50. | No |
| `cursor` | Continuation from `pageInfo.nextCursor`. Keep the filters and `top` unchanged. Available only with expanded capacity. | No |

### Date range

| Input | Description | Required |
|---|---|---|
| `dateFrom`, `dateTo` | `dateFrom` and `dateTo` (ISO 8601 dates to constrain the time window). | No |

## Response and UI behavior

This tool renders an interactive email selection grid. Its model-visible results
also include useful subject, sender, date and record identifiers without requiring
the widget.

This MCP tool is supported by an MCP app.

### Response type

Interactive component (app-in-chat)

Guarded results retain the selection grid even for one thread. In legacy mode, a
single match directs the caller to `view_email`; it doesn't eagerly fetch the body.
Open a chosen email with `view_email` and its `activityId`. No results with no
continuation show the normal empty state; a zero-thread response with continuation
shows a partial-response status instead. Local widget pagination is unchanged.

## Routing notes

Use `list_emails` for:

- Show me the email from [person], find the email about [topic].
- Any time you need an email but lack an activityId.
- Searching both sent and received emails.
- Scoping email search to a specific case through `entityId`.

Don't use `list_emails` when:

- The user already has an activityId and wants to read it—use `view_email`.
- The user wants to see the full activity timeline (not just emails)—use `get_activity_timeline`.

## Related tools

| Tool | Relationship |
|---|---|
| [`view_email`](view_email.md) | Opens a specific email by activityId (called after selection from the grid) |
| [`draft_email`](draft_email.md) | Composes a new email |
| [`get_activity_timeline`](get_activity_timeline.md) | Shows all activity types on a record, not just emails |
| [`link_email_to_case`](link_email_to_case.md) | Links an email found through search to a case |
| [`create_case_from_email`](create_case_from_email.md) | Creates a case from a found email |

## Data mutation classification

Read-only.

This tool only searches and displays email data. No data is modified.
