---
title: Summary Dashboard | Microsoft Docs
description: Learn about the Realtime summary dashboard to cater to your organization's customer service experience better.
ms.date: 10/12/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
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

---

# View and understand the Summary report in Omnichannel real time analytics (preview)

The Summary tab is displayed in the default view in your workspace. The dashboard includes a variety of charts with graphical views of your organization's key performance indicators (KPIs).

By default, the dashboard shows you KPIs for the past one day and for all channels, queues, and agents in your system. You can use the data filtering options to select data for specific time periods, channels, queues, agents, conversation status, direction, and time zone. Additionally, you can also pause the updates by using the ‘Pause updates’ button.

**(Need screenshots)**

## Metrics and their descriptions

**Conversation**

This section consists of the following performance indicators.

| Metric | Description 
| ------------ | --------------- |
| Offered | Total number of conversations which was offered to human agent queue. This includes both inbound and outbound conversations|
|Waiting|Total number of conversations which are currently waiting in the human agent queue to be assigned to an agent.|
|Longest wait time|Longest wait time of current unassigned conversations.|
|Avg. wait itme|Avg wait time of all assigned conversations for the period selected. This metric is calculated only for conversations which are accepted by human agent and is closed.|
|Abandon rate|Total number of conversations which are closed before an agent accepted the conversation.|
|||

**Operational**

This section consists of the following performance indicators.

| Metric | Description |
| ------------ | --------------- |
|Avg handle time |Average time an agent spent actively with a customer. Avg. handle time is derived by aggregating active session time across a conversation. This include hold time (if applicable), Wrap time (if applicable) and talk time (if applicable), active time. |
|Avg wait time |Avg wait time of all assigned conversations for the period selected. This metric is calculated only for conversations which are accepted by human agent and is closed.|
|Session rejection rate |Percentage of sessions rejected by agent(s) out of all sessions presented to an agent(s)|
|Session timeout rate |Percentage of sessions timed out by agent(s) out of all sessions presented to an agent(s)|
|Transfer rate |Percentage of conversations which was transferred atleast once. |
|||

**Agent status**

This section consists of the following performance indicators.

| Metric | Description |
| ------------ | --------------- |
|Available |Number of agents who are currently in presence status = "Available"|
|Busy|Number of agents who are currently in presence status = "busy"|
|Do not disturb|Number of agents who are currently in presence status = "Do not disturb"|
|Appear away|Number of agents who are currently in presence status = "Appear away"|
|Inactive|Number of agents who are currently in presence status = "Inactive"|
|||

**Service level**

This section consists of the following performance indicators.

| Metric | Description |
| ------------ | --------------- |
|SLA First response (30 secs) | Percentage of conversations which was responed within 30 seconds by an agent|
|SLA Response (30 secs)|Percentage of conversations which was responed within 30 seconds by an agent|
|SLA First response (60 secs)|Percentage of conversations which was responed within 60 seconds by an agent|
|SLA Response (60 secs)|Percentage of conversations which was responed within 60 seconds by an agent|
|SLA (30 secs)|Percentage of chats what were accepted by an agent within 30 seconds (after escalated by bot if applicable)|
|SLA (60 secs)|Percentage of chats what were accepted by an agent within 60 seconds (after escalated by bot if applicable)|
|||

## Capacity Profile and Units

Capacity profile explains the details of what the agent can handle. Capacity Units refers to the units an agent himself to.

**(Need screenshots)**

This section consists of the following performance indicators.

| Metric | Description |
| ------------ | --------------- |
|Required capacity units | |
|Available capacity units||
|Available agents||
|||

## Conversation and agent analytics

**(Need screenshots and description)**

- Table view
- Graph view

### See also

[Dashboard overview](customer-service-analytics-insights-csh.md)  
[Agent dashboard](agent-dashboard-cs.md)  
[Topics dashboard](case-topics-dashboard-cs.md)  
[Manage report bookmarks](manage-bookmarks.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
