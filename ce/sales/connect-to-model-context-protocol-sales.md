---
title: Connect to Dynamics 365 Sales with Model Context Protocol (preview)
description: Learn how to connect to Dynamics 365 Sales with Model Context Protocol (MCP) and integrate it with AI agents or models.
ms.date: 06/19/2025
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/03/2023
ai-usage: ai-assisted
---

# Connect to Dynamics 365 Sales with Model Context Protocol (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner-section.md)]

Model Context Protocol (MCP) is a powerful new standard that enables seamless integration between your favorite AI assistants, such as ChatGPT and Claude, and Dynamics 365 Sales. MCP can also be used to integrate with AI agents such as Microsoft Copilot Studio agents. With the Sales MCP server, you can extend your AI agents and AI assistants with sales-specific tools and create custom experiences for your sellers. The MCP server includes a set of APIs that enable the interaction with Dynamics 365 Sales data and functionality.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

Ensure that the following prerequisites are met:

- You have admin permissions in Dynamics 365 Sales.  
- You have a Copilot Studio license. Learn more in [Copilot Studio licensing](/microsoft-copilot-studio/billing-licensing).  
- Your Dataverse Model Context Protocol (MCP) server is set up and running. Learn more in [Connect to Dataverse with Model Context Protocol (preview)](/power-apps/maker/data-platform/data-platform-mcp).

## Integrate Sales MCP Server with AI agents and assistants

You can integrate the Sales MCP server with your Microsoft Copilot Studio agent, or any other AI agent or assistant that supports the MCP standard, except for Claude Desktop.

The steps for connecting to the Sales MCP server are similar to that of the Dataverse MCP server. 

- To connect to the Sales MCP server in Microsoft Copilot Studio, follow the steps in [Use the Dataverse MCP server in Microsoft Copilot Studio](/power-apps/maker/data-platform/data-platform-mcp#use-the-dataverse-mcp-server-in-microsoft-copilot-studio).

- To connect to the Sales MCP server in Visual Studio Code, follow the steps in [Configure and use your MCP client with VS Code](/power-apps/maker/data-platform/data-platform-mcp#configure-and-use-your-mcp-client-with-vs-code). Claude Desktop is supported with the Visual Studio Code MCP client.

> [!NOTE]
>- Ensure to select **Dynamics 365 Sales MCP server (preview)** when prompted to select the MCP server. If you want to perform CRUD operations on Dataverse records, connect to the **Dataverse MCP server** as well.
>- If your existing Sales MCP server is marked as deprecated, delete it and add the new Sales MCP server connection.
 
The following screenshot shows the Dataverse and Sales MCP servers and the tools available in each of them in Visual Studio Code:

:::image type="content" source="media/sales-model-context-protocol-in-vscode.png" alt-text="Screenshot of the MCP servers and tools available in the Sales MCP server in Visual Studio Code.":::


## Tools supported

The following table lists the tools supported by the Sales Model Context Protocol (MCP) server. 

### Lead management tools

The Sales MCP server includes basic sales tools that allow you to interact with leads in Dynamics 365 Sales.
These tools allow you to list leads, qualify leads, and draft and send outreach emails to leads.


| Tool Name              | Purpose                                                                                                   |
|------------------------|-----------------------------------------------------------------------------------------------------------|
| `D365_Sales_ListLeads`            | Retrieves a list of leads for the organization or fetches a lead by attribute name.                       |
| `D365_Sales_QualifyLeadToOpportunity` | Qualifies a lead and can create account, contact, or opportunity records.                                 |
| `D365_Sales_InvokeLeadSummary`    | Provides a summary of a lead based on lead ID. The tool fetches the lead summary from Copilot in Dynamics 365 Sales. Ensure that Copilot in Dynamics 365 Sales is enabled to use this tool. |
| `D365_Sales_DraftOutreachEmail`   | Drafts an outreach email for a lead based on lead ID. The tool fetches the outreach email from Copilot in Dynamics 365 Sales. Ensure that Copilot in Dynamics 365 Sales is enabled to use this tool. |
| `D365_Sales_SendOutreachEmail`    | Sends an outreach email to a customer using a draft for the specified lead.                                |

### Sales Qualification Agent tools

The following table lists the tools supported by the Sales Qualification Agent in Dynamics 365 Sales. Make sure that the agent is configured and turned on. Learn more in [Set up and configure the Sales Qualification Agent](configure-sales-qualification-agent.md).


### Sales Qualification Agent tools

The following table lists the tools supported by the Sales Qualification Agent in Dynamics 365 Sales.

| Tool Name (Friendly)         | API Name                                         | Purpose                                                      | Parameter(s)                | Returns                                                                                 |
|------------------------------|--------------------------------------------------|--------------------------------------------------------------|-----------------------------|-----------------------------------------------------------------------------------------|
| Account Research Tool        | `mcp_sales-mcp-ser_get_account_research`         | Retrieve comprehensive account research data                 | `msdyn_LeadId` (string)     | Financial information, company overview, strategic goals, recent news                   |
| Competitor Research Tool     | `mcp_sales-mcp-ser_get_competitor_research`      | Retrieve competitor research and competitive landscape       | `msdyn_LeadId` (string)     | Competitive threats, market positioning, alternative suppliers                          |
| Engagement Analysis Tool     | `mcp_sales-mcp-ser_get_engage_summary`           | Retrieve engagement summary and interaction history for a lead | `msdyn_LeadId` (string)     | Engagement patterns, touchpoint analysis, interaction effectiveness                     |
| Lead Qualification Tool      | `mcp_sales-mcp-ser_get_lead_qualification_assessment` | Get comprehensive lead qualification assessment against ICP criteria | `LeadId` (string)           | ICP standards evaluation, qualification ranking, overall assessment                     |
| Lead Research Tool           | `mcp_sales-mcp-ser_get_lead_research`            | Retrieve detailed lead research and individual prospect analysis | `msdyn_LeadId` (string)     | Professional background, decision-making authority, preferences                         |
| Outreach Email Generation Tool | `mcp_sales-mcp-ser_draft_outreach_email`        | Draft personalized sales qualification agent outreach emails | `LeadId` (string)           | Personalized email subject and body with company-specific insights                      |



### Dataverse MCP server tools

In addition to the Sales MCP server tools, you can also use the Dataverse MCP server tools to perform CRUD operations on Dataverse records in Dynamics 365 Sales. 

| Tool Name (Friendly)         | API Name                 | Purpose                                                                                                   | Parameter(s)                           | Returns                                                                                 |
|------------------------------|--------------------------|-----------------------------------------------------------------------------------------------------------|----------------------------------------|-----------------------------------------------------------------------------------------|
| List Tables Tool            | `list_tables`            | Gets a list of all tables in the Dataverse and returns an array of table names. This doesn't retrieve the tables from external sources. | None                                   | Array of table names in the Dataverse environment                                      |
| Describe Table Tool          | `describe_table`         | Gets the TSQL schema definition of a table in the Dataverse database                                     | `table_name` (string)                  | TSQL schema definition including column names, data types, and constraints              |
| Read Query Tool              | `read_query`             | Executes SQL SELECT statements against Dataverse, enabling complex query scenarios like filtering, joins, aggregations and more. Works best with grounded knowledge from describe and list table tools and with insights on the data gained from search tools . | `sql_query` (string)                   | Query results as structured data based on the SELECT statement                         |
| Create Table Tool            | `create_table`           | Creates a new table in Dataverse with the specified columns                                              | `table_name` (string), `columns` (array) | Confirmation of table creation with table details                                       |
| Update Table Tool            | `update_table`           | Updates an existing table in Dataverse by adding new columns                                             | `table_name` (string), `new_columns` (array) | Confirmation of table update with new column details                                    |
| Delete Table Tool            | `delete_table`           | Deletes a table in the Dataverse database (proceeds solely on explicit user consent)                    | `table_name` (string)                  | Confirmation of table deletion                                                          |
| Create Record Tool           | `create_record`          | Inserts a row into a table in the Dataverse database and returns the GUID ID of the created record      | `table_name` (string), `record_data` (object) | GUID ID of the newly created record                                                     |
| Update Record Tool           | `update_record`          | Updates a row in a table in the Dataverse database                                                       | `table_name` (string), `record_id` (GUID), `update_data` (object) | Confirmation of record update with updated field values                                 |
| Delete Record Tool           | `delete_record`          | Deletes a row from a table in the Dataverse database (proceeds solely on explicit user consent)         | `table_name` (string), `record_id` (GUID) | Confirmation of record deletion                                                         |



## What can you do with the Sales MCP server?

Let's explore some example scenarios to understand how you can use the Sales MCP server to enhance your sales processes with AI agents or assistants.

### Scenario 1: Sales team uploads leads (event attendees) from Excel into Dynamics 365 Sales

| Action performed                                                                                   | Tools used                                 | MCP Server used         |
|----------------------------------------------------------------------------------------|---------------------------------------------|-------------------------|
| For each event attendee, the agent gets the lead record and gets Copilot lead summary to determine if they’re a good fit | `D365_Sales_ListLeads` <br>`D365_Sales_InvokeLeadSummary`  | Sales MCP server        |
| For each lead that is a good fit, drafts an outreach email                             | `D365_Sales_DraftOutreachEmail`                    | Sales MCP server        |
| When a lead responds, converts lead to a new opportunity                               | `D365_Sales_QualifyLeadToOpportunity`              | Sales MCP server        |
| If the lead confirms interest, creates a quote in Dynamics 365 Sales        | `create_record`                 | Dataverse MCP server |
| Upon customer/seller approval, creates order in Dynamics 365 Sales          | `create_record`                 | Dataverse MCP server |

### Scenario 2: A lead comes from a marketing campaign to the website

The lead starts a chat: "I'm looking for metal packaging for cold pressed olive oil. Can you tell me what options you have?"

| Action performed                                                                                                                                                                                           | Tools used                                         | MCP Server used                |
|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------|-------------------------------|
| Agent checks if they're an existing lead, fetches the lead record, and gets Copilot lead summary from Dynamics 365 Sales. Through the summary, the agent learns that the lead is a decision maker, has previously done business, and prefers sustainable packaging. | `D365_Sales_ListLeads`, `D365_Sales_InvokeLeadSummary`                   | Sales MCP server               |
| Agent searches online to understand the type of packaging attributes olive oil requires and finds that opaque and slim bottles work best.                                                            | None required; agent uses Bing search from Copilot Studio | Not applicable                 |
| Based on this, the agent pulls the right products from Dynamics 365 and proposes them to the customer.                                                                   | `retrieve_knowledge`                                      | Dataverse MCP server and custom connector      |
| Optional: If the lead confirms interest, creates a quote in Dynamics 365 Sales.                                                                                          | `create_record`                                      | Dataverse MCP server |

## Related information

- [Video: Using Claude Desktop to engage directly with Dynamics 365 Sales](https://www.youtube.com/watch?v=H_CbRy3Pb88)
- [Blog: The autonomous enterprise: How generative AI is reshaping business applications](https://www.microsoft.com/en-us/dynamics-365/blog/business-leader/2025/05/20/the-autonomous-enterprise-how-generative-ai-is-reshaping-business-applications/)