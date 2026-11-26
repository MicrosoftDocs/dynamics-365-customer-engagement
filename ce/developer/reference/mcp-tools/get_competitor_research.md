---
title: Competitor research
description: Learn how to use the Competitor research capability in Dynamics 365 Sales.
ms.date: 08/12/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: pdhamal
ms.author: pdhamal
ms.reviewer: tmanchanda
---

# Competitor research

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs competitor research insights for a lead or opportunity.

## What it does
The assistant retrieves persisted competitor insights for a lead or opportunity from the Sales Agents competitor insights API and returns a text response with structured content for agent orchestration.

## Try prompts like
- Research the competitor context for this opportunity
- Get competitive insights for the Northpeak Manufacturing E5 rollout deal
- Pull competitor research for this lead before I qualify it
- Show competitive threats for this opportunity

## What you'll see in chat
The assistant displays a text response directly in chat. There is no interactive app-in-chat component for this capability.

## Helpful tips
- Resolve ambiguous lead or opportunity names before calling tools that require identifiers.
- Use `link_competitor_to_opportunity` when the seller asks to associate a known competitor with an opportunity.
- Use `get_account_research` for account background and customer context.

## What happens next
After the response appears, you can continue with prompts like:

- Get account research for this opportunity
- Link this competitor to the opportunity
- Show stakeholders for this deal
- Draft a competitive follow-up email

## Does this change data?
**No, get_competitor_research does not change data.**

This tool is read-only and does not modify records.

## Prerequisites
This tool requires access to Dynamics 365 Sales records and Sales Agents competitor insights for the selected environment.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Competitor research |
| Internal tool name | `get_competitor_research` |
| Purpose | retrieves competitor research insights for a lead or opportunity. |

## Tool behavior
The tool calls the Sales Agents `msdyn_SalesAgents_GetCompetitorInsights` custom API for one lead or opportunity. On success, it returns the API result, success flag, and error message (usually `null`) as structured content. If the API call itself fails or returns an unsuccessful result, the tool instead returns a minimal structured error (no raw API result or result text) plus a caller-safe error message — the original upstream error text is not exposed.

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
| `recordId` | Resolved lead or opportunity GUID to retrieve competitor insights for. Resolve names before calling this tool. | Yes |
| `recordType` | Entity type for `recordId`. Must be `lead` or `opportunity`. | Yes |

## Response and UI behavior
This tool returns a text-only response with no app-in-chat component. It is a data-only tool with no companion MCP App resource.

### Response type

Text narrative

The response includes structured content from the Sales Agents competitor insights custom API.

## Routing notes
Use `get_competitor_research` when the user asks for competitor research, competitive context, competitive threats, or competitor insights for a lead or opportunity. Don't use it to link or unlink competitor records.

## Related tools
| Tool | Relationship |
|---|---|
| [`get_account_research`](get_account_research.md) | Provides account insights for the same lead or opportunity context |
| [`link_competitor_to_opportunity`](link_competitor_to_opportunity.md) | Associates a competitor record with an opportunity after seller confirmation |
| [`get_stakeholder`](get_stakeholder.md) | Provides stakeholder context for a deal or account |

## Data mutation classification
Read-only.
