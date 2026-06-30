---
title: SLA Triage — query cases by SLA status
description: Learn how to find cases by SLA status and triage cases that are breached or at risk.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# SLA Triage — query cases by SLA status

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to see which of your cases are at risk of breaching or have already breached their SLA commitments.

## What it does
The assistant shows cases filtered by their SLA status. By default, it shows the actionable set: cases that have already breached SLA and cases that are nearing breach. You can narrow the view to just breached or just at-risk cases, filter by priority, scope to your queues or a specific queue, and set time windows like "breaching in the next 4 hours."

Results appear in an interactive SLA triage grid inside chat.

## Try prompts like
- "Show me cases at risk of SLA breach"
- "Which cases have breached SLA?"
- "Show cases breaching in the next 4 hours"
- "What needs my attention?"
- "Show high-priority at-risk cases"
- "What SLAs did I miss this month?"
- "Show actionable SLA cases in my queues"
- "Cases with noncompliant First Response By"

## What you see in chat

The assistant displays an interactive SLA triage grid as an app-in-chat component. The grid shows cases with their SLA KPI status (breached, at-risk, in-progress), breach time, time remaining, and case priority. Cases are sorted by urgency (most urgent first) by default.

## Helpful tips
- Say "at risk" for the combined breached + at-risk view (the default), or be specific with "breached" or "at risk of breaching" to narrow.
- You can combine filters: "high-priority cases breaching in the next 4 hours."
- Use "in my queues" to see both your assigned cases and unassigned queue items.
- Say "what SLAs did I miss this month?" to review historical breaches.
- For the SLA detail on a single case, ask "what's the SLA on CAS-X?" instead.

> [!TIP]
> Start your day with "what needs my attention?" to get a quick SLA triage view of your most urgent cases.

## What happens next
After seeing the SLA triage view, you can continue with prompts like:

- "Summarize the first case"
- "What changed on this case?"
- "Reassign this case to Alex"
- "Show more cases"
- "What's the SLA detail on this case?"

## Does this change data?

No. Viewing SLA status doesn't change data.

The SLA triage grid is read-only. Follow-up actions from the grid, such as reassigning or closing a case, can change data. The assistant asks for confirmation before making changes.

## What you can do from the app-in-chat component
From the SLA triage grid in chat, you can:

- Browse cases sorted by SLA urgency
- See which KPIs are breached, at-risk, or on track
- View breach time and remaining time for each case
- Select a case to drill into its details
- Ask for more results with "show more"

## Prerequisites
This tool requires the following:

- SLAs to be defined

Learn more in [Define service-level agreements](/dynamics365/customer-service/administer/define-service-level-agreements).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | SLA Triage — query cases by SLA status |
| Internal tool name | `query_cases_by_sla_status` |
| Purpose | Returns cases matching an SLA filter, scoped to the current user's assigned cases, their queues, or a specific queue |

## Tool behavior
Returns cases matching an SLA filter, scoped to the current user's assigned cases, their queues, or a specific queue. The default view returns the actionable set (breached + at-risk cases). Supports narrowing by specific SLA status, time window, case priority, KPI name, and recency filters. Renders an interactive SLA triage grid with pagination.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Scope

| Input | Description | Required |
|---|---|---|
| `scope`, `assigned_to_me`, `my_queues`, `queue` | `scope` (enum: `assigned_to_me`, `my_queues`, `queue`). Defaults to `assigned_to_me`. Use `my_queues` to include queue cases not picked by another CSR. Use `queue` with `queueId` for a specific queue. | No |

### Queue filter

| Input | Description | Required |
|---|---|---|
| `queueId` | `queueId` (GUID). Required when scope is `queue`, ignored otherwise. | Yes |

### SLA status filter

| Input | Description | Required |
|---|---|---|
| `status`, `noncompliant`, `nearing_noncompliance`, `in_progress` | `status` (enum: `noncompliant`, `nearing_noncompliance`, `in_progress`). Narrows to a specific KPI status. Omit for the default actionable set (breached + at-risk). | No |

### Widening

| Input | Description | Required |
|---|---|---|
| `includeOnTrack` | `includeOnTrack` (boolean). When true, widens the default set to also include on-track cases. Ignored when `status` is set. | No |

### Breach time window

| Input | Description | Required |
|---|---|---|
| `timeWindowHours` | `timeWindowHours` (integer, 1-168). Only KPIs whose breach time is within the next N hours. | No |

### Recency filters

| Input | Description | Required |
|---|---|---|
| `createdWithinDays`, `resolvedWithinDays` | `createdWithinDays` (integer) for case creation date, `resolvedWithinDays` (integer) for resolved/cancelled cases. | No |

### KPI name

| Input | Description | Required |
|---|---|---|
| `kpiName` | `kpiName` (string). Filters to a specific KPI (e.g. "First Response By", "Resolve By"). | No |

### Case priority

| Input | Description | Required |
|---|---|---|
| `casePriority`, `high`, `normal`, `low` | `casePriority` (enum: `high`, `normal`, `low`). Filters by case priority level. | No |

### Sort order

| Input | Description | Required |
|---|---|---|
| `sortBy`, `time_remaining`, `case_priority` | `sortBy` (enum: `time_remaining`, `case_priority`). Defaults to most urgent first. | No |

### Resolved cases

| Input | Description | Required |
|---|---|---|
| `includeResolved` | `includeResolved` (boolean). When true, includes resolved/cancelled cases for historical review. | No |

### Pagination

| Input | Description | Required |
|---|---|---|
| `limit`, `cursor`, `nextCursor` | `limit` (integer, 1-50, default 50) and `cursor` (opaque token from previous response's `nextCursor`). | No |

## Response and UI behavior
This tool renders an interactive SLA triage grid.

This MCP tool is supported by an MCP app.

### Response type

Interactive grid (app-in-chat)

The grid displays cases with SLA KPI status, breach time, time remaining, and case priority. Supports pagination via cursor.

## Routing notes
Use `query_cases_by_sla_status` when:

- The prompt mentions SLA, breach, at-risk, noncompliance, "breaching soon", or "time remaining"
- The user wants an SLA-driven triage view across multiple cases
- The user says "what needs my attention" or "urgent cases"

Don't use `query_cases_by_sla_status` when:

- **Single case SLA detail** - route to `get_case_sla_status`
- **General case listing** (by status, priority, owner) - route to `list_cases`
- **Personal inbox** - route to `list_case_inbox_workitems`

## Related tools
| Tool | Relationship |
|---|---|
| [`get_case_sla_status`](get_case_sla_status.md) | Shows SLA KPI detail for a single case |
| [`list_cases`](list_cases.md) | Lists cases by status, priority, or owner without SLA context |
| [`list_case_inbox_workitems`](list_case_inbox_workitems.md) | Shows the agent's personal inbox of assigned cases |
| [`summarize_case`](summarize_case.md) | Opens a case with an AI summary for triage |
| [`get_case_highlights`](get_case_highlights.md) | Activity digest and triage signals for a specific case |

## Data mutation classification
Read-only.

The tool queries SLA KPI instances and case records without modifying any data.
