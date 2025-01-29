---
title: Optimization scopes in Resource Scheduling Optimization
description: Learn how to use scopes in Resource Scheduling Optimization for Dynamics 365 Field Service.
author: AnilMur
ms.author: anilmur
ms.date: 01/29/2025
ms.topic: how-to
ms.subservice: resource-scheduling-optimization
---

# Optimization scopes in Resource Scheduling Optimization

Optimization scopes define what Resource Scheduling Optimization optimizes. Scope definitions include the resources, requirements, or bookings, and the time range to consider for optimization. Optimization scopes should be defined as narrowly as possible.

Often, organizations already have partitions that can be used for Resource Scheduling Optimization. Here are some examples:

- **Temporal partitions**: Resources that work during the day or resources that work at night
- **Geographical partitions**: Neighborhoods, cities, or other territories
- **Logical partitions**: Support levels, incident types, and so on

System views and personal views are critical building blocks for optimization scopes. A view is a set of filters that result in a list of records. [Create personal views](/power-apps/user/grid-filters-advanced) to ensure that the system focuses on the correct records. Optimization is completed more quickly if optimization requests contain fewer resources, requirements, or bookings, and a shorter time range.

## Prerequisites

[Create personal views](/power-apps/user/grid-filters-advanced).

## Create an optimization scope

1. In Resource Scheduling Optimization, go to **Settings** > **Optimization Scopes**.
1. Select **New** to create a new scope. Alternatively, you can edit an existing scope.
1. Select views to define the list of records that the system optimizes when this scope is used. If you select a personal view, it's shared with the Resource Scheduling Optimization application user and other users who have access to the optimization scope.

    - **Resource View**: This view defines which resources are considered for optimization.
    - **Requirement View**: This view defines which resource requirements are considered for optimization.
    - **Booking View**: This view defines which bookable resource bookings are considered for optimization. To ensure that optimization runs consider only future bookings that occur after a specific point, you can select a value in the **On or After** field.

1. Configure optimization range settings. The optimization range is the time range during which bookings can be created, updated, or deleted.

    - **Range Reference**: Specify the start time for all subsequent work order range calculation. Select either **Job current time** or **Beginning and the job's current day**.
    - **Range Offset**: Specify the amount of time to add to the range reference to define the start of the time range.
    - **Range Duration (days)**: Specify the number of days to add to the range reference to define the duration of the time range.

    The following diagram shows how the range reference, range offset, and range duration work together to define the optimization range.

    :::image type="content" source="media/optimization-scope-time-range.png" alt-text="Visualization of the optimization range and its related settings.":::

    > [!NOTE]
    > If bookings or resource requirements are listed in the selected views, but the promised date/time windows are outside the optimization range, Resource Scheduling Optimization doesn't create or update those requirements or bookings.

1. Save the optimization scope. Then, on the command bar, select **Schedule Board** to preview the selected resources, requirements, and bookings on a new schedule board tab. You can modify filters in the left pane and save the results to the optimization scope.
1. Expand the **Optimization** pane to [select the optimization goal](rso-optimization-goal.md). Select **Run** to [start an ad-hoc optimization request](rso-schedule-optimization.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
