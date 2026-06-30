---
title: Activity Timeline
description: Learn how to use the Activity Timeline capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Activity Timeline

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to see the full history of interactions on a case, account, or other record - including emails, phone calls, tasks, notes, and appointments.

## What it does
The assistant shows a chronological feed of all activities on a record. You can filter by activity type (for example, only emails or only tasks), search by keyword, filter by date range, or filter by state (open, completed, canceled). By default, the most recent activities appear first.

## Try prompts like
- "Show the timeline for this case"
- "What's the activity history on this case?"
- "Show me all emails on this case"
- "List the recent phone calls on this account"
- "Show completed activities on this case"
- "Search the timeline for billing"
- "Show the oldest activities on this case"
- "What happened on this case last week?"

## What you'll see in chat
The assistant displays an interactive activity timeline as an app-in-chat component. Activities are shown in chronological order with type icons, subjects, dates, and owners. You can expand entries to see full details.

## Helpful tips
- Say "show only emails" or "just the notes" to filter the timeline by activity type.
- Use date filters by saying something like "show activities from last week."
- The timeline shows the 30 most recent activities by default. Ask for more if needed.
- For a quick AI-generated summary of the case instead of the raw timeline, say "summarize this case."

> [!TIP]
> You can take action directly from the timeline. Click an email to read it, or use prompts like "reply to the last email" or "create a follow-up task."

## What happens next
After the timeline appears, you can continue with prompts like:

- "Open the latest email"
- "Create a task based on the last phone call"
- "Summarize what happened this week"
- "Reply to the customer's email"
- "Add a note about the follow-up"

## Does this change data?
**No, viewing the timeline does not change data.**

The timeline is read-only. Actions you take from the timeline (creating activities, replying to emails) may change data through separate tools.

## What you can do from the app-in-chat component
From the timeline in chat, you can:

- Browse activities in chronological order
- Filter by type (emails, tasks, notes, phone calls, appointments)
- Expand an activity to see its details
- Open an email to read its full content
- Create new activities (tasks, phone calls, notes) directly from the timeline
- Open the full record form in Dynamics 365

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Activity Timeline |
| Internal tool name | `get_activity_timeline` |
| Purpose | Returns the raw chronological feed of emails, tasks, notes, phone calls, and appointments for any Dynamics 365 record |

## Tool behavior
Returns the raw chronological feed of emails, tasks, notes, phone calls, and appointments for any Dynamics 365 record. Supports filtering by activity type, state, date range, free-text search, and pagination. Use when the user asks to see the activity feed, recent activity, history, or all touchpoints on a record.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Record context

| Input | Description | Required |
|---|---|---|
| `entityId`, `entityType`, `incident`, `account` | `entityId` (record GUID, required), `entityType` (entity logical name such as `incident` or `account`). | Yes |

### Pagination

| Input | Description | Required |
|---|---|---|
| `top`, `skipActivities`, `skipAnnotations` | `top` (maximum records per type, defaults to 30), `skipActivities` (number of activities to skip), `skipAnnotations` (number of annotations to skip). | No |

### Sort order

| Input | Description | Required |
|---|---|---|
| `sortOrder`, `newest`, `oldest` | `sortOrder` (`newest` or `oldest` - defaults to `newest`). | No |

### Type filter

| Input | Description | Required |
|---|---|---|
| `typeFilter` | `typeFilter` (array of activity types to include, e.g. `['email', 'task', 'note']`). Omit for all types. | No |

### State filter

| Input | Description | Required |
|---|---|---|
| `stateFilter`, `open`, `completed`, `canceled`, `scheduled` | `stateFilter` (array of states: `open`, `completed`, `canceled`, `scheduled`). Omit for all states. | No |

### Search

| Input | Description | Required |
|---|---|---|
| `searchText` | `searchText` (free-text search across subject, description, and owner fields). | No |

### Date range

| Input | Description | Required |
|---|---|---|
| `dateFrom`, `dateTo` | `dateFrom` and `dateTo` (ISO 8601 dates). | No |

### Advanced

| Input | Description | Required |
|---|---|---|
| `additionalFilter` | `additionalFilter` (OData filter conditions merged with AND). | No |

## Response and UI behavior
This tool renders an interactive activity timeline.

This MCP tool is supported by an MCP App. 

### Response type

Interactive component (app-in-chat)

The timeline widget displays activities in chronological order with type icons, subjects, dates, and owners. Users can expand entries to see details, filter by type, and navigate to individual activities.

## Routing notes
Use `get_activity_timeline` for:

- "Show the timeline", "activity history", "recent activity", "what happened on this case"
- Viewing the full chronological feed of all activity types
- Filtering by type, state, or date range

Don't use `get_activity_timeline` when:

- The user wants the case form with a pre-filtered Timeline tab (with form context) - use `get_case`
- The user wants an AI prose summary - use `summarize_case`
- The user wants triage signals - use `get_case_highlights`
- The user wants only emails - use `list_emails` for search or `view_email` for a specific email

## Related tools
| Tool | Relationship |
|---|---|
| [`get_case`](get_case.md) | Opens the case form with a built-in Timeline tab |
| [`summarize_case`](summarize_case.md) | AI-generated prose summary of case activity |
| [`get_case_highlights`](get_case_highlights.md) | Activity digest and triage signals |
| [`create_activity`](create_activity.md) | Creates a new activity on the timeline |
| [`create_note`](create_note.md) | Creates a note on the timeline |
| [`view_email`](view_email.md) | Opens a specific email from the timeline |
| [`list_emails`](list_emails.md) | Searches emails by subject or sender |

## Data mutation classification
Read-only.

This tool only reads and displays timeline data. No data is modified. Follow-up actions from the timeline widget (creating activities, opening emails) may trigger write operations via separate tools.
