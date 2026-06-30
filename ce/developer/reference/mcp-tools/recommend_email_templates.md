---
title: Recommend Email Templates
description: Learn how to use the Recommend Email Templates capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Recommend Email Templates

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to view which email templates are available and best suited for a specific case.

## What it does
The assistant uses AI to analyze the case context and returns a ranked list of email templates ordered by relevance. Each recommendation includes the template name and a relevance ranking so you can quickly identify the best fit.

This is the browsing step before applying a template. When you find the right template, you can ask the assistant to apply it to the case, which opens the compose form with the template content and merge fields filled in.

## Try prompts like
- "Recommend templates for this case"
- "What email templates are available for case CAS-01010-A0A0A0?"
- "Show me templates I can use to reply"
- "Which templates fit this case?"
- "Suggest email templates for this case"
- "What templates should I use?"

## What you see in chat
The assistant responds with a text message listing the recommended email templates, ranked by relevance to the current case. Each entry shows the template name and its ranking.

## Helpful tips
- You need to be in the context of a specific case for recommendations to work. Mention the case number or have an active case in the conversation.
- Templates are ranked by AI based on the case details — the top result is usually the best fit.
- After seeing the list, say "apply the first template" or reference the template by name to use it.
- You can also filter recommendations by intent, such as "recommend templates for resolving this issue."

## What happens next
After the template list appears, you can continue with prompts like:

- "Apply the first template"
- "Use the 'Case Resolution' template"
- "Apply the apology template to this case"
- "Create a new template instead"
- "Draft an email without a template"

## Does this change data?
No. Recommending templates doesn't change data.**

This returns a read-only list of suggestions. No email is created or sent until you apply a template and send the resulting email.

## Prerequisites
This tool requires the following:

- Email templates

Learn more in [Manage Copilot features in Customer Service](/dynamics365/customer-service/administer/configure-copilot-features).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Recommend Email Templates |
| Internal tool name | `recommend_email_templates` |
| Purpose | Returns AI-recommended email reply templates ranked by relevance for a case |

## Tool behavior
Returns AI-recommended email reply templates ranked by relevance for a case. Requires a case context (`incidentId`). Use when the user asks to browse available templates, pick a template, or see template options before replying. Pair with `apply_email_template` to instantiate a chosen template.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Case context

| Input | Description | Required |
|---|---|---|
| `incidentId` | `incidentId` (the Dataverse case GUID, required). | Yes |

### Intent filter

| Input | Description | Required |
|---|---|---|
| `intent` | `intent` (optional email intent hint to filter templates, e.g. `resolve-problem`, `request-info`). Omit to return all templates. | No |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. The tool returns a ranked list of recommended templates with IDs, titles, and relevance scores. The user selects a template, then `apply_email_template` is called with the chosen template.

## Routing notes
Use `recommend_email_templates` for:

- "Show me templates", "what templates are available", "recommend a template"
- Browsing template options before composing an email

Don't use `recommend_email_templates` when:

- The user already knows which template to apply - use `apply_email_template` directly
- The user wants AI-generated content (not template-based) - use `generate_email_content`
- The user wants to compose directly with AI - use `draft_email` with `aiComposeKeywords`

## Related tools
| Tool | Relationship |
|---|---|
| [`apply_email_template`](apply_email_template.md) | Instantiates a chosen template and opens compose (called after selection) |
| [`draft_email`](draft_email.md) | Opens compose with AI-generated content (alternative to templates) |
| [`generate_email_content`](generate_email_content.md) | AI content generation for specific intents |
| [`create_email_template`](create_email_template.md) | Creates a new template |

## Data mutation classification
Read-only.

This tool only retrieves and ranks templates. No data is modified.
