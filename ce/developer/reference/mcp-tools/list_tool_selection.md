---
title: List Tool Visibility
description: Learn how to list tool visibility settings in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# List Tool Visibility

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to review which tools are visible, hidden, or restored at the organization or profile level.

## What it does
This tool lists the current tool visibility settings for the selected scope. It returns the tool catalog, the resolved hidden set, and the raw visibility patches stored for the organization or profile.

## Try prompts like
- "Which tools are hidden?"
- "Show tool visibility for this org"
- "List tool visibility for the profile"
- "What tools are disabled?"
- "Show me the current tool selection"

## What you'll see in chat
The assistant returns a text summary of the visibility state, including the scope, the tool names, and the current hidden or restored status.

## Helpful tips
- Use `level: org` to review organization-wide visibility.
- Use `level: profile` to inspect a specific profile, and include `profileId`.
- This tool is read-only. Use `save_tool_selection` to make changes.

## What happens next
- "Hide the email tools for this profile"
- "Restore a hidden tool"
- "Reset tool visibility to defaults"

## Does this change data?
**No, this does not change data.**

It only reads the current visibility configuration.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | List Tool Visibility |
| Internal tool name | `list_tool_selection` |
| Purpose | Lists the current tool visibility settings for the selected organization or profile scope |

## Tool behavior
Lists the current tool visibility settings for the selected organization or profile scope. Returns the full tool catalog, the resolved hidden set, and the raw visibility patches that are currently saved.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable. |
| `idempotentHint` | Not set | Not applicable. |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Level

| Input | Description | Required |
|---|---|---|
| `level`, `org`, `profile` | `level` (`org` or `profile`, required). Selects whether to inspect organization-wide or profile-level visibility. | Yes |

### Profile ID

| Input | Description | Required |
|---|---|---|
| `profileId` | `profileId` (UUID string, optional). Required when `level` is `profile`. | Varies |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns structured text describing the current visibility state, including the scope, tool names, and hidden or restored status.

## Routing notes
Use `list_tool_selection` when:

- You need to confirm which tools are hidden or visible
- You want to inspect visibility before making a change
- You want a read-only audit of tool selection settings

Don't use `list_tool_selection` when:

- You already know the exact change you want to make. Use `save_tool_selection` instead.

## Related tools
| Tool | Relationship |
|---|---|
| [`save_tool_selection`](save_tool_selection.md) | Saves visibility overrides |
| [`delete_tool_selection`](delete_tool_selection.md) | Clears visibility overrides |
| [`browse_agent_config_options`](browse_agent_config_options.md) | Discovers related configuration options |

## Data mutation classification
Read-only.

This tool only reads the current visibility configuration.
