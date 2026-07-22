---
title: Case Summary
description: Learn how to use the Case Summary capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Case Summary

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to quickly understand what a case is about and see an AI-generated summary of the details.

## What it does

The assistant opens a case and shows an AI-generated summary on a dedicated Summary tab. The summary covers the key details of the case, including the customer's issue, recent activity, and current status. The full case form with all fields is accessible from the Form tab, one click away.

This is the default way cases open in chat. When you say "show me case X" or "open case X," the assistant uses this summary-first view to help you triage quickly.

## Try prompts like
- "Show me case CAS-01010-A0A0A0"
- "Summarize this case"
- "What's going on with CAS-01004-2F9LQX?"
- "Brief me on this case"
- "Open case CAS-01010-A0A0A0"
- "Tell me about this ticket"
- "Recap CAS-01010-A0A0A0"
- "View case details"

## What you see in chat
The assistant displays an interactive case form as an app-in-chat component, opened to the Summary tab with an AI-generated overview. You can switch to the Form tab to see all case fields.

## Helpful tips
- You can open a case by its case number (CAS-01010-A0A0A0) without listing cases first.
- The summary is AI-generated and covers the key points. For a deeper dive, switch to the Form or Timeline tabs.
- If you want structured triage signals (SLA risk, activity counts), ask for "highlights" instead.
- If you just want the form without the AI summary, say "just show the form."

> [!TIP]
> After reading the summary, ask "what should I do next on this case?" to get an AI-recommended action.

## What happens next
After seeing the summary, you can continue with prompts like:

- "What changed on this case since yesterday?"
- "What should I do next on this case?"
- "Set the priority to high"
- "Reassign this case to Alex"
- "Close this case"
- "Search knowledge for this issue"

## Does this change data?
No. Viewing the case summary doesn't change data.

The summary is generated from existing case data. Follow-up actions like updating, reassigning, or closing the case can change data. The assistant asks for confirmation before making changes.

## What you can do from the app-in-chat component
From the case summary in chat, you can:

- Read the AI-generated case summary
- Switch to the Form tab to see all case fields
- Navigate to the Timeline tab to see activity history
- Edit supported fields inline
- Open the full case form in Dynamics 365

## Prerequisites
This tool requires the following:

- Copilot case summaries are enabled.

Learn more in [Enable Copilot case and conversation summaries](/dynamics365/contact-center/administer/copilot-enable-summary).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Case Summary |
| Internal tool name | `summarize_case` |
| Purpose | Generates an AI summary of a case and opens the case form widget with the Summary tab as the default landing (Form tab is one click away) |

## Tool behavior
Generates an AI summary of a case and opens the case form widget with the Summary tab as the default landing (Form tab is one click away). Use for dedicated AI-summary intent: "summarize case CAS-X", "recap CAS-X", "brief me on CAS-X", "give me the AI summary of CAS-X". For general "show case", "open case", "view case", or "tell me about CAS-X" triage prompts, prefer `get_case` with `includeSummary: true` — same widget, but the Form tab is the default landing. For triage signals (SLA risk, escalation, activity counts since a date), use `get_case_highlights`.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | Not set | Default behavior (read-only in practice - generates a summary without modifying the case). |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Case identifier

| Input | Description | Required |
|---|---|---|
| `incidentId`, `caseNumber` | `incidentId` (GUID) or `caseNumber` (e.g. CAS-01010-A0A0A0). At least one is required. The tool can be called directly without first calling `list_cases`. When `caseNumber` is provided, the server resolves it to a GUID. | Yes |

## Response and UI behavior
This tool renders an interactive case form with the Summary tab active.

This MCP tool is supported by an MCP app.

### Response type

Interactive case form (app-in-chat)

The widget opens on the Summary tab showing the AI-generated summary. The Form tab with full case fields is accessible with one click.

## Routing notes
Use `summarize_case` for:

- "summarize case CAS-X", "recap CAS-X", "brief me on CAS-X", "give me the AI summary of CAS-X"
- Any prompt where the user explicitly wants an **AI-generated summary** of the case

Don't use `summarize_case` when:

- **The user says "show case", "open case", "view case", "tell me about CAS-X"** - route to `get_case` with `includeSummary: true` (form is default landing, but summary is available)
- **The user explicitly asks for form-only access** ("just show the form", "case fields only") - route to `get_case`
- **The user wants triage signals** (SLA risk, escalation, activity counts since a date) - route to `get_case_highlights`
- **The user wants resolution steps** - route to `summarize_case_actions`
- **The user wants the activity feed only** - route to `get_activity_timeline`

## Related tools
| Tool | Relationship |
|---|---|
| [`get_case`](get_case.md) | Opens the case form without an AI summary. Use for form-only access or pre-edit inspection |
| [`get_case_highlights`](get_case_highlights.md) | Returns structured triage signals (SLA risk, escalation, activity counts) |
| [`summarize_case_actions`](summarize_case_actions.md) | Lists resolution steps taken on the case |
| [`get_activity_timeline`](get_activity_timeline.md) | Returns the raw chronological activity feed |
| [`update_case`](update_case.md) | Updates fields on the case |
| [`close_case`](close_case.md) | Resolves and closes the case |

## Data mutation classification
Read-only entry point with downstream mutation potential.

The summary itself doesn't change data, though it triggers an LLM call. Follow-up actions from the form, such as update, reassign, and close, can trigger write operations via separate tools.
