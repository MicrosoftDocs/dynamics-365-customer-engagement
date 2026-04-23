---
title: Use the schedule board in Field Service
description: Learn about the schedule board experience in Dynamics 365 Field Service.
ms.date: 03/26/2026
ms.custom: bap-template
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
---

<!-- IMPORTANT: This article was previously an include of ../shared/urs/use-schedule-board.md. Content overlaps with that shared file. If you update this article, make sure you also update the relevant sections in the shared file, and vice versa. -->

# Use the schedule board in Field Service

The schedule board provides dispatchers with an overview of resource availability and bookings. Use it to schedule, reassign, and manage bookings for work orders and other requirements.

:::image type="content" source="media/schedule-board-callouts.png" alt-text="Screenshot of the new schedule board in Dynamics 365.":::

|Number  |Area  |
|---------|---------|
|1     | [Actions area](#actions-area)        |
|2     | [Resource list](#resource-list)        |
|3     | [Requirement pane](#requirement-pane)        |

## Actions area

The actions area at the top of the schedule board provides tools for scheduling and board management:

- **Filters** - Apply filters to define which resources show on the board. Learn more in [Filter resources and requirements](schedule-board-filtering.md).
- **Time scale** - Switch between hourly, daily, weekly, and monthly views. The weekly view always considers Sunday as the start of the week regardless of day visibility settings.
- **View type** - Choose **Gantt** (bar chart showing activities over time) or **List** (expandable resource list with time granularity).

  > [!NOTE]
  > In Gantt view, when you reschedule a task, the board may scroll to the first resource in the list instead of keeping the selected resource centered. Use the resource search or filter to navigate back.
- **Date range** - Set the time frame that shows on the board. Use the arrows to move between time frames.
- **Book** - Manually create a booking. Learn more in [Manual scheduling](schedule-board-manual-scheduling.md).
- **Move bookings** - Select **&hellip;** > **Move bookings** to move bookings to a different day. Learn more in [Drag and drop scheduling](schedule-board-drag-drop.md).
- **Print** - Select **&hellip;** > **Print schedule board** to configure and print the schedule.
- **Details panel** - Select the **Details panel** icon to see more details about the selected booking, resource, or requirement.

  > [!NOTE]
  > Custom booking tooltip views apply to the hourly view only. In daily, weekly, and monthly views, the schedule board displays a simplified tooltip that doesn't reflect custom view columns.
- **Booking alerts** - Select the bell icon to see active alerts or create new ones. Learn more in [Manage booking alerts](booking-alert.md).
- **Map view** - Select the **Map view** icon to see resources and requirements on a map. Learn more in [Filter resources and requirements](schedule-board-filtering.md#use-the-map-view-to-find-nearby-resources).
- **Refresh** - Manually refresh the board. The board also refreshes automatically for changes to start date, end date, resource assignment, or status of a booking in the current week.

  > [!TIP]
  > Availabilities in the schedule assistant don't refresh when the schedule board gets refreshed. Search for availabilities again or refresh the browser to have the latest updates reflected in the schedule assistant.
- **Focus mode** - Select the **Focus mode** icon to hide navigation and go full screen.
- **Legend** - Select **&hellip;** > **Legend** to view color codes and icons for status, priority, timeline, and travel time.
- **Scheduler settings** - Select **&hellip;** > **Scheduler settings** to open board view settings. Learn more in [Configure schedule board settings](schedule-board-tab-settings.md).

## Resource list

To show more options, right-click a resource's name:

- Choose **View resource card** to see the resource's skills and roles. You can also initiate a message, email, or phone call.
- Choose **Get driving directions** to get the driving directions for a work day.

## Requirement pane

The requirement pane shows unscheduled requirements. Select a requirement and select **Find availability** to launch the [schedule assistant](schedule-assistant.md), which lists available and matching resources.

> [!NOTE]
> Filtering isn't supported on the **Owner** column on the *Unscheduled Work Orders* tab.

Learn more in [Filter resources and requirements](schedule-board-filtering.md).

## Create a new schedule board tab

To create a new schedule board tab, select **New schedule board tab** (+) in the tab list on the schedule board.

Enter the [relevant details about your new schedule board](schedule-board-tab-settings.md) and select **Add**.

## Copy the link to a schedule board

The simplest way to share a schedule board URL is to configure the board as you prefer, select **More options (&hellip;)** and choose **Copy link**. The generated link includes the parameters currently configured on your board.

:::image type="content" source="media/schedule-board-copy-link.png" alt-text="Screenshot of the Copy link option on the schedule board.":::

## Cached settings

To facilitate workflows, the system caches some parameters so you can quickly continue where you left off:

- Last accessed tab
- Map panel: Open or closed
- View type: Gantt or list view
- View mode: Hourly, daily, or weekly
- Board start date: Cached for 15 minutes
- Column width: Zoom level
- Requirement panel filters

## View appointments on the schedule board

If your [organization enabled appointments](appointment-scheduling.md#enable-appointments-for-your-organization), you can view them on the schedule board. Appointments are read-only and you can't move them. They show for all required attendees and the owner. To see more details, hover over an appointment.

Appointments marked *Private* in Outlook and synced to Dynamics 365 don't show their subject on the schedule board.

## Automated scheduling with Resource Scheduling Optimization

The following features are only available for organizations using the [Resource Scheduling Optimization Add-in for Dynamics 365 Field Service](rso-overview.md).

The default optimization goal is the default for optimization requests. You can [change the optimization goal for each schedule board](../common-scheduler/schedule-board-tab-settings.md).

### Get resource suggestions or book them directly

In the requirements pane, select one or more requirements.

:::image type="content" source="media/scheduling-new-suggest-resources.png" alt-text="Screenshot of the suggest resources option.":::

Select **Suggest resources (Preview)** to get suggestions from Resource Scheduling Optimization about which resources to book.

Select **Book resources (Preview)** to let the system find the optimal resources and book directly.

### Optimize the schedule of a single resource

After a resource's planned schedule changes due to cancellations or emergency work, use Resource Scheduling Optimization for reoptimization. To optimize only a resource's schedule, right-click a resource on the schedule board and select **Optimize schedule**. Learn more in [Single resource optimization with Resource Scheduling Optimization](rso-single-resource-optimization.md).

## Known behavior changes with the new schedule board

When you switch to the new schedule board experience, you might notice the following behavior changes compared to the classic board.

| Behavior | Details | Workaround |
|---|---|---|
| Requirement panel filters reset | Filters you apply in the Requirement panel are stored in browser cache and clear when you switch between the classic and new board. | Reapply your filters once after switching. They're saved for future sessions. |
| Requirement panel column widths reset | Column sizing in the Requirement panel doesn't stay when you move between the classic and new board. | Resize columns to your preferred layout after switching. |
| Requirement view uses "Starts with" filtering | To improve performance and reduce the risk of throttling, filters in the Requirement view now use **Starts with** instead of **Contains**. | To use **Contains**, apply a column-level filter. |
| Requirement lookup uses Requirement panel view | When you book a requirement, the lookup now uses the same view as the Requirement panel instead of the default lookup view. This change is fixed as of release [8.8.133.214](version-history-archive.md#88133214). | No action needed. |
| RSO checkboxes limited to RSO extension tab | For organizations with Resource Scheduling Optimization (RSO): checkboxes now appear only on the RSO extension tab (which uses the classic board), not on other schedule board tabs. | Use the RSO extension tab to access checkboxes. |

## Next steps

- [Filter resources and requirements](schedule-board-filtering.md)
- [Drag and drop scheduling](schedule-board-drag-drop.md)
- [Manual scheduling](schedule-board-manual-scheduling.md)
- [Review resource utilization](schedule-board-utilization.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
