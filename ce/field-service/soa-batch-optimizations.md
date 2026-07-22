---
title: Run batch optimizations (preview)
description: Configure and run batch optimizations across resources, requirements, and bookings with the Scheduling Operations Agent in Dynamics 365 Field Service.
ms.date: 06/25/2026
ms.topic: how-to
ms.collection: bap-ai-copilot
ms.author: anclear
author: andrewclear-ms
ai-usage: ai-assisted
---

# Run batch optimizations (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

As an administrator or dispatcher, use batch optimizations to have the Scheduling Operations Agent rebalance a large set of resources, requirements, and bookings asynchronously. You configure the work once as a scope, a goal, and a plan, run it on demand, and review the results before they're applied or have them applied automatically.

Use batch optimizations to optimize broadly across many resources and bookings in the background. To optimize the schedules of one or a few specific technicians right now, use [interactive optimizations (preview)](soa-interactive-optimizations.md) instead.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Prerequisites

- An administrator [set up the agent](soa-setup.md).
- You have the **Scheduling Operations Agent Administrator** role to create scopes, goals, and plans, or the **Scheduling Operations Agent User** role to run an existing plan. Learn more in [Assign permissions and roles](soa-setup.md#assign-permissions-and-roles).

Find scopes, goals, and plans in the **Settings** area of the Resource Scheduling app, under **Optimization**.

## Step 1: Create a goal

A goal defines the objectives and constraints for the optimization. Create a custom goal or use a built-in goal. Learn more in [Goals and objectives (preview)](soa-goals.md).

## Step 2: Create a scope

A scope defines which resources to optimize, which unfulfilled requirements to consider, and which existing bookings the agent can change. Learn more in [Scopes (preview)](soa-scopes.md).

## Step 3: Create a plan

A [plan](soa-plans.md) combines the scope and goal with a time range.

1. In the **Settings** area of the Resource Scheduling app, under **Optimization**, select **Scheduling Plans**, and then select **New**.

1. Enter a **Name**.

1. Select the **Scope** you created.

1. For **Scheduling goal**, select the goal you created.

1. For **Apply method**, select **Review before apply** or **Apply automatically**.

1. Set the time range with **Time range reference**, **Time range offset**, and **Duration**. To learn more, see [Time range](soa-plans.md#time-range).

1. Select **Save**.

## Step 4: Run the plan

Open the plan and select **Run optimization plan**. The run starts immediately, and the new request appears in the plan's **Optimization Requests** grid. Whether the results are applied automatically or held for you to review depends on the plan's **Apply method**, which you set in [Step 3](#step-3-create-a-plan).

The optimization runs asynchronously, so you can continue working while the agent processes the request. A plan runs only one optimization request at a time.

## Step 5: Review and apply the results

In the plan's **Optimization Requests** grid, find the request for the run. When a request is **Ready for review**, open it to review the suggested schedule. A summary at the top of the review window describes the goal, the number of resources, and the time range. The window shows the suggested schedule in several views:

- **Gantt**: A timeline of the suggested schedule, where each resource row is marked **Suggested**. Use the **Hourly** control to change the time scale, and expand a resource to see its bookings.
- **Map**: The suggested routes, with each stop numbered in visit order.
- **Booking details**: A list of the bookings in the result, including the **Change Type** (**Create**, **Update**, **Delete**, or **None**), booking status, resource, start and end time, and duration.
- **Open requirements**: A list of the requirements that couldn't be scheduled, including priority and promise times.

Switch between the **Map**, **Booking details**, and **Open requirements** views from the view selector on the toolbar.

To apply the result, select **Apply**. The changes are applied asynchronously. If bookings, requirements, or resources changed since the request ran, the agent warns you before applying. You can't apply a request that's more than 72 hours old or past the start of its time range.

If a request shows **Failed**, or the results aren't what you expect, learn more in [Improve optimization results (preview)](soa-improve-results.md) and [Limits and troubleshooting (preview)](soa-limits.md).

## Next steps

- [Plans (preview)](soa-plans.md)
- [Scopes (preview)](soa-scopes.md)
- [Goals and objectives (preview)](soa-goals.md)
- [Run interactive optimizations (preview)](soa-interactive-optimizations.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
