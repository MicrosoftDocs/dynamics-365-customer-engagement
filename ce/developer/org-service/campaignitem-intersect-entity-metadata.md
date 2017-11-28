---
title: "CampaignItem intersect entity metadata (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "The CampaignItem intersect entity is the intersect table for several many-to-many relationships for the Campaign entity"
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
  - "campaign entity, campaignitem intersect table"
  - "campaignitem intersect entity, effect of early- and late-bound types on"
  - "campaignitem intersect entity, many-to-many (N:N) relationships for the campaign entity"
  - "many-to-many (N:N) relationships, for the campaignitem intersect entity"
  - "intersect entity metadata, campaignitem"
  - "campaignitem intersect entity, table of attribute metadata"
ms.assetid: 23835406-e515-4240-a10b-3d5df12542f5
caps.latest.revision: 18
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# CampaignItem intersect entity metadata

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

The `CampaignItem` intersect entity is the intersect table for the following many-to-many relationships for the `Campaign` entity.  
  
|Relationship schema name|Entity 1|Entity 2|  
|------------------------------|--------------|--------------|  
|campaignproduct_association|campaign|Product|  
|campaigncampaign_association|campaign|Campaign|  
|campaignsalesliterature_association|campaign|SalesLiterature|  
|campaignlist_association|campaign|List|  
  
 If you are not using early bound types, you might need to know the names of the attributes in this entity to effectively build a query. This information is provided in the following table. [!INCLUDE[metadata_browser](../../includes/metadata-browser.md)]  
  
### See also  
 [Retrieve Records for Many-To-Many Relationships using Intersect Entities](retrieve-records-many-to-many-relationships-intersect-entities.md)   
 [CampaignActivityItem intersect entity metadata](campaignactivityitem-intersect-entity-metadata.md)   
 [ListMember intersect entity metadata](listmember-intersect-entity-metadata.md)   
 [Role Privileges intersect entity metadata](role-privileges-intersect-entity-metadata.md)   
 [Sample: Retrieve records from an intersect table](sample-retrieve-records-intersect-table.md)   
 [Campaign entities](../campaign-entities.md)
