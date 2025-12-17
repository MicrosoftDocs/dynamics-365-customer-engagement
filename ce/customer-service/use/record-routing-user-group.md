---
title: View and understand real-time analytics for record routing in the User group report
description: Learn how to filter and analyze real-time metrics in the User group report to identify trends and improve user and customer outcomes in Dynamics 365 Customer Service.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: concept-article
ms.collection:
ms.date: 11/17/2025
ms.custom: bap-template
---

# View and understand real-time analytics for record routing in the User group report (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Contact centers often group customer service representatives (service representatives or representatives) into user groups focused on specific intents or clusters of related intents. Real-time analytics use these groupings to monitor conversations, track key metrics, and uncover actionable insights. By filtering data by user group, supervisors can quickly spot trends, evaluate team performance, and accelerate case resolution. This structured approach ensures that the right experts handle the right customer needs driving operational efficiency, enhancing service quality, and boosting customer satisfaction.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

You can filter this report by **Time**, **Line of business**, **Intent group**, **Agent group**, **Time zone**, and **Work item status**.

As part of visual customization, all record routing dashboards including **Summary**, **Backlog work items**, **Ongoing work items**, **Queue**, and **Agent** reports can be filtered by intent group, intent, and line of business by using the **IntentFamilyName** in **DimIntent** dimension. Learn more in [visual customization](customize-reports.md). You can search for the data measures for intent to select specific intent-based filters.

:::image type="content" source="../media/record-routing-user-group.png" alt-text="Screenshot of real-time analytics for record routing user group report." lightbox="../media/record-routing-user-group.png":::

## Prerequisites

- You turned on the toggle for Customer Intent Agent and added the Line of business, Intent groups, and Intents. Learn more in [Customer Intent Agent](/dynamics365/contact-center/administer/manage-customer-intent-agent).
- You enabled real-time analytics for record routing for intent. Learn more in [Enable the real-time analytics for record routing dashboard](../administer/enable-record-routing.md#enable-the-real-time-analytics-for-record-routing-dashboard).

You see the report after 24 hrs of provisioning. If you don't enable Customer Intent Agent, you might still see data measures related to intent, but no conversation or case details appear because configuration isn't complete.            

## Metrics

|Metrics | Definition  |
|---------|---------|
|Ongoing work items   |    Number of ongoing work items.     |
|Agents online | Number of representatives logged in per intent group. |
|Agents in active work items|	Number of representatives currently with active record type work items. |
|Closed work items |Total number of record type work items currently in **Closed** status. |
|Total work items | Total number of record type work items.|
|Auto-assigned work items| By default, the system displays the number of record-type work items modified in the last two hours and are currently auto assigned to the representative.|
|Manually assigned work items| By default, the system displays the number of record-type work items modified in the last two hours and are currently manually assigned to the representative.|


## Metrics by agent group

|Metrics | Definition  |
|---------|---------|
|User group name  |    Name of the service representative group.     |
|Unassigned work items | By default, the system displays the number of record-type work items modified in the last two hours and are currently unassigned within the user group.|
|Assigned work items| By default, the system displays the number of record-type work items modified in the last two hours and are currently assigned  per user group. Assigned work items = Auto-assigned work items + Manually assigned work items. |
|Longest wait time | Waiting time until the representative accepts the work item per user group.|
|Agents online | Number of representatives logged in per user group.|
|Agents available| Number of representatives who are in **Available** status per user group.|

## Report drilldown 

Select **Detailed view** to view **Metrics by user group**.

:::image type="content" source="../media/record-routing-user-group-drilldown.png" alt-text="Screenshot of metrics by user group drilldown." lightbox="../media/record-routing-user-group-drilldown.png":::

|Metrics | Definition  |
|---------|---------|
|Unassigned work items	|By default, the system displays the number of record-type work items modified in the last two hours and are currently unassigned within the user group. |
|Agents online|	Number of representatives logged in within the specific user group.|
|Agents in active work items| Number of representatives who are in **Available ** status within the specific user group.|
|Auto assigned work items|	By default, the system displays the number of record-type work items modified in the last two hours per representative and are currently auto assigned to the representative.|
|Agent availability status|	Total number of representatives in the system based on their availability status.|
|Manually assigned work items|	By default, the system displays the number of record-type work items modified in the last two hours and are manually assigned to the representative.|
|Active sessions| By default, the system displays the number of active sessions the representative is currently in and modified in the last two hours.|
|Closed sessions|	By default, the system displays the number of sessions closed by the representative and updated in the last two hours.|

## Metrics by user group

|Metrics | Definition  |
|---------|---------|
| Agent name | Name of representative set to the specific intent. |
| Assigned work items | By default, the system displays the number of record type work items modified in the last two hours and   currently assigned to the specific representative. Assigned work items = Auto assigned work items + Manually assigned work items. |
| Transferred work items | Number of record type work items that are transferred to a representative and currently assigned to this representative.|
|Agents online | Number of representatives logged in per user group.|
|Agents available| Number of representatives who are in **Available** status per user group.|


## Related information

[Manage real-time analytics for record routing](../administer/enable-record-routing.md#manage-real-time-analytics-for-record-routing)  
[Overview of real-time analytics for record routing](rr-overview.md#overview-of-real-time-analytics-for-record-routing)  
[Record routing in the Intent group report](record-routing-intent-group.md)  