---
title: Reset cross-namespace grants
description: Learn how to remove all foreign product tool grants from an agent in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=global
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Reset cross-namespace grants

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to undo all cross-namespace grants and return an agent to its own product tools only.

## What it does

This tool removes all cross-namespace grants at the organization or profile level, returning the agent to its native-namespace tools only. It requires confirmation before it clears the grants.

## Try prompts like

- Undo everything cross-namespace.
- Remove all foreign tools.
- Reset cross-namespace grants.
- Clear the granted namespaces for this profile.
- Take away all the sales tools I added.

## What you'll see in chat

The assistant asks you to confirm, then confirms the scope that was cleared and that the agent is back to its native tools only.

## Helpful tips

- Use `level: organization` to clear organization-wide grants.
- Use `level: profile` to clear a specific profile's grants. Profile level requires the service app.
- Include `profileId` when `level` is `profile`.
- This clears everything cross-namespace. To remove only one namespace or tool, use the grant tools with a `remove` action instead.

## What happens next

- List cross-namespace grants to verify they're cleared.
- Grant a namespace again.
- Exit configuration mode.

## Does this change data?

**Yes, this changes configuration data.**

It removes the stored cross-namespace grants for the selected scope.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Reset cross-namespace grants |
| Internal tool name | `delete_cross_namespace_grants` |
| Purpose | Removes all cross-namespace grants at the organization or profile level |

## Tool behavior

Removes all cross-namespace grants at organization or profile level, returning the agent to its native-namespace tools only. Requires confirmation. Profile level requires the service app.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `true` | Removes the cross-namespace grants for the scope. |
| `idempotentHint` | `true` | Clearing grants twice produces the same result. |
| `openWorldHint` | `false` | doesn't call external systems outside the configured Dynamics 365 scope. |

## Input concepts

### Level

| Input | Description | Required |
|---|---|---|
| `level`, `organization`, `profile` | `level` (`organization` or `profile`, required). Chooses the scope to clear. Profile is service-app only. | Yes |

### Profile ID

| Input | Description | Required |
|---|---|---|
| `profileId` | `profileId` (UUID string, optional). Required when `level` is `profile`. | Varies |

### Confirm

| Input | Description | Required |
|---|---|---|
| `confirm` | `confirm` (must be `true`). Confirms that all grants for the scope should be removed. | Yes |

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered. Returns a confirmation of the scope that was cleared.

## Routing notes

Use `delete_cross_namespace_grants` when:

- The user wants to remove all cross-namespace grants at once.
- The user wants to return an agent to its native tools only.
- The user wants to start over with grants.

Don't use `delete_cross_namespace_grants` when:

- The user wants to remove only one namespace. Use `save_cross_namespace_grant` with a `remove` action.
- The user wants to remove only one tool. Use `save_cross_namespace_tools` with a `remove` action.
- The user only wants to inspect grants. Use `list_cross_namespace_grants`.

## Related tools

| Tool | Relationship |
|---|---|
| [`save_cross_namespace_grant`](save_cross_namespace_grant.md) | Grants or revokes a whole foreign namespace |
| [`save_cross_namespace_tools`](save_cross_namespace_tools.md) | Grants or revokes individual foreign tools |
| [`list_cross_namespace_grants`](list_cross_namespace_grants.md) | Lists granted namespaces and tools |

## Data mutation classification

Write.

Deletes all cross-namespace grants for the selected scope.
