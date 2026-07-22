---
title: View Account
description: Learn how to use the View Account capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# View Account

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]
- "Show Contoso account details"
- "Open account Adventure Works"
- "View the Fabrikam account"
- "Show me the Northwind Traders account"
- "What are the details for the Litware account?"
- "Open this account"

## What you'll see in chat
The assistant displays an interactive account form as an app-in-chat component. The form shows account fields such as name, industry, address, phone number, email, and any custom fields configured on the form.

## Helpful tips
- You can use the account name or a GUID to open a specific account.
- If the assistant says multiple accounts match, try "list accounts" and then select the one you want.
- For a quick text summary instead of the full form, say "summarize this account" or "brief me about Contoso."

> [!TIP]
> After the account form appears, you can ask follow-up questions like "show contacts at this account" or "list cases for this account."

## What happens next
After the account form appears, you can continue with prompts like:

- "Summarize this account"
- "Show contacts at this account"
- "Update the phone number on this account"
- "List cases for this account"

## Does this change data?
**No, viewing an account does not change data.**

The account form is read-only by default. Inline edits from the form can change data. The assistant asks for confirmation before making changes.

## What you can do from the app-in-chat component
From the account form in chat, you can:

- Review all account details
- Edit supported fields inline
- Open the full account form in Dynamics 365
- Continue working with the account in chat using follow-up prompts

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | View Account |
| Internal tool name | `get_account` |
| Purpose | Opens the full form view of a single CRM account record with inline editing |

## Tool behavior
Opens the full form view of a single CRM account record with inline editing. Accepts a GUID or account name and resolves unique names automatically. Returns an error when multiple accounts match the name; use `list_accounts` to disambiguate.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | Not set | Read-only in practice; this tool does not modify data directly. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Record identifier

| Input | Description | Required |
|---|---|---|
| `recordId` | `recordId` (string, required). An account GUID or account name to search for. When a name is provided, the tool resolves it server-side. If multiple accounts match, an error is returned directing the user to `list_accounts` for disambiguation. | Yes |

### Form selection

| Input | Description | Required |
|---|---|---|
| `formId` | `formId` (string, optional). A system form GUID to use for rendering. Defaults to the primary main form when omitted. | No |

## Response and UI behavior
This tool renders an interactive app-in-chat account form.

This MCP tool is supported by an MCP App. 

### Response type

Interactive form (detail view)

The form displays the account's fields as defined by the selected system form, including account name, industry, address, phone, email, and custom fields.

## Routing notes
Use `get_account` for:

- "open account X", "show account details", "view Contoso"
- Any prompt that names a specific account and wants to see its form

Don't use `get_account` when the prompt explicitly says:

- **"List" or "show my accounts"** - route to `list_accounts`
- **"Summarize" or "brief me about"** a company - route to `summarize_account`
- **A generic entity by logical name** - route to `get_entity_record`

## Related tools
| Tool | Relationship |
|---|---|
| [`list_accounts`](list_accounts.md) | Lists accounts; use to disambiguate when multiple match a name |
| [`summarize_account`](summarize_account.md) | AI text summary of account context |
| [`update_entity_record`](update_entity_record.md) | Updates fields on the account record |
| [`get_contact`](get_contact.md) | Opens a contact form; often used alongside account detail |
| [`get_entity_record`](get_entity_record.md) | Generic entity detail for non-account entity types |

## Data mutation classification
Read-only entry point with downstream mutation potential.

The form view itself does not change data. Inline edits trigger write operations via `update_entity_record`.
