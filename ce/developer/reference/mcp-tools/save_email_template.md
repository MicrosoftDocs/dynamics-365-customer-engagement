---
title: Save Email Template
description: Learn how the Service Agent saves a new email template to Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Save Email Template

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

This capability is used internally by the email template creation form to save your new template to Dynamics 365.

## What it does
When you click Save in the email template creation form (opened by "create email template"), the assistant creates the template record in Dynamics 365. The saved template includes the name, subject, body, description, template type, language, and permission level (personal or organization-wide) that you set in the form.

You don't invoke this directly. It runs automatically when you save from the template creation form.

## Try prompts like
- "Create a new email template" (opens the form; Save triggers this action)
- "Make a template called 'Customer Follow-Up'"
- "Create an email template for case closures"

## What you'll see in chat
The assistant confirms the template was saved successfully and returns the new template ID. If there was an issue (such as a missing required field), you'll see an error message explaining what needs to be corrected.

## Helpful tips
- The template name (title) is required. Make sure you fill it in before saving.
- Personal templates are visible only to you. Set the permission to Organization to share with your team.
- The default language is English (1033). Change the language code if you're creating templates in other languages.
- If the save fails, check that all required fields are filled in and try again.

## What happens next
After the template is saved, you can continue with prompts like:

- "Apply that template to this case"
- "Recommend templates for this case"
- "Create another template"
- "Draft an email for this case"

## Does this change data?

Yes. Saving a template creates a new email template record in Dynamics 365.

The template is stored permanently and available for future use in email composition workflows.

## Prerequisites
This tool requires the following:

- Template author role

Learn more in [Configure email](/dynamics365/customer-service/administer/customer-service-hub-user-guide-email-admin).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Save Email Template |
| Internal tool name | `save_email_template` |
| Purpose | Creates a new email template record in Dynamics 365 |

## Tool behavior
Creates a new email template record in Dynamics 365. Called from the `create_email_template` widget when the user clicks Save. Not intended for direct invocation by the agent - the widget manages the save flow.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool creates data - Microsoft 365 Copilot prompts for confirmation. |
| `destructiveHint` | `false` | Creating a template is additive, not destructive. |
| `idempotentHint` | `false` | Each call creates a new template - not safe to retry. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Template identity

| Input | Description | Required |
|---|---|---|
| `title` | `title` (template name, required). | Yes |

### Content

| Input | Description | Required |
|---|---|---|
| `subject`, `body`, `description` | `subject` (email subject line), `body` (email body HTML), `description` (optional template description). | No |

### Classification

| Input | Description | Required |
|---|---|---|
| `templateTypeCode` | `templateTypeCode` (Dataverse templatetypecode picklist value, e.g. 112 for Case), `languageCode` (LCID, e.g. 1033 for English - defaults to 1033). | No |

### Permissions

| Input | Description | Required |
|---|---|---|
| `isPersonal` | `isPersonal` (true = Personal/owning user only, false = Organization/shared - defaults to true). | No |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. The tool returns the new template's ID as confirmation.

## Routing notes
Use `save_email_template` for:

- Internal widget use only - called when the user clicks Save in the template creation form

Don't use `save_email_template` directly:

- To open the template creation form - use `create_email_template`
- The agent should not call this tool directly - it's invoked by the widget

## Related tools
| Tool | Relationship |
|---|---|
| [`create_email_template`](create_email_template.md) | Opens the template form widget (upstream - calls save_email_template on Save) |
| [`recommend_email_templates`](recommend_email_templates.md) | Lists existing templates |
| [`apply_email_template`](apply_email_template.md) | Applies an existing template to a case |

## Data mutation classification
Write / mutation.

This tool creates a new email template record in Dataverse. M365 Copilot prompts the user for confirmation before execution.
