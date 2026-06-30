---
title: List Agent Configurations
description: Learn how to view org-level agent configurations in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# List Agent Configurations

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to see what org-level layout customizations are currently active for all agents in your organization.

## What it does
The assistant lists all org-level agent configurations that have been set up by an admin. These configurations affect every user in the organization and include customizations to grids, forms, timelines, and other layout elements. Each configuration shows its scope (what entity and type it applies to), its name, how many changes it includes, and when it was last modified.

## Try prompts like
- "List our agent configurations"
- "What org-level customizations are active?"
- "Show me all the org layouts"
- "List configurations for cases"
- "What grid customizations exist?"
- "Show agent configs"

## What you'll see in chat
The assistant responds with a text list of all active org-level configurations. Each entry shows the scope key (for example, `grid:incident:*`), a human-readable name, the number of patches applied, and the last-modified date.

## Helpful tips
- This shows org-wide configurations only. For profile-specific or personal preferences, ask separately.
- Scope keys follow the pattern `type:entity:target` (for example, `grid:incident:*` means "grid configuration for cases, all views").
- If you want to filter by entity, specify it in your prompt: "list configs for cases" or "show account configurations."
- Admin permissions are required to modify these configurations, but anyone can view them.

## What happens next
After seeing the list:

- "Show me details about [configuration name]"
- "Remove the grid config for cases" (admin only)
- "What are my personal preferences?" (separate from org configs)
- "Help me set up a new configuration"

## Does this change data?
**No, listing configurations does not change data.**

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | List Agent Configurations |
| Internal tool name | `list_agent_configs` |
| Purpose | Lists all org-level agent configurations |

## Tool behavior
Lists all org-level agent configurations. Shows scope, name, patch count, and last modified date for each customization applied to grids, forms, and timelines. Use when an org admin asks to review what org-level customizations are currently active.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Entity filter

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | `entityLogicalName` (string, optional). When provided, only returns configurations for that entity (e.g., `incident`, `account`). Omit to list all configurations across all entities. | No |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns a structured list of configurations with their scope keys (e.g., `grid:incident:*`), human-readable names, patch counts, and last-modified timestamps.

## Routing notes
Use `list_agent_configs` when:

- The user asks "what org configs exist" or "list our customizations"
- You need to show scope keys before a delete operation
- The user wants to audit existing org-level layouts

Don't use `list_agent_configs` when:

- The user asks about profile-level configurations. Use `list_profile_configs` instead.
- The user asks about their personal preferences. Use `list_user_prefs` instead.
- The user wants to explore what's possible. Use `browse_agent_config_options` instead.

## Related tools
| Tool | Relationship |
|---|---|
| [`save_agent_config`](save_agent_config.md) | Creates or updates an org-level configuration |
| [`delete_agent_config`](delete_agent_config.md) | Removes an org-level configuration by scope key |
| [`list_profile_configs`](list_profile_configs.md) | Lists configurations scoped to an Application Profile |
| [`list_user_prefs`](list_user_prefs.md) | Lists the current user's personal preferences |
| [`browse_agent_config_options`](browse_agent_config_options.md) | Interactive guide to available configuration options |

## Data mutation classification
Read-only.
