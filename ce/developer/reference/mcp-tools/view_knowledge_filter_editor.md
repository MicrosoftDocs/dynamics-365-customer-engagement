---
title: View or edit knowledge filters
description: Learn how to use the View or edit knowledge filters capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# View or edit knowledge filters

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want the assistant to help you view or edit knowledge filters from chat.

## What it does
Opens the interactive knowledge filter editor so the user can view, change, apply, or clear their own selections.

## Try prompts like
- "Show my knowledge filters"
- "Change my knowledge filters"
- "Clear my knowledge article filters"
- "What filters are applied to knowledge search?"

## What you'll see in chat
The assistant opens a widget that lists available knowledge filter dimensions and the user's current selections.

## Helpful tips
- Use this for any request about viewing or changing knowledge filters.
- Make changes inside the widget; the assistant only opens the editor.
- Saved filters personalize later knowledge results.

## What happens next
- "Apply new filter selections in the widget"
- "Clear filters from the widget"
- "Ask a knowledge question using the updated filters"

## Does this change data?
**Opening the filter editor does not change data. Applying or clearing selections in the widget saves user filter preferences.**

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
| User-facing name | View Knowledge Filter Editor |
| Internal tool name | `view_knowledge_filter_editor` |
| Purpose | DA entry point for knowledge filtering |

## Tool behavior
DA entry point for knowledge filtering. Lists current filter dimensions and selections, then renders a widget for both view AND change intent. For any user request about knowledge filters (view, change, apply, or clear), call this tool - it opens the widget where the user makes the change themselves.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
This tool takes no required input parameters. It reads the current filter state automatically.

## Response and UI behavior
This MCP tool is supported by an MCP App. 

### Response type

Interactive (widget)

Renders the knowledge filter editor widget showing current dimensions and selections. The user applies or clears filters via the widget UI, which calls `update_knowledge_filters` internally.

## Routing notes
Use `view_knowledge_filter_editor` when:

- The user asks to view, change, apply, or clear knowledge filters
- The user wants to see what filters are active for knowledge article search

Don't use `view_knowledge_filter_editor` when:

- The user wants to **search articles** - route to `search_knowledge_articles`

## Related tools
| Tool | Relationship |
|---|---|
| [`update_knowledge_filters`](update_knowledge_filters.md) | Widget-internal save tool. Called automatically by the filter editor widget |
| [`search_knowledge_articles`](search_knowledge_articles.md) | Searches articles using the active filter settings |

## Data mutation classification
**Read-only entry point.** The widget it launches may invoke `update_knowledge_filters` (write), but this tool itself only reads state.
