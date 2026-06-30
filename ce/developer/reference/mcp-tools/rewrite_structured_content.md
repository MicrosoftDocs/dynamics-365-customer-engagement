---
title: Rewrite a note with a structured template
description: Learn how to use the Rewrite a note with a structured template capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Rewrite a note with a structured template

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to create a professionally formatted timeline note by applying one of your organization's structured templates with Copilot.

## What it does
The assistant helps you create a structured note on any timeline-bearing record (case, contact, account, etc.) by rewriting your free-form draft using an organization-defined template. The process works in phases: the assistant lists available templates, rewrites your draft with the selected template, lets you review and edit, and then saves the final note to the record's timeline.

This is ideal when your organization has standardized note formats and you want to ensure consistency across case notes, contact notes, or account records.

## Try prompts like
- "Add a structured note to this case"
- "Rewrite this note with a template"
- "Structure my note using a template for case CAS-01010-A0A0A0"
- "Apply a template to my case note"
- "Create a structured note on this contact"
- "Use a Copilot template to reformat my note"

## What you'll see in chat
The assistant displays an interactive structured note editor as an app-in-chat component. You can browse available templates, preview how your note looks after rewriting, make edits, and save the final version.

## Helpful tips
- Your organization's administrator configures which templates are available. If no templates appear, contact your admin.
- You can choose a tone (formal, casual, or neutral) to match the context of your note.
- Review and edit the rewritten note before saving - the AI applies the template structure, but you control the final content.
- This works on any record with a timeline, not just cases. Try it on contacts, accounts, or opportunities.
- For quick, unstructured notes without a template, use the plain "add a note" capability instead.

> [!TIP]
> If you want to format notes without using a template, try "structure my notes" instead - it organizes text into sections without requiring an organization template.

## What happens next
After saving the structured note, you can continue with prompts like:

- "Summarize this case"
- "What should I do next on this case?"
- "Close this case"
- "Show the timeline for this case"

## Does this change data?
**The initial step is read-only, but saving the note changes data.**

Browsing templates and previewing the rewrite does not change any records. When you save the final note, it creates an annotation record on the entity's timeline in Dynamics 365.

## What you can do from the app-in-chat component
From the structured note editor, you can:

- Browse active structured templates available in your organization
- Preview the AI-rewritten note with the selected template applied
- Edit the rewritten content before saving
- Select the tone for the rewrite (formal, casual, or neutral)
- Save the final note to the record's timeline
- Provide feedback on the rewrite quality using thumbs-up or thumbs-down
- Copy the structured note to your clipboard

## Prerequisites
This tool requires the following:

- Copilot features to be enabled

Learn more in [Manage Copilot features in Customer Service](/dynamics365/customer-service/administer/configure-copilot-features).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Rewrite a note with a structured template |
| Internal tool name | `rewrite_structured_content` |
| Purpose | Creates a structured timeline note by rewriting a free-form draft with a Copilot structuring template |

## Tool behavior
Creates a structured timeline note by rewriting a free-form draft with a Copilot structuring template. Operates in four phases: listing available templates, rewriting the draft with a selected template, committing the final note as a Dataverse annotation, and recording feedback. Supports cases, contacts, accounts, and any timeline-bearing entity.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | true | The DA-initiated phase (list templates) is read-only. Write phases (rewrite, commit, feedback) are widget-initiated and bypass the M365 confirmation card. |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Record identifier

| Input | Description | Required |
|---|---|---|
| `recordId` | `recordId` (required). GUID of the timeline-owning record (incident, contact, account, etc.). | Yes |

### Entity type

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | `entityLogicalName` (required). Dataverse logical name of the owning entity (e.g. `incident`, `contact`, `account`). | Yes |

### Phase control

| Input | Description | Required |
|---|---|---|
| `intent` | `intent` (required). Sub-operation: `list-then-rewrite` (list templates), `rewrite` (apply template), `commit` (save note), or `feedback` (record rating). | Yes |

### Draft content

| Input | Description | Required |
|---|---|---|
| `sourceContent`, `rewrite` | `sourceContent` (optional, required for `rewrite`). Free-form draft note to rewrite, max 4000 characters. | Varies |

### Template selection

| Input | Description | Required |
|---|---|---|
| `templateId` | `templateId` (optional). Template ID from the Phase 1 results. Required for `rewrite` unless `structuringPrompt` is supplied. | Varies |

### Final content

| Input | Description | Required |
|---|---|---|
| `structuredContent`, `commit` | `structuredContent` (optional, required for `commit`). The structured note to persist as an annotation. | Varies |

### User inputs

| Input | Description | Required |
|---|---|---|
| `requestId`, `rating`, `feedback` | `requestId` and `rating` (required for `feedback`). Correlation ID and thumbs-up/down rating. | Yes |

### Tone and locale

| Input | Description | Required |
|---|---|---|
| `tone`, `formal`, `locale`, `en-US` | `tone` (optional, defaults to `formal`) and `locale` (optional, defaults to `en-US`). Control rewrite style. | No |

## Response and UI behavior
This MCP tool is supported by an MCP App. 

### Response type

Interactive component (app-in-chat)

The widget renders a multi-phase structured note editor. Phase 1 lists available templates. Phase 2 shows the rewritten note with an editable preview. Phase 3 commits the note. Phase 4 captures feedback.

## Routing notes
Use `rewrite_structured_content` when:

- The user asks to "add a structured note", "rewrite with a template", or "apply a template"
- The user wants a Copilot-powered template-based note on any timeline-bearing entity

Don't use `rewrite_structured_content` when:

- The user wants to **save a plain note** - route to `create_note`
- The user wants to **format notes without a template** - route to `format_case_note`
- The user wants to **create a generic activity** - route to `create_activity`

## Related tools
| Tool | Relationship |
|---|---|
| [`create_note`](create_note.md) | Creates a plain note on the timeline. Use `rewrite_structured_content` for template-based structured notes |
| [`format_case_note`](format_case_note.md) | Formats raw notes into sections without a template. Less formal than `rewrite_structured_content` |
| [`create_activity`](create_activity.md) | Creates a generic timeline activity. Different from a structured note annotation |
| [`summarize_entity_timeline`](summarize_entity_timeline.md) | Summarizes existing timeline activity. Can provide context for drafting a new structured note |

## Data mutation classification
Read-only entry point with widget-driven mutation.

The DA-initiated phase (`list-then-rewrite`) is read-only - it lists templates and probes cross-geo policy. The widget-initiated phases (`rewrite`, `commit`, `feedback`) can modify data: `commit` creates an annotation record on the entity's timeline, and `feedback` emits a telemetry event. These write phases are invoked by the widget, not by the orchestrator directly.
