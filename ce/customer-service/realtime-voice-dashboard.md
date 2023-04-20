---
title: Real-time analytics voice report| Microsoft Docs
description: Learn about the real-time voice report to cater to your organization's customer service experience better.
ms.date: 10/28/2022
ms.topic: article
author: Soumyasd27
ms.author: sdas
search.audienceType: 
  - admin
  - customizer
  - enduser
ms.custom: 
  - dyn365-customerservice
---

# View and understand the Voice report in Omnichannel real-time analytics (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

The voice report gives you insights into key metrics across the voice channel. You can filter these areas by time, queue, time zone, conversation status, or direction. More information: [Overview of Omnichannel real-time analytics dashboards (preview)](intro-realtime-analytics-dashboard.md#overview-of-omnichannel-real-time-analytics-dashboards-preview)
You will see the voice report, only if your organization has the voice feature configured. More information: [Manage real-time analytics reports in Omnichannel for Customer Service (preview)](enable-realtime-analytics-dashboard-administrator.md#manage-real-time-analytics-reports-in-omnichannel-for-customer-service-preview)

:::image type="content" source="media/realtime_voice.png" alt-text="Screenshot of the voice report":::

## KPI	Description

| KPI | Description |
| ------- | ------------------ |
| Incoming conversation  | Total number of voice conversations received.|
| Conversations in queue |Total number of voice conversations in queue currently awaiting agents. |
| Longest wait time |Maximum wait time of voice conversations currently in Open state awaiting agent.|
| Avg. speed to answer | Average time customers waited in the queue before connecting to an agent.|
| Abandoned rate | Total number of voice conversations that are closed before an agent accepted the conversation. |
| Ongoing conversation | Total number of voice conversations that are currently worked on by an agent. This includes all open conversations that are assigned to an agent. |
| Avg. handle time | Average time an agent spent actively with a customer on voice conversations.|
| Service level (60 sec) | Percentage of voice conversations that were accepted by an agent within 60 seconds (after including the conversations escalated by bot, if applicable). |

## Interactive charts

You can view different types of charts on the report, such as bar, horizontal bar, and donut chart. The visual display helps you see the changes and patterns in data and act quickly to address the most important issues.

When you select a component on the chart, data gets filtered accordingly and you'll be able to view data related only to the selected component. For example, if you select the **Busy** piece in the **Agent availability status** chart, the dashboard will refresh and you’ll see only the agents who are currently in the **Busy** state.

The voice report displays the following charts.

| Title | Description |
| ------- | ------------------ |
| Conversations over time| The bar chart shows the total voice conversations received mapped against hour. |
| Ongoing conversations by status | The donut chart shows the total number of voice conversations currently in Open, Active, and Wrap-up statuses. |
| Agent availability status| The donut chart shows the total number of voice agents in each of the applicable availability statuses. These could be Available, Offline, Do not disturb, Busy or any of the custom statuses configured.  |
| Conversation time |The horizontal bar chart shows the comparison of average talk time, average wrap time, and average hold time.  |
| Ongoing conversations by queue |The horizontal bar chart shows the total number of conversations that are currently worked on by an agent (including open conversations assigned) in each of queues in Omnichannel for Customer Service.|
| Capacity by profile | The donut chart shows the total number of voice agents in Available or Occupied status.|

### See also

[Manage real-time analytics reports in Omnichannel for Customer Service (preview)](enable-realtime-analytics-dashboard-administrator.md#manage-real-time-analytics-reports-in-omnichannel-for-customer-service-preview)

[Overview of Omnichannel real-time analytics reports (preview)](intro-realtime-analytics-dashboard.md)

[View and understand the Summary report in Omnichannel real-time analytics (preview)](realtime-summary-dashboard.md#view-and-understand-the-summary-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Agents report in Omnichannel real-time analytics (preview)](realtime-agents-analytics.md#view-and-understand-the-agents-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Ongoing Conversation report in Omnichannel real-time analytics (preview)](realtime-ongoing.md#view-and-understand-the-ongoing-conversation-report-in-omnichannel-real-time-analytics-preview)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
