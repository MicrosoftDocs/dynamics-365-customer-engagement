---
title: Connect AI agents and assistants to Dynamics 365 Sales MCP Server
description: Learn how to connect your AI agents and assistants to the Dynamics 365 Sales MCP Server to enable them to perform actions and retrieve information from Dynamics 365 Sales.
ms.date: 05/26/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: bap-template
ai-usage: ai-assisted
---

# Connect your AI agents and assistants to Dynamics 365 Sales MCP Server

You can integrate the Dynamics 365 Sales Model Context Protocol (MCP) server with your Microsoft Copilot Studio agent, or any other AI agent or assistant that supports the MCP standard. Claude Desktop isn't supported at this time.

## Prerequisites

Make sure you meet the following prerequisites:

- You have admin permissions in Dynamics 365 Sales.  

- You have admin access to Copilot Studio. Learn more in [Copilot Studio licensing](/microsoft-copilot-studio/billing-licensing).
- Allow access to Dataverse MCP Server from MCP clients. This is required only if you're planning to use an MCP client other than Copilot Studio. Learn more in [Configure the Dataverse MCP server for an environment](/power-apps/maker/data-platform/data-platform-mcp-disable).
- If you've previously connected to the Dynamics 365 Sales MCP server, delete the connection as it's now deprecated and will be removed soon.
- You have enough Copilot Studio credits to use the tools in the Sales MCP server. Learn more about consumption rates for each tool in [Copilot Credit consumption rates](connect-to-model-context-protocol-sales.md#copilot-credit-consumption-rates).

## Connect Sales MCP Server to Copilot Studio agent

To connect to the Sales MCP server in Microsoft Copilot Studio, follow the steps in [Add tools and resources from a Model Context Protocol (MCP) server to your agent](/microsoft-copilot-studio/mcp-add-components-to-agent). 

> [!NOTE]
> Select **Dynamics 365 Sales MCP server** when prompted to select the MCP server. If you want to perform CRUD operations on Dataverse records, connect to the **Dataverse MCP server** as well.

## Use Sales MCP tools in Visual Studio Code with GitHub Copilot

1. Download and open Visual Studio Code.

1. Press Ctrl + Shift + P (Windows/Linux) or Cmd + Shift + P (Mac).
1. Type `MCP: Add Server`, and select the server type as `HTTP (HTTP or Server-Sent Events)`.
1. Add the MCP server URL for Dynamics 365 Sales and Dataverse by using the following information:
    - For Dataverse, use `https://<OrgURL>/api/mcp`.

    - For Dynamics 365 Sales, use the following URL and replace the environment ID.
      `https://agent365.svc.cloud.microsoft/mcp/environments/<EnvironmentID>/servers/msdyn_SalesMCPServer`

   The following is a sample configuration:
    
    ```json
    {
            "servers": {
                "Dataverse-mcp-server": {
                    "url": "https://northwind.crm10.dynamics.com/api/mcp",
                    "type": "http"
                },
                "Sales-mcp-server": {
                    "url": "https://agent365.svc.cloud.microsoft/mcp/environments/00aa00aa-bb11-cc22-dd33-44ee44ee44ee/servers/msdyn_SalesMCPServer",
                    "type": "http" 
                }
                
            },
            "inputs": []
    }
    ```
1. Resolve syntax errors, if any, in the `mcp.json` file and save it.
   You should see the **Start** button enabled for each of the MCP servers you added in the configuration file.  
1. Select **Start** on all the servers.
1. Press Ctrl + Alt + I to open the GitHub Copilot chat pane and choose any agent (For example, Claude Sonnet 4).


## Related information

- [MCP tools for Sales Qualification Agent capabilities](sales-qualification-agent-tools.md)
- [MCP tools for Sales Opportunity Agent capabilities](sales-close-agent-research-tools.md)
- [MCP tools for Copilot in Dynamics 365 Sales](copilot-in-sales-tools.md)
- [Examples of using Sales MCP Server with AI agents and assistants](model-context-protocol-examples.md)
