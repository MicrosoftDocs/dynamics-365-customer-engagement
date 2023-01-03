---
title: Impact of unified routing on queue items, live work items, and APIs| MicrosoftDocs
description: How unified routing affects queue items, live work items, and the corresponding APIs.
ms.date: 01/04/2023
ms.topic: article
author: mh-jaya
ms.author: v-jmh
ms.custom: bap-template
ms.reviewer: nenellim
---
# How unified routing impacts queue items and live work items

Queue items are at the core of the record routing process. Whenever you route a record using unified routing, a queue item is created based on the route-to-queue rules. At the same time, a live work item (msdyn_ocliveworkitem) is also created for managing agent presence and capacity.

Here are a few important considerations to keep in mind when you work with queue items and live work items:

- To change the queue of a queue item from basic to advanced, you must reroute it so that it can be picked up by the unified routing services. If you manually change the queue of the queue item from basic to advanced, then it won't be considered for routing by the unified routing engine. 

- We recommend that you don't add any custom logic on live work items as Microsoft uses them in unified routing services.

## How unified routing impacts queue items and the corresponding APIs

When you change the status of a queue item that has been routed using unified routing, the queue item is affected in the following ways:

- When you change a queue item from a basic queue to an advanced queue&mdash;or from one advanced queue to another&mdash;by selecting  **Add to Queue** on the record (via the [AddToQueue Action](/dynamics365/customer-engagement/web-api/addtoqueue?view=dynamics-ce-odata-9&preserve-view=true)) or by selecting **Route To** on the queue item (via the [**RouteTo Action**](/dynamics365/customer-engagement/web-api/routeto?view=dynamics-ce-odata-9&preserve-view=true)), then the associated queue for the live work item ([msdyn_ocliveworkitem](/dynamics365/customer-service/developer/reference/entities/msdyn_ocliveworkitem)) also gets updated to the same destination queue. This action then updates the unified routing services that maintain agent presence and capacity with the corresponding changes.

- When you change a queue item from one advanced queue to a basic queue by selecting **Add to Queue** on the record (via the [AddToQueue Action](/dynamics365/customer-engagement/web-api/addtoqueue?view=dynamics-ce-odata-9&preserve-view=true)) or by selecting **Route To** on the queue item (via the [**RouteTo Action**](/dynamics365/customer-engagement/web-api/routeto?view=dynamics-ce-odata-9&preserve-view=true)), then the associated live work item ([msdyn_ocliveworkitem](/dynamics365/customer-service/developer/reference/entities/msdyn_ocliveworkitem)) is closed and the queue item moves out of the unified routing umbrella. This action then updates the unified routing services that maintain agent presence and capacity with the corresponding changes.

- When you update the **Worked By** field of queue items by selecting **Route To** on the queue items list (via the **RouteTo Action**) or by manually updating the **Worked By** field on the QueueItem details form, then the live work item (msdyn_ocliveworkitem) also gets assigned to the same agent.

- Unified routing changes the owner of the underlying entity record when it finds the right agent as per assignment method. If you change the **Worked By** field, then the the owner of the underlying entity record is also changed.

- When you update a queue item using unified routing, you can't remove it from the queue by selecting **Pick** ([**PickFromQueue Action**](/dynamics365/customer-engagement/web-api/pickfromqueue?view=dynamics-ce-odata-9&preserve-view=true)) or **RouteTo Action** on the queue item.

- When you resolve a routed record, the corresponding queue item that gets deactivated can't be activated again.

- When you delete a queue item by selecting **Remove** (via the [**RemoveFromQueue Action**](/dynamics365/customer-engagement/web-api/removefromqueue?view=dynamics-ce-odata-9&preserve-view=true)) or by deleting or canceling the underlying record, the associated live work item (msdyn_ocliveworkitem) is also closed. This action then updates the unified routing services that maintain agent presence and capacity with the corresponding changes.

Note:- Since unified routing also works upon the underlying entity record for the owner field, you must keep in mind for providing the right read privilege to the agents for that entity as well. And the same applies to any other dependent entity thereafter. For information on how to provide the accesses to different roles for the entities, see Manage user accounts, user licenses, and security roles (Dynamics 365 Marketing).

Note: - To get the capacity released for the agents for entities other than incident (via incident resolution or cancelation), have a custom logic to get the corresponding queue item deactivated. Create and manage capacity profiles | Microsoft Learn

## Next steps


### See also

[Overview of unified routing](overview-unified-routing.md)   
[Set up record routing](set-up-record-routing.md)   
[Set up unified routing](set-up-routing-process.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]
