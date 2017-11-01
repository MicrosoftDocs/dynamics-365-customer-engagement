---
title: "CampaignActivityItem intersect entity metadata (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "The CampaignActivityItem intersect entity is the intersect table for the following many-to-many relationships for the CampaignActivity entity"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d2d7d3ee-c6e1-4c86-844f-68f9b5c843b8
caps.latest.revision: 19
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# CampaignActivityItem intersect entity metadata

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

The `CampaignActivityItem` intersect entity is the intersect table for the following many-to-many relationships for the `CampaignActivity` entity.  
  
|Relationship schema name|Entity 1|Entity 2|  
|------------------------------|--------------|--------------|  
|campaignactivitysalesliterature_association|campaignactivity|salesliterature|  
|campaignactivitylist_association|campaignactivity|list|  
  
 If you are not using early bound types, you might need to know the names of the attributes in this entity to effectively build a query. This information is provided in the following table. [!INCLUDE[metadata_browser](../../includes/metadata-browser.md)]  
  
### See also  
 [Retrieve Records for Many-To-Many Relationships using Intersect Entities](retrieve-records-many-to-many-relationships-intersect-entities.md)   
 [CampaignItem intersect entity metadata](campaignitem-intersect-entity-metadata.md)   
 [ListMember intersect entity metadata](listmember-intersect-entity-metadata.md)   
 [Role Privileges intersect entity metadata](role-privileges-intersect-entity-metadata.md)   
 [Sample: Retrieve records from an intersect table](sample-retrieve-records-intersect-table.md)   
 [Campaign entities](../campaign-entities.md)
