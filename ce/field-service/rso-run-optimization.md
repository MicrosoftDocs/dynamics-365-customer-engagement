---
title: Run an optimization ad-hoc
description: Learn about how run a schedule optimization on demand with the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service.
author: AnilMur
ms.author: anilmur
ms.date: 07/16/2024
ms.topic: how-to
ms.subservice: resource-scheduling-optimization
---

# Run an optimization ad-hoc

The common method to run Resource Scheduling Optimization is through [automated optimization schedules](rso-optimization-schedule.md). Sometimes, high priority work comes up and leads to changes on subsequent bookings. In that case, a dispatcher might want to run the schedule optimization ad-hoc.

## Run schedule optimization from an optimization scope

1. In Resource Scheduling Optimization, go to **Tools** > **Optimization Schedules**.
1. Open a published schedule.
1. Select **Run now** in the command bar.

## Use the schedule board to review optimization results

To view optimization results in a more visual way and see the outcome of an optimization run, you can show the results on a schedule board.

1. In Resource Scheduling Optimization, go to **Tools** > **Optimization Schedules**.
1. Open a published schedule.
1. Select **Schedule board** in the command bar.

- Resource filters match the [configuration of the optimization scope](rso-optimization-scope.md).
- The requirements pane shows three tabs:
  - **Open and eligible for optimization**:unscheduled requirements that match scope definition, requirement range, and requirement state setting.
  - **Eligible for optimization**: unscheduled requirements and other eligible bookings that match scope definition, requirement range, and requirement state setting.
  - **Excluded from optimization**: requirements or bookings won't optimize due to failures such as invalid longitude/latitude.
- An icon on a resource indicates that a resource isn't part of the optimization scope.
- An icon on the booking indicates that the [booking has been locked](booking-lock-options.md).
- Yellow lines indicate the start and end time for the optimization range.
- **From** / **To** date and time match the time range defined in the optimization scope.

You can change the values and save the changes to the optimization scope. If the same scope is used for multiple optimization schedules, changes apply to all these schedules.

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
