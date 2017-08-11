---
title: "GetValidReferencingEntities Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 04a66b2a-740a-4bfb-b930-5ffef5f9c7ba
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# GetValidReferencingEntities Function
[!INCLUDE[./descriptions/getvalidreferencingentities.md](./descriptions/getvalidreferencingentities.md)]

The GetValidReferencingEntities function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ReferencedEntityName|Edm.String|true|false|The name of the primary entity in the relationship |

## Return Type
The GetValidReferencingEntities function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[GetValidReferencingEntitiesResponse ComplexType](../complextypes/GetValidReferencingEntitiesResponse.md)|false|Contains the results from the GetValidReferencingEntities function.|



[!INCLUDE[./remarks/getvalidreferencingentities.md](./remarks/getvalidreferencingentities.md)]

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