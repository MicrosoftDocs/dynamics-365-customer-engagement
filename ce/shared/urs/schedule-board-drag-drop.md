The [schedule board](../../field-service/work-with-schedule-board.md) supports drag-and-drop interactions to quickly schedule, move, and reassign bookings.

## Drag-and-drop versus Move To

The schedule board offers two ways to change a booking's resource or time. They differ in how they handle travel time and which resources are available.

| | Drag-and-drop | Move To (right-click) |
|---|---|---|
| **Travel time** | Start time represents the estimated arrival time, with travel time included | Recalculates travel time from the new start point, which shifts the booking slot forward |
| **Resource scope** | Only resources visible on the current board tab | Can search all resources, including those not on the current tab |
| **Best for** | Quick scheduling when you can see the target resource and time slot | Reassigning to a resource that isn't on the board, or when you need precise control over the start time |

> [!NOTE]
> When you drag a requirement onto the schedule board, the system sizes the booking from the requirement's remaining duration, not its end date. If the requirement has no remaining duration, the booking uses the default booking duration. To preserve a specific end date, use the **Book** action or the schedule assistant instead.

## Drag and drop a booking

Drag a booking on the timeline to move it to a different time slot or a different resource row on the current board tab. The booking's duration stays the same.

## Move or reassign bookings with Move to, Move by, or Reassign to

For more control, right-click a single booking on the schedule board and select **Move to**. Reassign the booking to any resource on the current schedule board tab, or change the start date and the start time of the booking. To assign the booking to a resource that doesn't show on this schedule board, select the filter icon in the resource field and change the filter from **Resources on this tab** to **All resources**. Select **Update** to apply the changes.

To act on multiple bookings, select the bookings with Ctrl-click (Windows) or Command-click (macOS), then right-click one of the selected bookings. Different rescheduling options appear in the right-click menu. Use **Move by** to move selected bookings forward or backward by a set offset (for example, move three selected bookings back by two days). Use **Reassign to** to move selected bookings to a new resource while preserving their existing times.

> [!IMPORTANT]
> When you use **Move To** or **Reassign to** to reassign a booking, the system recalculates travel time from the new start point. This shifts the booking slot forward compared to the original booking. This is expected behavior and differs from the initial drag-and-drop booking, where the start time represents the estimated arrival.

## Move bookings to a different day

Select **Show more schedule board actions** (&hellip;) > **Move bookings** to move bookings of a specific status to a different day. Moving bookings preserves times and other parameters.

## Schedule from the map view

On the map view, you can drag an unscheduled requirement pin from the map to the resource timeline and schedule it to that resource. You can also drag the resource route to a nearby unscheduled requirement to schedule it and add it to the resource route.

This approach is useful when you want to quickly identify areas with unscheduled jobs and schedule them to the nearest resources.

## Change time visualization

You can change how time is displayed on the schedule board. Use the slider on the bottom right to control the amount of time shown on the schedule board or use browser zoom keyboard shortcuts (for example, Ctrl+scroll or pinching a trackpad) to toggle between time granularities.
