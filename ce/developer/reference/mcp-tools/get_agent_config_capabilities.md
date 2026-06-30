---
title: Agent Configuration Capabilities
description: Learn how to discover what agent configuration options are available to you.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Agent Configuration Capabilities

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to find out what configuration options are available to you and whether you have permission to customize agent layouts.

## What it does
The assistant checks what types of agent customizations are supported in your environment and what level of access you have. It tells you whether you can configure org-wide layouts (admin), profile-specific layouts, or personal preferences. This helps you understand what's possible before you start customizing.

## Try prompts like
- "What can I configure?"
- "What agent configuration options are available?"
- "Do I have permission to customize layouts?"
- "What types of customizations are supported?"
- "Show me my configuration capabilities"

## What you'll see in chat
The assistant responds with a text summary listing:

- Supported configuration types (grids, forms, timelines, picklists, lookups, resolution)
- Your access level (whether you can make org-wide changes, profile changes, or only personal preferences)

## Helpful tips
- If you're not sure whether you have admin permissions, ask this question first.
- Personal preferences are available to all users. Org-level and profile-level configurations require admin permissions.
- After checking capabilities, say "help me set up" or "what can I configure?" to get guided through the options.

## What happens next
After learning your capabilities:

- "Help me set up the case grid" (guided configuration)
- "What can I configure for cases?" (browse options)
- "Save my preferred columns" (personal preference)
- "Show org-level configurations" (admin view)

## Does this change data?
**No, this does not change data.**

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Agent Configuration Capabilities |
| Internal tool name | `get_agent_config_capabilities` |
| Purpose | Returns which agent configuration types are supported and the full list of available override tools |

## Tool behavior
Returns which agent configuration types are supported and the full list of available override tools. Call this first to discover what customizations are available for grids, forms, timelines, and picklists before attempting to save or modify configurations. Individual tool access is gated by Dataverse privileges via TOOL_PRIVILEGE_MAP at call time.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
This tool takes no input parameters.

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns structured JSON listing supported configuration types (grid, form, form-section, form-select, form-type, timeline, lookup, picklist, resolution) and the full list of available override tools. Privilege gating for individual tools is handled by TOOL_PRIVILEGE_MAP at call time, not by this discovery tool.

## Routing notes
Use `get_agent_config_capabilities` as a discovery step before any configuration workflow. It tells the model which save/list tools are available to the current user.

- If the user asks "what can I configure?" or "help me set up", call this tool first, then route to `browse_agent_config_options` for guided setup.
- If the user asks to directly save a config without prior context, still call this tool first to verify permissions.

## Related tools
| Tool | Relationship |
|---|---|
| [`browse_agent_config_options`](browse_agent_config_options.md) | Interactive multi-turn guide to configuration options |
| [`list_agent_configs`](list_agent_configs.md) | Lists existing org-level configurations |
| [`save_agent_config`](save_agent_config.md) | Creates or updates org-level configurations |
| [`list_user_prefs`](list_user_prefs.md) | Lists personal layout preferences |

## Data mutation classification
Read-only.
