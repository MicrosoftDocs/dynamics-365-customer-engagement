---
title: "Intraday insights dashboard for supervisor | MicrosoftDocs"
description: "Learn about intraday insights dashboard for supervisor"
keywords: ""
author: udaykirang
ms.author: udag
manager: shujoshi
applies_to: 
ms.date: 06/22/2019
ms.service: dynamics-365-customerservice
ms.topic: article
ms.assetid: e88852ce-b7ad-4196-8939-419f019f3c5f
ms.custom: 
---

# Omnichannel intraday insights dashboard

The Omnichannel intraday insights dashboard provides information about the health and key performance indicators (KPIs) of agents in your organization. This dashboard consists of two sections:

-	[Conversations insights](#conversations-insights)

-	[Agent insights](#agent-insights)

The information displayed in these sections are displayed based on the conversations closed in the last 24 hours and refreshes every 15 minutes.

> [!IMPORTANT]
> The preciseness of insights that are displayed in the dashboard is affected if agents leave their account open without signing out or if you configure to assign conversations to agents who are offline.


## Conversations insights

The **Conversations insights** section provides insights on conversation requests that are generated in the past 24 hours with KPIs such as state of conversations and number of conversations.

The following screen is an example of the **Conversations insights** section.

> [!div class=mx-imgBorder]
> ![Conversations insights dashboard](../media/supervisor-conversations-insights-dashboard.png "Conversations insights dashboard")

This section of the dashboard consists of the following KPIs.

| KPI | Description |
|-------|-------|
| Average wait time per conversation | The average time a conversation is waiting in the queue in open state. |
| Average handle time per conversation | The average time that is taken to complete a conversation. The KPI is calculated based on the conversations closed in the last 24 hours. |
| Conversations exceeding 5 min wait time | The number of conversations that are in active state and exceeded the time in queue threshold of five minutes. |
| Conversations exceeding 5 min handle time | The number of active conversations that are exceeding the handle time threshold of five minutes. |
| Conversation state | The distribution of conversations across open, active, waiting and closed state. |
| Open conversations | The number of work items that are in the open state and that are available to be picked or pushed to an agent. |

## Agent insights

The **Agent insights** section provides information on the latest KPIs, the health of queues, the status of agents on a given day.

The following screen shows an example of the **Agent insights** section.

> [!div class=mx-imgBorder]
> ![Agent insights dashboard](../media/supervisor-agent-insights-dashboard.png "Agent insights dashboard")

This section of the dashboard consists of the following KPIs.

| KPI | Description |
|-------|-------|
| Average handle time per session | The average time that an agent takes to handle a session for conversation. |
| Average response time per session | The average time that an agent takes to accept a conversation from when assigned. |
| Agent sessions abandon rate | The percentage of conversation sessions abandoned by agents due to timed-out or rejected requests. | 
| Agent availability | The distribution of agents by presence status. The presence status of agents can be available, busy, busy-do not disturb, away, offline, or your custom defined status. |
| Sessions abandoned by agents | The number of sessions that are abandoned by agents. | 
| Agents with highest handle time | The list of agents with highest handle time. |
| Total sessions transferred | The number of sessions that are transferred to agents and supervisors, along with the break up between the two. | 
| Average consult time | The average time spent by agents on consultation for other agents or supervisor, across sessions. |
| Conversations per online agent | The average number of conversations that are in active state and being handled by agents. The numbers are shows for online agents (available, busy, and busy DND). | 

## View and filter report

You can filter the information by selecting the Queues that are custom defined for your organization. To view the queues, from the **Omnichannel queues** dropdown, select the queues as required and the information is filtered according to your selection. This helps you in quickly analyzing the KPIs and take necessary steps to improve outcomes.
 
> [!div class=mx-imgBorder]
> ![Queue selection](../media/supervisor-queue-selector.png "Queue selection")


### See also

-  [Introduction to intraday insights dashboard](intro-intraday-insights-dashboard.md)

-  [Ongoing Conversations dashboard](ongoing-conversations-dashboard.md)