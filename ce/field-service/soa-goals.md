---
title: Goals and objectives in the Scheduling Operations Agent (preview)
description: Learn how goals, objectives, and constraints shape the schedules that the Scheduling Operations Agent suggests in Dynamics 365 Field Service.
ms.date: 06/30/2026
ms.topic: concept-article
ms.collection: bap-ai-copilot
ms.author: anclear
author: andrewclear-ms
ai-usage: ai-assisted
---

# Goals and objectives in the Scheduling Operations Agent (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

A *goal* tells the Scheduling Operations Agent what outcome to optimize for. Each goal combines a set of *objectives*, which describe the trade-offs the agent makes, with a set of *constraints*, which determine whether a resource is eligible to fulfill a requirement. You select a goal when you run an [interactive optimization](soa-interactive-optimizations.md) and when you configure a [plan](soa-plans.md) for a batch optimization.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Goals

A goal is a reusable record that stores the settings for an optimization run: the [objectives](#objectives) to balance, the [options](#scheduling-options) that are enabled, and a name and description. Two types of goals exist:

- **Built-in goals** ship with the agent and match the optimization options already available in the settings panel, such as **Maximize Utilization** and **Front-load High-Priority Work**. Built-in goals are read-only, and they're updated over time as new objectives and constraints become available.

- **Custom goals** are goals that an administrator creates from scratch or by cloning a built-in goal. Custom goals are fully editable, so you can choose which objectives to include, set their relative importance, and decide which constraints are enabled by default.

Administrators create and edit goals. Dispatchers and technicians can view goals and select one when they run an optimization.

When you select a goal, the agent applies the goal's default constraints. For an interactive optimization, you can override those defaults for an individual run without changing the goal record. For a batch optimization, the goal applies to the run through the [plan](soa-plans.md).

## Objectives

Objectives describe the outcomes that the agent balances against one another. Increasing one objective usually means sacrificing another. For example, scheduling more high-priority work might increase total travel time.

In a custom goal, select which objectives to include and assign each one a weight from 1 to 10. Include at least one objective, and make each weight unique to stack-rank the objectives by importance. The agent ignores objectives that you don't include.

A weight expresses *relative* importance rather than an absolute amount. The agent interprets the weight based on how that objective is scored and how much optimality it can trade between objectives. For example, with **Prioritize Preferred Resources** weighted at 5, the agent can sacrifice roughly double the average travel time to assign a preferred resource. At 10, it assigns an eligible preferred resource in almost all cases.

The agent supports the following objectives:

| Objective | Description |
| --- | --- |
| Prioritize Preferred Resources | Favor the resources that are [preferred](resource-preferences.md) for a requirement. Preferred resources must still meet all enabled constraints to be eligible. |
| Schedule High Priority Requirements First | Schedule as much high-priority work as possible, based on each requirement's priority value. |
| Prefer Existing Bookings | Favor keeping existing bookings in place to reduce churn in resources' schedules. This gives preference to keeping the same resource assigned, and within 5 minutes of the existing arrival time. |
| Maximize Overall Resource Utilization | Reduce resource downtime so resources spend more of their time on bookings. Utilization doesn't include travel time. |
| Minimize Travel Time | Minimize the overall average travel time per booking in the optimization scope. This objective doesn't minimize the travel time for each booking individually - it considers the average of all travel times across all bookings in scope. |
| Schedule Within Requirement Time Window | Favor scheduling each requirement within its scheduling range. There's no partial credit for scheduling near the range. |
| Prefer Lowest Matching Characteristic Rating | Prefer the least-skilled resource that still meets the requirement, to keep more-skilled resources available for work that needs them. |

## Scheduling options

The goal's **Scheduling options** include options and constraints that you can turn on or off. When you select a goal, the agent applies the goal's settings. For an interactive optimization, you can override them for a single run.

| Option | Description |
| --- | --- |
| Always match required characteristics | The resource must have all the [characteristics](set-up-characteristics.md) that the requirement needs. If the requirement specifies a rating value, the resource's rating must meet or exceed it. A requirement with no characteristics can be fulfilled by any resource, and a resource with no characteristics can fulfill only requirements that need none. |
| Always match territories | The resource must be in the same [territory](set-up-territories.md) as the requirement. A requirement with no territory can be fulfilled by any resource. |
| Always match time window | The booking's arrival time must fall within the requirement's [scheduling range](schedule-time-constraints.md), which is derived from its promise window and date fields. A requirement whose range is already in the past can't be scheduled. |
| Predictive Travel | Uses historical traffic data to attempt to more accurately predict travel at different times of the day. Enabling this option results in slower optimizations, and is subject to different [limits](soa-limits.md). When those limits are exceeded, the system falls back to using standard travel calculations. |

> [!NOTE]
> The **Always match time window** option and the **Schedule Within Requirement Time Window** objective work similarly but do different things. The option decides whether a requirement *must* be scheduled within its time window to be eligible. The objective decides how strongly the agent *tries* to schedule a requirement within its window when the option is turned off.

### Constraints that always apply

These constraints are always enforced and can't be turned off:

| Constraint | Description |
| --- | --- |
| Categories | The resource must belong to at least one of the categories that the requirement specifies. A requirement with no categories can be fulfilled by any resource. |
| Restricted resources | Resources that are marked as restricted for a requirement are never matched to it. A restriction takes precedence over a preference for the same resource, and it can have an expiration date. |
| Must choose from | When a requirement specifies resources to choose from, only those resources are eligible, and they must still meet all other constraints. If none of them can be matched, the requirement isn't scheduled. |
| Resource types | The resource must be one of the resource types that the requirement specifies. When the requirement doesn't specify a type, any resource type is eligible. |

## Create a goal

To create a custom goal:

1. In the **Settings** area of the Resource Scheduling app, under **Optimization**, select **Scheduling Goals**, and then select **New**. To base your goal on a built-in goal, open a built-in goal record and clone it instead.

1. Enter a **Name** and, optionally, a **Description**.

1. For each objective that you want the agent to consider, turn it on and set its **Weighted value** from 1 to 10. Include at least one objective, and give each one a unique weight. The agent ranks the included objectives by weight in a priority ladder, from highest to lowest.

1. Under **Scheduling options**, select the options to enable.

1. Select **Save**.

You can select the goal when running interactive optimizations, or add it to a plan.

## Next steps

- [Improve optimization results](soa-improve-results.md)
- [Run interactive optimizations (preview)](soa-interactive-optimizations.md)
- [Run batch optimizations (preview)](soa-batch-optimizations.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
