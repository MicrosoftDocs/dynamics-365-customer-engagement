---
title: "Impact of unified routing on queue items and the corresponding APIs| Microsoft Docs"
description: "How unified routing affects queue items and the corresponding APIs"
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
# How unified routing affects queue items and the corresponding APIs
<!--note from editor: Writing Style Guide says about "impact": "Use only as a noun. As a verb, use affect or another synonym."-->
When you change the status of a queue item that has been routed using unified routing, the queue item is affected in the following ways:

- When you change a queue item from a basic queue to an advanced queue&mdash;or from one advanced queue to another&mdash;by selecting  **Add to Queue** on the record (via the [AddToQueue Action](/dynamics365/customer-engagement/web-api/addtoqueue?view=dynamics-ce-odata-9)) or by selecting **Route To** on the queue item (via the [**RouteTo Action**](https://docs.microsoft.com/dynamics365/customer-engagement/web-api/routeto?view=dynamics-ce-odata-9)), the associated queue for the live work item ([msdyn_ocliveworkitem](/dynamics365/customer-service/developer/reference/entities/msdyn_ocliveworkitem)) also gets updated to the same destination queue. This action then updates the unified routing services that maintain agent presence and capacity with the corresponding changes.<!--note from editor: The rewrite of the first sentence is suggested. It's not optimal, but I think having a bulleted list in the middle of a sentence is a bit confusing. Maybe rearranging this would be better, something like: "You can change a queue item from a basic queue to an advanced queue, or from one advanced queue to another, by selecting  **Add to Queue** on the record (via the [AddToQueue Action](/dynamics365/customer-engagement/web-api/addtoqueue?view=dynamics-ce-odata-9)) or by selecting **Route To** on the queue item (via the [**RouteTo Action**](https://docs.microsoft.com/dynamics365/customer-engagement/web-api/routeto?view=dynamics-ce-odata-9)). When you do so, the associated queue for the live work item..." etc.-->

- When you update the **Worked By** field of queue items by selecting **Route To** on the queue items list (via the **RouteTo Action**), the live work item (msdyn_ocliveworkitem) also gets assigned to the same agent.

- When you update a queue item using unified routing, you can't remove it from the queue by selecting **Pick** ([**PickFromQueue Action**](/dynamics365/customer-engagement/web-api/pickfromqueue?view=dynamics-ce-odata-9)) or **RouteTo Action** on the queue item.

- When you resolve a routed record, the corresponding queue item that gets deactivated can't be activated again.

- When you delete a queue item by selecting **Remove** (via the [**RemoveFromQueue Action**](/dynamics365/customer-engagement/web-api/removefromqueue?view=dynamics-ce-odata-9)) or by deleting or canceling the underlying record, the associated live work item (msdyn_ocliveworkitem) is also closed. This action then updates the unified routing services that maintain agent presence and capacity with the corresponding changes.

### See also

[Overview of unified routing](overview-unified-routing.md)   
[Set up record routing](set-up-record-routing.md)   
[Set up unified routing](set-up-routing-process.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]