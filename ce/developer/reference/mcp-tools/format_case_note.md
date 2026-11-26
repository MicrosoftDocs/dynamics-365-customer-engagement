---
title: Structure text for case note
description: Learn how to use the Structure text for case note capability in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=service
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Structure text for case note

**Applies to:** Dynamics 365 Customer Service

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability to turn raw notes, investigation logs, or findings into a case note for review before saving it to the case timeline.

## What it does

The assistant takes your raw text—such as investigation notes, findings, or resolution steps—and returns it as a case note for your review and editing before saving. You review the wording and can adjust it, then save it to the case timeline.

This is useful when you have quick notes jotted down during troubleshooting and want to create an organized record before closing a case or adding notes to the timeline.

## Try prompts like

- Structure these notes for the case.
- Format my investigation notes: customer reported login failure, checked SSO config, found expired certificate, renewed cert, issue resolved.
- Organize this into a proper case note.
- Clean up these findings for the case timeline.
- Format my notes before I close this case.
- Structure this resolution summary.

## What you'll see in chat

The assistant returns the note as text in the chat. You can review and edit it before saving. The assistant also asks which case to save it to if a case reference wasn't provided.

## Helpful tips

- Include as much detail as possible in your raw notes—the more context, the better the note.
- You can ask the assistant to save the note to a case by saying "save this to case CAS-01010-A0A0A0" after reviewing.
- This is a great step to run before closing a case—use the reviewed note as your resolution note.
- If you want to use an organization-defined template instead, ask to "rewrite with a template" for a more formal structured note.

> [!TIP]
> Combine this with case close: prepare your notes first, review them, then say "close this case with that note."

## What happens next

After the note appears, you can continue with prompts like:

- Save this note to the case.
- Close this case with that resolution note.
- Edit the note and add more details.
- Rewrite this with a structured template instead.

## Does this change data?

**No, this doesn't change data.**

Formatting the note is read-only. The formatted text is returned for your review. To save it, you need to use a follow-up action like adding a note or closing the case.

## Prerequisites

This tool requires the following:

- Copilot features to be enabled.

Learn more in [Manage Copilot features in Customer Service](/dynamics365/customer-service/administer/configure-copilot-features).

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Structure text for case note |
| Internal tool name | `format_case_note` |
| Purpose | Accepts raw agent notes, investigation logs, or findings and returns them as structured text with organized sections |

## Tool behavior

Accepts raw agent notes, investigation logs, or findings and returns them as structured text with organized sections. Currently passes the text through for the model to structure; a future release will add Copilot intelligence API-powered reformatting.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | Not set | Default behavior (processes text without modifying records). |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | `false` | doesn't use external data sources. |

## Input concepts

### Source text

| Input | Description | Required |
|---|---|---|
| `text` | `text` (required). Raw text to structure—agent notes, investigation logs, findings, or resolution details. | Yes |

### Case context

| Input | Description | Required |
|---|---|---|
| `incidentId`, `caseNumber` | `incidentId` (optional) or `caseNumber` (optional). Used to tailor formatting to the case and for narration context. Neither is required—the tool can format text without a case reference. | Varies |

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered. The note is returned as text in the chat for the agent to review and edit before saving.

## Routing notes

Use `format_case_note` when:

- The user has raw notes and asks to "structure", "format", or "organize" them.
- The user wants resolution notes prepared for `close_case`.
- The user wants to clean up notes before adding them to the timeline.

Don't use `format_case_note` when:

- The user wants to **save a note to the case**—route to `create_note` after formatting.
- The user wants to **rewrite a note with a structured template**—route to `rewrite_structured_content`.
- The user wants a **case summary**—route to `summarize_case`.

## Related tools

| Tool | Relationship |
|---|---|
| [`create_note`](create_note.md) | Saves a note to the case timeline. Use after `format_case_note` to persist the formatted text |
| [`rewrite_structured_content`](rewrite_structured_content.md) | Rewrites notes using organization-defined structured templates. More formal than `format_case_note` |
| [`close_case`](close_case.md) | Resolves a case. `format_case_note` can prepare the resolution note |
| [`summarize_case_actions`](summarize_case_actions.md) | Lists resolution steps taken. Can provide input text for `format_case_note` |

## Data mutation classification

Read-only.

No data is modified. The formatted text is returned for review. The agent must use `create_note` or another tool to persist the result.
