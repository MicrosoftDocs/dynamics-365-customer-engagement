---
title: Connect to Customer Service with Model Context Protocol (preview)
description: Learn how to configure AI agents with Model Context Protocol and use in Customer Service to resolve customer issues.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.date: 07/24/2025
ms.update-cycle: 180-days
ms.custom:
  - bap-template 
---

# Connect to Customer Service with Model Context Protocol (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Whether you're a developer building an AI agent to automate a part of the service workflow, or a customer service representative using an AI assistant such as Claude to resolve customer issues efficiently, you can connect Dynamics 365 Customer Service with the Model Context Protocol (MCP) server.

You can use Microsoft Copilot Studio to build custom agents for service teams that include the Customer Service MCP server or connect Dynamics 365 with any other agent platform that supports the MCP protocol. By using the Customer Service MCP server in combination with MCP servers from other business applications such as Sales and ERP systems, you can also automate complex cross-functional business operations with ease. For example, an order can be generated through the Dynamics 365 Business Central MCP server, after an MCP client is engaged with the Customer Service MCP server.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

- Access to Copilot Studio.
- System administrator or Omnichannel Administrator role.
- D365 Service MCP server is configured and appears in Copilot Studio tools list. Learn more in [Microsoft MCP connectors available in Copilot Studio](/microsoft-copilot-studio/agent-extend-action-mcp#microsoft-mcp-connectors-available-in-copilot-studio).
- The MCP server in Claude is set up for Customer Service. Learn more in [Configure and use the Dataverse MCP server in Claude](/power-apps/maker/data-platform/data-platform-mcp#configure-and-use-the-dataverse-mcp-server-in-claude).
    - Make sure that you update the JSON for the MCP server in Claude to provide the connection details of the MCP server for Dynamics 365 Customer Service.
    - A sample JSON format is as follows.
      Use a &lt;friendly name&gt; for your Customer Service MCP server that you can easily remember, for example: *MyServiceMCPServer*. 

        ```json
        {
             "mcpServers": {
            "<friendly name>": {
              "command": "Microsoft.PowerPlatform.Dataverse.MCP",
              "args": [
                "--ConnectionUrl",
                "<URL for Customer Service connection>",
                "--MCPServerName",
                "ServiceMCPServer",
                "--TenantId",
                "<Tenant Id GUID>",
                "--EnableHttpLogging",
                "true",
                "--EnableMsalLogging",
                "false",
                "--Debug",
                "false",
                "--BackendProtocol",
                "HTTP"
                 ]
               }
             }
           }
        ```

## Configure an AI agent based on MCP server

1. In Copilot Studio, select **AI agents**, and create a new agent or select an existing agent.
1. Perform the steps in [Add tools from an existing MCP connector to an agent](/microsoft-copilot-studio/agent-extend-action-mcp#add-tools-from-an-existing-mcp-connector-to-an-agent).
1. Search and select **D365 Service MCP Server**.
1. If the connection isn't configured, make sure that you configure the connection and verify it.
1. Select **Add to agent**. The MCP server is added to the agent.
1. Select **Publish** on the top right corner.

   :::image type="content" source="../media/screenshot-of-ai-agent-with-mcp-server.png" alt-text="Screenshot of an AI agent configured with MCP server in Copilot Studio.":::

1. If you have used a new AI agent, on the **Channels** tab, select **Dynamics 365 Customer Service** and perform the steps to connect the agent to Customer Service.

## Use the AI agent

After you configure the AI agent, your service representatives can use it to resolve customer issues. The following tools are available.

|Tool name|	Description|
|---|---|
|D365_CustomerService_ListCases	Get case (incident)| information from Dataverse Incident entity.|
|D365_CustomerService_UpdateCase |	Updates case (incident) record in Dataverse Incident entity.|
|D365_CustomerService_AddCaseNote |	Adds a note to a case (incident) record. This tool creates a new entry in the Dataverse annotations entity, linking it to the specified case (incident) via an entity reference.|
|D365_CustomerService_AddCase	|Adds a case (incident) record in Dataverse incidents entity.|
|D365_CustomerService_CloseCase	|Closes (resolve) a case (incident) with resolution in Dataverse Incident entity.|
|D365_CustomerService_ListAccounts|	Gets a list of the account and its primary contact information from Dataverse accounts entity. <br> **Note**: In Dataverse, one account can have multiple contacts, and when asked for the account information, you can retrieve additional information from other Dataverse entities for the account with the $expand parameter.|
|D365_CustomerService_UpdateAccount	|Updates an account in the organization from Dataverse accounts entity.|
|D365_CustomerService_AddAccount|	Adds an account record in the organization from Dataverse accounts entity.|
|D365_CustomerService_DraftEmailResponse|	Dynamics 365 Customer Service Copilot draft email tool. The tool is used to provide LLM-based email drafting based on information and instruction.|
|D365_CustomerService_SendEmailResponse	|Creates email record in Dataverse emails entity and send the email to customer based on the case (incident) information from Dataverse incident entity and contact information from Dataverse contacts entity.|

### Related information

[Blog: The autonomous enterprise: How generative AI is reshaping business applications](https://www.microsoft.com/dynamics-365/blog/business-leader/2025/05/20/the-autonomous-enterprise-how-generative-ai-is-reshaping-business-applications/)  
[Extend your agent with Model Context Protocol](/microsoft-copilot-studio/agent-extend-action-mcp)  
[Core MCP concepts](https://modelcontextprotocol.io/quickstart/server#core-mcp-concepts)  