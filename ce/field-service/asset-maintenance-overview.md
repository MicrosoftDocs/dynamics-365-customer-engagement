---
title: Asset maintenance overview (preview)
description: Learn how asset maintenance in Dynamics 365 Field Service uses reusable plans, service forecasts, and work orders to streamline recurring service.
ms.date: 10/28/2026
ms.topic: overview
author: jshotts
ms.author: jasonshotts
ms.reviewer: v-wendysmith
---

# Asset maintenance overview (preview)

[!INCLUDE [public-preview-banner](../includes/public-preview-banner.md)]

Asset maintenance in Field Service helps organizations maintain assets according to how the equipment ages, how much it is actually used, and which service activities are already completed. Create reusable maintenance plan templates and quickly apply them to assets that share the same asset category, manufacturer, or model. Applying a template creates the asset maintenance plan without requiring planners to configure every maintenance requirement individually.

The system forecasts service events based on the maintenance schedule. It generates eligible work orders according to the schedule type and configured work order creation lead time, which means some work orders, such as calendar-based work orders, can be generated before their maintenance due date. Planners have one place to manage calendar-based, actual usage-based, and multistep maintenance strategies.

[!INCLUDE [public-preview-note](../includes/public-preview-note.md)]

## Key benefits

The feature provides:

- Faster maintenance setup by applying reusable templates to similar assets.

- Forecast maintenance service events that planners can review before work is generated.

- Calendar and agenda views of upcoming service activities.

- Work order generation for eligible service events.

- Traceability from a work order back to the maintenance requirement that generated it.

## Assets and maintenance plans

- A **customer asset** can have one maintenance plan. Each maintenance plan belongs to one customer asset.

- A **maintenance plan** contains one or more maintenance schedules.

- A **maintenance schedule** identifies the [type of maintenance schedule](asset-maintenance-schedule-types.md) and defines services and their positions or steps.

- A **service** defines the work content, work order type, and incident types. A service can appear in multiple positions.

- A **position** places a service in the schedule and defines its applicable timing or sequence.

- A **service event** is a generated occurrence of the maintenance schedule. Daily, the system evaluates a maintenance plan and creates or updates eligible forecast service events and generates work orders for events that enter the configured work-generation window.

- A **maintenance plan template** contains template maintenance schedules and maintenance services that you can reuse across assets.

## Template snapshot

When you apply a maintenance plan template to an asset, you create a maintenance plan and instantiate the template’s maintenance schedule, services, and positions. The resulting plan is a point-in-time snapshot of the template.

Changes you make to the template afterward don't update plans that you already created from it. Edit the asset’s maintenance plan directly when its requirements differ from the original template. You can also create a maintenance plan for an asset without using a template.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
