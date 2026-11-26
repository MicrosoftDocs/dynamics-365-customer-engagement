---
title: Scopes in the Scheduling Operations Agent (preview)
description: Learn how scopes define the resources, requirements, and bookings that a batch optimization operates over in Dynamics 365 Field Service.
ms.date: 06/30/2026
ms.topic: concept-article
ms.collection: bap-ai-copilot
ms.author: anclear
author: andrewclear-ms
ai-usage: ai-assisted
---

# Scopes in the Scheduling Operations Agent (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

A *scope* defines the set of data that a batch optimization operates over - which resources to optimize, which unfulfilled requirements to consider, and which existing bookings the agent can change. You reference a scope from a [plan](soa-plans.md) when you run a [batch optimization](soa-batch-optimizations.md).

> [!NOTE]
> Scopes apply to batch optimizations only. [Interactive optimizations](soa-interactive-optimizations.md) use the resources and requirement view that you select when you run them.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## What a scope contains

A scope is made up of three queries. You build each query by selecting **Edit** next to the field, and then either starting from an existing view or building the query from scratch. You don't need to write any code, and the agent stores the resulting query rather than a reference to the view.

- **Resources** defines the resources to optimize. The agent automatically excludes unsupported resource types and inactive resources.

- **Open requirements** defines the unfulfilled requirements that the agent considers for scheduling. The agent automatically excludes requirements that are completely fulfilled, closed, or inactive. To run an optimization that only rearranges existing bookings, set this query to return no records.

- **Existing bookings** defines the bookings that the agent can move or change. By default, the agent includes only the bookings that are assigned to the resources in the scope.

To also include bookings that are assigned to other resources, set **Include Bookings From All Resources** to **Yes**. Any booking that the query doesn't return is treated as **Do Not Move**. Use caution when enabling this option, as it can easily result in too many bookings being returned.

## Create a scope

Administrators create scopes. To create a scope:

1. In the **Settings** area of the Resource Scheduling app, under **Optimization**, select **Scheduling Scopes**, and then select **New**.

1. Enter a **Name**.

1. For **Resources**, **Open requirements**, and **Existing bookings**, select **Edit** to build each query. Start from an existing view or build the query from scratch, and then save it.

1. Select **Save**.

## How scopes are evaluated

A scope stores the fetchXML query that's evaluated when the optimization runs, **not** a reference to the view used. This approach avoids permission errors and the need to keep multiple views that are only needed for scopes. If you change the view in the future, the scope isn't updated.

If a query returns more records than the optimization supports, the agent truncates the list. Keep your queries focused so that the most important records are included. Learn more about the specific limits in [Limits and troubleshooting](soa-limits.md#optimization-limits).

A scope doesn't store the optimization time range. The range is part of the [plan](soa-plans.md).

## Next steps

- [Run batch optimizations (preview)](soa-batch-optimizations.md)
- [Plans (preview)](soa-plans.md)
- [Goals and objectives (preview)](soa-goals.md)

[!INCLUDE [footer-banner](../includes/footer-banner.md)]
