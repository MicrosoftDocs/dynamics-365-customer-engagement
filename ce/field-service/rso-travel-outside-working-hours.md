---
title: Allow travel time outside of working hours with Resource Scheduling Optimization
description: Learn how to configure the Resource Scheduling Optimization add-in for Field Service to consider travel outside of working hours.
ms.date: 02/19/2025
ms.subservice: resource-scheduling-optimization
ms.topic: how-to
author: AnilMur
ms.author: anilmur
---

# Allow travel time outside of working hours with Resource Scheduling Optimization

By default, the Resource Scheduling Optimization add-in for Dynamics 365 Field Service considers travel time part of a technician's work hours. However, this default setting doesn't match every organization's business needs. For example, a technician's work hours begin at 8 AM. By default, the optimization algorithm schedules the technician to start to travel to the customer's site at 8 AM. Therefore, the technician won't start to work at the site until some time after 8 AM.

Administrators can change the settings of an optimization goal to allow travel time outside of working hours. Then, enable the resources that can travel outside working hours.

[Resource utilization](resource-utilization-report.md) might improve if travel time isn't considered part of a technician's work hours.

To allow travel outside of working hours:

1. [Remove the schedule within working hours constraint](#remove-the-schedule-within-working-hours-constraint) in an optimization goal.

1. [Enable the resources](#enable-the-resources-for-scheduling-outside-of-working-hours) for traveling outside working hours.

The system can then schedule a technician to begin their workday a little earlier. In this way, they can start to travel before the beginning of working hours and arrive at the work location when their work hours begin.

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=ee03b616-b4e1-4ae4-9bd3-3513c14f8f5e]

## Remove the schedule within working hours constraint

To remove the default constraint from an optimization goal, follow these steps.

1. [Open the optimization goal](rso-optimization-goal.md) for which you want to allow travel time outside of working hours.

1. Remove the **Schedule Within Working Hours** constraint.

   :::image type="content" source="media/optimization-goal-travel-constraint.png" alt-text="Screenshot of an optimization goal that has the Schedule Within Working Hours constraint.":::

1. Save and publish.

## Enable the resources for scheduling outside of working hours

Define which resources are considered for travel outside of working hours.

1. In Resource Scheduling Optimization, go to **Scheduling** > **Resources**.

1. Open a bookable resource.

1. On the **Scheduling** tab, for the **Schedule Outside Work Hours** field, select **Allow Travel Before Work Hours**, **Allow Travel After Work Hours**, or both.

1. For the **Travel Limit (in minutes)** field, specify how much extra time, in minutes, the Resource Scheduling Optimization algorithm can allocate for travel. The travel limit that you define applies to both travel before working hours and travel after working hours. You can't define a separate travel limit for each option.

   :::image type="content" source="media/rso-travel-outside-resource.png" alt-text="Screenshot showing the scheduling rules for a bookable resource.":::

[!INCLUDE[footer-include](../includes/footer-banner.md)]
