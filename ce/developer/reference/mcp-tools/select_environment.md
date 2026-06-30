---
title: Select Environment
description: Learn how the Service Agent connects to a chosen Dynamics 365 environment.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Select Environment

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

This capability connects your session to a specific Dynamics 365 environment so all your subsequent actions use that org's data.

## What it does
When you click an environment in the environment picker, the assistant connects your session to that org. All subsequent actions (viewing cases, accounts, contacts, etc.) automatically use data from the selected environment. You typically don't need to invoke this directly; it happens when you click an environment in the picker.

## Try prompts like
You usually don't need to type a prompt for this. It happens automatically when you click an environment in the picker. If you need to switch environments:

- "Switch environment" (shows the picker)
- "Show my environments" (shows the picker)

## What you'll see in chat
The assistant confirms which environment you connected to, showing the environment name. After this confirmation, you can start working with data in that org.

## Helpful tips
- You don't need to type an environment ID manually. Use the environment picker instead.
- After connecting, the assistant includes the environment name in responses so you always know which org you're working in.
- If you accidentally connect to the wrong environment, just say "switch environment" to pick again.

## What happens next
After connecting to an environment:

- "Show my cases"
- "List my accounts"
- "What's in my inbox?"
- "Which environment am I connected to?" (to confirm)

## Does this change data?
**No, this does not change Dynamics 365 data.**

It updates your session connection only. No records in Dynamics 365 are modified.

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Select Environment |
| Internal tool name | `select_environment` |
| Purpose | Selects a Dynamics 365 environment for the current session |

## Tool behavior
Selects a Dynamics 365 environment for the current session. All subsequent tool calls (cases, knowledge, accounts, etc.) automatically route to this environment. This tool is typically invoked by the org picker widget when a user clicks an environment, rather than being called directly by the model.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `false` | This tool modifies session state. |
| `destructiveHint` | `false` | Selecting an environment does not destroy data. |
| `idempotentHint` | `true` | Selecting the same environment twice has no additional effect. |
| `openWorldHint` | Not set | Uses default. |

## Input concepts
### Environment ID

| Input | Description | Required |
|---|---|---|
| `environmentId` | `environmentId` (string, required). The organization GUID of the environment to select. This is the `id` field returned by `get_environment` or `list_environments`. | Yes |

## Response and UI behavior
### Response type

Text-only

No interactive component is rendered. The org picker widget updates its own state optimistically after invoking this tool. The response confirms the selected environment name and ID.

## Routing notes
`select_environment` is a backend action tool. It is almost always invoked by the org picker widget, not by direct model routing.

- Do **not** route user prompts like "switch org" to `select_environment`. Use `list_environments` to show the picker instead.
- Only call `select_environment` directly when you have a confirmed environment GUID from a prior response.

## Related tools
| Tool | Relationship |
|---|---|
| [`get_environment`](get_environment.md) | Returns the currently active environment |
| [`list_environments`](list_environments.md) | Shows the org picker widget for the user to choose from |
| [`disconnect_environment`](disconnect_environment.md) | Clears the active environment |

## Data mutation classification
Write (session state).

Modifies the session's active environment. Does not change Dynamics 365 data.
