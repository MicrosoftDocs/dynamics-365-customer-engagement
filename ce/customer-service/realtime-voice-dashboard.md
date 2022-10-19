---
title: Voice Dashboard | Microsoft Docs
description: Learn about the Voice dashboard insights overview to better understand your organization's customer service experience.
ms.date: 10/19/2022
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

The Voice report gives you insights into key metrics across the voice channel.

**(Need screenshot of the report)**

## Report details

The report summarizes the KPIs for the specified time period and the percentage change over the period. You can filter these areas by time, queue, time zone, conversation status, or direction.

**Need screenshot**

## KPI	Description

| KPI | Description |
| ------- | ------------------ |
| Incoming conversation  | TTotal number of voice conversations received.  
Conversation escalated by the Power Virtual Agents bots is also included. |
| Conversations in queue |Total number of voice conversations in queue currently awaiting human agents   |
| Longest wait time |Maximum wait time of voice conversations currently in open state awaiting agent .|
| Avg. speed to answer | Average time customers waited in the queue before connecting to an agent|
| Abandoned rate | Total number of conversations which are closed before an agent accepted the conversation. |
| Ongoing conversation | Total number of conversations which are currently worked on by an human agent. This includes all open conversations which are assigned to an agent. |
| Avg. handle time | Average time an agent spent actively with a customer on voice conversations. Avg. handle time is derived by aggregating active session time across a conversation. This includes hold time (if applicable), Wrap time (if applicable) and talk time (if applicable), active time. |
| Service level (60 sec) | Percentage of voice conversations what were accepted by an agent within 60 seconds (after escalated by bot if applicable) |

The following charts are displayed in the Voice report.

**Need screenshot**

| Title | Description |
| ------- | ------------------ |
| Conversations over time| Total conversations voice received mapped against hour |
| Ongoing conversations by status | Total number of voice conversations currently in Open, Active and Wrap-Up statuses |
| Agent availability status| Total number of agents who are members of queues in voice workstreams, in Available, Busy, Do not disturb and Appear away statuses  |
| Conversation time | |
| Ongoing conversations by queue |Total number of conversations which are currently worked on by a human agent (including open conversations assigned) in each of Omnichannel queue. |
| Capacity by unit | Total number of voice agents in Available, Occupied status. |

You can select **View report details** to drill down on the **Conversation and agent analytics** queue and metrics by agent details.

**Need screenshot**

**Queue**

| Title | Description |
| ------- | ------------------ |
| Queue| |
| Conversation in queue| |
| Longest wait time| Longest wait time of current unassigned conversations. |
| Offered |Total number of conversations which was offered to human agent queue. This includes both inbound and outbound conversations|
| Ongoing |Total number of conversations which are currently worked on by an human agent. This includes all open conversations which are assigned to an agent. |
| Closed |Total number of conversations which are closed in the period.  |
| Ongoing | Total number of conversations which are currently worked on by an human agent. This includes all open conversations which are assigned to an agent.|
| Avg. speed to answer | |
| Abandon rate |Total number of conversations which are closed before an agent accepted the conversation. |
| Avg. handle time | Average time an agent spent actively with a customer. Avg. handle time is derived by aggregating active session time across a conversation. This include hold time (if applicable), Wrap time (if applicable) and talk time (if applicable), active time. |
| Avg. wrap time | |
| Avg. talk time | |
| Avg. hold time | |

Metrics by agent

| Title | Description |
| ------- | ------------------ |
| Agent| |
| Ongoing| Total number of conversations which are currently worked on by an human agent. This includes all open conversations which are assigned to an agent.|
| Engaged|  |
| Avg. talk time| |
| Avg. hold time | |
| Avg. wrap time | |
| Avg. handle time | Average time an agent spent actively with a customer. Avg. handle time is derived by aggregating active session time across a conversation. This include hold time (if applicable), Wrap time (if applicable) and talk time (if applicable), active time.|


### See also

[Configure real-time analytics reports in Omnichannel for Customer Service (preview)](enable-realtime-analytics-dashboard-administrator.md#configure-real-time-analytics-reports-in-omnichannel-for-customer-service-preview)

[Introduction to Omnichannel Real-time analytics dashboards (preview)](intro-realtime-analytics-dashboard.md#introduction-to-omnichannel-real-time-analytics-dashboards-preview)

[View and understand the Summary report in Omnichannel real time analytics (preview)](realtime-summary-dashboard.md#view-and-understand-the-summary-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Agents report in Omnichannel real time analytics (preview)](realtime-agents-analytics.md#view-and-understand-the-agents-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Ongoing Conversations report in Omnichannel real time analytics (preview)](realtime-ongoing.md#view-and-understand-the-ongoing-conversations-report-in-omnichannel-real-time-analytics-preview)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
