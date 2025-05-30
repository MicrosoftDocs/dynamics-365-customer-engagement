---
title: Use Model Context Protocol in Dynamics 365 Sales (preview)
description: Learn how to turn on and set up Copilot in Dynamics 365 Sales. Help your sales team can get summaries of their lead and opportunity records, catch up on recent changes, and prepare for meetings.
ms.date: 05/13/2025
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
---

# Use Model Context Protocol in Dynamics 365 Sales (preview)

Model Context Protocol (MCP) is a powerful new standard that enables seamless integration between your favorite AI assistants, such as ChatGPT and Claude, to Dynamics 365 Sales. It can also be used to integrate with AI agents such as Microsoft Copilot Studio agents. With MCP, you can create custom AI-powered experiences, leveraging AI assistants, Microsoft Copilot Studio, and Power Platform to enhance automation and data interaction.

## Integrate Sales MCP Server with AI agents or models

With the Sales MCP server, you can extend your AI agents and AI assistants with sales-specific tools and create custom experiences for your sellers. The MCP server is a set of APIs that enable the interaction with Dynamics 365 Sales data and functionality.

You can integrate the Sales MCP server with your Microsoft Copilot Studio agent, or any other AI agent or model that supports the MCP standard. Depending on the AI agent or assistant you are using, the integration process varies.

- For Microsoft Copilot Studio, follow the instructions in [Extend your agent with Model Context Protocol (preview)](/microsoft-copilot-studio/agent-extend-action-mcp).  
- For other AI agents or assistants, refer to the documentation provided by the respective platform for integrating with MCP. For example, for Claude integrations, refer to the [Claude documentation](https://docs.anthropic.com/en/docs/build-with-claude/tool-use/implement-tool-use).

## Tools supported by the Sales MCP Server

The following table lists the tools supported by the Model Context Protocol (MCP) server in Dynamics 365 Sales. These tools allow you to qualify leads, draft and send outreach emails to leads.


| Tool Name                        | Purpose                                                                                                   | Example Questions                                                  |
|----------------------------------|-----------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------|
| ListLeads             | Retrieves a list of leads for the organization or fetches a lead by attribute name.                       | "Show me all open leads." <br> "List leads assigned to me."        |
| QualifyLeadToOpportunity | Qualifies a lead and can create account, contact, or opportunity records.                                 | "Qualify this lead." <br> "Qualify the lead John Doe"   |
| InvokeLeadSummary     | Provides a summary of a lead based on lead ID. The tool fetches the lead summary from Copilot in Dynamics 365 Sales. Ensure that Copilot in Dynamics 365 Sales is enabled to use this tool.                                                           | "Summarize this lead." <br> "Give me details about lead John Doe."    |
| DraftOutreachEmail    | Drafts an outreach email for a lead based on lead ID. The tool fetches the outreach email from Copilot in Dynamics 365 Sales. Ensure that Copilot in Dynamics 365 Sales is enabled to use this tool.                                                     | "Draft an outreach email for this lead." <br> "Write an intro email to John Doe." |
| SendOutreachEmail     | Sends an outreach email to a customer using a draft for the specified lead.                                | "Send the outreach email to this lead." <br> "Email the draft to John Doe."   |