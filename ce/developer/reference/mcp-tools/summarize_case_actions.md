---
title: Summarize Resolution Steps
description: Learn how to use the Summarize Resolution Steps capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Summarize Resolution Steps

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to see a structured recap of the steps taken to resolve a case, drawn from the case timeline.

## What it does
The assistant reads through the case timeline (emails, notes, phone calls) and generates a structured summary of the resolution steps that were taken. This is useful for reviewing what happened before closing a case, or for drafting a knowledge base article from a resolved case.

## Try prompts like
- "What steps were taken on CAS-01010-A0A0A0?"
- "Recap what was done on this case"
- "Summarize the actions taken to resolve this case"
- "List the resolution steps for this ticket"
- "What did I do on this case?"
- "Help me write a KB article from this case's resolution"

## What you see in chat
The assistant shows a structured text summary listing the resolution steps in order, derived from the case timeline. This is a text response without an interactive component.

## Helpful tips
- This is different from "summarize case," which gives a general AI overview. This tool focuses specifically on the steps taken to resolve the issue.
- Use this before closing a case to help write a good resolution note.
- The summary is drawn from timeline activities, so the more complete your timeline notes are, the better the summary.
- This is great input for drafting knowledge base articles from resolved cases.

> [!TIP]
> Ask for this right before closing a case: "summarize the actions on this case" then "close this case with resolution: [paste from the summary]."

## What happens next
After seeing the resolution steps, you can continue with prompts like:

- "Close this case with resolution: [summary]"
- "Summarize this case"
- "Show the timeline for this case"
- "Draft a KB article from these steps"

## Does this change data?

No. Summarizing resolution steps doesn't change data.

The summary is generated from existing timeline activities.

## Prerequisites
This tool requires the following:

- Copilot case summaries are enabled.

Learn more in [Enable Copilot case and conversation summaries](/dynamics365/contact-center/administer/copilot-enable-summary).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Summarize Resolution Steps |
| Internal tool name | `summarize_case_actions` |
| Purpose | Generates a structured summary of the resolution steps taken on a case, derived from the case timeline activities (emails, notes, phone calls) |

## Tool behavior
Generates a structured summary of the resolution steps taken on a case, derived from the case timeline activities (emails, notes, phone calls). Use when the user wants to recap what was done on a case or needs structured resolution steps to draft a knowledge base article.

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
| `incidentId`, `caseNumber` | `incidentId` (GUID) or `caseNumber` (e.g. CAS-01010-A0A0A0). At least one is required. When `caseNumber` is provided, the server resolves it to a GUID. | Yes |

## Response and UI behavior
### Response type

Text-only

Returns a structured text summary of resolution steps derived from the case timeline. No interactive component is rendered.

## Routing notes
Use `summarize_case_actions` when:

- The user asks to recap "the steps I took", "what was done on this case"
- The user wants structured resolution steps for KB article drafting
- The user wants a step-by-step account of what happened

Don't use `summarize_case_actions` when:

- **AI prose case summary** - route to `summarize_case`
- **Triage signals** (SLA risk, escalation, activity counts) - route to `get_case_highlights`
- **Raw activity feed** - route to `get_activity_timeline`

## Related tools
| Tool | Relationship |
|---|---|
| [`summarize_case`](summarize_case.md) | AI prose summary of the case (triage-oriented) |
| [`get_case_highlights`](get_case_highlights.md) | Activity digest with SLA risk and triage signals |
| [`get_activity_timeline`](get_activity_timeline.md) | Raw chronological activity feed |
| [`close_case`](close_case.md) | Resolves the case after reviewing resolution steps |

## Data mutation classification
Read-only.

The tool reads timeline activities and generates a structured summary without modifying any data.
