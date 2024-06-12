---
title: Schedule in sequence with requirement dependencies
description: Learn how to schedule in sequence using requirement dependencies in the Resource Scheduling Optimization add-in for Dynamics 365 Field Service.
ms.date: 06/11/2024
ms.subservice: resource-scheduling-optimization
ms.topic: how-to
author: AnilMur
ms.author: anilmur
---

# Schedule in sequence with requirement dependencies

There are situations that could call for a specific sequence in which requirements must be scheduled., For example, a technician needs to stop by a warehouse to pick up a unique part before traveling to a customer's site to perform a repair/replacement operation.

You can ensure that Resource Scheduling Optimization schedules requirements in a desired sequence by adding requirement dependencies. When Resource Scheduling Optimization runs, it ensures the requirements are scheduled in the correct order where the start time of the successor is after the end time of the predecessor.

## Create a requirement dependency

In the following example, we have two requirements - Task 1.1, which should be completed first followed by Task 1.2, which should be completed second.

1. Open the requirement to be completed first and select **Related** > **Successors**.
1. Provide a name and choose requirements as predecessor and successor.
1. Set **Dependency Type** type as _StartAfterEnd_.

:::image type="content" source="media/rso-requirement-dependency-successor.png" alt-text="Screenshot of a requirement dependency.":::

For every requirement in the sequence, add a requirement dependency.

Assuming the requirements are [within the optimization scope](rso-optimization-scope.md), the system respects the dependencies [when Resource Scheduling Optimization runs](rso-optimization-schedule.md).

> [!IMPORTANT]
>
> - Requirement dependencies support only individual requirements that are scheduled through optimization runs to the same resource. Resource groups are not supported.
> - Resource Scheduling Optimization schedules successive requirements around [locked bookings](booking-lock-options.md) and considers a resources work hours. So you might see cases, where successors are scheduled to the next work day, depending on the optimization scope.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
