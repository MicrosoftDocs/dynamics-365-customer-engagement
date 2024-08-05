---
title: Run an optimization ad hoc
description: Learn how run a schedule optimization on demand with the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service.
author: AnilMur
ms.author: anilmur
ms.date: 07/16/2024
ms.topic: how-to
ms.subservice: resource-scheduling-optimization
---

# Run an optimization ad hoc

Typically, Resource Scheduling Optimization is run through [automated optimization schedules](rso-optimization-schedule.md). However, high-priority work sometimes comes up and leads to changes on subsequent bookings. In this case, a dispatcher might want to run the schedule optimization on demand.

## Run schedule optimization from an optimization scope

1. In Resource Scheduling Optimization, go to **Tools** > **Optimization Schedules**.
1. Open a published schedule.
1. On the command bar, select **Run now**.

## Use the schedule board to review optimization results

To view the outcome of an optimization run in a more visual way, you can show the results on a schedule board.

1. In Resource Scheduling Optimization, go to **Tools** > **Optimization Schedules**.
1. Open a published schedule.
1. On the command bar, select **Schedule board**.

On the schedule board:

- Resource filters match the [configuration of the optimization scope](rso-optimization-scope.md).
- The requirements pane has three tabs:

    - **Open and eligible for optimization**: This tab shows unscheduled requirements that match the scope definition, requirement range, and requirement state setting.
    - **Eligible for optimization**: This tab shows unscheduled requirements and other eligible bookings that match the scope definition, requirement range, and requirement state setting.
    - **Excluded from optimization**: This tab shows requirements or bookings that won't be optimized because of failures such as an invalid longitude or latitude value.

- An icon on a resource indicates that the resource isn't part of the optimization scope.
- An icon on the booking indicates that the [booking is locked](booking-lock-options.md).
- Yellow lines indicate the start and end times of the optimization range.
- The **From** and **To** dates and times match the time range that is defined in the optimization scope.

You can change the values and save the changes to the optimization scope. If the same scope is used for multiple optimization schedules, your changes apply to all of them.

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
