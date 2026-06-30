---
title: Configure Profile Layout
description: Learn how to use the Configure Profile Layout capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Configure Profile Layout

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to customize how the Service Agent displays information for agents assigned to a specific Application Profile.

## What it does
The assistant saves a layout configuration scoped to a specific Application Profile. This allows you to create different layouts for different agent tiers. For example, L1 support agents might see a simplified case grid, while L2 agents see additional technical columns.

Profile configurations override org-level configurations for agents assigned to that profile.

## Try prompts like
- "Set up a different case grid for L1 agents"
- "Add the escalation column for Tier 2 agents"
- "Configure the case form for the premium support profile"
- "Customize the timeline for L1 agents"
- "Save a profile-specific layout for this application profile"

## What you'll see in chat
The assistant confirms which profile configuration was saved, including the profile, entity, configuration type, and a summary of the changes.

## Helpful tips
- You need the Application Profile GUID when saving profile-scoped configurations.
- Profile configurations take precedence over org-level configurations.
- Use `browse_agent_config_options` with `scope: profile` to discover available options.
- Use `list_profile_configs` to review what configurations are active for a profile.

## What happens next
- "Show profile configurations" to verify what's active
- "Remove the profile customization for cases" to revert
- "Set up the org-wide layout" to create a baseline all profiles inherit

## Does this change data?
**Yes, this can change data.**

## Prerequisites
This tool requires the following:

- System Administrator or Copilot Service administrator role

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Configure Profile Layout |
| Internal tool name | `save_profile_config` |
| Purpose | Creates or updates an agent configuration scoped to an Application Profile |

## Tool behavior
Creates or updates an agent configuration scoped to an Application Profile. Use for tier-specific customizations where different agent groups need different layouts (e.g., different grid columns for L1 vs L2 agents, different form sections visible per profile).

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | Creates or updates configurations without deleting existing data. |
| `idempotentHint` | `true` | Saving the same configuration twice produces the same result. |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Profile ID

| Input | Description | Required |
|---|---|---|
| `profileId` | `profileId` (UUID string, required). The `msdyn_appconfigurationid` of the target Application Profile. | Yes |

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
| `name` | `name` (string, optional). Human-readable name for this configuration. | No |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns confirmation with the scope key, patch count, and effective configuration summary. The response also includes `propagationDelayMinutes` — the estimated time for the changes to take effect for users assigned to this profile.

## Routing notes
Use `save_profile_config` when:

- The user mentions a specific Application Profile, agent tier, or APM
- The customization should apply to a subset of agents (not all users)
- The user has a profile ID from `browse_agent_config_options` or a prior response

Don't use `save_profile_config` when:

- The customization should apply to all users. Use `save_agent_config` instead.
- The user wants a personal preference. Use `save_user_prefs` instead.
- You don't have a profile ID. Use `browse_agent_config_options` to list available profiles.

## Related tools
| Tool | Relationship |
|---|---|
| [`list_profile_configs`](list_profile_configs.md) | Lists existing profile-level configurations |
| [`delete_profile_config`](delete_profile_config.md) | Removes a profile-level configuration |
| [`save_agent_config`](save_agent_config.md) | Saves configurations at the org level (all users) |
| [`browse_agent_config_options`](browse_agent_config_options.md) | Discovers available profiles and configuration options |

## Data mutation classification
Write.

Creates or updates an agent configuration scoped to an Application Profile. Affects all agents assigned to that profile.
