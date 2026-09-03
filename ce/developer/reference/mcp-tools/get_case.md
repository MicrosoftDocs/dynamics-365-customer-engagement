---
title: Case detail
description: Learn how to use the Case detail capability in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Case detail

**Applies to:** Dynamics 365 Customer Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to view the full case form with all its fields, sections, and timeline directly in chat—especially when you're about to edit case details.

## What it does

The assistant opens an interactive case form inside chat that mirrors the Dynamics 365 case layout. The form displays all case fields organized by sections (such as case details, customer information, and SLA information), and includes a Timeline tab showing the case's activity history.

This is the form-first view of a case. It's best when you need to see specific field values or prepare to update the case. For a general overview of a case (with an AI-generated summary), use "summarize case" instead—the assistant defaults to the summary view for most "show me case" prompts.

## Try prompts like

- Show the case form for CAS-01010-A0A0A0.
- Open the form view for this case.
- Show me the case fields.
- Open the case form so I can edit it.
- Show the timeline for case CAS-01010-A0A0A0.
- Case form for this case, timeline tab.

## What you'll see in chat

The assistant displays an interactive case form as an app-in-chat component. The form shows the case's fields, sections, and tabs (including a Timeline tab with recent activities).

## Helpful tips

- Say "summarize case" instead if you want a quick AI-generated overview. The assistant routes most "show case" or "open case" prompts to the summary view by default.
- Use this tool when you need to see specific field values or plan to edit the case.
- You can jump directly to the Timeline tab by saying "show the timeline for this case."
- Filter timeline activities by type (emails, tasks, notes) or date range in your prompt.
- You can pass a case number (like CAS-01010-A0A0A0) or a case GUID.

## What happens next

After the case form appears, you can continue with prompts like:

- Update the priority to high.
- Reassign this case to Alex.
- Summarize this case.
- Draft an email to the customer.
- What changed on this case since yesterday?
- Close this case.

## Does this change data?

**No, viewing the case form doesn't change data.**

The form is read-only. Follow-up actions such as updating a field, reassigning, or closing the case can change data. The assistant asks for confirmation before making changes.

## What you can do from the app-in-chat component

From the case form in chat, you can:

- View all case fields organized by form sections.
- Switch between form tabs (Details, Timeline, and others).
- Browse the activity timeline with filters for activity type, state, and date range.
- Open the full case record in Dynamics 365.
- Use follow-up prompts to update fields or take action on the case.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Case detail |
| Internal tool name | `get_case` |
| Purpose | Opens the case form widget showing the Dataverse layout with sections, fields, timeline, and SLA KPIs |

## Tool behavior
Opens the case form widget showing the Dataverse layout with sections, fields, timeline, and SLA KPIs. Two summary modes: `deferSummary: true` offers a Summary tab whose AI summary loads only when you open that tab, so the form is not delayed by a summary you may never read; `includeSummary: true` generates the summary up front and returns it in the response, which is what a caller that renders no widget needs. Use for "show case CAS-X", "open/view case CAS-X", "get/show case details of CAS-X", "tell me about CAS-X", or any general triage or edit-prelude intent. Pass a summary flag only when case summary is enabled per `check_summary_enabled`. For dedicated AI-summary intent ("summarize CAS-X", "recap CAS-X"), use `summarize_case` instead — that tool generates the summary up front and lands on it. For chronological activity feed only, use `get_activity_timeline`.
## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Case identifier

| Input | Description | Required |
|---|---|---|
| `incidentId`, `caseNumber` | `incidentId` (GUID) or `caseNumber` (for example, CAS-01010-A0A0A0). At least one is required. When `caseNumber` is provided, the server resolves it to a GUID through exact then fuzzy matching. | Yes |

### Form selection

| Input | Description | Required |
|---|---|---|
| `formId` | `formId` (GUID). Optional. Selects a specific system form; defaults to the primary main form. | No |

### Initial tab

| Input | Description | Required |
|---|---|---|
| `initialActiveTab` | `initialActiveTab` (string). Sets which tab is active when the widget opens. | No |

### Timeline filters

| Input | Description | Required |
|---|---|---|
| `typeFilter`, `stateFilter`, `searchText`, `dateFrom`, `dateTo` | `typeFilter` (string array), `stateFilter` (string array), `searchText`, `dateFrom`, `dateTo`. Optional. Pre-filters the embedded timeline tab. | No |

### AI summary

| Input | Description | Required |
|---|---|---|
| `includeSummary` | `includeSummary` (boolean). When `true`, the AI summary is generated and returned in the response. Always costs an LLM call. Use when you need the summary text itself. | No |
| `deferSummary` | `deferSummary` (boolean). When `true`, the Summary tab is offered and its AI summary is fetched when you open that tab — not while the form is loading. Costs an LLM call only if the tab is opened. Takes precedence if both flags are passed. | No |

## Response and UI behavior

This MCP tool is supported by an MCP app.

### Response type

Interactive case form (app-in-chat)

## Routing notes

Use `get_case` when:

- The user says "show case", "open case", "view case", "get case details", "tell me about CAS-X" (general triage or view intents).
- The user is about to edit the case (prelude to `update_case`).
- The user explicitly asks for form-only access: "just show the form", "case fields only".
- Pass `deferSummary: true` (or `includeSummary: true` when you need the summary in the response) once `check_summary_enabled` returned `caseSummaryEnabled: true`.

Don't use `get_case` when:

- The user asks for **dedicated AI summary** ("summarize CAS-X", "recap CAS-X", "brief me on CAS-X")—route to `summarize_case`.
- The user wants an activity feed only—route to `get_activity_timeline`.
- The user wants triage signals—route to `get_case_highlights`.

## Related tools

| Tool | Relationship |
|---|---|
| [`summarize_case`](summarize_case.md) | Generates an AI summary with Summary tab as default landing. Use for dedicated summary intents ("summarize CAS-X", "recap CAS-X") |
| [`update_case`](update_case.md) | Updates fields on the case. Use `get_case` as a prelude to inspect before editing |
| [`get_case_highlights`](get_case_highlights.md) | Returns structured triage signals (SLA risk, escalation, activity counts) |
| [`get_activity_timeline`](get_activity_timeline.md) | Returns the raw chronological activity feed for the case |
| [`get_case_sla_status`](get_case_sla_status.md) | Returns SLA KPI details for the case |
| [`close_case`](close_case.md) | Resolves and closes the case |

## Data mutation classification

Read-only entry point with downstream mutation potential.

The form itself doesn't change data. Follow-up actions from the form (update, reassign, close) can trigger write operations through separate tools.
