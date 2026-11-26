---
title: View Workforce Engagement Management requests
description: Use the WEM agent to view Workforce Engagement Management requests, such as time-off requests, in an interactive list in chat.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=wem
ms.service: dynamics-365-customer-service
author: prashas
ms.author: prashas
ms.reviewer: laalexan
---

# View Workforce Engagement Management requests

**Applies to:** Dynamics 365 Customer Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to review Workforce Engagement Management (WEM) requests—time-off, shift-swap, and shift-bid—in chat without leaving the conversation.

## What it does

The assistant shows a list of WEM requests that match your filters. It covers all three request types—time-off, shift-swap, and shift-bid. You can filter by:

- Request type (time-off, shift-swap, shift-bid). Name a type to see only that type; ask for "all requests" to see every type.
- Your own requests or accessible team requests.
- A date range, and whether the range applies to the requested window or the created date.
- Request status (draft, in review, canceled, approved, rejected, pending approval, accepted, fulfilled, expired).
- Result count.

By default, it shows all requests you can access, of **every type**, across all dates and statuses. Add a type, timeframe, status, or "my requests" to narrow them. Results appear in an interactive list inside chat.

## Try prompts like

- Show all my pending requests (every type).
- Pending time-off requests.
- Open shift swaps for my team.
- My shift bids this month.
- Show approved requests for my team in August.

## What you'll see in chat

The assistant displays an interactive request list as an app-in-chat component. The list shows matching requests with key details such as name, agent, request type, status, and created date.

## Helpful tips

- By default you see all requests you can access; say "my requests" to narrow to only your own.
- Add a timeframe such as "this week," "next week," or "in August" to filter by the requested dates, or say "created in the last two weeks" to filter by submitted date.
- Add a status word (such as pending, approved, or rejected) to narrow the list; omit it to see all statuses.

> [!TIP]
> After the list appears, select a row to open the full request form, or ask a follow-up question about any request shown.

## What happens next

After the list appears, you can continue with prompts like:

- Open the first request.
- Show only pending approvals.
- Show these for my team instead.
- Show approved requests instead.

## Does this change data?

**No, listing requests doesn't change data.**

The request list is read-only. Selecting a request from the list opens its record in a form view; the list itself doesn't modify data.

## What you can do from the app-in-chat component

From the request list in chat, you can:

- Scan and review matching requests in a sortable grid.
- Select a request to open its full form view.
- Continue working with the request in chat using follow-up prompts.

## Prerequisites

This tool is available on the Dynamics 365 CX MCP Server—Workforce Engagement Management. See the availability note at the top of this page for details. Workforce Engagement Management must be enabled, and the signed-in user must have read access to WEM requests.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | View Workforce Engagement Management requests |
| Internal tool name | `list_wem_requests` |
| Purpose | Lists Workforce Engagement Management requests (time-off, shift-swap, shift-bid) filtered by request type, scope, status, and date, and renders them in an interactive grid-style app-in-chat experience |

## Tool behavior

Lists active Dataverse `msdyn_wemrequest` rows. When `requestType` is omitted, the tool returns **all** request types (time-off, shift-swap, shift-bid); when supplied, it filters to the named type(s). When neither `from` nor `to` is supplied, the tool applies no date filter (all dates), and when `status` is omitted it applies no status filter (all active statuses). It otherwise defaults to `dateBasis: requested` (which window field a supplied date range filters on—not a default date range), **team scope** (all requests the caller can access), and a maximum of 25 results. For `scope: self`, the query filters rows to the signed-in user (owner); for the default `scope: team`, it relies on Dataverse and WEM security to return only rows the caller can read.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Request type

| Input | Description | Required |
|---|---|---|
| `requestType` | Array of `time_off`, `shift_swap`, `shift_bid`. Omit to include all types (for example, "show all requests"); pass for example, `['time_off']` for time-off only, `['shift_swap']` for swaps. | No |

### Scope

| Input | Description | Required |
|---|---|---|
| `scope` | `self` or `team`. **Defaults to `team`**—everything you can access. A neutral "show requests" returns all accessible requests; only "**my** requests" narrows to `self` (requests you own). | No |

### Status

| Input | Description | Required |
|---|---|---|
| `status` | Array of `draft`, `in_review`, `canceled`, `approved`, `rejected`, `pending_approval`, `accepted`, `fulfilled`, `expired`. Omit to include all statuses. | No |

### Date range

| Input | Description | Required |
|---|---|---|
| `from`, `to` | Inclusive ISO 8601 datetimes. Omit both to apply no date filter (all dates); a single bound filters open-ended on the other side. | No |
| `dateBasis` | `requested` filters by the request's window; `created` filters by when the request was submitted. Defaults to `requested`. | No |

### Result limit

| Input | Description | Required |
|---|---|---|
| `top` | Integer maximum number of requests to return. Defaults to 25, capped at 200. | No |

## Response and UI behavior

This tool renders an interactive app-in-chat request grid.

This MCP tool is supported by an MCP app.

### Response type

Interactive grid (list view)

The grid displays name, agent, request type, status, and created date. Users can select a row to open the request's form view.

## Routing notes

Use `list_wem_requests` for:

- my time-off requests, open shift swaps, my shift bids (pass `requestType`).
- show all my requests, pending requests for my team (omit `requestType` → all types).
- Status- or date-based filtering of WEM requests.

Don't use `list_wem_requests` when the prompt asks for cases, accounts, or other non-WEM records.

## Related tools

| Tool | Relationship |
|---|---|
| Entity-grid record view | Selecting a row opens the request's record in the entity-grid form view. |

## Data mutation classification

Read-only.

The listing doesn't change data; opening a request shows its record in a form view.
