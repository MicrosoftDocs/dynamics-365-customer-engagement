---
title: Plans in the Scheduling Operations Agent (preview)
description: Learn how plans combine a scope, a goal, and a time range to run and review batch optimizations in Dynamics 365 Field Service.
ms.date: 06/30/2026
ms.topic: concept-article
ms.collection: bap-ai-copilot
ms.author: anclear
author: andrewclear-ms
ai-usage: ai-assisted
---

# Plans in the Scheduling Operations Agent (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

A *plan* combines a [scope](soa-scopes.md), a [goal](soa-goals.md), and a time range. It's the starting point for running a [batch optimization](soa-batch-optimizations.md) and for reviewing previous optimization requests.

> [!NOTE]
> Plans apply to batch optimizations only. To optimize schedules in the moment, use an [interactive optimization](soa-interactive-optimizations.md).

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## What a plan contains

The following table describes each setting in a plan.

| Setting | Description |
| --- | --- |
| Name | A name that identifies the plan. |
| Scope | The [scope](soa-scopes.md) of resources, requirements, and bookings to optimize. |
| Scheduling goal | The [goal](soa-goals.md) of objectives and constraints that shape the result. |
| Apply method | Whether results apply automatically or wait for review. See [Apply method](#apply-method). |
| Description | Optional notes about the plan. |
| Time range reference | The point that the optimization range starts from. See [Time range](#time-range). |
| Time range offset | How far from the time range reference the range begins. |
| Duration | How long the optimization range lasts. |

## Time range

A plan's time range tells the agent which window of time to optimize. Define the time range using three fields:

- **Time range reference**: The point that the range starts from. Select **Optimization start time** (the moment the run starts) or **Beginning of the optimization's current day**.

- **Time range offset**: How far from the time range reference the range begins. For example, an offset of **1 hour** starts the range one hour after the reference point.

- **Duration**: How long the range lasts, such as **3 days**.

For example, to optimize three days of work starting one hour after a run begins, set **Time range reference** to **Optimization start time**, **Time range offset** to **1 hour**, and **Duration** to **3 days**.

## Apply method

The apply method determines what happens after the agent finishes an optimization:

- **Review before apply** holds the results so that you can review them and apply them later.

- **Apply automatically** applies the results as soon as the optimization finishes.

## Optimization requests

Each time you run a plan, the agent creates an *optimization request* that records the result. To run a plan, open it and select **Run optimization plan**. The run starts immediately, and the new request appears in the plan's **Optimization Requests** grid. Whether the result is applied automatically or held for you to review depends on the plan's **Apply method**. A plan runs only one optimization request at a time, so you can't start a new request while a previous one is still solving or applying.

An optimization request moves through these statuses:

| Status | Description |
| --- | --- |
| Solving | The agent is generating the suggested schedule. |
| Ready for review | The request finished and is waiting for you to review and apply it. |
| Applying | The agent is applying the suggested changes to the schedule. |
| Applied | The suggested changes were applied. |
| Failed | The request couldn't be completed. |

The plan's **Optimization Requests** grid lists its requests, including each request's status, start time, end time, and expiration. Open a request to review it, and resolve any errors or conflicts.

A result expires so that an old suggestion can't be applied after the schedule changes too much. The **Expires on** value is 72 hours after the request runs, or the start of its time range, whichever is sooner.

## Next steps

- [Run batch optimizations (preview)](soa-batch-optimizations.md)
- [Scopes (preview)](soa-scopes.md)
- [Goals and objectives (preview)](soa-goals.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
