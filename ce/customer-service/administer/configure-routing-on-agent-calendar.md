---
title: Configure routing based on external schedules (preview)
description: Learn how to configure routing of work items to representatives based on shift schedules generated in external WFM systems.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection: 
ms.date: 03/03/2025
ms.custom: bap-template
---

# Configure routing based on external schedules (preview)

[!INCLUDE[cc-feature-availability](../../includes/cc-feature-availability.md)]

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner.md)]

Configure assignment rules to route and assign cases and conversations based on customer service representatives' (service representative or representative) shift schedules imported from external workforce management (WFM) systems. By verifying representatives' schedules in advance, organizations can avoid routing tasks to off-duty service representatives, and reduce the risk of delays. 

You can incorporate shift assignments and time-off considerations into the routing process to foster an employee-centric approach, and streamline operational workflows for productivity and improved retention rates.

> [!Note]
> Routing based on external schedules isn't supported in the Government Community Cloud (GCC) or sovereign clouds.

## Prerequisites

- [Workforce Management for Customer Service](configure-agent-calendar.md#enable-workforce-management) is enabled in your environment.
- [Unified routing](provision-unified-routing.md) is provisioned and set up.
- [Workstreams](create-workstreams.md) and [advanced queues](queues-omnichannel.md) are set up.
- [Custom assignment method](configure-assignment-rules.md) is configured for the queue.
- You must have a third-party adapter configured to import representative schedules from an external system. Without an adapter in place, external schedules can't be surfaced in the agent calendar, and representatives can't view their schedules in Dynamics 365 Customer Service.
- Shift-based routing is enabled.
- When you are importing external schedules using the third-party adapter, opt in every representative ([bookableresource](../develop/reference/entities/bookableresource.md)) into shift-based routing by setting the **msdyn_generatecalendarfromshift** column of the corresponding bookableresource entry to **True**.

## Enable shift-based routing

1. In the Customer Service admin center site map, select **Workforce management** under **Operations**.
1. In the **Shift based routing (preview)** section, select **Manage**.
1. On the **Shift based routing (preview)** page, turn on the **Enable routing based on shift bookings** toggle, and then select **Save**.

## Import external schedule data

You can use a third-party adapter to import schedules from external WFM systems into Dynamics 365 for Customer Service.

Alternatively, you can also use [Organization Service](/power-apps/developer/data-platform/org-service/overview) or [Dataverse OData Web API](/power-apps/developer/data-platform/webapi/overview) to import representative schedules from external systems into Dynamics 365. For a detailed overview of how to import external schedules and the entities in Customer Service that can represent these external schedules, see the [Schedule import integration](https://github.com/microsoft/dynamics365-customerservice-wem-samples/wiki/Schedule-import-integration) guide.

## Configure an assignment rule

1. In the Customer Service admin center site map, select **Queues**, and then select **Manage** in the **Advanced queues** area.
1. Select the queue that you want to configure the assignment rule for, select the [custom assignment](configure-assignment-rules.md) method, and select **Edit**.
1. Create a rule or modify an existing rule and do the following:
    1. In **Conditions**, select **Add row**, and then select **Calendar schedule**. The **Is working** value is automatically selected.
    1. Save and close.

       :::image type="content" source="../media/screenshot-of-calendar-schedule-condition.png" alt-text="Screenshot of assignment rule configured on calendar schedule.":::

## View routing diagnostics records

View the [routing diagnostics record](unified-routing-diagnostics.md) to understand how a work item is routed when routing is configured based on agent calendar attribute.

## How shift-based routing works

The imported schedules from external systems are represented in Dynamics 365 as "bookings". The [bookableresourcebooking](../develop/reference/entities/bookableresourcebooking.md) entity stores this information. Each booking is assigned to a representative. The representative is recorded as a bookable resource and each of them with one or more bookings has a corresponding entry in the [bookableresource](../develop/reference/entities/bookableresource.md) entity.

An automated process synchronizes the representative's imported schedules with the representative's work hour calendar. The following rules apply for the automatic synchronization:

- After you opt in the representative for shift-based routing, the first automated sync occurs after **180 minutes** to allow the external schedules to be imported for the representative.
- After the first automated sync, the representative's bookings are synchronized with their work hour calendar every **180 minutes**.
- Each automated run synchronizes the representative's bookings for the next **28 days**, starting from the time of the automated sync. Bookings beyond 28 days aren't synchronized.
- Any updates to the booking, including deletion of the booking, are immediately reflected in the corresponding work hour entry for the booking. For example, if the end time for a synchronized booking is updated, then the end time of the corresponding work hour calendar entry is also updated immediately. Similarly, if a synchronized booking is deleted, then the corresponding work hour calendar entry is also removed.

After the representative's bookings are synchronized with their work hour calendar, unified routing routes work items based on the work hour calendar entries.

## Next steps

[Use Customer Service workspace](../implement/csw-overview.md)  
[View the agent calendar](../use/use-agent-calendar.md)  
