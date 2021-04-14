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
# How the liveworkitem-queueitem sync impacts the Queue Item APIs

- For a particular queue item, when you change the queue from a (1) regular queue to a unified routed queue or (2) from one UR queue to another UR queue (via “Add to Queue” on the underlying record or “Route” on Queue Item), the associated queue for the live work item is also updated to the same destination queue.
- For the queue items having associated live work items, when you update the worker ID (via the “Route” option on Queue Item), the live work item is also assigned to the same agent.
- When a queue item with an associated live work item, you cannot use remove it from the queue by applying the Pick operation on the queue item. 
- You cannot reactivate a deactivated queue item that's part of a unified routed queue.
- When you delete a queue item either by removing the queue item or by deleting or canceling the underlying record, the associated live work item is also closed. 

