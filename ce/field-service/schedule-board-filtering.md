---
title: Filter resources and requirements on the schedule board
description: Learn how to filter resources and requirements on the schedule board in Dynamics 365 Field Service to find the right resources quickly.
ms.date: 03/26/2026
ms.custom: bap-template
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
---

<!-- IMPORTANT: Content in this article overlaps with ../shared/urs/use-schedule-board.md. If you update this article, make sure you also update the relevant sections in that shared file, and vice versa. -->

# Filter resources and requirements on the schedule board

Use filters on the [schedule board](work-with-schedule-board.md) to narrow down which resources and requirements are displayed. Filtering helps dispatchers quickly find the right resources for a job.

## Filter resources

Apply filters to define which resources show on the schedule board. Filter values are pulled from the *Bookable Resource* entity. You can [configure the board settings so filters also apply to requirements](schedule-board-tab-settings.md).

In **Resource filters**, select the ellipsis (&hellip;) > **Select Resources** to choose a subset of all resources for the schedule board. Select **Apply** to see the changes on the schedule board.

- To make the applied filter configuration the default for all schedule boards, select **&hellip;** > **Save as default**.

- To remove all applied filters, select **Reset to default**. The list of selected resources resets when you remove the resources from the selection.

## Filter requirements

The requirement pane shows unscheduled requirements. Each column can be sorted and filtered by accessing a drop-down menu next to each column header.

> [!NOTE]
> Filtering isn't supported on the **Owner** column on the *Unscheduled Work Orders* tab.

Select a single requirement from the requirement pane and select **Find availability** to launch the [schedule assistant](schedule-assistant.md). The schedule assistant lists available and matching resources that you can book for the requirement.

## Use the map view to find nearby resources

To see resources and requirements on a map, select the **Map view** icon on the schedule board.

On the map view, select a resource to see their planned route. The numbers indicate in which order requirements are scheduled to a resource.

Change the date to see the map for a different day. Zoom out of the map to see grouped requirements and resources. Quickly identify areas with unscheduled jobs and start scheduling these jobs to the nearest resources. Select the **View settings** icon to set which items show on the map.

On each resource pin associated with a user, there's an indicator icon representing how long ago the resource's location was detected. Green indicates that the user was seen since the start of the current day. A grey question mark indicates that the location was last detected yesterday or earlier.

## Next steps

- [Manually schedule from the schedule board](schedule-board-manual-scheduling.md)
- [Drag and drop to schedule on the board](schedule-board-drag-drop.md)
- [Configure schedule board settings](schedule-board-tab-settings.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
