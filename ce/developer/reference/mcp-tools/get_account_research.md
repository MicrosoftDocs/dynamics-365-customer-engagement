---
title: Account research
description: Learn how to use the Account research capability in Dynamics 365 Sales.
ms.date: 08/12/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=sales
ms.service: dynamics-365-sales
author: pdhamal
ms.author: pdhamal
ms.reviewer: tmanchanda
---

# Account research

**Applies to:** Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when a seller needs account research insights for a lead or opportunity.

## What it does
The assistant retrieves persisted account insights for a lead or opportunity from the Sales Agents account insights API and returns a text response with structured content for agent orchestration.

## Try prompts like
- Research the account context for this opportunity
- Get account insights for the Northpeak Manufacturing E5 rollout deal
- Pull account research for this lead before I qualify it
- Show customer background for this opportunity

## What you'll see in chat
The assistant displays a text response directly in chat. There is no interactive app-in-chat component for this capability.

## Helpful tips
- Resolve ambiguous lead or opportunity names before calling tools that require identifiers.
- Use `get_account_summary` for a stable account brief when you already have an account record.
- Use `get_account_catchup` when the seller asks what changed recently on an account.

## What happens next
After the response appears, you can continue with prompts like:

- Get competitor research for this opportunity
- Catch me up on this account
- Show stakeholders for this deal
- Draft a follow-up email

## Does this change data?
**No, get_account_research does not change data.**

This tool is read-only and does not modify records.

## Prerequisites
This tool requires access to Dynamics 365 Sales records and Sales Agents account insights for the selected environment.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Account research |
| Internal tool name | `get_account_research` |
| Purpose | retrieves account research insights for a lead or opportunity. |

## Tool behavior
The tool calls the Sales Agents `msdyn_SalesAgents_GetAccountInsights` custom API for one lead or opportunity. On success, it returns the API result, success flag, and error message (usually `null`) as structured content. If the API call itself fails or returns an unsuccessful result, the tool instead returns a minimal structured error (no raw API result or result text) plus a caller-safe error message — the original upstream error text is not exposed.

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
| `recordId` | Resolved lead or opportunity GUID to retrieve account insights for. Resolve names before calling this tool. | Yes |
| `recordType` | Entity type for `recordId`. Must be `lead` or `opportunity`. | Yes |

## Response and UI behavior
This tool returns a text-only response with no app-in-chat component. It is a data-only tool with no companion MCP App resource.

### Response type

Text narrative

The response includes structured content from the Sales Agents account insights custom API.

## Routing notes
Use `get_account_research` when the user asks for account research, account insights, customer context, or account background for a lead or opportunity. Don't use it for stable account summaries or recent-change catch-up requests.

## Related tools
| Tool | Relationship |
|---|---|
| [`get_competitor_research`](get_competitor_research.md) | Provides competitor insights for the same lead or opportunity context |
| [`get_account_summary`](get_account_summary.md) | Provides a stable brief for a resolved account record |
| [`get_account_catchup`](get_account_catchup.md) | Provides recent account changes |
| [`get_stakeholder`](get_stakeholder.md) | Provides stakeholder context for a deal or account |

## Data mutation classification
Read-only.
