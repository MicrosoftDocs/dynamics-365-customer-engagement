---
title: Delete tool description overrides
description: Learn how to remove tool description overrides in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=global
ms.service: dynamics-365-customer-service
author: gandhamm
ms.author: abpalani
ms.reviewer: laalexan
---

# Delete tool description overrides

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to remove all configured tool description overrides for the organization. Once deleted, all first-party tools revert to their original descriptions automatically.

## What it does

This tool deletes all organization-level tool description overrides. The original tool descriptions are restored automatically on the next request—no further action is required.

## Try prompts like

- Delete all tool description overrides.
- Remove the tool description cues.
- Clear the description overrides for this organization.
- Undo the tool description customizations.

## What you'll see in chat

The assistant confirms that the overrides were deleted and that the original tool descriptions have been restored.

## Helpful tips

- Pass `toolName` to remove the override for a single first-party tool. Omit `toolName` to remove all organization-level overrides at once.
- Changes propagate within a few minutes after deleting.
- Use `list_tool_description` before deleting to review what the tool removes.

## What happens next

- List tool description overrides to confirm removal.
- Save a tool description override to start fresh.
- Exit configuration mode.

## Does this change data?

**Yes, this changes configuration data.**

It deletes all stored tool description overrides for the organization.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server and requires maker/admin privileges. No additional configuration is required.

## Tool summary

| Property             | Value                     |
| -------------------- | ------------------------- |
| **Tool name**        | `delete_tool_description` |
| **Scope**            | organization                       |
| **Changes data**     | Yes                       |
| **Maker/admin only** | Yes                       |

## Tool behavior

Deletes organization-level tool description override patches. Pass `confirm=true` to execute. Optionally pass `toolName` to remove a single tool's override; omit it to remove all organization-level overrides. The affected original tool descriptions are automatically restored on the next request—no further action is required.

## Annotations

| Annotation        | Value   | Meaning                                                                   |
| ----------------- | ------- | ------------------------------------------------------------------------- |
| `readOnlyHint`    | `false` | This tool modifies data.                                                  |
| `destructiveHint` | `true`  | Deletes all stored tool description overrides for the organization.                |
| `idempotentHint`  | `true`  | Deleting when no overrides exist produces the same result.                |
| `openWorldHint`   | `false` | doesn't call external systems outside the configured Dynamics 365 scope. |

## Input concepts

- **`confirm`** (required)—must be `true` to execute the deletion; the tool refuses to delete without it.
- **`toolName`** (optional)—the exact 1P tool name whose override to remove (for example, `draft_email`). Omit it to remove all organization-level overrides.

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered. Returns a confirmation that all overrides were deleted and that original tool descriptions have been restored.

## Routing notes

Use `delete_tool_description` when:

- The user wants to remove all tool description overrides.
- The user wants to restore all original first-party tool descriptions.
- The user wants to undo all routing cue customizations.

Don't use `delete_tool_description` when:

- The user only wants to inspect overrides. Use `list_tool_description`.
- The user wants to add or update an override. Use `save_tool_description`.

## Related tools

| Tool                                                            | Relationship                                                    |
| --------------------------------------------------------------- | --------------------------------------------------------------- |
| [`list_tool_description`](list_tool_description.md)             | Lists overrides before deletion so you can confirm what the tool removes |
| [`save_tool_description`](save_tool_description.md)             | Creates or updates tool description overrides                   |
| [`browse_agent_config_options`](browse_agent_config_options.md) | Explores related configuration options                          |

## Data mutation classification

Delete.

Removes all tool description override patches at organization level.
