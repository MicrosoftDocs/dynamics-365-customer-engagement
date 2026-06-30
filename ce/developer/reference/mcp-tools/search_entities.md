---
title: Search Entity Records
description: Learn how to use the Search Entity Records capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Search Entity Records

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to search for records across one or more entity types using keywords or natural language.

## What it does
The assistant searches Dynamics 365 records using the best available search method. If relevance search is enabled in your environment, results are ranked by relevance. Otherwise, the assistant falls back to a substring-match search.

You can search across all entity types at once, or narrow the search to specific entity types like accounts, contacts, or opportunities.

## Try prompts like
- "Search for Contoso across all entities"
- "Find records matching printer issue"
- "Search accounts for Fabrikam"
- "Look up records about network outage"
- "Search opportunities for Project Alpha"
- "Find all records mentioning billing"

## What you'll see in chat
The assistant displays a text list of matching records directly in the chat conversation. Each result shows the record name and entity type. There is no interactive widget for this capability.

## Helpful tips
- You can search across multiple entity types at once, for example "search accounts and contacts for Contoso."
- For listing accounts by status or owner, use "list accounts" instead. Search is better for keyword-based lookups.
- For case-specific searches, say "search cases" for a more targeted experience.
- Search text is limited to 500 characters.
- The assistant tells you whether it used relevance search or substring matching.

> [!TIP]
> After search results appear, you can ask follow-up questions like "open the first result" or "show details for Contoso."

## What happens next
After the search results appear, you can continue with prompts like:

- "Open the first result"
- "Show details for this record"
- "Summarize this account"
- "Search again with different keywords"

## Does this change data?
**No, searching does not change data.**

The search is read-only. Follow-up actions from the results, such as updating or deleting a record, can change data.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Search Entity Records |
| Internal tool name | `search_entities` |
| Purpose | Searches Dataverse records using the best available search method (relevance search when enabled, or OData substring-match fallback) |

## Tool behavior
Searches Dataverse records using the best available search method (relevance search when enabled, or OData substring-match fallback). Supports any entity type and returns relevance-ranked results when available. This is a text-only tool with no app-in-chat widget.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Entity scope (single)

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | `entityLogicalName` (string, optional). A single entity type to search. Ignored if `entityLogicalNames` is provided. | No |

### Entity scope (multiple)

| Input | Description | Required |
|---|---|---|
| `entityLogicalNames` | `entityLogicalNames` (string array, optional). Multiple entity types to search simultaneously. Takes precedence over `entityLogicalName`. | No |

### Search text

| Input | Description | Required |
|---|---|---|
| `searchText` | `searchText` (string, required, max 500 characters). Natural language or keyword search query. | Yes |

### Result limit

| Input | Description | Required |
|---|---|---|
| `top` | `top` (integer, optional). Maximum results per entity type. Defaults to the org page-size setting. | No |

## Response and UI behavior
This tool returns a text-only response with no app-in-chat component.

This MCP tool is supported by an MCP App. 

### Response type

Text list of matching records

The response includes matched records with their primary name, entity type, and relevance score. The search tier (relevance or OData contains) is indicated.

## Routing notes
Use `search_entities` for:

- Free-text or keyword search across any entity type
- Generic search fallback when no dedicated tool exists
- Cross-entity search when the entity type is unspecified

Don't use `search_entities` when the prompt explicitly says:

- **Search cases** - route to `search_cases` (same engine, scoped to incident)
- **List accounts** - route to `list_accounts`
- **List contacts** - route to `list_contacts`
- **Lookup field association** - route to `search_lookup_records`
- **AI-generated timeline narrative** - route to `summarize_entity_timeline` or `get_case_highlights`

## Related tools
| Tool | Relationship |
|---|---|
| [`search_cases`](search_cases.md) | Same search engine, scoped to case entities |
| [`search_lookup_records`](search_lookup_records.md) | Searches records for lookup field association |
| [`list_accounts`](list_accounts.md) | Dedicated account list with filters |
| [`list_contacts`](list_contacts.md) | Dedicated contact list with filters |
| [`list_entity_records`](list_entity_records.md) | Generic entity grid for browsing records |
| [`get_entity_record`](get_entity_record.md) | Opens a single record detail from search results |

## Data mutation classification
Read-only.

This tool does not change data. It performs search queries against Dataverse.
