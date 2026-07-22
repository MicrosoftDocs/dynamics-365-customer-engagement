---
title: Adjust Email Tone
description: Learn how to use the Adjust Email Tone capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: aditibaghel
ms.author: aditibaghel
ms.reviewer: laalexan
---

# Adjust Email Tone

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to rewrite an email so it sounds more formal, friendlier, or so it reads shorter or longer — without re-typing it yourself.

## What it does
The assistant takes the body of an email and rewrites it with the tone and length you ask for. You pick the tone (friendly, standard, or formal), optionally the length (shorter, about the same, or longer), and the assistant returns a rewritten version that you can review before saving or sending.

Use it on text the assistant just generated, on a draft you've been composing, or on any email body you paste into chat. If a compose form is already open with a draft, the assistant rewrites the draft in place so you don't lose your subject line or recipients.

## Try prompts like
- "Make this email more formal"
- "Rewrite this draft to sound friendlier"
- "Make this email shorter"
- "Make my reply more professional and a bit longer"
- "Soften the tone of this email"
- "Adjust the tone of this draft to be formal and shorter"

## What you'll see in chat
The assistant returns the rewritten text. When you ask the assistant to adjust the tone of a draft you have open, the rewrite appears in the same email compose form so you can keep editing, save, or send.

## Helpful tips
- Be specific about the tone you want — "formal", "friendly", and "standard" are the supported choices, and the assistant works best when you name one of them.
- If you only want to change the length, ask for "shorter" or "longer" without naming a tone, and the assistant will keep the existing tone.
- The rewrite uses the text in the open draft (or the text you paste); the assistant doesn't pull in extra context from elsewhere.
- If the result isn't what you wanted, just ask again with a different tone or length — the original text is preserved if the rewrite fails.

## What happens next
After the rewrite appears, you can continue with prompts like:

- "Send this email"
- "Make it a bit shorter"
- "Translate this to French" — see [Translate Email](translate_email.md)
- "Try a friendlier tone instead"

## Does this change data?

No. Adjusting the tone doesn't change data.

The rewrite is a preview shown in the compose form. No email is saved or sent until you explicitly save or send it. If a draft is open and the rewrite succeeds, the assistant updates the draft body in Dataverse so the new tone persists if the form reloads — but no email is sent without your action.

## What you can do from the app-in-chat component
When the rewrite is shown inside the compose form, you can:

- Review the new tone and length before sending
- Keep editing — the form is fully editable after the rewrite
- Send the email, or save it as a draft
- Ask the assistant for another rewrite if the tone isn't quite right

## Prerequisites
This tool requires:

- Copilot email features to be enabled

Learn more in [Manage Copilot features in Customer Service](/dynamics365/customer-service/administer/configure-copilot-features).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Adjust Email Tone |
| Internal tool name | `adjust_email_tone` |
| Purpose | Rewrites an email body with a different tone and/or length |

The tool can:

- Accept the current email body as `content`
- Apply a `tone` knob (`friendly`, `standard`, or `formal`)
- Apply a `length` knob (`shorter`, `relative`, or `longer`)
- Render the rewrite in an app-in-chat component for review before sending
- Drive the in-place rewrite path for an open compose draft when invoked via `edit_email_draft` with a `pendingAction`

## Tool behavior
The tool calls the Dynamics 365 `msdyn_emailAssistAdjustAPI` Dataverse action with the supplied body and tone/length knobs and returns the rewritten text. The widget displays the rewritten content for review.

When invoked standalone (no open compose form), the tool returns the rewrite as a text response with the widget surface showing the new body. When invoked as part of refining an open draft, the `edit_email_draft` handler passes the directive through as a `pendingAction`, applies the rewrite to the loaded body server-side, and PATCHes the rewritten body back to the same draft activity so the persisted record matches what the user sees.

The tool doesn't send email messages.

## Annotations
| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | Microsoft 365 Copilot skips the confirmation prompt. The rewrite is shown for review only. |
| `destructiveHint` | Not set | Not applicable (no Dataverse mutation by this tool itself). |
| `idempotentHint` | Not set | Not applicable (each invocation triggers a fresh rewrite). |
| `openWorldHint` | Not set | Uses default behavior and calls a Dataverse action. |

## Input concepts
### Email body

| Input | Description | Required |
|---|---|---|
| `content` | The current email body to rewrite. Plain text or HTML. Capped at 50,000 characters. | Yes |

### Tone and length knobs

| Input | Description | Required |
|---|---|---|
| `tone` | Target tone: `friendly`, `standard`, or `formal`. | One of `tone` or `length` |
| `length` | Target length: `shorter`, `relative` (keep current), or `longer`. | One of `tone` or `length` |

The upstream Dataverse action requires both knobs on the wire; when only one is supplied, the server fills in the unspecified knob with `standard`/`relative` so the upstream returns a meaningful rewrite. A directive with neither tone nor length is rejected at the boundary.

## Response and UI behavior
The tool renders the rewritten content in an app-in-chat component for review.

This MCP tool is supported by an MCP app. 

### Response type

Interactive component (app-in-chat)

The widget shows:

- The rewritten body
- The applied tone and length knobs
- A label confirming the rewrite source

## Routing notes
Use `adjust_email_tone` when the user wants to:

- Rewrite an email body's tone or length, standalone
- Adjust tone of pasted or generated text

Use `edit_email_draft` with `pendingAction: { type: "adjust-tone", ... }` when the user wants to:

- Refine the tone of a draft already open in the compose form
- Persist the rewrite to the same draft activity

Don't use `adjust_email_tone` when the user wants to:

- Compose a brand-new email. Use `draft_email`.
- Translate an email. Use `translate_email`.
- Send the email. Use `send_email`.

## Related tools
| Tool | Relationship |
|---|---|
| [`edit_email_draft`](edit_email_draft.md) | Preferred refinement entry point — accepts `pendingAction: { type: "adjust-tone", ... }` and auto-saves the rewrite to the same draft |
| [`draft_email`](draft_email.md) | First-turn compose entry point |
| [`translate_email`](translate_email.md) | Sibling tool for translation |
| [`send_email`](send_email.md) | Sends the email after the rewrite is reviewed |

## Data mutation classification
The tool itself is marked with `readOnlyHint: true` and doesn't write to Dataverse on its own. The rewrite shown in chat is a preview.

When invoked through the `edit_email_draft + pendingAction` refinement path, the `edit_email_draft` handler PATCHes the rewritten body to the existing draft activity after the rewrite succeeds. That PATCH is gated server-side by `prvWriteActivity` on the `edit_email_draft` tool.
