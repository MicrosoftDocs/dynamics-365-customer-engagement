---
title: Queue Dashboard | Microsoft Docs
description: Learn about the Queue dashboard to better understand agent performance in your organization.
ms.date: 10/12/2022
ms.topic: article
author: gandhamm
ms.author: mgandham
---

# Queue dashboard

The Queue dashboard gives you a broad overview of the customer service experience in your organization by providing insights into how specific queues are operating.
 
> [!div class="mx-imgBorder"]
> ![Queue dashboard historical analytics.](media/queue-historical-analytics.png "Queue historical analytics dashboard")

By default, the dashboard shows key performance indicators (KPIs) for the past month and for all channels, queues, and agents in your system. You can use the data filtering options to select data for specific time periods, channels, queues, agents, conversation status, and time zone. To filter data by duration, channel, queue, agent, conversation status, or time zone, select a value from the respective dropdown list.

> [!NOTE]
> If you switch to a different dashboard, the filter you specified will persist and be applied to the data on all dashboards.


### Access the Queue dashboard

[!INCLUDE[cc-navigation](../includes/cc-navigation.md)]

## Report details

The following KPIs are displayed in the Queue dashboard.

> [!div class="mx-imgBorder"]
> ![KPI for queue dashboard.](media/queue-KPI.png "Key performance indicators for queue dashboard")

| KPI | Description |
| ----------------- | ------------------ |
| Incoming sessions | The total number of sessions initiated by customers. |
| Engaged sessions | The number of sessions presented to an agent that were accepted. |
| Avg. wait time (sec) | The average time customers waited before connecting to an agent. It's similar to "speed to answer," but this metric includes the wait time from each session within a conversation. |
| Avg. session handle time | The total session active time across engaged sessions. |
| Transfer rate | The percentage of conversations that were transferred to another agent or queue. |
| Avg. session sentiment | The average predicted customer sentiment for a given session. |


The following charts are displayed in the Queue dashboard.

> [!div class="mx-imgBorder"]
> ![Queue charts.](media/queue-charts.png "Key performance indicator charts for queue dashboard")

| Title | Description |
| ---------------- | ------------------ |
| Incoming session vs engaged session |The total number of sessions initiated by customers versus the number of sessions initiated and accepted by an agent.|
| Avg. wait time (sec) | The average time customers waited before connecting to an agent. It's similar to "speed to answer," but this metric includes wait time from each session within a conversation. |
| Avg. session active time (min) | The average total session active time across engaged conversations. |
| Avg. session handle time (min) | The average total session handle time across engaged conversations. |
| Sessions rejected/timed out rate | The number of sessions presented to an agent that weren't accepted. |

> [!div class="mx-imgBorder"]
> ![Queue summary chart.](media/oc-queue-summary.png "Queue summary chart")

| Session summary | Description |
| ---------------- | ---------------- |
| Incoming sessions | The number of sessions initiated by a customer |
| Engaged sessions | The number of sessions accepted by an agent.  |
| Avg. wait time (sec) | The average time customers waited before connecting to agents. This is similar to "speed to answer," but it includes wait time from each session within a conversation. |
| Session rejected/timed out rate | The number of sessions presented to an agent that weren't accepted. |
| Transfer rate | The percentage of conversations that were transferred to another agent or queue. |
| Avg. session time (min) | The average time, from session start to end, for engaged sessions. |
| Avg. session handle time (min) | The average of the total session active time across engaged sessions. |
| Avg. session sentiment | The average predicted customer sentiment for a given session. |


| Session details | Description |
| --------------- | ----------------- |
| Avg. session active time (min) | The average total session active time across engaged conversations. |
| Avg. session inactive time (min) | The average total session inactive time across engaged sessions.  |
| Avg. incoming messages | The average total number of incoming messages from the customer, per session. |
| Avg. outgoing messages | The average total number of outgoing messages from the customer, per session. |
| Incoming messages | The total incoming messages from the customer, per session. |
| Outgoing messages | The total outgoing messages per session from customer, per session.|


| Consult/ Monitor | Descriptions | 
| --------------------- | --------------------- |
| Consult sessions | Number of sessions where the agent has participated in consult mode. |
| Avg consult time (min) | Average time an agent spent during a session in consult mode. |
| Monitor sessions | Number of sessions where the agent has participated in monitor mode |
| Avg monitor time (min) | Average time agent spent on a session in monitoring mode | 

A blue upward triangle next to the value indicates that the percentage has changed in a positive direction. A red downward triangle indicates that the percentage has changed in a negative direction.

## Queue hourly details drill-down view

The "queue hourly details drill-down" view provides a more granular insight into the hour-by-hour breakdown of key conversation metrics within the contact center. Metrics for the conversation summary and conversation details are the same as the day-by-day view, ensuring that supervisors can consistently analyze their contact center operation regardless of duration granularity.

To view the drill-down report, select any single metric value on the required day, then select **Hourly details**.

> [!div class="mx-imgBorder"]
> ![Queue Hourly drill down view.](media/queue-hourly-drill-down-view.png "Queue hourly drill down view")


### See also

[Conversation dashboard](oc-conversation-dashboard.md)  
[Dashboard overview](customer-service-analytics-insights-csh.md)  
[Agent dashboard](agent-dashboard.md)  
[Bot dashboard](oc-bot-dashboard.md)  
[Conversation Topics dashboard](oc-conversation-topics-dashboard.md)  
[Manage report bookmarks](manage-bookmarks.md)  


