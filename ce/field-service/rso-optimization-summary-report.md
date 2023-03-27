---
title: Optimization summary report
description: This article provides information about the optimization summary report and the charts it contains.
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

The optimization summary report in the Resource Scheduling Optimization Add-in analyzes automatically scheduled bookings and the effect they had on the business.

## Before you start

To run the report, the Resource Scheduling Optimization administrator needs to publish at least one [optimization schedule](rso-optimization-schedule.md).  

## Filters and slicers

- **Schedule name**: Name of the [optimization schedule](rso-optimization-schedule.md).
- **Optimization request**: [List of jobs](rso-schedule-optimization.md#monitoring-optimization-requests) that ran to optimize schedules.

## Report metrics

To access the admin report, open **Resource Scheduling Optimization** and go to **Analytics** > **Reports**.

> [!div class="mx-imgBorder"]
> ![Screenshot of a Resource Scheduling Optimization summary report.](./media/scheduling-analytics-rso-summary.png "Screenshot of a Resource Scheduling Optimization summary report.")

### Booking scheduled

Total number of bookings scheduled.

### Resources allocated

Number of resources allocated.

### Work time allocated (hrs.)

The total work time of all allocated resources.

### Travel time allocated (hrs.)

Sum of the travel time of all allocated resources.

### Total times allocation (hrs.)

Distribution of work time and travel time in the scheduled bookings.

### Resource time allocation

List of each resource's scheduled bookings, locked bookings, work time, and travel time. Overbooked resources are highlighted.

### Least allocated resources

Ranks the resources by lowest usage to help dispatchers assign jobs on short notice.

### Territory summary

Shows optimized territories on a map with the ability to drill down.

### Booking metrics by territory

List of scheduled bookings, work time allocated, and travel time allocated for each territory.

## Next steps

- [Reports overview](reports.md)
- [Resource and utilization report](resource-utilization-report.md)
- [Optimization summary report](rso-optimization-summary-report.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
