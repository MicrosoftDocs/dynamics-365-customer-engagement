---
title: Optimization scopes in Resource Scheduling Optimization
description: Learn about how to use scopes in Resource Scheduling Optimization for Dynamics 365 Field Service
author: AnilMur
ms.author: anilmur
ms.date: 06/26/2024
ms.topic: how-to
ms.subservice: resource-scheduling-optimization
---

# Optimization scopes in Resource Scheduling Optimization

Optimization scopes define what Resource Scheduling Optimization optimizes, including resources, requirements, or bookings and the time range to be considered for optimization. Scope definitions should be as narrow as possible.

Organizations often already have partitions that could be used for Resource Scheduling Optimization. For example:

- Temporal partitions: resources that work during the day or resources that work at night
- Geographical partitions: neighborhoods, cities, or other territories
- Logical partitions: support levels, incident types, etc.

System views and personal views are a critical building block for optimization scopes. Views are a set of filters that result in a list of records. [Create personal views](/power-apps/user/grid-filters-advanced) to make sure the system focuses on the right records. Optimizations complete faster if optimization requests contain fewer resources, requirements, bookings, and a shorter time range.

## Create an optimization scope

1. In Resource Scheduling Optimization, go to **Settings** > **Optimization Scopes**.
1. Select **New** to create a new scope or edit an existing one.
1. Choose views to define the list of records that the system optimizes when this scope is used. If you choose a personal view, it gets shared with the Resource Scheduling Optimization application user and other users who have access to the optimization scope.

   - **Resource View**: Defines which resources are considered for optimization.
   - **Requirement View**: Defines the resource requirements that are considered for optimization.
   - **Booking View**: Defines the bookable resource bookings for optimization. You can also choose a value for **On or After** to ensure optimization runs only consider future bookings that occur after the moment chosen.

1. Configure **Optimization Range Settings**. The optimization range is the time range in which bookings can be created, updated, or deleted.

   - **Range Reference**: The start time for all subsequent work order range calculation. Choose between **Job current time** or **Beginning and the job's current day**.
   - **Range Offset**: Amount of time added to the range reference to define the start of the time range.
   - **Range Duration (days)**: Number of days added to the range reference.

   :::image type="content" source="media/optimization-scope-time-range.png" alt-text="Visualization of the optimization range and its related settings.":::

   > [!NOTE]
   > If bookings or resource requirements are listed in the selected views, but the promised date/time windows are outside the optimization range, Resource Scheduling Optimization won't create or update these requirements or bookings.

1. Save the optimization scope and select **Schedule Board** in the command bar to preview the selected resources, requirements, and bookings on a new schedule board tab. You can modify filters on the left panel and save it into the optimization scope.

1. Expand the Optimization pane to [choose the optimization goal](rso-optimization-goal.md) and select **Run** to [start an ad-hoc optimization request](rso-schedule-optimization.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
