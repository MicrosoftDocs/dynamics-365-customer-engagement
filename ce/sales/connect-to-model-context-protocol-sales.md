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

## Integrate Sales MCP Server with AI agents or models

You can integrate the Sales MCP server with your Microsoft Copilot Studio agent, or any other AI agent or model that supports the MCP standard. The Sales MCP server is part of the Dataverse MCP server. Learn more about integrating the Dataverse MCP server with your AI agent or model in [Connect to Dataverse with model context protocol (preview)](/power-apps/maker/data-platform/data-platform-mcp).


## Tools supported by the Sales MCP Server

The following table lists the tools supported by the Model Context Protocol (MCP) server in Dynamics 365 Sales. These tools allow you to list leads, qualify leads, and draft and send outreach emails to leads.


| Tool Name              | Purpose                                                                                                   |
|------------------------|-----------------------------------------------------------------------------------------------------------|
| `ListLeads`            | Retrieves a list of leads for the organization or fetches a lead by attribute name.                       |
| `QualifyLeadToOpportunity` | Qualifies a lead and can create account, contact, or opportunity records.                                 |
| `InvokeLeadSummary`    | Provides a summary of a lead based on lead ID. The tool fetches the lead summary from Copilot in Dynamics 365 Sales. Ensure that Copilot in Dynamics 365 Sales is enabled to use this tool. |
| `DraftOutreachEmail`   | Drafts an outreach email for a lead based on lead ID. The tool fetches the outreach email from Copilot in Dynamics 365 Sales. Ensure that Copilot in Dynamics 365 Sales is enabled to use this tool. |
| `SendOutreachEmail`    | Sends an outreach email to a customer using a draft for the specified lead.                                |