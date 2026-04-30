---
title: Set up and configure the Sales Opportunity Agent
description: Configure the Sales Opportunity Agent in Dynamics 365 Sales to automate opportunity research, get stakeholder and competitor intelligence, and enable risk assessment for your sales team.
ms.date: 04/27/2026
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

# Set up and configure the Sales Opportunity Agent

As an administrator, you can configure the Sales Opportunity Agent in Dynamics 365 Sales to help sales professionals gain insights and recommendations for the opportunities they're working on. By setting up this agent, you enable your sales team to spend less time on manual research and more time closing deals. The agent automatically gathers information from various sources, providing a streamlined research experience, stakeholder and competitor intelligence, and actionable risk mitigation strategies.

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
    | Knowledge source with public websites and data | Allows the agent to access public web data to enrich opportunity research with market and company information. |
    | Microsoft Copilot Studio | Core platform required to build, deploy, and run the agent. Without this, the agent can't function. |
    | Knowledge source with SharePoint or OneDrive | Required only if the agent uses internal documents stored in SharePoint or OneDrive as knowledge sources. |
    | Knowledge source with documents | Required only if the agent uses uploaded internal documents as knowledge sources. |
    | Direct Line channels in Copilot Studio | Required for the agent to communicate through Microsoft Copilot Studio's messaging infrastructure. |

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

## Set up the Sales Opportunity Agent

Before setting up the agent, make sure you [plan your implementation](#plan-your-implementation) and meet [all prerequisites](#prerequisites). Use the following steps to configure and start the Sales Opportunity Agent:

1. [Open the Sales Opportunity Agent settings page](open-sales-close-agent-research-settings.md).  
1. [Configure requirements for the agent](configure-requirements-for-sales-close-agent-research.md) to verify your environment meets technical requirements.
1. [Configure the agent profile](configure-sales-close-agent-profile-research.md) to set the agent's name and language.
1. [Configure company info](configure-sales-close-agent-research-company-info.md) so the agent understands your value proposition and can curate relevant research insights.
1. [Configure refresh frequency](configure-sales-close-agent-research-refresh-frequency.md) to control how often the agent updates research data.
1. [Set selection criteria for opportunities](configure-sales-close-agent-research-selection-criteria.md) to define which opportunities the agent should research.
1. [Configure importance and risk assessment](configure-sales-close-agent-research-opportunity-assessment.md) to choose the fields the agent uses to evaluate opportunity importance and risk.
1. [Configure knowledge sources](configure-sqa-knowledge-source.md) to add public and internal sources the agent uses to generate insights.
1. [Configure advanced settings (optional)](opportunity-research-agent-advanced-settings.md) to fine-tune risk and importance thresholds.
1. [Start the agent](start-sales-close-agent-research.md) to begin researching opportunities and generating insights.

## After setup

After the agent starts, it begins researching opportunities that match your selection criteria. Note that initial research results may take some time to appear depending on the number of matching opportunities and refresh frequency settings.

To verify the agent is working correctly:

- Go to an opportunity that meets your selection criteria and confirm that research insights are visible.
- Review the agent's activity to ensure it's processing the expected opportunities.

> [!TIP]
> If research insights aren't appearing, confirm the opportunity meets your configured selection criteria and that the required connectors are allowed in your data policies.

## Create multiple agent instances

You can use multiple agents to handle different product lines or opportunity segments at the same time. You can configure each agent instance independently with its own profile, selection criteria, and knowledge sources. For example, you can create one agent for high-value enterprise deals and another for mid-market opportunities, tailoring the insights and recommendations to the specific needs of each segment.

### Considerations
Consider the following points when creating multiple agent instances of Sales Opportunity Agent:

- **Maximum instances per organization**: Your organization can have up to 10 active agent instances.  
- **Capacity usage**: All agent instances draw from the same capacity pool. Monitor your capacity usage to ensure you have enough resources to support multiple agents. For more information, see [Manage consumption-based billing for agent capabilities](copilot-consumption-based-billing.md).  

### Configuring an agent instance

When you create a new agent instance, configure it by following the steps outlined in the [Set up the Sales Opportunity Agent section](#set-up-the-sales-opportunity-agent). Each instance can have its own unique configuration for selection criteria, knowledge sources, and other settings. This configuration allows you to customize the agent's behavior for different segments of opportunities.
However, note the aspects for the following configuration sections for each agent instance:

- **Selection criteria**: Each agent must have its own distinct selection criteria to determine which opportunities it processes. To learn how the selection criteria for multiple agent instances work, see [Selection criteria for multiple agent instances](configure-sales-close-agent-research-selection-criteria.md#selection-criteria-for-multiple-agent-instances). 
- **Knowledge sources**: All instances share the same single Microsoft Copilot Studio knowledge base. For each agent instance, you can configure which knowledge sources it uses by applying filters. To learn how to filter knowledge sources for specific agent instances, see [Filter knowledge sources by agent instance](configure-sqa-knowledge-source.md#filter-knowledge-sources-by-agent-instance). 

## Migrate agents across environments

When you have configured the Sales Opportunity Agent in one environment, you can export the agent as a solution and import it into another environment. This is especially useful when you have set up the agent in a sandbox or test environment and want to deploy it in production after testing and validation. Learn more in [Import an agent into a target environment](import-export-agent-solutions.md). 
 
## Related content

- [Work on opportunities handled by the Sales Opportunity Agent](use-opportunity-research-agent.md)
- [FAQs about Sales Opportunity Agent](faqs-about-opportunity-research.md)
- [Manage consumption-based billing for agent capabilities](copilot-consumption-based-billing.md)
- [AI agents in Dynamics 365 Sales](ai-agent-overview.md)
