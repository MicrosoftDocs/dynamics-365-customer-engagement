---
title: Show email template
description: Learn how to use the Show email template capability in Dynamics 365 Customer Service.
ms.date: 08/13/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service,field-service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Show email template

**Applies to:** Dynamics 365 Customer Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability to find saved email templates and open one for review or editing.

## What it does

The assistant searches template titles and subjects, filters by template type, or opens a template directly when its ID is known. If you don't provide a filter, it lists the 200 most recently modified templates.

One match opens the template in an edit form. Multiple matches appear in a paginated list, and no matches produce a text response so you can refine the search.

## Try prompts like

- Show me the case closure template.
- Find templates with a subject containing escalation.
- Show all email templates.
- Show templates for cases.
- Open the email template with ID 00000000-0000-0000-0000-000000000000.

## What you'll see in chat

The assistant either displays a list of matching templates, opens a single template in an edit form, or explains that no templates matched.

## What you can do from the app-in-chat component

- Review template titles, categories, languages, and modified dates.
- Move through result pages.
- Select a template to open its edit form.

## Helpful tips

- Search terms match both the template title and subject.
- Filter by template type when a broad search returns too many results.
- Use the template ID when you already know the exact template to open.

## What happens next

- Update the selected template in the edit form.
- Apply the template to an email.
- Create a new email template.

## Does this change data?

**No, this doesn't change data.**

Opening or searching for templates is read-only. Saving changes from the edit form uses `save_email_template`, which updates the selected template.

## Prerequisites

This tool requires read access to email templates.

Learn more in [Configure email](/dynamics365/customer-service/administer/customer-service-hub-user-guide-email-admin).

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Show email template |
| Internal tool name | `show_email_template` |
| Purpose | Finds saved email templates and opens a selected template for review or editing |

## Tool behavior

Searches template titles and subjects, filters by Dataverse template type, lists recent templates, or loads a template by ID. It doesn't create a template or save edits.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable because the tool is read-only. |
| `idempotentHint` | Not set | Uses the default behavior for read-only requests. |
| `openWorldHint` | Not set | Uses the default behavior for Dataverse requests. |

## Input concepts

### Template selection

| Input | Description | Required |
|---|---|---|
| `keywords` | Text to match against the template title or subject. Maximum length is 128 characters. | No |
| `templateId` | GUID of a specific template. When supplied, the tool skips search and opens that template. | No |
| `templateTypeCode` | Dataverse template type code, such as 112 for Case, 1 for Account, 2 for Contact, or 8 for User. | No |

## Response and UI behavior

This MCP tool is supported by an MCP app.

### Response type

Interactive component (app-in-chat)

Zero matches return text without an app-in-chat component. One match or a direct ID opens the edit form. Multiple matches render a list with 10 templates per page.

## Routing notes

Use `show_email_template` when the user wants to:

- Find templates by title or subject.
- List all templates or templates for a specific Dataverse entity type.
- Open a known template by ID.

Don't use `show_email_template` when the user wants to:

- Create a new template - use `create_email_template`.
- Apply a template to an email - use `apply_email_template`.

## Related tools

| Tool | Relationship |
|---|---|
| [`edit_email_template`](edit_email_template.md) | Loads a known template into the edit form |
| [`create_email_template`](create_email_template.md) | Opens a blank form for a new template |
| [`save_email_template`](save_email_template.md) | Saves changes made in the edit form |
| [`apply_email_template`](apply_email_template.md) | Applies an existing template to an email |

## Data mutation classification

Read-only.

Data changes only when the user saves the opened template through `save_email_template`.
