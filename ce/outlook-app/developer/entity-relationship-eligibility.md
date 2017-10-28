---
title: "Entity relationship eligibility (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The article lists the messages that you can use to determine whether entities can participate in entity relationships"
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
  - "determining whether entities can participate in entity relationships, messages for"
  - "entity relationship eligibility, determining whether entities can participate in entity relationships"
  - "entities"
  - "confirming that entities can participate in entity relationships, messages for"
ms.assetid: 960606ca-ff63-4b82-9fd6-2d2243a78043
caps.latest.revision: 18
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Entity relationship eligibility
Before you create an entity relationship you should confirm whether the entity is eligible to participate in the relationship. The following table lists the messages that you can use to determine whether entities can participate in entity relationships.  
  
|Message|Description|  
|-------------|-----------------|  
|<xref:Microsoft.Xrm.Sdk.Messages.CanBeReferencedRequest>|Checks whether the specified entity can be the primary entity (one) in a one-to-many relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.CanBeReferencingRequest>|Checks whether the specified entity can be the referencing entity (many) in a one-to-many relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.CanManyToManyRequest>|Checks whether the entity can participate in a many-to-many relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.GetValidManyToManyRequest>|Returns the set of entities that can participate in a many-to-many relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.GetValidReferencedEntitiesRequest>|Returns the set of entities that are valid as the primary entity (one) from the specified entity in a one-to-many relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.GetValidReferencingEntitiesRequest>|Returns the set of entities that are valid as the related entity (many) to the specified entity in a one-to-many relationship.|  
  
### See also  
 [Customize Entity Relationship Metadata](customize-entity-relationship-metadata.md)   
 [Extend the Metadata Model for Dynamics 365](org-service/use-organization-service-metadata.md)   
 [Entity Relationship Metadata](customize-entity-relationship-metadata.md)   
 [Entity Relationship Messages](entity-relationship-metadata-messages.md)   
 [Entity Relationship Behavior](entity-relationship-behavior.md)   
 [Create a 1:N Entity Relationship](org-service/create-retrieve-entity-relationships.md#BKMK_Create1NEntityRelationship)   
 [Create an N:N Entity Relationship](org-service/create-retrieve-entity-relationships.md#BKMK_CreateNNEntityRelationship)
