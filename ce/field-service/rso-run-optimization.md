---
title: Run an optimization ad hoc
description: Learn how run a schedule optimization on demand with the Resource Scheduling Optimization Add-in for Dynamics 365 Field Service.
author: andrewclear-ms
ms.author: anclear
ms.date: 07/22/2026
ms.topic: how-to
ms.subservice: resource-scheduling-optimization
ai-usage: ai-assisted
---

# Run an optimization ad hoc

Typically, Resource Scheduling Optimization runs automatically through [optimization schedules](rso-optimization-schedule.md). Sometimes, high-priority work comes up and changes subsequent bookings. In this case, a dispatcher can run schedule optimization on demand.

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
    - **Excluded from optimization**: This tab shows requirements or bookings that aren't optimized because of failures such as an invalid longitude or latitude value.

- An icon on a resource indicates that the resource isn't part of the optimization scope.
- An icon on the booking indicates that the [booking is locked](booking-lock-options.md).
- Yellow lines indicate the start and end times of the optimization range.
- The **From** and **To** dates and times match the time range that is defined in the optimization scope.

You can change the values and save the changes to the optimization scope. If the same scope is used for multiple optimization schedules, your changes apply to all of them.

## Interpret optimization results

After an optimization run finishes, the results might not match what you expect. A requirement might stay unscheduled, or the engine might choose a resource or time that seems suboptimal. The following table helps you understand why the engine made its decisions and where to learn more.

| Symptom | Likely cause |
|---|---|
| A requirement wasn't scheduled | The requirement doesn't meet the goal's constraints or falls outside the scope. Common causes: **Scheduling Method** not set to *Optimize*, a territory mismatch, missing characteristics, insufficient capacity, an invalid work location (latitude/longitude), a date/time window outside the optimization range, or a zero duration. As a quick check, run the [Schedule Assistant](schedule-assistant.md) on the requirement - it uses similar matching criteria. Learn more about the full list of causes and fixes in [Requirements not scheduled in Resource Scheduling Optimization](/troubleshoot/dynamics-365/field-service/rso/requirement-not-scheduled-in-rso). |
| A requirement was excluded from optimization | The engine couldn't process the record, for example because of an invalid longitude or latitude value. Excluded records appear on the **Excluded from optimization** tab of the schedule board results view, mentioned in the [Use the schedule board to review optimization results](#use-the-schedule-board-to-review-optimization-results) section. |
| The engine chose an unexpected resource or time | The outcome reflects the optimization goal's constraints and objectives. Constraints (for example, *Matches Territories* or *Meets Required Characteristics*) determine which bookings are allowed, and the ranked objectives (for example, *Minimize Total Travel Time* or *High Priority Requirements*) determine which allowed schedule is preferred. Learn more about constraints and objectives in [Optimization goals in Resource Scheduling Optimization](rso-optimization-goal.md). |
| A booking didn't move as expected | Locked bookings are held in place during optimization. Learn more about locked bookings in [Understand the booking lock option](booking-lock-options.md) and about resolving conflicts in [Handle and resolve booking conflicts](rso-handling-resolving-booking-conflicts.md). |
| The optimization request failed or was canceled | The **Scheduling Optimization Request** record has a failed or canceled status. Learn more about automated failure alerts in [Get email alerts for failed or canceled optimization requests](rso-monitoring-alerting.md). |

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
