---
title: Optimization scopes in Resource Scheduling Optimization
description: Learn about how to use scopes in Resource Scheduling Optimization for Dynamics 365 Field Service
author: AnilMur
ms.author: anilmur
ms.date: 06/26/2024
ms.topic: conceptual
ms.subservice: resource-scheduling-optimization
---

# Optimization scopes in Resource Scheduling Optimization

Optimization scopes define what Resource Scheduling Optimization optimizes, including resources, requirements, or bookings and the time range to be considered for optimization. Scope definitions should be as narrow as possible.

Organizations often already have partitions that could be used for Resource Scheduling Optimization. For example:

- Temporal partitions: resources that work during the day or those that work at night
- Geographical partitions: neighborhoods, cities, or other territories
- Logical partitions: support levels, incident types, etc.

System views and personal views are a critical building block for optimization scopes. Views are a set of filters that result in a list of records. [Create personal views](/power-apps/user/grid-filters-advanced) to make sure the system focuses on the right records. Optimizations complete faster if optimization requests contain fewer resources, requirements, bookings, and a shorter time range.

## Create an optimization scope

1. In Resource Scheduling Optimization, go to **Settings** > **Optimization Scopes**.
1. Select **New** to create an new scope or edit an existing one.
1. Choose views to define the list of records that the system will optimize when this scope is used. If you choose a personal view, it's shared with the Resource Scheduling Optimization application user and other users who have access to the optimization scope.

   - **Resource View**: Defines which resources are considered for optimization.
   - **Requirement View**: Defines the resource requirements that are considered for optimization.
   - **Booking View**: Defines the bookable resource bookings for optimization. You can also choose a value for **On or After** to exclude bookings within selected time from when the optimization runs and bookings in the past.
1. Configure **Optimization Range Settings**. The optimization range is the time range in which bookings can be created, updated, or deleted.
1. 
1. -- 

   - **Range Reference**: The start time for all subsequent work order range calculation (Job current time or Beginning of the Job’s current day).
   - **Range Offset**: Amount of time added to the range reference to define the range start.
   - **Range Duration (days)**: Number of days added to the range reference.

   :::image type="content" source="media/optimization-scope-time-range.png" alt-text="Visualization of the optimization range and its related settings.":::
  
   **Example 2**: You want to have a booking created/moved into the next two days.
  
   > [!div class="mx-imgBorder"]
   > ![Screenshot of optimization range settings_2.](media/6a06b7a1a69c2f493686442af5e44520.png)
   > [!div class="mx-imgBorder"]
   > ![Image showing range offset and duration.](media/5d265da65e27891ebab3319627e9a3fa.png)

   > [!NOTE]
   > If bookings or resource requirements are defined in the Requirement/Booking view, but the promised date/time windows are outside the optimization range, Resource Scheduling Optimization won't create or update these requirements or bookings after respecting the scheduling window constraint. If the promised date/time windows are overlapping the optimization range, Resource Scheduling Optimization will create/update these requirements/bookings after respecting the scheduling window constraint.

5. You can preview resources, requirements, and bookings for optimization scope
    through the schedule board:
   - Resource filters on the schedule board are prepopulated from the
        Resource View. The resource list matches the number of resources defined
        in the Resource View. Resource Scheduling Optimization will display a lock icon and tooltip to
        indicate if a resource is not enabled for optimization (even though it
        was added into Resource View).
   - Requirements under Eligible for Optimization match the records from the
        Requirement View.
        
     > [!div class="mx-imgBorder"]
     > ![Screenshot of the schedule board.](media/9b12b09d64d881041edd3d93f27be00c.png)

6. You can modify filters on the left panel and save it into scope:

   - If Resource View referred by optimization scope is a system view,
        modified filters through the schedule board will be saved as a new
        personal view.
   - If Resource View referred by optimization scope is a personal view,
        modified filters through the schedule board will be saved back into the
        same personal view.
        
     > [!div class="mx-imgBorder"]
     > ![Screenshot of the schedule board with modified filters.](media/d3b94e01e4d75db77d4f06e20b8d83d9.png)



[!INCLUDE[footer-include](../includes/footer-banner.md)]
