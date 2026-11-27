---
title: Summary dashboard in Omnichannel historical analytics
description: Integrate Copilot Studio and Omnichannel analytics to better understand your organization's customer service experience.
ms.date: 11/26/2026
ms.topic: concept-article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
ai-usage: ai-assisted
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
searchScope:
- D365-App-customerservicehub
- D365-Entity-*
- D365-UI-Dashboard
- Dynamics 365
- Customer Service
- Customer Engagement
---

# Omnichannel Summary dashboard

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE[pva-rebrand](../../includes/cc-pva-rebrand.md)]

[!INCLUDE[cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]


The **Summary** dashboard combines metrics from Copilot Studio and Omnichannel for Customer Service to show how customers move through the service journey. Learn how to [access the dashboard](omnichannel-analytics-insights.md#access-the-dashboards).

Customer service managers and supervisors can use the dashboard to:
- Review Copilot Studio bot metrics, such as escalation and deflection rates, alongside customer service representative (service representative or representative) metrics, such as engagement and abandon rates.
- Identify opportunities to improve how service representatives handle AI agent escalations and customer requests.

 :::image type="content" source="../media/oc-summary-dashboard.png" alt-text="Screenshot showing the Omnichannel Historical Summary dashboard.":::

## Report details

The report summarizes key performance indicators (KPIs) for the specified period and the percentage change over that period. You can filter the report by duration, channel, queue, or conversation status.

 :::image type="content" source="../media/oc-summary-bot-metrics.png" alt-text="Screenshot showing the bot metrics with respect to conversations.":::

| KPI | Description |
| ------- | ------------------ |
| Total conversations | The number of conversations initiated by customers. |
| Bot deflection rate | The percentage of conversations engaged by AI agents that were resolved.|
| Bot escalation rate | The percentage of conversations engaged by AI agents that were escalated to a customer service representative (service representative or representative).  |
| Incoming conversations | The total number of customer-initiated conversations presented to a service representative, including conversations escalated by Copilot agents. |
| Engaged conversations | Offered conversations that are engaged by an agent. Customer-to-agent communication begins at this point.|
| Abandon rate | The percentage of incoming conversations that are in a service representative's queue but aren't engaged by agents. |
|Average time to answer | The average time customers waited in the queue before being connected to an agent. |

An up or down indicator below each value shows the direction of the percentage change.

The **Summary** dashboard displays the following charts.

 :::image type="content" source="../media/oc-bot-summary-charts.png" alt-text="Screenshot showing the charts for integrated conversations.":::

| Title | Description |
| ------- | ------------------ |
| Total conversations | A graphical view of the conversations initiated by the customer and connected to a service representative directly, resolved by the Copilot Studio agent, or escalated by an AI agent to the service representative.|
| Agent engagement rate over time | A graphical view of daily incoming, engaged, and abandoned conversations over time. |
| Bot conversations | A graphical view of daily deflection, escalation, and abandon rates over the specified period. |

## Bot escalation topic metrics

The **Bot escalation topic metrics** section shows performance and key business metrics for individual AI agent topics. Supervisors can explore a topic to compare how AI agents resolve it with how service representatives resolve escalated conversations. This comparison helps supervisors understand how different topics affect support performance.

 :::image type="content" source="../media/oc-summary-topics.png" alt-text="Screenshot showing the bot conversation topics and customer journey.":::
 
Learn more about AI agent topics and their related metrics in [Bot dashboard](oc-bot-dashboard.md).   


## Related information

[Conversation dashboard](oc-conversation-dashboard.md)  
[Dashboard overview](customer-service-analytics-insights-csh.md)  
[Agent dashboard](agent-dashboard.md)  
[Bot dashboard](oc-bot-dashboard.md)  
[Manage report bookmarks](manage-bookmarks.md)  
