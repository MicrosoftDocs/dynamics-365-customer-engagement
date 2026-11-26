---
title: Set tool visibility
description: Learn how to hide or show tools in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=global
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Set tool visibility

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to hide or show MCP tools at the organization or profile level.

## What it does

This tool saves tool visibility overrides. You can hide tools at the organization level, hide additional tools for a profile, or restore a tool that was hidden at the organization level when working in profile scope.

## Try prompts like

- Hide list emails for everyone.
- Show the email tool for this profile.
- Disable tool visibility for the admin profile.
- Hide a tool for all agents.
- Make this tool visible again in the profile.

## What you'll see in chat

The assistant confirms the scope that was updated and which tools were hidden or shown.

## Helpful tips

- Use `level: organization` for organization-wide visibility changes.
- Use `level: profile` when the change should apply to one profile only.
- Include `profileId` when `level` is `profile`.
- Maker tools cannot be hidden.

## What happens next

- List tool visibility to verify the change.
- Reset tool visibility.
- Exit configuration mode.

## Does this change data?

**Yes, this changes configuration data.**

It updates the stored visibility overrides for the selected scope.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Set tool visibility |
| Internal tool name | `save_tool_selection` |
| Purpose | Saves tool visibility overrides at the organization or profile level |

## Tool behavior

Saves tool visibility overrides at the organization or profile level. Supports hiding tools at organization scope, hiding additional tools at profile scope, and restoring a tool that organization scope hid when profile scope allows it.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | Updates visibility overrides without deleting the scope. |
| `idempotentHint` | `true` | Saving the same visibility state twice produces the same result. |
| `openWorldHint` | `false` | doesn't call external systems outside the configured Dynamics 365 scope. |

## Input concepts

### Level

| Input | Description | Required |
|---|---|---|
| `level`, `organization`, `profile` | `level` (`organization` or `profile`, required). Chooses the scope for the visibility override. | Yes |

### Profile ID

| Input | Description | Required |
|---|---|---|
| `profileId` | `profileId` (UUID string, optional). Required when `level` is `profile`. | Varies |

### Patches

| Input | Description | Required |
|---|---|---|
| `patches` | `patches` (array, required). Array of `tool-selection` patches. | Yes |

### Tool name

| Input | Description | Required |
|---|---|---|
| `toolName` | `toolName` (string, required in each patch). Exact MCP tool name to hide or show. | Yes |

### Action

| Input | Description | Required |
|---|---|---|
| `action`, `hide`, `show` | `action` (`hide` or `show`, required in each patch). Hides a tool or restores it. | Yes |

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered. Returns a confirmation with the updated scope, the saved tool names, and the visibility change summary.

## Routing notes

Use `save_tool_selection` when:

- The user wants to hide or show one or more tools.
- The user wants to change visibility at organization scope or profile scope.
- The user is already clear on the target tools and actions.

Don't use `save_tool_selection` when:

- The user only wants to inspect visibility. Use `list_tool_selection`.
- The user wants to remove all overrides. Use `delete_tool_selection`.

## Related tools

| Tool | Relationship |
|---|---|
| [`list_tool_selection`](list_tool_selection.md) | Lists visibility state before or after a change |
| [`delete_tool_selection`](delete_tool_selection.md) | Removes saved visibility overrides |
| [`browse_agent_config_options`](browse_agent_config_options.md) | Explores related configuration options |

## Data mutation classification

Write.

Creates or updates tool visibility overrides for the selected scope.
