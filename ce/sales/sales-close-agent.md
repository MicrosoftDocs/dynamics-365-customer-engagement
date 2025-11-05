---
title: Sales Close Agent overview (preview)
description: Discover how Sales Close Agent in Dynamics 365 Sales automates the sales process for high-velocity, low-complexity deals using AI-powered assistance to enhance customer engagement and drive transactions to closure.
ms.date: 11/07/2025
ms.update-cycle: 180-days
ms.topic: overview
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-description
  - ai-seo-date:08/04/2025
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Sales Close Agent overview (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Closing deals in today’s dynamic environment requires more than strong selling skills—it demands trust-building, relationship management, and agility to respond to rapid changes in customer interactions, team updates, and competitive moves. Dynamics 365 Sales introduces AI-powered agents to simplify and optimize this process.  

- **Sales Close Agent - Research** (formerly known as Opportunity Research Agent) mode provides early visibility into emerging risks and highlights the most promising opportunities by synthesizing insights from multiple data sources into a single view. It enhances decision-making without replacing human judgment, enabling sellers to focus on high-impact actions. The **Sales Close Agent - Research** applies only to the **Opportunity** entity.  
- **Sales Close Agent - Engage** mode autonomously manages the end-to-end sales cycle for high-velocity, low-complexity deals. It engages customers, recommends products, handles objections, and drives transactions to closure using templated personalization for outreach and follow-ups. Ideal for SMB scenarios, it reduces costs while maintaining compliance and customer experience through accurate product catalogs, pricing, and customizable playbooks. Future enhancements will include advanced features like quote generation and discount handling, further scaling sales operations efficiently. The **Sales Close Agent - Engage** applies only to **Contact**, **Account**, **Lead**, and **Opportunity** entities.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## How does the Sales Close Agent help you?

Managing deals effectively requires timely insights and efficient execution. Dynamics 365 Sales offers two AI-powered agents that simplify these challenges:

### Sales Close Agent - Research  

This agent consolidates CRM updates, email threads, meeting intelligence, and real-time web research to provide actionable insights in one place. It helps you:  

- **Detect risks early**: Whether it’s a disengaged stakeholder, slowing momentum, or competitive pressure, the agent flags risks and recommends targeted actions to keep your deal moving forward.  
- **Prioritize with confidence**: Based on real-time signals, see which deals are gaining traction, which are at risk, and where your effort will drive the most impact.  
- **Get the full picture fast**: View buyer needs, stakeholder roles, competitor mentions, and deal health in one unified place without having to sift through multiple sources. The agent synthesizes insights from CRM, emails, meetings, and web research to give you a comprehensive view of your deal.  

Watch this video to learn how the Sales Close Agent - Research helps you focus on the most important opportunities and provides insights and recommendations to close deals faster:  
> [!VIDEO https://learn-video.azurefd.net/vod/player?id=808744ab-2236-42be-802a-4f1061c1d5c5]  

### Sales Close Agent - Engage  

Designed for high-velocity, low-complexity deals, this agent automates the sales process end-to-end. It enables you to:

- **Automate customer engagement**: The agent proactively reaches out to potential customers, providing personalized communication based on predefined templates and customer data. This ensures timely follow-ups and consistent engagement without manual intervention.  
- **Guide customers through the funnel**: The agent assists customers in navigating the sales process, from initial interest to final purchase. It can recommend products, answer common questions, and address objections, helping to move deals forward efficiently.  
- **Ensure compliance and accuracy**: By leveraging a well-defined product catalog and pricing information, the agent ensures that all customer interactions are compliant with organizational policies and that product recommendations are accurate.  
- **Leverage customizable playbooks**: Organizations can tailor the agent's behavior using customizable playbooks, allowing them to align the agent's actions with their specific sales strategies and messaging.  

## Difference between Sales Close Agent - Research and Sales Close Agent - Engage

The following table summarizes the differences between the Sales Close Agent - Research and Sales Close Agent - Engage:  

| Functionality | Sales Close Agent - Research | Sales Close Agent - Engage | Description |
|---------------|:----------------------------:|:--------------------------:|:-----------:|
| Consolidate insights from multiple sources | ✅ | ✅ | The agent synthesizes insights from CRM, emails, meetings, and web research to give you a comprehensive view of your deal. |
| Detect risks early | ✅ | ❌ | The agent flags risks such as disengaged stakeholders, slowing momentum, or competitive pressure, and recommends targeted actions to keep your deal moving forward. |
| Prioritize deals | ✅ | ❌ | Based on real-time signals, the agent helps you see which deals are gaining traction, which are at risk, and where your effort will drive the most impact. |
| Provide a comprehensive deal view | ✅ | ❌ | View buyer needs, stakeholder roles, competitor mentions, and deal health in one unified place without having to sift through multiple sources. |
| Automate customer engagement | ❌ | ✅ | The agent proactively reaches out to potential customers, providing personalized communication based on predefined templates and customer data. |
| Guide customers through the sales funnel | ❌ | ✅ | The agent assists customers in navigating the sales process, from initial interest to final purchase, recommending products, answering questions, and addressing objections. |
| Ensure compliance and accuracy | ❌ | ✅ | By leveraging a well-defined product catalog and pricing information, the agent ensures that all customer interactions are compliant with organizational policies and that product recommendations are accurate. |
| Leverage customizable playbooks | ❌ | ✅ | Organizations can tailor the agent's behavior using customizable playbooks, allowing them to align the agent's actions with their specific sales strategies and messaging. |
| Automate sales processes | ❌ | ✅ | The agent streamlines and automates various sales tasks, reducing manual effort and increasing efficiency throughout the sales cycle. |

## Capacity usage

The Sales Close Agent (Research and Engage) uses the capacity assigned to your tenant to process records and communicate with customers. You can set up either prepaid capacity or pay-as-you-go capacity for the agent. Use the following resources to learn more about setting up capacity and monitoring usage:

- [Manage consumption-based billing for agent capabilities](copilot-consumption-based-billing.md)
- [View the agent's usage consumption](/power-platform/admin/manage-copilot-studio-messages-capacity?tabs=new#use-the-summary-tab)

## Responsible AI

Sales Close Agent is built with responsible AI principles in mind. The agent has been carefully evaluated to ensure that it meets quality standards and is designed to be used as a productivity tool. For more information about the agent's responsible AI practices, go to:  

- [FAQs about Sales Close Agent - Research](faqs-about-opportunity-research.md)  
- [FAQs about Sales Close Agent - Engage](faqs-about-sales-close-agent-engage.md).  

## How to set up and use the agents

Depending on your role, use the following links to configure and use the Sales Close Agents:

- **Sales Close Agent - Research**

    | Role | Action |
    |------|--------|
    | Admin | [Configure the Sales Close Agent - Research](configure-opportunity-research-agent.md) |
    | Seller | [Work on opportunities researched by the Sales Close Agent - Research](use-opportunity-research-agent.md) |

- **Sales Close Agent - Engage**

    | Role | Action |
    |------|--------|
    | Administrator | [Set up and configure the Sales Close Agent - Engage](configure-sales-close-agent.md)<br>[Start the agent](start-sales-close-agent.md)<br>[Manage the agent](manage-sales-close-agent.md)<br>[How the Sales Close Agent - Engage works](how-sales-close-agent-engage-mode-works.md) |
    | Supervisor | [View agent insights and metrics](view-sales-close-agent-engage-insights-metrics.md)<br>[How the Sales Close Agent - Engage works](how-sales-close-agent-engage-mode-works.md) |
