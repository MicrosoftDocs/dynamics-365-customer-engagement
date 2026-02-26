---
title: Examples of using Sales MCP Server with AI agents and assistants
description: Learn about examples of how to use the Sales MCP Server with AI agents and assistants to enhance your sales processes in Dynamics 365 Sales.
ms.date: 11/17/2025
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

# Examples of using Sales MCP Server with AI agents and assistants

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

### Example 2: Share account research and engagement summary for a lead with colleagues

Prompt: Can you get account research and engagement summary for lead 'Gregory House'. Save them in two separate documents and send the word doc to kenny.smith@contoso.com

Other servers required to be setup as prerequisites: mcp_WordServer, mcp_MailTools.

The following screenshot shows the output from Visual Studio Code + Claude:  
:::image type="content" source="media/sales-mcp-server-save-as-word-example.png" alt-text="Screenshot of the task completion notification from Visual Studio Code + Claude showing the Word document saved and email sent confirmation.":::


### Example 3: Sales team uploads leads (event attendees) from Excel into Dynamics 365 Sales

This example illustrates how a custom agent can be built using the Sales MCP server tools to automate outreach and follow-up for event attendees who are uploaded as leads in Dynamics 365 Sales.

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


### Example 5: Prepare a deal briefing before a customer call

**Scenario:** A seller is about to join a customer call and wants a concise but comprehensive understanding of the opportunity.

**Prompt:** Give me a complete deal briefing for opportunity  'Customer Engagement Platform for Fabrikam Retail'. Include deal objective, current status, health, stakeholders, risks, and recent signals.

**Tools Used:** 
| Action performed | Tools used | MCP Server used |
|---|---|---|
| Agent retrieves all opportunity insights from Sales Close Agent in a single call | read_query, Opportunity deal overview tool | Dataverse MCP Server, Sales MCP Server |
| Agent summarizes the output into a structured briefing suitable for pre-call preparation | Opportunity deal overview tool | Sales MCP Server |

**Example Output:** 

The following screenshot includes the truncated version of the output from Visual Studio Code + Claude:

:::image type="content" source="media/deal-briefing-example.png" alt-text="Screenshot of the deal briefing output generated by Visual Studio Code + Claude, showing a structured summary of the opportunity including deal objective, current status, health, stakeholders, risks, and recent signals."::: 
 
### Example 6: Identify risks and gaps blocking deal progression
**Scenario:** A sales manager wants to understand why a deal is stalled and what gaps need to be addressed.

**Prompt:** Analyze the health and risks for opportunity 'Contoso – FY26 Renewal' and tell me what’s missing to move this deal forward.
 

| Action performed | Tools used | MCP Server used |
|---|---|---|
| Agent retrieves opportunity health signals and risk assessment | read_query, Opportunity health tool, Opportunity top risks tool | Dataverse MCP Server, Sales MCP Server |
| Agent analyzes MEDDPICC framework elements and identifies critical gaps | Opportunity health tool, Opportunity top risks tool | Sales MCP Server |
| Agent correlates health gaps with risks and generates actionable insights | Opportunity top risks tool | Sales MCP Server |
 
**Example Output:** The following screenshot includes the truncated version of the output from Visual Studio Code + Claude:

:::image type="content" source="media/deal-risk-analysis-example.png" alt-text="Screenshot of the deal risk analysis output generated by Visual Studio Code + Claude, showing an analysis of opportunity health and risks with identified gaps and actionable insights.":::

