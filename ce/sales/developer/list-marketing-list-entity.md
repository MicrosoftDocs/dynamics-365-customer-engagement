---
title: List (marketing list) table (Dynamics 365 Sales)
description: Learn about list management and the list (marketing list) table that help you create lists of potential customers or existing customers for marketing purposes.
ms.custom: 
ms.date: 03/01/2023
ms.reviewer: lavanyakr
ms.topic: article
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
manager: shujoshi
search.audienceType: 
  - developer

---
# List (marketing list) table

In Dynamics 365 Customer Engagement (on-premises), *list management* and the *list* (marketing list) table help you create lists of potential customers or existing customers for marketing purposes. Typically, a list is a potential target for a campaign. However, you can also use it for other marketing reasons. You can generate subsets of a list by using different parameters for a campaign or to run an activity in bulk mode.  
  
 There are two types of lists: static and dynamic. To specify whether the list is static or dynamic, use the `List.Type` attribute. All list members must be of the same table type, such as accounts, contacts, or leads. To add the members to a static list, use the <xref:Microsoft.Crm.Sdk.Messages.AddListMembersListRequest> message. The members for a dynamic list are selected dynamically based on the FetchXML query criteria during distribution of a campaign activity or a quick campaign. To specify the FetchXML criteria, use the `List.Query` attribute. Initially, the member count for the dynamic list is set to **null**. To determine how many records in the system satisfy the FetchXML query criteria, use the aggregate function on the query. You can create a new static list based on the existing dynamic list by using the <xref:Microsoft.Crm.Sdk.Messages.CopyDynamicListToStaticRequest> message. The newly created static list is locked.  
  
### See also  

 [List Table](entities/list.md)   
 [Use FetchXML to Construct a Query](/powerapps/developer/data-platform/use-fetchxml-construct-query)   
 [Use FetchXML Aggregation](/powerapps/developer/data-platform/use-fetchxml-aggregation)   
 <xref:Microsoft.Crm.Sdk.Messages.CopyDynamicListToStaticRequest>   
 [Marketing Tables (Campaign, List)](marketing-entities-campaign-list.md)   
 [Sample: Distribute a Quick Campaign](sample-distribute-a-quick-campaign.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]