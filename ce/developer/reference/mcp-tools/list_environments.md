---
title: List Environments
description: Learn how to view and switch between your available Dynamics 365 environments.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# List Environments

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]
- "List my orgs"
- "I want to connect to a different environment"
- "What environments do I have access to?"
- "Change org"

## What you'll see in chat
The assistant displays an interactive environment picker as an app-in-chat component. The picker shows all available environments with their names and URLs.

## Helpful tips
- If you have multiple environments (production, sandbox, test), use this to switch between them.
- After selecting an environment, all subsequent actions (viewing cases, accounts, etc.) use that org's data.
- You don't need to disconnect before switching. Just say "switch environment" and pick a new one.

> [!TIP]
> If you're not sure which environment to use, look for the friendly name that matches your team's production org.

## What happens next
After selecting an environment, you can continue with prompts like:

- "Show my cases"
- "List my accounts"
- "What's my current environment?" (to confirm the switch)

## Does this change data?
**No, listing environments does not change data.**

Selecting an environment from the picker updates your session connection but does not modify any Dynamics 365 data.

## What you can do from the app-in-chat component
From the environment picker in chat, you can:

- Browse all available environments in your tenant
- Click an environment to connect to it
- See environment names and URLs to identify the right org

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | List Environments |
| Internal tool name | `list_environments` |
| Purpose | Lists all Dynamics 365 environments the user has access to in their tenant and renders the org picker widget |

## Tool behavior
Lists all Dynamics 365 environments the user has access to in their tenant and renders the org picker widget. Use this tool when the user explicitly asks to switch organizations, see all available environments, or when `get_environment` returns no active org.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries tenant discovery). |

## Input concepts
This tool takes no input parameters.

## Response and UI behavior
This MCP tool is supported by an MCP App. 

### Response type

Interactive widget (org picker)

The org picker widget displays all available environments with their friendly names and URLs. The user clicks an environment to select it, which triggers `select_environment` from the widget.

## Routing notes
Use `list_environments` when:

- The user explicitly asks to switch environments or see all available orgs
- `get_environment` returns `selectedOrg: null` and the user needs to pick one
- The user says "switch org", "change environment", or "show my environments"

Don't use `list_environments` when:

- You only need to check which environment is currently active. Use `get_environment` instead.
- The user wants to disconnect without reconnecting. Use `disconnect_environment` instead.

## Related tools
| Tool | Relationship |
|---|---|
| [`get_environment`](get_environment.md) | Returns the currently active environment without showing the picker |
| [`select_environment`](select_environment.md) | Saves the chosen environment. Invoked by the org picker widget |
| [`disconnect_environment`](disconnect_environment.md) | Clears the active environment and shows the org picker |

## Data mutation classification
Read-only.
