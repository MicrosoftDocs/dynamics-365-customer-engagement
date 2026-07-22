---
title: Translate Email
description: Learn how to use the Translate Email capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: aditibaghel
ms.author: aditibaghel
ms.reviewer: laalexan
---

# Translate Email

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to translate the body of an email into a different language — for example, when the customer writes in French and you want to read it in English, or when you want to send your reply in the customer's language.

## What it does
The assistant takes the text of an email and translates it into the language you ask for. You can name the language by its English name (for example, "French", "Spanish", or "Japanese") or by its short code (for example, `fr`, `es`, `ja`). The translated version appears for you to review before you use it.

If a compose form is already open with a draft, the assistant translates the draft body in place so you don't lose your subject line or recipients. Otherwise, the translation is shown on its own as a text reply.

## Try prompts like
- "Translate this email to French"
- "Translate the customer's email to English"
- "Translate this draft to Japanese"
- "Convert this reply to Spanish"
- "Translate this email to German"
- "Make this draft Italian"

## What you see in chat

The assistant returns the translated text. When you ask the assistant to translate a draft you have open, the translation appears in the same email compose form so you can keep editing, save it, or send it.

## Helpful tips
- You can use either a language name ("French") or a short code (`fr`) — both work.
- If the language code isn't recognized, the assistant returns no content. Double-check the name or code and try again.
- Translation works on whatever text is in the open draft (or on text you paste in chat); the assistant doesn't pull in extra context.
- For best results, translate text that already reads cleanly — the translator preserves the structure of the original.

## What happens next
After the translation appears, you can continue with prompts like:

- "Send this email"
- "Translate it back to English"
- "Make this email more formal" — see [Adjust Email Tone](adjust_email_tone.md)
- "Translate to a different language"

## Does this change data?

No. Translating an email doesn't change data.

The translation is a preview shown in the compose form. No email is saved or sent until you save or send it. If a draft is open and the translation succeeds, the assistant updates the draft body in Dataverse so the translated text persists if the form reloads, but the email isn't sent without your action.

## What you can do from the app-in-chat component
When the translation is shown inside the compose form, you can:

- Review the translated text before sending
- Keep editing — the form is fully editable after the translation
- Send the email, or save it as a draft
- Ask the assistant to translate again into a different language

## Prerequisites
This tool requires:

- Copilot intelligence features are enabled.

Learn more in [Manage Copilot features in Customer Service](/dynamics365/customer-service/administer/configure-copilot-features).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Translate Email |
| Internal tool name | `translate_email` |
| Purpose | Translates an email body into a target language |

The tool can:

- Accept the email body as `content`
- Resolve `targetLanguage` from either an English display name ("French", "Japanese") or an ISO 639 primary subtag (`fr`, `ja`, `fil`)
- Render the translated content in an app-in-chat component for review
- Drive the in-place translation path for an open compose draft when invoked via `edit_email_draft` with a `pendingAction`

## Tool behavior
The tool calls the Dynamics 365 `msdyn_InvokeIntelligenceAction` Dataverse action (scenario `translatetext`) with the supplied body and target language and returns the translated text. Before the call, the server normalizes display names to ISO 639 primary subtags (for example, "French" becomes `fr`) and strips any region or variant suffix so the upstream receives the bare primary code its scenario expects.

When invoked standalone (no open compose form), the tool returns the translation as a text response with the widget surface showing the translated body. When invoked as part of refining an open draft, the `edit_email_draft` handler passes the directive through as a `pendingAction`, applies the translation to the loaded body server-side, and PATCHes the translated body back to the same draft activity so the persisted record matches what the user sees.

The tool doesn't send email messages.

## Annotations
| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | Microsoft 365 Copilot skips the confirmation prompt. The translation is shown for review only. |
| `destructiveHint` | Not set | Not applicable (no Dataverse mutation by this tool itself). |
| `idempotentHint` | Not set | Not applicable (each invocation triggers a fresh translation call). |
| `openWorldHint` | Not set | Uses default behavior and calls a Dataverse action. |

## Input concepts
### Email body

| Input | Description | Required |
|---|---|---|
| `content` | The current email body to translate. Plain text or HTML. Capped at 50,000 characters. | Yes |

### Target language

| Input | Description | Required |
|---|---|---|
| `targetLanguage` | Target language as an English display name (`French`, `Spanish`, `Japanese`) or ISO 639 primary subtag (`fr`, `es`, `ja`, `fil`). Capped at 32 characters. | Yes |

The server normalizes display names against a built-in name-to-code table for the most common languages and strips region suffixes from BCP-47-shaped codes (so `fr-FR` becomes `fr`). Codes the upstream scenario doesn't recognize return no content from the API.

## Response and UI behavior
The tool renders the translated content in an app-in-chat component for review.

This MCP tool is supported by an MCP app.

### Response type

Interactive component (app-in-chat)

The widget shows:

- The translated body
- The resolved target-language code
- A label confirming the translation source

## Routing notes
Use `translate_email` when the user wants to:

- Translate an email body, standalone
- Translate pasted or generated text

Use `edit_email_draft` with `pendingAction: { type: "translate", ... }` when the user wants to:

- Translate a draft already open in the compose form
- Persist the translation to the same draft activity

Don't use `translate_email` when the user wants to:

- Compose a brand-new email; use `draft_email`
- Adjust the tone of an email; use `adjust_email_tone`
- Send the email; use `send_email`

## Related tools
| Tool | Relationship |
|---|---|
| [`edit_email_draft`](edit_email_draft.md) | Preferred refinement entry point — accepts `pendingAction: { type: "translate", ... }` and auto-saves the translation to the same draft |
| [`draft_email`](draft_email.md) | First-turn compose entry point |
| [`adjust_email_tone`](adjust_email_tone.md) | Sibling tool for tone and length refinement |
| [`send_email`](send_email.md) | Sends the email after the translation is reviewed |

## Data mutation classification
The tool itself is marked with `readOnlyHint: true` and doesn't write to Dataverse on its own. The translation that appears in the chat is a preview.

When invoked through the `edit_email_draft + pendingAction` refinement path, the `edit_email_draft` handler PATCHes the translated body to the existing draft activity after the translation succeeds. That PATCH is gated server-side by `prvWriteActivity` on the `edit_email_draft` tool.
