---
title: Configure non-Microsoft MCP servers in Service Agent
description: Learn how administrators can connect non-Microsoft Model Context Protocol (MCP) servers to Service Agent in Dynamics 365 Customer Service to make their tools available to service representatives.
author: lalexms
ms.author: laalexan
ms.reviewer: laalexan
ms.topic: how-to
ms.date: 06/26/2026
ms.update-cycle: 180-days
ms.custom: bap-template
---

# Configure non-Microsoft MCP servers in Service Agent

Administrators can connect non-Microsoft Model Context Protocol (MCP) servers to Service Agent to make their tools available to service representatives. Non-Microsoft MCP servers let your organization extend Service Agent with business-specific capabilities. You can register, test, update, and remove MCP server connections.

> [!NOTE]
> This article describes how to bring non-Microsoft MCP servers into Service Agent so that their tools become available to your service representatives. To expose Dynamics 365 Customer Service data outward to other agents or MCP clients instead, see [Connect to Dynamics 365 Customer Service MCP Server](configure-customer-service-mcp-server.md).

## Prerequisites

- You have an accessible MCP endpoint.
- The MCP endpoint supports Microsoft Entra authentication.
- You have a security role that allows Service Agent administration (for example, System Administrator or System Customizer) with the `prvmsdyn_ServiceAgentMakerCustomize` Dataverse privilege for the `msdyn_agentmetadataoverride` elastic table.

## Add an MCP server

1. Open Service Agent and ask to **enter maker mode**.
1. Select **Organization** as the scope.
1. Prompt to **Add MCP server**.
1. Provide the server details that are listed in the following table.
1. Test the connection to validate connectivity and authentication, and to discover the tools that the server exposes.
1. Select which discovered tools to make available. For example, you can enable all tools, disable test tools, or hide internal-only tools.

The following table describes the server details.

| Setting | Description |
| --- | --- |
| Display name | The friendly name shown to administrators. |
| Name | The internal identifier. |
| Endpoint URL | The MCP server endpoint. |
| API scope | The authentication scope. |
| Tool prefix | The tool namespace prefix. |

For more about maker mode scopes, reviewing current configurations, and exiting maker mode, see [Configure Service Agent experiences](configure-service-agent-experiences.md#enter-maker-mode).

## Modify an MCP server

1. Open Service Agent and ask to **enter maker mode**.
1. Select **Organization** as the scope.
1. Open MCP server management, and then select the server that you want to update. <!-- TODO: confirm the exact prompt to open MCP server management and select an existing server. -->
1. Update the display name, name, endpoint URL, API scope, or tool prefix. <!-- TODO: confirm the exact prompt for each update. -->

## Remove an MCP server

1. Open Service Agent and ask to **enter maker mode**.
1. Select **Organization** as the scope.
1. Open MCP server management, and then remove the server that you want to disconnect. <!-- TODO: confirm the exact prompt to remove an MCP server. -->

When you remove an MCP server, Service Agent removes its tools. Removing the server doesn't delete the external MCP server.

## Security considerations

> [!IMPORTANT]
> When you connect to non-Microsoft MCP servers, you do so at your own risk. Microsoft has no responsibility related to your use of non-Microsoft MCP servers, and you're responsible for any associated terms and charges. Some of your data might be passed to the non-Microsoft MCP server, or your MCP client might receive data from the non-Microsoft MCP server. You're responsible for managing whether your data flows outside your organization's compliance and geographic boundaries. MCP implementations are vulnerable to attacks, cascading failures, and loss of human oversight. To mitigate these risks, vet MCP servers for security and reliability, follow Microsoft's recommendations and industry best practices, and implement approval mechanisms to monitor cascading behaviors.

Service Agent authenticates to MCP servers by using Microsoft Entra-based delegated authentication.

For tool governance, only expose tools that:

- Have a documented purpose.
- Meet your security requirements.
- Are appropriate for the representatives who use them.

## Common scenarios

| Scenario | Action |
| --- | --- |
| Add HR tools | Register the HR MCP server. |
| Disable experimental tools | Deselect specific tools. |
| Replace a server endpoint | Update the MCP server configuration. |
| Remove a retired integration | Delete the MCP server registration. |

## Related information

- [Configure Service Agent experiences](configure-service-agent-experiences.md)
- [Configure Copilot Studio agents in Service Agent](configure-service-agent-copilot-studio-agents.md)
