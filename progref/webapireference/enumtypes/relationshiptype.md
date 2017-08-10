---
title: "RelationshipType EnumType| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ba7b559a-8642-4ced-8709-0cf1ae3b72f0
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RelationshipType EnumType
[!INCLUDE[./descriptions/relationshiptype.md](./descriptions/relationshiptype.md)]

## Members
Members define the discrete options for the enumeration type.
|Name|Value|Description|
|---|---|---|
|OneToManyRelationship|0|The entity relationship is a One-to-Many relationship. | 
|ManyToManyRelationship|1|The entity relationship is a Many-to-Many relationship. | 

## Used by
The following use the RelationshipType enum type.
|Name|How used|Description|
|---|---|---|
|[RelationshipMetadataBase EntityType](../metadataentitytypes/relationshipmetadatabase.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/relationshipmetadatabase.md](../metadataentitytypes/descriptions/relationshipmetadatabase.md)]|
|[ComplexManyToManyRelationshipMetadata ComplexType](../complextypes/complexmanytomanyrelationshipmetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexmanytomanyrelationshipmetadata.md](../complextypes/descriptions/complexmanytomanyrelationshipmetadata.md)]|
|[ComplexOneToManyRelationshipMetadata ComplexType](../complextypes/complexonetomanyrelationshipmetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexonetomanyrelationshipmetadata.md](../complextypes/descriptions/complexonetomanyrelationshipmetadata.md)]|

[!INCLUDE[./remarks/relationshiptype.md](./remarks/relationshiptype.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)   
 [Web API EntityType Reference](../entitytypereference.md)   
 [Web API Action Reference](../actionreference.md)   
 [Web API Function Reference](../functionreference.md)   
 [Web API Query Function Reference](../queryfunctionreference.md)   
 [Web API EnumType Reference](../enumtypereference.md)   
 [Web API ComplexType Reference](../complextypereference.md)   
 [Web API Metadata EntityType Reference](../entitytypereference.md)   
 [Web API Solutions Reference](../solutionreference.md)