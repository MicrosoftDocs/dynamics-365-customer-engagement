---
title: Use the schedule board in Field Service
description: Learn about the schedule board experience in Dynamics 365 Field Service.
ms.date: 06/24/2026
ms.custom: bap-template
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
ai-usage: ai-assisted
---

# Use the schedule board in Field Service

[!INCLUDE[use-schedule-board](../shared/urs/use-schedule-board.md)]

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

## Work hours display on the schedule board

The schedule board uses each resource's work hour calendar to show available (colored) and unavailable (grayed out) time slots. If the schedule board shows incorrect availability for a resource, check the following common causes:

| Issue | Likely cause | Resolution |
|---|---|---|
| Days appear grayed out when the resource should be working | A business closure or time-off entry overlaps with working hours | Open the resource's **Work Hours** tab and check for conflicting calendar rules. Remove or adjust overlapping entries. |
| All time slots are grayed out | No working hours are defined for the resource, or the work hours recurrence ended | Open the resource's **Work Hours** tab, verify that working hours exist, and ensure the recurrence covers the date range shown on the board. |
| Work hours appear shifted by several hours | Time zone mismatch between the resource's work hours and the schedule board view | Verify the time zone set on the resource's work hours matches the resource's actual location. Also check the schedule board's [time zone setting](schedule-board-tab-settings.md). |
| Resource shows available on holidays | Business closures aren't applied to the resource's calendar | In the resource's **Work Hours** tab, select **New** > **Non-working** and add the applicable closure dates. |

Learn more about setting up work hours in [Set up bookable resources](set-up-bookable-resources.md#add-work-hours).

## Next steps

- [Filter resources and requirements](schedule-board-filtering.md)
- [Drag and drop scheduling](schedule-board-drag-drop.md)
- [Manual scheduling](schedule-board-manual-scheduling.md)
- [Review resource utilization](schedule-board-utilization.md)

## Related information

If you run into issues with the schedule board, see the following troubleshooting articles:

- [Schedule board isn't loading](/troubleshoot/dynamics-365/field-service/scheduling/schedule-board-not-loading)
- [Schedule board performance issues](/troubleshoot/dynamics-365/field-service/scheduling/schedule-board-performance)
- [Schedule board is missing resources](/troubleshoot/dynamics-365/field-service/scheduling/schedule-board-missing-resources)
- [Schedule board shows NaN or datetime errors](/troubleshoot/dynamics-365/field-service/scheduling/schedule-board-nan-datetime)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
