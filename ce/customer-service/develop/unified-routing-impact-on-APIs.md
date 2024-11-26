---
title: Understand how unified routing affects queue items and live work items for routed records
description: Learn how unified routing affects queue items, live work items, and the corresponding APIs.
ms.date: 07/31/2024
ms.topic: conceptual
author: gandhamm
ms.author: mgandham
ms.custom: bap-template
ms.reviewer:
ms.collection:
---

# Understand how unified routing affects queue items and live work items for routed records

When you route a case using unified routing, the system creates a live work item record ([`msdyn_ocliveworkitem`](reference/entities/msdyn_ocliveworkitem.md)) to track the workstream settings for allowed presence, matched skills, and available capacity. The unified routing engine uses these settings to route the record to the appropriate queue based on route-to-queue rules and to an agent based on presence, skills, and capacity.

After the record is routed to the queue, a queue item ([`queueitem`](reference/entities/queueitem.md)) is created with the following fields:

- the queue to which the queue item belongs
- the worker ID or agent assigned to the queue items
- the state of the queue item, active or inactive

When a record is automatically assigned to an agent or is picked up by an agent, unified routing updates the following details:
- Agent as the record owner
- Agent in the live work item
- Worker ID in the queue item

Unified routing automatically synchronizes these updates from the queue item to the live work item, but not the other way around. Any changes to the live work item aren't automatically reflected in the queue item. If you need to make a manual update, we recommend that you update the queue item, and let the unified routing engine update the live work item automatically.

You can update only one field of the queue item at a time.

Unified routing automatically sets the record's owner to a user.

We recommend that you don't add any custom logic to live work items. Microsoft uses them in unified routing services.

## How unified routing affects queue items, live work items for routed records

This section describes how queue items and live work items are updated when you change the status of a queue item with unified routing.

### What happens when you change the Queue field

You can change the **Queue** field by selecting [**Add to Queue**](/power-apps/developer/data-platform/webapi/reference/addtoqueue) on the record or [**Route To**](/power-apps/developer/data-platform/webapi/reference/routeto) on the queue item.

- When you change the **Queue** field from an advanced queue to another advanced queue, then the queue for the associated live work item ([msdyn_ocliveworkitem](reference/entities/msdyn_ocliveworkitem.md)) is changed to the same queue, and the unified routing services that maintain agent presence and capacity are updated with the corresponding changes.

- When you change the **Queue** field from an advanced queue to a basic queue, then the associated live work item ([msdyn_ocliveworkitem](reference/entities/msdyn_ocliveworkitem.md)) and table record are closed, the queue item is no longer considered for routing by the unified routing engine, and the unified routing services that maintain agent presence and capacity are updated with the corresponding changes.

- When you change the **Queue** field from a basic queue to an advanced queue, then the queue item is no longer considered for routing by the unified routing engine. You must reroute the queue item using **Save & Route** so that the corresponding live work item can be picked up by the unified routing services. 

### What happens when you change the Worked By field

You can change the **Worked By** field by selecting [**Route To**](/power-apps/developer/data-platform/webapi/reference/routeto) on the queue items list or by manually updating the **Worked By** field on the QueueItem details form.

- When you update the **Worked By** field of a queue item, then the live work item ([`msdyn_ocliveworkitem`](reference/entities/msdyn_ocliveworkitem.md)) is assigned to the same agent.

- When automatic assignment routes the record and the record is assigned to an agent, then the **Worked By** field is set to the agent who's assigned in the queue item, the agent field in the live work item, and the owner field in the record.

> [!CAUTION]
> If you run a custom script, flow, or action that updates the queue item, live work item, or record at the same time as the automatic assignment, then you might experience assignment errors. We recommend that you run custom scripts or flows before or after the automatic assignment is complete.

## What happens when you delete or deactivate a queue item

You can delete a queue item by selecting [**Remove**](/power-apps/developer/data-platform/webapi/reference/removefromqueue) or by deleting or closing the underlying record.

- When you delete a queue item, the associated live work item ([`msdyn_ocliveworkitem`](reference/entities/msdyn_ocliveworkitem.md)) is also closed and the unified routing services that maintain agent presence and capacity are updated with the corresponding changes.

- When you [deactivate a queue item](deactivate-queue-items.md), the associated live work item ([`msdyn_ocliveworkitem`](reference/entities/msdyn_ocliveworkitem.md)) is also closed and the unified routing services that maintain agent presence and capacity are updated with the corresponding changes.

  If the record needs to be reopened, you must reroute it using **Save & Route**. Don't reactivate the queue item. The rerouting creates a new live work item and a new queue item, ensuring all the information needed for routing is available again.

- When you update a queue item using unified routing, you can't remove it from the queue by selecting [**Pick**](/power-apps/developer/data-platform/webapi/reference/pickfromqueue) or **RouteTo action** on the queue item.

- When you resolve a case, the corresponding queue item that gets deactivated can't be activated again.


Unified routing works on the underlying table record for the owner field. Make sure to [provide Read privileges](../implement/add-users-assign-roles.md) to the agents for that table and any other dependent table.

To get the capacity released for agents for tables other than incident through incident resolution or cancellation, add custom logic to deactivate the corresponding queue item. [Learn more about capacity profiles](../administer/capacity-profiles.md).

For records other than cases, we recommend that you deactivate the associated queue item before you delete it.

## Next steps

[Close live work items or deactivate queue items](deactivate-queue-items.md)

### Related information

[Overview of unified routing](../administer/overview-unified-routing.md)   
[Set up record routing](../administer/set-up-record-routing.md)   
[Set up unified routing](../administer/set-up-routing-process.md)   


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
