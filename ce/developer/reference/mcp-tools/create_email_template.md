---
title: Create email template
description: Learn how to use the Create Email Template capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Create email template

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to create a new email template that you or your team can reuse for common customer communications.

## What it does
The assistant opens an email template creation form inside chat where you can author a new Dynamics 365 email template. You can set the template name, subject, body, description, and template type (for example, Case, Account, or Contact). If you mention details in your prompt, the form opens with those fields pre-filled.

When you're satisfied with the template, select **Save** in the form to create it in Dynamics 365. The template is then available for future use when composing emails or applying templates to cases.

## Try prompts like
- "Create a new email template"
- "Make a template with subject 'Case Resolution Notification'"
- "Create an email template for case closures"
- "New email template called 'Follow-Up Request'"
- "Create a template for requesting additional information"
- "Make a case email template with a thank-you message"

## What you see in chat
The assistant displays an email template creation form as an app-in-chat component. The form includes fields for the template name, subject line, body, description, and template type.

## Helpful tips
- Include the template subject or name in your prompt to pre-fill the form. For example, "create a template with subject 'Escalation Notice'" saves you a step.
- Choose the correct template type so merge fields resolve properly. Use Case (112) for case-related templates.
- Personal templates are visible only to you. Organization templates are shared with your team.
- You can use HTML formatting in the template body for rich-text emails.

## What happens next
After the template is saved, you can continue with prompts like:

- "Apply that template to this case"
- "Recommend templates for this case"
- "Create another template"
- "Draft an email using the new template"

## Does this change data?

Yes. Saving the template creates a new email template record in Dynamics 365.

The creation form itself is read-only until you select **Save**. When saved, the template is stored in Dynamics 365 and available for future use.

## What you can do from the app-in-chat component
From the template creation form in chat, you can:

- Enter or edit the template name, subject, and body
- Set the template type (Case, Account, Contact, and others)
- Add an optional description
- Save the template to Dynamics 365

## Prerequisites
This tool requires the following:

- Template author role

Learn more in [Configure email](/dynamics365/customer-service/administer/customer-service-hub-user-guide-email-admin).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Create Email Template |
| Internal tool name | `create_email_template` |
| Purpose | Opens the email template creation form widget so the user can author a new Dynamics 365 email template |

## Tool behavior
Opens the email template creation form widget so the user can author a new Dynamics 365 email template. Accepts optional pre-fill values for title, subject, body, and template type. The actual Dataverse write happens via `save_email_template` when the user clicks Save in the widget.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | Microsoft 365 Copilot skips the confirmation prompt. The widget manages persistence via `save_email_template`. |
| `destructiveHint` | Not set | Not applicable (opens form for authoring). |
| `idempotentHint` | Not set | Not applicable (each call opens a form session). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Template content

| Input | Description | Required |
|---|---|---|
| `title`, `subject`, `body`, `description` | `title` (template name), `subject` (email subject), `body` (email body - HTML accepted), `description` (optional template description). | No |

### Template type

| Input | Description | Required |
|---|---|---|
| `templateTypeCode` | `templateTypeCode` (Dataverse templatetypecode picklist value, e.g. 112 for Case, 1 for Account, 2 for Contact, 8 for User). | No |

## Response and UI behavior
This tool renders an interactive template creation form.

This MCP tool is supported by an MCP app.

### Response type

Interactive component (app-in-chat)

The widget displays a form with fields for template name, subject, body, description, and type. The user fills in or edits the pre-populated fields and clicks Save.

## Routing notes
Use `create_email_template` for:

- "Create a template", "new email template", "make a template"
- Authoring new reusable email templates

Don't use `create_email_template` when:

- The user wants to use an existing template - use `recommend_email_templates` then `apply_email_template`
- The user wants to compose a one-off email - use `draft_email`

## Related tools
| Tool | Relationship |
|---|---|
| [`save_email_template`](save_email_template.md) | Persists the template to Dataverse (called by the widget on Save) |
| [`recommend_email_templates`](recommend_email_templates.md) | Lists existing templates for a case |
| [`apply_email_template`](apply_email_template.md) | Applies an existing template to a case |
| [`draft_email`](draft_email.md) | Composes a one-off email (not a template) |

## Data mutation classification
Read-only entry point with downstream mutation potential.

The tool is marked `readOnlyHint: true` and only opens the form widget. The actual Dataverse write occurs when the user selects **Save**, which triggers `save_email_template`.
