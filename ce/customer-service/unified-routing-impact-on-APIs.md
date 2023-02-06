---
title: Understand unified routing and its impact on queue items and live work items| MicrosoftDocs
description: How unified routing affects queue items, live work items, and the corresponding APIs.
ms.date: 02/07/2023
ms.topic: article
author: mh-jaya
ms.author: v-jmh
ms.custom: bap-template
ms.reviewer: nenellim
---
# Understand unified routing and its impact on queue items and live work items

Whenever you route a record using unified routing, Omnichannel for Customer Service creates a live work item entity (`msdyn_ocliveworkitem`) to track the workstream settings for allowed presence and capacity. The unified routing engine uses these settings to route the records to the appropriate queue based on route-to-queue rules and to the available agent based on presence and capacity.

After the record is routed to the queue, Omnichannel for Customer Service also creates a queue item (`queueitem`). The queue item updates the following three  fields: 
- the queue to which the queue item belongs
- the worker ID or agent assigned to the queue item
- the state of the queue item, whether active or inactive
 
When a record is picked by the agent or is assigned automatically to the agent, then unified routing does the following:
- updates the agent as the record owner
- updates the agent in the live work item
- updates the worker ID in the queue item

Unified routing automatically synchronizes these updates from the queue item to the live work item, but not vice-versa. So, any updates from the live work item are not automatically reflected in the queue item. If you'd like to manually make these updates, we recommend that you update only the queue item so that the live work item gets updated automatically by the unified routing engine. 

You can update only one field of the queue item at a time, in a transaction. For example, if both the queue and the worker ID fields must be updated, then update the queue field in one transaction, and the worker ID field in the next transaction.

> [!NOTE]
> - We recommend that you don't add any custom logic on live work items as Microsoft uses them in unified routing services.
> - Unified routing automatically sets the record's owner to a user or team and the Owning Business Unit to that user or team's business unit. So, we recommend that you don't update these values of the live work item entity. More information: [Table relationship and cascading behavior](/power-platform/admin/update-record-owner#table-relationship-and-cascading-behavior)
## How unified routing impacts queue items, live work items, and the corresponding APIs

This section describes how queue items and live work items are affected when you change the status of a queue item with unified routing.

### What happens when you change the Queue field

- When you change the **Queue** field from an advanced queue to another&mdash;by selecting **Add to Queue** on the record (via the [AddToQueue Action](/dynamics365/customer-engagement/web-api/addtoqueue?view=dynamics-ce-odata-9&preserve-view=true)) or by selecting **Route To** on the queue item (via the [**RouteTo Action**](/dynamics365/customer-engagement/web-api/routeto?view=dynamics-ce-odata-9&preserve-view=true)), then the associated queue for the live work item ([msdyn_ocliveworkitem](/dynamics365/customer-service/developer/reference/entities/msdyn_ocliveworkitem)) also gets updated to the same destination queue. This action then updates the unified routing services that maintain agent presence and capacity with the corresponding changes.

- When you change the **Queue** field from an advanced queue to a basic queue by selecting **Add to Queue** on the record (via the [AddToQueue Action](/dynamics365/customer-engagement/web-api/addtoqueue?view=dynamics-ce-odata-9&preserve-view=true)) or by selecting **Route To** on the queue item (via the [**RouteTo Action**](/dynamics365/customer-engagement/web-api/routeto?view=dynamics-ce-odata-9&preserve-view=true)), then the associated live work item ([msdyn_ocliveworkitem](/dynamics365/customer-service/developer/reference/entities/msdyn_ocliveworkitem)) and the entity record are closed, and the queue item is no longer considered or picked by the unified routing engine. This action then updates the unified routing services that maintain agent presence and capacity with the corresponding changes.

- When you change the **Queue** field of a queue item from basic queue to advanced queue, then you must reroute the queue items using **Save & Route** so that the corresponding live work item can be picked up by the unified routing services. If you manually change the queue of the queue item from basic to advanced, then the queue item won't be considered for routing by the unified routing engine. 

### What happens when you update the Worked By field 

- When you update the **Worked By** field of queue items by selecting **Route To** on the queue items list (via the **RouteTo Action**) or by manually updating the **Worked By** field on the QueueItem details form, then the live work item (msdyn_ocliveworkitem) also gets assigned to the same agent.

- When automatic assignment routes the record and the record is assigned to the agent, then the **Worked By** field is set to the agent that's assigned in the queue item, the agent field in the live work item, and the owner field in the record. 

> [!CAUTION]
> If you're running a custom script, flow or action that updates these three entities at the same time as the automatic assignment, then you might experience assignment errors. We recommend that you run any custom scripts or flows after or before the automatic assignment.

## What happens when you delete or deactivate a queue item

- When you delete a queue item by selecting **Remove** (via the [**RemoveFromQueue Action**](/dynamics365/customer-engagement/web-api/removefromqueue?view=dynamics-ce-odata-9&preserve-view=true)) or by deleting or canceling the underlying record, the associated live work item (msdyn_ocliveworkitem) is also closed. This action then updates the unified routing services that maintain agent presence and capacity with the corresponding changes.

- When you [deactivate a queue item](deactivate-queue-items.md), the associated live work item (msdyn_ocliveworkitem) is also closed. This action then updates the unified routing services that maintain agent presence and capacity with the corresponding changes. If the record needs to be reopened, then you must reroute it using **Save & Route**, and not reactivate the queue item. The rerouting creates a new live work item and a new queue item, ensuring all the information needed for routing is available again.

- When you update a queue item using unified routing, you can't remove it from the queue by selecting **Pick** ([**PickFromQueue Action**](/dynamics365/customer-engagement/web-api/pickfromqueue?view=dynamics-ce-odata-9&preserve-view=true)) or **RouteTo Action** on the queue item.



> [!Note]
> - Since unified routing also works upon the underlying entity record for the owner field, ensure that you provide the right read privilege to the agents for that entity and any other dependent entity. For information on how to provide the accesses to different roles for the entities, see [Manage user accounts, user licenses, and security roles](/marketing/admin-users-licenses-roles).
> - To get the capacity released for the agents for entities other than incident (via incident resolution or cancelation), add a custom logic to get the corresponding queue item deactivated. More information: [Create and manage capacity profiles](capacity-profiles.md)
- When you resolve a routed record, the corresponding queue item that gets deactivated can't be activated again.



## Next steps

[Close live work items or deactivate queue items](deactivate-queue-items.md)

### See also

[Overview of unified routing](overview-unified-routing.md)   
[Set up record routing](set-up-record-routing.md)   
[Set up unified routing](set-up-routing-process.md)   

[!INCLUDE[footer-include](../includes/footer-banner.md)]
