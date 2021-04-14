---
title: "How the liveworkitem-queueitem sync impacts the Queue Item APIs| Microsoft Docs"
description: "How the liveworkitem-queueitem sync impacts the Queue Item APIs"
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 04/15/2021
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-customerservice
search.audienceType: 
  - developer
  - customizer
search.app: 
  - D365CE
  - D365CS
ms.reviewer: nenellim
---
# How the liveworkitem-queueitem sync impacts the queueitem entity in unified routing

When you change the status of a live work item or a queue item, the queue item entity is impacted in the following ways:

- For a particular queue item, when you change the queue from a (1) regular queue to an automatically routed queue or (2) from one automatically routed queue to another via [AddToQueue Action](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/addtoqueue?view=dynamics-ce-odata-9) on the entity record or **RouteTo Action** on the queue item), the associated queue for the live work item is also updated to the same destination queue.
- For the queue items that have associated live work items, when you update the **WorkerId** or **WorkerIdType** (via the **RouteTo Action** on the queue item), the live work item is also assigned to the same agent.
- When a queue item with an associated live work item, you cannot use remove it from the queue by applying the **PickFromQueue Action** or **ReleaseToQueue Action** on the queue item.
- When you deactivate a queue item that's part of an automatically routed queue, you cannot activate it again.
- When you delete a queue item using the **ReleaseToQueue Action**, **RemoveFromQueue Action** or by deleting or canceling the underlying record, the associated live work item is also closed.