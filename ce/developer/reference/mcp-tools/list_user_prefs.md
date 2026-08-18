---
title: List my preferences
description: Learn how to use the List my preferences capability in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=global
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# List my preferences

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to view your personal layout preferences for the Service Agent.

## What it does

The assistant lists all personal layout preferences you have saved. Personal preferences let you customize how grids, forms, and timelines appear for you without affecting other users.

Each preference entry shows the scope, name, number of layout patches, and when it was last modified.

## Try prompts like

- Show my saved preferences.
- What personal customizations do I have?
- List my layout preferences.
- Show my custom case grid settings.

## What you'll see in chat

The assistant displays a text summary of all your personal preferences, including the entity, scope, and patch count for each.

## Helpful tips

- Personal preferences override both organization-level and profile-level configurations for your account only.
- Your preferences persist across sessions and devices.
- Use this tool to audit your customizations before resetting them.

## What happens next

- Save a new preference to add or update a personal layout.
- Delete my preference for the case grid to remove a specific customization.
- Show organization-level configurations to see what the default layouts are.

## Does this change data?

**No, this doesn't change data.**

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | List my preferences |
| Internal tool name | `list_user_prefs` |
| Purpose | Lists all personal layout preferences for the current user |

## Tool behavior

Lists all personal layout preferences for the current user. Shows scope, name, patch count, and last modified date for each saved preference. Personal preferences persist across conversations and devices, allowing users to customize their own agent experience without affecting others.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default. |

## Input concepts

### Entity filter

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | `entityLogicalName` (string, optional). When provided, only returns preferences for that entity. Omit to list all personal preferences. | No |

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered. Returns a structured list of the user's personal preferences with their scope keys, names, patch counts, and last-modified timestamps.

## Routing notes

Use `list_user_prefs` when:

- The user asks about their own saved preferences or personal customizations.
- The user says "my preferences", "my layouts", or "my customizations".
- You need to show scope keys before a user preference delete operation.

Don't use `list_user_prefs` when:

- The user asks about organization-level configurations. Use `list_agent_configs` instead.
- The user asks about profile-level configurations. Use `list_profile_configs` instead.
- The user is an admin asking about all users' preferences (not supported; each user sees only their own).

## Related tools

| Tool | Relationship |
|---|---|
| [`save_user_prefs`](save_user_prefs.md) | Saves a personal layout preference |
| [`delete_user_prefs`](delete_user_prefs.md) | Removes a personal layout preference by scope key |
| [`list_agent_configs`](list_agent_configs.md) | Lists organization-level configurations (admin view) |
| [`browse_agent_config_options`](browse_agent_config_options.md) | Interactive guide to discover configuration options |

## Data mutation classification

Read-only.
