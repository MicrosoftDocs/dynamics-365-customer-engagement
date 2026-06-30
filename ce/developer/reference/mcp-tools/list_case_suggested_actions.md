---
title: Cases with Suggested Actions
description: Learn how to use the Cases with Suggested Actions capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Cases with Suggested Actions

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to see all cases where the AI has identified a recommended next action for you, such as replying to a customer or resolving the case.

## What it does
The assistant shows a grid of cases where the Case Management Agent (CMA) has flagged a recommended next action. Each case shows what the AI suggests you do: reply to the customer, send an AI-drafted email, propose a knowledge article, suggest a resolution, or close the case. Clicking a row takes you directly to that action.

## Try prompts like
- "Show cases with suggested actions"
- "What cases has CMA suggested actions for?"
- "Cases needing action"
- "What does the AI suggest I work on?"
- "Show me cases where CMA has a recommendation"

## What you see in chat

The assistant displays an interactive case grid as an app-in-chat component, showing cases with the case title, last action update time, and the type of recommended action (shown as a badge like "Reply to Customer" or "Propose KB Article").

## Helpful tips
- This shows all cases org-wide that have CMA-flagged next actions, not just your assigned cases.
- Each action badge tells you what to do: reply to customer, send AI draft, propose KB article, suggest resolution, or close.
- If you want the next suggestion for just one specific case, ask "what should I do next on CAS-X?" instead.
- If you want to see cases where the AI is stuck (not just suggesting), ask for "AI-escalated cases."

> [!TIP]
> Use this as a daily triage tool to see where the AI has done the analysis and is ready for you to take action.

## What happens next
After seeing the suggested actions, click a case row to take the suggested action, or continue with prompts like:

- "Summarize the first case"
- "Open this case"
- "What changed on this case since yesterday?"

## Does this change data?

No, viewing suggested actions does not change data.

The grid is read-only. Selecting a row to take the suggested action, such as replying, closing, and so forth, uses separate tools that might change data. The assistant asks for confirmation before making changes.

## What you can do from the app-in-chat component
From the suggested actions grid in chat, you can:

- See what the AI recommends for each case
- Click a row to take the suggested action directly
- View the case title and when the suggestion was last updated
- Navigate to the full case form in Dynamics 365

## Prerequisites
This tool requires the following:

- Case Management Agent to be configured with at least one active case resolution or follow-up rule. Without Case Management Agent, no suggested-action records exist
- This tool always returns an empty result

Learn more in [Configure Case Management Agent](/dynamics365/customer-service/administer/case-management-global-settings).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Cases with Suggested Actions |
| Internal tool name | `list_case_suggested_actions` |
| Purpose | Returns a grid of cases where the Case Management Agent (CMA) has flagged a recommended next action, such as replying to the customer, sending an AI-drafted email, proposing a knowledge article, suggesting a resolution, or closing the case |

## Tool behavior
Returns a grid of cases where the Case Management Agent (CMA) has flagged a recommended next action, such as replying to the customer, sending an AI-drafted email, proposing a knowledge article, suggesting a resolution, or closing the case. Each row shows the case and the recommended action type. Clicking a row routes to the appropriate action prompt.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
This tool takes no input parameters.

## Response and UI behavior
This tool renders an interactive case grid with action badges.

This MCP tool is supported by an MCP app.

### Response type

Interactive grid (app-in-chat)

The grid displays cases with columns for case title, last action update time, and recommended action type (shown as a badge). Clicking a row triggers the appropriate follow-up action prompt.

## Routing notes
Use `list_case_suggested_actions` when:

- The user asks about "cases with suggested actions", "cases needing action", "what does CMA suggest"
- The user wants to see all cases where the AI has identified a next action

Don't use `list_case_suggested_actions` when:

- **Cases the AI has escalated** (needs human help) - route to `list_cma_escalated_cases`
- **Next suggestion for a single specific case** - route to `get_case_next_suggestion`
- **SLA-driven triage** - route to `query_cases_by_sla_status`

## Related tools
| Tool | Relationship |
|---|---|
| [`list_cma_escalated_cases`](list_cma_escalated_cases.md) | Lists cases where CMA has escalated to a human (AI is stuck) |
| [`get_case_next_suggestion`](get_case_next_suggestion.md) | Returns the next best action for a single specific case |
| [`query_cases_by_sla_status`](query_cases_by_sla_status.md) | SLA-focused triage view |
| [`list_cases`](list_cases.md) | General case listing with filters |

## Data mutation classification
Read-only entry point with downstream mutation potential.

The listing itself doesn't change data. Selecting a row starts a follow-up action, such as reply, draft email, close, and so forth, which can change data via separate tools.
