---
title: "GetValidReferencedEntitiesResponse ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 005d08a7-0dc5-44ce-a117-236614452c57
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# GetValidReferencedEntitiesResponse ComplexType
[!INCLUDE[./descriptions/getvalidreferencedentitiesresponse.md](./descriptions/getvalidreferencedentitiesresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|EntityNames|Collection(Edm.String)||false|The array of valid entity names that can be the related entity in a many-to-many relationship.| 

## Used by
The following use the GetValidReferencedEntitiesResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[GetValidReferencedEntities Function](../functions/getvalidreferencedentities.md)|ReturnType|[!INCLUDE[../functions/descriptions/getvalidreferencedentities.md](../functions/descriptions/getvalidreferencedentities.md)]|

[!INCLUDE[./remarks/getvalidreferencedentitiesresponse.md](./remarks/getvalidreferencedentitiesresponse.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)<br />
 [Web API EntityType Reference](../entitytypereference.md)<br />
 [Web API Action Reference](../actionreference.md)<br />
 [Web API Function Reference](../functionreference.md)<br />
 [Web API Query Function Reference](../queryfunctionreference.md)<br />
 [Web API EnumType Reference](../enumtypereference.md)<br />
 [Web API ComplexType Reference](../complextypereference.md)<br />
 [Web API Metadata EntityType Reference](../entitytypereference.md)<br />
 [Web API Solutions Reference](../solutionreference.md)<br />