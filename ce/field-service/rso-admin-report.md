---
title: Resource Scheduling Optimization admin report
description: This article explains how the admin report in the Resource Scheduling Optimization Add-in works.
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

# Resource Scheduling Optimization admin report

The admin report in the Resource Scheduling Optimization Add-in analyzes when and how Resource Scheduling Optimization runs, but not the actual booking results.

## Before you start

To run the report, the Resource Scheduling Optimization administrator needs to publish at least one [optimization schedule](rso-optimization-schedule.md).  

## Filters and slicers

- **Schedule name**: Name of the [optimization schedule](rso-optimization-schedule.md).
- **Optimization request**: [List of jobs](rso-schedule-optimization.md#monitoring-optimization-requests) that ran to optimize schedules.

## Report metrics

To access the admin report, open **Resource Scheduling Optimization** and go to **Analytics** > **Reports**.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Resource Scheduling Optimization admin report.](./media/scheduling-analytics-rso-admin.png "Screenshot of the Resource Scheduling Optimization admin report.")

### Optimization Scope

Number of bookings, requirements, and resources in the selected schedule requests.

### Optimization E2E time (mins)

Time in minutes to run the optimization job from start to finish.

### Number of failed optimization requests

Number of failed optimization requests in the selected schedule requests.

## Next steps

- [Learn about other reports](reports.md)
- [Create an optimization schedule](rso-optimization-schedule.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
