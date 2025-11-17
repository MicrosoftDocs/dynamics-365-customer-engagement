---
title: View and understand real-time analytics for record routing in the User group report
description: Learn how to filter and analyze real-time metrics in the User group report to identify trends and improve user and customer outcomes.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 11/17/2025
ms.custom: bap-template
---

# View and understand real-time analytics for record routing in the User group report (preview)

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Contact centers often organize service representatives into user groups or user groups dedicated to handling specific intents or intent clusters. Real-time analytics leverage these groupings to monitor conversations, track metrics, and surface actionable insights. Filtering by agent group enables supervisors to quickly identify trends, assess team performance, and resolve cases faster. This structured approach ensures that the right specialists address the right customer needs, driving operational efficiency, improving service quality, and boosting customer satisfaction.

[!INCLUDE [preview-note](~/../shared-content/shared/preview-includes/preview-note-d365.md)]

:::image type="content" source="../media/agent-group-record-routing.png" alt-text="Screenshot of user group report for record routing." lightbox="../media/agent-group-record-routing.png":::

You can filter this report by **Duration**, **Line of Business**, **Agent group**, **Intent group**, **Work item status**, and **Time**.

As part of visual customization, all record routing dashboards including **Summary**, **Backlog work items**, **Ongoing work items**, **Queue**, and **Agent** reports can be filtered by intent group, intent, and line of business by using the **IntentFamilyName** in **DimIntent** dimension. Learn more in [visual customization](customize-reports.md). You can search for the data measures for intent to select specific intent-based filters.

## Prerequisites

- You turned on the toggle for Customer Intent Agent and added the Line of business, Intent groups, and Intents. Learn more in [Customer Intent Agent](/dynamics365/contact-center/administer/manage-customer-intent-agent).
- You enabled real-time analytics for record routing for intent. Learn more in [Enable the real-time analytics for record routing dashboard](../administer/enable-record-routing.md#enable-the-real-time-analytics-for-record-routing-dashboard).

You see the report after 24 hrs of provisioning. If you don't enable Customer Intent Agent, you might still see data measures related to intent. However, you don't see any conversation or case-related information in the report.             

## Metrics per user group

|Metrics | Definition  |
|---------|---------|
|Ongoing work items   |    Number of work items that are ongoing and not closed      |
|Agents online | Number of customer service representatives (service representatives or representatives) who have logged in per intent group|
|Agents in active work items|	Number of customer service representatives (service representatives or representatives) that are currently with active record type work items. |
|Closed work items |Total number of record type work items that are currently in closed status |
|Total work items | Total work items|
|Auto assigned work items| Number of work items auto assigned to the representative and modified in the last 2 hours.|
|Manually assigned work items| Number of work items manually assigned to the representative and modified in the last 2 hours.|


## Metrics by user group

|Metrics | Definition  |
|---------|---------|
|Agent group name  |    Name of the service representative group      |
|Unassigned work items | Number of record type work items modified in the last 2 hours and are unassigned currently within the user group|
| Assigned work items|Number of record type work items modified in the last 2 hours and are assigned currently per user group. Assigned work items = Auto assigned work items + Manually assigned work items. |
|Longest wait time | Waiting time until the agent accepts the work item per user group.|
| Agents online|Number of customer service representatives (service representatives or representatives) who have logged in per user group|
| Agents available| Number of customer service representatives (service representatives or representatives) who are in Available status per user group|

## Drilldown metrics

|Metrics | Definition  |
|---------|---------|
|Unassigned work items	|Number of record type work items modified in the last 2 hours and are unassigned currently within the user group|
|Agents online|	Number of customer service representatives (service representatives or representatives) who have logged in within the specific user group|
|Agents in active work items|	Number of customer service representatives (service representatives or representatives) who are in Available status within the specific user group|
|Auto assigned work items|	Number of work items auto assigned to the representative, and modified in the last 2 hours per agent|
|Agent availability status|	Total number of agents in the system based on their availability status|
|Manually assigned work items|	Number of work items manually assigned to the representative and modified in the last 2 hours.|
|Active sessions|	Number of active sessions the representative is in, and modified in the last 2 hours.|
|Closed sessions	Number of closed sessions the representative is in, and modified in the last 2 hours.|

## Metrics by user

|Metrics | Definition  |
|---------|---------|
| Agent name | Name of agent set to the specific intent |
| Assigned work items | Number of record type work items modified in the last 2 hours and are assigned currently to specific agent Assigned work items = Auto assigned work items + Manually assigned work items. |
| Transferred work items | Number of record type work items that are transferred to an agent and currently assigned to this agent |
| Active sessions | Number of active sessions the representative is in, and modified in the last 2 hours. |
| Closed sessions | Number of closed sessions the representative is in, and modified in the last 2 hours. |


## Drill-down 

Drilldown on the **Metrics by agent group**, select **Detailed view** to view **Metrics by agent group**.

## Related information

[Manage real-time analytics for record routing](../administer/enable-record-routing.md#manage-real-time-analytics-for-record-routing)  
[Overview of real-time analytics for record routing](rr-overview.md#overview-of-real-time-analytics-for-record-routing)  
[Record routing in the Intent group report](record-routing-intent-group.md)

