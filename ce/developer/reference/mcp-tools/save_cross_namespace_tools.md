---
title: Grant foreign tools
description: Learn how to add or exclude individual tools from another product in Dynamics 365 Customer Service.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=global
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Grant foreign tools

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to add just one or two tools from another product, or exclude specific tools from a namespace you already granted.

## What it does

This tool grants or revokes individual foreign tools one at a time. You can add a single tool from another product, or exclude a specific tool from a whole namespace you already granted. Granting only changes visibility—a granted tool the user lacks Dataverse privilege for stays hidden.

## Try prompts like

- Add just the qualify lead tool from sales.
- Grant the lead summary tool only.
- But don't let them delete entity records.
- Exclude delete entity record from the granted sales tools.
- Remove the one sales tool I added.

## What you'll see in chat

The assistant confirms which individual tools were granted or excluded, the scope that was updated, and the net set of foreign tools now available.

## Helpful tips

- Use `level: organization` for organization-wide changes.
- Use `level: profile` when the change should apply to one profile only. Profile level requires the service app.
- Include `profileId` when `level` is `profile`.
- Use an `add` action to grant a single tool and a `remove` action to exclude one, even from a whole-namespace grant.

## What happens next

- List cross-namespace grants to verify the change.
- Grant the whole namespace instead.
- Reset cross-namespace grants.

## Does this change data?

**Yes, this changes configuration data.**

It updates the stored cross-namespace grants for the selected scope.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Grant foreign tools |
| Internal tool name | `save_cross_namespace_tools` |
| Purpose | Grants or revokes individual foreign tools at the organization or profile level |

## Tool behavior

Grants or revokes individual foreign tools one by one (for example, adding just `qualify_lead` from Sales, or excluding `delete_entity_record` from a granted Sales namespace) at organization or profile level. The change is visibility scoping only—RBAC still applies. Profile level requires the service app.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies data. |
| `destructiveHint` | `false` | Updates grants without deleting the scope. |
| `idempotentHint` | `true` | Granting the same tool twice produces the same result. |
| `openWorldHint` | `false` | doesn't call external systems outside the configured Dynamics 365 scope. |

## Input concepts

### Level

| Input | Description | Required |
|---|---|---|
| `level`, `organization`, `profile` | `level` (`organization` or `profile`, required). Chooses the scope for the grant. Profile is service-app only. | Yes |

### Profile ID

| Input | Description | Required |
|---|---|---|
| `profileId` | `profileId` (UUID string, optional). Required when `level` is `profile`. | Varies |

### Patches

| Input | Description | Required |
|---|---|---|
| `patches` | `patches` (array, required). Array of per-tool grant patches. | Yes |

### Namespace

| Input | Description | Required |
|---|---|---|
| `namespace` | `namespace` (`service`, `sales`, `wem`, `customer-insights`, or `business-research-agent`, required in each patch). The foreign tool's product namespace. | Yes |

### Tool name

| Input | Description | Required |
|---|---|---|
| `toolName` | `toolName` (string, required in each patch). Exact MCP tool name to grant or revoke individually. | Yes |

### Action

| Input | Description | Required |
|---|---|---|
| `action`, `add`, `remove` | `action` (`add` or `remove`, required in each patch). Grants the single tool or revokes it (including excluding it from a whole-namespace grant). | Yes |

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered. Returns a confirmation with the updated scope, the granted or excluded tool names, and the net resolved foreign tool set.

## Routing notes

Use `save_cross_namespace_tools` when:

- The user wants to add one or a few specific foreign tools.
- The user wants to exclude a specific tool from a granted namespace.
- The user names individual tools rather than a whole product area.

Don't use `save_cross_namespace_tools` when:

- The user wants to grant an entire product's toolset. Use `save_cross_namespace_grant`.
- The user only wants to inspect grants. Use `list_cross_namespace_grants`.
- The user wants to remove all grants. Use `delete_cross_namespace_grants`.

## Related tools

| Tool | Relationship |
|---|---|
| [`save_cross_namespace_grant`](save_cross_namespace_grant.md) | Grants or revokes a whole foreign namespace |
| [`list_cross_namespace_grants`](list_cross_namespace_grants.md) | Lists granted namespaces and tools |
| [`delete_cross_namespace_grants`](delete_cross_namespace_grants.md) | Removes all cross-namespace grants |

## Data mutation classification

Write.

Creates or updates per-tool grants for the selected scope.
