---
title: "List (marketing list) entity (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Learn about list management and the list (marketing list) entity that help you create lists of potential customers or existing customers for marketing purposes."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - lists (marketing lists), managing
  - marketing lists, see 'list (marketing list) entity'
  - adding members to lists
  - list (marketing list) entity, managing lists
  - list (marketing list) entity, adding members to lists
  - lists (marketing lists), introduction
  - "list (marketing list) entity, types of lists: dynamic and static"
ms.assetid: 720709e2-32e0-44bc-87dc-445cb5d16e91
caps.latest.revision: 23
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# List (marketing list) entity

In Dynamics 365 Customer Engagement (on-premises), *list management* and the *list* (marketing list) entity help you create lists of potential customers or existing customers for marketing purposes. Typically, a list is a potential target for a campaign. However, you can also use it for other marketing reasons. You can generate subsets of a list by using different parameters for a campaign or to run an activity in bulk mode.  
  
 There are two types of lists: static and dynamic. To specify whether the list is static or dynamic, use the `List.Type` attribute. All list members must be of the same entity type, such as accounts, contacts, or leads. To add the members to a static list, use the <xref:Microsoft.Crm.Sdk.Messages.AddListMembersListRequest> message. The members for a dynamic list are selected dynamically based on the FetchXML query criteria during distribution of a campaign activity or a quick campaign. To specify the FetchXML criteria, use the `List.Query` attribute. Initially, the member count for the dynamic list is set to **null**. To determine how many records in the system satisfy the FetchXML query criteria, use the aggregate function on the query. You can create a new static list based on the existing dynamic list by using the <xref:Microsoft.Crm.Sdk.Messages.CopyDynamicListToStaticRequest> message. The newly created static list is locked.  
  
### See also  

 [List Entity](entities/list.md)   
 [Use FetchXML to Construct a Query](/powerapps/developer/data-platform/use-fetchxml-construct-query)   
 [Use FetchXML Aggregation](/powerapps/developer/data-platform/use-fetchxml-aggregation)   
 <xref:Microsoft.Crm.Sdk.Messages.CopyDynamicListToStaticRequest>   
 [Marketing Entities (Campaign, List)](marketing-entities-campaign-list.md)   
 [Sample: Distribute a Quick Campaign](sample-distribute-a-quick-campaign.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]