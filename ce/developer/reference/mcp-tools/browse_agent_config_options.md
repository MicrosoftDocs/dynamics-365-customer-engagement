---
title: Getting Started with Agent Configuration
description: Learn how to use the Getting Started with Agent Configuration capability in Dynamics 365 Customer Service.
ms.date: 06/30/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Getting Started with Agent Configuration

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to explore what you can configure in the Service Agent and understand the available customization options for grids, forms, timelines, picklists, and resolution strategies.

## What it does
The assistant provides an interactive, text-based guide to Service Agent configuration. It presents a navigable tree of configuration categories — you can browse top-level categories, drill into specific areas (such as case grid layout or timeline settings), and search for specific options by keyword.

The guide covers both organization-wide settings (applied to all users) and Application Profile-scoped settings (applied to specific user groups). At any level, you can ask for before-and-after examples to see what a configuration change looks like in practice.

## Try prompts like
- "What can I configure?"
- "Help me set up the agent"
- "Getting started with configuration"
- "How do I customize the case grid?"
- "Show me timeline configuration options"
- "What form settings are available?"
- "Search config options for picklist"
- "Browse agent configuration for the incident entity"

## What you'll see in chat
The assistant responds with a text message showing the current level of the configuration tree. Each entry includes a category name and a brief description. You can navigate deeper by asking about a specific category or search across all options with a keyword.

## Helpful tips
- Start with no specific path to see the root menu of all configuration categories.
- Say "search for [keyword]" to find configuration options across all categories without navigating manually.
- Ask "show examples" at any level to see before-and-after previews of what a configuration change looks like.
- Specify an entity (such as "incident" or "account") to filter options to configurations relevant to that entity type.
- Choose between "org" scope (organization-wide) and "profile" scope (Application Profile) to target the right configuration layer.

> [!TIP]
> This guide helps you discover what's configurable. To apply changes, follow up with the specific configuration action the guide recommends.

## What happens next
After browsing configuration options, you can continue with prompts like:

- "Show me the grid configuration options"
- "Drill into timeline settings"
- "Search for resolution strategy"
- "Show examples for this option"
- "Save this configuration"

## Does this change data?

No. Browsing configuration options doesn't change data.

This is a read-only guide. Configuration changes are applied only when you follow up with a specific save action.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Getting Started with Agent Configuration |
| Internal tool name | `browse_agent_config_options` |
| Purpose | Guides a maker through Service Agent configuration options via an interactive, multi-turn navigable tree |

## Tool behavior
Guides a maker through Service Agent configuration options via an interactive, multi-turn navigable tree. Covers grids, forms, timelines, picklists, lookups, and resolution strategies. Returns hierarchical menus that the user can drill into, with before/after examples at each level. The primary entry point for configuration discovery.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Navigation path

| Input | Description | Required |
|---|---|---|
| `path` | `path` (string, optional). Dot-delimited path to jump to any level of the configuration tree (e.g., `grid.incident`, `form`, `timeline.incident`). Omit or pass empty for the root menu. | No |

### Examples toggle

| Input | Description | Required |
|---|---|---|
| `showExamples` | `showExamples` (boolean, optional). When true, returns before/after examples at the current tree level. | No |

### Entity filter

| Input | Description | Required |
|---|---|---|
| `entity` | `entity` (string, optional). Filters the tree to a specific entity logical name (e.g., `incident`, `account`). | No |

### Configuration layer

| Input | Description | Required |
|---|---|---|
| `scope`, `org`, `profile` | `scope` (enum: `org` \| `profile`, optional). Targets a specific layer. Omit on first call to let the tool prompt for selection. | No |

### Profile ID

| Input | Description | Required |
|---|---|---|
| `profileId` | `profileId` (UUID string, optional). Required when scope is `profile`. The tool lists available profile GUIDs if omitted. | Varies |

### Search

| Input | Description | Required |
|---|---|---|
| `search` | `search` (string, optional). Free-text search across category paths, entity names, and override-type labels. Returns a flat list of matching nodes instead of tree navigation. | No |

### Include layers

| Input | Description | Required |
|---|---|---|
| `includeLayers` | `includeLayers` (boolean, optional). When true, search also considers the educational `layers.*` subtree. Defaults to false. | No |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns structured text describing the current tree level with available child paths, descriptions, and navigation instructions. Multi-turn: the user drills deeper by providing a path in subsequent calls.

## Routing notes
Use `browse_agent_config_options` when:

- The user asks "what can I configure?", "help me set up", "getting started"
- The user wants to explore options before committing to a save
- The user asks "how do I customize X?" without specifying exact patches
- The user wants to see examples of what configurations look like

Don't use `browse_agent_config_options` when:

- The user already knows what they want to save and provides specific details. Route directly to `save_agent_config` or `save_profile_config`.
- The user asks to list existing configurations. Use `list_agent_configs` or `list_profile_configs`.
- The user asks about their personal preferences. Use `list_user_prefs`.

## Related tools
| Tool | Relationship |
|---|---|
| [`save_agent_config`](save_agent_config.md) | Saves org-level configurations after discovery |
| [`save_profile_config`](save_profile_config.md) | Saves profile-level configurations after discovery |
| [`get_agent_config_capabilities`](get_agent_config_capabilities.md) | Quick permissions check before configuration |
| [`list_agent_configs`](list_agent_configs.md) | Lists what's already configured at org level |
| [`list_profile_configs`](list_profile_configs.md) | Lists what's already configured at profile level |

## Data mutation classification
Read-only entry point with downstream mutation potential.

The browsing itself does not change data. Follow-up actions (save_agent_config, save_profile_config) triggered from the guided workflow can create or update configurations.
