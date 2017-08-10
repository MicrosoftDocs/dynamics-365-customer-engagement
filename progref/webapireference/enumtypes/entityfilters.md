---
title: "EntityFilters EnumType| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: cf7366b1-cb56-4ac9-865d-454fd79bfc22
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# EntityFilters EnumType
[!INCLUDE[./descriptions/entityfilters.md](./descriptions/entityfilters.md)]

## Members
Members define the discrete options for the enumeration type.
|Name|Value|Description|
|---|---|---|
|Entity|1|Use this to retrieve only entity information.| 
|Attributes|2|Use this to retrieve entity information plus attributes for the entity.| 
|Privileges|4|Use this to retrieve entity information plus privileges for the entity.| 
|Relationships|8|Use this to retrieve entity information plus entity relationships for the entity.| 
|All|15|Use this to retrieve all data for an entity.| 

## Used by
The following use the EntityFilters enum type.
|Name|How used|Description|
|---|---|---|
|[RetrieveAllEntities Function](../functions/retrieveallentities.md)|Parameter|[!INCLUDE[../functions/descriptions/retrieveallentities.md](../functions/descriptions/retrieveallentities.md)]|

[!INCLUDE[./remarks/entityfilters.md](./remarks/entityfilters.md)]

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