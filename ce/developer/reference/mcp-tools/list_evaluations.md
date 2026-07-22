---
title: List Evaluations
description: Learn how to use the List Evaluations capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# List Evaluations

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to review quality evaluations for a specific case, for example during coaching sessions or quality reviews.

## What it does
The assistant shows a list of quality evaluations associated with a specific case. You can optionally filter by score threshold to focus on evaluations that need attention. Results appear in an interactive evaluation list inside chat.

The list includes each evaluation's name, score, evaluation method, AI agent status, evaluator status, evaluation criteria, and the CSR name.

## Try prompts like
- "Show evaluations for this case"
- "List quality evaluations for case CAS-01010-A0A0A0"
- "Get all evaluations where the score is below 90"
- "Show me the quality scores for this case"
- "What evaluations exist for this case?"
- "List evaluations with low scores"

## What you'll see in chat
The assistant displays an interactive evaluation list as an app-in-chat component. The list shows matching evaluations with key details such as name, score, evaluation method, and evaluator status.

## Helpful tips
- You need to specify a case to see its evaluations. Say the case number or have a case open in context.
- Use a score threshold to focus on evaluations that need attention, for example "show evaluations below 80."
- The score threshold is exclusive, meaning "below 90" returns scores of 89 and lower.
- The default number of results is 50, and the maximum is 200.

> [!TIP]
> After the evaluation list appears, you can ask "get evaluation insights" for a specific evaluation to see the AI-generated summary and action plan.

## What happens next
After the list appears, you can continue with prompts like:

- "Get insights for this evaluation"
- "What are the coaching recommendations?"
- "Summarize this case"
- "Open this case"

## Does this change data?
**No, listing evaluations does not change data.**

The evaluation list is read-only and does not modify any records.

## What you can do from the app-in-chat component
From the evaluation list in chat, you can:

- Scan and review evaluations in a sortable grid
- Select an evaluation to learn more
- Continue with coaching workflows via follow-up prompts

## Prerequisites
This tool requires the following:

- Quality Evaluation Agent to be configured. Without Quality Evaluation Agent enabled
- Evaluation plans active, no evaluation records exist. Requires the Quality Manager, Quality Evaluator, or Quality Administrator role

Learn more in [Manage Quality Evaluation Agent](/dynamics365/contact-center/administer/manage-quality-evaluation-agent).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | List Evaluations |
| Internal tool name | `list_evaluations` |
| Purpose | Retrieves quality evaluations for a specific case, optionally filtered by score threshold, and renders them in an interactive grid-style app-in-chat experience |

## Tool behavior
Retrieves quality evaluations for a specific case, optionally filtered by score threshold, and renders them in an interactive grid-style app-in-chat experience. Used by supervisors to review quality scores and evaluation criteria for a case.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Case reference

| Input | Description | Required |
|---|---|---|
| `regardingObjectId` | `regardingObjectId` (string, required). The case ID (`incidentid`) to filter evaluations for a specific case. | Yes |

### Score threshold

| Input | Description | Required |
|---|---|---|
| `maxScore` | `maxScore` (integer, optional). Maximum score threshold (exclusive). Returns evaluations with score below this value. | No |

### Result limit

| Input | Description | Required |
|---|---|---|
| `top` | `top` (integer, optional). Maximum number of evaluations to return. Defaults to 50, max 200. | No |

## Response and UI behavior
This tool renders an interactive app-in-chat evaluation grid.

This MCP tool is supported by an MCP App. 

### Response type

Interactive grid (list view)

The grid displays evaluation name, score, evaluation method, AI agent status, evaluator status, evaluation criteria, and CSR name.

## Routing notes
Use `list_evaluations` for:

- "show evaluations", "list evaluations", "quality scores" for a specific case
- Score-threshold filtering (e.g. "evaluations below 90")

Don't use `list_evaluations` when the prompt explicitly says:

- **Evaluation insights or coaching recommendations** - route to `get_evaluation_insights`
- **Case list or case search** - route to `list_cases` or `search_cases`

## Related tools
| Tool | Relationship |
|---|---|
| [`get_evaluation_insights`](get_evaluation_insights.md) | Retrieves AI summary and action plan for a specific evaluation |
| [`list_cases`](list_cases.md) | Lists cases; use to find the case before listing evaluations |
| [`get_case`](get_case.md) | Opens the case form for the case being evaluated |
| [`summarize_case`](summarize_case.md) | Generates a case summary alongside evaluation context |

## Data mutation classification
Read-only.

This tool does not change data. It reads evaluation records for a specified case.
