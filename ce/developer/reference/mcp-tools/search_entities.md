---
title: Search entity records
description: Learn how to use the Search entity records capability in Dynamics 365 Customer Service.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service,sales,field-service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Search entity records

**Applies to:** Dynamics 365 Customer Service, Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to find records across one or more entity types by keyword, phone number, or email address — especially when you know an identifier but not which record it belongs to.

## What it does

The assistant searches Dynamics 365 records using the best available search method. If relevance search is enabled in your environment, it is used; otherwise the assistant falls back to a substring-match search. Results are returned in the order Dynamics 365 supplies them — the first result is not necessarily the closest match.

You can search several entity types at once — for example contacts and accounts together — which is useful when a phone number or email address might belong to either. Contact and account results usually include key detail fields such as job title, city, and status, so you often don't need to open the record to answer a follow-up question. Those extra fields come from a second lookup, so if it doesn't succeed you still get the matching records, just without them.

Phone numbers and email addresses can be searched on, but the recognised phone and email fields aren't returned in the results for any entity type — the answer to "who owns this number" is the record, not the number you already had. Open the record to see its stored contact details. Two narrow exceptions: a custom column your organisation named without a recognisable phone or email root may still be returned, and a few custom tables use an address or number as the record's *name*, which where available is reported as the name.

## Try prompts like

- Search our CRM records for the phone number 555-0134.
- Find the contact record with the email address jordan@contoso.com.
- Search for Contoso across contacts and accounts.
- Which customer has the email address billing@fabrikam.com?
- Find records matching printer issue.
- Look up records about network outage.

## What you'll see in chat

The assistant displays a text list of matching records directly in the chat conversation. Each result shows the record name and entity type. There is no interactive widget for this capability.

## Helpful tips

- You can search several entity types at once, for example "search contacts and accounts for Contoso." This is the best choice when a phone number or email address could belong to either.
- Phone numbers are matched flexibly when relevance search is enabled in your environment — you can type `5550134` even if the record stores `(555)-0134`. Without relevance search, type the number as it's stored.
- For listing accounts by status or owner, use "list accounts" instead. Search is better when you don't already know which record you want.
- To open a record you can already name, say "open the Contoso account" instead.
- For case-specific searches, say "search cases" for a more targeted experience.
- Search text is limited to 500 characters.
- The assistant tells you whether it used relevance search or substring matching.

> [!TIP]
> After search results appear, you can ask follow-up questions like "open the first result" or "show details for Contoso."

## What happens next

After the search results appear, you can continue with prompts like:

- Open the first result.
- Show details for this record.
- Summarize this account.
- Search again with different keywords.

## Does this change data?

**No, searching doesn't change data.**

The search is read-only. Follow-up actions from the results, such as updating or deleting a record, can change data.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Search entity records |
| Internal tool name | `search_entities` |
| Purpose | Searches Dataverse records by keyword, phone number, or email address using the best available search method (relevance search when enabled, or OData substring-match fallback) |

## Tool behavior

Searches Dataverse records by keyword, phone number, or email address using the best available search method (relevance search when enabled, or OData substring-match fallback). Supports any entity type and several types in one call. Phone and email columns are withheld from results for every entity type; where a record's primary name is itself such a value, that name may still be reported as the record's name. Contact and account results are enriched with a curated detail set through a second, best-effort lookup — when that lookup fails the search result is returned un-enriched rather than failed. Other entity types receive no curated set and may carry whatever remaining fields the selected backend supplied. This is a text-only tool with no app-in-chat widget.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
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
| `top` | `top` (integer, optional). Maximum results per entity type. Defaults to the organization page-size setting. | No |

## Response and UI behavior

This tool returns a text-only response with no app-in-chat component.

This MCP tool is supported by an MCP app.

### Response type

Text list of matching records

The response includes matched records with their primary name, entity type, and relevance score. The search tier (relevance or OData contains) is indicated.

## Routing notes

Use `search_entities` for:

- Finding a record from an identifier you hold — a phone number, an email address, or a keyword — when you don't know which record or entity type owns it.
- Searching several entity types at once, such as contacts and accounts together.
- Generic search fallback when no dedicated tool exists for the entity.

Don't use `search_entities` when the prompt explicitly says:

- **Open or edit a record you can already name**—route to `get_contact` or `get_account`.
- **List records by criteria** such as status or owner—route to `list_accounts` or `list_contacts`.
- **Search cases**—route to `search_cases` (same engine, scoped to incident).
- **Lookup field association**—route to `search_lookup_records`.
- **AI-generated timeline narrative**—route to `summarize_entity_timeline` or `get_case_highlights`.

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

This tool doesn't change data. It performs search queries against Dataverse.
