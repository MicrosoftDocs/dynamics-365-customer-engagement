---
title: Check for an existing knowledge article
description: Learn how to use the Check for an existing knowledge article capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Check for an existing knowledge article

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want the assistant to help with check for an existing knowledge article from chat.

## What it does
Runs the Knowledge Management Agent deduplication check for a source record and returns an existing-article match or no-match result.

## Try prompts like
- "Do we have a KB for this case?"
- "Is there an existing article about this conversation?"
- "Check whether this issue is already documented"
- "Find an existing knowledge article for this record"

## What you see in chat
The assistant shows whether a similar article already exists for the selected source record.

## Helpful tips
- Use this tool when you want to know whether an article already exists.
- Don't run it before harvesting. The harvest pipeline already performs its own duplicate check.
- Start from a specific case or conversation so the check has enough context.

## What happens next
- "Open the matched article if one exists"
- "Harvest a draft only when no suitable article exists"
- "Ask for a summary of the source record before drafting"

## Does this change data?

This tool can create or update backend check state, but it doesn't publish or delete knowledge articles.

## What you can do from the app-in-chat component
From the component in chat, you can:

- Review the current result or state
- Open the related Dynamics 365 record when the component provides a link
- Continue the workflow with the available component actions

## Prerequisites
This tool requires the following:

- Copilot features are enabled

Learn more in [Configure knowledge management](/dynamics365/customer-service/administer/set-up-knowledge-management-embedded-knowledge-search) and [Manage Copilot features in Customer Service](/dynamics365/customer-service/administer/configure-copilot-features).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Check Knowledge Gap |
| Internal tool name | `check_knowledge_gap` |
| Purpose | Checks whether a similar knowledge article already exists for a source case, conversation, or custom entity via the Knowledge Management Agent dedup pipeline. |

## Tool behavior
Checks whether a similar Knowledge Article already exists for a source case, conversation, or custom entity via the Knowledge Management Agent dedup pipeline. Use as a preflight before `harvest_knowledge_article` when the user explicitly asks whether an article exists.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | Updates data but doesn't delete records. |
| `idempotentHint` | `false` | Repeated calls with the same input produce the same result. |
| `openWorldHint` | Not set | Uses default. (queries Dataverse). |

## Input concepts
### Source record

| Input | Description | Required |
|---|---|---|
| `sourceId` | `sourceId` (GUID, required). The ID of the source case, conversation, or custom entity to check. | Yes |

### Source entity type

| Input | Description | Required |
|---|---|---|
| `sourceEntityType` | `sourceEntityType` (required). The logical name of the source entity. For example, `incident`, `msdyn_ocliveworkitem`. | Yes |

## Response and UI behavior
This MCP tool is supported by an MCP app.

### Response type

Interactive (widget)

Renders a widget showing whether a matching article exists and providing an option to proceed with harvesting if no duplicate is found.

## Routing notes
Use `check_knowledge_gap` when:

- The user explicitly asks whether an article exists before creating one
- Used as a preflight step before `harvest_knowledge_article`

Don't use `check_knowledge_gap` when:

- The user wants to create an article immediately - route to `harvest_knowledge_article` (it checks internally anyway)
- The user wants to search for articles by keyword - route to `search_knowledge_articles`

## Related tools
| Tool | Relationship |
|---|---|
| [`harvest_knowledge_article`](harvest_knowledge_article.md) | The primary harvest tool. `check_knowledge_gap` is an optional preflight |
| [`search_knowledge_articles`](search_knowledge_articles.md) | Browses and lists articles by keyword |

## Data mutation classification
**Light write.** Triggers the KMA dedup pipeline but does not create or modify knowledge articles.
