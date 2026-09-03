---
title: Search cases
description: Learn how to use the Search cases capability in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Search cases

**Applies to:** Dynamics 365 Customer Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability to find cases for a specific customer (account or contact), or when a keyword is likely in the case description body rather than just the title. For plain "cases about X" keyword or title lookups, status or priority filtering, or case-number lookup, use list_cases instead.

## What it does

The assistant finds cases linked to a specific customer (account or contact), or searches case text by keyword—using relevance search across title and description when your organization has it enabled, otherwise a title-only match. It's most useful when you want a customer's cases, or when the words you remember are in the case description rather than its title. For plain title or topic keyword lookups, use list_cases.

## Try prompts like

- Find cases for Contoso.
- Search cases for Jordan Reyes.
- Which cases belong to the Fabrikam account?
- Find cases where the description mentions VPN timeout.
- Show cases linked to Acme Corp.

## What you'll see in chat

The assistant shows a text list of matching cases with case numbers, titles, status, and—when relevance search is available—relevance scores. This is a text response without an interactive component.

## Helpful tips

- Use specific keywords for better results. "Printer paper jam" finds more relevant cases than just "printer."
- Search by customer name to find all cases for a specific customer: "find cases for Contoso."
- If you know the case number, use "find case CAS-01010-A0A0A0" instead, which uses a different, faster lookup.
- If you want to filter cases by status or priority with an interactive grid, say "list my active cases" instead.

> [!TIP]
> After finding a matching case, ask "summarize case CAS-01010-A0A0A0" to quickly review it.

## What happens next

After finding cases, you can continue with prompts like:

- Summarize the first case.
- Open case CAS-01010-A0A0A0.
- What's the SLA status on that case?
- Reassign this case to Alex.

## Does this change data?

**No, searching cases doesn't change data.**

The search is read-only and queries existing case records.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Search Cases |
| Internal tool name | `search_cases` |
| Purpose | Finds cases by customer name (account or contact), or by a keyword ranked across the case body (best when the term is likely in the description) |

## Tool behavior

Finds cases by customer name (account or contact), or by a keyword—best when the term is likely in the description body, not just the title. Uses Dataverse Relevance Search when the organization has it enabled (spans title and description, relevance-ranked); otherwise a title-only substring fallback ordered by modified date (no relevance scores). Scoped to the incident entity, text-only. For plain title or topic keyword lookups, or status/priority/owner filtering, use list_cases.

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
| `searchText` | `searchText` (string, max 500 chars). Keyword to match; uses relevance search across title and description when enabled, else a title-only substring fallback. Use when the term may be in the description body, not just the title; for plain title or topic keyword lookups use `list_cases`. Ignored when `customerName` is also provided. | No |

### Customer filter

| Input | Description | Required |
|---|---|---|
| `customerName` | `customerName` (string, max 200 chars). Customer name (account or contact) to filter cases by. Takes precedence over `searchText` when both are provided. | No |

### Result limit

| Input | Description | Required |
|---|---|---|
| `top` | `top` (integer). Maximum number of results. Defaults to the organization page-size setting (typically 10). | No |

## Response and UI behavior

### Response type

Text-only

Returns a text list of matching cases with case number, title, status, and relevance score. No interactive component is rendered.

## Routing notes

Use `search_cases` when:

- The user wants to find cases for a specific customer name (account or contact).
- A keyword the user expects in the case **description body**, not just the title.
- The user says "find cases for customer Y", "cases linked to <account>".

Don't use `search_cases` when:

- **Plain keyword or title lookup** ("cases about X", "cases mentioning X", "find the X case")—route to `list_cases` (its `search` parameter matches the case title).
- **Filtering by status, priority, or owner with a grid widget**—route to `list_cases`.
- **Exact case-number lookup**—route to `list_cases` (the `search` parameter handles exact case number matching).
- **Non-case entity search**—route to `search_entities`.

## Related tools

| Tool | Relationship |
|---|---|
| [`list_cases`](list_cases.md) | Lists cases with filters and renders a grid. Use for title/topic keyword lookup, status/priority/owner filtering, or case-number lookup |
| [`search_entities`](search_entities.md) | Generic Dataverse search across any entity type |
| [`summarize_case`](summarize_case.md) | Opens a matched case with an AI summary |
| [`match_cases`](match_cases.md) | Finds cases matching an email through Relevance Search |

## Data mutation classification

Read-only.

The tool queries Dataverse search indices without modifying any data.
