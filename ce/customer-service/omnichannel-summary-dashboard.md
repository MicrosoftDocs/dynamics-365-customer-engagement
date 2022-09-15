---
title: Summary Dashboard for PVA bots | Microsoft Docs
description: Integrate PVA and Omnichannel analytics to better understand your organization's customer service experience
ms.date: 09/06/2022
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365CS
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

# Analyze PVA bot performance and usage

In Omnichannel for Customer Service, bots can be integrated into the customer service journey to perform tasks like starting a conversation with the customer, providing automated responses, and then transferring the conversation to a human agent, as required.

Measuring the effectiveness of a bot in the customer service lifecycle allows customer service managers or supervisors to handle escalations from the bot more effectively or handle increased customer request volumes by increasing agent staffing, and suggest changes to update the bot's responses based on the agent's resolution steps or escalated conversations, reducing future escalations and costs.

The Summary dashboard gives you a broad overview your Power Virtual Agent bots performance and the customer service experience of your organization. The Summary report provides Power Virtual agent-specific KPIs and metrics such as escalation rate, resolution rate, and abandon rate that can be used by supervisors and administrators to track the success of the bot. They can also track and correct bot responses for topics with higher escalation rates items to  improve the effectiveness and reducing further escalations and staffing costs, thereby increasing customer satisfaction.

 :::image type="content" source="media/oc-summary-dashboard.png" alt-text="Screenshot that shows the Omnichannel Historical Summary dashboard.":::

You can view the Summary dashboard in Omnichannel for Customer Service. On the Home tab, select the (+), and then select Omnichannel historical analytics. On the page that appears, select the Summary tab.


## Report details

The reports summarize the KPIs for the specified time period and the percent change over the period. You can filter these areas by duration, channel, queue, or conversation status.

 :::image type="content" source="media/oc-summary-bot-metrics.png" alt-text="Screenshot shows the bot metrics with respect to conversations.":::

| KPI | Description |
| ------- | ------------------ |
| Total conversations | The number of conversations initiated by the customer. |
| Bot deflection rate | The percentage of conversations that were resolved by a power virtual agent bot, out of all the bot engaged conversations.|
| Bot escalation rate | The percentage of engaged conversations that were escalated to a human agent.  |
| Incoming conversations  | The total number of conversations that are initiated by the customer and are presented to a human agent. These conversation include the conversations that are escalated by the Power Virtual Agent bots.|
| Engaged conversations | Offered conversations that are engaged by an agent. Customer-to-agent communication begins at this point.|
| Abandon rate | The percentage of conversations that are in a human agent's queue but aren't engaged by agents. |
|Average time to answer |The average time customers waited in the queue before connecting to an agent. |

A blue up-and-down indicator next to the value indicates the percent change in a positive direction. A red indicator indicates the percent change in a negative direction.

The following charts are displayed in the Summary dashboard.

 :::image type="content" source="media/oc-bot-summary-charts.png" alt-text="Screenshot shows the bot metrics with respect to conversations.":::

| Title | Description |
| ------- | ------------------ |
| Total conversations | A graphical view of the conversations that were initiated by the customer and were connected to a human agent directly, resolved by the power virtual agent bot, or escalated by to the human agent.|
| Agent engagement rate over time | A graphical view of the daily incoming conversations, conversations engaged by an agent, and abandoned conversations over time. |
| Bot conversations| A graphical view of the daily deflection and escalation rate, and abandon rate over the specified time period. |

## Bot escalation topic metrics

The bot escalation topic metrics section provides insights into the performance of individual bot topics. Drill-down into these topics to view the corresponding conversation topics, provides supervisors with a holistic look into individual topics in reference to key business metrics, and can be valuable in understanding how a bot is resolving a topic or if a bot escalated a conversation pertaining to a topic, how the agents are resolving the topic. to help you better understand how different topic areas are impacting your organization’s support performance.


 :::image type="content" source="media/oc-bot-summary-topics.png" alt-text="Screenshot shows the bot converation topics and customer journey.":::

## Language availability for topics