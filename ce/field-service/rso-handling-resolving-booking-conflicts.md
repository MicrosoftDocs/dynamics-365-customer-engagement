---
title: Resolve booking conflicts in Resource Scheduling Optimization
description: Learn how to resolve booking conflicts in the Resource Scheduling Optimization add-in for Dynamics 365 Field Service.
ms.date: 08/05/2025
ms.subservice: resource-scheduling-optimization
ms.topic: how-to
author: andrewclear-ms
ms.author: anclear
---

# Resolve booking conflicts in Resource Scheduling Optimization

Booking conflicts can occur when someone changes a resource, requirement, or booking during an optimization run that involves that resource, requirement, or booking. Resource Scheduling Optimization helps you understand and resolve these conflicts.

In conflict scenarios, the optimization request status is *Completed with Conflicts*.

The optimization request booking view includes bookings that have conflicts because of edits that were made during optimization. You can identify these bookings because they have a booking status of *Simulation*, and a conflict icon is shown for them.

The **Operation Details** column shows more details, such as the specific data changed during optimization.

To resolve the conflicts, select one or more of the affected bookings (bookings with a status of *Simulation*), and then select one of the following options:

- **Apply with Overwrite**: Commit the simulation booking. Select this option to keep the optimization results.
- **Discard**: Remove the simulation booking. Select this option to keep the manual booking edits from the dispatcher or field technician.

After you select **Apply with Overwrite** or **Discard**, the optimization status changes to *Completed*, and the conflict is resolved.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
