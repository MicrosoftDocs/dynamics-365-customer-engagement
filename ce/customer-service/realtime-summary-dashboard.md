---
title: Real-time analytics Summary report| Microsoft Docs
description: Learn about the Real-time summary report to cater to your organization's customer service experience better.
ms.date: 10/18/2022
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

The **Summary** report is displayed in the default view in the Customer Service workspace. The report includes a variety of charts with graphical views of your organization's key performance indicators (KPIs).

By default, the report shows you KPIs for the past one day and for all channels, queues, and agents in your system. You can use the data filtering options to select data for specific time periods, channels, queues, agents, conversation status, direction, and time zone. Additionally, you can also pause the updates by using the **Pause updates** button.

**Need screenshot of the Summary report**

## Navigation

You can view the Summary dashboard in the Customer Service workspace or Omnichannel for Customer Service app. You can navigate to the Summary dashboard as follows:

- In the default view, select the plus (+) icon, and then select **Omnichannel real-time analytics**. On the page that appears, select **Summary**.
-If the enhanced multisession workspace view is enabled, select the site map, and then select **Omnichannel historical analytics**. On the page that appears, select **Summary**.

## Report details

The report summarizes the KPIs for the specified time period and the percentage change over the period. You can filter these areas by time, channels, queue, time zone, or conversation status.

**Need screenshot**

## KPI	Description

| KPI | Description |
| ------- | ------------------ |
| Incoming conversation  | Total number of conversations received across all channels. Conversations escalated by the Power Virtual Agents bots are also included. |
| Conversations in queue |Total number of conversations in queue currently awaiting human agents across all channels  |
| Longest wait time | Longest wait time of current unassigned conversations across all channels |
| Avg. speed to answer |Average time across all channels taken for conversations to be accepted by agents   |
| Abandoned rate | Total number of conversations across all channels that were closed before an agent accepted the conversation. |
| Ongoing conversation | Total number of conversations which are currently worked on by a human agent. This includes all open conversations which are assigned to an agent.|
| Avg. handle time | Average time an agent spent actively with a customer across all channels. Avg. handle time is derived by aggregating active session time across a conversation. This includes hold time (if applicable), wrap time (if applicable), talk time (if applicable), active time. |
| Service level (60 sec) | Percentage of conversations across all channels what were accepted by an agent within 60 seconds. Conversations escalated by the Power Virtual Agents bots are also included.|

The following charts are displayed in the Summary report.

**Need screenshot**

| Title | Description |
| ------- | ------------------ |
| Conversations over time| Total conversations received mapped against hour |
| Ongoing conversations by status | Total number of conversations currently in Open, Active and Wrap-Up statuses |
| Agent availability status| Total number of agents in Available, Busy, Do not disturb and Appear away statuses  |
| Ongoing conversations by channel | Total number of conversations which are currently worked on by a human agent (including open conversations assigned) on each of Omnichannel channels.   |
| Ongoing conversations by queue | Total number of conversations which are currently worked on by a human agent (including open conversations assigned) in each of Omnichannel queue. |
| Capacity by unit |Total number of agents in Available, Occupied status  |

You can select **View report details** to drill down on the **Conversation and agent analytics** channel and queue details.

**Need screenshot**

Conversation Queue

| Title | Description |
| ------- | ------------------ |
| Queue| |
| Waiting| Total number of conversations which are currently waiting in the human agent queue to be assigned to an agent.|
| Longest wait time|  |
| Available capacity (units/profile) | |
| Avg. wait time |Avg wait time of all assigned conversations for the period selected. This metric is calculated only for conversations which are accepted by human agent and is closed. |
| Abandoned rate% |Total number of conversations which are closed before an agent accepted the conversation. |
| Ongoing |Total number of conversations which are currently worked on by an human agent. This includes all open conversations which are assigned to an agent.|
| SLA first response % |Percentage of conversations which was responed within 30 seconds by an agent |
| Avg. handle time |Average time an agent spent actively with a customer. Avg. handle time is derived by aggregating active session time across a conversation. This include hold time (if applicable), Wrap time (if applicable) and talk time (if applicable), active time.  |

Agent Queue

| Title | Description |
| ------- | ------------------ |
| Queue| |
| Agent available|Number of agents who are currently in presence status = "Available" |
| Agent busy| Number of agents who are currently in presence status = "busy" |
| Agent DND|Number of agents who are currently in presence status = "Do not disturb" |
| Units available | |
| Units occupied | |
| Profile available | |
| Profile occupied | |

**We need Conversation and Agent Channel details as well.**

### See also

[Configure real-time analytics reports in Omnichannel for Customer Service (preview)](enable-realtime-analytics-dashboard-administrator.md#configure-real-time-analytics-reports-in-omnichannel-for-customer-service-preview)

[Introduction to Omnichannel Real-time analytics dashboards (preview)](intro-realtime-analytics-dashboard.md#introduction-to-omnichannel-real-time-analytics-dashboards-preview)

[View and understand the Voice report in Omnichannel real time analytics (preview)](realtime-voice-dashboard.md#view-and-understand-the-voice-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Agents report in Omnichannel real time analytics (preview)](realtime-agents-analytics.md#view-and-understand-the-agents-report-in-omnichannel-real-time-analytics-preview)

[View and understand the Ongoing Conversations report in Omnichannel real time analytics (preview)](realtime-ongoing.md#view-and-understand-the-ongoing-conversations-report-in-omnichannel-real-time-analytics-preview)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
