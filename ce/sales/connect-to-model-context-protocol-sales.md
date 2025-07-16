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

Ensure that the Dataverse Model Context Protocol (MCP) server is set up and running. Learn more in [Connect to Dataverse with Model Context Protocol (preview)](/power-apps/maker/data-platform/data-platform-mcp).

## Integrate Sales MCP Server with AI agents and assistants

You can integrate the Sales MCP server with your Microsoft Copilot Studio agent, or any other AI agent or assistant that supports the MCP standard. The steps for connecting to the Sales MCP server are similar to that of the Dataverse MCP server. 

- To connect to the Sales MCP server in Microsoft Copilot Studio, follow the steps in [Use the Dataverse MCP server in Microsoft Copilot Studio](/power-apps/maker/data-platform/data-platform-mcp#use-the-dataverse-mcp-server-in-microsoft-copilot-studio) and select **Dynamics 365 Sales MCP server** when prompted to select the server under **Microsoft Dataverse Connector**. 

- To connect to the MCP server in Claude, follow the steps in [Configure and use the Dataverse MCP server in Claude](/power-apps/maker/data-platform/data-platform-mcp#configure-and-use-the-dataverse-mcp-server-in-claude). 

- To connect to the MCP server in Visual Studio Code, follow the steps in [Configure and use your MCP client with VS Code](/power-apps/maker/data-platform/data-platform-mcp#configure-and-use-your-mcp-client-with-vs-code).

  The following screenshot shows the Dataverse and Sales MCP servers and the tools available in each of them in Visual Studio Code:

  :::image type="content" source="media/sales-model-context-protocol-in-vscode.png" alt-text="Screenshot of the MCP servers and tools available in the Sales MCP server in Visual Studio Code.":::


## Tools supported

The following table lists the tools supported by the Sales Model Context Protocol (MCP) server. These tools allow you to list leads, qualify leads, and draft and send outreach emails to leads.


| Tool Name              | Purpose                                                                                                   |
|------------------------|-----------------------------------------------------------------------------------------------------------|
| `D365_Sales_ListLeads`            | Retrieves a list of leads for the organization or fetches a lead by attribute name.                       |
| `D365_Sales_QualifyLeadToOpportunity` | Qualifies a lead and can create account, contact, or opportunity records.                                 |
| `D365_Sales_InvokeLeadSummary`    | Provides a summary of a lead based on lead ID. The tool fetches the lead summary from Copilot in Dynamics 365 Sales. Ensure that Copilot in Dynamics 365 Sales is enabled to use this tool. |
| `D365_Sales_DraftOutreachEmail`   | Drafts an outreach email for a lead based on lead ID. The tool fetches the outreach email from Copilot in Dynamics 365 Sales. Ensure that Copilot in Dynamics 365 Sales is enabled to use this tool. |
| `D365_Sales_SendOutreachEmail`    | Sends an outreach email to a customer using a draft for the specified lead.                                |

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