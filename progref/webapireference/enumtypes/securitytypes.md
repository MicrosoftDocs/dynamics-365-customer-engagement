---
title: "SecurityTypes EnumType| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b2dd5983-c06d-4a28-9335-26c0f7c25596
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SecurityTypes EnumType
[!INCLUDE[./descriptions/securitytypes.md](./descriptions/securitytypes.md)]

## Members
Members define the discrete options for the enumeration type.
|Name|Value|Description|
|---|---|---|
|None|0|No security privileges are checked during create or update operations. | 
|Append|1|The Append and AppendTo privileges are checked for create or update operations. | 
|ParentChild|2|Security for the referencing entity record is derived from the referenced entity record. | 
|Pointer|4|Security for the referencing entity record is derived from a pointer record.  | 
|Inheritance|8|The referencing entity record inherits security from the referenced security record.| 

## Used by
The following use the SecurityTypes enum type.
|Name|How used|Description|
|---|---|---|
|[RelationshipMetadataBase EntityType](../metadataentitytypes/relationshipmetadatabase.md)|Property|[!INCLUDE[../metadataentitytypes/descriptions/relationshipmetadatabase.md](../metadataentitytypes/descriptions/relationshipmetadatabase.md)]|
|[ComplexManyToManyRelationshipMetadata ComplexType](../complextypes/complexmanytomanyrelationshipmetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexmanytomanyrelationshipmetadata.md](../complextypes/descriptions/complexmanytomanyrelationshipmetadata.md)]|
|[ComplexOneToManyRelationshipMetadata ComplexType](../complextypes/complexonetomanyrelationshipmetadata.md)|Property|[!INCLUDE[../complextypes/descriptions/complexonetomanyrelationshipmetadata.md](../complextypes/descriptions/complexonetomanyrelationshipmetadata.md)]|

[!INCLUDE[./remarks/securitytypes.md](./remarks/securitytypes.md)]

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