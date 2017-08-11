---
title: "RetrieveAllEntitiesResponse ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d6190e8e-72d7-409e-b752-0d5e7361d999
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveAllEntitiesResponse ComplexType
[!INCLUDE[./descriptions/retrieveallentitiesresponse.md](./descriptions/retrieveallentitiesresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|EntityMetadata|Collection([ComplexEntityMetadata ComplexType](../complextypes/ComplexEntityMetadata.md))||true|Contains metadata of the entity.| 
|Timestamp|Edm.String|true|false|| 

## Used by
The following use the RetrieveAllEntitiesResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrieveAllEntities Function](../functions/retrieveallentities.md)|ReturnType|[!INCLUDE[../functions/descriptions/retrieveallentities.md](../functions/descriptions/retrieveallentities.md)]|

[!INCLUDE[./remarks/retrieveallentitiesresponse.md](./remarks/retrieveallentitiesresponse.md)]

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