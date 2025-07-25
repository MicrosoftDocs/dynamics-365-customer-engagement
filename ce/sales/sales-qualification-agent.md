---
title: Sales Qualification Agent overview
description: Learn how the Sales Qualification Agent in Dynamics 365 Sales can be your personal assistant in qualifying leads and improving sales outcomes.
ms.date: 05/22/2025
ms.update-cycle: 180-days
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom: bap-template
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Sales Qualification Agents overview

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

Sales teams often struggle to keep up with the volume of inbound leads from websites, events, and webinars, leading to missed opportunities and idle leads in CRM. Sales qualification agents in Dynamics 365 Sales are AI assistants that automate manual lead qualification. They help you qualify leads faster and more effectively, so you can spend more time interacting with top leads.

## Types of Sales Qualification Agents

Sales Qualification Agents are classified into two types:

- **Research**: An AI assistant that automates the manual aspects of lead qualification. It doesn't replace your judgment or decision-making process. It provides detailed insights about each lead, such as their background, recent activities, and news about their company. Think of it as a personal assistant that provides detailed insights about each lead, such as their background, recent activities, and news about their company:

    - **Background**: Understand the lead's role, company, and industry.
    - **Insights**: Get insights about whether to engage with the lead or not. Know more about the lead's recent activities, such as their recent opportunities, colleagues who worked with the leads, and why this lead matches your ideal customer profile.
    - **News**: Stay updated with the latest news about the lead's company and industry.

    This helps you focus on the most promising leads and improve your sales outcomes.

- **Engage**: An AI assistant that helps you manage high lead volumes. The agent works on assigned leads based on your selection criteria, like lead source, rating, or geography. Additionally, the agent autonomously engages with each lead, follows up, and evaluates fit based on your seller hand-off rules. Leads that demonstrate purchase intent and meet most of your criteria are handed over to sellers for qualification, while those that don’t are handed over to supervisors for disqualification, ensuring your sales team focuses only on high-potential opportunities.  

## Difference between Research and Engage

The difference between the Research and Engage lies in their functionality and level of autonomy.  

| Feature | Research | Engage |
|---------|----------------|---------------|
| Autonomy | Research and provides insights to sellers. | Research, provides insights, and engages and qualifies leads autonomously. |
| Functionality | Provides insights and recommendations. | Engages with leads and manages follow-ups. |
| Decision-making | Allows seller to make decisions on engagement and qualification. | Automatically engages and hands over to seller for qualification. |

## Understand Sales Qualification Agent concepts

The Sales Qualification Agents are designed to assist you in the lead qualification process. Here are some key concepts to understand how the agents work on leads and help you qualify leads:

**Ideal customer profile (ICP)**: Applicable for both research and engage agents, the ICP is a set of criteria that defines the characteristics of your ideal customer. The agent uses this profile to evaluate leads and determine their fit. More information: [What is the ideal customer profile and how is the fit determined?](sales-qualification-agent-concepts.md#what-is-the-ideal-customer-profile-and-how-is-the-fit-determined)

**Purchase interest**: Applicable for the engage agent, purchase interest is an indicator of the lead's intent to buy. The agent evaluates leads based on their engagement and interest level. More information: [What is purchase interest and how is it determined?](sales-qualification-agent-concepts.md#what-is-purchase-interest-and-how-is-it-determined)

**BANT (Budget, Authority, Need, Timing)**: Applicable for the engage agent, BANT is a framework used to evaluate leads based on their budget, authority, need, and timing. The agent uses this framework to assess the lead's potential and readiness to buy. More information: [What is BANT and how is the fitment calculated?](sales-qualification-agent-concepts.md#what-is-bant-and-how-is-the-fitment-calculated)

## How to use the agent

The usage of the Sales Qualification Agents depend on your role in the sales process.  

| Role | Research | Engage |
|------|----------|--------|
| Admin | [Set up and configure Sales Qualification Agent](configure-sales-qualification-agent.md)<br>[Test the Sales Qualification Agent](test-sales-qualification-agent.md) | [Set up and configure Sales Qualification Agent](configure-sales-qualification-agent.md)<br>[Test the Sales Qualification Agent](test-sales-qualification-agent.md) |
| Seller | [Qualify leads with the Sales Qualification Agent](use-sales-qualification-agent.md) | Engage with leads and manage follow-ups |
| Supervisor | &mdash; | Monitor agent performance and lead hand-offs |

## Capacity usage

The Sales Qualification Agents uses the capacity assigned to your tenant to process leads and generate insights. You can set up either prepaid capacity or pay-as-you-go capacity for the agent. Use the following resources to learn more about setting up capacity and monitoring usage:  

- [Manage consumption-based billing for agent capabilities](copilot-consumption-based-billing.md)
- [View the agent's usage consumption](configure-sales-qualification-agent.md#view-the-agents-usage-consumption)

## Responsible AI

Sales Qualification Agent is built with responsible AI principles in mind. The agent has been carefully evaluated to ensure that it meets quality standards and is designed to be used as a productivity tool. For more information about the agent's responsible AI practices, go to [Responsible AI FAQ for the Sales Qualification Agent](faqs-sales-qualification-agent.md).

## Related information

- [Sales Qualification Agent FAQ](sales-qualification-agent-faq.md)
- [Responsible AI FAQ about the Sales Qualification Agent](faqs-sales-qualification-agent.md)
