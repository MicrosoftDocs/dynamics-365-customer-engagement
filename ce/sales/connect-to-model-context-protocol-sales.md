---
title: Dynamics 365 Sales Model Context Protocol overview
description: Learn about the Model Context Protocol (MCP) server for Dynamics 365 Sales, its capabilities, and how it enables integration with AI agents and assistants.
ms.date: 02/27/2026
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
- [Sales Close Agent - Research capabilities](sales-close-agent-research-tools.md)
- [Copilot in Dynamics 365 Sales capabilities](copilot-in-sales-tools.md)

In addition, the Sales MCP server also supports tools for performing CRUD operations on Dataverse records, which can be used across various sales scenarios. Learn more about the supported Dataverse MCP server tools in [Connect to Dataverse with Model Context Protocol](/power-apps/maker/data-platform/data-platform-mcp).

## Copilot Credit consumption rates

Each AI tool in the Sales MCP server consumes Copilot Studio credits based on the amount of data processed and the complexity of the response generated. The credit consumption rates for each tool may vary depending on these factors.

| Tool                              | API Call Type           | Copilot Credit Charge (CC) |
|------------------------------------|-------------------------|----------------------------|
| get_lead_research                  | Dataverse read          | 0.1 CC                     |
| get_account_research               | Dataverse read          | 0.1 CC                     |
| get_competitor_research            | Dataverse read          | 0.1 CC                     |
| draft_outreach_email               | CAPI call               | 2 CC                       |
| get_engage_summary                 | Dataverse read          | 0.1 CC                     |
| get_lead_qualification_assessment  | CAPI call               | 2 CC                       |
| get_customer_updates               | Dataverse read          | 0.1 CC                     |
| get_sales_record_summary           | CAPI call               | 2 CC                       |
| get_sales_lead_catchup             | Dataverse read          | 0.1 CC                     |
| get_sales_account_catchup          | Dataverse read          | 0.1 CC                     |
| get_sales_opportunity_catchup      | Dataverse read          | 0.1 CC                     |
| get_sharepoint_search_results      | CAPI call               | 2 CC                       |
| get_answer_from_sharepoint_documents| CAPI call               | 2 CC                       |
| get_key_opportunity_insights       | Dataverse read          | 0.1 CC                     |
| get_key_opportunity_signals        | Dataverse read          | 0.1 CC                     |
| get_key_opportunity_stakeholders   | Dataverse read          | 0.1 CC                     |
| get_opportunity_health             | Dataverse read          | 0.1 CC                     |
| get_opportunity_pain_points_and_needs| Dataverse read        | 0.1 CC                     |
| get_opportunity_top_risks          | Dataverse read          | 0.1 CC                     |
| get_opportunity_deal_overview | Dataverse read          | 0.1 CC                     |

## Related information

[Examples of using Sales MCP Server with AI agents and assistants](model-context-protocol-examples.md)