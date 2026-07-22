---
title: Remove Agent Configuration
description: Learn how to use the Remove Agent Configuration capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Remove Agent Configuration

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to remove an org-level layout configuration and revert to the default display.

## What it does
The assistant removes an org-wide layout configuration by its scope key. After removal, the affected grid, form, or timeline reverts to the system default for all users in the organization. This action requires explicit confirmation before proceeding.

## Try prompts like
- "Remove the org-wide customization for cases"
- "Reset the agent configuration on the case grid"
- "Delete the org-level case form layout"
- "Revert the case grid to defaults"
- "Remove all org customizations for accounts"

## What you'll see in chat
The assistant asks for confirmation before removing the configuration. After you confirm, it reports which configuration was removed and that the layout has reverted to the system default.

## Helpful tips
- Use `list_agent_configs` first to see active configurations and their scope keys.
- Removal is permanent. The configuration cannot be recovered after deletion.
- Profile-level and personal preferences are not affected when you remove an org-level configuration.
- You need the Service Agent Maker Customize privilege to remove org-level configurations.

## What happens next
After removing a configuration, you can:

- "Show all agent configurations" to verify the removal
- "Set up a new case grid layout" to create a fresh configuration
- "What can I configure?" to explore available options

## Does this change data?
**Yes, this removes configuration data.** The org-wide layout configuration is permanently deleted. Case, account, and contact records are not affected.

## Prerequisites
This tool requires the following:

- System Administrator or Copilot Service administrator role

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Remove Agent Configuration |
| Internal tool name | `delete_agent_config` |
| Purpose | Removes an org-level agent configuration by scope key |

## Tool behavior
Removes an org-level agent configuration by scope key. Use when an org admin asks to remove or reset a previously applied org-wide customization. Requires explicit confirmation to prevent accidental deletions.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `true` | This tool permanently removes configuration data. |
| `idempotentHint` | `true` | Deleting an already-removed scope has no additional effect. |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Scope key

| Input | Description | Required |
|---|---|---|
| `scope` | `scope` (string, required). The scope key to remove (e.g., `grid:incident:*`, `form:account:*`, `timeline:incident:*`). Use `list_agent_configs` to discover existing scope keys. | Yes |

### Confirmation

| Input | Description | Required |
|---|---|---|
| `confirm`, `true` | `confirm` (literal `true`, required). Must be explicitly set to `true` to confirm the deletion. Prevents accidental removals. | Yes |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns confirmation that the configuration was removed, or an error if the scope key was not found.

## Routing notes
Use `delete_agent_config` when:

- The user explicitly asks to remove or reset an org-level configuration
- The user provides a scope key or describes a configuration to remove
- Always call `list_agent_configs` first to show available scope keys if the user hasn't specified one

Don't use `delete_agent_config` when:

- The user wants to remove a profile-level configuration. Use `delete_profile_config` instead.
- The user wants to remove a personal preference. Use `delete_user_prefs` instead.
- The user wants to modify (not remove) an existing configuration. Use `save_agent_config` instead.

## Related tools
| Tool | Relationship |
|---|---|
| [`list_agent_configs`](list_agent_configs.md) | Lists existing configurations to identify scope keys for deletion |
| [`save_agent_config`](save_agent_config.md) | Creates or updates org-level configurations |
| [`delete_profile_config`](delete_profile_config.md) | Removes profile-level configurations |
| [`delete_user_prefs`](delete_user_prefs.md) | Removes personal layout preferences |

## Data mutation classification
Write (destructive).

Permanently removes an org-level agent configuration. This affects all users in the organization. The assistant asks for confirmation before executing.
