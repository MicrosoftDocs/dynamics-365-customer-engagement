---
title: Resource Scheduling Optimization version history
description: Version updates and updated features in the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service.
ms.date: 07/22/2025
ms.subservice: resource-scheduling-optimization
ms.topic: overview
author: DaPisani
ms.author: dapisani
---

# Resource Scheduling Optimization version history

## Release schedule

When a new version of the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service releases, it becomes available in different geographic regions at different times. The following table shows, when the next release will become available in the region of your environment.

For information about other updates to Field Service, visit the [Dynamics 365 release plans](/dynamics365/release-plans/).
For information about older versions, see [Version history archive](version-history-archive.md#resource-scheduling-optimization-add-in).

|Station | Region | Current version | Next version |  Scheduled date
|------| -------|-------|-----|------|
|**Station 1** | | |  | |
| | *First Release* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.5.0](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#350) | 08/08/2025
|**Station 2** | | |  | |
| | *South America* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.5.0](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#350) | 08/15/2025
| | *Canada* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917)  | [3.5.0](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#350) | 08/15/2025
| | *India* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.5.0](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#350) | 08/15/2025
| | *France* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.5.0](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#350) | 08/15/2025
| | *United Arab Emirates* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.5.0](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#350) | 08/15/2025
|**Station 3** | |  |  | |
| | *Japan* |  [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917)| [3.5.0](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#350) | 08/22/2025
| | *Asia Pacific* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.5.0](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#350) | 08/22/2025
| | *Great Britain* |[3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.5.0](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#350) | 08/22/2025
| | *Oceania* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.5.0](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#350) | 08/22/2025
|**Station 4** | |  |  | |
| | *Europe* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.5.0](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#350) | 08/30/2025
|**Station 5** | |  |  | |
| | *North America* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.5.0](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#350) | 09/05/2025
|**Station 6** | |  |  | |
| | *Dedicated Scale Groups* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.5.0](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#350) | 09/12/2025

>[!NOTE]
>
> - Dates in all regions indicate the timing of the next automatic update. While most updates should be complete on the scheduled night, updates requiring more time may be completed during dark hours over the weekend indicated in the **Scheduled date** column.

## 3.5.0
This release, available as of August 04, 2025 contains the following:
- Solution changes with compatibility for backend infrastructure upgrades to improve security and performance.

## 3.4.0.1406

This release, available as of April 25, 2025 fixes a rounding bug that resulted in booking duration occasionally being increased. In addition, this release improves optimization reliability.

## 3.4.0.1381

This release, available as of April 10, 2025 has a fix for the following bugs:
- Occasionally an optimization job creates fewer bookings than expected, resulting in schedules where not all resources are fully utilized.
- Optimization requests sometimes fail with an error message "System failed to optimize some records. Inner error(s)".

## 3.4.0.1332

This release, available as of December 6, 2024 has a fix for a bug where optimization requests occasionally fail with an error message "Object reference not set to an instance of an object".

## 3.4.0.1262

This release, available as of September 13, 2024, has updates improving performance.  
_Request Name_ in table _Optimization Requests_ now saved as date and time of request in UTC

## 3.4.0.1165

This release, available as of August 6, 2024, has updates improving reliability and performance.

## 3.4.0.1144

This release, available as of July 15, 2024, has miscellaneous service updates and logging improvements.

## 3.4.0.1040

This release removes the changes in build 3.4.0.1022 involving [bulk deletion jobs](rso-administration.md#bulk-deletion-jobs).

## 3.4.0.1022

This release has further improvements to diagnostic logging, and a fix to ensure that [bulk deletion jobs](rso-administration.md#bulk-deletion-jobs) are able to delete older optimization jobs in a timely manner.

## 3.4.0.917

This release has improved diagnostic logging. In addition, this release prevents the install or upgrade of Resource Scheduling Optimization if the environment is set to [block unmanaged customizations](/power-platform/alm/block-unmanaged-customizations). This flag must be disabled in order to install or upgrade Resource Scheduling Optimization.

## 3.4.0.623

This release introduces two new features:

- Support for optimizing [multi-day requirements](rso-multi-day.md).
- When schedulers optimize a single resource's schedule, [the system considers additional requirements](rso-single-resource-optimization.md) and their scheduled bookings.



[!INCLUDE[footer-include](../includes/footer-banner.md)]
