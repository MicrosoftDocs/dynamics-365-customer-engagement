---
title: Resource Scheduling Optimization version history
description: Version updates and updated features in the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service.
ms.date: 02/22/2024
ms.subservice: resource-scheduling-optimization
ms.topic: article
author: AnilMur
ms.author: anilmur
---

# Resource Scheduling Optimization version history

## Release schedule

When a new version of the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service releases, it becomes available in different geographic regions at different times. The following table shows, when the next release will become available in the region of your environment.

For information about other updates to Field Service, visit the [Dynamics 365 release plans](/dynamics365/release-plans/).
For information about older versions, see [Version history archive](version-history-archive.md#resource-scheduling-optimization-add-in).

|Station | Region | Current version | Next version |  Scheduled date
|------| -------|-------|-----|------|
|**Station 1** | | |  | |
| | *First Release* | [3.4.0.623](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340623) | [3.4.0.882](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340882) | 02/23/2024
|**Station 2** | | |  | |
| | *South America* | [3.4.0.623](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340623) | [3.4.0.882](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340882) | 03/01/2024
| | *Canada* | [3.4.0.623](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340623)  | [3.4.0.882](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340882) | 03/01/2024
| | *India* | [3.4.0.623](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340623) | [3.4.0.882](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340882) | 03/01/2024
| | *France* | [3.4.0.623](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340623) | [3.4.0.882](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340882) | 03/01/2024
| | *United Arab Emirates* | [3.4.0.623](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340623) | [3.4.0.882](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340882) | 03/01/2024
| | *South Africa* | [3.4.0.623](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340623) | [3.4.0.882](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340882) | 03/01/2024
| | *Germany* | [3.4.0.623](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340623)  | [3.4.0.882](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340882) | 03/01/2024
| | *Switzerland* | [3.4.0.623](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340623)  | [3.4.0.882](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340882) | 03/01/2024
|**Station 3** | |  |  | |
| | *Japan* |  [3.4.0.623](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340623)| [3.4.0.882](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340882) | 03/08/2024
| | *Asia Pacific* | [3.4.0.623](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340623) | [3.4.0.882](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340882) | 03/08/2024
| | *Great Britain* |[3.4.0.623](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340623) | [3.4.0.882](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340882) | 03/08/2024
| | *Oceania* | [3.4.0.623](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340623) | [3.4.0.882](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340882) | 03/08/2024
|**Station 4** | |  |  | |
| | *Europe* | [3.4.0.623](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340623) | [3.4.0.882](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340882) | 03/15/2024
|**Station 5** | |  |  | |
| | *North America* | [3.4.0.623](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340623) | [3.4.0.882](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340882) | 03/22/2024

>[!NOTE]
>
> - Dates in all regions indicate the timing of the next automatic update. While most updates should be complete on the scheduled night, updates requiring more time may be completed during dark hours over the weekend indicated in the **Scheduled date** column.

## 3.4.0.882

This release has improved diagnostic logging, as well as a fix for a bug where bookings [locked to a resource](booking-lock-options.md) would occasionally fail to get optimized to other time frames. In addition, this release prevents the install or upgrade of Resource Scheduling Optimization if the environment is set to [block unmanaged customizations](https://learn.microsoft.com/power-platform/alm/block-unmanaged-customizations). This flag must be disabled in order to install or upgrade Resource Scheduling Optimization.


## 3.4.0.623

This release introduces two new features:

- Support for optimizing [multi-day requirements](rso-multi-day.md).
- When schedulers optimize a single resource's schedule, [the system considers additional requirements](rso-single-resource-optimization.md) and their scheduled bookings.

## 3.4.0.495

This release is the same as 3.4.0.459, with a more efficient solution delivery mechanism.

## 3.4.0.459

Bug fix: Addressed issue where resource schedules were incorrectly ignored when there's a booking overlapping with optimization range start or end time.

## 3.4.0.254

- Bug fix: Addressed an issue with using the Optimization panel in [Single Resource Optimizations](/dynamics365/field-service/single-resource-optimization#run-after-making-changes-to-defaults)
- Behavior change: We're changing the behavior of how Resource Scheduling Optimization handles locks on bookings. Currently, if an optimization schedule is running, it might lock bookings, which prevents a user from being able to delete the booking via Schedule Board. The user would be required to manually unlock the booking before deleting it. With this release, a request to delete a booking by a schedule board user overrides any locking by Resource Scheduling Optimization.

## 3.4.0.180

- Bug fix: Addressed issue where certain schedule requests fail due to a timeout, with the message *Resource Scheduling Optimization failed to create, update or delete some of the bookings due to a system error*.
- Bug fix: Addressed issue where certain schedule requests produced overlapping bookings when using locked resources or by requirement duration and book duration mismatch.
- Bug fix: Addressed issue where unpublished schedules would get inadvertently published after a platform update.

## 3.4.0.72

- Fixed optimization request errors:
  - System failed to optimize some records. Inner error(s): The primal integer program model is infeasible or unbounded: optimization status = InfeasibleOrUnbounded.
  - System failed to optimize some records. Inner error(s): An exception was thrown while activating F1.RoutingEngine.PathSolver.PathSolver.

## 3.4.0.8

- Resource Scheduling Optimization always honors locked bookings and no longer overlaps them.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
