---
title: Improve Scheduling Operations Agent results (preview)
description: Learn how to troubleshoot and improve the optimization results of the Scheduling Operations Agent for Dynamics 365 Field Service.
ms.date: 09/03/2026
ms.topic: best-practice
ms.collection: bap-ai-copilot
ms.author: anclear
author: andrewclear-ms
ms.custom:
 - ai-gen-docs-bap
 - ai-seo-date: 06/30/2026
ai-usage: ai-assisted
---

# Improve Scheduling Operations Agent results (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

The Scheduling Operations Agent in Dynamics 365 Field Service suggests optimized schedules by evaluating your resources, resource requirements, and existing bookings. The quality of those suggestions depends on how consistently you configure that data and on which bookings the agent can move.

Use the practices in this article to set up resource and requirement properties, manage existing bookings, and avoid eligibility problems that cause the agent to return incomplete or unexpected results. The guidance applies to both interactive and batch optimizations.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Define resource and requirement properties

The agent evaluates properties of resources and requirements when it optimizes a schedule. To get the best results, use the following properties consistently:

- Resource properties:

  - [Work hours and breaks](set-up-bookable-resources.md#add-work-hours)
  - [Start Location and End Location](set-up-bookable-resources.md#create-other-bookable-resources)
  - [Territories](set-up-territories.md)
  - [Characteristics](set-up-characteristics.md)

- Resource requirements:

  - [From/To Date](schedule-time-constraints.md)
  - **Duration**
  - [Priority](set-priorities.md)
  - [Time From/To Promised](schedule-time-constraints.md)
  - [Territories](set-up-territories.md)
  - [Characteristics](set-up-characteristics.md)

## Test and refine optimization goals

A good [goal](soa-goals.md) balances objectives so that the agent produces the schedule you expect. Because objectives trade off against one another, building one is an iterative process: you create a goal, see what it produces, and adjust it. The safest way to test a new goal is to use a [plan](soa-plans.md) with the **Apply method** set to **Review before apply**. This setting lets you generate and inspect a suggested schedule without changing any bookings.

1. Create a goal with the objectives and weights you want to try. Learn more in [Create a goal](soa-goals.md#create-a-goal).

1. Create a narrow [scope](soa-scopes.md): a small set of resources, a short time range, and a focused requirement query, so that the results are easy to interpret.

1. Create a plan that uses the goal and scope, and set **Apply method** to **Review before apply**.

1. Run the plan, review the suggested schedule, and adjust the goal's weights. Repeat until the results match your expectations.

1. Gradually widen the scope, with more resources and a longer time range, as you gain confidence in the results.

Keep the objectives balanced. Some objectives affect the schedule more than others, so balance is about how they interact, not just the individual weights. An objective weighted far above the rest can overpower the result and cause unexpected schedules. For example, weighting **Schedule High Priority Requirements First** at 10 while everything else is 1–3 might prioritize high-priority work at the cost of long travel and idle gaps. Start with weights that are close together, change one objective at a time, and compare runs.

Your booking priority values and which booking statuses you can optimize also influence your results.

Don't enable objectives that rely on fields or data your organization doesn't use. For example, don't enable the **Prefer preferred resources** objective if your organization doesn't use resource preferences, or **Schedule High Priority Requirements First** if you use only a single priority for work.

## Keep optimizations focused

Smaller, focused optimizations generally produce better results than large, broad ones. Limit each optimization to the resources, requirements, and bookings that belong together:

- Don't include thousands of open requirements when fewer would do. Use a requirement query or view that returns only the work that you want to schedule.

- Don't optimize unrelated sets of resources and requirements in the same batch. Group resources and requirements that are related, such as those in the same territory or that share skills, instead of mixing distant locations or unrelated work.

Large or mixed optimizations are slower, harder to interpret, and more likely to hit the [size limits](soa-limits.md#optimization-limits), which truncate the records that are included. Scope each [plan](soa-plans.md) to a focused set, and for [interactive optimizations](soa-interactive-optimizations.md), choose a requirement view that's narrow enough for the resources you select.

## Manage existing bookings

The agent treats existing bookings the same as unfulfilled requirements, which might lead to unexpected results. For example, if a dispatcher asks the agent for a suggested schedule at 10:00 AM, the agent might suggest replacing the 10:20 AM booking with higher-priority work. The following suggestions can help you avoid these issues:

- Use a custom time range and set it to start an hour or two from the current time.
- Use the [Prefer Existing Bookings objective](soa-goals.md#objectives) in a custom goal to give higher weight to existing bookings.
- For bookings that you want to persist, apply a booking status that has an optimization method of **Do Not Move**. Learn more in [Select an optimization method for booking statuses](soa-setup.md#select-an-optimization-method-for-booking-statuses).
- Use [Booking-level restrictions](soa-booking-level-restrictions.md) to set specific rules on an existing booking.

## Eligible bookings

The agent needs eligible bookable resource bookings and unfulfilled resource requirements to suggest a schedule. It also needs requirements with locations that aren't too far apart. For example, it doesn't return results if the resource is based in New York but bookings and requirements are in Miami.

### Bookings the agent can't move

Some bookings are effectively fixed in place, so the agent can't reschedule them. A booking can be fixed for either of the following reasons:

- The optimization method on the booking's status is **Do Not Move**, or no optimization method is set. If an optimization method isn't set for a booking status, the agent treats those bookings as **Do Not Move** by default.

- The booking's **Optimization behavior** field is set to **Do not move**. This booking-level setting overrides the behavior implied by the booking's status. When **Optimization behavior** is **Do not move**, the restriction is effectively **Resource + Arrival time**, so the agent doesn't change the assigned resource or the arrival time.

A booking's **Restrict to** setting, such as **Resource** or **Arrival time**, can also limit how the agent moves a specific booking, even when the booking is otherwise optimizable.

The agent always enforces **Do not move** restrictions. If there are too many constraints, the agent might not find a feasible schedule, which can result in overlapping bookings or other constraint violations.

To avoid these issues, select an optimization method for all booking statuses. Then check individual bookings for a booking-level **Optimization behavior** of **Do not move** or a **Restrict to** value that prevents the move. Learn more in [Select an optimization method for booking statuses](soa-setup.md#select-an-optimization-method-for-booking-statuses),  [Booking-level restrictions](soa-booking-level-restrictions.md), and [Time range](soa-interactive-optimizations.md#time-range).

### Set priority values and optimization method

If the agent doesn't pick up requirements or bookings at all, make sure that priorities have a priority value set and booking statuses have an optimization method set. Learn more in [Set priority values](soa-setup.md#set-priority-values) and [Select an optimization method for booking statuses](soa-setup.md#select-an-optimization-method-for-booking-statuses).

## Next steps

- [Scheduling Operations Agent limits and troubleshooting (preview)](soa-limits.md)
- [Scheduling Operations Agent FAQ (preview)](faqs-soa.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
