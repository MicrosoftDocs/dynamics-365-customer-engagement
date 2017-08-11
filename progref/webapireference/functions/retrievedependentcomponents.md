---
title: "RetrieveDependentComponents Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 144e5060-c71e-4cf9-a09f-9473048c8354
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveDependentComponents Function
[!INCLUDE[./descriptions/retrievedependentcomponents.md](./descriptions/retrievedependentcomponents.md)]

The RetrieveDependentComponents function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ObjectId|Edm.Guid|false|true|The ID of the solution component|
|ComponentType|Edm.Int32|false|true|The solution component type. |

## Return Type
The RetrieveDependentComponents function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([dependency EntityType](../entitytypes/dependency.md))|false|Contains the results from the RetrieveDependentComponents function.|

## Entities
Use the RetrieveDependentComponents function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[dependency Entitytype](../entitytypes/dependency.md)|[!INCLUDE[../entitytypes/descriptions/dependency.md](../entitytypes/descriptions/dependency.md)]|

[!INCLUDE[./remarks/retrievedependentcomponents.md](./remarks/retrievedependentcomponents.md)]

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