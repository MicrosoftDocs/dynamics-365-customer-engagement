---
title: Search lookup records
description: Learn how to use the Search lookup records capability in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service,field-service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Search lookup records

**Applies to:** Dynamics 365 Customer Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you need to find a record to associate with another record, such as setting a customer on a case or assigning an account to an opportunity.

## What it does

The assistant searches Dynamics 365 records by name, or accounts and contacts by phone number, so you can pick one to link to another record. This is typically used when you want to:

- Set or change the customer on a case.
- Assign an account or contact to a lookup field.
- Link a record to another record.
- Pick a user, team, or queue for assignment.

After the search results appear, the assistant asks you which record to select, then applies the association using a separate update step.

## Try prompts like

- Find a contact to set as the customer on this case.
- Pick an account for this opportunity.
- Assign this case to a user named Alex.
- Set the customer on this case to Jordan Reyes.
- Find an account named Contoso for this lookup.
- Find the contact with phone number +1-555-0142 for this lookup.
- Change the customer to Fabrikam.

## What you'll see in chat

The assistant displays a text list of matching records directly in the chat conversation, including the record name and entity type. The assistant then asks you which record to select. There is no interactive widget for this capability.

## Helpful tips

- You can search across multiple entity types at once, for example both accounts and contacts for a Customer lookup.
- Phone lookup supports account and contact targets and checks their standard phone fields.
- Phone lookup uses primary common fields by default. Exhaustive coverage
  prioritizes those fields and searches up to 48 readable Dataverse
  Phone-formatted fields, including custom fields.
- After you pick a record, the assistant uses a separate step to apply the association.
- For general searching or browsing, say "search for" or "list" instead. This tool is specifically for finding records to link.
- The assistant asks for confirmation before applying the association.

> [!TIP]
> This capability is most useful when you are in the middle of updating a record and need to find a related record to link.

## What happens next

After you select a record, the assistant applies the association. You can then continue with prompts like:

- Show this record.
- Update another field.
- Summarize this case.
- Open the linked record.

## Does this change data?

**No, the search itself doesn't change data.**

The search is read-only. The follow-up step that applies the association changes data. The assistant asks for confirmation before making that change.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Search lookup records |
| Internal tool name | `search_lookup_records` |
| Purpose | Searches Dataverse records by name or phone to find a specific record for association with another record through a lookup field |

## Tool behavior

Searches Dataverse records by name, or account and contact records by phone, to find a specific record for association with another record through a lookup field. Supports searching across one or many entity types in a single call. A phone-only request with no entity scope searches both accounts and contacts. Primary phone coverage uses product-curated common fields. Exhaustive coverage prioritizes those fields and searches up to 48 readable Dataverse Phone-formatted fields. When both `search` and `phone` are provided, both predicates must match. When metadata or field limits, candidate retrieval, or the requested result limit omits matches, the response includes `phoneLookupTruncated: true` and the narration warns that additional matches may exist.

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
| `entityLogicalName` | `entityLogicalName` (string, optional). A single entity type to search. Provide this or `entityLogicalNames`, not both. | No |

### Entity scope (multiple)

| Input | Description | Required |
|---|---|---|
| `entityLogicalNames` | `entityLogicalNames` (string array, optional). Multiple entity types to search simultaneously (for example, `['account', 'contact']` for Customer lookup fields). Maximum 10 entity types. | No |

### Search term

| Input | Description | Required |
|---|---|---|
| `search` | `search` (string). Search term to match against the entity primary name. At least one of `search` or `phone` is required. | Conditional |

### Phone

| Input | Description | Required |
|---|---|---|
| `phone` | Phone number for account or contact lookup. When entity scope is omitted, the tool searches both entity types. Accounts check `telephone1`, `telephone2`, and `telephone3`; contacts check `telephone1` and `mobilephone`. At least one of `search` or `phone` is required. | Conditional |

### Search coverage

| Input | Description | Required |
|---|---|---|
| `searchCoverage` | `primary` (default) searches curated common phone fields. `exhaustive` searches up to 48 readable Dataverse Phone-formatted fields and reports truncation when more exist. Applies when `phone` is supplied. | No |

### Result limit

| Input | Description | Required |
|---|---|---|
| `top` | `top` (integer, optional, max 100). Maximum records per entity type. Default 25. | No |

## Response and UI behavior

This tool returns a text-only response with no app-in-chat component.

This MCP tool is supported by an MCP app.

### Response type

Text list of matching records

The response includes matched records with their ID, entity type, display name, and optional secondary text. Phone results include the matched stored phone value, field, and match type. `phoneLookupTruncated: true` means metadata or field limits, candidate retrieval, or the requested result limit may have omitted additional matches. The assistant presents results and asks the user which record to select.

## Routing notes

Use `search_lookup_records` for:

- set as, assign as, change to, associate with, link to, set the customer, pick a contact for, find a record to attach.
- Any prompt where the goal is to find a record for lookup field association.
- Account or contact lookup association by phone number.

Don't use `search_lookup_records` when the prompt explicitly says:

- **General entity browsing or search**—route to `search_entities`.
- **Listing records by criteria**—route to `list_accounts`, `list_contacts`, or `list_cases`.
- **Viewing a record's details**—route to `get_entity_record`, `get_account`, or `get_contact`.

## Related tools

| Tool | Relationship |
|---|---|
| [`search_entities`](search_entities.md) | General entity search; use for browsing, not lookup association |
| [`update_entity_record`](update_entity_record.md) | Updates the lookup field after the user selects a record |
| [`update_case`](update_case.md) | Updates case-specific fields including customer lookup |
| [`list_accounts`](list_accounts.md) | Lists accounts; use when filtering rather than searching for association |
| [`list_contacts`](list_contacts.md) | Lists contacts; use when filtering rather than searching for association |

## Data mutation classification

Read-only.

This tool doesn't change data. It searches for records that can then be associated through a separate update tool.
