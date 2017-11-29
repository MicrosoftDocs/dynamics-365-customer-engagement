---
title: "Role Privileges intersect entity metadata (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "The RolePrivileges intersect entity is the intersect table for the following many-to-many relationships for the Role entity"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: a85583a8-9f2b-401f-926d-7872e3885852
caps.latest.revision: 14
author: "KumarVivek"
ms.author: "kvivek"
manager: "amyla"
---
# Role Privileges intersect entity metadata

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

The `RolePrivileges` intersect entity is the intersect table for the following many-to-many relationships for the `Role` entity.  
  
|Relationship schema name|Entity 1|Entity 2|  
|------------------------------|--------------|--------------|  
|roleprivileges_association|Privilege|Role|  
  
 If you are not using early bound types, you might need to know the names of the attributes in this entity to effectively build a query. This information is provided in the following table. [!INCLUDE[metadata_browser](../../includes/metadata-browser.md)]  
  
### See also  
 [Retrieve Records for Many-To-Many Relationships using Intersect Entities](retrieve-records-many-to-many-relationships-intersect-entities.md)   
 [CampaignActivityItem intersect entity metadata](campaignactivityitem-intersect-entity-metadata.md)   
 [CampaignItem intersect entity metadata](campaignitem-intersect-entity-metadata.md)   
 [ListMember intersect entity metadata](listmember-intersect-entity-metadata.md)   
 [Sample: Retrieve records from an intersect table](sample-retrieve-records-intersect-table.md)   
 [Privilege and role entities](../privilege-role-entities.md)
