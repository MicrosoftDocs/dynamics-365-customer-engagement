---
title: Voice Dashboard | Microsoft Docs
description: Learn about the Voice dashboard insights overview to better understand your organization's customer service experience.
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

# View and understand the Voice report in Omnichannel real time analytics (preview)

> [!IMPORTANT]
> [!INCLUDE[cc-preview-feature](../includes/cc-preview-feature.md)]
>
> [!INCLUDE[cc-preview-features-definition](../includes/cc-preview-features-definition.md)]
>
> [!INCLUDE[cc-preview-features-expect-changes](../includes/cc-preview-features-expect-changes.md)]
>
> [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]
>

The Voice report gives you insights into key metrics across the voice channel. You can filter these areas by time, queue, time zone, conversation status, or direction. More information: [Overview of Omnichannel Real-time analytics dashboards (preview)](intro-realtime-analytics-dashboard.md#overview-of-omnichannel-real-time-analytics-dashboards-preview)
You will see the Voice report, only if your organization has the Voice feature configured. More information: [Configure real-time analytics reports in Omnichannel for Customer Service (preview)](enable-realtime-analytics-dashboard-administrator.md#configure-real-time-analytics-reports-in-omnichannel-for-customer-service-preview)

**(Need screenshot of the report)**

## KPI	Description

| KPI | Description |
| ------- | ------------------ |
| Incoming conversation  | Total number of voice conversations received.|
| Conversations in queue |Total number of voice conversations in queue currently awaiting human agents   |
| Longest wait time |Maximum wait time of voice conversations currently in Open state awaiting agent .|
| Avg. speed to answer | Average time customers waited in the queue before connecting to an agent|
| Abandoned rate | Total number of voice conversations which are closed before an agent accepted the conversation. |
| Ongoing conversation | Total number of voice conversations which are currently worked on by an human agent. This includes all open conversations which are assigned to an agent. |
| Avg. handle time | Average time an agent spent actively with a customer on voice conversations.|
| Service level (60 sec) | Percentage of voice conversations what were accepted by an agent within 60 seconds (after including the conversations escalated by bot) |

## Interactive charts

You can view different types of charts on the report, such as bar, horizontal bar, and donut chart. The visual display helps you see the changes and patterns in data, and act quickly to address the most important issues.

When you select a component on the chart, data gets filtered accordingly and you'll be able to view data related only to the selected component. For example, if you select the **Busy** piece in the **Agent availability status** chart, the dashboard will refresh and you’ll see only the agents who are currently in the **Busy** state.

The Voice report displays the following charts.

**Need screenshot**

| Title | Description |
| ------- | ------------------ |
| Conversations over time| The bar chart shows the total voice conversations received mapped against hou.r |
| Ongoing conversations by status | The donut chart shows the total number of voice conversations currently in Open, Active and Wrap-Up statuses. |
| Agent availability status| The donut chart shows the total number of agents who are members of queues in voice workstreams, in Available, Busy, Do not disturb and Appear away statuses. |
| Conversation time |The horizontal bar chart shows the average conversation time mapped by minutes. |
| Ongoing conversations by queue |The horizontal bar chart shows the total number of conversations which are currently worked on by a human agent (including open conversations assigned) in each of Omnichannel queue.|
| Capacity by profile | The donut chart shows the total number of voice agents in **Available** or **Busy** status.|

### See also

[Configure real-time analytics reports in Omnichannel for Customer Service (preview)](enable-realtime-analytics-dashboard-administrator.md#configure-real-time-analytics-reports-in-omnichannel-for-customer-service-preview)

[Introduction to Omnichannel Real-time analytics dashboards (preview)](intro-realtime-analytics-dashboard.md#introduction-to-omnichannel-real-time-analytics-dashboards-preview)

[View and understand the Summary report in Omnichannel real time analytics (preview)](realtime-summary-dashboard.md#view-and-understand-the-summary-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Agents report in Omnichannel real time analytics (preview)](realtime-agents-analytics.md#view-and-understand-the-agents-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Ongoing Conversations report in Omnichannel real time analytics (preview)](realtime-ongoing.md#view-and-understand-the-ongoing-conversations-report-in-omnichannel-real-time-analytics-preview)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
