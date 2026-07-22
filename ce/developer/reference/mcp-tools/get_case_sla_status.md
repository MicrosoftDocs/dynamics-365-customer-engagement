---
title: Case SLA Status
description: Learn how to check SLA status and remaining time for a case in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Case SLA Status

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to check the SLA status on a specific case, including how much time remains before breach.

## What it does
The assistant shows every SLA KPI linked to a case, such as First Response By and Resolve By. For each KPI, you see the current status (in progress, at risk, breached, paused, succeeded, or canceled), the breach time, warning time, time remaining, and whether the timer is paused. An overall risk level is derived from the worst KPI status.

## Try prompts like
- "What's the SLA on CAS-01010-A0A0A0?"
- "Will this case breach?"
- "How much time before SLA breach on this case?"
- "Check SLA status for CAS-01004-2F9LQX"
- "Is this case at risk of SLA breach?"
- "Show me the Resolve By KPI for this case"

## What you see in chat
The assistant displays an interactive SLA detail view as an app-in-chat component, showing all SLA KPIs linked to the case with their status and timing details.

## Helpful tips
- You can ask about a specific KPI by name, like "show me the Resolve By KPI."
- If you want to see SLA status across multiple cases, ask for "cases at risk of SLA breach" instead.
- The overall risk level is based on the worst KPI. If any one KPI is breached, the case shows as breached overall.
- Paused KPIs have their timers stopped (for example, when the case is on hold).

> [!TIP]
> Check SLA status early in your triage to prioritize cases that are closest to breaching.

## What happens next
After checking SLA status, you can continue with prompts like:

- "Summarize this case"
- "Set the priority to high"
- "Reassign this case to the escalation team"
- "What changed on this case since yesterday?"

## Does this change data?
**No, viewing SLA status does not change data.**

The SLA detail view reads existing KPI data without modifying anything.

## What you can do from the app-in-chat component
From the SLA detail view in chat, you can:

- See the status of each SLA KPI (breached, at-risk, in-progress, on-track)
- View breach time, warning time, and remaining time per KPI
- See whether any KPI timer is paused
- Understand the overall risk level at a glance

## Prerequisites
This tool requires the following:

- SLAs to be defined

Learn more in [Define service-level agreements](/dynamics365/customer-service/administer/define-service-level-agreements).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Case SLA Status |
| Internal tool name | `get_case_sla_status` |
| Purpose | Returns every linked SLA KPI instance for a single case, including status (in_progress, nearing_noncompliance, noncompliant, paused, succeeded, canceled), breach time, warning time, time remaining, and pause state |

## Tool behavior
Returns every linked SLA KPI instance for a single case, including status (in_progress, nearing_noncompliance, noncompliant, paused, succeeded, canceled), breach time, warning time, time remaining, and pause state. Overall risk is derived as the worst KPI status across all linked KPIs.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Case identifier

| Input | Description | Required |
|---|---|---|
| `incidentId`, `caseNumber` | `incidentId` (GUID) or `caseNumber` (e.g. CAS-01010-A0A0A0). At least one is required. When `caseNumber` is provided, the server resolves it to a GUID via exact then fuzzy matching. | Yes |

### KPI filter

| Input | Description | Required |
|---|---|---|
| `kpiName` | `kpiName` (string, optional). Filters to a single KPI by name (e.g. "Resolve By"). Omit to see all linked KPIs. | No |

## Response and UI behavior
This tool renders an interactive SLA detail view.

This MCP tool is supported by an MCP app.

### Response type

Interactive component (app-in-chat)

Displays all SLA KPIs linked to the case with their status, breach time, warning time, remaining time, and pause state.

## Routing notes
Use `get_case_sla_status` when:

- The user asks about SLA on a specific case ("what's the SLA on CAS-X", "will this case breach")
- The user wants to know time remaining before breach on a specific case
- The user asks about a specific KPI (e.g. "First Response By", "Resolve By") on a case

Don't use `get_case_sla_status` when:

- **Multi-case SLA triage** - route to `query_cases_by_sla_status`
- **General case triage** - route to `get_case_highlights` or `summarize_case`

## Related tools
| Tool | Relationship |
|---|---|
| [`query_cases_by_sla_status`](query_cases_by_sla_status.md) | Multi-case SLA triage view with filters |
| [`get_case_highlights`](get_case_highlights.md) | Activity digest and triage signals (includes SLA risk as one signal) |
| [`summarize_case`](summarize_case.md) | AI-generated case summary for general triage |
| [`list_cases`](list_cases.md) | Lists cases by criteria |

## Data mutation classification
Read-only.

The tool queries SLA KPI instances without modifying any data.
