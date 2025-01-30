---
title: Summary dashboard in Omnichannel historical analytics
description: Integrate Copilot Studio and Omnichannel analytics to better understand your organization's customer service experience.
ms.date: 07/26/2024
ms.topic: article
author: gandhamm
ms.author: mgandham
ms.reviewer: mgandham
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

The **Summary** dashboard provides a seamless end-to-end reporting of metrics across the customer service journey. This integrated analytics report aligns key metrics in Copilot Studio and Omnichannel for Customer Service.

 With the Summary dashboard, customer service managers or supervisors can:
- Use Copilot Studio bot metrics, such as escalation and deflection rate, and customer service representatives (service representatives or representatives) metrics like engagement rate and abandon rate to get an overview of how customers interact with bots and bot performance.
- Evaluate how different bot topic areas and their corresponding agent conversation topics affect your organization’s support performance.
- Get actionable insights to handle bot escalations and customer requests effectively, which help improve customer satisfaction and decrease costs.

 :::image type="content" source="../media/oc-summary-dashboard.png" alt-text="Screenshot showing the Omnichannel Historical Summary dashboard.":::

### Access the Summary dashboard

[!INCLUDE[cc-navigation](../../includes/cc-navigation.md)]

## Report details

The report summarizes the KPIs for the specified time period and the percentage change over that period. You can filter these areas by duration, channel, queue, or conversation status.

 :::image type="content" source="../media/oc-summary-bot-metrics.png" alt-text="Screenshot showing the bot metrics with respect to conversations.":::

| KPI | Description |
| ------- | ------------------ |
| Total conversations | The number of conversations initiated by customers. |
| Bot deflection rate | The percentage of conversations engaged by bots that were resolved.|
| Bot escalation rate | The percentage of conversations engaged by bots that were escalated to a customer service representative (service representative or representative).  |
| Incoming conversations  | The total number of conversations that are initiated by the customer and are presented to a service representative. Conversation escalated by the Copilot Studio bots is also included.|
| Engaged conversations | Offered conversations that are engaged by an agent. Customer-to-agent communication begins at this point.|
| Abandon rate | The percentage of incoming conversations that are in a service representative's queue but aren't engaged by agents. |
|Average time to answer | The average time customers waited in the queue before being connected to an agent. |

An up-and-down indicator below the value indicates the percent change in either a positive or negative direction.

The following charts are displayed in the Summary dashboard.

 :::image type="content" source="../media/oc-bot-summary-charts.png" alt-text="Screenshot showing the charts for integrated conversations.":::

| Title | Description |
| ------- | ------------------ |
| Total conversations | A graphical view of the conversations initiated by the customer and connected to a customer service representative directly, resolved by the Copilot Studio bot, or escalated by a bot to the customer service representative.|
| Agent engagement rate over time | A graphical view of the daily incoming conversations, conversations engaged by an agent, and abandoned conversations over time. |
| Bot conversations| A graphical view of the daily deflection and escalation rate and abandon rate over the specified time period. |

## Bot escalation topic metrics

The **Bot escalation topic metrics** section provides insights into the performance of individual bot topics and their key business metrics. Supervisors can drill down into a topic to view the corresponding agent conversation topics and analyze how a bot is resolving a topic versus how an agent is resolving an escalated conversation topic. The resolution helps supervisors analyze how different topic areas impact an organization’s support performance.

 :::image type="content" source="../media/oc-summary-topics.png" alt-text="Screenshot showing the bot conversation topics and customer journey.":::
 
To view further bot topics and their related metrics, go to [Bot dashboard](oc-bot-dashboard.md).   

## Language availability for topics 

The topics capability in the Customer Service historical analytics reports comes with a natural language understanding model that can understand text semantics and intent in the following languages: 

- English 
- French 
- German 
- Italian 
- Japanese 
- Portuguese 
- Simplified Chinese 
- Spanish 

> [!NOTE]
> While topic discovery is enabled and still possible in languages that aren't listed in this section, there might be differences in experience for users who uaw topics in unsupported languages.

### Related information

[Conversation dashboard](oc-conversation-dashboard.md)  
[Dashboard overview](customer-service-analytics-insights-csh.md)  
[Agent dashboard](agent-dashboard.md)  
[Bot dashboard](oc-bot-dashboard.md)  
[Manage report bookmarks](manage-bookmarks.md)  
