---
title: Real-time analytics Summary report| Microsoft Docs
description: Learn about the real-time summary report to cater to your organization's customer service experience better.
ms.date: 10/28/2022
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
# View and understand the Summary report in Omnichannel real-time analytics (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

The **Summary** report is the default report that appears when you select the Omnichannel real-time analytics dashboard in Customer Service workspace. This report provides KPIs across the volume of customer interactions and service levels, along with the available capacity in real time. You can filter these areas by time, channels, queue, time zone, or conversation status. More information: [Overview of Omnichannel real-time analytics dashboards (preview)](intro-realtime-analytics-dashboard.md#overview-of-omnichannel-real-time-analytics-dashboards-preview)

:::image type="content" source="media/realtime_summary.png" alt-text="Screenshot of realtime summary report":::

The Summary report displays the following metrics.

| Metrics | Description |
| ------- | ------------------ |
| Incoming conversation  | Total number of conversations received across all channels. |
| Conversations in queue |Total number of conversations in queue currently awaiting agents across all channels.  |
| Longest wait time | Longest wait time of currently unassigned conversations awaiting agents across all channels. |
| Avg. speed to answer |Average time across all channels taken for conversations to be accepted by agents.   |
| Abandoned rate | Total number of conversations across all channels that were closed before an agent accepted the conversation. |
| Ongoing conversation | Total number of conversations that are currently worked on by an agent. This includes all open conversations that are assigned to an agent.|
| Avg. handle time | Average time an agent spent actively with a customer across all channels. Avg. handle time is derived by aggregating active session time across a conversation. This includes hold time (if applicable), wrap time (if applicable), talk time (if applicable), and active time.|
| Service level (60 sec) | Percentage of conversations across all channels that were accepted by an agent within 60 seconds.|

## Interactive charts

You can view different types of charts on the report, such as bar, horizontal bar, and donut chart. The visual display helps you see the changes and patterns in the data, and act quickly to address the most important issues.

When you select a component on the chart, the data gets filtered accordingly and you'll be able to view data related only to the selected component. For example, if you select the **Busy** piece in the **Agent availability status** chart, the dashboard will refresh and you’ll see only the agents who are currently in the **Busy** state.

The Summary report displays the following charts.

| Charts| Description |
| ------- | ------------------ |
| Conversations over time| The bar chart shows the total conversations received mapped against the hour of the day, when they were received. |
| Ongoing conversations by status | The donut chart shows the total number of conversations currently in Open, Active, and Wrap-up statuses. |
| Agent availability status| The donut chart shows the total number of agents in each of the applicable statuses. The statuses could be Available, Offline, Do not disturb, Busy, or any of the configured custom statuses.|
| Ongoing conversations by channel | The horizontal bar chart shows the total number of conversations that are currently worked on by an agent (including open conversations assigned) on each of channels in Omnichannel for Customer Service.|
| Ongoing conversations by queue | The horizontal bar chart shows the total number of conversations that are currently worked on by an agent (including open conversations currently assigned to agents) in each of queues in Omnichannel for Customer Service. |
| Capacity by unit | The donut chart shows the total number of voice agents in Available or Occupied statuses. |

### See also

[Manage real-time analytics reports in Omnichannel for Customer Service (preview)](enable-realtime-analytics-dashboard-administrator.md#manage-real-time-analytics-reports-in-omnichannel-for-customer-service-preview)

[Overview of Omnichannel real-time analytics reports (preview)](intro-realtime-analytics-dashboard.md)

[View and understand the Voice report in Omnichannel real-time analytics (preview)](realtime-voice-dashboard.md#view-and-understand-the-voice-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Agents report in Omnichannel real-time analytics (preview)](realtime-agents-analytics.md#view-and-understand-the-agents-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Ongoing Conversation report in Omnichannel real-time analytics (preview)](realtime-ongoing.md#view-and-understand-the-ongoing-conversation-report-in-omnichannel-real-time-analytics-preview)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
