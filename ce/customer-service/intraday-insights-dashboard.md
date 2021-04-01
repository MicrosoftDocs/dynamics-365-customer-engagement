---
title: "Intraday insights dashboard for supervisor | MicrosoftDocs"
description: "Learn about the intraday insights dashboard for supervisors"
author: Meghanalanka
feedback_product_url: https://experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.author: v-mlanka
manager: shujoshi
ms.date: 04/01/2020
ms.topic: article
ms.service: dynamics-365-customerservice
---

# View and understand Omnichannel intraday insights dashboard

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The Omnichannel intraday insights dashboard provides information about the health and key performance indicators (KPIs) for your organization. Intraday Monitoring allows you to see a summary of the conversation and insights reports. From the Omnichannel intraday insights report, you can view a summary of the two sections:

- [Conversations insights](#conversations-insights)
- [Agent insights](#agent-insights)

The information displayed in these sections are displayed based on the conversations closed in the last 24 hours and is refreshed every 15 minutes.


> [!IMPORTANT]
> Best practices should be followed to ensure that metrics displayed on the dashboard are not adversely affected. To learn more, see [Best practices to use Omnichannel for Customer Service](best-practices.md).

## Conversations insights

The **Conversations insights** section provides insights on conversation requests that are generated in the past 24 hours with KPIs such as state of conversations and number of conversations.

The following screenshot is an example of the **Conversations insights** section.

> [!div class=mx-imgBorder]
> THIS SCREENSHOT NEEDS TO BE ADDED

This section of the dashboard consists of the following KPIs.

| KPI | Description |
|-------|-------|
| Inbound | Number of conversations that happened in the last 24 hours. |
| Ongoing | The number of conversations that are ongoing. |
| Waiting in queue | The number of conversations that are waiting in the queue and are ready to be picked up by an agent. |
| Closed | The number of conversations that are closed. |
| Abandoned | Conversations that have been abandoned by the customer. |
| Longest wait time | The longest time that the conversation was in queue. |

You can also view a report on the average conversation handle time, average wait time, transfer rate and more. The report can also be filtered to display an in-depth analysis of each chat channel that conversations have come in from.


### Ongoing conversations

The ongoing conversations section provides information on the status of the conversation, wait time and also allows you to assign the conversations to agents based on their status and capacity. You can also reassign the conversation to a different queue using the ongoing conversations report. The ongoing conversation report also displays information of the channel through which the conversation came in, along with the time and date that the conversation was picked up on. 

### Assign a conversation

A conversation can be assigned to another agent or can be routed to another queue through the ongoing conversations report. Select the **Assign** option in the **Action** column in the report. Select an available agent and then **Assign**.If no agent is available, you can move the conversation to another queue and check if an agent is available. After an agent is assigned, the action is changed to **Monitor**.

> [!NOTE]
> Conversations can be assigned in every state except when they are in the closed state. 


## Agent insights

The **Agent insights** section provides information on the latest KPIs, the health of queues, the status of agents on a given day. The agent insights dashboard provides a consolidated report of conversations in both Live chats and Digital messaging platforms.

An example of the **Agent insights** section is as follows.

> [!div class=mx-imgBorder]
> THIS SCREENSHOT NEEDS TO BE ADDED

This section of the dashboard consists of the following KPIs.

| KPI | Description |
|-------|-------|
| Agents logged in | The number of agents that are logged in.|
| Agents with available capacity | The number of agents who have the capacity to accept incoming conversation requests. |
| Average handle time per session | The average time that an agent takes to accept a conversation and resolve it. |
| Sessions rejected | The number of conversation sessions rejected by agents due to the lack of capacity. |
| Sessions timed-out | The number of sessions that were timed-out. |
| Sessions transferred | The number of sessions that were transferred to another agent or queue.

You can view specific insights about the performance of individual or groups of agents, such as their availability, average length of time in conversations, and average response time per session.

You can filter on a specific queue or set of queues to view more specific information about an agent or group of agents, and if needed, modify their presence. You can also hover over an agent’s name and a pop-up dialog will display, showing details such as the agent’s presence, their current conversations, and the sentiments of those conversations.

The following screen shows the options for viewing agent information in a specific set of queues.

> [!div class=mx-imgBorder]
> ![View agent information](media/view-agent-info-queues.png "View agent information")

The **Agents insights** table displays the following information.

| KPI | Description |
|-------|-------|
| Agent name | A list of the agent names for the queue. |
| Status | The current presence of the agent: available, offline, do not disturb, or busy. |
| Active | The number of conversations in the active state.|
| Waiting | The total number of conversations waiting to be picked up by an agent. |
| Closed | All the conversations that are closed. |
| Avg handle time (min) | The average of an individual agent's handle time in minutes for all closed conversations that the agent is involved in. More information: [Average handle time](#average-handle-time). |
| Email ID | The email address of the agent handling the conversation. |
|||

You can also view specific details about an agent by right-clicking the agent's name, and then selecting **Drill through** > **Agent details**, as shown on the following screen.

> [!div class=mx-imgBorder]
> ![Access agent's specific details](media/intraday-agent-drill-through.png "Access specific details for an agent")

The agent's details are displayed, as shown on the following screen.

> [!div class=mx-imgBorder]
> ![View agent's specific details](media/view-agent-details.png "View agent's specific details")

This section of the dashboard consists of the following details:

| Detail | Description |
|-------|-------|
| Status | The agent's current presence: available, offline, do not disturb, or busy. |
| Status since | The amount of time that this agent has been in their current presence. |
| Available capacity | The agent's current free capacity. |
| Total capacity | The total capacity configured for an agent. |
| Logged in duration 24 hrs | The total duration for which the agent had been logged in during the past 24 hours.|
|Logged off duration 24 hrs | The total duration for which the agent had been logged out during the past 24 hours. |
| Logged in duration 12 hrs | The total duration for which the agent had been logged in during the past 12 hours.|
|Logged off duration 12 hrs | The total duration for which the agent had been logged out during the past 12 hours. |
| Queues | The queues that the agent is mapped to. |
| Skills | The skills that are assigned to the agent.|
| Conversation status reason | The status of the latest conversation between the agent and a customer. | 
| Avg handle time per session | The average handle time for an agent is calculated based on the active time the agent spends in a session from the time the conversation is active till it is closed and includes the time the agents takes to wrap-up. More information: [Average handle time](#average-handle-time). |
| Logged in states duration | The agent's presence when the agent is logged on. The state reflects the base presence and not the custom presence.|
| Subject | For an identified customer, the customer's name is displayed with the subject. For unidentified customers, static text is displayed with a "Visitor" label. For information about identified customers, see [Automatically identify customers](record-identification-rule.md). |
| Participation mode | Primary indicates that agent is engaged in a session. Consult means the agent is engaged in a consulting session with another agent. Monitor means this agent is monitoring the session. |
| Workstream | The work stream that the conversation is assigned to. |
| Channel | The channel that the conversation was created from. |
| Queue | The queue that the conversation is currently part of. |
| Status reason | The current conversation status. |
| Customer sentiment | The current sentiment. |
| Created on | The conversation creation time. |
| Capacity and status timeline | Every change in capacity or status is plotted on the timeline. Negative capacity is displayed if a supervisor assigns a conversation to an agent that is beyond the agent's available capacity. |
|||

## View and filter report

You can filter the information by selecting the Queues that are custom defined for your organization. To view the queues, from the **Omnichannel queues** dropdown, select the queues as required and the information is filtered according to your selection. This helps you in quickly analyzing the KPIs and take necessary steps to improve outcomes.
 
> [!div class=mx-imgBorder]
> ![Queue selection](media/supervisor-queue-selector.png "Queue selection")

## Average handle time

The average handle time for an agent is calculated based on the active time the agent spends in a session from the time the conversation is active till it is closed and includes the time the agents takes to wrap-up. When agents are concurrently handling multiple customers, and switch sessions, the active time for the previous session is paused and the active time for the current session resumes.

If the agent spends time in providing consultation, it is included in the agent's average handle time. Similarly, for supervisors, the monitor time is included in the supervisor's average handle time.

The average handle time for a conversation is defined as the cumulative handle times of its individual sessions. The session handle times take into account only the active time of agents.

In a transfer scenario, the active time spent by all agents who are involved is summed up to compute the handle time for the conversation.

The average handle time will be accurately calculated if you ensure the following:

- Agents close the sessions by selecting the close button at the end of their shift. More information: [Conversation in waiting status](oc-conversation-state.md).
- Agents don't change the computer time.
- Agents don't use incognito mode in Google Chrome or private browsing in Microsoft Edge.

When the agent steps away from the desk during the ongoing session and does not interact with the customer, the system takes into account this time as active and subsequently computes a higher value handle time. For a realistic reporting on the active time that agents spend in the session, you can configure the idle time threshold. If no agent activity is detected after the idle time threshold is reached, the handle time computation is paused. The computation resumes if any mouse, touch, or keyboard activity is detected. By default, idle time is not enabled out of the box. To set up the idle time threshold, see [Set the idle time threshold](set-idle-time-threshold.md).

### See also

[Introduction to intraday insights dashboard](intro-intraday-insights-dashboard.md)  
[View and understand Ongoing Conversations dashboard](ongoing-conversations-dashboard.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]