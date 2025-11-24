---
title: Connect to Dynamics 365 Customer Service MCP Server with Model Context Protocol (preview)
description: Learn how to configure Dynamics 365 Customer Service MCP Server in Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.date: 11/24/2025
ms.update-cycle: 180-days
ms.custom:
  - bap-template 
---

# Connect to Dynamics 365 Customer Service MCP Server with Model Context Protocol (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Whether you're a developer building an AI agent to automate a part of the service workflow, or a customer service representative (service representative or representative) using an AI assistant such as Copilot to resolve customer issues efficiently, you can connect Dynamics 365 Customer Service with the Model Context Protocol (MCP) server.

Use [Microsoft Copilot Studio](https://www.microsoft.com/microsoft-365-copilot/microsoft-copilot-studio) to build custom agents for service teams that include the Dynamics 365 Customer Service MCP Server or connect Dynamics 365 Customer Service with any other agent platform that supports the MCP protocol. By using the Dynamics 365 Customer Service MCP Server in combination with Dataverse MCP servers or MCP servers from other business applications such as Sales and ERP systems, you can automate complex cross-functional business operations with ease. For example, an order can be generated through the Dynamics 365 Business Central MCP server, after an MCP client is engaged with the Customer Service MCP server.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

- Access to Microsoft Copilot Studio.

- System administrator or Omnichannel Administrator role to configure the MCP Server.
- CSR or CSR Manager roles to use the MCP Server and tools.
- Dynamics 365 Customer Service MCP Server is configured and appears in Copilot Studio tools list. Learn more in [Microsoft MCP connectors available in Copilot Studio](/microsoft-copilot-studio/agent-extend-action-mcp#microsoft-mcp-connectors-available-in-copilot-studio).

> [!NOTE]
> - The existing D365 Service MCP Server is deprecated and you must remove it. Learn more in [Deprecations in Customer Service](../implement/deprecations-customer-service.md).
> - Claude Desktop isn't supported with Dynamics 365 Customer Service MCP Server.
> - We recommend that you don't use deprecated connections and consider deleting them.

## Configure an AI agent based on MCP server

1. In Copilot Studio, select **AI agents**, and create a new agent or select an existing agent.
1. Perform the steps in [Add tools from an existing MCP connector to an agent](/microsoft-copilot-studio/agent-extend-action-mcp#add-tools-from-an-existing-mcp-connector-to-an-agent).
1. Search and select **Dynamics 365 Customer Service MCP Server (Preview)**.
1. If the connection isn't configured, make sure that you configure the connection and verify it.
1. Select **Add to agent**. The MCP server is added to the agent.
1. Select **Publish** on the top right corner.

   :::image type="content" source="../media/screenshot-of-ai-agent-with-mcp-server.png" alt-text="Screenshot of an AI agent configured with MCP server in Copilot Studio.":::

1. If you used a new AI agent, on the **Channels** tab, select **Dynamics 365 Customer Service** and perform the steps to connect the agent to Customer Service.

Repeat the steps to add **Dataverse MCP server (Preview)** to enable CRUD operations.

## Enable access to Dataverse MCP Server from non-Microsoft apps

You can also access your MCP tools from external sources such as Visual Studio Code.

1. In Power Platform admin center, go to the environment settings, expand **Product**, and select **Features**.
1. On the **Features** page, for **Dataverse Model Context Protocol**, select the **Allow MCP clients to interact with Dataverse MCP Server** checkbox.
1. Select **Advanced Settings**, and on the tab that opens, select **Microsoft GitHub Copilot** in **Active Allowed MCP Clients**, and select **Activate**.

### Use MCP tools in Visual Studio Code

1. In Visual Studio Code, select the command palette or use CTRL+Shift+P, type **MCP: Add Server**, and press enter.
1. Select **Http or Server sent Events** server and press enter.
1. Add the following URLs
    - Dataverse: Use the orgID in the URL. For example: https://`<OrgURL>`/api/mcp
    - Customer Service: Use the environment ID.
    The system generates the following code.
    {
    "servers": {
        "Dataverse-mcp-server": {
            "url": "`<OrgURL>`/api/mcp",
            "type": "http"
        },
        "Service-mcp-server": {
            "url": “https://agent365.svc.cloud.microsoft/mcp/environments/`<EnvironmentID>`/servers/msdyn_ServiceMCPServer ",
            "type": "http"
                }
    },
    "inputs": []
    }

## Use the AI agent

After you configure the AI agent with the Dataverse MCP server and Dynamics 365 Customer Service MCP Server, you can navigate to the **Channels** tab and publish your AI Agent to Teams or M365 Copilot. Your service representatives can use it to resolve customer issues. The following tools are available.

The following tools are available in the Dynamics 365 Customer Service MCP Server(preview).

|Tool name|	Description|
|---|---|
| enrich_case  | This tool enriches an existing case (incident) or similar Dataverse entity with an optional activity entity (like email) as enrichment context by predicting case field values using AI. It uses an AI-powered field prediction model to infer the best values for the case record based on a source activity and updates the case with these predicted values. |
| get_next_suggestion_on_case      | Finds the next suggested steps for a case (incident) or similar Dataverse entities, optionally using an activity (like email) as context for finding suggested next steps. |
| send_email  | Sends an existing drafted email identified by its unique GUID. The draft email must already exist in the email table in Dataverse.  |
| draft_email_with_suggested_response | Drafts email responses based on the context of the case and the suggested response from the get_next_suggestion_on_case tool. The draft email is for sharing a solution or requesting more information with interview questions. |
| resolve_incident | Closes (resolves) a case (incident) with resolution in Dataverse Incident entity. A resolution note is required to resolve a case.|

The following tools are available in the Dataverse MCP Server (preview).

| Tool name                | Description                                                                                                                                                                                                                                                                                                                                                                   |
|--------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| list_tables              | This tool gets a list of all tables in the Dataverse and returns an array of table names. This doesn't retrieve the tables from external sources.                                                                                                                                                                                                                              |
| describe_table           | Get the TSQL schema definition of a table in the Dataverse database.                                                                                                                                                                                                                                                                                                          |
| read_query               | Executes SQL SELECT statements against Dataverse, enabling complex query scenarios like filtering, joins, aggregations, and more. Works best with grounded knowledge from the describe and list table tools, as well as insights gained from search tools.                                                                              |
| create_table             | Create a new table in Dataverse with the specified columns.                                                                                                                                                                                                                                                                                                                   |
| update_table             | Update an existing table in Dataverse by adding new columns.                                                                                                                                                                                                                                                                                                                  |
| delete_table             | Proceed solely on explicit user consent, then DELETE a table in the Dataverse database.                                                                                                                                                                                                                                                |
| create_record            | INSERT a row into a table in the Dataverse database and returns the GUID ID of the created record.                                                                                                                                                                                                                                     |
| update_record            | UPDATE a row in a table in the Dataverse database.                                                                                                                                                                                                                                                                                                                            |
| delete_record            | Proceed solely on explicit user consent, then DELETE a row from a table in the Dataverse database.                                                                                                                                                                                                                                      |
| list_knowledge_sources   | Returns a list of all the knowledge sources available in the Dataverse environment. Each knowledge source is a combination of Dataverse tables (entities) or external data sources. Use retrieve_knowledge to retrieve data if the table exists in one of these configurations; otherwise, use read_query to get search results.         |
| retrieve_knowledge       | Retrieve knowledge from Dataverse tables and external data sources. If the table has a configuration, use this configuration with the retrieve_knowledge tool to retrieve the data; otherwise, use read_query to get search results.                                                                                                    |

### Examples

Representatives can use the following prompts with the MCP tool:

- List my open cases

- Help me resolve this case
- Fetch me the intent of this case from the intent library
- What is the intent category of the case?
- Draft an email to this customer with a resolution
- Send this email to the customer
- Resolve this case and add the following resolution notes

### Related information

[Extend your agent with Model Context Protocol](/microsoft-copilot-studio/agent-extend-action-mcp)  
[Core MCP concepts](https://modelcontextprotocol.io/quickstart/server#core-mcp-concepts)  