---
title: Manage Copilot Studio Agents
description: Learn how to use the Manage Copilot Studio Agents capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Manage Copilot Studio Agents

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to register, edit, or remove Copilot Studio agents that the Service Agent can delegate questions to during a conversation.

## What it does
The assistant opens an admin interface where you can manage Copilot Studio agent registrations for your Dynamics 365 environment. Copilot Studio agents are published bots that the Service Agent can hand off questions to by schema name.

From the registration widget you can add new agent delegations, edit existing ones, test connectivity, and remove registrations you no longer need. Each registration includes a display name, bot identity, description, schema name, and optional input parameters.

## Try prompts like
- "Manage my Copilot Studio agents"
- "Register a sub-agent"
- "Show my MCS agent registrations"
- "Add a Copilot Studio bot delegation"
- "Delegate to an agent"
- "I want to add an MCS agent"

## What you'll see in chat
The assistant displays an interactive registration management widget as an app-in-chat component. If you already have registrations, the widget shows them in a list with key details such as display name, tool name, description, and schema name.

## Helpful tips
- You need the Service Agent Maker Customize privilege to manage registrations.
- Only published, active Copilot Studio bots in your environment can be registered.
- Always use the Test Connection button before saving to verify the agent is reachable via the Agents SDK.
- Your environment supports up to 10 Copilot Studio agent registrations.
- The description you provide is shown to the Service Agent at routing time, so write it clearly to help the agent decide when to delegate.

> [!TIP]
> After registering an agent, the Service Agent can delegate questions to it in future conversations. The agent appears as a tool prefixed with `mcs_`.

## What happens next
After the registration widget appears, you can:

- "Add a new Copilot Studio agent"
- "Test my agent connection"
- "Remove the FAQ bot"
- "Edit the description for my registered agent"

## Does this change data?
**This step is read-only, but follow-up actions from it may change data.**

Opening the registration widget does not change data. Adding, editing, or removing registrations from within the widget does change your environment's configuration.

## What you can do from the app-in-chat component
From the registration widget in chat, you can:

- View all registered Copilot Studio agents for your environment
- Add a new agent registration by selecting a published bot from your environment
- Edit an existing registration's display name or description
- Test connectivity to a registered agent to verify it is reachable
- Remove a registration you no longer need

## Prerequisites
This tool requires the following:

- Copilot extensibility with Copilot Studio to be configured. Requires the System Administrator or Copilot Service administrator role

Learn more in [Extend Copilot with Copilot Studio](/dynamics365/customer-service/administer/extend-copilot-with-copilot-studio).

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Manage Copilot Studio Agents |
| Internal tool name | `manage_copilot_studio_registration` |
| Purpose | Opens the admin UI for managing Copilot Studio agent registrations |

## Tool behavior
Opens the admin UI for managing Copilot Studio agent registrations. Administrators can list, register, or unregister published Copilot Studio bots that the Service Agent can delegate questions to by schema name. This tool covers Copilot Studio agent delegation only; HTTPS tool server endpoints are managed via `manage_mcp_registration`.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data directly. The widget invokes separate save/delete tools. |
| `destructiveHint` | Not set | Not applicable (read-only launcher). |
| `idempotentHint` | Not set | Not applicable (read-only launcher). |
| `openWorldHint` | Not set | Uses default (queries Dataverse + Power Platform). |

## Input concepts
### Action

| Input | Description | Required |
|---|---|---|
| `open`, `list` | `open` (default) or `list`. `open` renders the interactive registration management widget. `list` returns a text summary of currently registered Copilot Studio agents. | No |

### Organization URL

| Input | Description | Required |
|---|---|---|
| `orgUrl` | `orgUrl` (optional). Overrides the currently selected environment URL when the host does not provide one. | No |

## Response and UI behavior
This MCP tool is supported by an MCP App. 

### Response type

Interactive widget (action `open`) or text summary (action `list`)

When action is `open`, the widget displays the registration management interface where administrators can browse, add, test, and remove Copilot Studio agent registrations. When action is `list`, the tool returns a text-only summary.

## Routing notes
Use `manage_copilot_studio_registration` when:

- The user mentions Copilot Studio, MCS agents, sub-agents, or bot delegation
- The user wants to add, remove, or browse agent integrations

Don't use this tool when:

- The user mentions MCP servers, tool endpoints, or HTTPS URLs - route to `manage_mcp_registration`
- The user wants to configure agent layouts (grids, forms, timelines) - route to `browse_agent_config_options`

## Related tools
| Tool | Relationship |
|---|---|
| [`save_copilot_studio_registration`](save_copilot_studio_registration.md) | Widget-invoked tool that persists a new or updated agent registration |
| [`delete_copilot_studio_registration`](delete_copilot_studio_registration.md) | Widget-invoked tool that removes an agent registration |
| [`test_copilot_studio_registration_connection`](test_copilot_studio_registration_connection.md) | Widget-invoked tool that tests agent reachability |
| [`list_copilot_studio_registration_bots`](list_copilot_studio_registration_bots.md) | Widget-invoked tool that lists available bots for the bot picker |
| [`manage_mcp_registration`](manage_mcp_registration.md) | Manages HTTPS MCP tool server registrations (separate scope) |

## Data mutation classification
Read-only launcher with downstream mutation via widget.

The launcher itself does not change data. The widget invokes `save_copilot_studio_registration` and `delete_copilot_studio_registration` for write operations.
