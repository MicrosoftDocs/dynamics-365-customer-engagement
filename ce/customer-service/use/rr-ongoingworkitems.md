---
title: View and understand real-time analytics for record routing in the ongoing work items report
description: Understand real-time analytics for ongoing work items. Identify and triage new items quickly. Assign, transfer, or close items from the dashboard.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 03/12/2025
ms.custom: bap-template
---

# View and understand real-time analytics for record routing in the ongoing work items report

The Ongoing work items report lists all open and active state work items
that have been modified in the past 24 hours or today per time zone
setting. Content can be filtered by time, queue, agent, workstream, work
item skill, and time zone.  

This report is specifically for real-time tracking of recent cases or
records. In this view, you can easily identify work items that are
created but aren't assigned to a customer service representative (service representative or representative). It can help you ensure that all new work items that need attention are triaged. Work items can be assigned, transferred, or force closed from within the
dashboard. 

For longer time periods, you can use [the backlog work items report](rr-backlogitems.md#view-and-understand-real-time-analytics-for-record-routing-in-the-backlog-work-items-report).

:::image type="content" source="../media/record-routing-ongoingworkitems.png" alt-text="Screenshot of the real-time analytics for ongoing work items report.":::

|KPIs|Description  |
|---------|---------|
|Subject     |   Case or Record title      |
|Queue    |     Queue that the work item is routed to.    |
|Status    |  Open or active, where open hasn't been assigned to a service representative. |
|Work item age    |Time in days since case or record was created.|
|Assigned agent   |The service representative the work item is assigned to.         |
 |Created on    |    Date and time stamp of when the work item was created.      |
|Case    |   Unique number ID of conversation linked case record.      |
|Priority   |  Priority of conversation linked case record.       |


When a list item is selected, it can be assigned to a service representative,
transferred to another queue or force closed. 

> [!NOTE]
> When a work item is transferred to a different queue, it could affect
  automatic assignment since the criteria for assignment doesn’t change
  upon transfer. In scenarios of push (automatic assignment),
  supervisors need to ensure that the destination queue has users who
  meet the criteria for work item assignment.   

**Force close** closes the work item (conversation) but not the case. 

When you assign or transfer a selected work item, an assign or transfer
conversation dialog appears. This dialog allows you to identify the best
matching representative or queue (assign only) for the activity, by displaying a
list of matching representatives with availability, capacity and skill
proficiency match.

:::image type="content" source="../media/record-routing-assign-conversation.png" alt-text="Screenshot of the ongoing work items conversation report.":::

## Related information

[Manage real-time analytics for record routing](../administer/enable-record-routing.md#manage-real-time-analytics-for-record-routing)  
[Overview of real-time analytics for record routing](rr-overview.md#overview-of-real-time-analytics-for-record-routing)  
[Summary report](rr-summary.md#view-and-understand-real-time-analytics-for-record-routing-in-the-summary-report)  
[Queue report](rr-queue.md#view-and-understand-real-time-analytics-for-record-routing-in-the-queue-report)  
[Agent report](rr-agent.md#view-and-understand-real-time-analytics-for-record-routing-in-the-agent-report)  
[Backlog work items report](rr-backlogitems.md#view-and-understand-real-time-analytics-for-record-routing-in-the-backlog-work-items-report)