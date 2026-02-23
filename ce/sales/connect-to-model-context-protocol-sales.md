---
title: Connect to Dynamics 365 Sales with Model Context Protocol
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
ms.custom: bap-template
ai-usage: ai-assisted
---

# Connect to Dynamics 365 Sales with Model Context Protocol

Model Context Protocol (MCP) is a powerful new standard that enables seamless integration between your favorite AI assistants, such as ChatGPT and Claude, and Dynamics 365 Sales. MCP can also be used to integrate with AI agents such as Microsoft Copilot Studio agents. With the Sales MCP server, you can extend your AI agents and AI assistants with sales-specific tools and create custom experiences for your sellers. The MCP server includes a set of APIs that enable the interaction with Dynamics 365 Sales data and functionality.

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
| msdyn_GetOpportunityResearchResult | Dataverse read          | 0.1 CC                     |

## Related information

- [Video: Using Claude Desktop to engage directly with Dynamics 365 Sales](https://www.youtube.com/watch?v=H_CbRy3Pb88)
- [Blog: The autonomous enterprise: How generative AI is reshaping business applications](https://www.microsoft.com/en-us/dynamics-365/blog/business-leader/2025/05/20/the-autonomous-enterprise-how-generative-ai-is-reshaping-business-applications/)