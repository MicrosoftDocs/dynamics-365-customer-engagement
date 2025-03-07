---
title: Schedule in sequence with requirement dependencies
description: Learn how to schedule in sequence by using requirement dependencies in the Resource Scheduling Optimization add-in for Dynamics 365 Field Service.
ms.date: 06/11/2024
ms.subservice: resource-scheduling-optimization
ms.topic: how-to
author: AnilMur
ms.author: anilmur
---

# Schedule in sequence with requirement dependencies

In some situations, requirements must be scheduled in a specific sequence. For example, a technician must stop by a warehouse to pick up a unique part before they go to a customer's site to install that part.

If Resource Scheduling Optimization should schedule requirements in a specific sequence, you can add requirement dependencies. Then, when Resource Scheduling Optimization runs, it ensures that the requirements are scheduled in the correct order. It also ensures that the start time of each successive requirement is after the end time of its predecessor.

## Create a requirement dependency

In the following example, there are two requirements: Task 1.1, which should be completed first, and Task 1.2, which should be completed second.

1. Open the requirement that must be completed first, and select **Related** > **Successors**.
1. Provide a name, and select the requirements that should be the predecessor and the successor.
1. Set the **Dependency Type** field to _StartAfterEnd_.

    :::image type="content" source="media/rso-requirement-dependency-successor.png" alt-text="Screenshot of a requirement dependency.":::

1. Repeat the previous steps to add a requirement dependency for every other requirement in the sequence.

Provided that the requirements are [within the optimization scope](rso-optimization-scope.md), the system respects the dependencies [when Resource Scheduling Optimization runs](rso-optimization-schedule.md).

> [!IMPORTANT]
> - Requirement dependencies support only individual requirements that are scheduled to the same resource through optimization runs. Resource groups aren't supported.
> - Resource Scheduling Optimization schedules successive requirements around [locked bookings](booking-lock-options.md) and considers a resource's work hours. Therefore, depending on the optimization scope, successors might be scheduled for the next workday in some cases.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
