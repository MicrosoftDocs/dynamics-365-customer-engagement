---
title: Omnichannel real-time analytics agents insights report for supervisors | MicrosoftDocs
description: Learn about the real-time agents insights report for supervisors in Omnichannel for Customer Service.
ms.date: 10/28/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
manager: shujoshi
feedback_product_url: https://experience.dynamics.com/ideas/categories/list/?category=a7f4a807-de3b-eb11-a813-000d3a579c38&forum=b68e50a6-88d9-e811-a96b-000d3a1be7ad
ms.custom: intro-internal
---

# View and understand the Agents report in Omnichannel real-time analytics (preview)

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

The **Agents** report consists of metrics that provide an overview of agent performance. Supervisors can select the **All** filter to view agent performance across all channels or select a particular channel to view channel-wise agent performance. You can also filter areas by time, queue, time zone, or conversation status. More information: [Overview of Omnichannel Real-time analytics dashboards (preview)](intro-realtime-analytics-dashboard.md#overview-of-omnichannel-real-time-analytics-dashboards-preview)

:::image type="content" source="media/realtime-agent insights.png" alt-text="Screenshot of real-time agent insights report":::

The agents insights report consists of the following metrics.

| Metrics | Description |
|-------|-------|
| Agents logged in | The number of agents who are currently signed in.|
| Session rejection rate | The percentage of sessions rejected by the agents, out of the total sessions assigned to them. |
| Session timeout rate | The percentage of sessions that were timed out, out of the total sessions assigned. |
| Avg. session handle time| Average time an agent spent actively with a customer. Avg. handle time is derived by aggregating active session time across a conversation. This includes hold time (if applicable), wrap time (if applicable), talk time (if applicable), and active time. |
Required capacity unit for current waiting conversation| Total capacity required to handle all conversations currently waiting to be assigned to an agent. |

## Interactive charts

You can view interactive charts on the report, such as donut charts. The visual display helps you see the changes and patterns in data, and act quickly to address the most important issues.

When you select a component on the chart, data gets filtered accordingly, and you'll be able to view data related only to the selected component. For example, if you select the **Busy** piece in the **Agent availability status** chart, the dashboard will refresh and you’ll see only the agents who are currently in the **Busy** state.

The Agent report displays the following charts.

| Title | Description |
| ------- | ------------------ |
| Agent availability status| The donut chart shows the total number of agents in each of the applicable statuses. The statuses could be Available, Offline, Do not disturb, Busy, or any of the configured custom statuses.|
| Capacity by unit| The donut chart shows the total number of agents in Available or Occupied status. |
| Session participation mode| The donut chart shows the distribution of the sessions across various participation types. Primary indicates agents who have sessions assigned to them, Consult indicates agents who are engaged in a consulting session, and Monitor indicates an ongoing supervisor's monitor session. |

## Agent details

The **Agent list** table provides you with the ability to drill down to key metrics on agent details. It includes the following information.

:::image type="content" source="media/realtime_agent_list-table.png" alt-text="Screenshot of agent list table":::

| Agent details | Description |
|-------|-------|
| Agent | A list of the agent names for the queue. |
| Status | The current presence of the agent: Available, Offline, Do not disturb, or Busy. |
| Status since | Time since the status was set.  |
| Active sessions | The number of conversations that are active.|
| Wrap-up sessions | The total number of conversations in the Wrap-up stage. |
| Closed | The number of conversations that are closed. |
| Avg. handle time | The average of an individual agent's handle time for all closed conversations that the agent is involved with.|
| Session rejection rate | The percentage of sessions rejected by the agents, out of the total sessions assigned to them. |
| Session timeout rate | The percentage of sessions that were timed out, out of the total sessions assigned. |
|Domain name| The user ID of the agent.|

You can also drill down to view specific insights about the performance of individual agents by selecting the agent name and then the **Detailed view** link. Agent details are displayed on a new page with the following details.

:::image type="content" source="media/realtime-agent-detailed-view.png" alt-text="Drill down to agent details":::

| Metrics | Description |
|-------|-------|
| Status | The current status of an agent. These could be Available, Offline, Do not disturb, or Busy; or any other custom presence states set by your organization.  |
| Units available | The current available agent capacity units. Available capacity can be displayed as negative due to supervisor assignments. |
| Units occupied | The agent capacity units currently utilized. |
| Profiles available | The current capacity profiles available. |
| Profiles occupied | The current capacity profiles utilized. |
| Engaged Sessions | The number of sessions presented to an agent and accepted by an agent.  |
| Transfer rate  | The percentage of conversations that were transferred by the agent to another agent or queue. |
| Session rejection rate  | The percentage of sessions presented to an agent but rejected by the agent. |
| Session time out rate | The percentage of sessions presented to an agent but ended before the agent responded. |
| Average session handle time  | The average handle time per session is calculated as the average of all the handle times of the sessions handled by the agent. The session handle time is the total duration an agent spent on the session when it's in focus in the session panel until an agent closes the session. The handle time is paused when the agent switches to another session and is resumed when the agent returns to the session. This includes the time the agent takes to wrap up the conversation. |

**Conversations**

| Metrics | Description |
|-------|-------|
| Subject  | The conversation subject. For an identified customer, the customer's name is displayed with the subject. For unidentified customers, static text is displayed with the label Visitor. More information: [Identify customers automatically](record-identification-rule.md#identify-customers-automatically)|
| Handle time  | The time from the session start to the session end.  |
| Channel| The channel that the conversation was created from.  |
| Queue | The queue that the conversation is currently part of.  |
| Status | The current conversation status.  |
| Sentiment | Current sentiment of the conversation. It could be one of the following sentiments: Very positive, Positive, Slightly positive, Neutral, Slightly negative, or Negative.  |
| Created on| The conversation creation time. |

**Agent presence history**

| Metrics | Description |
|-------|-------|
| Name | The agent name.|
| Presence status | The presence status set. |
| Start time | The time when the presence status was set.  |
| End time | The time when the presence status was changed.  |
| Created on | The time the status change entry was created.  |

### See also

[Manage real-time analytics reports in Omnichannel for Customer Service (preview)](enable-realtime-analytics-dashboard-administrator.md#manage-real-time-analytics-reports-in-omnichannel-for-customer-service-preview)

[Overview of Omnichannel real-time analytics reports (preview)](intro-realtime-analytics-dashboard.md)

[View and understand the Summary report in Omnichannel real-time analytics (preview)](realtime-summary-dashboard.md#view-and-understand-the-summary-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Voice report in Omnichannel real-time analytics (preview)](realtime-voice-dashboard.md#view-and-understand-the-voice-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Ongoing Conversation report in Omnichannel real-time analytics (preview)](realtime-ongoing.md#view-and-understand-the-ongoing-conversation-report-in-omnichannel-real-time-analytics-preview)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
