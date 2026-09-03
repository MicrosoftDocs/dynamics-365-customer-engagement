---
title: Configure agent layout
description: Learn how to use the Configure agent layout capability in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=global
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Configure agent layout

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability to customize how the Service Agent displays information for an organization or Application Profile.

## What it does

The assistant saves a layout configuration that changes how grids, forms, timelines, or picklists appear. `scope` defaults to `org`; use `scope: "profile"` with `profileId` to target a specific Application Profile. For example, you can add columns to the case list, rearrange form sections, or configure which activity types appear on the timeline.

Organization configurations apply organization-wide. Profile configurations apply to agents using the selected Application Profile.

## Try prompts like

- Always show the priority column in the case grid.
- Add the customer column to the case list for all agents.
- Set up the case grid for everyone.
- Configure the default case form layout.
- Hide the SLA section for all agents.
- Change the default timeline filter to show only emails.

## What you'll see in chat

The assistant confirms which layout configuration was saved, including the entity, configuration type, and a summary of the changes applied.

## Helpful tips

- Use `browse_agent_config_options` first to discover what configuration options are available.
- Organization-level configurations apply to all users unless overridden by a profile-level or personal preference.
- You need the Service Agent Maker Customize privilege to save configurations.
- Use `list_agent_configs` to review what configurations are currently active before making changes.

## What happens next

After saving a configuration, you can:

- Show all agent configurations to review what's active.
- Remove the organization-wide customization for cases to revert.
- Set up a different layout for L1 agents to create profile-specific configurations.

## Does this change data?
**Yes, this changes configuration data.** An organization-level configuration affects all users in the organization; a profile-level configuration affects agents using the selected Application Profile. It does not modify case, account, or contact records.

## Prerequisites

This tool requires the following:

- System Administrator or Copilot Service administrator role.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Configure agent layout |
| Internal tool name | `save_agent_config` |
| Purpose | Creates or updates an organization-level or profile-level agent configuration |

## Tool behavior
Creates or updates an organization-level configuration by default, or a profile-level configuration when `scope: "profile"` and `profileId` are supplied. Translates natural-language layout requests into structured patches applied to grids, forms, timelines, picklists, or lookups.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | Creates or updates configurations without deleting existing data. |
| `idempotentHint` | `true` | Saving the same configuration twice produces the same result. |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Configuration scope
| Input | Description | Required |
|---|---|---|
| `scope` | Configuration tier: `org` (default) or `profile`. | No |
| `profileId` | Application Profile UUID. Required when `scope` is `profile`. | For profile scope |

### Target entity

| Input | Description | Required |
|---|---|---|
| `entityLogicalName` | `entityLogicalName` (string, required). The entity to configure (for example, `incident`, `account`, `contact`). | Yes |

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

No interactive component is rendered. Returns confirmation with the scope key, patch count, and effective configuration summary. The response also includes `propagationDelayMinutes` — the estimated time for the changes to take effect for users in the selected tier.

## Routing notes

Use `save_agent_config` when:

- An organization admin explicitly asks to customize layouts for all users
- A maker customizes a specific Application Profile by passing `scope: "profile"` and `profileId`
- The request is about organization-wide grid columns, form fields, timeline settings, or picklist visibility
- The user has already explored options via `browse_agent_config_options` and is ready to save

Don't use `save_agent_config` when:

- The user wants to save a personal preference. Use `save_user_prefs` instead.
- The user is still exploring options. Use `browse_agent_config_options` first.

## Related tools

| Tool | Relationship |
|---|---|
| [`list_agent_configs`](list_agent_configs.md) | Lists existing organization-level or profile-level configurations |
| [`delete_agent_config`](delete_agent_config.md) | Removes an organization-level or profile-level configuration |
| [`browse_agent_config_options`](browse_agent_config_options.md) | Interactive guide to discover configuration options before saving |
| [`save_user_prefs`](save_user_prefs.md) | Saves personal layout preferences |
| [`get_agent_config_capabilities`](get_agent_config_capabilities.md) | Checks which configuration types are available |

## Data mutation classification

Write.

Creates or updates an organization-level or profile-level agent configuration record, according to `scope`.
