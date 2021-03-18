---
title: Scopes in resource scheduling optimization for Dynamics 365 Field Service
description: Learn about how to use scopes in resource scheduling optimization for Dynamics 365 Field Service
author: FieldServiceDave
ms.author: daclar
ms.reviewer: krbjoran
manager: shellyha
ms.date: 01/02/2020
ms.topic: article
ms.custom: 
  - dyn365-fieldservice
ms.service: dynamics-365-customerservice
search.app: 
  - D365CE
  - D365FS
---

# Optimization scopes in resource scheduling optimization

You can define what resource scheduling optimization optimizes, including resources, requirements, or bookings.

Scope is the resource scheduling optimization mechanism for defining the relevant inputs: resource requirements, resources, and existing resource bookings. It also includes the timeframes to be considered for optimization. Extensible scope leverages Dynamics 365 entity views, providing an easy and flexible way to define what to optimize (resource requirements, resources, and existing resource bookings).

> [!IMPORTANT]
> Scopes should be as small as possible. Resource scheduling optimization will be quicker and more effective if optimization requests contain few resources, requirements, bookings, and shorter range durations. Usually companies already have partitions that could be used for resource scheduling optimization; for instance: 
> - Temporally defined: optimize technicians who work in the day separately from
    those who work at night.
> - Geographically defined: neighborhoods, cities.
> - Logically defined: support level, incident type.

After opening the **Scheduling Optimization Scope** form, users can select existing system views or personal views (for which they have read permissions) from the Resource, Requirement, and Booking view drop-down menus. If a personal view is selected, it is shared with the Resource Scheduling Optimization application user and other users who have access to the scope.
> [!div class="mx-imgBorder"]
> ![Screenshot of the scheduling optimization scope](media/92069616c79fb0f7fe9c4adc6683f50b.png)
> [!div class="mx-imgBorder"]
> ![Screenshot of a modal with system view options](media/e7dd89ff112dcae60489d52534c564f2.png)

1. Using **Resource View** for example, 0_WA Resources has been defined with
    the filter conditions shown in the following screenshot. This is equivalent
    to configuring WA territory as an optimization scope in the previous version
    of resource scheduling optimization. Users can apply more filter conditions as needed to specify
    resources they need to optimize. Resource scheduling optimization will respect the Optimize Scheduling
    setting on individual resource records on top of the resource view filters.
    > [!div class="mx-imgBorder"]
    > ![Screenshot of a list of resources](media/4b4f1beede0d89f940677b7df65f80c8.png)
    > [!div class="mx-imgBorder"]
    > ![Screenshot of bookable resource territories](media/349c0ca23d3c32edb227b78430c95d46.png)

2. Select at least one requirement or booking view for what needs to be
    optimized.
    
   > [!div class="mx-imgBorder"]
   > ![Screenshot showing that users must select on requirement or booking view](media/843748f6ea067de2163318e71ac4851d.png)

3. If you select booking view, you can set it to **Now or After**. For example,
    maybe you want to optimize bookings for the next five days, from 2 hours on
    (while excluding bookings within the next 2 hours and bookings in the past).
    The current, out-of-the-box Dynamics 365 entity view filter doesn’t support
    this Now or After condition; resource scheduling optimization enabled this additional setting on top of
    whatever filter conditions are defined for that booking view.
    
   > [!div class="mx-imgBorder"]
   > ![Screenshot of Bookings for this Optimization](media/322f8b809e438d032b150b13fde88148.png)

4. **Optimization Range Settings** is the time range where bookings can be created,
    updated, and deleted.

   **Example 1:** You want to have a booking created or moved ahead 24 hours but from 1 hour on; in other words, bookings will be moved into a range starting Now+1hour and ending Now+1hour+1day (which might partly still be today).
  
   > [!div class="mx-imgBorder"]
   > ![Screenshot of optimization range settings](media/62ab888c08dfc0bdd81587535de73d5d.png)

   - **Range Reference**: The start moment for all subsequent work order range
     calculation (Job current time or Beginning of the Job’s current day).
   - **Range Offset**: Amount of time added to the range reference to define the
     range start.
   - **Range Duration (days)**: Number of days added to the range reference.
  
     > [!div class="mx-imgBorder"]
     > ![Screenshot of range duration](media/06e5a506621a550cc2d05df234a3dbde.png)

   **Example 2**: You want to have a booking created/moved into the next two days.
  
   > [!div class="mx-imgBorder"]
   > ![Screenshot of optimization range settings](media/6a06b7a1a69c2f493686442af5e44520.png)
   > [!div class="mx-imgBorder"]
   > ![Image showing range offset and duration](media/5d265da65e27891ebab3319627e9a3fa.png)

   > [!NOTE]
   > If bookings or resource requirements are defined in the Requirement/Booking view, but the promised date/time windows are outside the optimization range, resource scheduling optimization won't create or update these requirements or bookings after respecting the scheduling window constraint. If the promised date/time windows are overlapping the optimization range, resource scheduling optimization will create/update these requirements/bookings after respecting the scheduling window constraint.

5. You can preview resources, requirements, and bookings for optimization scope
    through the schedule board:

   - Resource filters on the schedule board are prepopulated from the
        Resource View. The resource list matches the number of resources defined
        in the Resource View. Resource scheduling optimization will display a lock icon and tooltip to
        indicate if a resource is not enabled for optimization (even though it
        was added into Resource View).
   - Requirements under Eligible for Optimization match the records from the
        Requirement View.
        
     > [!div class="mx-imgBorder"]
     > ![Screenshot of the schedule board](media/9b12b09d64d881041edd3d93f27be00c.png)

6. You can modify filters on the left panel and save it into scope:

   - If Resource View referred by optimization scope is a system view,
        modified filters through the schedule board will be saved as a new
        personal view.
   - If Resource View referred by optimization scope is a personal view,
        modified filters through the schedule board will be saved back into the
        same personal view.
        
     > [!div class="mx-imgBorder"]
     > ![Screenshot of the schedule board with modified filters](media/d3b94e01e4d75db77d4f06e20b8d83d9.png)



[!INCLUDE[footer-include](../includes/footer-banner.md)]