---
title: View Contact
description: Learn how to use the View Contact capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# View Contact

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to see the full details of a specific contact directly in chat.

## What it does
The assistant opens a detailed contact form for the person you name or specify by ID. You can see all contact fields, edit supported fields inline, and navigate to the full form in Dynamics 365.

If you provide a contact name and multiple contacts match, the assistant lets you know and suggests using "list contacts" to find the right one.

## Try prompts like
- "Open contact Jordan Reyes"
- "Show me Scarlett Hughes"
- "View contact details for Alex Johnson"
- "Open the contact form for Maria Garcia"
- "What are the details for Jordan?"
- "Show this contact"

## What you'll see in chat
The assistant displays an interactive contact form as an app-in-chat component. The form shows contact fields such as name, email, phone, company, job title, and any custom fields configured on the form.

## Helpful tips
- You can use the contact's name or a GUID to open a specific contact.
- If the assistant says multiple contacts match, try "list contacts" and then select the one you want.
- For a quick text summary instead of the full form, say "summarize contact Jordan Reyes."
- For the parent company's details, say "open account" followed by the company name.

> [!TIP]
> After the contact form appears, you can ask follow-up questions like "summarize this contact" or "list cases for this contact."

## What happens next
After the contact form appears, you can continue with prompts like:

- "Summarize this contact"
- "Show the account for this contact"
- "List cases for this contact"
- "Update the email address on this contact"

## Does this change data?
**No, viewing a contact does not change data.**

The contact form is read-only by default. Inline edits from the form can change data. The assistant asks for confirmation before making changes.

## What you can do from the app-in-chat component
From the contact form in chat, you can:

- Review all contact details
- Edit supported fields inline
- Open the full contact form in Dynamics 365
- Continue working with the contact in chat using follow-up prompts

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | View Contact |
| Internal tool name | `get_contact` |
| Purpose | Opens the full form view of a single CRM contact record with inline editing |

## Tool behavior
Opens the full form view of a single CRM contact record with inline editing. Accepts a GUID or contact name and resolves unique names automatically. Returns an error when multiple contacts match the name; use `list_contacts` to disambiguate.

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
| `recordId` | `recordId` (string, required). A contact GUID or contact name to search for. When a name is provided, the tool resolves it server-side. If multiple contacts match, an error is returned directing the user to `list_contacts` for disambiguation. | Yes |

### Form selection

| Input | Description | Required |
|---|---|---|
| `formId` | `formId` (string, optional). A system form GUID to use for rendering. Defaults to the primary main form when omitted. | No |

## Response and UI behavior
This tool renders an interactive app-in-chat contact form.

This MCP tool is supported by an MCP App. 

### Response type

Interactive form (detail view)

The form displays the contact's fields as defined by the selected system form, including full name, email, phone, company, job title, and custom fields.

## Routing notes
Use `get_contact` for:

- "open contact X", "show contact details", "view Jordan Reyes"
- Any prompt that names a specific contact and wants to see their form

Don't use `get_contact` when the prompt explicitly says:

- **"List" or "show my contacts"** - route to `list_contacts`
- **"Summarize" a contact** - route to `summarize_contact`
- **A generic entity by logical name** - route to `get_entity_record`

## Related tools
| Tool | Relationship |
|---|---|
| [`list_contacts`](list_contacts.md) | Lists contacts; use to disambiguate when multiple match a name |
| [`summarize_contact`](summarize_contact.md) | AI text summary of contact context and case history |
| [`update_entity_record`](update_entity_record.md) | Updates fields on the contact record |
| [`get_account`](get_account.md) | Opens an account form; often used alongside contact detail |
| [`get_entity_record`](get_entity_record.md) | Generic entity detail for non-contact entity types |

## Data mutation classification
Read-only entry point with downstream mutation potential.

The form view itself does not change data. Inline edits trigger write operations via `update_entity_record`.
