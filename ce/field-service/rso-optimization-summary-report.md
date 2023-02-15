---
title: Optimization summary report
description: This article contains information about the optimization summary report and the charts it contains.
author: FeifeiQiu
ms.author: feiqiu
ms.reviewer: mhart
ms.service: dynamics-365-field-service
ms.subservice: resource-scheduling-optimization
ms.topic: conceptual 
ms.date: 02/09/2023
ms.custom: bap-template 
search.app: 
  - D365CE
  - D365FS
---

# Optimization summary report

The optimization summary report is available in the Resource Scheduling Optimization add-in. It analyzes, such as an analysis of minimized travel time.
The optimization summary report in the Resource Scheduling Optimization add-in analyzes the automatically scheduled bookings in and the effect they had on the business.

## Before you start

To run the report, the resource scheduling optimization administrator needs to publish at least one [optimization schedule](rso-optimization-schedule.md).  

## Filters and slicers

- **Schedule name**: Name of the [optimization schedule](rso-optimization-schedule.md).
- **Optimization request**: [List of jobs](rso-schedule-optimization.md#monitoring-optimization-requests) that ran to optimize schedules.

## Report metrics

To access the admin report, open the **Resource Scheduling Optimization** app and go to **Analytics** > **Reports**.

> [!div class="mx-imgBorder"]
> ![Screenshot of a resource scheduling optimization summary report.](./media/scheduling-analytics-rso-summary.png)

### Booking scheduled

Total number of bookings scheduled.

### Resource allocated

Number of resources allocated.

### Work time allocated (hrs.)

The total work time of all allocated resources.

### Travel time allocated (hrs.)

Sum of the travel time of all allocated resources.

### Total time allocation (hrs.)

Distribution of work time and travel time in the scheduled bookings.

### Resource time allocation

List of each resource's scheduled bookings, locked bookings, work time, and travel time. Overbooked resources are highlighted.

### Least allocated resource

Ranks the resources by lowest utilization to help dispatchers assign jobs on short notice.

### Territory summary

Shows optimized territories on a map with the ability to drill down.

### Booking metrics by territory

List of scheduled bookings, work time allocated, and travel time allocated for each territory.

## Next steps

- [Reports overview](reports.md)
- [Resource and utilization report](resource-utilization-report.md)
- [Optimization summary report](rso-optimization-summary-report.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
