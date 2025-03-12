---
title: View and understand real-time analytics for the queue report
description: Learn to view and understand real-time analytics for queue reports. Improve your data insights and decision-making.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual
ms.collection:
ms.date: 03/12/2025
ms.custom: bap-template
---

# View and understand real-time analytics for the queue report

The queue report lists all the advanced queues in the organization in a
table by default. Content can be filtered by individual queue, time,
agent, workstream, work item status, work item skill and time zone. 

:::image type="content" source="../media/record-routing-queue.png" alt-text="Screenshot real-time analytics for queue report":::

The queue table has the following sortable columns: 


|KPI |Description |
|---------|---------|
|Queue    |    Name of queue     |
|Assigned work items    | Work items assigned to customer service representative (service representative or representative) during reporting
  period.         |
|Unassigned work items| Cases during reporting period that haven’t
  yet been assigned to a service representative, which include transfers to queue.|
|Longest wait time| Longest time for a case during reporting period
  in queue until status changed from open to active (assigned)|
|Agents available| Lists the number of service representatives per queue that have
  presence set to Available. |
|Agents online| Service representatives assigned to queue that are online. |

Because the table allows for sorting by Assigned cases, Unassigned
cases, Longest wait time, Agents available, and Logged in agents, you can
easily identify queues where corrective action needs to be taken to
provide a smooth customer experience. For example, if you sort by
unassigned cases or longest wait time, you can ensure that enough agents
and agent capacity is available to handle the backlog efficiently. 

When a queue is selected in the table, queue work items can be listed as
an embedded ongoing work items table for easy management via the
**Detailed view** option.

## Related information

[Manage real-time analytics for record routing](../administer/enable-record-routing.md#manage-real-time-analytics-for-record-routing)  
[Overview of real-time analytics for record routing](rr-overview.md#overview-of-real-time-analytics-for-record-routing)
[Summary report](../use/rr-summary.md#view-and-understand-real-time-analytics-for-the-summary-report)  
[Agent report](rr-agent.md#view-and-understand-real-time-analytics-for-the-agent-report) ](../use/rr-agent.md#view-and-understand-real-time-analytics-for-the-agent-report)  
[Ongoing work items report](rr-ongoingworkitems.md#view-and-understand-real-time-analytics-for-the-ongoing-work-items-report)
[Backlog work items report](../use/rr-backlogitems.md#view-and-understand-real-time-analytics-for-the-backlog-work-items-report) 