---
title: "Entity relationship metadata messages (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The article describes the messages that you can use to create, retrieve, update, and delete entity relationships"
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
  - entity relationship messages, list of messages with descriptions
  - entity relationship metadata messages, list of messages with descriptions
  - entity relationship eligibility, messages for
  - relationships, list of messages for entity relationships
ms.assetid: 14b504b9-addb-40cd-aeef-a45a6a24bbcb
caps.latest.revision: 16
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Entity relationship metadata messages

Entity relationships define how entities are related to each other. This includes information about how relationships are represented in the application. Also, when actions are performed on a record, the relationship indicates what actions to perform on related records.  
  
## Entity relationship messages  
 The following table lists the messages that you can use to create, retrieve, update, and delete entity relationships.  
  
|Message|Description|  
|-------------|-----------------|  
|<xref:Microsoft.Xrm.Sdk.Messages.CreateManyToManyRequest>|Creates a many-to-many relationship between two entities.|  
|<xref:Microsoft.Xrm.Sdk.Messages.CreateOneToManyRequest>|Creates a one-to-many relationship between two entities.|  
|<xref:Microsoft.Xrm.Sdk.Messages.DeleteRelationshipRequest>|Deletes an entity relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.RetrieveRelationshipRequest>|Retrieves an entity relationship.|  
|<xref:Microsoft.Xrm.Sdk.Messages.UpdateRelationshipRequest>|Updates an entity relationship.|  
  
### See also  
 [Customize Entity Relationship Metadata](customize-entity-relationship-metadata.md)   
 [Entity Relationship Eligibility](entity-relationship-eligibility.md)   
 [Entity Relationship Behavior](entity-relationship-behavior.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]