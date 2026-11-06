---
title: Use the schedule board in Field Service
description: Learn about the schedule board experience in Dynamics 365 Field Service.
ms.date: 11/06/2026
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
ai-usage: ai-assisted
ms.reviewer: puneetsingh
ms.custom:
 - bap-template
 - ai-gen-docs-bap
 - ai-seo-date: 06/24/2026
---

# Use the schedule board in Field Service

<!--- This article appears in Field Service and Common Scheduler doc sets. Update metadata in both articles. --->

[!INCLUDE[use-schedule-board](../shared/urs/use-schedule-board.md)]

> [!NOTE]
> The schedule board runs as part of a model-driven app, so it requires a [supported and up-to-date web browser](/power-apps/limits-and-config#supported-browsers-for-running-power-apps). An unsupported or outdated browser is a common cause of the board not loading. If the board doesn't load, see [Schedule board isn't loading](/troubleshoot/dynamics-365/field-service/scheduling/schedule-board-not-loading).

## View appointments on the schedule board

If your [organization enabled appointments](appointment-scheduling.md#enable-appointments-for-your-organization), you can view them on the schedule board. Appointments are read-only and you can't move them. They show for all required attendees and the owner. To see more details, hover over an appointment.

Appointments marked *Private* in Outlook and synced to Dynamics 365 don't show their subject on the schedule board.

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
| Work hours appear shifted by several hours | Time zone mismatch between the resource's work hours and the schedule board view, or a daylight saving time (DST) transition | Verify the time zone set on the resource's work hours matches the resource's actual location. Also check the schedule board's [time zone setting](schedule-board-tab-settings.md). If the shift starts on a DST change date, see [Daylight saving time transition](/troubleshoot/dynamics-365/field-service/scheduling/schedule-board-nan-datetime#cause-daylight-saving-time-dst-transition). |
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
- [Fix schedule board version mismatch errors](/troubleshoot/dynamics-365/field-service/scheduling/schedule-board-version-mismatch)
- [Schedule board performance issues](/troubleshoot/dynamics-365/field-service/scheduling/schedule-board-performance)
- [Schedule board is missing resources](/troubleshoot/dynamics-365/field-service/scheduling/schedule-board-missing-resources)
- [Schedule board shows NaN or datetime errors](/troubleshoot/dynamics-365/field-service/scheduling/schedule-board-nan-datetime)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
