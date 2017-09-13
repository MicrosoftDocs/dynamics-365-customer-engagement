---
title: "GetValidReferencedEntities Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e36995d8-155e-4298-b206-0386260f6f75
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# GetValidReferencedEntities Function
[!INCLUDE[./descriptions/getvalidreferencedentities.md](./descriptions/getvalidreferencedentities.md)]

The GetValidReferencedEntities function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ReferencingEntityName|Edm.String|true|false|The logical name of the entity to get valid referenced entities. |

## Return Type
The GetValidReferencedEntities function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[GetValidReferencedEntitiesResponse ComplexType](../complextypes/GetValidReferencedEntitiesResponse.md)|false|Contains the results from the GetValidReferencedEntities function. |



[!INCLUDE[./remarks/getvalidreferencedentities.md](./remarks/getvalidreferencedentities.md)]

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