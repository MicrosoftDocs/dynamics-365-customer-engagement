---
title: "Omnichannel Intraday insights: Agents insights report for supervisors | MicrosoftDocs"
description: "Learn about the Intraday dashboards: Agents insights report for supervisors in Omnichannel for Customer Service."
ms.date: 08/02/2021
ms.topic: article
author: neeranelli
ms.author: nenellim
manager: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.custom: intro-internal
---

# View and understand the Agents insights report in Omnichannel intraday insights

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

## Introduction

The Omnichannel intraday insights dashboard contains the Agents insights report that helps provide an overview of agent performance.

## The Agents insights report

The **Agents insights** report consists of metrics from an agent’s standpoint. The report shows all-up agent metrics across all channels or channel-wise agent performance. Supervisors can select the **All** tab to view agent performance across all channels, or select the **Live chat**, **Digital messaging**, or **Voice (preview)** tabs to view the agent performance for the corresponding channel. Digital messaging includes all asynchronous channels, like Facebook messenger, Twitter, WeChat, and SMS. The **Duration** option displays report details based on duration and time filter that is applied. The filter can be customized to show report data within the last four, eight, and twelve hours duration.

You can view specific insights about the performance of individual agents or groups of agents, such as their availability, average length of time in conversations, and average response time per session.

> [!div class="mx-imgBorder"]
> ![Agents insights report.](media/agents-insights-report.png "Agents insights report")

> [!div class="mx-imgBorder"]
> ![Agents insights graph.](media/agents-insights-report-slice.png "Agents insights graph")

The agents insights report consists of the following metrics.

| Metrics | Description |
|-------|-------|
| Agents logged in | The number of agents who are signed in.|
| Agents with available capacity | The number of agents who can accept incoming conversation requests as well as their available capacity across all capacity profiles. |
| Average handle time per session | The average time taken by an agent to accept an incoming session after it is assigned. |
| Session reject rate | The percentage of sessions rejected by the agents out of the total sessions assigned to them. |
| Session time out rate | The percentage of sessions that were timed out, out of the total sessions assigned. |
| Session transfer rate | The percentage of sessions that were transferred to another agent or queue. |
| Agent status | The presence status of an agent. |
| Chat status | Available for Live chat. Displays the number of chat conversations that are in the different statuses.|
| Conversation status by channel | Available for the digital messaging channels. The distribution of the different conversations statuses across different channels. |
|Call status| Available for the voice channel (preview). Displays the number of calls that are in the different statuses. |
| Participation mode | The distribution of the sessions across various participation types - Primary indicates the agent who's assigned the session, Consult indicates agents who are engaged in a consulting session and Monitor indicates an ongoing Supervisor's monitor session. |
| Transfer rate by agent | The percentage of sessions transferred by the agent to another agent or queue. |
| Transfer rate by queue | The percentage of sessions within a queue that were transferred to another agent or queue. |
| Consult acceptance rate | The percentage of consult requests accepted by an agent out of the total requests received. |
| Avg. talk time (min)| **For voice channel (Preview)**: The average time an agent spent talking with a customer over a voice call. |
| Avg. hold time (min) | **For voice channel (Preview)**: The average time an agent put a customer on hold over a voice call. |
|||

You can filter on a specific queue or set of queues to view more specific information about an agent or group of agents. You can select the **Status** field to modify the presence indicator for an agent. You can also hover over an agent's name and a pop-up window will appear, showing details such as the agent's presence, current conversations, and the sentiments of those conversations, as well as an agent's available capacity across different capacity profiles. Unit-based capacity is accounted against Unit capacity profile.

The table in the **Agent insights** report displays the following information.

| Agent details | Description |
|-------|-------|
| Agent name | A list of the agent names for the queue. |
| Status | The current presence of the agent: **Available**, **Offline**, **Do not disturb**, or **Busy**. |
| Active | The number of conversations that are active.|
| Waiting | The total number of conversations waiting to be picked up by an agent. |
Wrap-up | The total number of conversations in the wrap-up stage. |
| Closed | The number of conversations that are closed. |
| Avg handle time (min) | The average of an individual agent's handle time in minutes for all closed conversations that the agent is involved in. More information: [Average handle time](intraday-insights-dashboard.md#average-handle-time). |
| Email ID | The email address of the agent handling the conversation. |


> [!div class="mx-imgBorder"]
> ![Agent details.](media/agent-insights-dashboard-table.png "Agent details")

### Agent details

You can also view details about a specific agent by right-clicking the agent's name and then selecting **Drill through** > **Agent details** on the shortcut menu, as shown in the following image.

> [!div class="mx-imgBorder"]
> ![Access details for an agent.](media/intraday-agent-drill-through.png "Access details for an agent")

> [!NOTE]
> The **Drill through** feature isn't supported outside of Omnichannel for Customer Service.

Details about the agent are displayed as shown in the following image.

> [!div class="mx-imgBorder"]
> ![View details for an agent.](media/view-agent-details.png "View details for an agent")

> [!div class="mx-imgBorder"]
> ![Agent profile.](media/view-agent-details-1.png "Agent profile")

This section displays the following details.

| Detail | Description |
|-------|-------|
| Profile | The capacity profiles that are assigned to an agent. If a profile is force assigned, it is displayed in red. |
| Total capacity | The total capacity as configured in the profile. |
| Available capacity | The current available capacity. Available capacity can be displayed as negative due to supervisor assigns. |
| Status | The agent's current presence : **Available**, **Offline**, **Do not disturb**, or **Busy**. |
| Status since | The amount of time that the agent's presence has been in its current state. |
| Logged in duration 24 hrs | The total duration for which the agent has been signed in during the past 24 hours.|
| Logged off duration 24 hrs | The total duration for which the agent has been signed out during the past 24 hours. |
| Logged in duration 12 hrs | The total duration for which the agent has been signed in during the past 12 hours.|
| Logged off duration 12 hrs | The total duration for which the agent has been signed out during the past 12 hours. |
| Queues | The queues that the agent is mapped to. |
| Skills | The skills that are assigned to the agent.|
| Conversation status reason | The status of the latest conversation between the agent and a customer. | 
| Avg handle time per session | The average handle time for an agent is calculated based on the active time the agent spends in a session from the time the conversation is active until it's closed. This includes the time the agent takes to wrap up the conversation. More information: [Average handle time](intraday-insights-dashboard.md#average-handle-time). |
| Logged in states duration | The agent's presence when the agent is signed in.|
| Subject | For an identified customer, the customer's name is displayed with the subject. For unidentified customers, static text is displayed with the label **Visitor**. More information: [Automatically identify customers](record-identification-rule.md). |
| Participation mode | **Primary** indicates that the agent is engaged in a session. **Consult** means that the agent is engaged in a consulting session with another agent. **Monitor** means that this agent is monitoring the session. |
| Work stream | The work stream that the conversation is assigned to. |
| Channel | The channel that the conversation was created from. |
| Queue | The queue that the conversation is currently part of. |
| Status reason | The current conversation status. |
| Customer sentiment | The current sentiment. |
| Created on | The conversation creation time. |
| Capacity and status timeline | Every change in capacity or status is plotted on the timeline. Negative capacity is displayed if a supervisor assigns a conversation to an agent that's beyond the agent's available capacity. |
|||


### See also

[Introduction to intraday insights dashboard](intro-intraday-insights-dashboard.md)  
[Intraday insights dashboard](intraday-insights-dashboard.md)  
[View and understand conversation insights](intraday-conversation-insights.md)  
[View and understand Ongoing Conversations dashboard](ongoing-conversations-dashboard.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
