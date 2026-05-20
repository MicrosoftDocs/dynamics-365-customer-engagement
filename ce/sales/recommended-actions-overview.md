---
title: Recommended actions overview
description: Recommended actions is an intelligent capability that shows prioritized actions so sellers focus on the most effective tasks for their opportunities. 
ms.date: 05/19/2026
ms.update-cycle: 180-days
ms.topic: how-to
ms.service: dynamics-365-sales
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Recommended actions overview (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Recommended actions is an intelligent capability that shows prioritized actions so sellers focus on the most effective tasks for their opportunities. This agent evaluates actions from multiple agents and presents them in a single, prioritized experience.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Key capabilities

- **Intelligent prioritization**: Uses AI and LLM processing to evaluate and prioritize actions. It moves beyond deterministic recommendations and provides contextual insights. This capability helps sellers act on high impact opportunities and risks faster.

- **Multi-agent support**: Aggregates actions from other agents in your organization, like Sales Opportunity Agent, Data Enrichment Agent, and custom agents you create. This capability enables a unified action surface regardless of where the insight originates.  

- **Extensible architecture**: Supports onboarding of custom workflows and third party or customer built agents. The architecture scales as new agents enter the ecosystem.  

- **Actionable insights**: Provides clear, actionable recommendations that sellers can execute directly from the interface. This capability reduces friction and accelerates time to action. 

- **Ranking actions**: Ranks actions based on custom prioritization models that consider factors like deal importance, risk criticality, and potential impact. This capability ensures sellers focus on what matters most.  

## Supported agents and behavior

| Agent type | Behavior | Charging model |
|------------|----------|----------------|
| Sales Opportunity Agent | Provides prioritized actions | Charged |
| Data Enrichment Agent | Displayed in carousel, not prioritized | Not charged.<br>Data Enrichment agent actions are shown but not processed through the prioritization engine, which is why they're not billed. |
| Custom agents | Can be onboarded and prioritized | Charged |

## Capacity usage

The system charges for recommended actions based on the number of actions the prioritization engine processes. Each action from a supported agent that the engine evaluates and prioritizes counts toward your usage. Actions that the system displays but doesn't process through prioritization (like actions from the Data Enrichment Agent) don't count toward your usage.

- [Manage consumption-based billing for agent capabilities](copilot-consumption-based-billing.md)
- [View the agent's usage consumption](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new#use-the-summary-tab)

## How to use the agent

Your role in the sales process determines how you use recommended actions.

| User role | Reference |
|-----------|-----------|
| Administrator | [Configure recommended actions](configure-recommended-actions.md)<br>[Add Custom Agent to the Recommended Actions Agent](developer/recommended-actions-api.md) |
| Seller | [View and act on recommended actions](next-best-actions-to-manage-opportunities.md) |

