---
title: "Resource scheduling optimization version history | MicrosoftDocs"
description: Find a list of important updates for resource scheduling optimization in Dynamics 365 Field Service.
ms.custom: 
  - dyn365-fieldservice
ms.date: 02/03/2021
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.topic: article
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.author: daclar
manager: shellyha
search.app: 
  - D365CE
  - D365FS
---

# Resource scheduling optimization version history

## 3.2.3.3
-	Fixed bug: a hard and virtually locked booking that was out of scope would show up as a create operation in the optimization request booking tab. Optimization request bookings are created for virtually locked if resource scheduling optimization has something to change. If there is nothing to change, the record should not be created. 
-	Fixed bug: reset would cause error: “Value cannot be null.” When a reset does happen, the confusing error is no longer provided. Instead, it errors by either defaulting the effort level or raising a ```RSODataNotFound``` exception.  
-	Fixed bug: reset all in resource scheduling optimization **Schedules** tab was not properly deleting data within database.  
-	Fixed bug with "System.OutOfMemoryException: Array dimensions exceeded supported range.” This scenario would occur when a large number of resource requirements ~50k would be attempted to be optimized for. 
-	Fixed “Keyset does not exist” errors. This is a transient issue that would fail the authentication from Azure to CRM.
-	Fixed bug within ineligibility graph in which an entire resource was incorrectly removed if other shifts associated with the resource were still eligible to be scheduled. 
-	Fixed bug: optimization would run for more than one day without completing. This scenario would occur when 5000 resource requirements and 500 resources were scheduled to be optimized over 21 days. 
-	Fixed bug: the settings panel within resource scheduling optimization app displayed "properties" instead of "priorities." 
-	Fixed bug: optimization goal was not saving when the travel time calculation was updated. 

## 3.2.2.18 

- Fixed bug: optimization request fails with the message: “an item with the same key has already been added.” The scenario occurred when there was more than one booking with the same resource requirement. 
- Fixed bug: version 3.0.190941 would not upgrade to version 3.2.1.96 due to plugin name issues.  
- Fixed bug: schedule assist would fail with the message: “The remote name could not be resolved: 'website20200924t163642zzvulvehb5hdn4.azurewebsites.net'”. The scenario occurred when schedule assist was unable to correctly provide options for the resource name, travel time, and arrival time for a suggested booking.  
- Fixed bug: running reset all or reset selected on a schedule associated with heavy effort optimizations would time out.  
- Fixed bug: in operation requests booking details tab where the operation reason was showing “---” for all records. 

## 3.2.1.71 

- Resource scheduling optimization intelligence used to help dispatcher schedule multiple requirements in the schedule board. [Read about this update.] (https://docs.microsoft.com/dynamics365/field-service/preview-schedule-board)
- Increased end-to-end overall optimization performance by 3-5%.  

## 3.2.1.6 

- Fixed bug: scenario installing the resource scheduling optimization analytics solution would remove the resource scheduling optimization app module icon. 
- Allow resources to travel outside of working hours [Read about this update.] (https://docs.microsoft.com/dynamics365/field-service/rso-travel-outside-working-hours)
- Improved predictive travel time accuracy [Read about this update.] (https://docs.microsoft.com/dynamics365/field-service/rso-predictive-travel) 

## 3.1.5.24 

- Fixed bug scenario where the MoveUp button was hidden on the resource scheduling optimization goal objective. 
- Made performance enhancements for single resource optimization scenarios.  

## 3.1.4.1 

- Fixed bug scenario where the resource scheduling optimization package was imported regardless of minimum Universal Resource Scheduling version required, resulting in an import failure. The fix ensures that the user cannot import the resource scheduling optimization package if the minimum Universal Resource Scheduling version is not met.  
- Fixed bug scenario where single resource optimization deleted valid bookings. This scenario occurred when the user attempted to trigger single resource optimization for a resource. The single resource optimization would then delete most of the valid and eligible bookings.  



## 3.1.3.17

- Fixed bug where 'Created On' field in optimization panel of resource scheduling optimization schedule board does not respect date format of user setting. 
- Fixed issue where optimization request status was not set correctly when resource scheduling optimization is run as a simulation. 


## 3.0.19316.2

- ConsiderTravelTime parameter for SA API msdyn_SearchResourceAvailability is not working as expected. Use the following steps to understand the impact of this bug fix:
  - Create a resource requirement with four hours duration, and location set to **Onsite**. 
  - Create a resource A with four hours available hour on their calendar; make sure there are a few minutes travel time between the location between resource and requirement.
  - Use msdyn_SearchResourceAvailability with the ConsiderTravelTime parameter set to false, and to find availability for this requirement. Before this, no potential bookable slot was returned; now there is potential bookable slot returned from resource A since resource A has enough available hours.
- Resource scheduling optimization booking details: **Operation Details** field doesn't show message anymore if user is missing the Field Service - Administrator security role.
- Booking status form showing false scheduling method the first time resource scheduling optimization is opened after initial setup.
- Fixed upgrade issue from resource scheduling optimization v3.0.18341.1 to latest in-market version.

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
