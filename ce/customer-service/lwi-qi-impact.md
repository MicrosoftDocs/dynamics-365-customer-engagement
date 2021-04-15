---
title: "Impact of Unified Routing on Queue Item APIs| Microsoft Docs"
description: "How unified routing impacts the Queue Item APIs"
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
# How unified routing impacts the Queue Item APIs

When you change the status of a queue item that has been routed using unified routing, the queue item is impacted in the following ways:

- When you change the queue of a particular queue item from (1) a basic queue to an advanced queue or (2) from one advanced queue to another by clicking  **Add to Queue** on the record (via the [AddToQueue Action](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/addtoqueue?view=dynamics-ce-odata-9)) or by clicking **Route To** on the queue item (via the [**RouteTo Action**](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/routeto?view=dynamics-ce-odata-9)), the associated queue for the live work item ([msdyn_ocliveworkitem](https://docs.microsoft.com/en-us/dynamics365/customer-service/developer/reference/entities/msdyn_ocliveworkitem)) is also updated to the same destination queue. This will, in turn, update the unified routing services that maintain agent presence and capacity with the corresponding changes.
- When you update the **Worked By** field of queue items by clicking **Route To** on the queue item details page (via the [**RouteTo Action**](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/routeto?view=dynamics-ce-odata-9)), the live work item ([msdyn_ocliveworkitem](https://docs.microsoft.com/en-us/dynamics365/customer-service/developer/reference/entities/msdyn_ocliveworkitem)) is also assigned to the same agent.
- When a queue item has been updated using unified routing, you cannot use remove it from the queue by clicking **Pick** ([**PickFromQueue Action**](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/pickfromqueue?view=dynamics-ce-odata-9)) or [**RouteTo Action**](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/routeto?view=dynamics-ce-odata-9) on the queue item.
- When you deactivate a queue item that's part of an advanced queue, you cannot activate it again.
- When you delete a queue item by clicking **Remove** (via the [**RemoveFromQueue Action**](https://docs.microsoft.com/en-us/dynamics365/customer-engagement/web-api/removefromqueue?view=dynamics-ce-odata-9)) or by deleting or canceling the underlying record, the associated live work item ([msdyn_ocliveworkitem](https://docs.microsoft.com/en-us/dynamics365/customer-service/developer/reference/entities/msdyn_ocliveworkitem)) is also closed. This will, in turn, update the unified routing services that maintain agent presence and capacity with the corresponding changes.