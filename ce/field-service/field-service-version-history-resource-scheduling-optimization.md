---
title: "Resource Scheduling Optimization version history | MicrosoftDocs"
description: Find a list of important updates for Resource Scheduling Optimization in Dynamics 365 Field Service.
ms.date: 03/24/2023
ms.subservice: resource-scheduling-optimization
ms.topic: article
author: FeifeiQiu
ms.author: feiqiu
---

# Resource Scheduling Optimization version history

## Release schedule

When a new version of Dynamics 365 Field Service Resource Scheduling Optimization releases, it becomes available in different geographic regions at different times. Use the table below to see when the next release will become available in the region of your environment.

For information about other updates to Field Service, visit the [Dynamics 365 release plans](/dynamics365/release-plans/).
For information about older versions, see [Version history archive](version-history-archive.md#resource-scheduling-optimization-add-in).

|Station | Region | Current version | Next version |  Scheduled date
|------| -------|-------|-----|------|
|**Station 1** | | |  | |
| | *First Release* | [3.4.0.72](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#34072) | 3.4.0.180 | 3/17/2023
|**Station 2** | | |  | |
| | *South America* | [3.4.0.72](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#34072) | 3.4.0.180 | 3/31/2023
| | *Canada* | [3.4.0.72](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#34072)  | 3.4.0.180  | 3/31/2023
| | *India* | [3.4.0.72](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#34072) | 3.4.0.180  | 3/31/2023
| | *France* | [3.4.0.72](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#34072) | 3.4.0.180  | 3/31/2023
| | *United Arab Emirates* | [3.4.0.72](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#34072) | 3.4.0.180  | 3/31/2023
| | *South Africa* | [3.4.0.72](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#34072) | 3.4.0.180  | 3/31/2023
| | *Germany* | [3.4.0.72](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#34072)  | 3.4.0.180  | 3/31/2023
| | *Switzerland* | [3.4.0.72](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#34072)  | 3.4.0.180  | 3/31/2023
|**Station 3** | |  |  | |
| | *Japan* |  [3.4.0.72](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#34072)| 3.4.0.180  | 4/7/2023
| | *Asia Pacific* | [3.4.0.72](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#34072) | 3.4.0.180 | 4/7/2023
| | *United Kingdom* |[3.4.0.72](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340728) | 3.4.0.180  | 4/7/2023
| | *Oceania* | [3.4.0.72](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#34072) | 3.4.0.180   | 4/7/2023
|**Station 4** | |  |  | |
| | *Europe* | [3.4.0.72](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#34072) | 3.4.0.180   | 4/7/2023
|**Station 5** | |  |  | |
| | *North America* | [3.4.0.72](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#34072) | 3.4.0.180 | 4/14/2023
|**Station 6** | |  |  | |
| | *Government Community Cloud* | [3.4.0.8](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3408) | 3.4.0.180  | 4/21/2023
| | *China* |  [3.4.0.8](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3408)| 3.4.0.180 | 4/21/2023
| | *Dedicated Scale Groups* |  [3.4.0.8](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3408) | 3.4.0.180  | 4/21/2023

>[!NOTE]
>
> - Dates in all regions except Government Community Cloud (GCC) and China indicate the timing of the next automatic update. Dates in GCC and China indicate version availability; at this time, there is no automatic update for the GCC and China regions.
> - For all other regions, while most updates should be complete on the scheduled night, updates requiring more time may be completed during dark hours over the weekend indicated in the **Scheduled date** column.

## 3.4.0.254

- Bug fix: Addressed an issue with using the Optimization panel in [Single Resource Optimizations](/dynamics365/field-service/single-resource-optimization#run-after-making-changes-to-defaults)
- Behavior change: We are changing the behavior of how Resource Scheduling Optimization handles locks on bookings. Currently, if an optimization schedule is running, it may apply a lock to the bookings, which prevents a user from being able to delete the booking via Schedule Board. The user would be required to manually unlock the booking before deleting it. With this release, a request to delete a booking by a Schedule Board user will automatically override any locking by Resource Scheduling Optimization.

## 3.4.0.180

- Bug fix: Addressed issue where certain schedule requests fail due to a timeout, with the message *Resource Scheduling Optimization failed to create, update or delete some of the bookings due to a system error*.
- Bug fix: Addressed issue where certain schedule requests produced overlapping bookings when using locked resources or by requirement duration and book duration mismatch.
- Bug fix: Addressed issue where unpublished schedules would get inadvertently published after a platform update.

## 3.4.0.72

- Fixed optimization request errors:
  - System failed to optimize some records. Inner error(s): The primal integer program model is infeasible or unbounded: optimization status = InfeasibleOrUnbounded.
  - System failed to optimize some records. Inner error(s): An exception was thrown while activating F1.RoutingEngine.PathSolver.PathSolver.

## 3.4.0.8

- Resource Scheduling Optimization always honors locked bookings and will no longer overlap them.


[!INCLUDE[footer-include](../includes/footer-banner.md)]
