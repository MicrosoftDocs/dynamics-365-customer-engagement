---
title: View Sales Close Agent (Research) insights and metrics
description: Learn how to view insights and metrics for the Sales Close Agent's Research type, including key performance indicators and engagement statistics.
ms.date: 11/21/2025
ms.topic: how-to
ms.service: dynamics-365-sales
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

# View Sales Close Agent (Research) insights and metrics

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

After the Sales Close Agent Research type is set up and running, you can monitor its performance by viewing insights and metrics. These insights help you understand how effectively the agent is engaging with customers and driving sales.  

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

The insights dashboard is displayed as shown in the following image:

:::image type="content" source="media/sca-research-insights-dashboard.png" alt-text="Screenshot of the Sales Close Agent Research type insights dashboard.":::

## Open the insights dashboard

1. In the Sales Hub app, go to **App settings**.  
1. Under **General** settings, select **Dynamics 365 AI hub**.
    If you have trouble finding or accessing the AI hub, it might be due to permission restrictions. Learn more in [Access Dynamics 365 AI Hub](dynamics-365-ai-hub.md).  
1. In the **AI Optimization hub** card, select **See insights**.  
    The Agent insights page opens with the available insights for the agents configured in your organization.  
1. Select the **Sales Close Agent - Research** tab.  
1. Verify the **Last refreshed** date and time to ensure the data is up-to-date. The data is refreshed when you open the dashboard. If needed, you can refresh the dashboard by selecting the **Refresh** icon.  
1. Select the **Time period** filter to specify the period for which you want to view the data. By default, the dashboard shows data for the last 7 days.  

## Understand the insights and metrics

### Top metrics  

| Metric | Description |
|--------|-------------|
| Opportunities researched | Total number of opportunities where research has been completed by the agent. |
| Deal velocity | Average revenue generated per month from opportunities researched by the agent. |
| Win rate | Percentage of opportunities researched by the agent that were closed as won. |
| Risk mitigation rate | Percentage of opportunities with risk that were acted upon by the sellers. |

### Agent effectiveness

**Opportunity status funnel**

| Stage | Description |
|-------|-------------|
| Opportunities at risk | Total number of opportunities identified as at risk by the agent. |
| Riskfree | Opportunities that are no longer at risk after seller intervention. |
| Active | Opportunities where risk is still present and requires further action. |

**Risk status funnel**

| Stage | Description |
|-------|-------------|
| Total risks | Total number of risks identified by the agent across all researched opportunities. |
| Mitigated | Total number of risks that have been successfully mitigated by the agent. |
| Active | Total number of risks that are still active and require attention. |
| Marked as done | Total number of risks marked as resolved by sellers. |
| Dismissed | Total number of risks dismissed by sellers. |

**Opportunity risk breakdown**

The doughnut chart provides a breakdown of the different types of risks identified by the agent across all researched opportunities. Each segment represents a specific risk category, allowing sellers to quickly identify prevalent issues.  

## Related information

[Configure the Sales Close Agent - Research (preview)](configure-opportunity-research-agent.md)  
