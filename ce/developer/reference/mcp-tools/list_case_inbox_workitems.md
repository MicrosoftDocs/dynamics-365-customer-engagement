---
title: Case Inbox — Work Items
description: Learn how to review your assigned case inbox work items in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Case Inbox — Work Items

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to see your personal inbox of cases that are assigned to you and need your attention.

## What it does
The assistant shows your personal case inbox with active cases assigned to you that have been modified in the last 90 days. Cases are sorted by priority (highest first), and then by most recently modified. These details give you a quick view of what's on your plate.

## Try prompts like
- "Show my inbox"
- "What's in my work items?"
- "Show my case inbox"
- "What work items do I have?"

## What you see in chat
The assistant displays an interactive case grid as an app-in-chat component, showing your assigned cases with case number, title, status, and priority.

## Helpful tips
- This tool responds specifically to the words "inbox" or "work items." For "my cases" or "cases assigned to me," the assistant uses a different view that may include more results.
- Your inbox shows only active cases modified in the last 90 days. Older cases don't appear.
- If you want to pick up a new case from the queue, say "pick a case from my queue" instead.
- Cases are sorted by priority first, so your most urgent work appears at the top.

> [!TIP]
> Start your day with "show my inbox" to see what's waiting for you, then pick the top case to start triaging.

## What happens next
After seeing your inbox, you can continue with prompts like:

- "Summarize the first case"
- "What's the SLA status on this case?"
- "What changed on this case since yesterday?"
- "Set the priority to high"

## Does this change data?

No. Viewing your inbox doesn't change data.

The inbox is read-only. Follow-up actions from the grid, such as updating or reassigning a case, can change data. The assistant asks for confirmation before making changes.

## What you can do from the app-in-chat component
From the inbox in chat, you can:

- Scan your assigned cases in a sortable grid
- Select a case to see more details
- Open the full case form in Dynamics 365
- Continue working with a case using follow-up prompts

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Case Inbox — Work Items |
| Internal tool name | `list_case_inbox_workitems` |
| Purpose | Returns the agent's personal inbox: active cases assigned to the current user that were modified in the last 90 days, sorted by priority then most recently modified |

## Tool behavior
Returns the agent's personal inbox: active cases assigned to the current user that were modified in the last 90 days, sorted by priority then most recently modified. This is the agent's personal work queue view, triggered by the literal words "inbox" or "work items".

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
This tool renders an interactive case grid.

This MCP tool is supported by an MCP app.

### Response type

Interactive grid (app-in-chat)

The grid displays the agent's assigned active cases with case number, title, status, and priority.

## Routing notes
Use `list_case_inbox_workitems` when:

- The prompt contains the literal word "inbox" or "work items"
- The user says "show my inbox", "what's in my work items"

Don't use `list_case_inbox_workitems` when:

- **Ownership-scoped listing without "inbox"/"work items" keywords** ("my cases", "cases assigned to me") - route to `list_cases` with `assignedToMe: true`
- **Claiming the next case from a queue** ("go next", "pick a case") - route to `pick_case_from_queue`
- **General case filtering** - route to `list_cases`

## Related tools
| Tool | Relationship |
|---|---|
| [`list_cases`](list_cases.md) | Lists cases with filters. Use with `assignedToMe: true` for "my cases" without the inbox keyword |
| [`pick_case_from_queue`](pick_case_from_queue.md) | Claims the next unassigned case from the queue |
| [`summarize_case`](summarize_case.md) | Opens a case with an AI summary for triage |
| [`query_cases_by_sla_status`](query_cases_by_sla_status.md) | SLA-focused triage view of cases |

## Data mutation classification
Read-only.

The inbox listing doesn't change data. Follow-up actions from the grid can trigger write operations using separate tools.
