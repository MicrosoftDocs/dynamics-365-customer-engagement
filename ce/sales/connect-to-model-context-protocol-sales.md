---
title: Dynamics 365 Sales Model Context Protocol overview
description: Learn about the Model Context Protocol (MCP) server for Dynamics 365 Sales, its capabilities, and how it enables integration with AI agents and assistants.
ms.date: 04/17/2026
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

# Dynamics 365 Sales Model Context Protocol (MCP) server overview

## Overview

Model Context Protocol (MCP) is a standard that enables AI agents and assistants to interact with various applications and services in a consistent manner. With the Dynamics 365 Sales MCP server, you can extend your AI applications with sales-specific tools to create custom experiences for your sellers. The server provides APIs that enable AI agents to retrieve sales data, generate insights, draft emails, and perform other sales-related tasks.

## Tools available in the Sales MCP server

The following tools are currently available in the Sales MCP server:

- [Sales Qualification Agent capabilities](sales-qualification-agent-tools.md)
- [Sales Opportunity Agent capabilities](sales-close-agent-research-tools.md)
- [Copilot in Dynamics 365 Sales capabilities](copilot-in-sales-tools.md)

In addition, the Sales MCP server also supports tools for performing CRUD operations on Dataverse records, which can be used across various sales scenarios. Learn more about the supported Dataverse MCP server tools in [Connect to Dataverse with Model Context Protocol](/power-apps/maker/data-platform/data-platform-mcp).

## Copilot Credit consumption rates

Each AI tool in the Sales MCP server consumes Copilot Studio credits based on the agent feature it uses, such as Text and generative AI tools (basic) or Generative answer. The billing rates for these features are defined in the [Copilot Studio documentation](/microsoft-copilot-studio/requirements-messages-management). The billing rate for each agent feature might vary, so it's important to understand the costs associated with using these tools in your AI applications.

Copilot credits are not charged for specific Dynamics 365 Sales licenses. For more information, refer to the **Model Context Protocol (MCP) for Dynamics 365** section in the [Dynamics 365 Licensing guide](https://go.microsoft.com/fwlink/?LinkId=866544).

The following table summarizes the tools available in the Sales MCP server and their corresponding agent features for credit consumption:

| Tool                              | Agent feature |
|-----------------------------------|----------------------|
| get_lead_research                  | Text and generative AI tools (basic) |
| get_account_research               | Text and generative AI tools (basic) |
| get_competitor_research            | Text and generative AI tools (basic) |
| draft_outreach_email               | Text and generative AI tools (basic) |
| get_engage_summary                 | Text and generative AI tools (basic) |
| get_lead_qualification_assessment  | Text and generative AI tools (basic) |
| get_customer_updates               | Text and generative AI tools (basic) |
| get_sales_record_summary           | Generative answer |
| get_sales_lead_catchup             | Text and generative AI tools (basic) |
| get_sales_account_catchup          | Text and generative AI tools (basic) |
| get_sales_opportunity_catchup      | Text and generative AI tools (basic) |
| get_sharepoint_search_results      | Text and generative AI tools (basic) |
| get_answer_from_sharepoint_documents| Generative answer |
| get_key_opportunity_insights       | Text and generative AI tools (basic) |
| get_key_opportunity_signals        | Text and generative AI tools (basic) |
| get_key_opportunity_stakeholders   | Text and generative AI tools (basic) |
| get_opportunity_health             | Text and generative AI tools (basic) |
| get_opportunity_pain_points_and_needs| Text and generative AI tools (basic) |
| get_opportunity_top_risks          | Text and generative AI tools (basic) |
| get_opportunity_deal_overview      | Text and generative AI tools (basic) |



## Related information

[Examples of using Sales MCP Server with AI agents and assistants](model-context-protocol-examples.md)
