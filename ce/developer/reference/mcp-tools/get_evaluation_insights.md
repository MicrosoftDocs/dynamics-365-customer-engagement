---
title: Get Evaluation Insights
description: Learn how to use the Get Evaluation Insights capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Get Evaluation Insights

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to see the AI-generated summary and coaching recommendations for a specific quality evaluation.

## What it does
The assistant retrieves the evaluation summary and recommended action plan for a quality evaluation you specify. This is useful during coaching sessions, quality reviews, or when a supervisor wants to understand what happened in a specific interaction and what steps to take next.

The response includes two main sections: an evaluation summary describing what was observed, and an action plan with specific recommendations for improvement.

## Try prompts like
- "Get evaluation insights for this evaluation"
- "What are the coaching recommendations for this evaluation?"
- "Show me the evaluation summary"
- "What's the action plan for this evaluation?"
- "Give me insights on this evaluation"

## What you'll see in chat
The assistant displays a text summary directly in the chat conversation, including the evaluation summary and the recommended action plan. There is no interactive widget for this capability.

## Helpful tips
- You typically call this after listing evaluations for a case. Select the evaluation you want to review.
- The evaluation summary describes what was observed during the interaction.
- The action plan provides specific coaching recommendations.
- If no insights are available for an evaluation, the assistant lets you know.

> [!TIP]
> Use this capability alongside "list evaluations" for a complete quality review workflow: first list the evaluations, then get insights for the ones that need attention.

## What happens next
After the insights appear, you can continue with prompts like:

- "Summarize this case"
- "Show more evaluations for this case"
- "Open this case"
- "Get insights for another evaluation"

## Does this change data?
**No, getting evaluation insights does not change data.**

The insights are read-only and do not modify any records.

## Prerequisites
This tool requires the following:

- Quality Evaluation Agent to be configured. Without Quality Evaluation Agent enabled
- Evaluation plans active, no evaluation records exist. Requires the Quality Manager, Quality Evaluator, or Quality Administrator role

Learn more in [Manage Quality Evaluation Agent](/dynamics365/contact-center/administer/manage-quality-evaluation-agent).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Get Evaluation Insights |
| Internal tool name | `get_evaluation_insights` |
| Purpose | Retrieves the AI-generated evaluation summary and recommended action plan for a specific quality evaluation |

## Tool behavior
Retrieves the AI-generated evaluation summary and recommended action plan for a specific quality evaluation. This is a text-only tool with no app-in-chat widget, used for coaching review and quality improvement workflows.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Evaluation identifier

| Input | Description | Required |
|---|---|---|
| `evaluationId` | `evaluationId` (string, required). The `msdyn_evaluationid` GUID of the evaluation to retrieve insights for. | Yes |

## Response and UI behavior
This tool returns a text-only response with no app-in-chat component.

This MCP tool is supported by an MCP App. 

### Response type

Text narrative

The response includes the AI-generated evaluation summary and the recommended action plan.

## Routing notes
Use `get_evaluation_insights` for:

- "evaluation insights", "coaching recommendations", "action plan" for a specific evaluation
- Detailed review of a single evaluation's findings

Don't use `get_evaluation_insights` when the prompt explicitly says:

- **List evaluations** - route to `list_evaluations`
- **Case summary** - route to `summarize_case`

## Related tools
| Tool | Relationship |
|---|---|
| [`list_evaluations`](list_evaluations.md) | Lists evaluations for a case; use to find the evaluation ID before calling this tool |
| [`get_case`](get_case.md) | Opens the case form for the case being evaluated |
| [`summarize_case`](summarize_case.md) | Generates a case summary alongside evaluation insights |

## Data mutation classification
Read-only.

This tool does not change data. It reads evaluation summary and action plan data.
