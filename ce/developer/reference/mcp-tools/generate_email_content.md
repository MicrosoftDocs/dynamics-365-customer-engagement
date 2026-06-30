---
title: Generate Email Content (Copilot)
description: Learn how to use the Generate Email Content (Microsoft 365 Copilot) capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Generate Email Content (Copilot)

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want the assistant to draft an email subject and body using AI, tailored to a specific intent and grounded in case context.

## What it does
The assistant uses Dynamics 365 Copilot to generate email content for a case based on a specific intent you choose. Available intents include:

- **Suggest a call** — proposes a phone call with the customer to discuss the issue
- **Request information** — asks the customer to provide more details
- **Empathize** — acknowledges the customer's frustration and shows understanding
- **Product details** — provides information about a product or feature relevant to the case
- **Resolve problem** — outlines the resolution steps or solution

The generated content can optionally be grounded in knowledge articles, so the email includes relevant product or process information with cited sources.

## Try prompts like
- "Generate an empathetic reply for this case"
- "Draft an email requesting more information from the customer"
- "Write a resolution email for case CAS-01010-A0A0A0"
- "Generate a response suggesting a call with the customer"
- "Create a product details email for this case"
- "Draft an email with knowledge article references for this case"

## What you see in chat
The assistant responds with a text message containing the generated email subject and body. If knowledge grounding was used, the response includes references to the knowledge articles that informed the content.

## Helpful tips
- Choose the intent that best matches your goal. "Resolve problem" and "product details" automatically include knowledge article references when available.
- You can pass the generated content into a compose form by following up with "draft an email with that content" or "send that."
- Use "request info" when you need the customer to provide details before you can proceed.
- The AI uses the case context (title, description, timeline) to make the email relevant — you don't need to repeat case details in your prompt.
- Add "use knowledge" or "include knowledge articles" in your prompt to ground the email in your organization's knowledge base.

## What happens next
After the generated content appears, you can continue with prompts like:

- "Draft an email with that content"
- "Send that email to the customer"
- "Regenerate with a different intent"
- "Apply a template instead"
- "Edit the subject line"

## Does this change data?

No. Generating email content doesn't change data.

The generated text is a draft shown in chat. No email is created or sent until you use a follow-up action like drafting or sending the email.

## Prerequisites
This tool requires the following:

- Copilot email features are enabled.

Learn more in [Manage Copilot features in Customer Service](/dynamics365/customer-service/administer/configure-copilot-features).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Generate Email Content (Copilot) |
| Internal tool name | `generate_email_content` |
| Purpose | Generates email subject and body using Dynamics 365 Copilot with a specific intent |

## Tool behavior
Generates email subject and body using Dynamics 365 Copilot with a specific intent. Supports five intent types: suggest-call, request-info, empathize, product-details, and resolve-problem. Optionally grounds the generated content in knowledge articles when `useKnowledge` is enabled, returning cited sources in the response for downstream use by `draft_email`.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data - it only generates content. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Record context

| Input | Description | Required |
|---|---|---|
| `entityId`, `entityType` | `entityId` (record GUID for context, required), `entityType` (entity logical name). | Yes |

### Intent

| Input | Description | Required |
|---|---|---|
| `intent`, `suggest-call`, `request-info`, `empathize`, `product-details`, `resolve-problem` | `intent` (required - one of: `suggest-call`, `request-info`, `empathize`, `product-details`, `resolve-problem`). Determines the tone and structure of the generated content. | Yes |

### Customization

| Input | Description | Required |
|---|---|---|
| `keywords` | `keywords` (optional keywords to guide generation). | No |

### Knowledge grounding

| Input | Description | Required |
|---|---|---|
| `useKnowledge`, `knowledgeSources` | `useKnowledge` (when true, grounds the generated email in knowledge articles and returns citations as `knowledgeSources`). Note: always enabled for `resolve-problem` and `product-details` intents regardless of this flag. | No |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. The tool returns generated subject, body, and optionally knowledge source citations. The output is typically passed to `draft_email` to open the compose widget with the generated content.

## Routing notes
Use `generate_email_content` for:

- AI-generated email content for a specific intent category
- Knowledge-grounded email generation
- Generating content before opening compose with `draft_email`

Don't use `generate_email_content` when:

- The user wants to compose an email directly (AI compose is built into `draft_email` via `aiComposeKeywords`) - use `draft_email`
- The user wants to use a template - use `recommend_email_templates` then `apply_email_template`

## Related tools
| Tool | Relationship |
|---|---|
| [`draft_email`](draft_email.md) | Opens compose with the generated content (downstream consumer) |
| [`recommend_email_templates`](recommend_email_templates.md) | Template-based alternative to AI generation |
| [`apply_email_template`](apply_email_template.md) | Applies a specific template to a case |

## Data mutation classification
Read-only.

This tool only generates content. No data is modified in Dataverse.
