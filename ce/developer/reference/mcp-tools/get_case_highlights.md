---
title: Case Highlights
description: Learn how to review recent case highlights, activity counts, and triage signals in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Case Highlights

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]
- "What happened on this case since last week?"
- "Since my last visit, what's new on this case?"
- "Show activity digest for CAS-01004-2F9LQX"
- "Any SLA risk on this case?"
- "Show me the email activity since Monday"

## What you see in chat
The assistant shows a text summary with activity counts by type (emails, calls, notes), SLA risk status, escalation indicators, last customer contact time, and a digest of recent activity. This is a text response without an interactive component.

## Helpful tips
- Say "since yesterday" or "since last week" to scope the time window to what matters.
- You can filter to specific activity types like "show me just the emails and phone calls."
- If you want the full AI prose summary instead, ask for "summarize this case."
- For detailed SLA timings, ask "what's the SLA status on this case?"
- This works only for cases. For accounts or contacts, ask for "timeline highlights" instead.

> [!TIP]
> Use highlights before your shift starts to quickly catch up on what happened overnight: "What changed on my cases since yesterday?"

## What happens next
After seeing the highlights, you can continue with prompts like:

- "Summarize this case"
- "What should I do next on this case?"
- "Show me the timeline for this case"
- "Set the priority to high"
- "Draft a reply to the customer"

## Does this change data?

No. Viewing case highlights doesn't change data.**

The highlights are derived from existing activity records and SLA data.

## Prerequisites
This tool requires the following:

- No additional Microsoft 365 Copilot features are required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Case Highlights |
| Internal tool name | `get_case_highlights` |
| Purpose | Returns a comprehensive activity digest and triage signals for a case over a configurable time window |

## Tool behavior
Returns a comprehensive activity digest and triage signals for a case over a configurable time window. Includes activity counts by type, SLA risk indicators, escalation status, last customer contact, and a summary of recent activity. Scoped to cases (incident entity) only.

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
| `incidentId`, `caseNumber` | `incidentId` (GUID) or `caseNumber` (e.g. CAS-01004-2F9LQX). At least one is required. When `caseNumber` is provided, the server resolves it to a GUID. | Yes |

### Time window

| Input | Description | Required |
|---|---|---|
| `since` | `since` (ISO 8601 timestamp). Marks the lower bound of the activity window. Defaults to 7 days ago if omitted. Use for "since yesterday", "since last week", "since my last visit" questions. | No |

### Activity type filter

| Input | Description | Required |
|---|---|---|
| `activityTypes` | `activityTypes` (string array, e.g. `["email", "phonecall", "task"]`). Defaults to all types. Supports custom activity type codes. | No |

## Response and UI behavior
### Response type

Text-only

Returns structured text with activity counts, SLA risk indicators, escalation status, last customer contact time, and a digest of recent activity. No interactive component is rendered.

## Routing notes
Use `get_case_highlights` when:

- The prompt mentions a case/incident/ticket AND asks for "highlights", "what changed since X", "since yesterday", "since last week", "since my last visit"
- The user asks about SLA risk, escalation, last customer contact, or activity counts on a specific case
- Even when "timeline" appears in the prompt alongside a case reference, prefer this tool

Don't use `get_case_highlights` when:

- **Non-case entities** (account, contact, opportunity, lead) - route to `summarize_entity_timeline`
- **Raw activity list** - route to `get_activity_timeline`
- **AI prose summary** - route to `summarize_case`
- **Resolution steps** - route to `summarize_case_actions`

## Related tools
| Tool | Relationship |
|---|---|
| [`summarize_case`](summarize_case.md) | AI prose summary of the case. Use for general "summarize" intents |
| [`summarize_case_actions`](summarize_case_actions.md) | Structured list of resolution steps taken |
| [`get_activity_timeline`](get_activity_timeline.md) | Raw chronological activity feed |
| [`summarize_entity_timeline`](summarize_entity_timeline.md) | AI narrative for non-case entities |
| [`get_case_sla_status`](get_case_sla_status.md) | Detailed SLA KPI breakdown for a single case |

## Data mutation classification
Read-only.

The tool queries activity records and SLA KPI instances without modifying any data.
