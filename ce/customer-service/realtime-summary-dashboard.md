---
title: Real-time analytics Summary report| Microsoft Docs
description: Learn about the Real-time summary report to cater to your organization's customer service experience better.
ms.date: 10/20/2022
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

The **Summary** report is the default report that appears when you select the Omnichannel real-time analytics dashboard in Customer Service workspace. The report includes a variety of charts with graphical views of your organization's key performance indicators (KPIs).

By default, the report shows you KPIs for the past one day and for all channels, queues, and agents in your system. You can use the data filtering options to select data for specific time periods, channels, queues, time zone, and conversation status.

**Need screenshot of the Summary report**

## Report details

The report summarizes the KPIs for the specified time period and the percentage change over the period. You can filter these areas by time, channels, queue, time zone, or conversation status. The report includes conversations that are only handled by agents. It also includes conversations that were escalated but not completely handled by the Power Virtual Agents bots.

**Need screenshot**

## KPI	Description

| KPI | Description |
| ------- | ------------------ |
| Incoming conversation  | Total number of conversations received across all channels. Conversations escalated by the Power Virtual Agents bots are also included. |
| Conversations in queue |Total number of conversations in queue currently awaiting human agents across all channels.  |
| Longest wait time | Longest wait time of current unassigned conversations across all channels. |
| Avg. speed to answer |Average time across all channels taken for conversations to be accepted by agents.   |
| Abandoned rate | Total number of conversations across all channels that were closed before an agent accepted the conversation. |
| Ongoing conversation | Total number of conversations which are currently worked on by a human agent. This includes all open conversations which are assigned to an agent.|
| Avg. handle time | Average time an agent spent actively with a customer across all channels. Avg. handle time is derived by aggregating active session time across a conversation. This includes hold time (if applicable), wrap time (if applicable), talk time (if applicable), active time. |
| Service level (60 sec) | Percentage of conversations across all channels what were accepted by an agent within 60 seconds. Conversations escalated by the Power Virtual Agents bots are also included.|

The following charts are displayed in the Summary report. You can select the individual metrics on the chart to view related data.

**Need screenshot**

| Title | Description |
| ------- | ------------------ |
| Conversations over time| Total conversations received mapped against hour. |
| Ongoing conversations by status | Total number of conversations currently in Open, Active and Wrap-Up statuses. |
| Agent availability status| Total number of agents in Available, Busy, Do not disturb and Appear away statuses.  |
| Ongoing conversations by channel | Total number of conversations which are currently worked on by a human agent (including open conversations assigned) on each of Omnichannel channels.   |
| Ongoing conversations by queue | Total number of conversations which are currently worked on by a human agent (including open conversations assigned) in each of Omnichannel queue. |
| Capacity by unit |Total number of agents in **Available**, **Busy** status.  |

### See also

[Configure real-time analytics reports in Omnichannel for Customer Service (preview)](enable-realtime-analytics-dashboard-administrator.md#configure-real-time-analytics-reports-in-omnichannel-for-customer-service-preview)

[Introduction to Omnichannel Real-time analytics dashboards (preview)](intro-realtime-analytics-dashboard.md#introduction-to-omnichannel-real-time-analytics-dashboards-preview)

[View and understand the Voice report in Omnichannel real time analytics (preview)](realtime-voice-dashboard.md#view-and-understand-the-voice-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Agents report in Omnichannel real time analytics (preview)](realtime-agents-analytics.md#view-and-understand-the-agents-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Ongoing Conversations report in Omnichannel real time analytics (preview)](realtime-ongoing.md#view-and-understand-the-ongoing-conversations-report-in-omnichannel-real-time-analytics-preview)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
