---
title: Apply Email Template
description: Learn how to use the Apply Email Template capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Apply Email Template

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to apply an existing email template to a case and review the result before sending.

## What it does
The assistant takes an email template and applies it to a specific case, automatically filling in any merge fields (such as the customer name, case number, or account details) from the case record. The result opens in an email compose form inside chat so you can review, edit, and send the message.

You can specify the template by name or pick one from a list of recommendations. If you aren't sure which template to use, ask the assistant to recommend templates first.

## Try prompts like
- "Apply the case closure template to this case"
- "Use the apology template for case CAS-01010-A0A0A0"
- "Apply the follow-up template"
- "Use the resolution template on this case"
- "Apply the next steps template to my current case"
- "Use template 'Thank You for Contacting Us' on this case"

## What you'll see in chat
The assistant displays an email compose form as an app-in-chat component. The form shows the template content with merge fields already filled in from the case data.

## Helpful tips
- Ask the assistant to recommend templates first if you don't know the exact template name. Say "recommend templates for this case" to see your options.
- The template's merge fields (like customer name or case number) are resolved automatically from the case record.
- You can edit the email freely after the template is applied — the compose form is fully editable.
- Pair this with "recommend email templates" to browse available templates before choosing one.

## What happens next
After the compose form appears, you can continue with prompts like:

- "Send this email"
- "Add a CC recipient"
- "Change the subject line"
- "Try a different template instead"

## Does this change data?
No. Applying a template doesn't change data.

The compose form is a preview. No email is sent until you explicitly send it. Sending the email from the compose form creates a new email activity on the case.

## What you can do from the app-in-chat component
From the email compose form in chat, you can:

- Review the pre-filled subject and body
- Edit the email content before sending
- Add or change recipients (To, CC, BCC)
- Send the email when you're ready

## Prerequisites
This tool requires: 

- Email templates configured in Dynamics 365 Customer Service

Learn more in [Configure email](/dynamics365/customer-service/administer/customer-service-hub-user-guide-email-admin).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Apply Email Template |
| Internal tool name | `apply_email_template` |
| Purpose | Applies an email template to a case and opens the email compose experience for review |

The tool can:

- Pass `templateSubject` as a template title or free-text keyword
- Use `customerIntent` with the recommendation API
- Resolve merge fields automatically
- Open the email compose experience for review before the email is sent

## Tool behavior
The tool applies a configured email template to a case and opens the email compose experience. The compose experience displays the selected template content, resolves merge fields automatically, and lets the user review the generated email before sending.

The tool doesn't automatically send email messages.

## Annotations
| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | Microsoft 365 Copilot skips the confirmation prompt. The tool opens the compose experience for review only. |
| `destructiveHint` | Not set | Not applicable because the tool opens a compose form. |
| `idempotentHint` | Not set | Not applicable because each invocation opens a compose session. |
| `openWorldHint` | Not set | Uses default behavior and queries Dataverse. |

## Input concepts
### Case context

| Input | Description | Required |
|---|---|---|
| `incidentId` | Dataverse case GUID | Yes |

### Template selection

| Input | Description | Required |
|---|---|---|
| `templateSubject` | Template title or free-text keyword | Yes |
| `customerIntent` | Customer intent used by the recommendation API | No |
| `templateId` | Template GUID for traceability | No |

## Response and UI behavior
The tool renders the email compose form with the template content applied.

This MCP tool is supported by an MCP app.

### Response type

Interactive component (app-in-chat)

The compose widget opens with:

- Template body applied
- Merge fields resolved
- Email ready for review and editing before sending

## Routing notes
Use `apply_email_template` when the user wants to:

- Apply a specific template
- Apply a recommended template
- Apply a known template by name

Don't use `apply_email_template` when the user wants to:

- Browse templates first; use `recommend_email_templates`
- Generate AI-authored content; use `draft_email`
- Compose from scratch; use `draft_email`

## Related tools
| Tool | Relationship |
|---|---|
| [`recommend_email_templates`](recommend_email_templates.md) | Returns ranked templates for the case before a template is applied |
| [`draft_email`](draft_email.md) | Opens the compose experience with AI-generated content |
| [`generate_email_content`](generate_email_content.md) | Generates AI content for specific intents |

## Data mutation classification
The tool opens the email compose experience for review and is marked with `readOnlyHint: true`. Users can modify, save, or send the generated email from the compose experience.

Applying the template doesn't modify data until the user saves or sends the email.
