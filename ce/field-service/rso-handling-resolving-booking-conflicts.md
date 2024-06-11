---
title: "Resolving booking conflicts in Resource Scheduling Optimization for Dynamics 365 | MicrosoftDocs"
description: Learn how to resolve booking conflicts in Resource Scheduling Optimization for Dynamics 365
ms.date: 06/11/2024
ms.subservice: resource-scheduling-optimization
ms.topic: how-to
author: AnilMur
ms.author: anilmur
---

# Resolve booking conflicts in Resource Scheduling Optimization

Booking conflicts can occur when someone changes a resource, requirement, or booking during an optimization run involving that resource, requirement or booking is ongoing. Resource Scheduling Optimization provides a way to understand these conflicts and resolve them.

In conflict scenarios, the optimization request has the status **Completed with Conflicts**.

Within the optimization request booking view, you can see the bookings that were edited during optimization, leading to a conflict. These bookings have a booking status of **Simulation**, along with a conflict icon.

The **Operation Details** column shows more details, like the specific data modified during optimization.

> [!div class="mx-imgBorder"]
> ![Requirement group with two requirements.](./media/scheduling-rso-3-0-booking-conflict.png)

To resolve the issue, select one or more of the affected bookings (with a Simulation status), and choose either:

- **Apply with Overwrite**: commit the simulation booking, favoring optimization results
- **Discard**: remove simulation booking, favoring the manual booking edits from the dispatcher or field technician

> [!div class="mx-imgBorder"]
> ![Screenshot of a requirement group with 2 requirements.](./media/scheduling-rso-3-0-booking-conflict-override.png)

After selecting **Apply with Overwrite** or **Discard**, the optimization status changes to **Completed**, and the conflict is resolved.

> [!div class="mx-imgBorder"]
> ![Screenshot of requirement group with 2 requirements_3.](./media/scheduling-rso-3-0-booking-conflict2.png)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
