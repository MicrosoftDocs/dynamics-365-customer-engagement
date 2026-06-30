---
title: Apply knowledge filter selections
description: Learn how to use the Apply knowledge filter selections capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Apply knowledge filter selections

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want the assistant to help you apply knowledge filter selections from chat.

## What it does
Persists the user selections made in the knowledge-filter widget. The assistant should not compose these values directly.

## Try prompts like
- "Apply these knowledge filters"
- "Clear all knowledge filters"
- "Save my filter selections"
- "Use these filter values"

## What you'll see in chat
The widget saves the selected filter values and refreshes the current knowledge filter state.

## Helpful tips
- Open the filter editor instead of calling this directly from a chat prompt.
- Use Apply to save selected values.
- Use Clear all to remove saved selections.

## What happens next
- "Search knowledge articles using the updated filters"
- "Open the filter editor again to review selections"
- "Clear filters when personalization is no longer needed"

## Does this change data?
**Yes, applying or clearing filters saves the user's knowledge filter selections.**

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
| User-facing name | Update Knowledge Filters |
| Internal tool name | `update_knowledge_filters` |
| Purpose | Saves the user's knowledge-filter widget selections when they click Apply or Clear all |

## Tool behavior
Saves the user's knowledge-filter widget selections when they click Apply or Clear all. Widget-internal persistence tool - do NOT call this directly. It expects the exact dimension keys and values the user picks in the widget, not values you compose. For any user request about knowledge filters (view, change, apply, or clear), call `view_knowledge_filter_editor`, which opens the widget where the user makes the change themselves.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | Updates data but does not delete records. |
| `idempotentHint` | `true` | Repeated calls with the same input produce the same result. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Selections

| Input | Description | Required |
|---|---|---|
| `selections` | `selections` (array, required). One entry per filter dimension. Each entry must contain: | Yes |

## Response and UI behavior
This MCP tool is supported by an MCP App. 

### Response type

Widget update

The widget refreshes to reflect the saved filter selections after the tool completes.

## Routing notes
This tool is exclusively called by the `view_knowledge_filter_editor` widget. Do not invoke it directly.

For any user request to view, change, apply, or clear knowledge filters, use `view_knowledge_filter_editor`.

## Related tools
| Tool | Relationship |
|---|---|
| [`view_knowledge_filter_editor`](view_knowledge_filter_editor.md) | The launcher tool that opens the filter widget. This tool is only called by that widget |
| [`search_knowledge_articles`](search_knowledge_articles.md) | Searches articles; filter settings applied here affect search results |

## Data mutation classification
**Write.** Persists the user's knowledge filter selections in Dataverse.
