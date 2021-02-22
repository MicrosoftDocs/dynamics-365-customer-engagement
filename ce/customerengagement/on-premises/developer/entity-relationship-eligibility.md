---
title: "Entity relationship eligibility (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "The article lists the messages that you can use to determine whether entities can participate in entity relationships"
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
  - determining whether entities can participate in entity relationships, messages for
  - entity relationship eligibility, determining whether entities can participate in entity relationships
  - entities
  - confirming that entities can participate in entity relationships, messages for
ms.assetid: 960606ca-ff63-4b82-9fd6-2d2243a78043
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Entity relationship eligibility

Before you create an entity relationship you should confirm whether the entity is eligible to participate in the relationship. The following table lists the messages that you can use to determine whether entities can participate in entity relationships.  
  
|Message|Web API Operation|SDK Assembly|  
|-------------|-----------------|----------------|  
|CanBeReferenced</br>Checks whether the specified entity can be the primary entity (one) in a one-to-many relationship.|<xref href="Microsoft.Dynamics.CRM.CanBeReferenced?text=CanBeReferenced Action" />|<xref:Microsoft.Xrm.Sdk.Messages.CanBeReferencedRequest>|  
|CanBeReferencing</br>Checks whether the specified entity can be the referencing entity (many) in a one-to-many relationship.|<xref href="Microsoft.Dynamics.CRM.CanBeReferencing?text=CanBeReferencing Action" />|<xref:Microsoft.Xrm.Sdk.Messages.CanBeReferencingRequest>|  
|CanManyToMany</br>Checks whether the entity can participate in a many-to-many relationship.|<xref href="Microsoft.Dynamics.CRM.CanManyToMany?text=CanManyToMany Action" />|<xref:Microsoft.Xrm.Sdk.Messages.CanManyToManyRequest>|  
|GetValidManyToMany</br>Returns the set of entities that can participate in a many-to-many relationship.|<xref href="Microsoft.Dynamics.CRM.GetValidManyToMany?text=GetValidManyToMany Function" />|<xref:Microsoft.Xrm.Sdk.Messages.GetValidManyToManyRequest>|  
|GetValidReferencedEntities</br>Returns the set of entities that are valid as the primary entity (one) from the specified entity in a one-to-many relationship.|<xref href="Microsoft.Dynamics.CRM.GetValidReferencedEntities?text=GetValidReferencedEntities Function" />|<xref:Microsoft.Xrm.Sdk.Messages.GetValidReferencedEntitiesRequest>|  
|GetValidReferencingEntities</br>Returns the set of entities that are valid as the related entity (many) to the specified entity in a one-to-many relationship.|<xref href="Microsoft.Dynamics.CRM.GetValidReferencingEntities?text=GetValidReferencingEntities Function" />|<xref:Microsoft.Xrm.Sdk.Messages.GetValidReferencingEntitiesRequest>|  
  
### See also  
 [Customize Entity Relationship Metadata](customize-entity-relationship-metadata.md)   
 [Extend the Metadata Model for Dynamics 365 Customer Engagement (on-premises)](org-service/use-organization-service-metadata.md)   
 [Entity Relationship Metadata](customize-entity-relationship-metadata.md)   
 [Entity Relationship Messages](entity-relationship-metadata-messages.md)   
 [Entity Relationship Behavior](entity-relationship-behavior.md)   
 [Create one-to-many or many-to-one entity relationships overview](/powerapps/maker/common-data-service/create-edit-1n-relationships)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]