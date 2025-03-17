---
title: Configure routing based on shift bookings
description: Learn how to configure routing of work items to representatives based on shift schedules of representatives.
author: neeranelli
ms.author: nenellim
ms.reviewer: nenellim
ms.topic: how-to
ms.collection: 
ms.date: 03/03/2025
ms.custom: bap-template
---

# Configure routing based on shift bookings

Configure assignment rules to route and assign cases and conversations based on customer service representatives' (service representative or representative) shift bookings in workforce management (WFM) system or schedules imported from external systems. By verifying representatives' schedules in advance, organizations can route tasks to only those service representatives who are available, and reduce the risk of delays. 

You can incorporate shift assignments and time-off considerations into the routing process to foster an employee-centric approach, and streamline operational workflows for productivity and improved retention rates.

> [!NOTE]
> Routing based on external schedules isn't supported in the Government Community Cloud (GCC) or sovereign clouds.

With shift bookings, the routing engine considers the shift activity type to determine if a representative can be considered for assignment. If the shift activity type is "not assignable", such as training or lunch break, then the representative isn't considered for assignment.

## Prerequisites

- [Workforce Management for Customer Service](configure-agent-calendar.md#enable-workforce-management) is enabled in your environment, or a non-Microsoft adapter is configured to import representative schedules from an external system. If you're importing external schedules using the non-Microsoft adapter, opt in every representative ([bookableresource](../develop/reference/entities/bookableresource.md)) into shift-based routing by setting the **msdyn_generatecalendarfromshift** column of the corresponding bookableresource entry to **True**.
- Shift activity types are enabled and created in WFM system.
- [Unified routing](provision-unified-routing.md) is provisioned and set up.
- [Workstreams](create-workstreams.md) and [advanced queues](queues-omnichannel.md) are set up.
- [Custom assignment method](configure-assignment-rules.md) is configured for the queue.
- Shift-based routing is enabled.

## Enable shift-based routing

1. In the site map of Contact Center admin center or Customer Service admin center, select **Workforce management** under **Operations**.
1. In the **Shift based routing** section, select **Manage**.
1. On the **Shift based routing** page, turn on the **Enable routing based on shift bookings** toggle, and then select **Save**.

## Import external schedule data

Optionally, if you want to integrate schedules from external WFM systems, you can use a non-Microsoft adapter to import the schedules into Customer Service.

Alternatively, you can use [Organization Service](/power-apps/developer/data-platform/org-service/overview) or [Dataverse OData Web API](/power-apps/developer/data-platform/webapi/overview) to import representative schedules from external systems into Dynamics 365. For a detailed overview of how to import external schedules and the entities in Customer Service that can represent these external schedules, see the [Schedule import integration](https://github.com/microsoft/dynamics365-customerservice-wem-samples/wiki/Schedule-import-integration) guide.

## Configure an assignment rule

You can configure custom assignment method and rules by doing the steps in [Configure assignment methods](configure-assignment-rules.md).

## View routing diagnostics records

View the [conversation diagnostics in Azure Application Insights](configure-conversation-diagnostics.md) to understand how a work item is routed when routing is configured based on shift bookings.

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
