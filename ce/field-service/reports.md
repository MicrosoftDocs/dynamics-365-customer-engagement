---
title: Reports overview
description: This article explains what reports are lists available reports in Dynamics 365 Field Service and the Resource Scheduling Optimization add-in.
author: FeifeiQiu
ms.author: feiqiu
ms.reviewer: mhart
ms.service: dynamics-365-field-service
ms.topic: overview 
ms.date: 01/11/2023
ms.custom: bap-template 
---

# Reports overview

Reports are a collections of charts and visuals, built with Microsoft Power BI. They are based on a data set to get a quick view into core metrics. Resource and operations managers can monitor key operational metrics to gauge the performance of resources and their scheduling strategy. Reports can help explore important business-related questions, such as:

- Are my resources being utilized efficiently over a given time period?
- What is the average discrepancy between estimated and actual completion times for tasks and work orders?
- Are tasks and resources being matched effectively?

With answers to these questions, scheduling managers can develop an effective resource scheduling strategy and that saves cost and time and improves customer experiences.

Dynamics 365 Field Service and the Resource Scheduling Optimization add-in provide reports that focus on different scenarios and user needs:

1. The [Resource and utilization report](resource-utilization-report.md), which is included with Field Service.
1. The [Work order summary report](work-order-summary-report.md), which is included with Field Service.
1. The [Admin report](rso-admin-report.md), included with the Resource Scheduling Optimization add-in.
1. The [Optimization summary report](optimization-summary-report.md), included with the Resource Scheduling Optimization add-in.
1. [Predictive work duration (preview)](analytics-predictive-work-duration.md) with the upcoming work duration and the territory duration reports in Field Service.

Other than editing filters and drill down, the reports aren't configurable or customizable.

## Prerequisites

Reports are only available to users with **System Administrator** or **Field Service-Administrator** security roles.

| Report name              | Required apps                                                |
|--------------------------|--------------------------------------------------------------|
| Resource and utilization | Field Service                                                |
| Work order summary       | Field Service                                                |
| Admin report             | Field Service<br>Resource Scheduling Optimization add-in     |
| Optimization summary     | Field Service<br>Resource Scheduling Optimization add-in     |
| Predictive work duration | Field Service                                                |

## Refresh cadence and data retention

The system refreshes the reports automatically once a day (every 24 hours). The report shows a time stamp in the top right corner when it was last updated.

A warning icon next to the time stamp on the report indicates a delay or an issue with the data refresh. If the data has not been refreshed in the last 24 hours, you'll see a tooltip message when you hover over the icon. Contact your system administrator to investigate or open a support ticket if the issue persists.

The system pauses the data refresh for reports that aren't opened for two weeks. When a user opens the report again, data will get refreshed in the next refresh cycle.

Report data get retained for 24 months. Storage file size automatically increases when using analytics features. If this increase causes issues or concerns, contact Microsoft Support.

## Supported regions for reports

| Region | Name |
| --- | --- |
| North America| NAM |
| South America | SAM |
| Canada | CAN |
| Europe | EUR |
| Asia Pacific Japan |APJ |
| Australia | OCE |
| Japan| JPN |
| India | IND |
| Great Britain |GBR |

## Next steps

- [Apply filters to reports](filter-report.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
