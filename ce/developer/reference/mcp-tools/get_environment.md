---
title: Get active environment
description: Learn how to check which Dynamics 365 environment is connected to your current session.
ms.date: 08/11/2026
ms.topic: reference
ms.custom: mcp-enabled-namespaces=global
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Get active environment

[!INCLUDE [cc-mcp-tools-compatibility-versioning-note](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning-note.md)]

Use this capability to check which Dynamics 365 environment you are currently connected to before working with cases, accounts, or other data.

## What it does

The assistant checks your current session and tells you which Dynamics 365 environment is active. This happens automatically at the start of each conversation. If no environment is connected, the assistant prompts you to pick one.

## Try prompts like

- Which environment am I connected to?
- What organization am I using?
- Am I connected to Dynamics?
- Show me my current environment.

## What you'll see in chat

The assistant responds with a text message showing the name and details of your connected environment. If you are not connected to any environment, the assistant lets you know and offers to show the environment picker.

## Helpful tips

- This check happens automatically when you start a new conversation. You usually don't need to ask explicitly.
- If the assistant says no environment is selected, say "show my environments" to see the picker.
- The environment name shown in responses helps you confirm you're working in the right organization (for example, production vs. test).

## What happens next

- Show my environments (if you need to switch).
- List my cases (to start working in the connected environment).
- Disconnect from this environment (if you want to change orgs).

## Does this change data?

**No, this doesn't change data.**

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary

| Property | Value |
|---|---|
| User-facing name | Get active environment |
| Internal tool name | `get_environment` |
| Purpose | Returns the currently selected Dynamics 365 environment for this session |

## Tool behavior

Returns the currently selected Dynamics 365 environment for this session. This tool is called at the start of every session before any other tool to determine which organization the user is connected to. If no environment is selected, the response indicates that the user should be prompted to pick one through `list_environments`.

## Annotations

| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool doesn't modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries session state). |

## Input concepts

This tool takes no input parameters.

## Response and UI behavior

### Response type

Text-only

No interactive component is rendered. The response returns the selected organization's `friendlyName`, `id`, and connection details as structured JSON. If no organization is selected, `selectedOrg` is null.

## Routing notes

Use `get_environment` as the session initializer. It should be called automatically at the start of every conversation before any other tool.

- If `selectedOrg` is null in the response, follow up with `list_environments` to show the organization picker widget.
- Do **not** use `get_environment` when the user explicitly asks to switch environments or see all environments. Use `list_environments` instead.

## Related tools

| Tool | Relationship |
|---|---|
| [`list_environments`](list_environments.md) | Shows the organization picker widget with all available environments |
| [`select_environment`](select_environment.md) | Saves the chosen environment for the session |
| [`disconnect_environment`](disconnect_environment.md) | Clears the active environment and shows the organization picker |

## Data mutation classification

Read-only.
