---
title: Use the schedule board in Field Service
description: Learn about the schedule board experience in Dynamics 365 Field Service.
ms.date: 05/14/2024
ms.topic: how-to
author: mkelleher-msft
ms.author: mkelleher
---

# Use the schedule board in Field Service

[!INCLUDE[use-schedule-board.md](../shared/urs/use-schedule-board.md)]

## Automated scheduling with Resource Scheduling Optimization

The following features are only available for organizations using the [Resource Scheduling Optimization Add-in for Dynamics 365 Field Service](rso-overview.md).

The default optimization goal is the default for optimization requests. You can [change the optimization goal for each schedule board](../common-scheduler/schedule-board-tab-settings.md).

### Get resource suggestions or book them directly

In the requirements pane, select one or more requirements.

> [!div class="mx-imgBorder"]
> ![Screenshot of the suggest resources option.](media/scheduling-new-suggest-resources.png)

Select **Suggest resources (Preview)** to get suggestions from Resource Scheduling Optimization about which resources to book.

Select **Book resources (Preview)** to let the system find the optimal resources and book directly.

### Optimize the schedule of a single resource

After a resource's planned schedule has changed due to cancellations or emergency work, you can use Resource Scheduling Optimization for reoptimization. To optimize only a resource's schedule, right-click a resource on the schedule board and select **Optimize schedule**. For more information, see [Single resource optimization with Resource Scheduling Optimization](rso-single-resource-optimization.md).

[!INCLUDE[footer-include](../includes/footer-banner.md)]
