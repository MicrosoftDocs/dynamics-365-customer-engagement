---
title: Work on opportunities researched by the Opportunity Research Agent
description: Learn how to work on opportunities researched by the Opportunity Research Agent.
ms.date: 07/14/2025
ms.topic: how-to
ms.service: dynamics-365-sales
content_well_notification:
  - AI-contribution
ms.custom: bap-template
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
search.app: salescopilot-docs
ms.collection: bap-ai-copilot
ai-usage: ai-assisted
---

# Work on opportunities researched by the Opportunity Research Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Opportunity Research Agent in Dynamics 365 Sales makes it easy for you to focus on the most important opportunities. By identifying high-value and at-risk opportunities, the agent helps you prioritize your efforts. With critical insights and recommendations, you can quickly ramp up on opportunities, engage the right stakeholders, and mitigate risks effectively.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## Prerequisites

You need the following prerequisites:

- Your admin has configured the Opportunity Research Agent for your organization. 

- You're part of the sales team that works on the product and opportunity segment that the agent is configured for.
- You have the necessary permissions to view and work on the opportunities researched by the agent.
- Your mailbox is configured to track **All email messages**. This is required for the agent to gather insights from your emails and meetings. Learn more in [Configure server-side synchronization](configure-opportunity-research-agent.md#configure-server-side-synchronization).

## View opportunities researched by the Opportunity Research Agent

1. In the Sales Hub app, select **Opportunities**.

1. From the views drop-down, select **My top opportunities from AI agent**.  
   :::image type="content" source="media/opportunities-from-agent.png" alt-text="Screenshot of the My top opportunities from AI agent view in the Sales Hub app.":::
   The view lists all the opportunities that the agent researched on and includes the importance and risk for each opportunity. The list includes only opportunities with high and medium importance.
   > [!NOTE]
   > The agent uses the estimated revenue, estimated close date, predictive score, and other factors to calculate the importance and risk of the opportunities.  

1. Open an opportunity.
   You'll see a **Summary** card at the top of the page, displaying a quick summary of the research outcome and actionable recommendation, if any.
1. Select **Research this opportunity**.
   The Opportunity research page opens with the complete research insights and recommendations.

## Opportunity research page

The Opportunity research page includes the following sections:

**Risk mitigation:** This section is displayed only for opportunities that are at risk. The agent assesses the risk based on the information available in the opportunity and its related entities, such as account and stakeholders. The agent also provides recommendations to mitigate the risk.

If the risk and the recommended action seem relevant, take the action and select **Mark as done**. Otherwise, mark the risk as **Not relevant** so that the agent can learn from your feedback and remove the risk from the list of risks for the opportunity.

**Key insights:** This section provides a quick overview of the deal and its importance. It also includes what happened so far and how much time you should invest in the deal, along with next steps, if any.

**Key signals:** This section includes the recent communications and activities related to the opportunity and key updates that the seller should be aware of to take the deal forward.

**Deeper insights:** This section includes the entire research spectrum. This includes stakeholders insights, pain points and needs, opportunity health based on MEDDPICC framework, and account, product, and competitor insights. The insights in this section contribute to the **Key insights** and **Key signals** sections.