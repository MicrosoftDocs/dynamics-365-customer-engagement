---
title: Reset Tool Visibility
description: Learn how to reset tool visibility settings in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Reset Tool Visibility

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to remove all tool visibility overrides for the organization or for a specific profile.

## What it does
This tool removes the saved visibility overrides for the selected scope and restores the default tool visibility state.

## Try prompts like
- "Reset tool visibility"
- "Clear all tool restrictions"
- "Remove the profile tool overrides"
- "Restore default tool visibility"
- "Undo the tool hiding changes"

## What you'll see in chat
The assistant confirms which scope was cleared and that default visibility has been restored.

## Helpful tips
- Use `level: org` to clear organization-wide overrides.
- Use `level: profile` to clear a single profile's overrides.
- Include `profileId` when `level` is `profile`.
- Confirm the action before sending it.

## What happens next
- "List tool visibility to verify the defaults"
- "Set tool visibility again if needed"
- "Exit configuration mode"

## Does this change data?
**Yes, this changes configuration data.**

It deletes the saved visibility overrides for the selected scope.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Reset Tool Visibility |
| Internal tool name | `delete_tool_selection` |
| Purpose | Removes tool visibility overrides at the organization or profile level and restores the default visibility state for that scope |

## Tool behavior
Removes tool visibility overrides at the organization or profile level and restores the default visibility state for that scope.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `true` | Deletes saved visibility overrides for the selected scope. |
| `idempotentHint` | `true` | Repeating the reset produces the same result once the overrides are gone. |
| `openWorldHint` | `false` | Does not call external systems outside the configured Dynamics 365 scope. |

## Input concepts
### Level

| Input | Description | Required |
|---|---|---|
| `level`, `org`, `profile` | `level` (`org` or `profile`, required). Chooses the scope to clear. | Yes |

### Profile ID

| Input | Description | Required |
|---|---|---|
| `profileId` | `profileId` (UUID string, optional). Required when `level` is `profile`. | Varies |

### Confirm

| Input | Description | Required |
|---|---|---|
| `confirm`, `true` | `confirm` (`true`, required). Must be `true` to delete the overrides. | Yes |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. Returns confirmation that the selected visibility overrides were removed and default visibility is restored.

## Routing notes
Use `delete_tool_selection` when:

- The user wants to clear all overrides for org or profile scope
- The user wants to restore default visibility
- The user explicitly confirms the reset

Don't use `delete_tool_selection` when:

- The user only wants to inspect visibility. Use `list_tool_selection`.
- The user wants to change visibility without clearing everything. Use `save_tool_selection`.

## Related tools
| Tool | Relationship |
|---|---|
| [`list_tool_selection`](list_tool_selection.md) | Lists visibility state before or after a reset |
| [`save_tool_selection`](save_tool_selection.md) | Reapplies visibility overrides after a reset |
| [`browse_agent_config_options`](browse_agent_config_options.md) | Explores related configuration options |

## Data mutation classification
Write.

Deletes the saved visibility overrides for the selected scope.
