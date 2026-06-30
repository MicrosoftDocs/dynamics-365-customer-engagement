---
title: Draft a knowledge article from a source record
description: Learn how to use the Draft a knowledge article from a source record capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Draft a knowledge article from a source record

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want the assistant to help with draft a knowledge article from a source record from chat.

## What it does
Starts the Knowledge Management Agent pipeline to draft a knowledge article from a source record. It never auto-publishes.

## Try prompts like
- "Draft a knowledge article from this case"
- "Create a KB draft from this conversation"
- "Harvest an article for this issue"
- "Turn this resolved case into a draft article"

## What you'll see in chat
The assistant opens a harvest card. It may show processing, a completed draft, or a no-article result when the pipeline finds the topic already covered.

## Helpful tips
- Use this when the article should be drafted from an existing case, conversation, or source record.
- Call it once; the widget refreshes while the draft is processing.
- Use draft/edit tools instead when the title and article body are already known.

## What happens next
- "Review and edit the generated draft"
- "Save the draft after editing"
- "Publish the article only after explicit confirmation"

## Does this change data?
**Yes, this can create a draft knowledge article.**

## What you can do from the app-in-chat component
From the component in chat, you can:

- Review the current result or state
- Open the related Dynamics 365 record when the component provides a link
- Continue the workflow with the available component actions

## Prerequisites
This tool requires the following:

- Copilot features to be enabled

Learn more in , [Configure knowledge management](/dynamics365/customer-service/administer/set-up-knowledge-management-embedded-knowledge-search), and [Manage Copilot features in Customer Service](/dynamics365/customer-service/administer/configure-copilot-features).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Harvest Knowledge Article from Source Entity |
| Internal tool name | `harvest_knowledge_article` |
| Purpose | Drafts a Knowledge Article from a source case, conversation, or custom entity using the Knowledge Management Agent (KMA) pipeline, which extracts issue, cause, and resolution |

## Tool behavior
Drafts a Knowledge Article from a source case, conversation, or custom entity using the Knowledge Management Agent (KMA) pipeline, which extracts issue, cause, and resolution. Always creates a DRAFT (never auto-publishes). Returns quickly with a 'processing' status - the widget self-polls and refreshes when the draft is ready. Use after `summarize_case_actions` to auto-draft an article; use `draft_knowledge_article` when title and content are already known.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | Updates data but does not delete records. |
| `idempotentHint` | `false` | Repeated calls with the same input produce the same result. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Source record

| Input | Description | Required |
|---|---|---|
| `sourceId` | `sourceId` (GUID, required). The ID of the source case, conversation, or custom entity to harvest from. | Yes |

### Source entity type

| Input | Description | Required |
|---|---|---|
| `sourceEntityType` | `sourceEntityType` (required). The logical name of the source entity (e.g. `incident`, `msdyn_ocliveworkitem`). | Yes |

## Response and UI behavior
This MCP tool is supported by an MCP App. 

### Response type

Interactive (widget)

Returns quickly with a 'processing' status. The harvest widget self-polls the KMA pipeline and refreshes to show the drafted article when it's ready.

## Routing notes
Use `harvest_knowledge_article` when:

- The user asks to draft an article FROM a source record (case, conversation, entity)
- After `summarize_case_actions` to auto-populate a KB article from resolution steps
- When AI-assisted extraction from source data is preferable to manual authoring

Don't use `harvest_knowledge_article` when:

- The user has explicit title + content ready - route to `draft_knowledge_article`
- The user wants to search for existing articles - route to `search_knowledge_articles`

## Related tools
| Tool | Relationship |
|---|---|
| [`draft_knowledge_article`](draft_knowledge_article.md) | Creates a draft from explicit title + content. Use when content is already known |
| [`check_knowledge_gap`](check_knowledge_gap.md) | Preflight to check for duplicates before harvesting |
| [`check_harvest_status`](check_harvest_status.md) | Polls harvest progress if the user asks explicitly |
| [`save_knowledge_draft`](save_knowledge_draft.md) | Saves edits to the harvested draft |
| [`publish_knowledge_article`](publish_knowledge_article.md) | Publishes the draft once ready |
| [`discard_knowledge_draft`](discard_knowledge_draft.md) | Abandons the draft |

## Data mutation classification
**Write.** Creates a draft Knowledge Article record in Dataverse via the KMA pipeline.
