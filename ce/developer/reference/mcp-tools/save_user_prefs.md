---
title: Save My Preference
description: Learn how to use the Save My Preference capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Save My Preference

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to save a personal layout preference that customizes how the Service Agent displays information for you.

## What it does
The assistant saves a personal layout preference for your account. This lets you customize how grids, forms, or timelines appear without affecting other users. Your preferences persist across conversations and devices.

Personal preferences take the highest priority in the configuration stack, overriding both org-level and profile-level configurations.

## Try prompts like
- "Remember my case grid layout"
- "Save this as my preference"
- "Always show me the priority column first"
- "Save my personal case form layout"
- "Set my preferred timeline filter"

## What you'll see in chat
The assistant confirms which personal preference was saved, including the entity, configuration type, and a summary of the changes.

## Helpful tips
- Your personal preferences override org-level and profile-level configurations.
- Preferences persist across all your sessions and devices.
- Use `list_user_prefs` to review your current preferences before adding new ones.

## What happens next
- "Show my preferences" to verify what's saved
- "Delete my preference for the case grid" to remove a customization
- "What can I configure?" to explore available options

## Does this change data?
**Yes, this can change data.**

Saving a preference writes or updates your personal preference record in Dataverse.

Only your own preference record is affected. It doesn't change shared org-level or other users' settings.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Save My Preference |
| Internal tool name | `save_user_prefs` |
| Purpose | Saves a personal layout preference for the current user |

## Tool behavior
Saves a personal layout preference for the current user. Persists across conversations and devices, allowing each user to customize their own agent experience without affecting other users or org-level configurations. Use when the user says "remember this" or "save as my preference."

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | Creates or updates preferences without deleting existing data. |
| `idempotentHint` | `true` | Saving the same preference twice produces the same result. |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Target entity

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | `entityLogicalName` (string, required). The entity to configure (e.g., `incident`, `account`). | Yes |

### Override type

| Input | Description | Required |
|---|---|---|
| `overrideType` | `overrideType` (string, required). Configuration scope prefix: `resolution`, `grid`, `form`, `form-section`, `form-select`, `form-type`, `timeline`, `lookup`, `picklist`. | Yes |

### Target ID

| Input | Description | Required |
|---|---|---|
| `targetId`, `*` | `targetId` (string, defaults to `*`). A specific view or form GUID, or `*` for entity-wide. | No |

### Patches

| Input | Description | Required |
|---|---|---|
| `patches` | `patches` (array, required). Ordered array of patch objects discriminated by `type`. | Yes |

### Display name

| Input | Description | Required |
|---|---|---|
| `name` | `name` (string, optional). Human-readable name for this preference. | No |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns confirmation with the scope key and effective preference summary. The response also includes `propagationDelayMinutes` — the estimated time before the saved preference takes effect.

## Routing notes
Use `save_user_prefs` when:

- The user asks to save something "for me", "as my preference", or "remember this"
- The customization is personal and should not affect other users
- The user does not have org admin permissions but wants personal layout tweaks

Don't use `save_user_prefs` when:

- The user is an admin saving org-wide configurations. Use `save_agent_config` instead.
- The user specifies a profile. Use `save_profile_config` instead.
- The user is exploring options. Use `browse_agent_config_options` first.

## Related tools
| Tool | Relationship |
|---|---|
| [`list_user_prefs`](list_user_prefs.md) | Lists existing personal preferences |
| [`delete_user_prefs`](delete_user_prefs.md) | Removes a personal preference |
| [`save_agent_config`](save_agent_config.md) | Saves org-level configurations (admin only) |
| [`browse_agent_config_options`](browse_agent_config_options.md) | Interactive guide to discover what can be configured |

## Data mutation classification
Write.

Creates or updates a personal layout preference for the current user only. Does not affect other users.
