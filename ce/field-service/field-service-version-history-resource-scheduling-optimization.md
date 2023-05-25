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

## 3.3.5.199

- Resource Scheduling Optimization no longer fails with constraint violations; it will continue while skipping over the identified resource(s) that have violations. For more information, go to [Booking lock options](booking-lock-options.md).
- Bug fix: Addressed issue where ResetRSO fails with timeout exception on UR28.

## 3.3.3.12

- Bug fix: Addressed the problem of Resource Scheduling Optimization jobs getting stuck in the 'Optimizing' state, which happened due to long running write operations from Dynamics 365 into Resource Scheduling Optimization.
- Bug fix: Adjusted the degree of parallelism that Resource Scheduling Optimization was using, to write results back to Dynamics 365. This was done to prevent throttling, which could cause optimization request failures.

## 3.3.2.4

- Bug fix: Addressed issue where the predicative travel info icon wasn't able to be selected and hovering caused formatting issues.
- Bug fix: Addressed issue where single resource optimization requests with no schedulable requirements are canceled with message: "This request was canceled as none of the selected resource requirements or bookings were valid."

## 3.3.1.38

- Bug fix: Addressed issue that caused Resource Scheduling Optimization to delete bookings that were locked to resource and time, if the booking was the length of an entire shift. 
- Bug fix: Addressed issue that prevented Resource Scheduling Optimization from deleting bookings that needed to be deleted, if they weren't associated with a resource requirement record.

## 3.3.0.115

- Improved predictive travel time user experience. Allows users to distinguish bookings that used predictive travel (and thus have more accurate travel time that includes historical traffic) from those that didn't.
- Fixed bug in which 401 error was thrown in creation of account and contact records after Field Service autoupdate. Error message: "The remote server returned an error: (401) Unauthorized."
- Bug fix: Addressed issue in which “Something went wrong. Try reloading the page. If you still see this message, contact your administrator to file a support request" when trying to display booking tool tip view on the new schedule board. This would occur when hovering over any booking.

## 3.2.3.3

-	Bug fix: Addressed issue where a hard and virtually locked booking that was out of scope would show up as a create operation in the optimization request booking tab. Optimization request bookings are created for virtually locked bookings if Resource Scheduling Optimization has something to change. If there's nothing to change, the record shouldn't be created. 

>[!OTE]
> Virtually locked bookings are bookings created outside of the optimization scope.

-	Bug fix: reset would cause error: “Value can't be null.” When a reset does happen, the confusing error is no longer provided. Instead, it errors by either defaulting the effort level or raising a ```RSODataNotFound``` exception.  
-	Bug fix: reset all in Resource Scheduling Optimization **Schedules** tab wasn't properly deleting data within database.  
-	Bug fix: Addressed error issue "System.OutOfMemoryException: Array dimensions exceeded supported range.” This scenario would occur when a trying to optimize a large number of resource requirements (~50k). 
-	Fixed “Keyset doesn't exist” errors. This error was a transient issue that would fail the authentication from Azure to CRM.
-	Bug fix: within ineligibility graph in which an entire resource was incorrectly removed if other shifts associated with the resource were still eligible to be scheduled. 
-	Bug fix: optimization would run for more than one day without completing. This scenario would occur when 5000 resource requirements and 500 resources were scheduled to be optimized over 21 days. 
-	Bug fix: the settings panel within Resource Scheduling Optimization app displayed "properties" instead of "priorities."
-	Bug fix: optimization goal wasn't saving when the travel time calculation was updated.

## 3.2.2.18

- Bug fix: optimization request fails with the message: “an item with the same key has already been added.” The scenario occurred when there was more than one booking with the same resource requirement. 
- Bug fix: version 3.0.190941 wouldn't upgrade to version 3.2.1.96 due to plugin name issues.  
- Bug fix: schedule assist would fail with the message: “The remote name couldn't be resolved: 'website20200924t163642zzvulvehb5hdn4.azurewebsites.net'”. The scenario occurred when schedule assist was unable to correctly provide options for the resource name, travel time, and arrival time for a suggested booking.  
- Bug fix: running reset all or reset selected on a schedule associated with heavy effort optimizations would time out.  
- Bug fix: in operation requests booking details tab where the operation reason was showing “---” for all records.

## 3.2.1.71

- Resource scheduling optimization intelligence used to help dispatcher schedule multiple requirements in the schedule board. [Read about this update.](/dynamics365/field-service/preview-schedule-board)
- Increased end-to-end overall optimization performance by 3-5%.  

## 3.2.1.6

- Bug fix: scenario installing the Resource Scheduling Optimization analytics solution would remove the Resource Scheduling Optimization app module icon. 
- Allow resources to travel outside of working hours [Read about this update.](/dynamics365/field-service/rso-travel-outside-working-hours)
- Improved predictive travel time accuracy [Read about this update.](/dynamics365/field-service/rso-predictive-travel) 

## 3.1.5.24

- Bug fix: scenario where the MoveUp button was hidden on the Resource Scheduling Optimization goal objective. 
- Made performance enhancements for single resource optimization scenarios.  

## 3.1.4.1

- Bug fix: scenario where the Resource Scheduling Optimization package was imported regardless of minimum Universal Resource Scheduling version required, resulting in an import failure. The fix ensures that the user can't import the Resource Scheduling Optimization package if the minimum Universal Resource Scheduling version isn't met.  
- Bug fix: scenario where single resource optimization deleted valid bookings. This scenario occurred when the user attempted to trigger single resource optimization for a resource. The single resource optimization would then delete most of the valid and eligible bookings.  

## 3.1.3.17

- Bug fix: where 'Created On' field in optimization panel of Resource Scheduling Optimization schedule board doesn't respect date format of user setting. 
- Bug fix: issue where optimization request status wasn't set correctly when Resource Scheduling Optimization is run as a simulation. 

## 3.0.19316.2

- ConsiderTravelTime parameter for SA API msdyn_SearchResourceAvailability isn't working as expected. Use the following steps to understand the impact of this bug fix:
  - Create a resource requirement with four hours duration, and location set to **Onsite**. 
  - Create a resource A with four hours available hour on their calendar; make sure there are a few minutes travel time between the location between resource and requirement.
  - Use msdyn_SearchResourceAvailability with the ConsiderTravelTime parameter set to false, and to find availability for this requirement. Before this, no potential bookable slot was returned; now there's potential bookable slot returned from resource A since resource A has enough available hours.
- Resource scheduling optimization booking details: **Operation Details** field doesn't show message anymore if user is missing the Field Service - Administrator security role.
- Booking status form showing false scheduling method the first time Resource Scheduling Optimization is opened after initial setup.
- Bug fix: Fixed upgrade issue from Resource Scheduling Optimization v3.0.18341.1 to latest in-market version.

## 3.0.19263.1

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/10/03/whats-new-in-dynamics-365-resource-scheduling-optimization-version-3-0-19263-1/)

## 3.0.19109.3

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2019/05/01/whats-new-for-dynamics365-resource-scheduling-optimization-v3-0-update-release/)

## 2.8

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2018/10/16/whats-new-for-dynamics-365-resource-scheduling-optimization-v2-8-release/)

## 2.7

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2018/08/16/whats-new-in-the-dynamics-365-resource-scheduling-optimization-version-2-7-release/)

## 2.6

[Read a blog post about this update.](https://cloudblogs.microsoft.com/dynamics365/it/2018/05/09/whats-new-for-dynamics-365-resource-scheduling-optimization-v2-6-release/)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
