---
title: "Intraday insights dashboard for supervisor | MicrosoftDocs"
description: "Learn about the intraday insights dashboard for supervisors"
author: lalexms
ms.author: laalexan
manager: shujoshi
ms.date: 10/12/2020
ms.service: 
  "dynamics-365-customerservice"
ms.topic: article
---

# View and understand Omnichannel intraday insights dashboard

[!INCLUDE[cc-use-with-omnichannel](../../includes/cc-use-with-omnichannel.md)]

The Omnichannel intraday insights dashboard provides information about the health and key performance indicators (KPIs) for your organization. This dashboard consists of two sections:

-	[Conversations insights](#conversations-insights)
-	[Agent insights](#agent-insights)

The information displayed in these sections are displayed based on the conversations closed in the last 24 hours and refreshes every 15 minutes.


> [!IMPORTANT]
> Best practices should be followed to ensure that metrics displayed on the dashboard are not adversely affected. To learn more, see [Best practices to use Omnichannel for Customer Service](../best-practices.md).


## Conversations insights

The **Conversations insights** section provides insights on conversation requests that are generated in the past 24 hours with KPIs such as state of conversations and number of conversations.

The following screen is an example of the **Conversations insights** section.

> [!div class=mx-imgBorder]
> ![Conversations insights dashboard](../media/supervisor-conversations-insights-dashboard.png "Conversations insights dashboard")

This section of the dashboard consists of the following KPIs.

| KPI | Description |
|-------|-------|
| Average wait time per conversation | For a conversation, its wait time is defined as the cumulative wait times of its individual sessions. This KPI is calculated as an average that considers only closed conversations. Session wait time is defined as the elapsed time between the session's creation and the time an agent is assigned. |
| Exceeding 5 mins wait time | The number of conversations that are in an open state and have exceeded the time in the queue threshold of 5 minutes. |
| Average handle time per conversation | For a conversation, its handle time is defined as the cumulative handle times of its individual sessions. This KPI is calculated as an average that considers only closed conversations. Session handle time is defined as the elapsed time between the session's creation and the time it is closed. |
| Exceeding 5 mins handle time | The number of active conversations that are exceeding the handle time threshold of five minutes. |
| Conversation by status | The distribution of conversations across open, active, waiting, wrap up, and closed state. |
| Open conversations | The distribution of open conversations in pick mode and push mode respectively. |

## Agent insights

The **Agent insights** section provides information on the latest KPIs, the health of queues, the status of agents on a given day.

The following screen shows an example of the **Agent insights** section.

> [!div class=mx-imgBorder]
> ![Agent insights dashboard](../media/supervisor-agent-insights-dashboard.png "Agent insights dashboard")

This section of the dashboard consists of the following KPIs.

| KPI | Description |
|-------|-------|
| Agent availability | The distribution of agents by presence status. The presence status of agents can be available, busy, busy-do not disturb, away, offline, or your custom defined status. |
| Average handle time per session | The average time that an agent takes to handle a session for conversation. |
| Average response time per session | The average time that an agent takes to accept a conversation from when assigned. |
| Agent sessions abandon rate | The percentage of conversation sessions abandoned by agents due to timed-out or rejected requests. |
| Agents with longest handle time | The list of agents with highest handle time. |
| Sessions abandoned by agents | The number of sessions that are abandoned by agents. |
| Total sessions transferred | The number of sessions that are transferred to agents and supervisors, along with the break up between the two. |
| Average consult time | The average time spent by agents on consultation for other agents or supervisor, across sessions. |
| Conversations per online agent | The average number of active conversations and being handled by agents whose status is currently available, busy or busy-do not disturb. |
|||

### Agent Performance

You can view specific insights about the performance of individual or groups of agents, such as their availability, average length of time in conversations, and average response time per session.

The following screen shows an example of the specific queue for a group of agents.
 
> [!div class=mx-imgBorder]
> ![Agent queue](../media/agent-queue-details.png "Agent queue")

This section of the dashboard consists of the following KPIs.

| KPI | Description |
|-------|-------|
| Agent status | The availability status of the agent. |
| Conversation status reason | The status of the latest conversation between the agent and a customer. | 
| Avg handle time per session | The agent’s average amount of time per session. |
| Avg response time per session | The agent’s average amount of response time. | 
| Participation mode | The split of sessions which are of three types: Primary indicates the agent who's assigned to the session, Consult indicates agents who are engaged in a consulting session, and supervisors who are monitoring are treated as Monitor sessions. |

You can filter on a specific queue or set of queues to view more specific information about an agent or group of agents, and if needed, modify their presence. You can also hover over an agent’s name and a pop-up dialog will display, showing details such as the agent’s presence, their current conversations, and the sentiments of those conversations.

The following screen shows the options for viewing agent information in a specific set of queues.

> [!div class=mx-imgBorder]
> ![View agent information](../media/view-agent-info-queues.png "View agent information")

This section of the dashboard consists of the following KPIs:

| KPI | Description |
|-------|-------|
| Agent name | A list of the agent names for the queue. |
| Status | The current presence of the agent: available, offline, do not disturb, or busy. |
| Available capacity | The current free capacity with the agent. |
| Total capacity | The total capacity configured for an agent. |
| Ongoing Conversations | All the conversations that are currently in active, waiting or wrap-up states. |
| Avg handle time (min) | The average of an individual agent's handle time in minutes for all closed conversations that the agent is involved in. |

You can also view specific details about an agent by right-clicking the agent's name, and then selecting **Drill through** > **Agent details**, as shown on the following screen.

> [!div class=mx-imgBorder]
> ![Access agent's specific details](../media/intraday-agent-drill-through.png "Access specific details for an agent")

The agent's details are displayed, as shown on the following screen.

> [!div class=mx-imgBorder]
> ![View agent's specific details](../media/view-agent-details.png "View agent's specific details")

This section of the dashboard consists of the following details:

| Detail | Description |
|-------|-------|
| Email ID | The email address of the agent. |
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
| Avg handle time per session | The agent’s average amount of time per session. |
| Logged in states duration | The agent's presence when the agent is logged on. The state reflects the base presence and not the custom presence.|
| Subject | For an identified customer, the customer's name is displayed with the subject. For unidentified customers, static text is displayed with a "Visitor" label. For information about identified customers, see [Automatically identify customers](../administrator/record-identification-rule.md). |
| Participation mode | Primary indicates that agent is engaged in a session. Consult means the agent is engaged in a consulting session with another agent. Monitor means this agent is monitoring the session. |
| Workstream | The workstream that the conversation is assigned to. |
| Channel | The channel that the conversation was created from. |
| Queue | The queue that the conversation is currently part of. |
| State | The current conversation state. |
| Customer sentiment | The current sentiment. |
| Created on | The conversation creation time. |
| Capacity and status timeline | Every change in capacity or status is plotted on the timeline. Negative capacity is displayed if a supervisor assigns a conversation to an agent that is beyond the agent's available capacity. |

## View and filter report

You can filter the information by selecting the Queues that are custom defined for your organization. To view the queues, from the **Omnichannel queues** dropdown, select the queues as required and the information is filtered according to your selection. This helps you in quickly analyzing the KPIs and take necessary steps to improve outcomes.
 
> [!div class=mx-imgBorder]
> ![Queue selection](../media/supervisor-queue-selector.png "Queue selection")



### See also

[Introduction to intraday insights dashboard](intro-intraday-insights-dashboard.md)  
[View and understand Ongoing Conversations dashboard](ongoing-conversations-dashboard.md)  
