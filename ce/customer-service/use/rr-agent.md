---
title: View and understand real-time analytics for record routing in the agent report
description: Explore real-time analytics for agent reports. Use filters and KPIs to manage agent performance and address capacity limitations.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection: 
ms.date: 03/12/2025
ms.custom: bap-template
---

# View and understand real-time analytics for record routing in the agent report

[!INCLUDE [cc-rebrand-bot-agent](../../includes/cc-rebrand-bot-agent.md)]

The agent report provides an agent centric view for case and record
management. Time, Queue, Agent, Agent skill, Agent status and Time zone
are filters that enable you to drill into the data to identify agent
availability and capacity limitations to address unassigned work
items.  

A set of KPIs provide a quick insight into the filter scope. They
include Agents online, Agents available, Agents busy, and Agents at max
capacity.  

When you select a component in a chart, the data is filtered
accordingly. In this way, you can view data that is related to the
selected component only. For example, if you select the **Offline** component
in the **Agent availability status** chart, the dashboard is refreshed
and shows capacity that is essentially locked. The agent list table also
allows you to identify agents with the highest count of transferred work
items, which allows you to identify misassignments and to take
corrective steps.  

:::image type="content" source="../media/record-routing-agent.png" alt-text="Screenshot of the real-time analytics for agent report":::

### Lists and charts 

**Agent availability status:** This donut chart lists all agents in the
org that are assigned to any record type queue. It lists all the
availability statuses, including custom ones. When clicking on a status,
the filter is automatically applied to the entire tab. 

**Agent availability by capacity profiles:** This table lists all
capacity profiles, as well as logged in agents linked to the capacity
profiles and capacity in use, which allows you to identify assignment
bottle necks caused by lack of capacity. If capacity is occupied in
profiles with blocking assignment toggle turned on, the entry is
displayed in red. Clicking on *show more* displays this table with
detailed agent availability status, which can be another cause for
unassigned work items, besides capacity.

**Agent list:** The agent list table lists all agents associated with a
queue of record type.


|KPIs | Description  |
|---------|---------|
|Assigned agent   |   Name of customer service representative or AI agent.       |
|Status    |      Availability status of agent.     |
|Status since    |    Time stamp when agent entered current availability status.      |
|Active   |   Number of work items in active state assigned to agent during reporting period.       |
|Closed    |   Number of work items closed by an agent in the reporting period.       |
|Transfers    |   Number of work items agent transferred to queue or another agent in the reporting period.       |
|Average duration     | Average time conversations that were active and assigned to agent during reporting period.         |
|Accepted    | Number of conversations the agent accepted during the reporting period.         |
|Rejected    | Number of conversations the agent rejected when it was assigned during reporting period.         |
|Timeout     |   Number of conversations that timed out before the agent accepted or rejected during reporting period. This doesn’t apply to setups where cases are auto assigned.       |

When selecting an agent in the list you can open a detailed agent view
of that agent. This view includes:

- Agent name and account.

- Agent specific KPIs (in reporting period).

  - Active work items assigned to agent.

  - Closed work items.

  - Transferred work items.

  - Average conversation time.

- Agent skills by proficiency.

- Agent availability by capacity profiles.

- List of record conversations assigned to agent, including associated
  queue, conversation status and conversation creation date/time.

- Agent presence history.

:::image type="content" source="../media/record-routing-agent-drilldown.png" alt-text="Screenshot of the agent drilldown report":::

The agent list status column also allows you to set agent status by
agent. This can be very useful when there are unassigned work items and
agents with available capacity but not in the available status.

:::image type="content" source="../media/record-routing-agent-status.png" alt-text="Screenshot of the agent status report":::

## Related information

[Manage real-time analytics for record routing](../administer/enable-record-routing.md#manage-real-time-analytics-for-record-routing)  
[Overview of real-time analytics for record routing](rr-overview.md#overview-of-real-time-analytics-for-record-routing)  
[Summary report](rr-summary.md#view-and-understand-real-time-analytics-for-record-routing-in-the-summary-report)  
[Queue report](rr-queue.md#view-and-understand-real-time-analytics-for-record-routing-in-the-queue-report)   
[Ongoing work items report](rr-ongoingworkitems.md#view-and-understand-real-time-analytics-for-record-routing-in-the-ongoing-work-items-report)  
[Backlog work items report](rr-backlogitems.md#view-and-understand-real-time-analytics-for-record-routing-in-the-backlog-work-items-report)

