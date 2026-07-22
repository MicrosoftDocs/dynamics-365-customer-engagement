---
title: Contact Summary
description: Learn how to use the Contact Summary capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Contact Summary

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want a quick overview of a contact without opening the full contact form.

## What it does
The assistant generates a text summary of the contact, including:

- Case history statistics
- Entitlement tier (based on the parent account)
- Job title
- How long the contact has been a customer (relationship tenure)

This is useful for getting context on a person before handling their case, during triage, or when you need a quick refresher on the customer relationship.

## Try prompts like
- "Summarize contact Jordan Reyes"
- "Tell me about Scarlett Hughes"
- "What's the case history for this customer?"
- "Give me context on Jordan"
- "Who is Alex Johnson?"
- "Summarize the contact for this case"

## What you'll see in chat
The assistant displays a text summary directly in the chat conversation. There is no interactive widget or app-in-chat component for this capability.

## Helpful tips
- You can refer to the contact by name. The assistant finds the contact for you automatically.
- Partial names work too, for example "summarize Jordan" will search for contacts matching "Jordan."
- If you already have a case open, you can say "summarize the contact for this case."
- For the full contact form with all fields, say "open contact Jordan Reyes" instead.
- The entitlement tier comes from the parent account, not the contact directly.

> [!TIP]
> The contact summary is a good starting point before handling a customer interaction or reviewing a new case.

## What happens next
After the summary appears, you can continue with prompts like:

- "Open the contact form for Jordan Reyes"
- "Show the account for this contact"
- "List cases for this customer"
- "Summarize the account for this contact"

## Does this change data?
**No, summarizing a contact does not change data.**

The summary is read-only and does not modify any records.

## Prerequisites
This tool requires the following:

- Copilot features to be enabled

Learn more in [Manage Copilot features in Customer Service](/dynamics365/customer-service/administer/configure-copilot-features).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Contact Summary |
| Internal tool name | `summarize_contact` |
| Purpose | Returns an AI-generated text summary of a CRM contact, covering case history stats, entitlement tier (via the parent account), job title, and relationship tenure |

## Tool behavior
Returns an AI-generated text summary of a CRM contact, covering case history stats, entitlement tier (via the parent account), job title, and relationship tenure. This is a text-only tool with no app-in-chat widget. Accepts a contact name or contact GUID; at least one is required.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Contact name

| Input | Description | Required |
|---|---|---|
| `contactName` | `contactName` (string, optional). Contact full name or partial name to search for. At least one of `contactName` or `contactId` is required. | Varies |

### Contact identifier

| Input | Description | Required |
|---|---|---|
| `contactId` | `contactId` (string, optional). Dataverse `contactid` GUID. If provided, skips the name search and fetches directly. At least one of `contactName` or `contactId` is required. | Varies |

## Response and UI behavior
This tool returns a text-only response with no app-in-chat component.

This MCP tool is supported by an MCP App. 

### Response type

Text narrative

The response includes case history statistics, entitlement tier (derived from the parent account), job title, and relationship tenure.

## Routing notes
Use `summarize_contact` for:

- "summarize contact", "tell me about" + a person's name
- Quick customer context during triage
- Learning about a contact's case history and entitlement

Don't use `summarize_contact` when the prompt explicitly says:

- **"Open" or "view" contact details** - route to `get_contact`
- **"List contacts"** - route to `list_contacts`
- **"Summarize account" (a company, not a person)** - route to `summarize_account`

## Related tools
| Tool | Relationship |
|---|---|
| [`get_contact`](get_contact.md) | Opens the full contact form for detailed field-level view |
| [`list_contacts`](list_contacts.md) | Lists contacts for browsing or disambiguation |
| [`summarize_account`](summarize_account.md) | Summarizes an account (company) rather than a contact (person) |
| [`get_account`](get_account.md) | Opens the parent account form |

## Data mutation classification
Read-only.

This tool does not change data. It reads contact, account, case, and entitlement records to generate a summary.
