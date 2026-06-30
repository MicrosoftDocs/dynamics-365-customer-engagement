---
title: Remove Profile Configuration
description: Learn how to use the Remove Profile Configuration capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Remove Profile Configuration

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to remove a layout configuration from a specific Application Profile and revert to the org-level default.

## What it does
The assistant removes a profile-scoped layout configuration by its scope key. After removal, agents assigned to that profile see the org-level configuration (if one exists) or the system default. This action requires explicit confirmation.

## Try prompts like
- "Remove the L1 case grid customization"
- "Reset the profile layout for Tier 2 agents"
- "Delete the profile-level case form configuration"
- "Revert this profile to the org default"

## What you'll see in chat
The assistant asks for confirmation before removing the configuration. After you confirm, it reports which profile configuration was removed.

## Helpful tips
- Use `list_profile_configs` first to see active configurations and their scope keys.
- Removal is permanent. The configuration cannot be recovered after deletion.
- Org-level and personal preference configurations are not affected.

## What happens next
- "Show profile configurations" to verify the removal
- "Set up a new layout for this profile" to create a replacement
- "Show org-level configurations" to see what agents will fall back to

## Does this change data?
**Yes, this can change data.**

## Prerequisites
This tool requires the following:

- System Administrator or Copilot Service administrator role

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Remove Profile Configuration |
| Internal tool name | `delete_profile_config` |
| Purpose | Removes an agent configuration from an Application Profile by scope key |

## Tool behavior
Removes an agent configuration from an Application Profile by scope key. Use when the user asks to remove or reset a profile-level customization (e.g., "reset L1 grid layout"). Requires explicit confirmation to prevent accidental deletions.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `true` | This tool permanently removes configuration data. |
| `idempotentHint` | `true` | Deleting an already-removed scope has no additional effect. |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Profile ID

| Input | Description | Required |
|---|---|---|
| `profileId` | `profileId` (UUID string, required). The `msdyn_appconfigurationid` of the target Application Profile. | Yes |

### Scope key

| Input | Description | Required |
|---|---|---|
| `scope` | `scope` (string, required). The scope key to remove (e.g., `grid:incident:*`). Use `list_profile_configs` to discover existing scope keys. | Yes |

### Confirmation

| Input | Description | Required |
|---|---|---|
| `confirm`, `true` | `confirm` (literal `true`, required). Must be explicitly set to `true` to confirm the deletion. | Yes |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns confirmation that the configuration was removed from the profile, or an error if the scope key was not found.

## Routing notes
Use `delete_profile_config` when:

- The user explicitly asks to remove a profile-level configuration
- The user mentions a specific profile or agent tier when asking to reset layouts
- Always call `list_profile_configs` first if the user hasn't specified a scope key

Don't use `delete_profile_config` when:

- The user wants to remove an org-level configuration. Use `delete_agent_config` instead.
- The user wants to remove a personal preference. Use `delete_user_prefs` instead.
- The user wants to modify (not remove) a profile configuration. Use `save_profile_config` instead.

## Related tools
| Tool | Relationship |
|---|---|
| [`list_profile_configs`](list_profile_configs.md) | Lists existing profile configurations to identify scope keys |
| [`save_profile_config`](save_profile_config.md) | Creates or updates profile-level configurations |
| [`delete_agent_config`](delete_agent_config.md) | Removes org-level configurations |
| [`delete_user_prefs`](delete_user_prefs.md) | Removes personal layout preferences |

## Data mutation classification
Write (destructive).

Permanently removes an agent configuration from an Application Profile. Affects all agents assigned to that profile. The assistant asks for confirmation before executing.
