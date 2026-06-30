---
title: Summarize a case in text
description: Learn how to use the Summarize a case in text capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Summarize a case in text

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want the assistant to help you summarize a case in text from chat.

## What it does
Provides a text-only case summary when the organization has disabled the AI case-summary widget path.

## Try prompts like
- "Summarize case CAS-01010-A0A0A0"
- "Give me a brief for this case"
- "Recap this case"
- "What is the status of this case?"

## What you'll see in chat
The assistant returns a short text summary from case fields such as title, customer, status, priority, description, and owner.

## Helpful tips
- Use this for summarize or recap intents when case summaries are disabled.
- Use an exact case number when you have one.
- For viewing the case record instead of summarizing it, open the case form.

## What happens next
- "Open the case for details"
- "Ask for recent activity on the case"
- "Draft a customer reply using the summary"

## Does this change data?
**No, summarizing a case in text does not change data.**

## Prerequisites
This tool requires the following:

- Copilot case summaries are enabled.

Learn more in [Enable Copilot case and conversation summaries](/dynamics365/contact-center/administer/copilot-enable-summary).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Summarize Case (Text) |
| Internal tool name | `summarize_case_text` |
| Purpose | Returns a text-only case summary for the DA fallback path when on-demand case summary is disabled by the org |

## Tool behavior
Returns a text-only case summary for the DA fallback path when on-demand case summary is disabled by the org. Text only - no widget. Use this ONLY when `check_summary_enabled` returned `caseSummaryEnabled: false` AND the user's intent is to summarize/recap/brief. When `caseSummaryEnabled: true`, use `summarize_case` instead (renders the AI summary widget). For show/view intent when the flag is false, use `get_case` instead.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Case identifier

| Input | Description | Required |
|---|---|---|
| `incidentId`, `caseNumber` | `incidentId` (GUID) or `caseNumber` (e.g. CAS-01010-A0A0A0). At least one is required. | Yes |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns a text-only summary of the case. Only use when `check_summary_enabled` confirms `caseSummaryEnabled: false`.

## Routing notes
Use `summarize_case_text` when:

- `check_summary_enabled` returned `caseSummaryEnabled: false`
- The user's intent is to summarize, recap, or brief a specific case

Don't use `summarize_case_text` when:

- `caseSummaryEnabled: true` - use `summarize_case` instead (widget experience)
- The user wants to **view** the case form - use `get_case`

## Related tools
| Tool | Relationship |
|---|---|
| [`check_summary_enabled`](check_summary_enabled.md) | Must be called first to determine which summary path to use |
| [`summarize_case`](summarize_case.md) | Widget-based case summary. Use when `caseSummaryEnabled: true` |
| [`get_case`](get_case.md) | Opens case form widget. Fallback when summary is disabled and user wants to view the case |

## Data mutation classification
**Read-only.** Doesn't create or modify any records.
