---
title: List Profile Configurations
description: Learn how to use the List Profile Configurations capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# List Profile Configurations

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to view layout configurations applied to a specific Application Profile.

## What it does
The assistant lists all agent configurations that are scoped to a specific Application Profile (APM). Profile configurations allow different agent tiers (such as L1 and L2 support) to see different layouts for grids, forms, and timelines.

Each configuration entry shows the scope, name, number of layout patches, and the date it was last modified.

## Try prompts like
- "Show me the L1 agent layout customizations"
- "List profile configurations for this application profile"
- "What customizations are applied to the Tier 2 profile?"
- "Show APM customizations"
- "List our profile-level agent configurations"

## What you'll see in chat
The assistant displays a text summary of all configurations active for the specified Application Profile, including the entity, scope, and patch count for each.

## Helpful tips
- You need the Application Profile GUID to query profile-specific configurations.
- Profile configurations override org-level configurations for agents assigned to that profile.
- Use `list_agent_configs` to see org-level configurations that apply to all profiles.

## What happens next
- "Save a new layout for this profile" to add or update a configuration
- "Remove the profile customization for cases" to revert a specific layout
- "Show org-level configurations" to compare with org-wide settings

## Does this change data?
**No, this does not change data.**

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | List Profile Configurations |
| Internal tool name | `list_profile_configs` |
| Purpose | Lists agent configurations for a specific Application Profile (APM) |

## Tool behavior
Lists agent configurations for a specific Application Profile (APM). Profile configurations apply to all agents assigned to that profile, enabling tier-specific layouts (e.g., different columns for L1 vs L2 agents). Use when the user asks about layout customizations scoped to a particular profile.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Profile ID

| Input | Description | Required |
|---|---|---|
| `profileId` | `profileId` (UUID string, required). The `msdyn_appconfigurationid` of the target Application Profile. | Yes |

### Entity filter

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | `entityLogicalName` (string, optional). When provided, only returns configurations for that entity. Omit to list all configurations for the profile. | No |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns a structured list of configurations with their scope keys, names, patch counts, and last-modified timestamps scoped to the specified profile.

## Routing notes
Use `list_profile_configs` when:

- The user asks about configurations for a specific Application Profile
- The user mentions "profile", "APM", "L1", "L2", or tier-specific layouts
- You need to show scope keys before a profile-level delete operation

Don't use `list_profile_configs` when:

- The user asks about org-wide configurations. Use `list_agent_configs` instead.
- The user asks about personal preferences. Use `list_user_prefs` instead.
- You don't have a profile ID. Use `browse_agent_config_options` to discover available profiles first.

## Related tools
| Tool | Relationship |
|---|---|
| [`save_profile_config`](save_profile_config.md) | Creates or updates a profile-level configuration |
| [`delete_profile_config`](delete_profile_config.md) | Removes a profile-level configuration by scope key |
| [`list_agent_configs`](list_agent_configs.md) | Lists org-level configurations (applies to all users) |
| [`browse_agent_config_options`](browse_agent_config_options.md) | Interactive guide that can list available profiles |

## Data mutation classification
Read-only.
