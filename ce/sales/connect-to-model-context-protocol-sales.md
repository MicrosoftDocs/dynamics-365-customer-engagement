---
title: Connect to Dynamics 365 Sales with Model Context Protocol (preview)
description: Learn how to connect to Dynamics 365 Sales with Model Context Protocol (MCP) and integrate it with AI agents or models.
ms.date: 06/13/2025
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

Model Context Protocol (MCP) is a powerful new standard that enables seamless integration between your favorite AI assistants, such as ChatGPT and Claude, and Dynamics 365 Sales. It can also be used to integrate with AI agents such as Microsoft Copilot Studio agents. With the Sales MCP server, you can extend your AI agents and AI assistants with sales-specific tools and create custom experiences for your sellers. The MCP server includes a set of APIs that enable the interaction with Dynamics 365 Sales data and functionality.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Integrate Sales MCP Server with AI agents and assistants

You can integrate the Sales MCP server with your Microsoft Copilot Studio agent, or any other AI agent or assistant that supports the MCP standard. The steps for connecting to the Sales MCP server are similar to connecting to the Dataverse MCP server.

- To connect to the MCP server in Microsoft Copilot Studio, follow the steps in [Use the Dataverse MCP server in Microsoft Copilot Studio](/power-apps/maker/data-platform/data-platform-mcp#use-the-dataverse-mcp-server-in-microsoft-copilot-studio).

- To connect to the MCP server in Claude, follow the steps in [Configure and use the Dataverse MCP server in Claude](/power-apps/maker/data-platform/data-platform-mcp#configure-and-use-the-dataverse-mcp-server-in-claude). 


## Tools supported by the Sales MCP Server

The following table lists the tools supported by the Model Context Protocol (MCP) server in Dynamics 365 Sales. These tools allow you to list leads, qualify leads, and draft and send outreach emails to leads.


| Tool Name              | Purpose                                                                                                   |
|------------------------|-----------------------------------------------------------------------------------------------------------|
| `ListLeads`            | Retrieves a list of leads for the organization or fetches a lead by attribute name.                       |
| `QualifyLeadToOpportunity` | Qualifies a lead and can create account, contact, or opportunity records.                                 |
| `InvokeLeadSummary`    | Provides a summary of a lead based on lead ID. The tool fetches the lead summary from Copilot in Dynamics 365 Sales. Ensure that Copilot in Dynamics 365 Sales is enabled to use this tool. |
| `DraftOutreachEmail`   | Drafts an outreach email for a lead based on lead ID. The tool fetches the outreach email from Copilot in Dynamics 365 Sales. Ensure that Copilot in Dynamics 365 Sales is enabled to use this tool. |
| `SendOutreachEmail`    | Sends an outreach email to a customer using a draft for the specified lead.                                |

## What can you do with the Sales MCP server?

The Sales MCP server provides a set of tools that can be used to interact with Dynamics 365 Sales data and functionality. Let's explore some scenarios where you can use the Sales MCP server for a seamless integration with AI agents or assistants.

**Scenario 1: Sales team uploads leads (event attendees) from Excel into Dynamics 365 Sales**

| Action performed                                                                                   | Tools used                                 |
|----------------------------------------------------------------------------------------|---------------------------------------------|
| For each event attendee, the agent gets the lead record and gets Copilot lead summary to determine if they’re a good fit | Get Lead #Sales<br>Get Lead Summary #Sales  |
| For each lead that is a good fit, drafts an outreach email                             | Get Outreach Email #Sales                   |
| When a lead responds, converts lead to a new opportunity                               | Qualify #Sales                              |
| If the lead confirms interest, creates a quote in D365 Sales or D365 Business Central  | Create quote #Sales #BusinessCentral        |
| Upon customer/seller approval, creates order in Dynamics 365 Business Central or an ERP system | Create order #BusinessCentral               |

**Scenario 2: A lead comes from a marketing campaign to the website and starts chat "I'm looking for metal packaging for cold pressed olive oil. Can you tell me what options you have?"**

| Action performed                                                                                                                                                                                           | Tools used                                         |
|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------|
| Agent checks if they're an existing lead, fetches the lead record, and gets Copilot lead summary from Dynamics 365 Sales. Through the summary, the agent learns that the lead is a decision maker, has previously done business, and prefers sustainable packaging. | `ListLead` and `InvokeLeadSummary`  |
| Agent searches online to understand the type of packaging attributes olive oil requires and finds that opaque and slim bottles work best.                                                            | None required; agent uses Bing search from Copilot Studio |
| Based on this, the agent pulls the right products from Dynamics 365 and proposes them to the customer. (Insert relevant text for the chat)                                                                  | `GetProducts` #Dynamics 365 Supply Chain                    |
| Optional: If the lead confirms interest, creates a quote in Dynamics 365 Sales or Dynamics 365 Business Central.                                                                                                    | `CreateQuote` #Sales #BusinessCentral               |

