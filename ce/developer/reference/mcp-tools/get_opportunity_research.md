---
title: Opportunity research
description: Learn how to use the Opportunity research capability in Dynamics 365 Sales.
ms.date: 08/13/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: pdhamal
ms.author: pdhamal
ms.reviewer: tmanchanda
---

# Opportunity research

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs the full Sales Opportunity Agent research report for an opportunity.

## What it does
The assistant retrieves persisted opportunity research from the Sales Opportunity Agent result API, including deal overview, account, competitor, stakeholder, historical-pattern, and custom insight sections when available.

## Try prompts like
- Research the Northpeak Manufacturing E5 rollout opportunity
- Get all Sales Opportunity Agent insights for this deal
- Show the opportunity research report for this opportunity
- Pull deal intelligence and pain points for this opportunity

## What you'll see in chat
The assistant displays a text response directly in chat. There is no interactive app-in-chat component for this capability.

## Helpful tips
- Resolve ambiguous opportunity names before calling tools that require identifiers.
- Use `get_account_research` for customer-account context scoped to a lead or opportunity.
- Use `get_competitor_research` for competitive intelligence scoped to a lead or opportunity.

## What happens next
After the response appears, you can continue with prompts like:

- Get account research for this opportunity
- Get competitor research for this opportunity
- Show stakeholders for this deal
- Draft a follow-up email

## Does this change data?
**No, get_opportunity_research does not change data.**

This tool is read-only and does not modify records.

## Prerequisites
This tool requires read access to Dynamics 365 Sales opportunities and Sales Opportunity Agent research results for the selected environment.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Opportunity research |
| Internal tool name | `get_opportunity_research` |
| Purpose | retrieves the full Sales Opportunity Agent research report for one opportunity. |

## Tool behavior
The tool calls the `msdyn_GetOpportunityResearchResult` custom API for one opportunity. On success, it returns the research result, success flag, status, processing metadata, and specialized insight sections as structured content. If the API call itself fails or returns an unsuccessful result, the tool instead returns a minimal structured error (no raw research result or specialized insight sections) plus a caller-safe error message — the original upstream error text is not exposed.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Sales context

| Input | Description | Required |
|---|---|---|
| `opportunityId` | Resolved opportunity GUID to retrieve deal overview and research insights for. Resolve names before calling this tool. | Yes |

## Response and UI behavior
This tool returns a text-only response with no app-in-chat component. It is a data-only tool with no companion MCP App resource.

### Response type

Text narrative

The response includes structured content from the Sales Opportunity Agent opportunity research custom API.

## Routing notes
Use `get_opportunity_research` when the user asks for opportunity research, deal intelligence, pain points, or all Sales Opportunity Agent insights for one opportunity. Don't use it for stable opportunity summaries, recent-change catch-up requests, or competitor-only research.

## Related tools
| Tool | Relationship |
|---|---|
| [`get_account_research`](get_account_research.md) | Provides account insights for a lead or opportunity context |
| [`get_competitor_research`](get_competitor_research.md) | Provides competitor insights for a lead or opportunity context |
| [`get_opportunity_summary`](get_opportunity_summary.md) | Provides a stable brief for a resolved opportunity |
| [`get_opportunity_catchup`](get_opportunity_catchup.md) | Provides recent opportunity changes |

## Data mutation classification
Read-only.
