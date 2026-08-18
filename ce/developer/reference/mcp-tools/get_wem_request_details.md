---
title: View a Workforce Engagement Management request
description: Use the WEM agent to open the full form view of a single Workforce Engagement Management request in chat.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=wem
ms.service: dynamics-365-customer-service
author: prashas
ms.author: prashas
ms.reviewer: laalexan
---

# View a Workforce Engagement Management request

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-wem.md)]

Use this capability when you want to see the full details of a specific Workforce Engagement Management (WEM) request directly in chat.

## What it does

The assistant opens a detailed form for a single WEM request. It supports the three WEM request types and shows the fields that matter for each:

- **Time-off requests**—time-off type, whether it's a full day, the start and end of the time off, hours, and notes.
- **Shift-bid requests**—the shift plan being bid on, along with status and review information.
- **Shift-swap requests**—both sides of the swap: the agent's shift and the shift being swapped for, with their dates, times, and hours.

You typically reach it by selecting a row from a WEM request list.

## Try prompts like

- Open the first request.
- Show the August 24 time-off request.
- View this shift swap.
- Open the selected bid request.

## What you'll see in chat

The assistant displays an interactive request form as an app-in-chat component. The form shows the request's details and header information such as the date submitted, last updated, request status, and owner.

## Helpful tips

- The easiest way to open a request is to select a row in the WEM request list.
- The form is a focused view of the request, matched to its type (time-off, shift bid, or shift swap)—WEM requests don't have an activity timeline, so none is shown.
- To see a different set of requests first, say something like "show my time-off requests this week."

> [!TIP]
> After the request form appears, you can ask a follow-up question or go back to the list to open another request.

## What happens next

After the request form appears, you can continue with prompts like:

- Go back to the list.
- Show my pending time-off approvals.
- Open the next request.

## Does this change data?

**No, viewing a request doesn't change data.**

The request form is a read-only view of the request's details.

## What you can do from the app-in-chat component

From the request form in chat, you can:

- Review the request's details, matched to its type—time-off type and dates, the shift plan being bid on, or both sides of a shift swap.
- See header information such as request status and owner.
- Continue working in chat using follow-up prompts.

## Prerequisites

This tool is available on the Dynamics 365 CX MCP Server—Workforce Engagement Management. See the availability note at the top of this page for details. Workforce Engagement Management must be enabled, and the signed-in user must have read access to WEM requests.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | View a Workforce Engagement Management request |
| Internal tool name | `get_wem_request_details` |
| Purpose | Opens the full form view of a single Workforce Engagement Management request (time-off, shift-bid, or shift-swap) |

## Tool behavior

Opens the full form view of a single Dataverse `msdyn_wemrequest` record. You can identify the record by `recordId` (its GUID) or by `requestName` (its exact name); when `recordId` is omitted, the tool looks the record up by name. If the name matches more than one request, the tool shows the matching requests in a grid—the same columns as the request list—so you can select the one to open (it never guesses); if the name matches none, it reports that no request was found. Once a single record is identified, the tool reads the request type and renders the matching Dataverse form scoped to that type's relevant details—the time-off window for a time-off request, the shift plan for a bid, or both shifts for a swap—with the core request facts presented read-only. WEM requests have no activities, so no timeline is shown.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Record identifier

Provide at least one of the following. You may supply both: if both are present, `recordId` takes precedence and `requestName` is used only when `recordId` is omitted. (For example, pass `recordId` from a `list_wem_requests` row whenever you have it.)

| Input | Description | Required |
|---|---|---|
| `recordId` | The WEM request GUID to open. Precise; wins when supplied. | No* |
| `requestName` | The exact request name (`msdyn_name`, for example, "Weekend cover swap"). Used to resolve the record when `recordId` is omitted. When the name matches more than one request, the matching requests are shown in a grid so you can select the one to open; agent-based lookup is not supported here (use `list_wem_requests` to find an agent's requests). | No* |

\* At least one of `recordId` or `requestName` is required.

### Form selection

| Input | Description | Required |
|---|---|---|
| `formId` | `formId` (string, optional). A system form GUID to use for rendering. Defaults to the request's primary main form when omitted. | No |

## Response and UI behavior

This tool renders an interactive app-in-chat request form.

This MCP tool is supported by an MCP app.

### Response type

Interactive form (detail view)

The form displays the request's details and header fields as defined by the selected system form.

## Routing notes

Use `get_wem_request_details` for:

- open this request, show the time-off request, view this shift swap, open the bid request.
- Drilling into a specific row from a WEM request list.

Don't use `get_wem_request_details` when the prompt asks to list or browse requests—route to `list_wem_requests` instead.

## Related tools

| Tool | Relationship |
|---|---|
| [`list_wem_requests`](list_wem_requests.md) | Lists WEM requests; select a row to open it here |

## Data mutation classification

Read-only.

The form view doesn't change data.
