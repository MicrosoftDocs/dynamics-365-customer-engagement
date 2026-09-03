---
title: List agent configurations
description: Learn how to view org-level or profile-level agent configurations in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=global
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# List agent configurations

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability to see the layout customizations active at the organization or Application Profile level.

## What it does
The assistant lists agent configurations at the requested tier. `scope` defaults to `org`; use `scope: "profile"` with `profileId` for a specific Application Profile. Each configuration shows its scope key, name, patch count, and last-modified time.

## Try prompts like

- List our agent configurations.
- What organization-level customizations are active?
- Show me all the organization layouts.
- List configurations for cases.
- What grid customizations exist?
- Show agent configs.

## What you'll see in chat
The assistant responds with a text list of active configurations at the requested tier. Each entry shows the scope key (for example, `grid:incident:*`), a human-readable name, the number of patches applied, and the last-modified date.

## Helpful tips
- Org-wide configurations are listed by default. Specify an Application Profile to list its configurations.
- Scope keys follow the pattern `type:entity:target` (for example, `grid:incident:*` means "grid configuration for cases, all views").
- If you want to filter by entity, specify it in your prompt: "list configs for cases" or "show account configurations."
- The Service Agent Maker Customize privilege is required to view or modify these configurations.

## What happens next

After seeing the list:

- Show me details about [configuration name].
- Remove the grid config for cases (admin only).
- What are my personal preferences? (separate from organization configs).
- Help me set up a new configuration.

## Does this change data?

**No, listing configurations doesn't change data.**

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. The signed-in user must have the Service Agent Maker Customize privilege.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | List agent configurations |
| Internal tool name | `list_agent_configs` |
| Purpose | Lists org-level or profile-level agent configurations |

## Tool behavior
Lists org-level configurations by default, or profile-level configurations when `scope: "profile"` and `profileId` are supplied. Shows scope key, name, patch count, and last-modified date.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Configuration scope
| Input | Description | Required |
|---|---|---|
| `scope` | Configuration tier: `org` (default) or `profile`. | No |
| `profileId` | Application Profile UUID. Required when `scope` is `profile`. | For profile scope |

### Entity filter

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | `entityLogicalName` (string, optional). When provided, only returns configurations for that entity (for example, `incident`, `account`). Omit to list all configurations across all entities. | No |

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered. Returns a structured list of configurations with their scope keys (for example, `grid:incident:*`), human-readable names, patch counts, and last-modified timestamps.

## Routing notes

Use `list_agent_configs` when:

- The user asks "what organization configs exist" or "list our customizations".
- You need to show scope keys before a delete operation.
- The user wants to audit existing organization-level layouts.

For profile-level configurations, call `list_agent_configs` with `scope: "profile"` and the target `profileId`.

Don't use `list_agent_configs` when:

- The user asks about their personal preferences. Use `list_user_prefs` instead.
- The user wants to explore what's possible. Use `browse_agent_config_options` instead.

## Related tools

| Tool | Relationship |
|---|---|
| [`save_agent_config`](save_agent_config.md) | Creates or updates an org-level or profile-level configuration |
| [`delete_agent_config`](delete_agent_config.md) | Removes an org-level or profile-level configuration by scope key |
| [`list_user_prefs`](list_user_prefs.md) | Lists the current user's personal preferences |
| [`browse_agent_config_options`](browse_agent_config_options.md) | Interactive guide to available configuration options |

## Data mutation classification

Read-only.
