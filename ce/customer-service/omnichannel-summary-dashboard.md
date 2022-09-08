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

The Summary page gives you a broad overview of how effectively Power Virtual Agent bots are enabling customers navigate the customer service experience.
 Using artificial intelligence (AI) technology, KPIs such as topics are having the greatest impact on escalation rate, abandon rate, and resolution rate (see the table under Summary charts for more information on these metrics) are displayed.

This allows you cto monitor the escalation rate from PVA to staff additional agents on the floor and suggest changes to update PVA bot based on the agent resolution steps to increase PVA deflection and to reduce over all support cost.

You can view the Summary dashboard in Omnichannel for Customer Service. On the Home tab, select the (+), and then select Omnichannel historical analytics. On the page that appears, select the Bot tab.


## Report details

The reports summarize the KPIs for the specified time period and the percent change over the period. You can filter these areas by duration, channel, queue, or conversation status.


| KPI | Description |
| ------- | ------------------ |
| Total conversations | The number of conversations initiated by the customer. |
| Bot deflection rate | The percentage of conversations that were resolved by a bot, out of all conversations engaged by power virtual agent bots. |
| Bot escalation rate | The percentage of engaged conversations that were escalated to a human agent.  |
| Incoming conversations  | The total number of conversations that are initiated by a customer and is in the agent bucket. |
| Engaged conversations | The total conversations that are engaged conversations. An engaged conversation is the one in which a user-created topic (as opposed to a system topic) is triggered, or the session ends in escalation. Engaged sessions can have one of three outcomes—they are either resolved, escalated, or abandoned. |
| Abandon rate | The daily rate of abandoned conversations. An abandoned conversation is a conversation that is neither resolved nor escalated after an hour from the beginning of the session. |
|Average time to answer | The average amount of time an agent actively spends on a session, by day. |

A blue up-and-down indicator next to the value indicates the percent change in a positive direction. A red indicator indicates the percent change in a negative direction.

## Summary charts

| Title | Description |
| ------- | ------------------ |
| Total conversations | A graphical view of the conversations that were initiated by the customer and were either resolved by the power virtual agent bot or was escalated by the bot to the agent.|
| Agent engagement rate over time | A graphical view of the incoming conversations, engaged conversations, and abandon rate over the specified time period. |
| Bot conversations | A graphical view of the bot escalation rate and the deflection rate over the specified time period. This indicates the number of engaged bot conversations that were resolved by the bot versus the number of conversations that were escalated to the agent. |

## Bot escalation topic metrics

The bot escalation topic metrics section provides a view into the performance of escalated topics and their associated conversation topics, over the specified period. The conversation topic

You can display the topic details page by selecting the Detail link in one of the following charts on the Summary and Customer Satisfaction pages: