---
title: Connect to Dynamics 365 Sales with Model Context Protocol (preview)
description: Learn how to connect to Dynamics 365 Sales with Model Context Protocol (MCP) and integrate it with AI agents or models.
ms.date: 11/17/2025
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
- Allow access to Dataverse MCP Server from MCP clients. Learn more in [Configure the Dataverse MCP server for an environment](/power-apps/maker/data-platform/data-platform-mcp-disable)
- If you've previously connected to the Dynamics 365 Sales MCP server (preview), delete the connection as it's now deprecated and will be removed soon.

## Connect your AI agents and assistants to Sales MCP Server

You can integrate the Sales MCP server with your Microsoft Copilot Studio agent, or any other AI agent or assistant that supports the MCP standard. Claude Desktop is not supported at this time.

### Connect Sales MCP Server to Copilot Studio agent

To connect to the Sales MCP server in Microsoft Copilot Studio, follow the steps in [Add tools and resources from a Model Context Protocol (MCP) server to your agent](/microsoft-copilot-studio/mcp-add-components-to-agent). 

> [!NOTE]
> Ensure to select **Dynamics 365 Sales MCP server (preview)** when prompted to select the MCP server. If you want to perform CRUD operations on Dataverse records, connect to the **Dataverse MCP server** as well.

### Connect Sales MCP Server to Github Copilot in Visual Studio Code

To connect to the Sales MCP server with Github Copilot in Visual Studio Code, follow these steps:

1. Download and open Visual Studio Code

1. Press Ctrl + Shift + P - type in **MCP** and select **MCP:Open User Configuration**. to open the `mcp.json` config file.
1. Add the server URL for Dynamics 365 Sales and Dynamics 365 Dataverse MCP Servers using:
    - For Dataverse, use the orgID in the URL. For example: Northwind.crm10.dynamics.com

    - For Dynamics 365 Sales, use the environmentID. For example: 00aa00aa-bb11-cc22-dd33-44ee44ee44ee
    - Optional: If you want to send emails as well, you can add the Mail MCP Server, with the same Dynamics 365 environment ID.
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
                },
                
            },
            "inputs": []
        }
    ```
4. Select **Start** on all the servers
5. Press Ctrl + Alt + I to open the Github Copilot chat pane and choose any agent (For example, Claude Sonnet 4).


## Tools supported

The following table lists the tools supported by the Sales MCP Server, powered by the Sales Qualification Agent in Dynamics 365 Sales. Make sure that the agent is configured and turned on. Learn more in [Set up and configure the Sales Qualification Agent](configure-sales-qualification-agent.md).


| Tool Name (Friendly)         | API Name                                         | Purpose                                                      | Parameter(s)                | Returns                                                                                 |
|------------------------------|--------------------------------------------------|--------------------------------------------------------------|-----------------------------|-----------------------------------------------------------------------------------------|
| Account Research Tool        | `mcp_sales-mcp-ser_get_account_research`         | Retrieve comprehensive account research data                 | `msdyn_LeadId` (string)     | Financial information, company overview, strategic goals, recent news                   |
| Competitor Research Tool     | `mcp_sales-mcp-ser_get_competitor_research`      | Retrieve competitor research and competitive landscape       | `msdyn_LeadId` (string)     | Competitive threats, market positioning, alternative suppliers                          |
| Engagement Analysis Tool     | `mcp_sales-mcp-ser_get_engage_summary`           | Retrieve engagement summary and interaction history for a lead | `msdyn_LeadId` (string)     | Engagement patterns, touchpoint analysis, interaction effectiveness                     |
| Lead Qualification Tool      | `mcp_sales-mcp-ser_get_lead_qualification_assessment` | Get comprehensive lead qualification assessment against ICP criteria | `LeadId` (string)           | ICP standards evaluation, qualification ranking, overall assessment                     |
| Lead Research Tool           | `mcp_sales-mcp-ser_get_lead_research`            | Retrieve detailed lead research and individual prospect analysis | `msdyn_LeadId` (string)     | Professional background, decision-making authority, preferences                         |
| Outreach Email Generation Tool | `mcp_sales-mcp-ser_draft_outreach_email`        | Draft personalized sales qualification agent outreach emails | `LeadId` (string)           | Personalized email subject and body with company-specific insights                      |


In addition to the Sales MCP server tools, you can also use the Dataverse MCP server tools to perform CRUD operations on the records in Dynamics 365 Sales. Learn more about the supported Dataverse MCP server tools in [Connect to Dataverse with Model Context Protocol](/power-apps/maker/data-platform/data-platform-mcp). 


## What can you do with the Sales MCP server?

Let's explore some example scenarios to understand how you can use the Sales MCP server to enhance your sales processes with AI agents or assistants.


### Example 1: Generate sales call scripts for each lead


**Prompt:** Look up all the leads for kenny.smith@contoso.com, gather their account and competitor research, and write me sales phone scripts to sell GPUs to each of these leads

The following text includes the truncated version of the output from Visual Studio Code + Claude:

Based on the comprehensive account research I gathered, I can now create detailed sales phone scripts for each lead. Here are the scripts:

Sales Phone Scripts for GPU Sales - kenny.smith@contoso.com
Based on comprehensive account research, here are tailored sales phone scripts for each prospect:

Lead 1: Microsoft - Kenny Smith (100 GPUs)
Lead ID: 32e354c2-3b06-44fd-b722-9422e1b2c422
Target Quantity: 100 GPUs
Company: Microsoft
Financial Health: Excellent ($281.7B revenue, $101.8B net income)

**Sales Phone Script:**
**Opening:**
"Hi Kenny, this is [Your Name] from [Your Company]. I hope you're having a great day. I'm calling about your inquiry for 100 GPUs. Given Microsoft's massive $80 billion capital expenditure plan for AI infrastructure that was announced this year, I wanted to discuss how we can support your specific GPU requirements."

**Research-Based Insights:**
"I've been following Microsoft's incredible growth story - $281.7 billion in revenue with $32.5 billion in R&D investment shows your commitment to innovation. Your Azure deployment of Nvidia Hopper GPUs for large language models caught our attention, and we'd love to be part of Microsoft's continued AI infrastructure expansion."

**Discovery Questions:**

"Are these 100 GPUs intended for Azure's AI services expansion, or perhaps internal Microsoft AI research projects?"
"Given Microsoft's focus on purpose-built hardware for scalable AI applications, what specific performance requirements are you targeting?"
"How does this procurement fit into Microsoft's broader AI supercomputing infrastructure plans?"

**Value Proposition:**
"Microsoft's mission to 'empower every person and organization to achieve more' aligns perfectly with our GPU solutions:

Enterprise-grade reliability for mission-critical Azure workloads
Seamless integration with existing Microsoft AI infrastructure
Performance optimization for Microsoft's AI-focused applications
Scalable architecture supporting future expansion plans"

**Financial Alignment:**
"With Microsoft's strong financial position and 16% year-over-year growth driven by AI-focused Azure, I know you have the purchasing power for premium solutions. Our competitive pricing for enterprise deployments ensures optimal ROI on your AI investments."

**Next Steps:**
"I'd love to schedule a technical consultation with your Azure infrastructure team. Given Microsoft's aggressive AI timeline, would you be available for a 45-minute discussion this week to explore how our GPUs can accelerate your AI initiatives?"

## Example 2: Share account research and engagement summary for a lead with colleagues

Prompt: Can you get account research and engagement summary for lead 'Gregory House'. Save them in two separate document and send the word doc to <Your email id>

Other servers required to be setup as prerequisites: mcp_WordServer, mcp_MailTools.

The following screenshot shows the output from Visual Studio Code + Claude:  
:::image type="content" source="media/sales-mcp-server-save-as-word-example.png" alt-text="Screenshot of the task completion notification from Visual Studio Code + Claude showing the Word document saved and email sent confirmation.":::


### Example 3: Sales team uploads leads (event attendees) from Excel into Dynamics 365 Sales

| Action performed                                                                                   | Tools used                          | MCP Server used         |
|----------------------------------------------------------------------------------------------------|-------------------------------------|-------------------------|
| For each event attendee, the agent gets the lead record and uses Sales Qualification Agent's lead research to determine if they’re a good fit | read_query, mcp_sales-mcp-ser_get_lead_research | Dataverse MCP server, Sales MCP Server |
| For each lead that is a good fit, drafts an outreach email                                         | mcp_sales-mcp-ser_draft_outreach_email | Sales MCP server        |
| When a lead responds, converts lead to a new opportunity                                           | create_record, update_record        | Dataverse MCP server    |
| If the lead confirms interest, creates a quote in Dynamics 365 Sales                               | create_record                       | Dataverse MCP server    |
| Upon customer/seller approval, creates order in Dynamics 365 Sales                                 | create_record                       | Dataverse MCP server    |

### Example 4: A lead comes from a marketing campaign to the website

The lead starts a chat: "I'm looking for metal packaging for cold pressed olive oil. Can you tell me what options you have?"

| Action performed                                                                                                                                         | Tools used                                      | MCP Server used                        |
|----------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------|----------------------------------------|
| Agent checks if they're an existing lead, fetches the lead record, and gets account research from Dynamics 365 Sales. Through the research, the agent learns that the company is an ideal customer for the products and prefers sustainable packaging. | `read_query`, `mcp_sales-mcp-ser_get_account_research` | Dataverse MCP Server, Sales MCP Server |
| Agent searches online to understand the type of packaging attributes olive oil requires and finds that opaque and slim bottles work best.                 | None required; agent uses Bing search from Copilot Studio | Not applicable                         |
| Based on this, the agent pulls the right products from Dynamics 365 and proposes them to the customer, sending them in an email.                          | `retrieve_knowledge`, `mcp_sales-mcp-ser_draft_outreach_email` | Dataverse MCP Server, Sales MCP Server |
| The agent sends a summary of the lead's engagement history (including their responses to the outreach email sent earlier and their intent to purchase) to the account manager | `mcp_sales-mcp-ser_get_engage_summary`, `SendEmailWithAttachmentsAsync` | Sales MCP Server, Mail MCP Server      |


## Related information

- [Video: Using Claude Desktop to engage directly with Dynamics 365 Sales](https://www.youtube.com/watch?v=H_CbRy3Pb88)
- [Blog: The autonomous enterprise: How generative AI is reshaping business applications](https://www.microsoft.com/en-us/dynamics-365/blog/business-leader/2025/05/20/the-autonomous-enterprise-how-generative-ai-is-reshaping-business-applications/)