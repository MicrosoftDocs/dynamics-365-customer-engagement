---
title: Use the Scheduling Operations Agent (preview)
description: Learn how to use the Scheduling Operations Agent to optimize a technician's schedule in Dynamics 365 Field Service.
ms.date: 04/24/2025
ms.topic: how-to
ms.author: anilmur
author: anilmur
---

# Use the Scheduling Operations Agent (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

You can launch the Scheduling Operations Agent in either the Copilot side pane or from the schedule board in Dynamics 365 Field Service.

- In any page in the Field Service app, select the Copilot icon in the app header. In the chat box, prompt Copilot to suggest a schedule; for example, "Suggest a schedule."

   :::image type="content" source="media/soa-copilot-chat.png" alt-text="Screenshot of the Copilot side pane in Dynamics 365 Field Service showing a chat with a prompt to build a schedule for a technician.":::

- From the schedule board, right-click the technician's name and select **Suggest schedule**. If the agent doesn't support the selected resource type, the option is unavailable. Review the tooltip to understand the reason.

   :::image type="content" source="media/soa-suggest-schedule.png" alt-text="Screenshot of the schedule board in Dynamics 365 Field Service showing a menu of options for a selected resource, with the Suggest schedule option highlighted.":::

## Adjust the settings for optimization requests

After you launch the agent, it suggests settings that you can adjust before it starts generating an optimized schedule. Adjust the settings as needed to ensure that the agent suggests a schedule that meets your business requirements.

Regardless of the settings you select, the agent doesn't move any bookings that are set to [*Do Not Move*](soa-setup.md#select-an-optimization-method-for-booking-statuses), and it honors the technician's work hours and break times.

:::image type="content" source="media/soa-suggested-schedule-settings.png" alt-text="Screenshot of suggested schedule settings used by the Scheduling Operations Agent in Dynamics 365 Field Service.":::

### Resource

The name of the resource you selected is filled in for you, but you can edit this field to optimize the schedule of any resource.

### Scheduling goal

The scheduling goal informs the agent what the expected outcome of the optimization is. You have two options to choose from:

- **Maximize utilization** maximizes the time that the technician spends on doing the work for the bookings, taking priority and promise windows into consideration while minimizing travel time. The agent can prefer a lower-priority work order with a [promise time](schedule-time-constraints.md) that expires today over a higher-priority work order that's due tomorrow.

- **Front-load high-priority work** includes as many high-priority requirements as possible, even if it means more travel time and lower utilization. However, the agent doesn't consider the order in which the requirements are booked, so the booking with the highest priority could end up being the last one on the technician's shift.

### Time range

Select the range of time over which the agent should optimize the schedule. By default, the range is from the current time through the end of the current day in the selected time zone. You can optimize the schedule over a custom range and up to 72 hours and up to three days in the future.

The time zone can be different from the local time zone for the resource or the dispatcher. It defaults to the time zone that's selected in the [schedule board settings](schedule-board-tab-settings.md).

When you launch the agent, especially in the Copilot side panel, if the time range and time zone don't match or overlap with the resource's working hours, the agent returns an error message.

### Requirements

To have the agent consider unfulfilled requirements when it optimizes the schedule, select a resource requirement view. You can select any view that you have access to, including shared views, system views, and personal views.

We recommend that you create and select requirement views to help influence the schedule the agent suggests. For example, if the scheduling goal is to front-load high-priority work, it would help to pick a view that only lists high-priority requirements. Or, if you want the agent to only rearrange existing bookings to reduce the travel time, create and select a requirement view that returns an empty list.

#### Other options

You can further influence the agent's suggested schedule using the following constraint settings:

- **Match required characteristics** looks for bookings and requirements that have the same [characteristics](set-up-characteristics.md) as the resource. If this option is unchecked, the agent ignores characteristics and assumes the resource can fulfill any requirement or booking. If it's checked, the agent considers resource and requirement characteristics as follows: If the resource has no characteristics, the agent looks for bookings and requirements that also have no characteristics. If the resource has characteristics, the agent looks for bookings and requirements that have the same characteristics *and* for ones that have no characteristics. If a booking or requirement has a characteristic that doesn't match the resource's, the agent deletes it from the suggested schedule.

- **Match territories** looks for bookings and requirements that have the same [territory](set-up-territories.md) as the resource. If this option is unchecked, the agent ignores territories and assumes the resource can work in every available territory. If it's checked, the agent removes bookings from the suggested schedule that aren't in the same territory as the resource.

- **Schedule within time promised window** considers [time constraints](schedule-time-constraints.md) that are placed on requirements and bookings. If this option is unchecked, the agent ignores time constraints. If it's checked and there are requirements or bookings for which Time to Promised would expire before the end of the optimization range, the agent tries to include them in the suggested schedule as higher importance than the travel time, priority, or duration.

    > [!CAUTION]
    > If you select this option and a booking in the optimization range has an expired promise window, the agent deletes that booking from the suggested schedule.

- **Use predictive travel time** takes historical traffic information into consideration when estimating travel time. If this option is unchecked, the agent calculates travel time based on average travel times. If it's checked, the agent uses past traffic patterns, such as morning rush hour or typical traffic jams, to estimate travel time. However, it doesn't account for real-time traffic disruptions like accidents or road maintenance. Learn more in [Optimization goals in Resource Scheduling Optimization](rso-optimization-goal.md).

## Review the suggested schedule

Review the agent's suggested schedule before you apply it. You can compare the original schedule with the suggested schedule in a list view or on the Gantt chart, along with the suggested travel routes.

In the following example, the technician's original schedule included a job outside of normal work hours, which would have resulted in overtime, and double bookings during the morning.

:::image type="content" source="media/soa-original-schedule.png" alt-text="Screenshot of a technician's schedule with overlapping bookings and overtime.":::

The following example shows the comparison of the original schedule with the Schedule Operations Agent's suggested schedule. The optimized schedule focuses on high-priority work, with no overlapping bookings, and optimizes travel time, all within the technician's normal working hours.

:::image type="content" source="media/soa-optimized-schedule.png" alt-text="Screenshot of an optimized schedule that respects priorities and work hours.":::

To make it easier to interpret the suggested schedule, show travel time on the schedule board. Select the gear icon in the upper-right corner, and then under **Travel Duration Settings**, select **Show Travel Duration**.

To accept a suggested schedule, select **Apply**. You can also select **Adjust settings** to try again. To cancel the optimization request without making any changes to the resource's schedule, select **Cancel**.

To view the travel route comparison for optimized schedules across multiple days, use the date picker on the map view.

## Related information

- [Improve the Scheduling Operations Agent's suggestions (preview)](soa-tips.md)
- [Use Copilot in the Dynamics 365 Field Service web application](copilot-side-pane.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
