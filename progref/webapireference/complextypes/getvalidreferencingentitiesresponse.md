---
title: "GetValidReferencingEntitiesResponse ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c8893053-9c4b-439a-bea5-e99f24d6be7a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# GetValidReferencingEntitiesResponse ComplexType
[!INCLUDE[./descriptions/getvalidreferencingentitiesresponse.md](./descriptions/getvalidreferencingentitiesresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|EntityNames|Collection(Edm.String)||false|The array of valid entity names that can be the related entity in a many-to-many relationship.| 

## Used by
The following use the GetValidReferencingEntitiesResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[GetValidReferencingEntities Function](../functions/getvalidreferencingentities.md)|ReturnType|[!INCLUDE[../functions/descriptions/getvalidreferencingentities.md](../functions/descriptions/getvalidreferencingentities.md)]|

[!INCLUDE[./remarks/getvalidreferencingentitiesresponse.md](./remarks/getvalidreferencingentitiesresponse.md)]

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