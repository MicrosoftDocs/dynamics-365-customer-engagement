---
title: Find and manage cases
description: Use the Service Agent to find, filter, and manage support cases directly in chat with an interactive case list.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Find and manage cases

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to find support cases, review them in chat, and take action without leaving the conversation.

## What it does
The assistant shows a list of cases that match your filters. You can filter by the following methods:

- Whether the case is assigned to you
- Case status (active, resolved, cancelled, in progress, on hold, waiting, researching)
- Priority (high, normal, low)
- Case number
- Keywords in the case title

Results appear in an interactive case list inside chat.

## Try prompts like
- "Show my active cases"
- "List my high-priority cases"
- "Find case CAS-01010-A0A0A0"
- "Show resolved cases"
- "List cases assigned to me"
- "Show waiting cases"
- "Find cases about billing"
- "What cases do I need to work on?"

## What you see in chat

The assistant displays an interactive case list as an app-in-chat component. The list shows matching cases with key details such as case number, title, status, and priority.

## Helpful tips
- Say "my cases" or "assigned to me" to see only cases you own.
- Use the exact case number (for example, CAS-01010-A0A0A0) for the most precise result.
- Combine filters by saying something like "show my high-priority active cases."
- Use status words like active, resolved, cancelled, in progress, on hold, waiting, or researching.
- If you want your personal work queue specifically, say "show my inbox" or "show my work items" instead. That uses a different view.

> [!TIP]
> After the case list appears, you can ask follow-up questions about any case shown. For example, "summarize the first case" or "reassign case CAS-01010-A0A0A0."

## What happens next
After the list appears, you can continue with prompts like:

- "Open the first case"
- "Summarize this case"
- "What changed on this case since yesterday?"
- "Reassign this case to Alex"
- "Close this case"
- "Draft a customer reply for this case"

## Does this change data?

No. Listing cases doesn't change data.

The case list is read-only. Follow-up actions from the list, such as updating a field or reassigning a case, can change data. The assistant asks for confirmation before making changes.

## What you can do from the app-in-chat component
From the case list in chat, you can:

- Scan and review matching cases in a sortable grid
- Select a case to see more details
- Open the full case form in Dynamics 365
- Update supported fields inline when available
- Continue working with the case in chat using follow-up prompts

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Find and manage cases |
| Internal tool name | `list_cases` |
| Purpose | Lists support cases filtered by status, priority, owner, or structured criteria and renders them in an interactive grid-style app-in-chat experience |

## Tool behavior
Lists support cases filtered by status, priority, owner, or structured criteria and renders them in an interactive grid-style app-in-chat experience. The `search` parameter supports exact case-number lookup (CAS-XXXXX-XXXXX) or title contains-match.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | Not set | Read-only in practice; this tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Status

| Input | Description | Required |
|---|---|---|
| `active`, `resolved`, `cancelled`, `in-progress`, `on-hold`, `waiting`, `researching` | `active`, `resolved`, `cancelled`, `in-progress`, `on-hold`, `waiting`, `researching`. Filters by case state or status reason. | No |

### Priority

| Input | Description | Required |
|---|---|---|
| `high`, `normal`, `low` | `high`, `normal`, `low`. Case-insensitive. | No |

### Search

| Input | Description | Required |
|---|---|---|
| — | free-text string. Performs exact case-number lookup (CAS-XXXXX-XXXXX) or title contains-match. | No |

### Ownership scope

| Input | Description | Required |
|---|---|---|
| `assignedToMe` | `assignedToMe` (boolean). When true, scopes results to cases owned by the current user. | No |

### Result limit

| Input | Description | Required |
|---|---|---|
| `top` | `top` (integer). Maximum number of cases to return. Defaults to 10. | No |

### Additional filters

| Input | Description | Required |
|---|---|---|
| `additionalFilter` | `additionalFilter` (key-value map). Arbitrary OData filter conditions merged with AND. | No |

## Response and UI behavior
This tool renders an interactive app-in-chat case grid.

This MCP tool is supported by an MCP app.

### Response type

Interactive grid (list view)

The grid displays case number, title, status, priority, and owner. Users can select a row to drill into case detail or take follow-up actions via chat.

## Routing notes
Use `list_cases` for:

- "my cases", "cases assigned to me", "my active cases"
- "what cases do I need to work on"
- Category, status, or priority-based filtering
- Exact case number lookup
- Title-based keyword search

Don't use `list_cases` when the prompt explicitly says:

- **"inbox"** or **"work items"** - route to `list_case_inbox_workitems`
- **Free-text search across title AND description** - route to `search_cases`

## Related tools
| Tool | Relationship |
|---|---|
| [`get_case`](get_case.md) | Opens the full case form for a selected case |
| [`update_case`](update_case.md) | Updates fields on a case (priority, status, etc.) |
| [`summarize_case`](summarize_case.md) | Generates an AI-powered case summary |
| [`get_case_highlights`](get_case_highlights.md) | Returns activity digest and triage signals |
| [`reassign_case`](reassign_case.md) | Reassigns a case to another user, team, or queue |
| [`close_case`](close_case.md) | Resolves and closes a case |
| [`search_cases`](search_cases.md) | Free-text search across case title and description |
| [`list_case_inbox_workitems`](list_case_inbox_workitems.md) | Returns the agent's personal inbox of active cases |
| [`summarize_case_actions`](summarize_case_actions.md) | Lists resolution steps taken on a case |

## Data mutation classification
Read-only entry point with downstream mutation potential.

The listing itself doesn't change data. Follow-up actions from the grid, such as update, reassign, and close, can trigger write operations by using separate tools.
