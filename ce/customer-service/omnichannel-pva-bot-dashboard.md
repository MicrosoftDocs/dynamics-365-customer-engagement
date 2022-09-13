---
title: "PVA Bot Dashboard | Microsoft Docs"
description: "Learn about the PVA bot dashboard in Omnichannel historical analytics to better understand agent performance in your organization."
ms.date: 05/09/2022
ms.topic: article
author: gandhamm
ms.author: mgandham
manager: shujoshi
---

# Bot dashboard

The Bot dashboard shows key performance indicators (KPIs) and charts that you can use to understand how bots are playing a role in a support organization.

> [!div class="mx-imgBorder"]
> ![Bot dashboard.](media/bot-dashboard-oc.png "Bot dashboard")

You can view the Bot dashboard in Omnichannel for Customer Service. On the **Home** tab, select the (**+**), and then select **Omnichannel historical analytics**. On the page that appears, select the **Bot** tab.

## Report details

The reports summarize the KPIs for the specified time period and the percent change over the period. You can filter these areas by duration, channel, queue, or agent.


The Report details changes when Power Virtual agents are configured and the toggle in enabled in the Customer Service Admin Center.  Based on your selection the KPIs are displayed.

### When PVA bots are integrated

| KPI | Description |
| ------- | ------------------ |
| Total conversations | The number of conversations initiated by the customer and engaged by a bot. |
|Escalation rate |  The percentage of conversations that were escalated by a bot to a human agent.  |
|Total sessions |  The total number of sessions within the specified time period. A session is a Power Virtual Agent topic. A customer interaction can have multiple sessions. |
|Engagement rate |  The percentage of total sessions that are engaged sessions. An engaged session is a session in which a user-created topic (as opposed to a system topic) is triggered, or the session ends in escalation. Engaged sessions can have one of three outcomes—they are either resolved, escalated, or abandoned. |
| Resolution rate | The percentage of conversations that were closed by interacting with a bot, out of all conversations engaged by a bot. |
|Abandon rate  | The percentage of engaged sessions that are abandoned. An abandoned session is an engaged session that is neither resolved nor escalated after one hour from the beginning of the session. |
| Bot CSAT | The graphical view of the average of customer satisfaction (CSAT) scores for sessions in which customers respond to an end-of-session request to take the survey. |

The following table explains the bot KPI chart metrics.


| Title | Description |
| --------------- | ----------------- |
| Total conversations | A graphical view of the total number of bot conversations with the number of escalated and deflected conversations over time. |
| Engagement over time | The Engagement over time chart provides a graphical view of the number of engaged and unengaged sessions over time. An engaged session is a session in which a user-created topic is triggered or the session ends in escalation. |
|Session outcomes over time | The Session outcomes over time chart provides a graphical view of the daily resolution rate, escalation rate, and abandon rate over the specified time period. | 

The following table explains the bot metrics.

| Title | Description |
| --------------- | --------------- |
| Bot conversations | The number of conversations initiated by the customer and engaged by a bot. |
| Bot resolution rate | The percentage of conversations that were closed by interacting with a bot, out of all conversations engaged by a bot. |
| Bot resolution time | The length of time, in minutes, a customer interacted with a bot before the conversation was closed. |
| Bot escalation rate | The percentage of conversations that were escalated by a bot to a human agent.|
| Bot escalation time (min) | The length of time, in minutes, a customer interacted with a bot before the conversation was escalated to an human agent. | 


## Metrics by bot 

The Metrics by bot view provides a granular insight into the breakdown of key conversation metrics for a bot. 

The Topics drill-down view provides supervisors with a holistic look into individual topics in reference to key business metrics, and can be valuable in understanding why customers are contacting support.

To access the drill-down, select any metric value for the topic you're interested in, and then select Details. To view the drill down, select any bot and then select **Detailed view**. This opens the **Conversation topics on bot escalation** drill down.

This drill-down view provides supervisors with a holistic look into individual topics in reference to key business metrics, and can be valuable in understanding why customers are contacting support.

To access the drill-down, select any metric value for the topic you're interested in, and then select Details.

Click on the metrics to access the transcript of the bot conversation with the customer. You can also download and listen to a recording of the video.

Based on the pva bot, you can edit it from the PVA bot.
