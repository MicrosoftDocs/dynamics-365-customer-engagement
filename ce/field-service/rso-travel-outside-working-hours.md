---
title: Allow travel time outside of working hours with Resource Scheduling Optimization
description: Learn how to configure the Resource Scheduling Optimization add-in for Field Service to consider travel outside of working hours.
ms.date: 06/24/2024
ms.subservice: resource-scheduling-optimization
ms.topic: how-to
author: AnilMur
ms.author: anilmur
---

# Allow travel time outside of working hours with Resource Scheduling Optimization

By default, the Resource Scheduling Optimization add-in for Dynamics 365 Field Service considers travel time a part of a technician's work hours. This default setting doesn't match every organization's business needs. For example, a technician's work hours start at 8 am. By default, the optimization algorithm schedules them to begin traveling at 8 am and thus, they won't start the work at a customer site until some time after 8 am.

Administrators can [change the settings of an optimization goal](rso-optimization-goal.md) to allow travel time outside of working hours. This setting lets the system schedule the technician to begin their day a little earlier to begin traveling before working hours and arrive at the work location when their work hours start.

Not considering travel time as part of a technician's working hours might lead to improved [resource utilization](resource-utilization-report.md).

> [!VIDEO https://www.microsoft.com/videoplayer/embed/RE4Fe9O]

## Edit constraints of the optimization goal

Change the optimization goal to remove the default constraint.

1. [Open the optimization goal](rso-optimization-goal.md) for which you want to allow travel outside of working hours.

1. Remove the constraint **Schedule Within Working Hours**.

:::image type="content" source="media/optimization-goal-travel-constraint.png" alt-text="Screenshot of an optimization goal with constraints.":::

## Enable a resource for scheduling outside working hours

Define which resources to consider for travel outside of work hours.

1. In Resource Scheduling Optimization, go to **Scheduling** > **Resources**.
1. Open a bookable resource, and go to the **Scheduling** tab.
1. For **Schedule Outside Work Hours**, choose **Allow Travel Before Work Hours**, **Allow Travel After Work Hours**, or both.
1. Provide a **Travel Limit (in minutes)** to define how much extra time the Resource Scheduling Optimization algorithm can allocate for travel. The travel limit applies to travel before and after work hours. You can't define separate values for either option.

:::image type="content" source="media/rso-travel-outside-resource.png" alt-text="Screenshot of resource details, showing the scheduling rules.":::

[!INCLUDE[footer-include](../includes/footer-banner.md)]
