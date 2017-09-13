---
title: "RetrieveAllEntities Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ea614554-5b1c-4807-9323-a5c15535dfb7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveAllEntities Function
[!INCLUDE[./descriptions/retrieveallentities.md](./descriptions/retrieveallentities.md)]

The RetrieveAllEntities function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|EntityFilters|[EntityFilters EnumType](../enumtypes/EntityFilters.md)|false|true|Filter to control how much data for each entity is retrieved. |
|RetrieveAsIfPublished|Edm.Boolean|false|true|Whether to retrieve the metadata that has not been published. |

## Return Type
The RetrieveAllEntities function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[RetrieveAllEntitiesResponse ComplexType](../complextypes/RetrieveAllEntitiesResponse.md)|false|Contains the response from the RetrieveAllEntities function.|



[!INCLUDE[./remarks/retrieveallentities.md](./remarks/retrieveallentities.md)]

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