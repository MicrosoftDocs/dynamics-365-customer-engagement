---
title: Create Case from Email
description: Learn how to use the Create Case from Email capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Create Case from Email

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you receive an email that needs a new support case. The assistant creates the case, links the email to it, and sets up the customer contact automatically.

## What it does
The assistant creates a new support case based on the email's content. It uses the email subject as the case title unless you specify a different one, and looks up the sender as a contact in Dynamics 365. If the sender doesn't have a contact record yet, one is created automatically. The email is linked to the new case so it appears on the case timeline.

## Try prompts like
- "Create a case from this email"
- "Convert the email to a support case"
- "Open a case from the customer's email"
- "File a ticket from this email"
- "Create a case for the billing complaint email"

## What you see in chat
The assistant shows a text confirmation with the new case number, case ID, and contact information. If a new contact was created for the sender, it's noted in the response.

## Helpful tips
- If you're not sure whether a case already exists for this email, use the prompt, "match this email to existing cases" first. That way, you avoid creating a duplicate case.
- The case title defaults to the email subject. If you want a different title, include it in your prompt.
- The sender is automatically linked as the case customer. If the sender doesn't have a contact record in Dynamics 365, one is created.
- After the case is created, you can open it to add more details or start working on it.

> [!TIP]
> A common workflow is: view email, check for matching cases, then create a new case if none match - or link to an existing case if one does.

## What happens next
After the case is created, you can continue with prompts like:

- "Open the case"
- "Summarize the case"
- "Draft a reply to the customer"
- "Update the case priority to high"
- "Assign the case to the billing team"

## Does this change data?

Yes. This creates a new case.

A new support case (incident) is created in Dynamics 365, the email is linked to it, and a contact record may be created for the sender. The assistant asks for confirmation before creating the case.

## Prerequisites
This tool requires the following:

- Automatic record creation rules

Learn more in [Automatically create or update records](/dynamics365/customer-service/administer/automatically-create-update-records).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Create Case from Email |
| Internal tool name | `create_case_from_email` |
| Purpose | Creates a new support case from an email |

## Tool behavior
Creates a new support case from an email. Looks up the sender as a contact (creates one if not found), creates an incident linked to the email, and sets the contact as the customer. Use when the user asks to convert an email into a case, open a case from an email, or file a ticket from an email.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool creates data - Microsoft 365 Copilot prompts for confirmation. |
| `destructiveHint` | `false` | Creating a case is additive, not destructive. |
| `idempotentHint` | `false` | Each call may create a new case - not safe to retry. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Email identifier

| Input | Description | Required |
|---|---|---|
| `emailId` | `emailId` (the Dataverse email activity GUID to create a case from, required). | Yes |

### Sender context

| Input | Description | Required |
|---|---|---|
| `senderEmail` | `senderEmail` (sender email address for contact lookup - if omitted, extracted from the email record). | No |

### Case details

| Input | Description | Required |
|---|---|---|
| `title`, `description` | `title` (case title - if omitted, uses the email subject), `description` (email body text - if omitted, extracted from the email record). | No |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. The tool returns the new case ID, ticket number, and contact information (whether a new contact was created or an existing one was linked).

## Routing notes
Use `create_case_from_email` for:

- "Convert this email to a case", "create a case from this email", "file a ticket"
- When no existing case matches the email (after `match_cases` returns no results)

Don't use `create_case_from_email` when:

- An existing case matches the email - use `link_email_to_case` instead
- The user wants to check for matching cases first - use `match_cases`
- The user wants to create a case without an email context - use case creation tools

## Related tools
| Tool | Relationship |
|---|---|
| [`match_cases`](match_cases.md) | Finds existing cases that may match (called before creating a new one) |
| [`link_email_to_case`](link_email_to_case.md) | Links the email to an existing case (alternative to creating a new one) |
| [`view_email`](view_email.md) | Displays the email content before case creation |
| [`get_case`](get_case.md) | Opens the newly created case |

## Data mutation classification
Write / mutation.

This tool creates a new incident record, optionally creates a contact record, and links the email to the case in Dataverse. Microsoft 365 Copilot prompts the user for confirmation before it runs.
