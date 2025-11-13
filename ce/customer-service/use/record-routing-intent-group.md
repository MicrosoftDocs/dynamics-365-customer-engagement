---
title: View and understand real-time analytics for record routing in the Intent group report.
description: Use the Intent group report to drill down into metrics by intent and representative in Dynamics 365 Customer Service, enabling better insights and operational improvements.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 11/13/2025
ms.custom: bap-template
---

# View and understand real-time analytics for record routing in the Intent group report (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Organizations set up intents and intent groups for the contact center to handle. Real-time analytics empower contact center supervisors to effectively monitor conversations and track operational metrics using intent attributes. This capability enhances decision-making by providing immediate insights into customer interactions, allowing supervisors to identify trends, optimize agent performance, and ensure that customer queries are resolved efficiently. By leveraging intent attributes, supervisors can gain a deeper understanding of customer intent and improve overall service quality, driving business value through enhanced operational efficiency and customer satisfaction.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

:::image type="content" source="../media/intent-group-record-routing.png" alt-text="Screenshot of the Intent Group for record routing":::

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
|Agents online     |     Number of Agents that are currently online based on the time slicer.     |
|Agents in wrap-up conversations    |   Service representatives who have finished interacting with the customer but are still completing post-conversation tasks before closing the session.        |
|Average session handle time | Average Session Handle Time = Total handle time across sessions / Number of sessions handled. |
|Longest wait time| Longest wait time is a measure of the longest first wait time among unaccepted incoming conversations. |
|Conversations abandoned rate | The abandoned rate refers to the percentage of incoming conversation requests that are terminated before a representative engages with the customer. |
|Logged in agents | Logged in service representatives is the number of representatives who are currently logged in and aren't in Offline status. |
|Agents available | Service representatives who are currently in **Available** status. |
|Average handle time (hh:mm:ss)| Total handle time divided by the number of conversations handled.|
|Engaged conversations | conversations handled by the service representative. |
|Transfer rate | Session transfer rate is the total transfers within a conversation across sessions over the total conversations. |


## Drill-down 

You can drilldown on the **Metrics by intent group**. Select **Detailed view** to view metrics by intent and agent.

## Related information

[Manage real-time analytics for record routing](../administer/enable-record-routing.md#manage-real-time-analytics-for-record-routing)  
[Overview of real-time analytics for record routing](rr-overview.md#overview-of-real-time-analytics-for-record-routing)  
[Record routing in the Agent group report](record-routing-agent-group.md#view-and-understand-real-time-analytics-for-record-routing-in-the-agent-group-report)
