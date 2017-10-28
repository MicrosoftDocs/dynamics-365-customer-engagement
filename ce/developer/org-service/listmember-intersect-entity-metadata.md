---
title: "ListMember intersect entity metadata (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This topic lists the various many-to-many relationships for the List entity for which the ListMember intersect entity is the intersect table"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "marketing list metadata"
  - "list entity, listmember intersect table"
  - "listmember intersect entity, many-to-many (N:N) relationships for the list entity"
  - "listmember intersect entity, table of attribute metadata"
  - "many-to-many (N:N) relationships, for the listmember intersect entity"
  - "listmember intersect entity, effect of early- and late-bound types on"
  - "intersect entity metadata, listmember"
ms.assetid: b8dcd1b3-6750-429e-ac7a-c0213c77e136
caps.latest.revision: 15
author: "KumarVivek"
ms.author: "kvivek"
manager: "jdaly"
---
# ListMember intersect entity metadata
The `ListMember` intersect entity is the intersect table for the following many-to-many relationships for the `List` entity.  
  
|Relationship schema name|Entity 1|Entity 2|  
|------------------------------|--------------|--------------|  
|listaccount_association|list|account|  
|listcontact_association|list|contact|  
|listlead_association|list|lead|  
  
 If you are not using early bound types, you might need to know the names of the attributes in this entity to effectively build a query. This information is provided in the following table. [!INCLUDE[metadata_browser](../../includes/metadata-browser.md)]  
  
### See also  
 [Retrieve Records for Many-To-Many Relationships using Intersect Entities](retrieve-records-many-to-many-relationships-intersect-entities.md)   
 [CampaignActivityItem intersect entity metadata](campaignactivityitem-intersect-entity-metadata.md)   
 [CampaignItem intersect entity metadata](campaignitem-intersect-entity-metadata.md)   
 [Role Privileges intersect entity metadata](role-privileges-intersect-entity-metadata.md)   
 [Sample: Retrieve records from an intersect table](sample-retrieve-records-intersect-table.md)   
 [Campaign Entities](campaign-entities.md)
