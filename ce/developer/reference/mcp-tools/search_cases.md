---
title: Search Cases
description: Learn how to use the Search Cases capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Search Cases

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to find cases by searching for keywords in the case title and description, or by customer name.

## What it does
The assistant searches across case titles and descriptions using keywords you provide, or finds cases linked to a specific customer (account or contact). Results are ranked by relevance. This is useful when you know what the issue is about but don't know the case number.

## Try prompts like
- "Search for cases about printer issues"
- "Find cases for Contoso"
- "Cases about login errors"
- "Search cases for Jordan Reyes"
- "Find cases mentioning VPN timeout"
- "Look up cases about billing discrepancy"

## What you see in chat
The assistant shows a text list of matching cases with case numbers, titles, status, and relevance scores. This is a text response without an interactive component.

## Helpful tips
- Use specific keywords for better results. "Printer paper jam" finds more relevant cases than just "printer."
- Search by customer name to find all cases for a specific customer: "find cases for Contoso."
- If you know the case number, use "find case CAS-01010-A0A0A0" instead, which uses a different, faster lookup.
- If you want to filter cases by status or priority with an interactive grid, say "list my active cases" instead.

> [!TIP]
> After finding a matching case, ask "summarize case CAS-01010-A0A0A0" to quickly review it.

## What happens next
After finding cases, you can continue with prompts like:

- "Summarize the first case"
- "Open case CAS-01010-A0A0A0"
- "What's the SLA status on that case?"
- "Reassign this case to Alex"

## Does this change data?
No. Searching cases doesn't change data.

The search is read-only and queries existing case records.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Search Cases |
| Internal tool name | `search_cases` |
| Purpose | Searches cases by free-text keyword across case title and description, or by customer name (account or contact) |

## Tool behavior
Searches cases by free-text keyword across case title and description, or by customer name (account or contact). Uses Dataverse Relevance Search when available, with a substring match fallback. Returns relevance-ranked text results scoped to the incident entity.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Keyword search

| Input | Description | Required |
|---|---|---|
| `searchText` | `searchText` (string, max 500 chars). Free-text keyword to search across case title and description. Ignored when `customerName` is also provided. | No |

### Customer filter

| Input | Description | Required |
|---|---|---|
| `customerName` | `customerName` (string, max 200 chars). Customer name (account or contact) to filter cases by. Takes precedence over `searchText` when both are provided. | No |

### Result limit

| Input | Description | Required |
|---|---|---|
| `top` | `top` (integer). Maximum number of results. Defaults to the org page-size setting (typically 10). | No |

## Response and UI behavior
### Response type

Text-only

Returns a text list of matching cases with case number, title, status, and relevance score. No interactive component is rendered.

## Routing notes
Use `search_cases` when:

- The user wants to search cases by keyword across title AND description
- The user wants to find cases for a specific customer name
- The user says "search for cases about X", "find cases for customer Y"

Don't use `search_cases` when:

- **Filtering by status, priority, or owner with a grid widget** - route to `list_cases`
- **Exact case-number lookup** - route to `list_cases` (the `search` parameter handles exact case number matching)
- **Non-case entity search** - route to `search_entities`

## Related tools
| Tool | Relationship |
|---|---|
| [`list_cases`](list_cases.md) | Lists cases with filters and renders a grid. Use for status/priority/owner filtering or case-number lookup |
| [`search_entities`](search_entities.md) | Generic Dataverse search across any entity type |
| [`summarize_case`](summarize_case.md) | Opens a matched case with an AI summary |
| [`match_cases`](match_cases.md) | Finds cases matching an email via Relevance Search |

## Data mutation classification
Read-only.

The tool queries Dataverse search indices without modifying any data.
