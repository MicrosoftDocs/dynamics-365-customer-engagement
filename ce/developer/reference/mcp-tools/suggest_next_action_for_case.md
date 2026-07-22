---
title: Next Best Action for Case
description: Learn how to use the Next Best Action for Case capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Next Best Action for Case

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you need help deciding what to do next on an open case. The assistant analyzes the case context and suggests the best next steps.

## What it does
The assistant reviews the full context of your open case - including case details, customer history, and recent activity - and recommends the best next actions to take. Suggestions can include replying to the customer, resolving the case, escalating, or other steps specific to the situation.

When a widget appears, you can review the suggested actions, select one to take, and continue working directly from the chat.

## Try prompts like
- "What should I do next on this case?"
- "Suggest next best action for case CAS-01010-A0A0A0"
- "What's the next step for this case?"
- "What actions should I take?"
- "Help me figure out next steps"
- "Suggest actions for this case"
- "Triage this case for me"
- "What's the best action to take?"

## What you'll see in chat
The assistant displays an interactive next-best-action panel as an app-in-chat component. The panel shows AI-recommended action steps with details for each option, such as reply drafts or resolution paths.

## Helpful tips
- This works best on open, active cases with recent activity.
- The more context available on the case (emails, notes, timeline), the better the suggestions.
- You can ask for text-only suggestions if you prefer not to use the widget.
- After receiving suggestions, you can follow up with specific actions like "draft a reply" or "close this case."
- Use "what should I do next" as a natural way to trigger this capability.

> [!TIP]
> After reviewing the suggested actions, you can ask follow-up questions like "draft a reply to the customer" or "resolve this case" to act on a suggestion.

## What happens next
After the suggestions appear, you can continue with prompts like:

- "Draft an email reply for this case"
- "Close this case"
- "Summarize this case"
- "Search knowledge base for related articles"

## Does this change data?
**This step is read-only, but follow-up actions from it may change data.**

Viewing the suggestions does not change any records. If you select an action (like replying to the customer or resolving the case), that follow-up step can modify data. The assistant asks for confirmation before making changes.

## What you can do from the app-in-chat component
From the next-best-action panel, you can:

- Review the AI-suggested action steps
- Select an action to execute (reply to customer, resolve case, escalate)
- Preview a draft reply before sending
- Provide feedback on suggestions using thumbs-up or thumbs-down
- Hand off to an email draft or case close workflow

## Prerequisites
This tool requires the following:

- Customer Intent Agent to be enabled. Without Customer Intent Agent, the msdyn_GetIntentNextAction API returns no suggestions. A pay-as-you-go plan is also required

Learn more in [Manage Customer Intent Agent](/dynamics365/contact-center/administer/manage-customer-intent-agent).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Next Best Action for Case |
| Internal tool name | `suggest_next_action_for_case` |
| Purpose | Identifies customer intent and returns AI-suggested next-best-action steps for an open case |

## Tool behavior
Identifies customer intent and returns AI-suggested next-best-action steps for an open case. Uses full case context including case fields and activity history to generate actionable recommendations via the `msdyn_GetIntentNextAction` API. Returned actions can include replying to the customer, resolving the case, escalating, or other context-specific steps.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | Not set | Default behavior (reads case data and generates suggestions). |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Case identifier

| Input | Description | Required |
|---|---|---|
| `caseId` | `caseId` (required). The Dataverse incidentid (GUID) of the open case. The case must be open for meaningful suggestions. | Yes |

### Conversation context

| Input | Description | Required |
|---|---|---|
| `conversationId` | `conversationId` (optional). Active conversation ID used for linking the suggestion to an ongoing session. | No |

### Language

| Input | Description | Required |
|---|---|---|
| `userLanguage` | `userLanguage` (optional). BCP 47 locale of the agent (e.g. `en-US`). Controls the language of the generated suggestions. | No |

### Display mode

| Input | Description | Required |
|---|---|---|
| `textOnly` | `textOnly` (optional). When `true`, returns text-only response without the interactive widget. | No |

### Proactive mode

| Input | Description | Required |
|---|---|---|
| `proactiveMode` | `proactiveMode` (optional). When `true`, surfaces proactive risks and insights without an explicit agent prompt. Returns text-only. | No |

## Response and UI behavior
This tool renders an interactive next-best-action widget unless `textOnly` or `proactiveMode` is set.

This MCP tool is supported by an MCP App. 

### Response type

Interactive component (app-in-chat) or text-only

When the widget renders, it displays AI-suggested action steps with details such as reply drafts, resolution options, and escalation paths. In text-only mode, the suggestions are returned as plain text in the chat response.

## Routing notes
Use `suggest_next_action_for_case` when:

- The user asks "what should I do next" or "suggest actions" on a case
- The user needs triage guidance on an open case
- The user wants AI-recommended next steps

Don't use `suggest_next_action_for_case` when:

- The user explicitly wants to **compose an email** - route to email draft tools
- The user explicitly wants to **close the case** - route to `close_case`
- The user wants a **case summary** - route to `summarize_case`
- The user wants **case highlights or SLA signals** - route to `get_case_highlights`

## Related tools
| Tool | Relationship |
|---|---|
| [`summarize_case`](summarize_case.md) | Opens the case with an AI summary. Use for case overview; use `suggest_next_action_for_case` for actionable next steps |
| [`get_case_highlights`](get_case_highlights.md) | Returns triage signals (SLA risk, escalation, activity counts). Complements intent suggestions |
| [`close_case`](close_case.md) | Resolves and closes a case. Can be a downstream action from a next-best-action suggestion |
| [`get_response_preview`](get_response_preview.md) | Generates non-email reply previews. Invoked by the widget when a reply action is selected |
| [`submit_feedback`](submit_feedback.md) | Records agent feedback on intent suggestions. Invoked by the widget's thumbs-down action |

## Data mutation classification
Read-only entry point with downstream mutation potential.

The tool reads case data and generates AI suggestions without modifying any records. Follow-up actions from the widget (replying to the customer, resolving the case) can trigger write operations via separate tools.
