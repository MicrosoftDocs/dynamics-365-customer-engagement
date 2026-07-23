---
title: AI agents in Dynamics 365 Sales
description: Learn about the out-of-the-box AI agents in Dynamics 365 Sales that help sales teams qualify leads and close deals faster.
ms.date: 07/18/2026
ms.update-cycle: 90-days
ms.topic: concept-article
ms.service: dynamics-365-sales
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:07/09/2025
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# AI agents in Dynamics 365 Sales

Dynamics 365 Sales includes out-of-the-box AI agents that autonomously research and engage with leads and opportunities. These agents help sales professionals qualify leads and close deals faster by providing insights and engaging with customers.

[!INCLUDE[ai-agents-dynamics-365-sales](../../ce-shared/ai-agents-dynamics-365-sales.md)]

## MCP and skills support

Dynamics 365 Sales also provides supported Model Context Protocol (MCP) capabilities so sales tools and actions can surface through other agents and apps, not only through the Dynamics 365 Sales UI. Learn more in [Dynamics 365 Sales Model Context Protocol overview](model-context-protocol-sales-overview.md) and [Connect AI agents and assistants to Dynamics 365 Sales MCP Server](connect-agents-to-model-context-protocol.md). For supported skills experiences in Microsoft 365 Copilot, see [Use Dynamics 365 Sales skills in Copilot Cowork](use-copilot-cowork-sales-skills.md).

## Data movement and residency for AI agents

The AI agents in Dynamics 365 Sales use the same data processing and storage infrastructure as other Copilot features in Power Platform. This behavior means that the data that the agents use might be processed and stored in regions outside of the user's primary region, depending on the availability of services and infrastructure. For more information about data residency and movement for Copilot features, see [Move data across regions for Copilots and generative AI features](/power-platform/admin/geographical-availability-copilot).

## Geographical availability and languages supported

AI agents in Dynamics 365 Sales are available in geographical regions and languages listed in the [Copilot international availability report](https://releaseplans.microsoft.com/availability-reports/?report=copilotfeaturereport). [Learn how to use the report](copilot-overview.md#how-to-use-the-copilot-international-availability-report).

<a name="monitor-agent-performance"></a>
## Monitor agent performance

You can monitor the performance of the Sales Qualification Agent and Sales Close Agent using the Agent insights dashboard. Learn more in [Monitor leads handled by the Sales Qualification Agent](monitor-leads-by-sales-qualification-agent.md) and [View Sales Close Agent engage mode insights and metrics](view-sales-close-agent-engage-insights-metrics.md). 

## Manage AI agents across environments

AI agents are deployed in sandbox or test environments before being deployed in production. This allows environments to test and validate the agents' performance and behavior before they are used in a live environment to avoid any potential disruptions to business operations. Learn how to manage AI agents across environments in [Import an agent into a target environment](import-export-agent-solutions.md).

## FAQs about sales AI agents

- [FAQs about Sales Qualification Agent](sales-qualification-agent-faq.md)
- [FAQs about Sales Opportunity Agent](opportunity-research-agent-faqs.md)
- [FAQs about Sales Research Agent (preview)](faqs-sales-research-agent.md)
