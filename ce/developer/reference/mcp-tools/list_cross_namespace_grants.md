---
title: List cross-namespace grants
description: Learn how to review which foreign product tools are granted to an agent in Dynamics 365 Customer Service.
ms.date: 09/02/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=global
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# List cross-namespace grants

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to review which foreign product namespaces and tools are currently granted to an agent.

## What it does

This tool lists the foreign namespaces and tools currently granted at the organization or profile level, the net resolved tool set, and which other namespaces are still available to grant. Supply a `namespace` to preview that foreign namespace's individual tools (name, title, and description) *before* granting, so you can decide whether to grant the whole namespace or pick specific tools.

## Try prompts like

- What other agent toolsets can I add.
- Which cross-namespace tools are granted.
- Show me the foreign tools I've enabled.
- List the granted namespaces for this profile.
- What sales tools are visible to my service agents.
- What tools are in the wem namespace.

## What you'll see in chat

The assistant lists the granted namespaces and individual tools, the net resolved foreign tool set, and the namespaces available to grant.

## Helpful tips

- Use `level: organization` to review organization-wide grants.
- Use `level: profile` to review a specific profile's grants. Profile level requires the service app.
- Include `profileId` when `level` is `profile`.
- Listing doesn't change anything—it's safe to run any time.

## What happens next

- Grant a whole foreign namespace.
- Grant just one foreign tool.
- Reset cross-namespace grants.

## Does this change data?

**No, this doesn't change data.**

It reads and reports the current cross-namespace grants for the selected scope.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | List cross-namespace grants |
| Internal tool name | `list_cross_namespace_grants` |
| Purpose | Lists granted foreign namespaces and tools at the organization or profile level |

## Tool behavior

Lists the foreign namespaces and tools currently granted at organization or profile level, the net resolved tool set, and which other namespaces are available to grant. Read-only.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool only reads data. |
| `destructiveHint` | Not set | Not applicable to a read-only tool. |
| `idempotentHint` | Not set | Not applicable to a read-only tool. |
| `openWorldHint` | `false` | doesn't call external systems outside the configured Dynamics 365 scope. |

## Input concepts

### Level

| Input | Description | Required |
|---|---|---|
| `level`, `organization`, `profile` | `level` (`organization` or `profile`, defaults to `organization`). Chooses the scope to list. Profile is service-app only. | No |

### Profile ID

| Input | Description | Required |
|---|---|---|
| `profileId` | `profileId` (UUID string, optional). Required when `level` is `profile`. | Varies |

### Namespace preview

| Input | Description | Required |
|---|---|---|
| `namespace` | `namespace` (`service`, `sales`, `wem`, `customer-insights`, or `business-research-agent`, optional). When set, the response also lists that foreign namespace's individual tools (name, title, description) so you can preview them before granting. | No |

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered. Returns the granted namespaces, granted individual tools, the net resolved foreign tool set, and the namespaces available to grant. When a `namespace` is supplied, also returns that namespace's member tools (name, title, description) as a preview.

## Routing notes

Use `list_cross_namespace_grants` when:

- The user wants to see which foreign namespaces or tools are granted.
- The user wants to know what other toolsets are available to add.
- The user wants to verify a grant before or after a change.

Don't use `list_cross_namespace_grants` when:

- The user wants to grant a whole namespace. Use `save_cross_namespace_grant`.
- The user wants to grant individual tools. Use `save_cross_namespace_tools`.
- The user wants to remove all grants. Use `delete_cross_namespace_grants`.

## Related tools

| Tool | Relationship |
|---|---|
| [`save_cross_namespace_grant`](save_cross_namespace_grant.md) | Grants or revokes a whole foreign namespace |
| [`save_cross_namespace_tools`](save_cross_namespace_tools.md) | Grants or revokes individual foreign tools |
| [`delete_cross_namespace_grants`](delete_cross_namespace_grants.md) | Removes all cross-namespace grants |

## Data mutation classification

Read.

Reads the current cross-namespace grants for the selected scope without modifying them.
