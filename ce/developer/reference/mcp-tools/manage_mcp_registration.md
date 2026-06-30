---
title: Manage External MCP Tool Servers
description: Learn how to use the Manage External MCP Tool Servers capability in Dynamics 365 Customer Service.
ms.date: 06/25/2026
ms.topic: reference
ms.service: dynamics-365-customer-service
author: dleblond
ms.author: dleblond
ms.reviewer: laalexan
---

# Manage External MCP Tool Servers

[!INCLUDE [cc-mcp-tools-compatibility-versioning](../../../includes/mcp-tools/cc-mcp-tools-compatibility-versioning.md)]

Use this capability when you want to register, edit, or remove third-party MCP tool server endpoints that the Service Agent can invoke on your behalf.

## What it does
The assistant opens an admin interface where you can manage external MCP tool server registrations for your Dynamics 365 environment. MCP (Model Context Protocol) tool servers are HTTPS endpoints that expose additional tools the Service Agent can call during a conversation.

From the registration widget you can add new server endpoints, edit existing ones, test connectivity, and remove registrations you no longer need. Each registration includes a display name, endpoint URL, authentication scope, tool prefix, and a snapshot of the tools the server exposes.

## Try prompts like
- "Manage my MCP servers"
- "Register an external tool server"
- "Show my MCP server registrations"
- "Add a third-party tool endpoint"
- "Open the MCP server admin"
- "I want to register a tool endpoint"

## What you'll see in chat
The assistant displays an interactive registration management widget as an app-in-chat component. If you already have registrations, the widget shows them in a list with key details such as display name, endpoint URL, tool prefix, and tool count.

## Helpful tips
- You need the Service Agent Maker Customize privilege to manage registrations.
- Each registration requires a unique tool prefix (3-20 lowercase alphanumeric characters or hyphens) that namespaces the server's tools.
- Always use the Test Connection button before saving a new registration to verify the endpoint is reachable.
- Your environment supports up to 20 external MCP server registrations.
- Prefixes that match first-party tool namespaces (such as "cases", "email", or "mcp") are reserved and cannot be used.

> [!TIP]
> After registering a server, its tools become available to the Service Agent in future conversations. You can verify by asking the agent to use a tool from that server.

## What happens next
After the registration widget appears, you can:

- "Add a new MCP server"
- "Test my server connection"
- "Remove the Contoso server"
- "Show what tools my server provides"

## Does this change data?
**This step is read-only, but follow-up actions from it may change data.**

Opening the registration widget does not change data. Adding, editing, or removing registrations from within the widget does change your environment's configuration.

## What you can do from the app-in-chat component
From the registration widget in chat, you can:

- View all registered external MCP tool servers for your environment
- Add a new server registration by providing the endpoint URL, authentication scope, and tool prefix
- Edit an existing registration's display name, endpoint, or authentication scope
- Test connectivity to a registered server to verify it is reachable and returns valid tools
- Remove a registration you no longer need
- Review the list of tools each server exposes

## Prerequisites

This tool is available on the Dynamics 365 Customer Service MCP server. See the availability note at the top of this page for details. No additional configuration is required.

## Tool summary
| Property | Value |
|---|---|
| User-facing name | Manage External MCP Tool Servers |
| Internal tool name | `manage_mcp_registration` |
| Purpose | Opens the admin UI for managing third-party MCP tool server registrations |

## Tool behavior
Opens the admin UI for managing third-party MCP tool server registrations. Administrators can view, add, edit, and remove HTTPS server endpoint registrations that extend the Service Agent's capabilities with external tools. This tool covers HTTPS endpoint registrations only; Copilot Studio agent delegation is managed separately.

## Annotations
| Annotation | Value | Meaning |
|------------|-------|---------|
| `readOnlyHint` | `true` | This tool does not modify data directly. |
| `destructiveHint` | Not set | Not applicable (read-only tool). |
| `idempotentHint` | Not set | Not applicable (read-only tool). |
| `openWorldHint` | Not set | Uses default (queries Dataverse). |

## Input concepts
### Action

| Input | Description | Required |
|---|---|---|
| `open`, `list` | `open` (default) or `list`. `open` renders the interactive registration management widget. `list` returns a text summary of currently registered MCP servers. | No |

### Organization URL

| Input | Description | Required |
|---|---|---|
| — | Optional. A `.dynamics.com` environment URL. When provided, overrides the currently selected environment. | No |

## Response and UI behavior
This tool renders an interactive registration management widget.

This MCP tool is supported by an MCP App. 

### Response type

Interactive widget (action `open`) or text summary (action `list`)

When action is `open`, the widget displays the full registration management interface where administrators can browse, add, edit, test, and delete MCP server registrations. When action is `list`, the tool returns a text-only summary of registered servers.

## Routing notes
Use `manage_mcp_registration` when:

- The user says "MCP server", "external tool server", "third-party tool endpoint", or "register a tool endpoint"
- The user pastes an HTTPS server URL and wants to register it
- The user asks to manage, view, or configure external tool integrations

Don't use `manage_mcp_registration` when:

- The user mentions a **Copilot Studio agent**, **sub-agent**, or **MCS agent** — route to `manage_copilot_studio_registration`
- The user wants to delegate to a published bot — route to `manage_copilot_studio_registration`

## Related tools
| Tool | Relationship |
|---|---|
| [`save_mcp_registration`](save_mcp_registration.md) | Widget-invoked tool that persists a new or updated registration |
| [`delete_mcp_registration`](delete_mcp_registration.md) | Widget-invoked tool that removes a registration by ID |
| [`test_mcp_registration_connection`](test_mcp_registration_connection.md) | Widget-invoked tool that tests connectivity to an endpoint |
| [`manage_copilot_studio_registration`](manage_copilot_studio_registration.md) | Equivalent admin UI for Copilot Studio agent registrations |

## Data mutation classification
Read-only entry point with downstream mutation potential.

The tool itself does not change data. The widget it renders invokes `save_mcp_registration`, `delete_mcp_registration`, and `test_mcp_registration_connection` to perform write operations.
