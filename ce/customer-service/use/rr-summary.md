---
title: View and understand real-time analytics for record routing in the summary report
description: Learn how to analyze and manage queue distribution and capacity use efficiency with real-time analytics for record routing summary report.
author: Soumyasd27
ms.author: sdas
ms.reviewer: sdas
ms.topic: conceptual 
ms.collection:
ms.date: 03/12/2025
ms.custom: bap-template
---

# View and understand real-time analytics for record routing in the summary report

The Summary report appears by default when you select the real-time analytics for record routing dashboard in the Customer Service workspace or the Contact Center workspace app. You can filter this report by time, queue, agent, workstream, work item status, work item skill and time zone. The time filters that are available include **Last 24 hrs** and **Today**.

The Summary report provides a summary of cases and records over time, by workstream or queue. Statistics about the workstream that a work item was created against can help you analyze and manage queue distribution and capacity use efficiency. For example, a high rate of unassigned work items can lead to decreased customer satisfaction. To address the rate of unassigned work items or long wait times before cases are assigned, you can examine operational metrics such as agent availability and case distribution for available agent capacity in real time. 

By editing the visual display, you can add metrics to those that are already shown on the Summary report. Learn more in [Customize visual display](customize-reports.md#customize-visual-display).

:::image type="content" source="../media/record-routing-summary.png" alt-text="Screenshot of real-time analytics Summary report for record routing":::


|KPIs| Description  |
|---------|---------|
|Assigned work items    |   Measure of the total number of assigned work items, irrespective of work item state, which is every state, including open and closed.      |
|Unassigned work items    |  Measure of the total number of unassigned work items, irrespective of work item state.       |
|Work items over time   |   Used in the stacked column chart in real-time analytics for record routing, this metric shows the number of work items in an assigned and unassigned state, projected over the created-on time in the x-axis.      |

### Interactive charts

You can view different types of charts in the report, such as bar, horizontal bar, and donut charts. The visual display helps you discern
changes and patterns in the data, so that you can act quickly to address the most important issues.

When you select a component in a chart, the data is filtered accordingly. This way, you can view data that is related to the selected component only. For example, if you select the **Offline** component in the **Agent availability status** chart, the dashboard is refreshed and shows only work items of agents who are currently in the **Offline** state.

The **Agent availability by capacity** chart also offers a drill-down view that lists agent availability in more details per workstream.

## Related information

[Manage real-time analytics for record routing](../administer/enable-record-routing.md#manage-real-time-analytics-for-record-routing)  
[Overview of real-time analytics for record routing](rr-overview.md#overview-of-real-time-analytics-for-record-routing)  
[Queue report](rr-queue.md#view-and-understand-real-time-analytics-for-record-routing-in-the-queue-report)  
[Agent report](rr-agent.md#view-and-understand-real-time-analytics-for-record-routing-in-the-agent-report)  
[Ongoing work items report](rr-ongoingworkitems.md#view-and-understand-real-time-analytics-for-record-routing-in-the-ongoing-work-items-report)  
[Backlog work items report](rr-backlogitems.md#view-and-understand-real-time-analytics-for-record-routing-in-the-backlog-work-items-report) 
