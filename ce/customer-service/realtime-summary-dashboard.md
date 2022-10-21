---
title: Real-time analytics Summary report| Microsoft Docs
description: Learn about the Real-time summary report to cater to your organization's customer service experience better.
ms.date: 10/21/2022
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

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

The **Summary** report is the default report that appears when you select the Omnichannel real-time analytics dashboard in Customer Service workspace. This report provides KPIs across the volume of customer interactions and service levels along with the available capacity in near real time. You can filter these areas by time, channels, queue, time zone, or conversation status. More information: [Overview of Omnichannel Real-time analytics dashboards (preview)](intro-realtime-analytics-dashboard.md#overview-of-omnichannel-real-time-analytics-dashboards-preview)

**Need screenshot of the Summary report**

The Summary report displays the following metrics.

| Metrics | Description |
| ------- | ------------------ |
| Incoming conversation  | Total number of conversations received across all applicable channels. |
| Conversations in queue |Total number of conversations in queue currently awaiting human agents across all channels.  |
| Longest wait time | Longest wait time of currently unassigned conversations across all channels. |
| Avg. speed to answer |Average time across all channels taken for conversations to be accepted by agents.   |
| Abandoned rate | Total number of conversations across all channels that were closed by customers before an agent accepted the conversation. |
| Ongoing conversation | Total number of conversations which are currently worked on by a human agent. This includes all open conversations which are currently assigned to an agent.|
| Avg. handle time | Average time an agent spent actively with a customer across all channels.|
| Service level (60 sec) | Percentage of conversations across all channels what were accepted by an agent within 60 seconds.|

## Interactive charts

You can view different types of charts on the report, such as bar, horizontal bar, and donut chart. The visual display helps you see the changes and patterns in data, and act quickly to address the most important issues.

When you select a component on the chart, data gets filtered accordingly and you'll be able to view data related only to the selected component. For example, if you select the **Busy** piece in the **Agent availability status** chart, the dashboard will refresh and you’ll see only the agents who are currently in the **Busy** state.

The Summary report displays the following charts.

**Need screenshot**

| Charts| Description |
| ------- | ------------------ |
| Conversations over time| The bar chart shows the total conversations received mapped against hour. |
| Ongoing conversations by status | The donut chart shows the total number of conversations currently in Open, Active and Wrap-Up statuses. |
| Agent availability status| The donut chart shows the total number of agents in Available, Busy, Do not disturb, and Appear away statuses.  |
| Ongoing conversations by channel | The horizontal bar chart shows the total number of conversations which are currently worked on by a human agent (including open conversations assigned) on each of Omnichannel channels.|
| Ongoing conversations by queue | The horizontal bar chart shows the total number of conversations which are currently worked on by a human agent (including open conversations assigned) in each of Omnichannel queue. |
| Capacity by unit | The donut chart shows the total number of available units occupied. |

### See also

[Configure real-time analytics reports in Omnichannel for Customer Service (preview)](enable-realtime-analytics-dashboard-administrator.md#configure-real-time-analytics-reports-in-omnichannel-for-customer-service-preview)

[Overview of Omnichannel Real-time analytics reports (preview)](intro-realtime-analytics-dashboard.md)

[View and understand the Voice report in Omnichannel real time analytics (preview)](realtime-voice-dashboard.md#view-and-understand-the-voice-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Agents report in Omnichannel real time analytics (preview)](realtime-agents-analytics.md#view-and-understand-the-agents-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Ongoing Conversation report in Omnichannel real time analytics (preview)](realtime-ongoing.md#view-and-understand-the-ongoing-conversations-report-in-omnichannel-real-time-analytics-preview)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
