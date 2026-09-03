---
title: Save tool description override
description: Learn how to append a fallback cue to a first-party tool description in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=global
ms.service: dynamics-365-customer-service
author: gandhamm
ms.author: abpalani
ms.reviewer: laalexan
---

# Save tool description override

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability when you want to append a routing cue to a first-party tool's description so that a customer's equivalent third-party (third-party) tool becomes the primary orchestrator choice, with the first-party tool acting as a fallback.

## What it does

This tool saves organization-level tool description overrides. Each override appends a sanitized cue to the original first-party tool description. When a paired `primaryToolName` is specified, the override is applied only when that third-party tool is also registered in the same request (conditional demotion).

## Try prompts like

- Add a routing cue to `list_cases` to prefer my Copilot Studio tool.
- Save a tool description override for `get_case` with `mcs_my_case_tool` as the primary.
- Append 'Consider using Contoso Cases for better ROI' to the list cases tool description.

## What you'll see in chat

The assistant confirms how many overrides were saved and shows a preview of the appended cue for each patch (showing what text is appended at runtime). Warnings are shown if unknown tool names or non-third-party `primaryToolName` values are provided.

## Helpful tips

- Only first-party tool names can be targeted. Customer third-party tools (`mcs_*`/`ext_*`) are not supported as targets.
- `primaryToolName` should be a customer third-party tool name (`mcs_*` or `ext_*`) to enable conditional demotion.
- Cue text is sanitized to remove control characters and zero-width characters before being appended.
- The composed description (original + cue) must stay within 1024 bytes. If it exceeds the limit, the override is silently skipped at runtime.
- Changes propagate within a few minutes after saving.

## What happens next

- List tool description overrides to verify the change.
- Delete tool description overrides.
- Exit configuration mode.

## Does this change data?

**Yes, this changes configuration data.**

It saves tool description overrides in the organization-level configuration.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server and requires maker/admin privileges. No additional configuration is required.

## Tool summary

| Property             | Value                   |
| -------------------- | ----------------------- |
| **Tool name**        | `save_tool_description` |
| **Scope**            | organization                     |
| **Changes data**     | Yes                     |
| **Maker/admin only** | Yes                     |

## Tool behavior

Saves organization-level tool description override patches. Each patch appends a sanitized cue to the original first-party tool description. When a `primaryToolName` (`mcs_*`/`ext_*`) is specified, the override is applied at runtime only when that third-party tool is also registered in the same request (conditional demotion). Rejects customer third-party tool names as override targets.

## Annotations

| Annotation        | Value   | Meaning                                                                   |
| ----------------- | ------- | ------------------------------------------------------------------------- |
| `readOnlyHint`    | `false` | This tool modifies data.                                                  |
| `destructiveHint` | `false` | Merges or upserts patches; doesn't delete existing overrides.            |
| `idempotentHint`  | `true`  | Saving the same patch twice produces the same result.                     |
| `openWorldHint`   | `false` | doesn't call external systems outside the configured Dynamics 365 scope. |

## Input concepts

### Patches

| Input     | Description                               | Required |
| --------- | ----------------------------------------- | -------- |
| `patches` | Array of `tool-description` patch objects | Yes      |

### Tool name

| Input      | Description                                                  | Required |
| ---------- | ------------------------------------------------------------ | -------- |
| `toolName` | First-party tool name to shape (must not be `mcs_*`/`ext_*`) | Yes      |

### Text

| Input  | Description                                            | Required |
| ------ | ------------------------------------------------------ | -------- |
| `text` | Cue text to append after the original tool description | Yes      |

### Primary tool name

| Input             | Description                                                                               | Required |
| ----------------- | ----------------------------------------------------------------------------------------- | -------- |
| `primaryToolName` | Customer third-party tool name (`mcs_*`/`ext_*`)—override applies only when this tool is present | No       |

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered. Returns a confirmation of how many patches were saved with a preview of each composed description and any warnings for unknown tool names or non-third-party primary tool names.

## Routing notes

Use `save_tool_description` when:

- The user wants to add or update a routing cue for a first-party tool.
- The user wants to steer the model toward a customer third-party tool.
- The user is ready to confirm the cue text.

Don't use `save_tool_description` when:

- The user only wants to inspect overrides. Use `list_tool_description`.
- The user wants to remove all overrides. Use `delete_tool_description`.

## Related tools

| Tool                                                            | Relationship                                      |
| --------------------------------------------------------------- | ------------------------------------------------- |
| [`list_tool_description`](list_tool_description.md)             | Lists configured overrides before or after saving |
| [`delete_tool_description`](delete_tool_description.md)         | Removes all tool description overrides            |
| [`browse_agent_config_options`](browse_agent_config_options.md) | Explores related configuration options            |

## Data mutation classification

Write.

Creates or updates tool description override patches at organization level.
