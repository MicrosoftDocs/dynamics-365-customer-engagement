---
title: View and understand real-time analytics for record routing in the queue report
description: Learn to view and understand real-time analytics for queue reports. Improve your data insights and decision-making.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: concept-article
ms.collection:
ms.date: 11/07/2025
ms.custom: bap-template
---

# View and understand real-time analytics for record routing in the queue report

The queue report lists all the advanced queues in the organization in a table by default. You can filter content by modified on, individual queue, agent, work item status, work item skill, and time zone. By default, the time filter displays data from the last 2 hours. You can also view data from the last 24 hours. [Learn how to access the report](rr-overview.md#access-reports).

> [!NOTE]
> This report shows entity record type queues only.

:::image type="content" source="../media/record-routing-queue.png" alt-text="Screenshot real-time analytics for queue report":::

The queue table has the following sortable columns:

|KPI |Description |
|---------|---------|
|Queue    |    Name of entity record queue.    |
|Queue priority| Priority of the queue. |
|Assigned work items    | Work items that are assigned to customer service representative (service representative or representative) during the reporting period.       |
|Unassigned work items| Work items during reporting period that aren't yet assigned to a service representative, and that include transfers to queue.|
|Longest wait time| Longest time for a work item during reporting period in queue until the status changed from open to active (assigned).|
|Agents online| Service representatives assigned to queue who are online. |

Since the table can be sorted by queue, queue priority, assigned and unassigned work items, longest wait time, and agents online, you can quickly identify queues that might need attention and take steps to improve the customer experience. For example, if you sort by unassigned cases or longest wait time, you can ensure that enough agents and agent capacity are available to handle the backlog efficiently.

When a queue is selected in the table, queue work items can be listed as an embedded ongoing work items table for easy management using the **Detailed view** option.

## Related information

[Manage real-time analytics for record routing](../administer/enable-record-routing.md#manage-real-time-analytics-for-record-routing)  
[Overview of real-time analytics for record routing](rr-overview.md#overview-of-real-time-analytics-for-record-routing)  
[Summary report](rr-summary.md#view-and-understand-real-time-analytics-for-record-routing-in-the-summary-report)  
[Agent report](rr-agent.md#view-and-understand-real-time-analytics-for-record-routing-in-the-agent-report)  
[Backlog work items report](rr-backlogitems.md#view-and-understand-real-time-analytics-for-record-routing-in-the-backlog-work-items-report)  
[Ongoing work items report](rr-ongoingworkitems.md#view-and-understand-real-time-analytics-for-record-routing-in-the-ongoing-work-items-report)
