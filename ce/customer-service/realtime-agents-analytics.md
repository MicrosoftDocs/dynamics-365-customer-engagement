---
title: "Omnichannel real-time analytics agents insights report for supervisors | MicrosoftDocs"
description: "Learn about the real-time agents insights report for supervisors in Omnichannel for Customer Service."
ms.date: 10/21/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
feedback_product_url: https //experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.custom: intro-internal
---

# View and understand the Agents report in Omnichannel real time analytics (preview)

[!INCLUDE[cc-use-with-omnichannel](../includes/cc-use-with-omnichannel.md)]

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

The Omnichannel real time insights dashboard contains the Agents insights report that helps provide an overview of agent performance for the last 24hrs.

## The Agents insights report

The **Agents insights** report consists of metrics from an agent’s standpoint. The report shows agent metrics across all channels or channel-wise agent performance. Supervisors can select the **All** filter to view agent performance across all channels. You can also filter areas by time, queue, time zone, or conversation status. More information: [Overview of Omnichannel Real-time analytics dashboards (preview)](intro-realtime-analytics-dashboard.md#overview-of-omnichannel-real-time-analytics-dashboards-preview)[Overview of Omnichannel Real-time analytics dashboards (preview)](intro-realtime-analytics-dashboard.md#overview-of-omnichannel-real-time-analytics-dashboards-preview)

**Need screenshot for Agent dashboard**

The agents insights report consists of the following metrics.

| Metric | Description |
|-------|-------|
| Agents logged in | The number of agents who are signed in.|
| Session rejection rate | The percentage of sessions rejected by the agents out of the total sessions assigned to them. |
| Session timeout rate | The percentage of sessions that were timed out, out of the total sessions assigned. |
| Avg. session handle time| Average time an agent spent actively with a customer. Avg. handle time is derived by aggregating active session time across a conversation. This includes hold time (if applicable), Wrap time (if applicable) and talk time (if applicable), active time. |
Required capacity unit for current waiting conversation| |
|

The following charts are displayed in the Summary report. When you select the individual components on the chart, data gets filtered accordingly and you'll be able to view data related to the selected component.

**Need screenshot** 

| Title | Description |
| ------- | ------------------ |
| Agent availability status| Total number of agents in Available, Busy, Do not disturb and Appear away statuses |
| Capacity by unit| Total number of agents in Available, Occupied status |
| Session participation mode| The distribution of the sessions across various participation types - Primary indicates the agent who's assigned the session, Consult indicates agents who are engaged in a consulting session and Monitor indicates an ongoing Supervisor's monitor session. |

The **Agent list** table in the **Agent** report displays the following information.

**(Need screenshot for Agent list screen)**

| Agent details | Description |
|-------|-------|
| Agent | A list of the agent names for the queue. |
| Status | The current presence of the agent: **Available**, **Offline**, **Do not disturb**, or **Busy**. |
| Status since | Time since the status was set  |
| Active sessions | The number of conversations that are active.|
| Wrap-up sessions | The total number of conversations in the wrap-up stage. |
| Closed | The number of conversations that are closed. |
| Avg. handle time | The average of an individual agent's handle time in minutes for all closed conversations that the agent is involved in. More information: [Average handle time](intraday-insights-dashboard.md#average-handle-time). |
| Session rejection rate | The percentage of sessions rejected by the agents out of the total sessions assigned to them. |
| Session timeout rate | The percentage of sessions that were timed out, out of the total sessions assigned. |
|DomainName| |
|||


### Agent details

You can also drill down to view specific insights about the performance of individual agents by selecting the agent name and then the **Detail** option.

**Need screenshot**

Details about the agent are displayed as shown in the following image.

**(Need agent details screenshot)**

| Metrics | Description |
|-------|-------|
| Status | The agent's current presence : **Available**, **Offline**, **Do not disturb**, or **Busy**. |
| Units available | The current available capacity. Available capacity can be displayed as negative due to supervisor assigns. |
| Units occupied |  |
| Profiles available |  |
| Profiles occupied |  |
| Engaged Sessions | The number of sessions presented to an agent and accepted by an agent  |
| Transfer rate  | The percentage of conversations that were transferred by the agent to another agent/queue. |
| Session rejection rate  | The percentage of sessions presented to an agent but rejected by the agent |
|Session time out rate | The percentage of sessions presented to an agent but ended before the agent responded  |
| Average session handle time  | The average handle time per session is calculated as the average of all the handle times of the sessions handled by the agent. The session handle time is the total duration an agent spent on the session when it is in focus in the session panel until an agent closes the session. The handle time is paused when the agent switches to another session and is resumed when the agent returns to the session. This includes the time the agent takes to wrap up the conversation. More information: Average handle time.  |

**Conversations**

| Metrics | Description |
|-------|-------|
|Subject  | Conversation subject. For an identified customer, the customer's name is displayed with the subject. For unidentified customers, static text is displayed with the label Visitor. More information: Automatically identify customers. |
|Handle time  | Time from the session start to session end  |
| Channel| The channel that the conversation was created from.  |
| Queue | The queue that the conversation is currently part of.  |
| Status | The current conversation status.  |
| Sentiment | The current sentiment.  |
|Created on| The conversation creation time. |

**Agent presence history**

| Metrics | Description |
|-------|-------|
| Name | Agent name|
| Presence status | Presence status set |
| Start time | Time when the presence status was set  |
| End time | Time when the presence status was changed  |
| Created on | Time the status change entry was created   |

### See also

[Configure real-time analytics reports in Omnichannel for Customer Service (preview)](enable-realtime-analytics-dashboard-administrator.md#configure-real-time-analytics-reports-in-omnichannel-for-customer-service-preview)

[Introduction to Omnichannel Real-time analytics dashboards (preview)](intro-realtime-analytics-dashboard.md#introduction-to-omnichannel-real-time-analytics-dashboards-preview)

[View and understand the Summary report in Omnichannel real time analytics (preview)](realtime-summary-dashboard.md#view-and-understand-the-summary-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Voice report in Omnichannel real time analytics (preview)](realtime-voice-dashboard.md#view-and-understand-the-voice-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Ongoing Conversations report in Omnichannel real time analytics (preview)](realtime-ongoing.md#view-and-understand-the-ongoing-conversations-report-in-omnichannel-real-time-analytics-preview)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
