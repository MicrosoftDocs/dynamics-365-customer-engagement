---
title: Run interactive optimizations (preview)
description: Learn how to run interactive optimizations to optimize one or more technicians' schedules with the Scheduling Operations Agent in Dynamics 365 Field Service.
ms.date: 06/30/2026
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.author: anclear
ms.reviewer: v-wesmith
author: andrewclear-ms
ai-usage: ai-assisted
---

# Run interactive optimizations (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Use the Scheduling Operations Agent to make in-the-moment adjustments to up to five technicians' schedules from Copilot, the schedule board, or a resource. You select the resources to optimize, review the agent's suggested schedule, and apply it when you're satisfied. Choose interactive optimization for targeted, on-demand changes during the day. For larger, asynchronous runs that are configured with a scope, a goal, and a plan, learn more in [Run batch optimizations (preview)](soa-batch-optimizations.md).

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Prerequisites

- An administrator must [set up the agent](soa-setup.md).
- You have the **Scheduling Operations Agent User** or **Scheduling Operations Agent Administrator** role. Learn more in [Assign permissions and roles](soa-setup.md#assign-permissions-and-roles).

## Launch the agent

You can launch the agent from several places. Every entry point opens the same optimization settings panel, where you confirm the resources to optimize.

### Copilot side pane

1. In any Field Service page, select the Copilot icon in the app header.

1. In the chat box, enter a prompt such as **Suggest a schedule** or **Optimize the schedules for my team**.

### Schedule board

- To optimize one resource, right-click the resource's name and select **Suggest schedule**.

- To optimize several resources at once, hold Ctrl (or Cmd on a Mac), select multiple resource rows, and select **Suggest schedule** from the schedule board toolbar.

- To open the settings panel without preselecting resources, select **Suggest schedule** on the schedule board toolbar, and then add resources in the panel.

If a selected resource type isn't supported, the **Suggest schedule** option is unavailable. Check the tooltip for details.

### Resource list

1. Go to a resource list view in the Field Service or Resource Scheduling app.

1. Select one or more resources.

1. On the toolbar, select **Suggest schedule**.

The **Suggest schedule** toolbar button is also available from eligible resource records.

## Adjust the settings for optimization requests

After you launch the agent, it suggests settings that you can adjust before it starts generating an optimized schedule. Adjust the settings as needed to ensure that the agent suggests a schedule that meets your business requirements.

Regardless of the settings you select, the agent doesn't move any bookings that are set to [**Do Not Move**](soa-setup.md#select-an-optimization-method-for-booking-statuses), and it honors the technician's work hours and break times.

### Resources

The system fills in the resources you selected. Use the **Resource** field to search for and add or remove resources before the agent generates a schedule. You can start with a single resource and add more, or start with several resources and reduce the list. The agent optimizes the selected resources' schedules together.

### Scheduling goal

The scheduling goal tells the agent what outcome to optimize for. Select a goal from the list of goals you have access to. The list includes the following built-in goals, along with any custom goals that your administrator creates:

- **Maximize Utilization** maximizes the time that the technician spends on doing the work for the bookings, taking priority and promise windows into consideration while minimizing travel time. The agent can prefer a lower-priority work order with a [promise time](schedule-time-constraints.md) that expires today over a higher-priority work order that's due tomorrow.

- **Front-load High-Priority Work** includes as many high-priority requirements as possible, even if it means more travel time and lower utilization. However, the agent doesn't consider the order in which the requirements are booked, so the booking with the highest priority could end up being the last one on the technician's shift.

When you select a goal, the agent sets the scheduling options to that goal's defaults. You can override them for the current run without changing the goal. If you switch to a different goal, the options reset to the new goal's defaults. For more information, see [Goals and objectives (preview)](soa-goals.md).

### Time range

For **Time range**, select a preset such as **Next 3 days**, and the panel shows the resulting dates. You can optimize any window up to 72 hours in the future.

### Time zone

For **Time zone**, select the time zone for the optimization. The time zone can be different from the resource's or the dispatcher's local time zone. When the interactive optimization is initated from the schedule board, it defaults to that time zone. When launched from other entry points, the user's configured time zone is used.

### Requirements

To have the agent consider unfulfilled requirements when it optimizes the schedule, select a resource requirement view. You can select any view that you have access to, including shared views, system views, and personal views.

Create and select requirement views to help influence the schedule the agent suggests. For example, if the scheduling goal is to front-load high-priority work, pick a view that only lists high-priority requirements. Or, if you want the agent to only rearrange existing bookings to reduce the travel time, create and select a requirement view that returns an empty list.

### Scheduling options

The **Scheduling options** field lists constraints that you can turn on or off to influence the suggested schedule. It shows how many are selected, such as **(3 of 4 selected)**. The available options are:

- **Always match required characteristics** ([characteristics](set-up-characteristics.md))
  - Off: The agent ignores characteristics and assumes the resource can fulfill any booking or requirement.
  - On: The agent enforces characteristic matching:
    - If the resource has no characteristics, only bookings and requirements with no characteristics are considered.
    - If the resource has characteristics, bookings and requirements with matching characteristics (or none) are considered.
    - Bookings and requirements with nonmatching characteristics are removed from the suggested schedule.

- **Always match territories** looks for bookings and requirements that have the same [territory](set-up-territories.md) as the resource. If you clear this option, the agent ignores territories and assumes the resource can work in every available territory. If you select it, the agent removes bookings from the suggested schedule that aren't in the same territory as the resource.

- **Always match time window** considers [time constraints](schedule-time-constraints.md) that are placed on requirements and bookings. If you clear this option, the agent ignores time constraints. If you select it and there are requirements or bookings for which Time to Promised would expire before the end of the optimization range, the agent tries to include them in the suggested schedule as higher importance than the travel time, priority, or duration.

    > [!CAUTION]
    > If you select this option and a booking in the optimization range has an expired promise window, the agent deletes that booking from the suggested schedule.

- **Use predictive travel time** takes historical traffic information into consideration when estimating travel time. If you clear this option, the agent calculates travel time based on average travel times. If you select it, the agent uses past traffic patterns, such as morning rush hour or typical traffic jams, to estimate travel time. However, it doesn't account for real-time traffic disruptions like accidents or road maintenance. Because predictive travel time varies by departure time, the suggested schedule might show small gaps between bookings, which is expected.

The agent also applies other eligibility rules that you can't turn off, such as categories, restricted and must-choose-from resources, and resource types. Learn more in [Goals and objectives (preview)](soa-goals.md).

## Review the suggested schedule

Review the agent's suggested schedule before you apply it. A summary at the top of the window describes the goal, the number of resources, and the time range. You can compare the original schedule with the suggested schedule in the list view, on the Gantt chart, or on the map, along with the suggested travel routes.

When you optimize a single resource, its row expands and the map shows by default. When you optimize multiple resources, each resource appears as a separate row with the suggested schedule shown above the current schedule. The rows are collapsed and the map is hidden by default. Expand a resource to see the details of its schedule, or use **Expand all** and **Collapse all** to show or hide every resource at once. On the map, you can filter to show suggested or current routes, highlight the route for a selected resource, and see each stop numbered in visit order.

To act on the suggested schedule, select one of the following options:

- **Apply** accepts the suggested schedule.
- **Adjust settings** reruns the optimization with different constraints.
- **Cancel** discards the suggestion without changes.

If results aren't meeting expectations, learn more in [Improve optimization results](soa-improve-results.md).

## Next steps

- [Improve optimization results](soa-improve-results.md)
- [Use Copilot in the Dynamics 365 Field Service web application](copilot-side-pane.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
