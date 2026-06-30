---
title: Check knowledge article draft status
description: Learn how to use the Check knowledge article draft status capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Check knowledge article draft status

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want the assistant to help with check knowledge article draft status from chat.

## What it does
Checks the status of an existing knowledge-harvest job without starting a new harvest.

## Try prompts like
- "Is the article ready?"
- "Check the harvest status"
- "Has the draft finished processing?"
- "Refresh the knowledge draft status"

## What you'll see in chat
The assistant shows the current harvest job state and refreshes the harvest widget when the draft is ready.

## Helpful tips
- Use this only after a harvest has already started.
- Do not ask repeatedly in the same prompt; the widget refreshes itself.
- Keep the original source record context available when asking for status.

## What happens next
- "Review the generated draft when processing completes"
- "Save edits as a draft"
- "Publish the draft after confirming it is ready"

## Does this change data?

No. Checking harvest status doesn't change Dynamics 365 data.**

## What you can do from the app-in-chat component
From the component in chat, you can:

- Review the current result or state
- Open the related Dynamics 365 record when the component provides a link
- Continue the workflow with the available component actions

## Prerequisites
This tool requires the following:

- Knowledge management

Learn more in [Configure knowledge management](/dynamics365/customer-service/administer/set-up-knowledge-management-embedded-knowledge-search).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Check Knowledge Article Harvest Status |
| Internal tool name | `check_harvest_status` |
| Purpose | Checks the status of a previously triggered Knowledge Article harvest |

## Tool behavior
Checks the status of a previously triggered Knowledge Article harvest. Used internally by the harvest widget. Do NOT call this tool autonomously after `harvest_knowledge_article` returns a 'processing' status on the same prompt. Only invoke when the user explicitly asks for a status update.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Job ID

| Input | Description | Required |
|---|---|---|
| `jobId` | `jobId` (required). The harvest job identifier returned by `harvest_knowledge_article`. | Yes |

## Response and UI behavior
This MCP tool is supported by an MCP app.

### Response type

Interactive (widget update) or text-only

When the harvest job is complete, the widget refreshes to show the drafted article. When the harvest is still in progress, returns a status message.

## Routing notes
Use `check_harvest_status` only when:

- The user explicitly asks whether a harvest is ready or complete. For example, 'is the article ready', 'check harvest status'.

Don't use `check_harvest_status` when:

- The harvest widget is self-polling (the widget handles this automatically)
- Immediately after `harvest_knowledge_article` returns 'processing' on the same prompt

## Related tools
| Tool | Relationship |
|---|---|
| [`harvest_knowledge_article`](harvest_knowledge_article.md) | Initiates the harvest that this tool checks |
| [`save_knowledge_draft`](save_knowledge_draft.md) | Saves edits to the harvested draft once it's ready |
| [`publish_knowledge_article`](publish_knowledge_article.md) | Publishes the draft when the user confirms |

## Data mutation classification
**Read-only.** Reads job status only. Doesn't modify records.
