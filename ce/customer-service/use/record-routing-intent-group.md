---
title: View and understand real-time analytics for record routing in the Intent group report.
description: Use the Intent group report to drill down into metrics by intent and representative in Dynamics 365 Customer Service, enabling better insights and operational improvements.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 11/17/2025
ms.custom: bap-template
---

# View and understand real-time analytics for record routing in the Intent group report (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Organizing contact center data by intent, intent groups, and line of business enables supervisors to monitor and track record type work items effectively. This structured approach improves service quality and operational efficiency, driving higher customer satisfaction.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

:::image type="content" source="../media/intent-group-record-routing.png" alt-text="Screenshot of the Intent Group for record routing":::

You can filter this report by **Duration**, **Line of Business**, **Agent group**, **Intent group**, **Work item status**, and **Time**.

As part of visual customization, all record routing dashboards including **Summary**, **Backlog work items**, **Ongoing work items**, **Queue**, and **Agent** reports can be filtered by intent group, intent, and line of business by using the **IntentFamilyName** in **DimIntent** dimension. Learn more in [visual customization](customize-reports.md). You can search for the data measures for intent to select specific intent-based filters.

## Prerequisites

- You turned on the toggle for Customer Intent Agent and added the Line of business, Intent groups, and Intents. Learn more in [Customer Intent Agent](/dynamics365/contact-center/administer/manage-customer-intent-agent).
- You enabled real-time analytics for record routing for intent. Learn more in [Enable the real-time analytics for record routing dashboard](../administer/enable-record-routing.md#enable-the-real-time-analytics-for-record-routing-dashboard).

You see the report after 24 hrs of provisioning. If you don't enable Customer Intent Agent, you might still see data measures related to intent. However, you don't see any conversation or case-related information in the report.


## Metrics by Intent Group

|Metrics | Definition  |
|---------|---------|
|Unassigned work items|	Number of record type work items modified in the last 2 hours and are unassigned currently within the intent group.|
|Assigned work item|	Number of record type work items modified in the last 2 hours and are assigned currently within intent group. |Assigned work items = Auto assigned work items + Manually assigned work items.|
|Longest wait time|	Waiting time until the agent accepts the work item per intent group.|
|Agents online|	Number of customer service representatives (service representatives or representatives) who have logged in per intent group|
|Agents available|	Number of customer service representatives (service representatives or representatives) who are in Available status per intent group|
|Active sessions|	Number of active sessions the representative is in, and modified in the last 2 hours per intent group|
vClosed sessions|	Number of closed sessions the representative is in, and modified in the last 2 hours per intent group|


## Drilldown
|Metrics | Definition  |
|---------|---------|
|Assigned work items|	Number of record type work items modified in the last 2 hours and are assigned currently. Assigned work items = Auto assigned work items + Manually assigned work items.|
|Unassigned work items|	Number of record type work items modified in the last 2 hours and are unassigned currently.|
|Agents with active work items|	Number of customer service representatives (service representatives or representatives) that are currently with active record type work items.|
|Agents online|	Number of customer service representatives (service representatives or representatives) who have logged in|
|Transferred work itemsv	Number of record type work items that are either agent transfer or transferred to a queue|

## Metrics by intent

|Metrics | Definition  |
|---------|---------|
|Intent name|	Name of intent set by admin to be tracked per record type workitems|
|Assigned work items|	Number of record type work items modified in the last 2 hours and are assigned currently per intent name. |Assigned work items = Auto assigned work items + Manually assigned work items.|
|Unassigned work items|	Number of record type work items modified in the last 2 hours and are unassigned currently per intent name.|
|Longest wait time (hh:mm:ss)|	Waiting time until the agent accepts the work item per intent name.|


## Metrics by agent
|Metrics | Definition  |
|---------|---------|
|Agent name|	Name of agent set to the specific intent|
|Assigned work items|	Number of record type work items modified in the last 2 hours and are assigned currently to specific agent. Assigned work items = Auto assigned work items + Manually assigned work items.|
|Transferred work items|	Number of record type work items that are transferred to an agent and currently assigne to this agent|
|Active sessions|	Number of active sessions the representative is in, and modified in the last 2 hours.|
|Closed sessions|	Number of closed sessions the representative is in, and modified in the last 2 hours.|


## Drill-down 

Drill down on the **Metrics by intent group**, and then select **Detailed view** to view metrics by intent and agent.

## Related information

[Manage real-time analytics for record routing](../administer/enable-record-routing.md#manage-real-time-analytics-for-record-routing)  
[Overview of real-time analytics for record routing](rr-overview.md#overview-of-real-time-analytics-for-record-routing)  
[Record routing in the Agent group report](record-routing-user-group.md)
