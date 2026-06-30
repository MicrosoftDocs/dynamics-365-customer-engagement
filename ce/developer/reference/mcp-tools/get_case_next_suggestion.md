---
title: Get Next Suggested Action
description: Learn how to use the Get Next Suggested Action capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Get Next Suggested Action

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you're working on a case and want AI-assisted recommendations about what you should do next.

## What it does
The assistant analyzes the case context, history, and knowledge base to recommend a concrete next action. This might be responding to the customer, escalating to a specialist, proposing a knowledge article, suggesting a resolution, or resolving the case. The suggestion is specific to the case you're working on and based on the latest activity.

This is different from a general summary. Instead of telling you what happened, it tells you what to do next.

## Try prompts like
- "What should I do next on CAS-01010-A0A0A0?"
- "Suggest the next action for this case"
- "What does the AI recommend?"
- "What's the next best action for this case?"
- "Help me figure out what to do on this ticket"
- "Get a suggestion for this case"

## What you see in chat
The assistant shows a text response with the recommended next action and supporting context explaining why that action is suggested.

## Helpful tips
- The suggestion is based on case context, so the more complete the case timeline is, the better the recommendation.
- You can act on the suggestion immediately. For example, if it suggests "reply to customer," just say "draft a reply."
- This works best on cases with recent activity (like a new customer email).
- For a list of all cases with suggestions across your workload, ask for "cases with suggested actions" instead.

> [!TIP]
> Combine this with your triage flow: "summarize this case" then "what should I do next?" to get both the context and the recommended action.

## What happens next
After getting the suggestion, you can act on it with prompts like:

- "Draft a reply to the customer"
- "Close this case"
- "Search knowledge for this issue"
- "Reassign this case to the billing team"
- "Escalate this case"

## Does this change data?
**No, getting a suggestion does not change data.**

The suggestion is read-only. Acting on the suggestion (replying, closing, reassigning) uses separate tools that may change data. The assistant asks for confirmation before making changes.

## Prerequisites
This tool requires the following:

- Case Management Agent (case resolution capability) to be configured. Without Case Management Agent enabled, the msdyn_InvokeGetNextSuggestion API returns no suggestions

Learn more in [Configure Case Management Agent](/dynamics365/customer-service/administer/case-management-global-settings).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Get Next Suggested Action |
| Internal tool name | `get_case_next_suggestion` |
| Purpose | Returns the next best action or suggested response for a case based on context, history, and knowledge base |

## Tool behavior
Returns the next best action or suggested response for a case based on context, history, and knowledge base. Wraps the Dataverse `msdyn_InvokeGetNextSuggestion` Custom API. Distinct from intent-assist (which classifies intent) - this tool recommends a concrete action such as responding to the customer, escalating, invoking an external agent, or resolving the case.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool reads case context and generates suggestions without modifying data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Case identifier

| Input | Description | Required |
|---|---|---|
| `incidentId`, `caseNumber` | `incidentId` (GUID) or `caseNumber` (e.g. CAS-01010-A0A0A0). At least one is required. When `caseNumber` is provided, the server resolves it to a GUID. | Yes |

### Email context

| Input | Description | Required |
|---|---|---|
| `sourceContextEntityId` | `sourceContextEntityId` (GUID, optional). The email activity that triggered the action. If omitted, the backend auto-finds the latest incoming email on the case. | No |

### Automation level

| Input | Description | Required |
|---|---|---|
| `automationLevel`, `Full`, `Semi`, `Shadow` | `automationLevel` (enum: `Full`, `Semi`, `Shadow`, default `Semi`). Semi is the correct value for MCP-surfaced interactions (human-in-the-loop). Shadow logs telemetry only. Full is for autonomous LOBs and should not be set by the DA. | No |

### Correlation

| Input | Description | Required |
|---|---|---|
| `runId` | `runId` (string, optional). End-to-end correlation ID for tracing. | No |

## Response and UI behavior
### Response type

Text-only

Returns a text response with the recommended next action (e.g. reply to customer, escalate, resolve, suggest knowledge article) and supporting context. No interactive component is rendered.

## Routing notes
Use `get_case_next_suggestion` when:

- The user asks "what should I do next", "suggest next action", "next best action"
- The user wants the AI to recommend a concrete action for a specific case

Don't use `get_case_next_suggestion` when:

- **Viewing all cases with CMA suggestions org-wide** - route to `list_case_suggested_actions`
- **AI prose summary** - route to `summarize_case`
- **Activity digest** - route to `get_case_highlights`

## Related tools
| Tool | Relationship |
|---|---|
| [`list_case_suggested_actions`](list_case_suggested_actions.md) | Lists all cases org-wide that have CMA-flagged next actions |
| [`summarize_case`](summarize_case.md) | AI prose summary of the case |
| [`get_case_highlights`](get_case_highlights.md) | Activity digest and triage signals |
| [`close_case`](close_case.md) | If the suggestion is to resolve the case |
| [`reassign_case`](reassign_case.md) | If the suggestion is to escalate or reassign |

## Data mutation classification
Read-only entry point with downstream mutation potential.

The suggestion itself doesn't change data. The user can act on the suggestion using separate tools, such as close_case, reassign_case, draft email, and so forth.
