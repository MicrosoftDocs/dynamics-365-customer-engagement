---
title: Connect Dynamics 365 CX MCP Server - Service through Agent 365 Tooling Gateway
description: Learn how to connect Dynamics 365 CX MCP Server - Service to Copilot Studio and supported MCP clients through the Agent 365 Tooling Gateway.
author: gandhamm 
ms.author: mgandham
ms.reviewer: mgandham
ms.topic: how-to 
ms.date: 07/30/2026
ms.custom: bap-template 
ms.collection: bap-ai-copilot
---

# Connect Dynamics 365 CX MCP Server - Service through Agent 365 Tooling Gateway 

> [!IMPORTANT]
> US NOTICE: Enabling this feature will allow data to egress outside of the FedRAMP High boundary. Users should confirm with their Tenant Administrator that this feature meets their organization’s specific security requirements and compliance obligations.

Use the Dynamics 365 CX Model Context Protocol (MCP) Server - Service to connect Customer Service data and tools to Microsoft Copilot Studio agents or other MCP clients that support HTTP-based MCP connections. Agent 365 Tooling Gateway (ATG) provides the Microsoft-hosted gateway that fronts the Customer Service MCP server and handles authentication to Dataverse.

This article explains how to:

- Understand how Agent 365 Tooling Gateway authentication works for the Dynamics 365 CX MCP Server - Service.
- Configure a Copilot Studio agent to use the Dynamics 365 CX MCP Server - Service server through Agent 365 Tooling Gateway.
- Connect supported external MCP clients, such as Cursor, ChatGPT, Claude Code, Visual Studio Code, and GitHub Copilot CLI.
- Troubleshoot common setup and authentication issues.


## How Agent 365 Tooling Gateway authentication works

Agent 365 Tooling Gateway is an OAuth 2.0-protected resource. Each MCP server URL that the gateway fronts exposes OAuth discovery metadata through an anonymous discovery endpoint.

```http
GET https://<ring-host>/.well-known/oauth-protected-resource/mcp/environments/<environment-id>/servers/mcp_D365CX_Service
```

The discovery response tells the MCP client which authorization server, resource audience, and scopes to use.

```json
{
  "resource_name": "mcp_D365CX_Service",
  "resource": "https://<ring-host>/mcp/environments/<environment-id>/servers/mcp_D365CX_Service",
  "authorization_servers": [
    "https://login.microsoftonline.com/organizations/v2.0"
  ],
  "scopes_supported": [
    "https://<ring-host>/mcp/environments/<environment-id>/servers/mcp_D365CX_Service/.default",
    "openid",
    "profile",
    "offline_access"
  ],
  "bearer_methods_supported": [
    "header"
  ]
}
```

The MCP client requests a token for the Agent 365 Tooling Gateway resource. Agent 365 Tooling Gateway then performs the on-behalf-of exchange that allows the request to reach Dataverse.

## Key considerations

- The token audience is tooling gateway, not the Dynamics 365 CX MCP Server - Service directly.
- The OAuth scope uses the Agent 365 Tooling Gateway resource URL and ends with `/.default`.
- The `/.default` scope doesn't support incremental or dynamic user consent. Admin consent must be granted in advance in the customer tenant.
- The scope is specific to the ring, environment, and server. Each ring and environment requires its own connector configuration.
- Discovery-capable clients can read the OAuth metadata automatically. Copilot Studio custom connector setup might require you to enter OAuth values manually.

## Prerequisites

- Use the System Administrator or Omnichannel Administrator role to configure the MCP server. 
- Use the Customer Service Representative or CSR Manager role to use the MCP server and its tools. 
- The Dynamics 365 CX MCP Server - Service must be configured and available in the Copilot Studio tools list. 
- Dataverse environment ID. This is required in the Agent 365 Tooling Gateway  server URL. The environment ID must belong to the same ring as the Agent 365 Tooling Gateway  host.
- Correct Agent 365 Tooling Gateway ring host and app ID.
- Tenant admin or delegated admin-consent permissions.
-  Non-production tenant account for Test or PreProd, when you connect to non-production Agent 365 Tooling Gateway  rings. 

> [!NOTE]
> The environment ID in the URL must belong to the same ring as the Agent 365 Tooling Gateway  host. For example, a Test-ring environment ID doesn't resolve on the PreProd or Prod host.

> [!IMPORTANT]
> Enabling connections between Dynamics 365 and non-Dynamics 365 services, including Microsoft or external services, will allow data to egress outside of the Dynamics 365 FedRAMP High boundary. Data flowing from Dynamics 365 to other services will be processed and stored according to the terms, compliance commitments, and data residency and handling requirements of the destination service.
> 
> This data might include queries and other data submitted to agents by users in your organization. Before enabling MCP server connections for your organization, your Tenant Administrator should confirm that these connections meet their data security, compliance, residency, and governance requirements.

## Agent 365 Tooling Gateway ring hosts and app IDs

Agent 365 Tooling Gateway uses separate hosts and Microsoft Entra app IDs for each ring. Use the host and app ID that match the target environment.

| Ring | Gateway host | Microsoft Entra app ID |
|---|---|---|
| Test | `https://test.agent365.svc.cloud.dev.microsoft` | `05879165-0320-489e-b644-f72b33f3edf0` |
| PreProd | `https://preprod.agent365.svc.cloud.dev.microsoft` | `4585d2c8-61e2-4f6a-a2a5-707519abf91c` |
| Prod | `https://agent365.svc.cloud.microsoft` | `ea9ffc3e-8a23-4a7d-836d-234d7c7565c1` |


Use this server URL format for all rings:

```http
https://<ring-host>/mcp/environments/<environment-id>/servers/mcp_D365CX_Service
```

The `/mcp/environments/` path segment is required. If you omit it, the request returns `404 RouteNotFound`.

## Provision the service principal and grant admin consent

The Agent 365 Tooling Gateway app is a Microsoft first-party app registration. Before a client app can request a token for it, the tooling gateway service principal must exist in the customer tenant and the delegated permission must be admin-consented.

As a tenant admin, open the following admin-consent URL. Replace `<customer-tenant-id>` with the customer tenant ID and `<ATG-ring-app-id>` with the app ID for the target ring.

```http
https://login.microsoftonline.com/<customer-tenant-id>/adminconsent?client_id=<ATG-ring-app-id>
```

Sign in as a tenant admin and approve the request. Microsoft Entra creates the Agent 365 Tooling Gateway resource service principal under **Enterprise applications** in the customer tenant.

You can also provision the service principal manually and grant admin consent as follows:

```azurecli
az ad sp create --id <ATG-ring-app-id>
```

```powershell
New-MgServicePrincipal -AppId "<ATG-ring-app-id>"
```

## Create a client Microsoft Entra app for Copilot Studio

To configure a custom connector in Copilot Studio, create your own confidential client app in Microsoft Entra ID. This app isn't the Dynamics 365 first-party app and only requires permission to access the Agent 365 Tooling Gateway resource scope.

In the [Microsoft Entra admin center](https://entra.microsoft.com), complete the following steps:
1. Create a Microsoft Entra app registration by following the steps in [Register an application](/entra/identity-platform/quickstart-register-app#register-an-application). Make sure you use a single-tenant app registration.
1. Create a client secret for the app registration. Learn more in [Add a client secret](/entra/identity-platform/how-to-add-credentials?tabs=client-secret). Copy the secret value. You use this value when you configure OAuth in Copilot Studio.
1. Go to **API permissions**, and then select **Add a permission**.
1. Select **APIs my organization uses**.
1. Search for the Agent 365 Tooling Gateway app by using the app ID for the target ring.
1. Add the delegated permission that the Agent 365 Tooling Gateway app exposes for `McpServers.D365Service.All`.
1. Select **Grant admin consent**.

Leave the web redirect URI empty until Copilot Studio generates the callback URL during connector setup.

### Add MCP server to agent

1. Open [Copilot Studio](https://copilotstudio.microsoft.com), and then open or create an agent.
1. Follow the steps in [Add tools and resources from a Model Context Protocol (MCP) server to your agent](/microsoft-copilot-studio/mcp-add-components-to-agent) to create a new MCP server and provide the following details:

   | Field | Value |
   |---|---|
   | Server name | Enter a clear name, such as `Dynamics 365 CX MCP Server through ATG`. |
   | Server description | Describe the available capabilities so the orchestrator can route requests to this server. For example, `Use Dynamics 365 Customer Experience tools to list, read, and update cases; search knowledge; view activity timelines; and draft emails.` |
   | Server URL | `https://<ring-host>/mcp/environments/<environment-id>/servers/mcp_D365CX_Service` |
   | Authentication | Select **OAuth 2.0**. |  

1. Enter the OAuth values that Agent 365 Tooling Gateway discovery metadata provides. Use manual configuration unless your Copilot Studio environment supports dynamic OAuth discovery for MCP servers.

   | Field | Value |
   |---|---|
   | Client ID | The client ID of the Microsoft Entra app that you created for Copilot Studio. |
   | Client secret | The client secret value from the Microsoft Entra app. |
   | Authorization URL | `https://login.microsoftonline.com/<customer-tenant-id>/oauth2/v2.0/authorize` |
   | Token URL | `https://login.microsoftonline.com/<customer-tenant-id>/oauth2/v2.0/token` |
   | Refresh URL | Same as the token URL. |
   | Scope | `<ATG ring App ID>/.default` For example: Prod `ea9ffc3e-8a23-4a7d-836d-234d7c7565c1/.default`, Test `05879165-0320-489e-b644-f72b33f3edf0/.default` |

After you create the OAuth configuration, Copilot Studio displays a callback URL. Copy the callback URL and add it as a **Web** redirect URI on the Microsoft Entra app that you created for Copilot Studio.

### Create the connection and add the tool

In your Copilot Studio agent, complete the following steps:

1. In the **Add tool** dialog, select **Create a new connection**.
1. Sign in with an account that has access to the target Customer Service environment.
1. For Test or PreProd, use a non-production tenant account. A production or corporate tenant account on a non-production ring can trigger the `TenantBlocked` error.
1. Add the tool to the agent.
1. Publish the agent.

Optionally, if you want to use your agent in Customer Service, go to the **Channels** tab and connect the agent to Dynamics 365 Customer Service.

## Configure discovery-capable MCP clients

Discovery-capable MCP clients, such as Visual Studio Code, GitHub Copilot CLI, Cursor, ChatGPT, and Claude Code, can retrieve tooling gateway OAuth metadata automatically. For these clients, configure the MCP server URL and let the client handle sign-in.

> [!NOTE]
> No manual OAuth endpoint, client ID, scope, or secret is required for clients that support OAuth discovery for MCP servers.

### Visual Studio Code

1. In Visual Studio Code, open the command palette by pressing Ctrl+Shift+P.
1. Enter `MCP: Add Server`.
1. Select **HTTP** or **Server sent Events**.
1. Add the Customer Service MCP server URL.

```json
{
  "servers": {
    "d365-customer-service": {
      "type": "http",
      "url": "https://<ring-host>/mcp/environments/<environment-id>/servers/mcp_D365CX_Service"
    }
  },
  "inputs": []
}
```

### GitHub Copilot CLI

Add the server to `.mcp.json`.

```json
{
  "mcpServers": {
    "d365-customer-service": {
      "type": "http",
      "url": "https://<ring-host>/mcp/environments/<environment-id>/servers/mcp_D365CX_Service"
    }
  }
}
```

### Cursor

1. Open Cursor.
1. Open **Settings**.
1. Go to **Features** > **MCP Servers**.
1. Select **Add MCP Server**.
1. Add the server configuration.

```json
{
  "mcpServers": {
    "d365-customer-service": {
      "url": "https://<ring-host>/mcp/environments/<environment-id>/servers/mcp_D365CX_Service"
    }
  }
}
```

Replace `<environment-id>` with the Dataverse environment ID for the target environment.

### ChatGPT

1. Open **Settings** > **Connectors** > **MCP Servers**.
1. Add the Customer Service MCP server URL.

```http
https://<ring-host>/mcp/environments/<environment-id>/servers/mcp_D365CX_Service
```

1. Select **Connect**.
1. Sign in when the Microsoft authentication flow opens.
1. Verify that the available MCP tools are registered.

### Claude Code

When Claude Code makes its first MCP request, it discovers the Agent 365 Tooling Gateway OAuth metadata, opens Microsoft sign-in, and stores tokens locally after the user authenticates.

Configure the MCP server in Claude Code.

```json
{
  "mcpServers": {
    "d365-customer-service": {
      "transport": {
        "type": "http",
        "url": "https://<ring-host>/mcp/environments/<environment-id>/servers/mcp_D365CX_Service"
      }
    }
  }
}
```



