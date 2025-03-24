---
title: Run the Scheduling Operations Agent (preview)
description: Learn how to invoke and run the Scheduling Operations Agent for Dynamics 365 Field Service.
ms.date: 03/24/2025
ms.topic: how-to
ms.author: anilmur
author: anilmur
---

# Run the Scheduling Operations Agent (preview)

There are two ways to have the Scheduling Operations Agent suggest an optimized schedule:

1. When on any page in the Field Service app, via the [Copilot side pane](copilot-side-pane.md): Select the Copilot icon in the app header and prompt Copilot to suggest a schedule. For example: Suggest an optimal schedule.

   :::image type="content" source="media/soa-copilot-chat.png" alt-text="Screenshot of a chat conversation with Microsoft Copilot and the schedule options for a suggested schedule.":::

1. From the Schedule Board: Right-click the resource name and select **Suggest Schedule**. If the agent doesn't support the selected resource type, the option is greyed out and you can review the tooltip to understand the reason.

   :::image type="content" source="media/soa-suggest-schedule.png" alt-text="Screenshot of a schedule board with the expanded options for a selected resource.":::

After you launch the agent, the system suggests default settings that you can adjust before starting an optimization request for the selected resource. The following sections discuss the settings for the optimization requests.

## Adjust the settings for optimization requests

You can adjust the settings for each optimization request to ensure the agent suggests a schedule that meets your business requirements. Irrespective of the settings, the agent will not move any bookings that are set to [Do Not Move](soa-setup.md#create-or-update-optimization-method-for-booking-status), and it honors the technician’s work hours and break times.

:::image type="content" source="media/soa-suggested-schedule-settings.png" alt-text="Screenshot of the options for the suggested schedule with several values selected.":::

### Resource

If you launched the agent using the Copilot sidecar, you can specify the name of the resource. Else if you launched via the schedule board, the name of the resource is auto-populated. In either case, you can edit this field to optimize the schedule of any resource.

### Scheduling goal

The scheduling goal informs the agent about the expected outcome of the optimization. There are two options to choose from.

- **Maximize utilization**: maximize the time that the technician spends on doing the work for the bookings, taking priority and promise windows into consideration while minimizing travel time. The agent could prefer a lower priority work order with a [promise time](schedule-time-constraints.md) expiring today over a higher priority work order that is due tomorrow. 
- **Front-load high priority work**: include as many high priority requirements as possible at the expense of more travel time and lower utilization. However, the agent doesn't consider the order in which the requirements are booked. So, the booking with the highest priority could end up being the last one on the technician’s shift.

### Time range

This parameter defines the range over which the schedule gets optimized. By default, this range is between the current time and the end of the current day (11:59PM) in the time zone shown in the settings panel. This time zone could be different from the resource's time zone or the dispatcher's time zone - the default value is taken from the zone set in the [Schedule Board settings](schedule-board-tab-settings.md).

:::image type="content" source="media/soa-time-range.png" alt-text="Screenshot of the time range dropdown options showing the allowed time ranges.":::

You can choose from other time ranges or a custom range, which can be up to 72 hours and up to three days in the future.

### Requirements

You can inform the agent to consider unfulfilled requirements by picking any of the existing resource requirement views that the dispatcher has access to. These views include shared views, system views, and personal views. We recommend that you create and select requirement views to help influence the suggested schedule returned by the agent. For example, if the scheduling goal is to front-load high priority work, it would help to pick a view that only lists high-priority requirements.

> [!TIP]
> If you want the agent to only re-arrange existing bookings to reduce travel time, you can define and use a requirement view that returns an empty list.

### Options

You can further influence the suggested schedule via the following constraint settings.

- **Match required characteristics**: Matches requirements with the [characteristics](set-up-characteristics.md) of the resource. If this option is unchecked, the agent ignores characteristics and assumes the resource can fulfill any requirement or booking. Otherwise, if the option is checked, then the agent honors characteristics as follows. For a bookable resource that has no characteristics, the agent chooses from bookings and resource requirements that also have no characteristics. A resource with none or more characteristics can fulfill requirements that have no characteristics. Note that if an existing booking has a characteristic which doesn't match with the resource's skills, the agent will delete that booking from the suggested schedule.
- **Match territories**: If checked, ensures that bookings and requirements have the same [territory](set-up-territories.md) as the resource. The agent removes bookings that aren't in the same territory as the resource from the suggested schedule. If this option is unchecked, the agent ignores territories and assumes the resource can work in every available territory. 
- **Schedule with promised time window**: Considers the [time constraints](schedule-time-constraints.md) for requirements and bookings. If there are requirements or bookings for which Time to Promised would expire before the end of the optimization range, the agent tries to include them in the suggested schedule as higher importance than the travel time, priority, or duration. If this option is unchecked, the agent ignores such time constraints.
    > [!CAUTION]
    > If you enable this option and an existing booking in the optimization range has an expired promise window, the agent deletes that booking from the suggested schedule.
- **Use predictive travel**: By default, the agent calculates travel time based on average travel time. Enabling this option lets the agent consider historical traffic information when estimating travel time. For example, by considering rush hour in the morning or typical traffic jams. However, it doesn’t account for traffic in real-time. For more information, see: [Travel Time Calculation](rso-optimization-goal.md#create-a-scheduling-optimization-goal).

## Review the suggested schedule

A dispatcher can review the suggested schedule before applying it for the resource. They can compare the original with the suggested schedule on the Gantt chart together with the travel routes or see the suggestions in a list view.

The following screenshot shows an example where a resource had a suboptimal schedule before the agent was used. An important job was manually scheduled outside work hours and this led to double-booking during the morning.

:::image type="content" source="media/soa-original-schedule.png" alt-text="Screenshot of a schedule with overlapping bookings for a resource.":::

When the Schedule Operations Agent successfully completes, it suggests a new schedule without overlaps, focused on high-priority work, and optimized travel time - all within the resource's working hours.

> [!TIP]
> To make it easier to interpret the suggested schedule, enable the setting to show travel time on the schedule board.

:::image type="content" source="media/soa-optimized-schedule.png" alt-text="Screenshot of an optimized schedule that respects priorities and work hours.":::

To accept a suggested schedule, select **Apply**. You can also choose to **Adjust settings** and try again or **Cancel** the optimization request without making any changes to the resource’s schedule.

For optimized schedules across multiple days, use the date picker on the map view to see the travel route comparison for each day.

## Next steps

- [Tips and troubleshooting for the Scheduling Operations Agent (preview)](soa-tips.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
