---
title: View and understand real-time analytics for record routing in the Intent group report
description: Use the Intent group report to drill down into metrics by intent and representative in Dynamics 365 Customer Service, enabling better insights and operational improvements.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: concept-article
ms.collection:
ms.date: 01/21/2026
ms.custom: bap-template
---

# View and understand real-time analytics for record routing in the Intent group report (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

As a supervisor, organizing contact center data by intent, intent groups, and line of business lets you effectively monitor and track work items by record type. This structured approach enhances service quality, streamlines operations, and ultimately drives higher customer satisfaction.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

You can filter this report by **Time**, **Line of business**, **Intent group**, **Agent group**, **Time zone**, and **Work item status**.

As part of visual customization, all record routing dashboards including **Summary**, **Backlog work items**, **Ongoing work items**, **Queue**, and **Agent** reports can be filtered by intent group, intent, and line of business by using the **IntentFamilyName** in **DimIntent** dimension. Learn more in [visual customization](customize-reports.md). You can search for the data measures for intent to select specific intent-based filters.

:::image type="content" source="../media/record-routing-intent-group.png" alt-text="Screenshot of real-time for record routing intent group report." lightbox="../media/record-routing-intent-group.png":::

## Prerequisites

- You turned on the toggle for Customer Intent Agent and added the Line of business, Intent groups, and Intents. Learn more in [Customer Intent Agent](/dynamics365/contact-center/administer/manage-customer-intent-agent).
- You enabled real-time analytics for record routing for intent. Learn more in [Enable the real-time analytics for record routing dashboard](../administer/enable-record-routing.md#enable-the-real-time-analytics-for-record-routing-dashboard).

You see the report after 24 hrs of provisioning. If you don't enable Customer Intent Agent, you might still see data measures related to intent, but no conversation or case details appear because configuration isn't complete.


## Metrics by Intent group

|Metrics | Definition  |
|---------|---------|
|Intent group name| Name of the intent group.|
|Unassigned work items|	By default, the system displays the number of record-type work items modified in the last two hours and  currently unassigned within the intent group.|
|Assigned work items|	By default, the system displays the number of record-type work items modified in the last two hours and  currently assigned within the intent group. Assigned work items = autoassigned work items + manually assigned work items.|
|Longest wait time|	Waiting time until the customer service representative (service representative or representative) accepts the work item per intent group.|
|Agents online|	Number of representatives logged in per intent group.|
|Agents available|	Number of representatives in **Available** status per intent group.|


## Report drilldown 

Select **Detailed view** to view metrics by intent and representative.

:::image type="content" source="../media/record-routing-intent-group-drilldown.png" alt-text="Screenshot of detailed view for a selected intent group.":::

|Metrics | Definition  |
|---------|---------|
|Assigned work items|	By default, the system displays the number of record-type work items modified in the last two hours and ones that are currently assigned. Assigned work items = autoassigned work items + manually assigned work items.|
|Unassigned work items|	By default, the system displays the number of record-type work items modified in the last two hours and are currently unassigned.|
|Agents with active work items|	Number of representatives that are currently with active record type work items.|
|Agents online|	Number of logged in representatives.|
|Transferred work items| Number of record type work items that are transferred to a queue or representative.|

## Metrics by intent

|Metrics | Definition  |
|---------|---------|
|Intent name|	Name of intent set by the administrator to be tracked per record type work item. |
|Assigned work items|	By default, the system displays the number of record-type work items modified in the last two hours and ones that are currently assigned per intent name. Assigned work items = autoassigned work items + manually assigned work items.|
|Unassigned work items|	By default, the system displays the number of record-type work items modified in the last two hours and are currently unassigned per intent name.|
|Longest wait time (hh:mm:ss)|	Waiting time until the representative accepts the work item per intent name.|


## Metrics by agent

|Metrics | Definition  |
|---------|---------|
|Agent name|	Name of representatives set to the specific intent. |
|Assigned work items|	By default, the system displays the number of record-type work items modified in the last two hours and are currently assigned to the specific representative. Assigned work items = autoassigned work items + manually assigned work items.|
|Unassigned work items| By default, the system displays the number of record-type work items modified in the last two hours and are currently unassigned per intent name.|
|Transferred work items| Number of record type work items transferred and assigned to a representative. |
|Active sessions|	By default, the system displays the number of active sessions the representative is currently in and modified in the last two hours.|
|Closed sessions|	By default, the system displays the number of sessions closed by the representative and updated in the last two hours.|


## Related information

[Manage real-time analytics for record routing](../administer/enable-record-routing.md#manage-real-time-analytics-for-record-routing)  
[Overview of real-time analytics for record routing](rr-overview.md#overview-of-real-time-analytics-for-record-routing)  
[Record routing in the Agent group report](record-routing-user-group.md)
