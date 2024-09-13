---
title: Resource Scheduling Optimization version history
description: Version updates and updated features in the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service.
ms.date: 09/13/2024
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
| | *First Release* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.4.0.1040](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3401040) | 06/01/2024
|**Station 2** | | |  | |
| | *South America* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.4.0.1040](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3401040) | 06/02/2024
| | *Canada* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917)  | [3.4.0.1040](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3401040) | 06/02/2024
| | *India* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.4.0.1040](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3401040) | 06/02/2024
| | *France* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.4.0.1040](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3401040) | 06/02/2024
| | *United Arab Emirates* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.4.0.1040](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3401040) | 06/02/2024
| | *South Africa* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.4.0.1040](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3401040) | 06/02/2024
| | *Germany* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917)  | [3.4.0.1040](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3401040) | 06/02/2024
| | *Switzerland* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917)  | [3.4.0.1040](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3401040) | 06/02/2024
|**Station 3** | |  |  | |
| | *Japan* |  [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917)| [3.4.0.1040](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3401040) | 06/02/2024
| | *Asia Pacific* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.4.0.1040](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3401040) | 06/02/2024
| | *Great Britain* |[3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.4.0.1040](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3401040) | 06/02/2024
| | *Oceania* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.4.0.1040](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3401040) | 06/02/2024
|**Station 4** | |  |  | |
| | *Europe* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.4.0.1040](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3401040) | 06/07/2024
|**Station 5** | |  |  | |
| | *North America* | [3.4.0.917](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#340917) | [3.4.0.1040](/dynamics365/field-service/field-service-version-history-resource-scheduling-optimization#3401040) | 06/14/2024

>[!NOTE]
>
> - Dates in all regions indicate the timing of the next automatic update. While most updates should be complete on the scheduled night, updates requiring more time may be completed during dark hours over the weekend indicated in the **Scheduled date** column.

## 3.4.0.1262

This release, available as of Septembert 13, 2024, has updates improving performance.

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
