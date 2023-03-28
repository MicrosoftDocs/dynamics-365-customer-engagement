---
title: Reports overview
description: This article explains what reports are and lists available reports in Dynamics 365 Field Service and the Resource Scheduling Optimization Add-in.
author: FeifeiQiu
ms.author: feiqiu
ms.reviewer: mhart
ms.service: dynamics-365-field-service
ms.topic: overview 
ms.date: 02/09/2023
ms.custom: bap-template 
---

# Reports overview

Reports are a collection of charts and visuals, built with Microsoft Power BI. They're based on a data set to get a quick view into core metrics. Resource and operations managers can monitor key operational metrics to gauge the performance of resources and their scheduling strategy. Reports can help explore important business-related questions, such as:

- Are my resources being used efficiently over a given time period?
- What is the average discrepancy between estimated and actual completion times for tasks and work orders?
- Are tasks and resources being matched effectively?

With answers to these questions, scheduling managers can develop an effective resource scheduling strategy and that saves cost and time and improves customer experiences.

Dynamics 365 Field Service and the Resource Scheduling Optimization Add-in provide reports that focus on different scenarios and user needs:

1. The [Resource and utilization report](resource-utilization-report.md), which is included with Field Service.
1. The [Work order summary report](work-order-summary-report.md), which is included with Field Service.
1. The [Admin report](rso-admin-report.md), included with the Resource Scheduling Optimization Add-in.
1. The [Optimization summary report](rso-optimization-summary-report.md), included with the Resource Scheduling Optimization Add-in.
1. [Predictive work duration reports (preview)](analytics-predictive-work-duration.md) with the upcoming work duration and the territory duration reports in Field Service.

Other than editing filters and drill-down actions, the reports aren't configurable or customizable.

## Prerequisites

Reports are only available to users with **System Administrator** or **Field Service-Administrator** security roles.

| Report name              | Required apps                                                |
|--------------------------|--------------------------------------------------------------|
| Resource and utilization | Field Service                                                |
| Work order summary       | Field Service                                                |
| Admin report             | Field Service<br>Resource Scheduling Optimization Add-in     |
| Optimization summary     | Field Service<br>Resource Scheduling Optimization Add-in     |
| Predictive work duration | Field Service                                                |

## Refresh cadence and data retention

The system refreshes the reports automatically once a day (every 24 hours). The report shows a time stamp in the top right corner when it was last updated.

A warning icon next to the time stamp on the report indicates a delay or an issue with the data refresh. Contact your system administrator to investigate or open a support ticket if the issue persists.

The system pauses the data refresh for reports that aren't opened for two weeks. When a user opens the report again, data will get refreshed in the next refresh cycle.

Report data get retained for 24 months. Storage file size automatically increases when using analytics features. If this increase causes issues or concerns, contact Microsoft Support.

## Provide report access to a security role

By default, only administrators have access to the resource duration report. Administrators can provide access to others through security roles.

1. In Field Service, go to **Advanced Settings**.

1. Go to **Settings** > **Security**.

1. Go to **Security Roles**.

1. Select the security role that needs access to the reports (for instance, **Field Service – Dispatcher**).

1. Go to the **Custom Entities**.

1. Select the Read privilege for a report entity.

    - Resource duration (preview) - predictive duration report
    - Predictive duration (preview) - predictive duration report
    - Field Service historical analytics - work order summary report
    - Resource scheduling historical analytics - admin and optimization summary report

1. **Save and Close**.

Now the **Field Service - Dispatcher** can see the corresponding report.

## Supported regions for reports

| Region | Name |
| --- | --- |
| North America| NAM |
| South America | SAM |
| Canada | CAN |
| Europe | EUR |
| Asia Pacific Japan | APJ |
| Australia | OCE |
| Japan| JPN |
| India | IND |
| United Kingdom | UK |
| United Arab Emirates | UAE |

## Data model

The system uses the following list of entities to generate reports. If there's no data or you've customized these entities, parts of it may show blank.

Field Service entities:

- *bookableresource*
- *bookableresourcebooking*
- *msdyn_resourcerequirement*
- *territory*
- *calendarrule*
- *bookableresourcegroup*
- *bookingstatus*
- *msdyn_bookingtimestamp*
- *organization*

Resource Scheduling Optimization entities:

- *resource*
- *bookableresource*
- *territory*
- *bookableresourcebooking*
- *msdyn_optimizationrequestbooking*
- *msdyn_resourcerequirement*
- *msdyn_priority*
- *msdyn_routingoptimizationrequest*
- *msdyn_routingprofileconfiguration*
- *calendar*
- *calendarrule*
- *bookableresourcegroup*
- *bookingstatus*
- *organization*

## Next steps

- [Resource and utilization report](resource-utilization-report.md)
- [Optimization summary report](rso-optimization-summary-report.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
