---
title: Disconnect environment
description: Learn how to disconnect from your current Dynamics 365 environment and switch to a different one.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=global
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Disconnect environment

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability to disconnect from your current Dynamics 365 environment when you want to stop using it or switch to a different organization.

## What it does

The assistant disconnects your session from the currently connected Dynamics 365 environment. After disconnecting, it automatically shows the environment picker so you can reconnect to a different organization. This is useful when you need to switch between production and test environments, or when you want to ensure you're no longer connected.

## Try prompts like

- Disconnect from this environment.
- Log out of Dynamics.
- I want to switch to a different organization.
- Disconnect my environment.
- Reset my connection.

## What you'll see in chat

The assistant confirms the disconnection and then displays the environment picker so you can reconnect to a different environment.

## Helpful tips

- If you just want to switch environments, you can say "switch environment" instead. That shows the picker directly without a separate disconnect step.
- After disconnecting, other tools (like listing cases) won't work until you reconnect to an environment.
- This doesn't log you out of Microsoft 365 or Teams. It only clears the Dynamics 365 organization connection for this chat session.

## What happens next

After disconnecting, you'll see the environment picker. From there:

- select an environment to reconnect.
- Show my environments (if the picker closed).

## Does this change data?

**No, this doesn't change Dynamics 365 data.**

It clears your session connection only. No records in Dynamics 365 are modified.

## What you can do from the app-in-chat component

After disconnecting, the environment picker appears. From it you can:

- Browse all available environments.
- Select a different environment to connect to.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Disconnect environment |
| Internal tool name | `disconnect_environment` |
| Purpose | Disconnects from the currently selected Dynamics 365 environment |

## Tool behavior

Disconnects from the currently selected Dynamics 365 environment. Clears the active connection and session cache so the user can connect to a different organization. After disconnecting, the organization picker widget is automatically displayed so the user can reconnect or choose a different environment.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool clears session state but doesn't modify Dynamics 365 data. |
| `destructiveHint` | Not set | Not applicable (no Dynamics 365 data is changed). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default. |

## Input concepts

This tool takes no input parameters.

## Response and UI behavior

This MCP tool is supported by an MCP app.

### Response type

Interactive widget (organization picker)

After clearing the connection, the organization picker widget is rendered so the user can reconnect or select a different environment.

## Routing notes

Use `disconnect_environment` when the user explicitly asks to disconnect, log out, or reset their environment connection.

- If the user says "switch organization" or "change environment", prefer `list_environments` directly (it shows the picker without disconnecting first).
- If the user says "disconnect" or "log out", use this tool.

## Related tools

| Tool | Relationship |
|---|---|
| [`get_environment`](get_environment.md) | Returns the currently active environment |
| [`list_environments`](list_environments.md) | Shows the organization picker widget without disconnecting first |
| [`select_environment`](select_environment.md) | Saves the chosen environment after reconnecting |

## Data mutation classification

Write (session state).

Clears the session's active environment and Redis cache. doesn't change Dynamics 365 data.
