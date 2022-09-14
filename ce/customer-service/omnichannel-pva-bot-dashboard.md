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

The Bot dashboard shows key performance indicators (KPIs) and charts that you can use to understand how effective the Power Virtual Agents bots integrated with the application are in handling customer conversations.

You can view the Bot dashboard in Omnichannel for Customer Service. On the **Home** tab, select the (**+**), and then select **Omnichannel historical analytics**. On the page that appears, select the **Bot** tab.

## Report details

The reports summarize the KPIs for the specified time period and the percent change over the period. You can filter these areas by duration, channel, queue, or agent.

The Report details changes when Power Virtual agents are configured and the toggle in enabled in the Customer Service Admin Center.  Based on your selection the KPIs are displayed.

### When PVA bots are integrated

| KPI | Description |
| ------- | ------------------ |
| Total conversations | The number of conversations initiated by the customer and engaged by a bot. |
|Escalation rate |  The percentage of conversations that were escalated by a bot to a human agent.  |
|Total sessions |  The total number of sessions within the specified time period. A bot session is defined as a conversation in which a bot is invoked. The bot can be invoked at the beginning, during, or end of a conversation. |
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

The metrics section displays a comprehensive set of analytics that show you the key performance indicators for your bot.

Multiple key performance indicators show you the trends and usage for your bot's topics at a granular level, highlighting the topics that have the greatest impact on your bot's performance.

### Summary

The Summary tab gives you a broad overview of your bot's performance with respect to the customer initiated conversations.

The following table explains the bot metrics.

| Title | Description |
| --------------- | --------------- |
| Bot conversations | The number of conversations initiated by the customer and engaged by a bot. |
| Bot resolution rate | The percentage of conversations that were closed by interacting with a bot, out of all conversations engaged by a bot. |
| Bot resolution time | The length of time, in minutes, a customer interacted with a bot before the conversation was closed. |
| Bot escalation rate | The percentage of conversations that were escalated by a bot to a human agent.|
| Bot escalation time (min) | The length of time, in minutes, a customer interacted with a bot before the conversation was escalated to an human agent. | 

You view the topics associated to a specific bot by clicking on the bot and then selecting Details on the right. The bot topics with the KPIs and percentages are displayed. Select the topic to view and  download up to seven days of bot conversation transcript sessions from the past 30 days.

To edit the bot responses to a topic, select Power Virtual Agents on the Topics metrics grid or by selecting Details. This will open the corresponding Power Virtual Agents bot. You can modify both the topic name and trigger phrases, and in the case of trigger phrases; you can add additional ones.

### Details

The Details tab gives you an insight into the bot sessions.

The following table explains the bot metrics.

| Title | Description |
| --------------- | --------------- |
| Total sessions| The total number of sessions within the specified time period. |
| Bot sessions engaged | The number of sessions the bot is engaged in within the specified time period. |
| Bot sessions resolved| The number of engaged sessions that are resolved by the bot. |
| Bot sessions abandoned|The number of engaged sessions that are abandoned. An abandoned session is an engaged session that is neither resolved nor escalated after one hour from the beginning of the session.|
| Bot sessions per conversation | Average number of PVA sessions per conversation. | 
| Session resolved rate | The percentage of total sessions that were resolved by the bot within the specified time period. | 
| Sessions escalated rate | The percentage of total sessions that were escalated by the bot to a human agent within the specified time period.| 

## Bot hourly detail drill down view

The Bot hourly details drill down view provides more granular insight into the hour-by-hour breakdown of key conversation metrics within the contact center. The metrics are the same as the day-by-day view ensuring that supervisors can consistently analyze their contact center operation regardless of desired duration granularity. To view the drill down, select any single metric value on the desired day, then select Hourly details.