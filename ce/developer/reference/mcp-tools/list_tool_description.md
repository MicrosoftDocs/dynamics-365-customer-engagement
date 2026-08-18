---
title: List tool description overrides
description: Learn how to view configured tool description overrides in Dynamics 365 Customer Service.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=global
ms.service: dynamics-365-customer-service
author: gandhamm
ms.author: abpalani
ms.reviewer: laalexan
---

# List tool description overrides

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to see the currently configured tool description overrides for the organization, or to discover which first-party tools can be shaped.

## What it does

This tool retrieves all organization-level tool description overrides. It also returns the list of first-party tools that can have a fallback cue appended to their description.

## Try prompts like

- List tool description overrides.
- Show which tool descriptions have been customized.
- What tool description overrides are configured?
- Which tools can I add a description cue to?

## What you'll see in chat

The assistant shows the configured patches (tool name, optional paired third-party tool, and the appended cue text) and the count of available shapeable tools.

## Helpful tips

- Only first-party tool descriptions can be overridden—customer third-party tools (`mcs_*`/`ext_*`) are excluded.
- Maker and admin tools are always excluded from overrides.
- Use this before saving to confirm the current state.

## What happens next

- Save a tool description override.
- Delete all tool description overrides.
- Exit configuration mode.

## Does this change data?

**No, this is a read-only operation.**

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server and requires maker/admin privileges. No additional configuration is required.

## Tool summary

| Property             | Value                   |
| -------------------- | ----------------------- |
| **Tool name**        | `list_tool_description` |
| **Scope**            | organization                     |
| **Changes data**     | No                      |
| **Maker/admin only** | Yes                     |

## Tool behavior

Returns all organization-level tool description override patches and the set of first-party tool names available for shaping. Customer third-party tools (`mcs_*`/`ext_*`) and maker/admin tools are excluded from the manageable set.

## Annotations

| Annotation | Value | Meaning |
|---|---|---|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | `false` | Read-only—no data is changed. |
| `idempotentHint` | `true` | Returns the same result for repeated calls with the same state. |
| `openWorldHint` | `false` | doesn't call external systems outside the configured Dynamics 365 scope. |

## Input concepts

No required inputs. The tool reads the current organization-level override configuration automatically.

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered. Returns the list of configured patches and the count of available shapeable first-party tools.

## Routing notes

Use `list_tool_description` when:

- The user wants to see current tool description overrides.
- The user wants to know which first-party tools can be shaped.
- The user wants to verify a change before or after saving.

Don't use `list_tool_description` when:

- The user wants to create or update an override. Use `save_tool_description`.
- The user wants to remove overrides. Use `delete_tool_description`.

## Related tools

| Tool | Relationship |
|---|---|
| [`save_tool_description`](save_tool_description.md) | Creates or updates tool description overrides |
| [`delete_tool_description`](delete_tool_description.md) | Removes all tool description overrides |
| [`browse_agent_config_options`](browse_agent_config_options.md) | Explores related configuration options |

## Data mutation classification

Read.
