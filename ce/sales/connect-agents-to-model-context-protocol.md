---
title: Connect AI agents and assistants to Dynamics 365 Sales MCP Server
description: Learn how to connect your AI agents and assistants to the Dynamics 365 Sales MCP Server to enable them to perform actions and retrieve information from Dynamics 365 Sales.
ms.date: 02/27/2026
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

- You have access to Copilot Studio. Learn more in [Copilot Studio licensing](/microsoft-copilot-studio/billing-licensing).
- Allow access to Dataverse MCP Server from MCP clients. This is required only if you're planning to use an MCP client other than Copilot Studio. Learn more in [Configure the Dataverse MCP server for an environment](/power-apps/maker/data-platform/data-platform-mcp-disable).
- If you've previously connected to the Dynamics 365 Sales MCP server, delete the connection as it's now deprecated and will be removed soon.
- You have enough Copilot Studio credits to use the tools in the Sales MCP server. Learn more about consumption rates for each tool in [Copilot Credit consumption rates](connect-to-model-context-protocol-sales.md#copilot-credit-consumption-rates).

## Connect Sales MCP Server to Copilot Studio agent

To connect to the Sales MCP server in Microsoft Copilot Studio, follow the steps in [Add tools and resources from a Model Context Protocol (MCP) server to your agent](/microsoft-copilot-studio/mcp-add-components-to-agent). 

> [!NOTE]
> Select **Dynamics 365 Sales MCP server** when prompted to select the MCP server. If you want to perform CRUD operations on Dataverse records, connect to the **Dataverse MCP server** as well.

## Connect Sales MCP Server to GitHub Copilot in Visual Studio Code

To connect to the Sales MCP server with GitHub Copilot in Visual Studio Code, follow these steps:

1. Download and open Visual Studio Code.

1. Press Ctrl + Shift + P, type **MCP**, and select **MCP:Open User Configuration** to open the `mcp.json` config file.
1. Add the server URL for Dynamics 365 Sales and Dynamics 365 Dataverse MCP Servers by using the following information:
    - For Dataverse, use the orgID in the URL. For example: Northwind.crm10.dynamics.com

    - For Dynamics 365 Sales, use the environmentID. For example: 00aa00aa-bb11-cc22-dd33-44ee44ee44ee
    - Optional: If you want to send emails as well, add the Mail MCP Server, with the same Dynamics 365 environment ID.
   The following is a sample configuration:
    
    ```json
    {
            "servers": {
                "Dataverse-mcp-server": {
                    "url": "Northwind.crm10.dynamics.com/api/mcp",
                    "type": "http"
                },
                "Sales-mcp-server": {
                    "url": "https://Northwind.crm10.dynamics.com/mcp/environments/00aa00aa-bb11-cc22-dd33-44ee44ee44ee/servers/msdyn_SalesMCPServer",
                    "type": "http" 
                },
                "Mail-server": {
                    "url": "https://Northwind.crm10.dynamics.com/mcp/environments/00aa00aa-bb11-cc22-dd33-44ee44ee44ee/servers/mcp_MailTools",
                    "type": "http"
                }
                
            },
            "inputs": []
    }
    ```
1. Resolve syntax errors, if any, in the `mcp.json` file and save it.
   You should see the **Start** button enabled for each of the MCP servers you added in the configuration file.  
   :::image type="content" source="media/vs-code-start-mcp-servers.png" alt-text="Screenshot of Visual Studio Code mcp.json configuration file showing the MCP servers added for Dataverse, Sales, and Mail with the Start button enabled.":::
1. Select **Start** on all the servers.
1. Press Ctrl + Alt + I to open the GitHub Copilot chat pane and choose any agent (For example, Claude Sonnet 4).

