---
title: List contacts
description: Learn how to use the List contacts capability in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# List contacts

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to find contacts, review them in chat, and take action without leaving the conversation.

## What it does

The assistant shows a list of contacts that match your filters. You can filter by:

- Whether the contact is assigned to you.
- Contact status (active or inactive).
- Parent company.
- Contact name.

Results appear in an interactive contact list inside chat.

## Try prompts like

- Show my contacts.
- List my active contacts.
- Show contacts at Contoso.
- List inactive contacts.
- Show contacts assigned to me.
- Find Jordan Reyes.
- List all contacts.
- Show contacts at Fabrikam.

## What you'll see in chat

The assistant displays an interactive contact list as an app-in-chat component. The list shows matching contacts with key details such as name, email, phone, company, and job title.

## Helpful tips

- Say "my contacts" or "assigned to me" to see only contacts you own.
- Use status words like active or inactive to filter results.
- Use a company name to find contacts at a specific organization, for example "show contacts at Contoso."
- Combine filters by saying something like "show my active contacts at Fabrikam."
- If you want a text summary of a contact, say "summarize contact Jordan Reyes" instead.

> [!TIP]
> After the contact list appears, you can ask follow-up questions about any contact shown. For example, "open the first contact" or "summarize Jordan Reyes."

## What happens next

After the list appears, you can continue with prompts like:

- Open the first contact.
- Summarize this contact.
- Show the account for this contact.
- Update this contact's email address.

## Does this change data?

**No, listing contacts doesn't change data.**

The contact list is read-only. Follow-up actions from the list, such as updating a field, can change data. The assistant asks for confirmation before making changes.

## What you can do from the app-in-chat component

From the contact list in chat, you can:

- Scan and review matching contacts in a sortable grid.
- Select a contact to see more details.
- Open the full contact form in Dynamics 365.
- Update supported fields inline when available.
- Continue working with the contact in chat using follow-up prompts.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | List contacts |
| Internal tool name | `list_contacts` |
| Purpose | Lists customer contacts filtered by status, parent company, owner, or name search and renders them in an interactive grid-style app-in-chat experience |

## Tool behavior

Lists customer contacts filtered by status, parent company, owner, or name search and renders them in an interactive grid-style app-in-chat experience. The `search` parameter performs a contains-match against the contact name.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Search

| Input | Description | Required |
|---|---|---|
|—| free-text string. Performs a contains-match against the contact name. | No |

### Company

| Input | Description | Required |
|---|---|---|
|—| filter by parent company name (contains match). Use when the user specifies a company or organization. | No |

### Status

| Input | Description | Required |
|---|---|---|
| `active`, `inactive` | `active` or `inactive`. Filters by contact state code. | No |

### Ownership scope

| Input | Description | Required |
|---|---|---|
| `assignedToMe` | `assignedToMe` (boolean). When true, scopes results to contacts owned by the current user. | No |

### Result limit

| Input | Description | Required |
|---|---|---|
| `top` | `top` (integer). Maximum number of contacts to return. Defaults to 10, max 200. | No |

### Additional filters

| Input | Description | Required |
|---|---|---|
| `additionalFilter` | `additionalFilter` (key-value map). Arbitrary OData filter conditions merged with AND. | No |

## Response and UI behavior

This tool renders an interactive app-in-chat contact grid.

This MCP tool is supported by an MCP app.

### Response type

Interactive grid (list view)

The grid displays contact name, email, phone, company, and job title. Users can select a row to drill into contact detail or take follow-up actions through chat.

## Routing notes

Use `list_contacts` for:

- my contacts, contacts assigned to me, my active contacts.
- Status-based filtering (active, inactive).
- Company-based filtering.
- Contact name search.

Don't use `list_contacts` when the prompt explicitly says:

- **A specific contact by name for detail view**—route to `get_contact`.
- **"Summarize" a contact (person)**—route to `summarize_contact`.
- **Free-text search across multiple entity types**—route to `search_entities`.
- **Lookup field association**—route to `search_lookup_records`.

## Related tools

| Tool | Relationship |
|---|---|
| [`get_contact`](get_contact.md) | Opens the full contact form for a selected contact |
| [`summarize_contact`](summarize_contact.md) | Generates an AI-powered contact summary |
| [`list_accounts`](list_accounts.md) | Lists accounts; often used alongside contact browsing |
| [`search_entities`](search_entities.md) | Free-text search across any entity type |
| [`search_lookup_records`](search_lookup_records.md) | Searches records for lookup field association |
| [`list_entity_records`](list_entity_records.md) | Generic entity grid for entity types without a dedicated list tool |

## Data mutation classification

Read-only entry point with downstream mutation potential.

The listing itself doesn't change data. Follow-up actions from the grid (update, edit fields) can trigger write operations through separate tools.
