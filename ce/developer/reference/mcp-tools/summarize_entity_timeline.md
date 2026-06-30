---
title: Timeline Highlights (AI narrative)
description: Learn how to use the Timeline Highlights (AI narrative) capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Timeline Highlights (AI narrative)

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to get an AI-generated narrative summary of recent activity on any record in Dynamics 365, including cases, accounts, contacts, opportunities, and leads.

## What it does
The assistant reviews the timeline of a record - including notes, emails, phone calls, and other activities - and generates a readable narrative summary of what's happened recently. This gives you a quick overview of a record's history without scrolling through individual timeline entries.

This works for any record that has a timeline in Dynamics 365, not just cases. You can use it on accounts, contacts, opportunities, leads, and custom entities.

## Try prompts like
- "Show timeline highlights for case CAS-01010-A0A0A0"
- "Summarize the timeline for this account"
- "What's happened recently on this contact?"
- "Give me highlights for this opportunity"
- "Narrative summary of this lead's timeline"
- "Summarize recent activity on this case"

## What you'll see in chat
The assistant returns an AI-generated narrative as text in the chat. The summary covers recent timeline activity such as emails sent, notes added, phone calls logged, and other interactions. The length and detail are determined by the amount of available timeline data.

## Helpful tips
- This works on any entity with a timeline, not just cases. Try it on accounts, contacts, or opportunities.
- For case-specific triage signals (SLA risk, escalation status, activity counts), ask for "case highlights" instead - that returns structured signals rather than a narrative.
- If you want the raw list of activities rather than a summary, ask for the "activity timeline" instead.
- Provide the entity type when asking about non-case records (e.g. "summarize the timeline for this account" rather than just "summarize the timeline").

> [!TIP]
> Combine timeline highlights with other capabilities: "summarize the timeline, then suggest what I should do next."

## What happens next
After reading the highlights, you can continue with prompts like:

- "What should I do next on this case?"
- "Show me the full activity timeline"
- "Draft a reply to the customer"
- "Open this case"

## Does this change data?
**No, this does not change data.**

The timeline summary is generated from existing activity data and does not modify any records.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Timeline Highlights (AI narrative) |
| Internal tool name | `summarize_entity_timeline` |
| Purpose | Returns an AI-generated narrative summary of a record's timeline using the Dataverse SummarizeRecord action |

## Tool behavior
Returns an AI-generated narrative summary of a record's timeline using the Dataverse SummarizeRecord action. Works for any Timeline-Wall-enabled entity including cases (incident), accounts, contacts, opportunities, leads, and custom tables. Summarizes recent notes, emails, phone calls, and other timeline activities into a readable narrative.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Entity type

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | `entityLogicalName` (required). Dataverse entity logical name of the record (e.g. `incident`, `opportunity`, `account`, `contact`, `lead`, or any custom table with Timeline Wall configured). | Yes |

### Record identifier

| Input | Description | Required |
|---|---|---|
| `recordId` | `recordId` (required). GUID of the record whose timeline to summarize. If the user supplies only a name or display label, call `search_lookup_records` first to resolve it to a GUID. | Yes |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. The AI-generated timeline narrative is returned as text in the chat response.

## Routing notes
Use `summarize_entity_timeline` when:

- The user asks for "timeline highlights", "narrative summary", or "what's happened recently" on any record
- The user wants an AI-generated prose summary of timeline activity

Don't use `summarize_entity_timeline` when:

- The user wants **structured triage signals** (SLA risk, escalation, activity counts) - route to `get_case_highlights`
- The user wants the **raw activity list** - route to `get_activity_timeline`
- The user wants a **case summary** (not just timeline) - route to `summarize_case`

## Related tools
| Tool | Relationship |
|---|---|
| [`get_case_highlights`](get_case_highlights.md) | Returns structured triage signals (SLA risk, escalation, activity counts). Use for triage; use `summarize_entity_timeline` for AI narrative |
| [`get_activity_timeline`](get_activity_timeline.md) | Returns raw activity list. Use for detailed activity records; use `summarize_entity_timeline` for prose summary |
| [`summarize_case`](summarize_case.md) | Opens a case with AI summary on the Summary tab. Broader than timeline highlights |
| [`search_lookup_records`](search_lookup_records.md) | Resolves entity names to GUIDs. Use when the user provides a name instead of a record ID |

## Data mutation classification
Read-only.

Reads timeline data and generates an AI narrative. No records are created or modified.
