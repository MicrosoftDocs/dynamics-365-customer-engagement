---
title: "Create and retrieve entity relationships (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The topic shows how to create and retrieve entity relationships."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 (on-premises)"
  - "Dynamics CRM 2016"
  - "Dynamics CRM Online"
ms.assetid: d10c5399-7e79-413c-9b8c-9e4f402fc167
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Create and retrieve entity relationships

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

This topic shows how to create and retrieve entity relationships.  
  
<a name="BKMK_Create1NEntityRelationship"></a>   
## Create a 1:N entity relationship  
 The following sample uses the [EligibleCreateOneToManyRelationship](#eligiblecreateonetomanyrelationship) method to verify that the `Account` and `Campaign` entities can participate in a 1:N entity relationship and then creates the entity relationship by using <xref:Microsoft.Xrm.Sdk.Messages.CreateOneToManyRequest>.  
  
 [!code-csharp[Relationships#WorkWithRelationships1](../../snippets/csharp/CRMV8/relationships/cs/workwithrelationships1.cs#workwithrelationships1)]  
  
<a name="BKMK_EligibleCreateOneToManyRelationship"></a>   

### EligibleCreateOneToManyRelationship  

 The following sample creates a `EligibleCreateOneToManyRelationship` method that uses <xref:Microsoft.Xrm.Sdk.Messages.CanBeReferencedRequest> and <xref:Microsoft.Xrm.Sdk.Messages.CanBeReferencingRequest> to verify whether two entities can participate in a 1:N entity relationship.  
  
 [!code-csharp[Relationships#WorkWithRelationships4](../../snippets/csharp/CRMV8/relationships/cs/workwithrelationships4.cs#workwithrelationships4)]  
  
<a name="BKMK_CreateNNEntityRelationship"></a>   

## Create an N:N entity relationship  

 The following sample uses a [EligibleCreateManyToManyRelationship](create-retrieve-entity-relationships.md#BKMK_EligibleCreateManyToManyRelationship) method to verify that the `Account` and `Campaign` entities can participate in a N:N entity relationship and then creates the entity relationship by using <xref:Microsoft.Xrm.Sdk.Messages.CreateManyToManyRequest>.  
  
 [!code-csharp[Relationships#WorkWithRelationships2](../../snippets/csharp/CRMV8/relationships/cs/workwithrelationships2.cs#workwithrelationships2)]  
  
<a name="BKMK_EligibleCreateManyToManyRelationship"></a>   

### EligibleCreateManyToManyRelationship  

 The following sample creates a `EligibleCreateManyToManyRelationship` method that uses <xref:Microsoft.Xrm.Sdk.Messages.CanManyToManyRequest> to verify whether an entity can participate in a N:N entity relationship.  
  
 [!code-csharp[Relationships#WorkWithRelationships3](../../snippets/csharp/CRMV8/relationships/cs/workwithrelationships3.cs#workwithrelationships3)]  
  
<a name="BKMK_RetrieveEntityRelationships"></a>   
## Retrieve entity relationships  
 The following sample retrieves the two entity relationships previously created using <xref:Microsoft.Xrm.Sdk.Messages.RetrieveRelationshipRequest>. The first example uses the `MetadataId` and the second uses the `Name`.  
  
 [!code-csharp[relationships#WorkWithRelationships.RetrieveRelationship](../../snippets/csharp/CRMV8/relationships/cs/workwithrelationships.retrieverelationship.cs#workwithrelationships.retrieverelationship)]  
  
### See Also  
 [Customize entity relationship metadata](../customize-entity-relationship-metadata.md)   
 [Entity Relationship Metadata Messages](../entity-relationship-metadata-messages.md)   
 [Sample: Create Entity Relationships](sample-create-retrieve-entity-relationships.md)