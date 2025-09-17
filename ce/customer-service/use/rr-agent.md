---
title: View and understand real-time analytics for record routing in the agent report
description: Explore real-time analytics for agent reports. Use filters and KPIs to manage agent performance and address capacity limitations.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection: 
ms.date: 09/16/2025
ms.custom: bap-template
---

# View and understand real-time analytics for record routing in the agent report

[!INCLUDE [cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

The agent report provides an agent-centric view for case and record management. Modified on, queue, agent, agent skill, agent status, and time zone are filters that enable you to drill into the data to identify agent availability and capacity limitations to address unassigned work items. [Learn how to access the report](rr-overview.md#access-reports).

:::image type="content" source="../media/record-routing-agent.png" alt-text="Screenshot of agent report":::

A set of KPIs helps provide quick insight into the filter scope.


|KPIs |Description |
|---------|---------|
|Ongoing work items     |   Number of record type work items modified in the last 24 hours, and are ongoing currently, and includes open and active work items.      |
|Unassigned work items    |  Number of record type work items modified in the last 24 hours and are unassigned currently.       |
|Agents online    |   Number of customer service representatives (service representatives or representatives) who are online.    |
|Agents with active workitems   |Number of representatives, irrespective of presence status, who have active work items assigned. |

## Lists and charts

**Agent availability status:** The donut chart lists all agents in the organization who are assigned to any record-type queue. It lists all the availability statuses, including custom statuses. When you select a status, the filter is automatically applied to the entire component. For example, if you select the **Busy** component in the **Agent availability status** chart, the system refreshes the dashboard, and then shows capacity that's busy. 

**Agent availability by capacity profiles:** The table lists all capacity profiles and signed-in agents who are linked to the capacity profiles and capacity in use. This data helps you identify areas where lack of capacity causes assignment bottlenecks. If capacity is occupied in profiles with the blocking assignment toggle turned on, the entry is displayed in red. Select **show more** to view detailed agent availability status, which can be another cause for unassigned work items.

**Agent list:** The agent list has all agents associated with a queue of record type. It has **Agent online**, **Agent offline**, and **Agents with sessions** tabs.

**Agent online** and **Agent offline** provide the following information: 

|KPIs  |Description |
|---------|---------|
|Agent name    |  Name of the representative. |
|Status    |  Current presence status of the representative.       |
|Status since    | Time from when the representative is in the current status.        |
|Domain name    |    Domain name of the representative.     |

**Agents with sessions** provide the following information: 

|KPIs | Description  |
|---------|---------|
|Agent name   |   Name of the representative.   |
|Status    |      Current presence status of the representative.   |
|Status since    |    Time stamp when the representative entered their current status.      |
|Active  sessions |  Number of active sessions the representative is in, and modified in the last 24 hours. |
|Closed  sessions  |   Number of closed sessions the representative is in, and modified in the last 24 hours. |
|Manually assigned sessions| Number of sessions manually assigned to the representative, which are modified in the last 24 hours. These sessions can be both active and closed.|
|Autoassigned sessions| Number of sessions autoassigned to the representative, which are modified in the last 24 hours. These sessions can be both active and closed.|
|Domain name| Domain name of the representative.|

When selecting an agent in the list, you can open a detailed agent view of that agent. This view includes:

- Agent name and account.

- Agent-specific KPIs (in reporting period).

  - Active work items assigned to agent.

  - Closed work items.

  - Transferred work items.

  - Average conversation time.

- Agent skills by proficiency.

- Agent availability by capacity profiles.

- List of record conversations assigned to agent, including associated queue, conversation status, and conversation creation date/time.

- Agent presence history.

:::image type="content" source="../media/record-routing-agent-drilldown.jpg" alt-text="Screenshot of agent drill-down":::

The agent list status column also allows you to set agent status by agent, which can be useful when there are unassigned work items and
agents with available capacity but not showing an available status.

:::image type="content" source="../media/record-routing-agent-status.png" alt-text="Screenshot of the agent status report":::

### Related information

[Manage real-time analytics for record routing](../administer/enable-record-routing.md#manage-real-time-analytics-for-record-routing)  
[Overview of real-time analytics for record routing](rr-overview.md#overview-of-real-time-analytics-for-record-routing)  
[Summary report](rr-summary.md#view-and-understand-real-time-analytics-for-record-routing-in-the-summary-report)  
[Queue report](rr-queue.md#view-and-understand-real-time-analytics-for-record-routing-in-the-queue-report)  
[Ongoing work items report](rr-ongoingworkitems.md#view-and-understand-real-time-analytics-for-record-routing-in-the-ongoing-work-items-report)  
[Backlog work items report](rr-backlogitems.md#view-and-understand-real-time-analytics-for-record-routing-in-the-backlog-work-items-report)

