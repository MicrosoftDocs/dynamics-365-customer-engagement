---
title: Edit email template
description: Learn how to use the Edit email template capability in Dynamics 365 Customer Service.
ms.date: 08/13/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Edit email template

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to open a known email template in an edit form.

## What it does

The assistant loads the template identified by its Dataverse template ID and displays its current content in an edit form. You can update the name, subject, body, description, template type, language, and sharing level.

For title or subject searches, use `show_email_template` first. It finds the template and opens the same edit experience.

## Try prompts like

- Edit the email template with ID 00000000-0000-0000-0000-000000000000.
- Update the template with ID 00000000-0000-0000-0000-000000000000.
- Modify the email template with ID 00000000-0000-0000-0000-000000000000.

## What you'll see in chat

The assistant displays the selected template in an edit form with its existing values pre-filled.

## What you can do from the app-in-chat component

- Review and update template content.
- Change the template category, language, or sharing level.
- Save the updated template to Dynamics 365.

## Helpful tips

- Use `show_email_template` when you know the title or subject but not the template ID.
- Confirm the template category before saving so merge fields remain compatible.
- Organization templates are shared; personal templates are visible only to their owner.

## What happens next

- Apply the updated template to an email.
- Open another saved template.
- Create a new email template.

## Does this change data?

**No, this doesn't change data.**

Opening the edit form is read-only. Selecting **Update** in the form calls `save_email_template`, which changes the existing template.

## Prerequisites

This tool requires read and write access to email templates.

Learn more in [Configure email](/dynamics365/customer-service/administer/customer-service-hub-user-guide-email-admin).

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Edit email template |
| Internal tool name | `edit_email_template` |
| Purpose | Loads a known email template into the edit form |

## Tool behavior

Loads one email template by GUID and opens its current values in the edit form. It doesn't search for templates and doesn't write data until the user saves through `save_email_template`.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable because opening the form is read-only. |
| `idempotentHint` | Not set | Uses the default behavior for read-only requests. |
| `openWorldHint` | Not set | Uses the default behavior for Dataverse requests. |

## Input concepts

### Template identity

| Input | Description | Required |
|---|---|---|
| `templateId` | GUID of the email template to load. | Yes |

## Response and UI behavior

This MCP tool is supported by an MCP app.

### Response type

Interactive component (app-in-chat)

The component displays the existing template fields and changes its primary action to **Update**. If the template can't be loaded, the response explains the Dataverse error.

## Routing notes

Use `edit_email_template` when the user wants to:

- Open a template when its GUID is already known.
- Continue an edit flow started from a template list.

Don't use `edit_email_template` when the user wants to:

- Find a template by title or subject - use `show_email_template`.
- Create a new template - use `create_email_template`.

## Related tools

| Tool | Relationship |
|---|---|
| [`show_email_template`](show_email_template.md) | Finds templates and opens a selected result |
| [`save_email_template`](save_email_template.md) | Saves changes made in the edit form |
| [`create_email_template`](create_email_template.md) | Opens a blank form for a new template |
| [`apply_email_template`](apply_email_template.md) | Applies an existing template to an email |

## Data mutation classification

Read-only.

The entry tool only loads data. Selecting **Update** triggers `save_email_template`, which updates the existing template.
