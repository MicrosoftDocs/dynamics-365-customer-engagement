---
title: View and understand real-time analytics for record routing in the Agent  group report
description: Learn how to filter and analyze real-time metrics in the Agent group report to identify trends and improve agent and customer outcomes.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 10/21/2025
ms.custom: bap-template
---

# View and understand real-time analytics for record routing in the Agent group report (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Organizations set up intents and intent groups for the contact center. Real-time analytics for record routing let supervisors monitor conversations and track metrics using intent attributes. Supervisors get immediate insights into customer interactions, identify trends, optimize agent performance, and help resolve customer queries efficiently. By using intent attributes, supervisors better understand customer intent and improve service quality, leading to greater operational efficiency and customer satisfaction.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

:::image type="content" source="../media/agent-group-record-routing.png" alt-text="Screenshot agent group report for record routing." lightbox="../media/agent-group-record-routing.png":::

You can filter this report by **Duration**, **Line of Business**, **Agent group**, **Intent group**, **Work item status**, and **Time**.

As part of visual customization, all record routing dashboards including **Summary**, **Backlog work items**, **Ongoing work items**, **Queue**, and **Agent** reports can be filtered by Intent group, intent and Line of Business by using the **IntentFamilyName** in **DimIntent** dimension. Learn more in [visual customization](customize-reports.md). You can search for the data measures for intent to select specific intent-based filters.

## Prerequisites

- You have turned on the toggle for Customer Intent Agent and have added the Line of business, Intent groups and Intents. Learn more in [Customer Intent Agent](/dynamics365/contact-center/administer/manage-customer-intent-agent).
- You have enabled real-time analytics for record routing for intent. Learn more in [Enable the real-time analytics for record routing dashboard](../administer/enable-record-routing.md#enable-the-real-time-analytics-for-record-routing-dashboard).

You see the report after 24hrs of provisioning. If you don't enable Customer Intent Agent, you might still see data measures related to intent. However, there won't be any conversation or case-related information in the report.             

## Metrics


|Metrics | Definition  |
|---------|---------|
|Conversations in queue    |    Conversations that are currently waiting in queue to be assigned.      |
|Agents online     |     Number of representatives that are currently online based on the time slicer.     |
|Agents in active conversations    |    Representatives currently handling live conversations that are in progress and not yet closed excluding wrap-up state. |
|Agents in wrap conversations    |   Service representatives who have finished interacting with the customer but are still completing post-conversation tasks before closing the session. |
| Avg session handle time | Average Session Handle Time = Total handle time across sessions / Number of sessions handled. |
|Session timeout rate    |  Session Timeout Rate (%) = (Number of timed-out sessions/Total assigned sessions) × 100.        |
|Session rejection rate     |  Session Rejection Rate (%)= Number of sessions rejected by agents / Total number of sessions assigned to agents *100 |
|Longest wait time| Longest wait time is a measure of the longest first wait time among unaccepted incoming conversations. |
|Conversations abandoned rate | Abandoned rate refers to the percentage of incoming conversation requests that are terminated before a representative engages with the customer. |
|Logged in agents | Logged in service representatives is the number of representatives who are currently logged in and aren't in Offline status. |
|Agents available | Service representatives who are currently in **Available** status. |
|Avg. handle time (hh:mm:ss)| It’s the total handle time divided by the number of conversations handled.|
|Agent availability status| Donut chart showing agent presence status. |
 

## Drill-down 

You can drilldown on the **Metrics by agent group**. Select **Detailed view** to view **Metrics by agent group**.

## Related information

[Manage real-time analytics for record routing](../administer/enable-record-routing.md#manage-real-time-analytics-for-record-routing)  
[Overview of real-time analytics for record routing](rr-overview.md#overview-of-real-time-analytics-for-record-routing)  
[Record routing in the Intent group report](record-routing-intent-group.md#view-and-understand-real-time-analytics-for-record-routing-in-the-intent-group-report)

