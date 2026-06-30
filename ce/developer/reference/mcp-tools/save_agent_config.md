---
title: Configure Agent Layout
description: Learn how to use the Configure Agent Layout capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Configure Agent Layout

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability to customize how the Service Agent displays information for all users in your organization.

## What it does
The assistant saves a layout configuration that changes how grids, forms, timelines, or picklists appear for everyone in the organization. For example, you can add columns to the case list, rearrange form sections, or configure which activity types appear on the timeline.

These configurations apply organization-wide. All agents in your org see the updated layout.

## Try prompts like
- "Always show the priority column in the case grid"
- "Add the customer column to the case list for all agents"
- "Set up the case grid for everyone"
- "Configure the default case form layout"
- "Hide the SLA section for all agents"
- "Change the default timeline filter to show only emails"

## What you'll see in chat
The assistant confirms which layout configuration was saved, including the entity, configuration type, and a summary of the changes applied.

## Helpful tips
- Use `browse_agent_config_options` first to discover what configuration options are available.
- Org-level configurations apply to all users unless overridden by a profile-level or personal preference.
- You need the Service Agent Maker Customize privilege to save org-level configurations.
- Use `list_agent_configs` to review what configurations are currently active before making changes.

## What happens next
After saving a configuration, you can:

- "Show all agent configurations" to review what's active
- "Remove the org-wide customization for cases" to revert
- "Set up a different layout for L1 agents" to create profile-specific configurations

## Does this change data?
**Yes, this changes configuration data.** The assistant saves a layout configuration that affects how information is displayed for all users in the organization. It does not modify case, account, or contact records.

## Prerequisites
This tool requires the following:

- System Administrator or Copilot Service administrator role

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Configure Agent Layout |
| Internal tool name | `save_agent_config` |
| Purpose | Creates or updates an org-level agent configuration |

## Tool behavior
Creates or updates an org-level agent configuration. Translates natural-language layout requests into structured patches applied to grids, forms, timelines, picklists, or lookups for all users in the organization. Use when an org admin asks to customize layouts at the org tier.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | Creates or updates configurations without deleting existing data. |
| `idempotentHint` | `true` | Saving the same configuration twice produces the same result. |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Target entity

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | `entityLogicalName` (string, required). The entity to configure (e.g., `incident`, `account`, `contact`). | Yes |

### Override type

| Input | Description | Required |
|---|---|---|
| `overrideType` | `overrideType` (string, required). The configuration scope prefix: `resolution`, `grid`, `form`, `form-section`, `form-select`, `form-type`, `timeline`, `lookup`, `picklist`. | Yes |

### Target ID

| Input | Description | Required |
|---|---|---|
| `targetId`, `*` | `targetId` (string, defaults to `*`). A specific view or form GUID, or `*` for entity-wide application. | No |

### Patches

| Input | Description | Required |
|---|---|---|
| `patches` | `patches` (array, required). Ordered array of patch objects discriminated by `type`. Valid types include `column` (grid columns), `section` (form sections), `field` (form fields), `source` (base view/form replacement), `picklist` (option set visibility), `timeline` (timeline config). | Yes |

### Display name

| Input | Description | Required |
|---|---|---|
| `name` | `name` (string, optional). Human-readable name for this configuration. | No |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns confirmation with the scope key, patch count, and effective configuration summary. The response also includes `propagationDelayMinutes` — the estimated time for the changes to take effect for all users in the org.

## Routing notes
Use `save_agent_config` when:

- An org admin explicitly asks to customize layouts for all users
- The request is about org-wide grid columns, form fields, timeline settings, or picklist visibility
- The user has already explored options via `browse_agent_config_options` and is ready to save

Don't use `save_agent_config` when:

- The user wants to customize for a specific Application Profile. Use `save_profile_config` instead.
- The user wants to save a personal preference. Use `save_user_prefs` instead.
- The user is still exploring options. Use `browse_agent_config_options` first.

## Related tools
| Tool | Relationship |
|---|---|
| [`list_agent_configs`](list_agent_configs.md) | Lists existing org-level configurations |
| [`delete_agent_config`](delete_agent_config.md) | Removes an org-level configuration |
| [`browse_agent_config_options`](browse_agent_config_options.md) | Interactive guide to discover configuration options before saving |
| [`save_profile_config`](save_profile_config.md) | Saves configurations scoped to an Application Profile |
| [`save_user_prefs`](save_user_prefs.md) | Saves personal layout preferences |
| [`get_agent_config_capabilities`](get_agent_config_capabilities.md) | Checks which configuration types are available |

## Data mutation classification
Write.

Creates or updates an org-level agent configuration record. Affects all users in the organization.
