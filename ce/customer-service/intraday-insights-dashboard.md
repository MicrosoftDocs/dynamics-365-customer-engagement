---
title: "Intraday insights dashboard for supervisors in Omnichannel for Customer Service | MicrosoftDocs"
description: "Learn about the intraday insights dashboard for supervisors"
author: Meghanalanka
feedback_product_url: https://experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.author: v-mlanka
manager: shujoshi
ms.date: 05/07/2021
ms.topic: article
ms.service: dynamics-365-customerservice
---

# View and understand Omnichannel intraday insights dashboards 

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

The **Omnichannel intraday insights** dashboards provide information about the health and key performance indicators (KPIs) for your organization. From the Omnichannel intraday insights report, you can view a summary of the following sections.

- [Conversations insights](#conversations-insights)
- [Agent insights](#agent-insights)

The information displayed in these sections is based on the conversations that are currently not closed or have been closed within the last 24 hours. The report fetches the latest data and is generated in real time when a supervisor accesses it. If the report in a customer configured workspace is kept open, it's automatically refreshed after 15 minutes. In a pre-configured Power BI workspace the report auto refreshes after every 5 minutes. 

> [!IMPORTANT]
> To help ensure that the most accurate and up-to-date data is displayed on the dashboard, be sure to follow [best practices for using Omnichannel for Customer Service](best-practices.md).

## Omnichannel intraday insights dashboard

The **Omnichannel intraday insights** tab provides information on conversations insights, agent insights and their performance.


### Conversations insights

The **Conversations insights** section provides insights about conversation requests with KPIs such as the number and state of the conversations. The following image shows an example of the **Conversations insights** section of the Omnichannel intraday insights report.

> [!div class="mx-imgBorder"]
> ![Conversation Insights](media/conversation-insights.png "Conversation Insights")

This section of the dashboard displays the following KPIs about conversations.


| Metric | Description |
|-------|-------|
| Average wait time per conversation | For a conversation, wait time is defined as the cumulative wait time of its individual sessions. This KPI is calculated as an average that considers only closed conversations. Session wait time is defined as the elapsed time between the creation of a session and the time that an agent is assigned. This metric is also displayed on a per-queue basis. |
| Exceeding 5 mins wait time | The number of conversations that are open and have exceeded the threshold wait time of five minutes. This metric is also displayed on a per-queue basis. |
| Exceeding 5 mins wrap time | The number of conversations that are open and have exceeded the threshold wrap time of five minutes. |
| Abandon rate | The percentage of conversations abandoned by customers before connecting to an agent. | 
| Average handle time per conversation | For a conversation, the handle time used to calculate the average is defined as the cumulative handle time of its individual sessions. *Session handle time* is defined as the elapsed time between the creation of a session and the time that it's closed. Average handle time is also displayed on a per-queue basis. More information: [Average handle time](#average-handle-time)|
| Exceeding 5 mins handle time | The number of active conversations that are exceeding the handle time threshold of five minutes. This metric is also displayed on a per-queue basis. |
| Conversation status | The distribution of the status of conversations across **Open**, **Active**, **Waiting**, **Wrap up**, and **Closed**. |
| Conversation status by queue | The distribution of the status of conversations across different queues. |
| Transfer/Escalation rate by queue | The transfer rate is the percentage of conversations in a queue that was transferred atleast once. Escalation rate is the percentage of conversations within a queue that was escalated to a supervisor |
| Abandon rate by queue | The rate of conversations that have been abandoned by customers. |


### Agent insights

The **Agent insights** section provides information about the latest KPIs, the health of the queues, and the status of agents on a given day. The agent insights section consolidates conversations in both live chat and digital messaging platforms. An example of the **Agent insights** section is shown in the following image.

> [!div class="mx-imgBorder"]
> ![Agent Insights](media/agent-insights.png "Agent Insights")



This section consists of the following performance indicators.

| Metric | Description |
| ------------ | --------------- |
| Agents logged in | The number of agents who are signed in.|
| Average handle time per session | The average time that an agent takes to accept a conversation and resolve it |
| Average session acceptance time | The average time an agent takes to accept an incoming conversation |
| Session rejection rate | The percentage of sessions rejected by the agents out of the total sessions assigned to them |
| Session time out rate | The rate of sessions that were timed out |
| Sessions rejected by agents | The percentage of sessions rejected out of the total sessions assigned per agent |
| Sessions timed out | The rate of sessions that were timed out per agent |
| Conversations per online agent | The number of conversations that are handled by each agent |
| Agent availability | The distribution of agents presence |
| Agents with longest handle time | The number of agents with the longest time to accept a conversation and resolve it |
| Total sessions transferred | The number of sessions that were transferred to other agents or supervisors |
| Average consult time | The average time spent by agents consulting with other agents or supervisors |


## Agents Insights report

The agent insights report consists of the following metrics.

> [!div class="mx-imgBorder"]
> ![Agents insights dashboard](media/agents-insights-dashboard.png "Agents insights dashboard")

> [!div class="mx-imgBorder"]
> ![Agents insights dashboard](media/agents-insights-dashboard-1.png "Agents insights dashboard")

| Metrics | Description |
|-------|-------|
| Agents logged in | The number of agents who are signed in.|
| Agents with available capacity | The number of agents who have the capacity to accept incoming conversation requests as well as the available capacity across all capacity profiles. |
| Average handle time per session | The average time taken by an agent to accept an incoming session after it is assigned |
| Session reject rate | The rate of conversation sessions rejected by agents due to lack of capacity. |
| Session time out rate | The percentage of sessions that were timed out, out of the total sessions assigned. |
| Session transfer rate | The percentage of sessions that were transferred to another agent or queue. |
| Agent status | The presence status of an agent |
| Conversation status by channel | The distribution of the different conversations statuses across different channels. |
| Participation mode | The distribution of the sessions across various participation types - Primary indicates the agent who's assigned the session, Consult indicates agents who are engaged in a consulting session and Monitor indicates an ongoing Supervisors monitor session |
| Transfer rate by agent | The percentage of sessions transferred by the agent to another agent or queue |
| Transfer rate by queue | The percentage of sessions within a queue that were transferred to another agent or queue |
| Consult acceptance rate | The percentage of consult requests accepted by an agent out of the total requests received | 

You can view specific insights about the performance of individual agents or groups of agents, such as their availability, average length of time in conversations, and average response time per session.

You can filter on a specific queue or set of queues to view more specific information about an agent or group of agents. You can select the **Status** field to modify the presence indicator for an agent. You can also hover over an agent's name and a pop-up window will appear, showing details such as the agent's presence, current conversations, and the sentiments of those conversations as well as an agent's available capacity across different capacity profiles. Unit based capacity is accounted against Unit capacity profile.

The **Agent insights** table displays the following information.

| Agent details | Description |
|-------|-------|
| Agent name | A list of the agent names for the queue. |
| Status | The current presence of the agent: **Available**, **Offline**, **Do not disturb**, or **Busy**. |
| Active | The number of conversations that are active.|
| Waiting | The total number of conversations waiting to be picked up by an agent. |
Wrap-up | The total number of conversations in the wrap-up stage. |
| Closed | The number of conversations that are closed. |
| Avg handle time (min) | The average of an individual agent's handle time in minutes for all closed conversations that the agent is involved in. More information: [Average handle time](#average-handle-time). |
| Email ID | The email address of the agent handling the conversation. |


> [!div class="mx-imgBorder"]
> ![Agent details](media/agent-insights-dashboard-table.png "Agent details")

You can also view details about a specific agent by right-clicking the agent's name and then selecting **Drill through** > **Agent details** on the shortcut menu, as shown in the following image.

> [!div class="mx-imgBorder"]
> ![Access details for an agent](media/intraday-agent-drill-through.png "Access details for an agent")

> [!NOTE]
> The **Drill through** feature isn't supported outside of Omnichannel for Customer Service.

Details about the agent are displayed as shown in the following image.

> [!div class="mx-imgBorder"]
> ![View details for an agent](media/view-agent-details.png "View details for an agent")

> [!div class="mx-imgBorder"]
> ![View details for an agent](media/view-agent-details-1.png "View details for an agent")

This section displays the following details.

| Detail | Description |
|-------|-------|
| Profile | The capacity profiles that are assigned to an agent. If a profile is force assigned it is displayed in red |
| Total capacity | The total capacity as configured in the profile |
| Available capacity | The current available capacity.  Available capacity can be displayed as negative due to supervisor assigns |
| Status | The agent's current presence : **Available**, **Offline**, **Do not disturb**, or **Busy**. |
| Status since | The amount of time that the agent's presence has been in its current state. |
| Logged in duration 24 hrs | The total duration for which the agent has been signed in during the past 24 hours.|
| Logged off duration 24 hrs | The total duration for which the agent has been signed out during the past 24 hours. |
| Logged in duration 12 hrs | The total duration for which the agent has been signed in during the past 12 hours.|
| Logged off duration 12 hrs | The total duration for which the agent has been signed out during the past 12 hours. |
| Queues | The queues that the agent is mapped to. |
| Skills | The skills that are assigned to the agent.|
| Conversation status reason | The status of the latest conversation between the agent and a customer. | 
| Avg handle time per session | The average handle time for an agent is calculated based on the active time the agent spends in a session from the time the conversation is active until it's closed. This includes the time the agent takes to wrap up the conversation. More information: [Average handle time](#average-handle-time) |
| Logged in states duration | The agent's presence when the agent is signed in.|
| Subject | For an identified customer, the customer's name is displayed with the subject. For unidentified customers, static text is displayed with the label **Visitor**. More information: [Automatically identify customers](record-identification-rule.md) |
| Participation mode | **Primary** indicates that the agent is engaged in a session. **Consult** means that the agent is engaged in a consulting session with another agent. **Monitor** means that this agent is monitoring the session. |
| Work stream | The work stream that the conversation is assigned to. |
| Channel | The channel that the conversation was created from. |
| Queue | The queue that the conversation is currently part of. |
| Status reason | The current conversation status. |
| Customer sentiment | The current sentiment. |
| Created on | The conversation creation time. |
| Capacity and status timeline | Every change in capacity or status is plotted on the timeline. Negative capacity is displayed if a supervisor assigns a conversation to an agent that's beyond the agent's available capacity. |


## Conversation insights report

This section of the dashboard displays the following metrics about conversations.

> [!div class="mx-imgBorder"]
> ![Conversation insights dashboard](media/conversation-insights-dashboard.png "Agents insights dashboard")

| Metric | Description |
|-------|-------|
| Inbound | The number of conversations created in the last 24 hours. |
| Ongoing |The number of conversations in Active, Waiting and Wrap-up statuses |
| Waiting in queue | The number of conversations that are waiting in the queue and are ready to be picked up by an agent |
| Closed | The number of conversations closed in the last 24 hours |
| Longest wait time | The longest time that a conversation is in queue waiting to be picked up by an agent |
| Average conversation handle time | For a conversation, the handle time used to calculate the average is defined as the cumulative handle time of its individual sessions. *Session handle time* is defined as the elapsed time between the creation of a session and the time that it's closed. More information: [Average handle time](#average-handle-time) |
| Average wait time (min) | For a conversation, wait time is defined as the cumulative wait time of its individual sessions. This KPI is calculated as an average that considers only closed conversations. Session wait time is defined as the elapsed time between the creation of a session and the time that an agent is assigned |
| Average wrap time (min) | The average time of conversations that are in the wrap up stage. |
| Conversation status | The distribution of the status of conversations across **Open**, **Active**, **Waiting**, **Wrap up**, and **Closed** |
| Abandon rate | The percentage of conversations abandoned by customers before connecting to an agent |
| Transfer rate by queue | The percentage of sessions within a queue that were transferred to another agent or queue |

You can also view a report on the average conversation handle time, average wait time, transfer rate, and more. The report can be filtered to display an in-depth analysis of each chat channel through which conversations have come in.

### Ongoing conversations

The **Ongoing conversations** section provides information about the status of the conversation and its wait time, and is also where you can assign the conversation to agents based on their status and capacity. You can reassign the conversation to a different queue by using the ongoing conversations report. This report also displays information about the channel through which the conversation came in, along with the time and date that the conversation was picked up.

> [!div class="mx-imgBorder"]
> ![Ongoing conversations](media/ongoing-conversations.png "Ongoing conversations")

The **Ongoing conversations** table displays the following metrics.

| Title | The title of the case |
|------------ | --------------- |
| Agent | Name of the agent |
| Status | The status of the conversation |
| Action | The action that can be taken on the conversation |
| Queue | The name of the queue that the conversation is a part of |
| Channel | The name of the channel that the conversation came through |
| Wait time (min) | Total wait time of the conversation |
| Handle time (min) | Total time taken to accept and close the conversation |
| Wrap time (min) | Total time in which the conversation was in the wrap stage |
| Sentiment | The real-time sentiment analysis |
| Created on | The date on which the conversation was created on |
| Conversation ID | The conversation's ID |

The **Closed conversations** table provides information related to all the conversations that have been closed.

You can also assign a conversation to an agent or route it to another queue. More information: [Monitor and assign conversations](monitor-conversations.md#assign-conversations).


## View and filter reports

You can filter information by selecting the queues that have been defined for your organization. From the **Omnichannel queues** drop-down list, select the queues you want, and the information will be filtered according to your selection. This helps you quickly analyze the KPIs and take any necessary steps to improve outcomes.

> [!div class="mx-imgBorder"]
> ![Queue selection](media/supervisor-queue-selector.png "Queue selection")

## Average handle time

The average handle time for a conversation is defined as the cumulative handle times of its individual sessions. The session handle times take into account only the active time of agents. The average handle time for an agent is calculated based on the active time the agent spends in a session from the time the conversation is active until it's closed. This includes the time the agent takes to wrap up the conversation. When an agent concurrently handles multiple customers and switches sessions, the active time for the previous session is paused and the active time for the current session resumes. 

If the agent spends time providing consultation, it's included in the agent's average handle time. Similarly, for supervisors, the monitor time is included in the supervisor's average handle time.
When a conversation is transferred, the active time spent by all agents who are involved is summed up to compute the handle time for the conversation.

Average handle time will be accurately calculated if you ensure the following:

- Agents close the sessions by selecting the **Close** button at the end of their shift. More information: [Conversation in waiting status](oc-conversation-state.md).
- Agents don't change the computer time.
- Agents don't use incognito mode in Google Chrome or private browsing in Microsoft Edge.

When an agent steps away from the desk during an ongoing session and doesn't interact with the customer, the system counts this time as active and subsequently computes a higher value for the handle time. For a more realistic report of the active time that agents spend in the session, you can configure the idle time threshold. If no agent activity is detected after the idle time threshold is reached, the handle time computation is paused. The computation resumes if any mouse, touch, or keyboard activity is detected. By default, the idle time threshold isn't enabled out of the box. More information: [Set the idle time threshold](set-idle-time-threshold.md).

### See also

[Introduction to intraday insights dashboard](intro-intraday-insights-dashboard.md)  
[View and understand Ongoing Conversations dashboard](ongoing-conversations-dashboard.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]