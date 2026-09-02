---
title: Create entity record
description: Learn how to use the Create entity record capability in Dynamics 365 Customer Service.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service,sales
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Create entity record

**Applies to:** Dynamics 365 Customer Service, Dynamics 365 Sales

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to create a new Dataverse record directly from chat.

## What it does

The assistant creates a new case (incident), account, or contact record in Dynamics 365. You provide the details for the record, and the assistant creates it using only the values you give—it never invents or guesses field values.

When you refer to a related record by name (for example, the customer on a case, or the company a contact works for), the assistant looks up the matching record for you. If the name matches more than one record, the assistant asks which one you mean. If a required field is missing (such as the case title, the account name, or the contact's last name), the assistant asks you for it before creating the record.

## Try prompts like

- Create a case titled 'Espresso machine leaking' for the Contoso account.
- Open a support case for a billing issue on the Contoso account.
- Log a case 'Grinder making loud noise' for Fabrikam.
- Create a new account called Northwind Traders.
- Add a contact named Priya Nair at Contoso.
- Create a contact, last name Okafor, first name Ada, email ada@fabrikam.com.

## What you'll see in chat

The assistant confirms the new record was created and tells you its name and the entity type. If more information is needed first, the assistant tells you which fields are missing or asks you to choose between matching related records.

## Helpful tips

- Provide the record details up front to avoid follow-up questions—for a case, the title and the related customer; for an account, the company name; for a contact, at least the last name.
- When you name a related record (like a customer account or a contact's company), the assistant resolves it automatically. If several match, pick the one the assistant lists.
- Describe what you want naturally. The assistant picks the right tool.

> [!TIP]
> If the assistant asks for a missing required field or to disambiguate a related record, answer in chat and the assistant continues creating the record.

## What happens next

After the record is created, you can continue with prompts like:

- Show this record.
- Update a field on this record.
- Create another record.
- Open this record in Dynamics 365.

## Does this change data?

**Yes, this creates a new Dataverse record.**

The assistant creates the record as soon as it has the required details—there's no separate confirmation step. You can update the record afterward if you need to change anything.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required. You need the Dataverse create privilege on the entity you're creating.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Create entity record |
| Internal tool name | `create_entity_record` |
| Purpose | Creates a new case (incident), account, or contact record, resolving lookup names and preflighting required fields |

## Tool behavior

Creates a new case (incident), account, or contact record in Dynamics 365. Use when the user asks to create, open, or log a support case, or to create a new account (company) or contact (person). For any activity (task, phone call, appointment, email, letter, fax, social activity) use `create_activity`; for a note use `create_note`. Lookup fields provided by name (such as the case customer or a contact's company) are resolved to the related record automatically; an ambiguous name returns candidates to disambiguate. If a required field is missing, the tool returns the missing fields so the assistant can ask for them and retry. Entity types outside case, account, and contact—including system and security entities (users, teams, roles, business units)—cannot be created here.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | This tool creates data without hard-delete behavior. |
| `idempotentHint` | `false` | Repeated calls create additional records. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts

### Entity type

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | `entityLogicalName` (string, required). The Dataverse entity logical name of the record to create: `incident` (case), `account`, or `contact`. | Yes |

### Field values

| Input | Description | Required |
|---|---|---|
| `fields` | `fields` (key-value map). Scalar field logical names to values (text, numbers, option-set codes, ISO dates). Example: `{ "title": "Espresso machine leaking" }` for a case, `{ "name": "Northwind Traders" }` for an account, or `{ "lastname": "Nair", "firstname": "Priya" }` for a contact. | No |

### Lookup values

| Input | Description | Required |
|---|---|---|
| `lookups` | `lookups` (key-value map). Lookup field logical names to a related record name or GUID. Example: `{ "customerid": "Contoso" }` on a case, or `{ "parentcustomerid": "Contoso" }` on a contact. Names are resolved automatically; ambiguous names return candidates. | No |

## Response and UI behavior

This tool returns a text response. On success it reports the created record's name and entity type. When more input is needed, it returns a structured re-prompt describing the missing required fields or the lookup candidates to choose from, so the assistant can gather the missing input and try again.

### Response type

Text response (no app-in-chat component)

## Routing notes

Use `create_entity_record` for:

- Creating, opening, or logging a support case (`incident`).
- Creating a new account—a company or organization (`account`).
- Creating a new contact—a person (`contact`).

Don't use `create_entity_record` when:

- **Creating any activity** (task, phone call, appointment, email, letter, fax, social activity)—route to `create_activity`.
- **Creating a note**—route to `create_note`.
- **Updating an existing record**—route to `update_entity_record`.
- **Deleting a record**—route to `delete_entity_record`.
- **Creating any other entity** (users, teams, roles, business units, opportunities, leads, or custom tables)—the tool rejects these.

## Related tools

| Tool | Relationship |
|---|---|
| [`get_entity_record`](get_entity_record.md) | View a record after creating it |
| [`update_entity_record`](update_entity_record.md) | Update fields on an existing record |
| [`delete_entity_record`](delete_entity_record.md) | Delete a record |
| [`list_entity_records`](list_entity_records.md) | List records for an entity type |

## Data mutation classification

Write operation (non-destructive, non-idempotent).

This tool creates data. A new record is inserted directly into Dataverse. The operation is not idempotent; repeated calls create additional records.
