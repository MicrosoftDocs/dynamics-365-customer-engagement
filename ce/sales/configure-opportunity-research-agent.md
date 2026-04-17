---
title: Set up and configure the Sales Opportunity Agent
description: Learn how to set up and configure the Sales Opportunity Agent in Dynamics 365 Sales.
ms.date: 04/17/2026
ms.update-cycle: 90-days
ms.topic: overview
ms.service: dynamics-365-sales
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Set up and configure the Sales Opportunity Agent

As an administrator, you can configure the Sales Opportunity Agent in Dynamics 365 Sales to help sales professionals gain insights and recommendations for the opportunities they're working on. The agent automatically gathers information from various sources, providing a streamlined research experience, stakeholder and competitor intelligence, and actionable risk mitigation strategies.  

You can also set up multiple agent instances to handle different product lines or opportunity segments simultaneously. Each agent instance can be configured independently with its own profile, selection criteria, and knowledge sources, allowing you to tailor the insights and recommendations to the specific needs of each segment. For more information, see [Create multiple agent instances](#create-multiple-agent-instances).

## Prerequisites

Ensure that you meet the following prerequisites before configuring the agent.

- Complete the [common prerequisites applicable to all sales agents](prerequisites-for-all-agents.md).
- You have admin permissions in Dynamics 365 Sales.  
- You have a Copilot Studio license. Learn more in [Copilot Studio licensing](/microsoft-copilot-studio/billing-licensing).  
- You turned on the modern UI for the Sales Hub app. Learn more in [Enabling the modern look for my app and removing the toggle](/power-apps/user/modern-fluent-design#enabling-the-modern-look-for-my-app-and-removing-the-toggle).  
- Allow the following connectors in your organization's data policies for the agent to use various knowledge sources. 

    | Connector | Why is it required? |
    |-----------|---------------------|
    | Knowledge source with public websites and data | Access public data for enrichment. |
    | Microsoft Copilot Studio | Core platform for building and deploying the agent. |
    | Knowledge source with SharePoint or OneDrive | Required only if the agent uses internal documents on SharePoint or OneDrive. |
    | Knowledge source with documents | Required only if the agent uses internal documents. |
    | Direct Line channels in Copilot Studio | Required for the agent to connect to Microsoft Copilot Studio. |

    Learn more in [Manage data policies](/power-platform/admin/prevent-data-loss?tabs=new).

## Plan your implementation

Before you set up the agent, consider the following points:

- **Pick a product line.** The agent can be configured to handle opportunities for a specific product line. Choose a product line that has a good amount of opportunities and is important for your business.
- **Define an opportunity segment.** Determine the segment of opportunities for the agent to handle. For example, only opportunities that are **Hot** with an estimated revenue of $100,000 or more.
- **Predictive scoring dependency.** The agent uses the machine learning model in predictive opportunity scoring for risk assessment. If you didn't configure scoring in your environment, it's configured automatically when you start the agent.

## Grant permissions to sellers <a name="grant-permissions"></a>

By default, the **Salesperson** and **Sales Manager** security roles have the necessary permissions. If you're using a custom security role, ensure sellers have the following minimum permissions:

| Purpose | Access level - Permissions | Entities |
|---------|----------------------------|----------|
| Consent to use Microsoft 365 emails for opportunity research | Basic-level - Read | prvReadconnector |

## Setup the Sales Opportunity Agent

Before setting up the agent, make sure you [plan your implementation](#plan-your-implementation) and meet [all prerequisites](#prerequisites). Use the following steps to configure and start the Sales Opportunity Agent:

1. [Open the Sales Opportunity Agent settings page](open-sales-close-agent-research-settings.md).  
1. [Configure requirements for the agent](configure-requirements-for-sales-close-agent-research.md).
1. [Configure the agent profile](configure-sales-close-agent-profile-research.md) for the agent such as name and language.
1. [Configure company info](configure-sales-close-agent-research-company-info.md) for the agent to understand value proposition and curate research insights.
1. [Configure refresh frequency](configure-sales-close-agent-research-refresh-frequency.md) to specify how often the agent refreshes research data.
1. [Set selection criteria for opportunities](configure-sales-close-agent-research-selection-criteria.md) to define which opportunities the agent should research.
1. [Configure importance and risk assessment](configure-sales-close-agent-research-opportunity-assessment.md) to select the fields the agent uses to assess opportunity importance and risk.
1. [Configure knowledge sources](configure-sqa-knowledge-source.md) to add public and internal knowledge sources for the agent to generate insights.
1. [Configure advanced settings (optional)](opportunity-research-agent-advanced-settings.md) to customize risk and importance criteria.
1. [Start the agent](start-sales-close-agent-research.md) to begin researching opportunities and generating insights.

## Create multiple agent instances

You can use multiple agents to handle different product lines or opportunity segments at the same time. You can configure each agent instance independently with its own profile, selection criteria, and knowledge sources. For example, you can create one agent for high-value enterprise deals and another for mid-market opportunities, tailoring the insights and recommendations to the specific needs of each segment.

### Considerations
Consider the following points when creating multiple agent instances of Sales Opportunity Agent:

- **Maximum instances per organization**: Your organization can have up to 10 active agent instances.  
- **Capacity usage**: All agent instances draw from the same capacity pool. Monitor your capacity usage to ensure you have enough resources to support multiple agents. For more information, see [Manage consumption-based billing for agent capabilities](copilot-consumption-based-billing.md).  

### Configuring an agent instance

When you create a new agent instance, configure it by following the steps outlined in the [Setup the Sales Opportunity Agent section](#setup-the-sales-opportunity-agent). Each instance can have its own unique configuration for selection criteria, knowledge sources, and other settings. This configuration allows you to customize the agent's behavior for different segments of opportunities.
However, note the aspects for the following configuration sections for each agent instance:

- **Selection criteria**: Each agent must have its own distinct selection criteria to determine which opportunities it processes. To learn how the selection criteria for multiple agent instances work, see [Selection criteria for multiple agent instances](configure-sales-close-agent-research-selection-criteria.md#selection-criteria-for-multiple-agent-instances). 
- **Knowledge sources**: All instances share the same single Microsoft Copilot Studio knowledge base. For each agent instance, you can configure which knowledge sources it uses by applying filters. To learn how to filter knowledge sources for specific agent instances, see [Filter knowledge sources by agent instance](configure-sqa-knowledge-source.md#filter-knowledge-sources-by-agent-instance). 
 
## Related information

- [Work on opportunities handled by the Sales Opportunity Agent](use-opportunity-research-agent.md)
- [FAQs about Sales Opportunity Agent](faqs-about-opportunity-research.md)