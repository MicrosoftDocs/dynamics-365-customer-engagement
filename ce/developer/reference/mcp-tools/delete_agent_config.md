---
title: Remove agent configuration
description: Learn how to use the Remove agent configuration capability in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=global
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Remove agent configuration

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability to remove an org-level or Application Profile layout configuration and revert to the default display.

## What it does
The assistant removes a layout configuration by its scope key. The optional `scope` selects the org (default) or profile tier; profile deletion also requires `profileId`. After removal, the affected grid, form, or timeline reverts to the applicable default. This action requires explicit confirmation before proceeding.

## Try prompts like

- Remove the organization-wide customization for cases.
- Reset the agent configuration on the case grid.
- Delete the organization-level case form layout.
- Revert the case grid to defaults.
- Remove all organization customizations for accounts.

## What you'll see in chat
The assistant asks for confirmation before removing the configuration. After you confirm, it reports which configuration was removed. The layout then uses the next applicable tier, such as an org configuration after a profile configuration is removed, or the system default.

## Helpful tips

- Use `list_agent_configs` first to see active configurations and their scope keys.
- Removal is permanent. The configuration cannot be recovered after deletion.
- Profile-level and personal preferences are not affected when you remove an organization-level configuration.
- You need the Service Agent Maker Customize privilege to remove organization-level configurations.

## What happens next

After removing a configuration, you can:

- Show all agent configurations to verify the removal.
- Set up a new case grid layout to create a fresh configuration.
- What can I configure? to explore available options.

## Does this change data?
**Yes, this removes configuration data.** The selected org-level or profile-level layout configuration is permanently deleted. Case, account, and contact records are not affected.

## Prerequisites

This tool requires the following:

- System Administrator or Copilot Service administrator role.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Remove agent configuration |
| Internal tool name | `delete_agent_config` |
| Purpose | Removes an org-level or profile-level agent configuration by scope key |

## Tool behavior
Removes an org-level or profile-level agent configuration by scope key. Use `scope: "org"` (the default) for org-wide customizations or `scope: "profile"` with `profileId` for Application Profile customizations. Requires explicit confirmation to prevent accidental deletions.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `true` | This tool permanently removes configuration data. |
| `idempotentHint` | `true` | Deleting an already-removed scope has no additional effect. |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Configuration scope

| Input | Description | Required |
|---|---|---|
| `scope` | Configuration tier: `org` (default) or `profile`. | No |
| `profileId` | Application Profile UUID. Required when `scope` is `profile`. | For profile scope |
| `scopeKey` | The configuration key to remove (e.g., `grid:incident:*`, `form:account:*`, `timeline:incident:*`). Use `list_agent_configs` to discover existing keys. | Yes |

### Confirmation

| Input | Description | Required |
|---|---|---|
| `confirm`, `true` | `confirm` (literal `true`, required). Must be explicitly set to `true` to confirm the deletion. Prevents accidental removals. | Yes |

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered. Returns confirmation after the idempotent delete. If the scope key is already absent, the operation still succeeds and makes no additional change.

## Routing notes

Use `delete_agent_config` when:

- The user explicitly asks to remove or reset an org-level configuration
- The user asks to remove a profile-level configuration and supplies the target `profileId`
- The user provides a scope key or describes a configuration to remove
- Always call `list_agent_configs` first to show available scope keys if the user hasn't specified one

Don't use `delete_agent_config` when:

- The user wants to remove a personal preference. Use `delete_user_prefs` instead.
- The user wants to modify (not remove) an existing configuration. Use `save_agent_config` instead.

## Related tools

| Tool | Relationship |
|---|---|
| [`list_agent_configs`](list_agent_configs.md) | Lists existing configurations to identify scope keys for deletion |
| [`save_agent_config`](save_agent_config.md) | Creates or updates org-level or profile-level configurations |
| [`delete_user_prefs`](delete_user_prefs.md) | Removes personal layout preferences |

## Data mutation classification

Write (destructive).

Permanently removes an org-level or profile-level agent configuration, according to `scope`. The assistant asks for confirmation before executing.
