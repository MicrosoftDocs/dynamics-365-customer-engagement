---
title: Drag and drop to schedule on the schedule board
description: Learn how to use drag and drop on the schedule board in Dynamics 365 Field Service to move, reassign, and schedule bookings.
ms.date: 03/26/2026
ms.custom: bap-template
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
---

<!-- IMPORTANT: Content in this article overlaps with ../shared/urs/use-schedule-board.md. If you update this article, make sure you also update the relevant sections in that shared file, and vice versa. -->

# Drag and drop to schedule on the schedule board

The [schedule board](work-with-schedule-board.md) supports drag-and-drop interactions to quickly schedule, move, and reassign bookings.

## Drag-and-drop verses Move To

The schedule board offers two ways to change a booking's resource or time. They behave differently in how they handle end dates and travel time.

| | Drag-and-drop | Move To (right-click) |
|---|---|---|
| **End date** | Set based on the requirement's **duration**, not its end date | You specify the end date and time explicitly |
| **Travel time** | Start time represents the estimated arrival time, with travel time included | Recalculates travel time from the new start point, which shifts the booking slot forward |
| **Resource scope** | Only resources visible on the current board tab | Can search all resources, including those not on the current tab |
| **Best for** | Quick scheduling when you can see the target resource and time slot | Reassigning to a different resource not on the board, or when you need precise control over start and end times |

> [!NOTE]
> When you drag a requirement onto the schedule board, the system sets the booking end date based on the requirement's duration, not its end date. To preserve a specific end date, use the **Book** action or the schedule assistant instead.

## Drag and drop a booking

Drag a booking on the timeline to move it to a different time slot or a different resource row on the current board tab. The booking's duration stays the same.

## Move or reassign a booking with Move To

For more control, right-click the booking on the schedule board and select **Move to**. Reassign the booking to any resource on the current schedule board tab, or change the start date and the start time of the booking. To assign the booking to a resource that doesn't show on this schedule board, select the filter icon in the resource field and change the filter from **Resources on this tab** to **All resources**. Select **Update** to apply the changes.

> [!IMPORTANT]
> When you use **Move To** to reassign a booking, the system recalculates travel time from the new start point. This shifts the booking slot forward compared to the original booking. This is expected behavior and differs from the initial drag-and-drop booking, where the start time represents the estimated arrival.

## Move bookings to a different day

Select **Show more schedule board actions** (&hellip;) > **Move bookings** to move bookings of a specific status to a different day. Moving bookings preserves times and other parameters.

## Schedule from the map view

On the map view, you can drag an unscheduled requirement pin from the map to the resource timeline and schedule it to that resource. You can also drag the resource route to a nearby unscheduled requirement to schedule it and add it to the resource route.

This approach is useful when you want to quickly identify areas with unscheduled jobs and schedule them to the nearest resources.

## Change time visualization

You can change how time is displayed on the schedule board. Use the slider on the bottom right to control the amount of time shown on the schedule board or use browser zoom keyboard shortcuts (for example, Ctrl+scroll or pinching a trackpad) to toggle between time granularities.

## Next steps

- [Filter resources and requirements on the schedule board](schedule-board-filtering.md)
- [Manually schedule from the schedule board](schedule-board-manual-scheduling.md)
- [Review resource utilization](schedule-board-utilization.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
