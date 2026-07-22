---
title: List AI-Escalated Cases
description: Learn how to use the List AI-Escalated Cases capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# List AI-Escalated Cases

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]
- "Show my AI-escalated cases"
- "Cases where the AI needs help"
- "What has CMA escalated to me?"

## What you'll see in chat
The assistant displays an interactive case grid as an app-in-chat component, showing escalated cases with the case title, fallback reason, and escalation date.

## Helpful tips
- The fallback reason tells you why the AI got stuck. Use this to understand what kind of help is needed.
- Check this view regularly if you have the Case Management Agent enabled. Escalated cases are waiting for your expertise.
- If you want to see cases where the AI has a suggestion (but isn't stuck), ask for "cases with suggested actions" instead.
- You can limit results by saying something like "show me the top 5 AI-escalated cases."

> [!TIP]
> After opening an escalated case, ask "summarize this case" to understand the full context before taking action.

## What happens next
After seeing escalated cases, you can continue with prompts like:

- "Summarize the first case"
- "What happened on this case?"
- "What should I do next on this case?"
- "Draft a reply to the customer"

## Does this change data?
**No, viewing escalated cases does not change data.**

The escalated cases grid is read-only. Follow-up actions like replying, reassigning, or closing a case can change data.

## What you can do from the app-in-chat component
From the escalated cases grid in chat, you can:

- See why the AI escalated each case (the fallback reason)
- See when each case was escalated
- Select a case to drill into its details
- Open the full case form in Dynamics 365
- Take over the case and continue working on it

## Prerequisites
This tool requires the following:

- Case Management Agent to be configured. Cases are only flagged as escalated when Case Management Agent is active
- Detects escalation signals

Learn more in [Configure Case Management Agent](/dynamics365/customer-service/administer/case-management-global-settings).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | List AI-Escalated Cases |
| Internal tool name | `list_cma_escalated_cases` |
| Purpose | Returns cases owned by the current user where the Case Management Agent (CMA) has escalated to a human because the AI is stuck and needs assistance |

## Tool behavior
Returns cases owned by the current user where the Case Management Agent (CMA) has escalated to a human because the AI is stuck and needs assistance. Shows the case title, fallback reason, and escalation date, ordered by most recently escalated first.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Result limit

| Input | Description | Required |
|---|---|---|
| `top` | `top` (integer, max 50, optional). Maximum number of escalated cases to return. Defaults to the org page-size setting (typically 10). | No |

## Response and UI behavior
This tool renders an interactive case grid.

This MCP tool is supported by an MCP App. 

### Response type

Interactive grid (app-in-chat)

The grid displays escalated cases with columns for case title, fallback reason, and escalation date.

## Routing notes
Use `list_cma_escalated_cases` when:

- The user explicitly asks about "escalated cases", "AI-escalated cases", "cases the AI escalated", "cases where the AI is stuck"

Don't use `list_cma_escalated_cases` when:

- **Cases with CMA suggested next actions** (no escalation) - route to `list_case_suggested_actions`
- **SLA-driven triage** - route to `query_cases_by_sla_status`
- **General case listing** - route to `list_cases`

## Related tools
| Tool | Relationship |
|---|---|
| [`list_case_suggested_actions`](list_case_suggested_actions.md) | Lists cases where CMA has a suggested next action (not escalated) |
| [`query_cases_by_sla_status`](query_cases_by_sla_status.md) | SLA-focused triage view |
| [`list_cases`](list_cases.md) | General case listing with filters |
| [`summarize_case`](summarize_case.md) | Opens an escalated case with an AI summary for triage |

## Data mutation classification
Read-only.

The tool queries escalation metadata without modifying any data.
