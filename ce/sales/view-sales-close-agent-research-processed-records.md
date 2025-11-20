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

After the Sales Close Agent Engage type is set up and running, you can monitor its performance by viewing insights and metrics. These insights help you understand how effectively the agent is engaging with customers and driving sales.  

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

The insights dashboard is displayed as shown in the following image:

:::image type="content" source="media/sca-engage-insights-dashboard.png" alt-text="Screenshot of the Sales Close Agent Engage type insights dashboard.":::

## Open the insights dashboard

1. In the Sales Hub app, go to **App settings**.  
1. Under **General** settings, select **Dynamics 365 AI hub**.
    If you have trouble finding or accessing the AI hub, it might be due to permission restrictions. Learn more in [Access Dynamics 365 AI Hub](dynamics-365-ai-hub.md).  
1. In the **AI Optimization** card, select **See insights**.  
    The Agent insights page opens with the available insights for the agents configured in your organization.  
1. Select the **Sales Close Agent - Engage** tab to view the insights specific to the Sales Close Agent engage mode.  
1. Verify the **Last refreshed** date and time to ensure the data is up-to-date. The data is refreshed when you open the dashboard. If needed, you can refresh the dashboard by selecting the **Refresh** icon.  
1. Select the **Time period** filter to specify the period for which you want to view the data. By default, the dashboard shows data for the last 7 days.  

## Understand the insights and metrics

- The **Top metrics** section provides metrics for the selected time period, including:  

    | Metric | Description |
    |--------|-------------|
    | Total number of records | Total number of records to which outreach email is sent. |
    | Engagements rate | The percentage of records where the agent engaged with a customer or handed them over to seller. |
    | Customers pitched by agent | Total number of customers to which agent made a product recommendation based on the engagement. |
    | Email response rate | Percentage of emails sent by the agent that got a response from customers. |

- The **Agent effectiveness** section provides key performance indicators (KPIs) into how well the agent is performing in terms of customer engagement and sales conversion.  

    | KPI | Description |
    |-----|-------------|
    | Average attempts to achieve engagement | Average number of outreach emails sent before a customer responded. |
    | Autonomous resolution rate | Percentage of records the agent completed without human involvement. |
    | Escalation rate | Percentage of records the agent handed over to a supervisor for follow-up. |

- The **Engagement funnel** section provides a visual representation of engagement metrics over time, allowing you to identify patterns and trends in customer interactions. The funnel chart is divided into four stages as described in the following table.

    | Stage | Description |
    |-------|-------------|
    | Outreach email sent | The total number of outreach emails sent by the agent to customers. |
    | Customer responded | The number of customers who responded to the outreach emails. |
    | Customer not responded | The number of customers who didn't respond to the outreach emails. |
    | Engaged | The number of customers who are engaging with the agent. |
    | Products pitch | The number of customers who received product recommendations from the agent. |
    | Escalated | The number of customers asked to escalate this to a human seller. |
    | Completed | The number of customers who completed the engagement with the agent. |
    | Closed as lost | The number of customers who aren't interested in purchasing a product or haven't responded to outreach emails.|

## Related information

[Set up and configure the Sales Close Agent (preview)](configure-sales-close-agent.md)  
[How the Sales Close Agent Engage mode works](how-sales-close-agent-engage-mode-works.md)