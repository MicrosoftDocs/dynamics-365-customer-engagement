---
title: Work on opportunities handed over by the Opportunity Research Agent
description: Learn how to work on opportunities handed over by the Opportunity Research Agent. 
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

# Work on opportunities handed over by the Opportunity Research Agent

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

The Opportunity Research Agent in Dynamics 365 Sales empowers you to work more efficiently on complex, high-value deals. The agent automatically gathers insights from multiple sources, assesses risk to the opportunity, and provides actionable recommendations. After completing the research, the agent hands over the opportunity to you to take action.

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

## View opportunities handed over by the Opportunity Research Agent

1. In the Sales Hub app, select **Opportunities**.
1. From the views drop-down, select **My top opportunities from AI agent**.  
   :::image type="content" source="media/opportunities-from-agent.png" alt-text="Screenshot of the My top opportunities from AI agent view in the Sales Hub app.":::
   The view lists all the opportunities that the agent researched on and includes the importance and risk for each opportunity. The list includes only opportunities with high and medium importance.
   > [!NOTE]
   > Importance is calculated based on the estimated revenue of the opportunity and risk is calculated based on the estimated close date of the opportunity and its predictive score. Learn more about predictive score in [Prioritize opportunities through predictive scores](work-predictive-opportunity-scoring.md)

1. Open an opportunity.
   You'll see a **Summary** card at the top of the page, displaying a quick summary of the research outcome and actionable recommendation, if any.
1. Select **Research opportunity**.
   The Opportunity research page opens with the complete research insights and recommendations.

## Opportunity research page

The Opportunity research page includes the following sections:

**Risk mitigation:** This section is displayed only for opportunities that are at risk. The agent assesses the risk based on the information available in the opportunity and its related entities, such as account, product, and stakeholders. The agent also provides recommendations to mitigate the risk. These recommendations are based on similar deals in the past and the current context of the opportunity.

If the risk and the recommended action seem relevant, take the action and select **Mark as done**. Otherwise, mark the risk as **Not relevant**.

**Key insights:** This section provides a quick overview of the deal and its importance. It also includes what happened so far and how much time you should invest in the deal, along with next steps, if any.

**Key signals:** This section includes the recent communications and activities related to the opportunity and key updates that the seller should be aware of to take the deal forward.

**Deeper insights:** This section includes the entire research spectrum. This includes stakeholders insights, pain points and needs, opportunity health based on MEDDPICC framework, and account, product, and competitor insights. The insights in this section contribute to the Key insights and Key signals sections.