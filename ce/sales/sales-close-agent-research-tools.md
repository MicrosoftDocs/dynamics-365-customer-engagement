---
title: MCP tools for Sales Close Agent - Research capabilities (preview)
description: Learn about the tools available in the Sales MCP server that support the Sales Close Agent - Research capabilities in Dynamics 365 Sales.
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


# MCP tools for Sales Close Agent - Research capabilities (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

This article lists the tools for using the Sales Close Agent - Research capabilities. Make sure that the Sales Close Agent - Research is [configured and turned on](configure-opportunity-research-agent.md). 

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Learn more about the insights returned by the following tools in [Opportunity research page](use-opportunity-research-agent.md#opportunity-research-page). 

| Tool name (friendly)         | API name                                         | Purpose                                                      | Parameter(s)                | Returns                                                                                 |
|------------------------------|--------------------------------------------------|--------------------------------------------------------------|-----------------------------|-----------------------------------------------------------------------------------------|
| Key opportunity insights tool          | `msdyn_GetKeyOpportunityInsights`        | Retrieve key insights for the opportunity from Sales Close Agent          | `OpportunityId` (string)    | Summary of the deal's objective, status, and key facts.                                                       |
| Key opportunity signals tool           | `msdyn_GetKeyOpportunitySignals`         | Retrieve the key signals for the opportunity from Sales Close Agent           | `OpportunityId` (string)    | Most recent developments for the given opportunity                                                           |
| Key opportunity stakeholders tool      | `msdyn_GetKeyOpportunityStakeholders`    | Retrieve key stakeholders for the opportunity from Sales Close Agent      | `OpportunityId` (string)    | List of key stakeholders and decision makers for the opportunity                                                     |
| Opportunity health tool                | `msdyn_GetOpportunityHealth`             | Retrieve opportunity health from Sales Close Agent                | `OpportunityId` (string)    | Health status for the opportunity based on the MEDDPICC framework (Metrics, Economic Buyer, Decision Process, Decision Criteria, Paper Process, Identify Pain, Champion, Competition).                                                         |
| Opportunity pain points and needs tool | `msdyn_GetOpportunityPainPointsAndNeeds` | Retrieve opportunity pain points and needs from Sales Close Agent | `OpportunityId` (string)    | List of pain points and needs related to the opportunity                                                |
| Opportunity top risks tool             | `msdyn_GetOpportunityTopRisks`           | Retrieve opportunity top risks from Sales Close Agent             | `OpportunityId` (string)    | Top risks for the opportunity based on the [risks criteria configured by your admin](opportunity-research-agent-advanced-settings.md)                                                          |
| Opportunity deal overview tool         | `msdyn_GetOpportunityResearchResult`     | Retrieve all opportunity insights from Sales Close Agent          | `OpportunityId` (string)    | Comprehensive insights for the opportunity                                               |

In addition to the Sales MCP server tools, you can also use the Dataverse MCP server tools to perform CRUD operations on the records in Dynamics 365 Sales. Learn more about the supported Dataverse MCP server tools in [Connect to Dataverse with Model Context Protocol](/power-apps/maker/data-platform/data-platform-mcp). 
