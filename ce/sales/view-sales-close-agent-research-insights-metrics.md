---
title: View Sales Opportunity Agent insights and metrics
description: Learn how to view Sales Opportunity Agent insights and metrics, track key indicators, and measure engagement to improve sales results. Open the dashboard now.
ms.date: 07/07/2026
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

# View Sales Opportunity Agent insights and metrics

After you set up and run the Sales Opportunity Agent, monitor its performance by viewing insights and metrics. These insights help you understand how effectively the agent is engaging with customers and driving sales.  

The insights dashboard is displayed as shown in the following image:

:::image type="content" source="media/sca-research-insights-dashboard.png" alt-text="Screenshot of the Sales Opportunity Agent insights dashboard.":::

## Open the insights dashboard

1. In the Sales Hub app, go to **App settings**.  
1. Under **General** settings, select **Dynamics 365 AI hub**.
    If you have trouble finding or accessing the AI hub, it might be due to permission restrictions. To learn more, see [Access Dynamics 365 AI Hub](dynamics-365-ai-hub.md).  
1. In the **AI Optimization hub** card, select **See insights**.  
    The Agent insights page opens with the available insights for the agents configured in your organization.  
1. Select the **Sales Opportunity Agent** tab.  
1. Verify the **Last refreshed** date and time to ensure the data is up-to-date. The data refreshes when you open the dashboard. If needed, you can refresh the dashboard by selecting the **Refresh** icon.  
1. Select the **Time period** filter to specify the period for which you want to view the data. By default, the dashboard shows data for the last seven days.  

## Understand the insights and metrics

### Top metrics  

| Metric | Description |
|--------|-------------|
| Opportunities researched | Total number of opportunities where research is completed by the agent. |
| Deal velocity | Average revenue generated per month from opportunities researched by the agent. |
| Win rate | Percentage of opportunities researched by the agent that are closed as won. |
| Risk mitigation rate | Percentage of opportunities with risk that sellers acted upon. |

### Agent effectiveness

**Opportunity status funnel**

| Stage | Description |
|-------|-------------|
| Opportunities at risk | Total number of opportunities the agent identifies as at risk. |
| Riskfree | Opportunities that are no longer at risk after seller intervention. |
| Active | Opportunities where risk is still present and requires further action. |

**Risk status funnel**

| Stage | Description |
|-------|-------------|
| Total risks | Total number of risks the agent identifies across all researched opportunities. |
| Mitigated | Total number of risks that the agent successfully mitigates. |
| Active | Total number of risks that are still active and require attention. |
| Marked as done | Total number of risks that sellers mark as resolved. |
| Dismissed | Total number of risks that sellers dismiss. |

**Opportunity risk breakdown**

The doughnut chart provides a breakdown of the different types of risks the agent identifies across all researched opportunities. Each segment represents a specific risk category, so sellers can quickly identify prevalent issues.  

## Related information

[Configure the Sales Opportunity Agent (preview)](configure-opportunity-research-agent.md)  
