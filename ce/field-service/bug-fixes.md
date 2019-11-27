---
title: "Bug fixes for Dynamics 365 Field Service | MicrosoftDocs"
ms.custom: 
  - dyn365-fieldservice
ms.date: 11/05/2019
ms.reviewer: krbjoran
ms.service: dynamics-365-customerservice
ms.suite: ""
ms.technology: 
  - "field-service"
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
author: FieldServiceDave
ms.assetid: f7e513fc-047f-4a88-ab83-76fae5e583e2
caps.latest.revision: 42
ms.author: daclar
manager: shellyha
search.audienceType: 
  - admin
  - customizer
search.app: 
  - D365CE
  - D365FS
---

# Bug fixes

In this article, you'll find an ongoing list of bug fixes for Dynamics 365 Field Service, Universal Resource Scheduling (URS), Field Service Mobile, Resource Scheduling Optimization (RSO), and Connected Field Service (CFS). For information about other updates to Field Service, visit the [Dynamics 365 Release Plans](https://docs.microsoft.com/dynamics365/release-plans/). 

## Dynamics 365 Field Service

### Version 8.8.8.50

- Improve error messages when the user attempting an action is missing "Field Service Setting" read privilege.
- Form logic always turns Incident Type to not required based on Work Order Type, regardless of field settings.
- Bookings are not shared consistently to all resources on multi-booking Work Orders.
- Deleting and recreating a Booking associated with a Work Order changes the shared users of Booking.
- TypeError: Cannot read property 'getDefaultView' when Requested by Contact field removed from RMA form.
- Agreement Invoice Product Currency Set to Base Currency - should be set to Agreement's Pricelist Currency.

### Version 8.8.7.47

-	Removal of Territory from Work Order is not removed from non-primary related requirements.
-	Inappropriate command buttons shown for Opportunity, Quote, and Order Product and Service-based Lines Sub Grids.
-	Field Service Resource privilege exception on create and save of Time Off Request.
  
  

## Universal Resource Scheduling (URS)

### Version 3.12.2.114

- When the schedule board map view is opened, the map automatically zooms out to show all the map pins. 
-	The resource look up is displayed on the schedule board in Arabic.
-	On the schedule assistant results list view, work start time aligns with the estimated arrival time values on the create resource booking pane. 
-	Added additional handling to avoid the corruption of the booking setup metadata and the schedule board settings records. 
-	Bookings can be edited in the days view of the schedule board by right-clicking on the booking and selecting **Edit**.
-	The select resources dialog opens and loads successfully on the filter view of the schedule board, even when there are more than 100 resources enabled to be displayed on the schedule board.  
-	When Turkish language is enabled on the org, resource requirement records load under the **Unscheduled Workorders** tab of the Requirement pane of the Schedule board. 
-	When double clicking on the Save button the new Bookable Resource Booking form, would not create duplicate records. 
-	Resources can be searched on the Schedule Board by their name in the Search Resources search box. 
-	Map View on the Schedule Board only shows the pins for the Requirements that are returned from the Requirement View configured for Requirement Map Filer View setting on the Map Settings of the Schedule Board tab settings. 
- When Hebrew language is enabled on the org, Schedule Board loads in the Chrome with browser zoom at 90%. 
-	The requirement Demand pie chart on the Schedule Assistant information at the bottom is accessible, via Screen readers. 

### Version 3.12.1.158

- Workflows can be triggered when resource requirements are created with any allocation method.
- When upgrading URS from version 2.x to version 3.x, resource filters on the schedule board tabs are preserved. 
  

## Resource Scheduling Optimization (RSO)

### Version 3.0.19316.2

- ConsiderTravelTime parameter for SA API msdyn_SearchResourceAvailability is not working as expected
   - Create a resource requirement with 4 hours duration, and location = Onsite 
   - Create a resource A with 4 hours available hour on his calendar , make sure there is few mins travel time between the location between resource and requirement
   - Use msdyn_SearchResourceAvailability with ConsiderTravelTime parameter set to false , and to find availability for this requirement 
Before: no potential bookable slot returned , now there is potential bookable slot return from resource A since resource A has enough available hours 
- RSO Booking Details -> Operation Details field doesn't show message anymore if RSO application user missing FS-admin security role
- Booking status form showing false Scheduling Method when first time open after setup fresh RSO environment
- Fixed upgrade issue from RSO v3.0.18341.1 to latest in-market version


