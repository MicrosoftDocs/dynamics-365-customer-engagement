---
title: List Accounts
description: Learn how to use the List Accounts capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# List Accounts

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to find customer accounts, review them in chat, and take action without leaving the conversation.

## What it does
The assistant shows a list of accounts that match your filters. You can filter by:

- Whether the account is assigned to you
- Account status (active or inactive)
- City
- Account name

Results appear in an interactive account list inside chat.

## Try prompts like
- "Show my active accounts"
- "List my accounts"
- "Show accounts in Seattle"
- "List inactive accounts"
- "Show accounts assigned to me"
- "Find Contoso account"
- "List all accounts"
- "Show technology industry accounts"

## What you'll see in chat
The assistant displays an interactive account list as an app-in-chat component. The list shows matching accounts with key details such as account name, industry, city, phone, and email.

## Helpful tips
- Say "my accounts" or "assigned to me" to see only accounts you own.
- Use status words like active or inactive to filter results.
- Combine filters by saying something like "show my active accounts in Seattle."
- Use a company name to search for a specific account.
- If you want a full summary of a company, say "brief me about Contoso" instead. That uses a different tool.

> [!TIP]
> After the account list appears, you can ask follow-up questions about any account shown. For example, "open the first account" or "summarize Contoso."

## What happens next
After the list appears, you can continue with prompts like:

- "Open the first account"
- "Summarize this account"
- "Show contacts at this account"
- "Update the phone number on this account"

## Does this change data?
**No, listing accounts does not change data.**

The account list is read-only. Follow-up actions from the list, such as updating a field, can change data. The assistant asks for confirmation before making changes.

## What you can do from the app-in-chat component
From the account list in chat, you can:

- Scan and review matching accounts in a sortable grid
- Select an account to see more details
- Open the full account form in Dynamics 365
- Update supported fields inline when available
- Continue working with the account in chat using follow-up prompts

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | List Accounts |
| Internal tool name | `list_accounts` |
| Purpose | Lists customer accounts filtered by status, city, owner, or name search and renders them in an interactive grid-style app-in-chat experience |

## Tool behavior
Lists customer accounts filtered by status, city, owner, or name search and renders them in an interactive grid-style app-in-chat experience. The `search` parameter performs a contains-match against the account name.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Search

| Input | Description | Required |
|---|---|---|
| — | free-text string. Performs a contains-match against the account name. | No |

### City

| Input | Description | Required |
|---|---|---|
| `address1_city` | filter by `address1_city` (contains match). Use when the user specifies a geographic location. | No |

### Status

| Input | Description | Required |
|---|---|---|
| `active`, `inactive` | `active` or `inactive`. Filters by account state code. | No |

### Ownership scope

| Input | Description | Required |
|---|---|---|
| `assignedToMe` | `assignedToMe` (boolean). When true, scopes results to accounts owned by the current user. | No |

### Result limit

| Input | Description | Required |
|---|---|---|
| `top` | `top` (integer). Maximum number of accounts to return. Defaults to 10, max 200. | No |

### Additional filters

| Input | Description | Required |
|---|---|---|
| `additionalFilter` | `additionalFilter` (key-value map). Arbitrary OData filter conditions merged with AND, using odata-query `Filter<T>` object syntax. | No |

## Response and UI behavior
This tool renders an interactive app-in-chat account grid.

This MCP tool is supported by an MCP App. 

### Response type

Interactive grid (list view)

The grid displays account name, industry, city, phone, and email. Users can select a row to drill into account detail or take follow-up actions via chat.

## Routing notes
Use `list_accounts` for:

- "my accounts", "accounts assigned to me", "my active accounts"
- Status-based filtering (active, inactive)
- City-based filtering
- Account name search

Don't use `list_accounts` when the prompt explicitly says:

- **A specific account by name for detail view** - route to `get_account`
- **"Brief me about" or "summarize" a company** - route to `summarize_account`
- **Free-text search across multiple entity types** - route to `search_entities`
- **Lookup field association** - route to `search_lookup_records`

## Related tools
| Tool | Relationship |
|---|---|
| [`get_account`](get_account.md) | Opens the full account form for a selected account |
| [`summarize_account`](summarize_account.md) | Generates an AI-powered account summary |
| [`list_contacts`](list_contacts.md) | Lists contacts, often used alongside account browsing |
| [`search_entities`](search_entities.md) | Free-text search across any entity type |
| [`search_lookup_records`](search_lookup_records.md) | Searches records for lookup field association |
| [`list_entity_records`](list_entity_records.md) | Generic entity grid for entity types without a dedicated list tool |

## Data mutation classification
Read-only entry point with downstream mutation potential.

The listing itself does not change data. Follow-up actions from the grid (update, edit fields) can trigger write operations via separate tools.
