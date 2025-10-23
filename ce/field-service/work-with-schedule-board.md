---
title: Use the schedule board in Field Service
description: Learn about the schedule board experience in Dynamics 365 Field Service.
ms.date: 07/10/2025
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
---

# Use the schedule board in Field Service

[!INCLUDE[use-schedule-board.md](../shared/urs/use-schedule-board.md)]

## View appointments on the schedule board

If your [organization enabled appointments](appointment-scheduling.md#enable-appointments-for-your-organization), you can view them on the schedule board. Appointments are read-only and you can't move them. They show for all required attendees and the owner. Hover over an appointment to see more details.

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

After a resource's planned schedule has changed due to cancellations or emergency work, you can use Resource Scheduling Optimization for reoptimization. To optimize only a resource's schedule, right-click a resource on the schedule board and select **Optimize schedule**. Learn more: [Single resource optimization with Resource Scheduling Optimization](rso-single-resource-optimization.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
