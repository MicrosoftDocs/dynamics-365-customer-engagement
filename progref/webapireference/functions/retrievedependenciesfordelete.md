---
title: "RetrieveDependenciesForDelete Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d78ff8c2-a922-49e6-b412-9608db732135
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveDependenciesForDelete Function
[!INCLUDE[./descriptions/retrievedependenciesfordelete.md](./descriptions/retrievedependenciesfordelete.md)]

The RetrieveDependenciesForDelete function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ObjectId|Edm.Guid|false|true|ID of the solution component to delete.|
|ComponentType|Edm.Int32|false|true|The component type that is to be deleted. |

## Return Type
The RetrieveDependenciesForDelete function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([dependency EntityType](../entitytypes/dependency.md))|false|Contains the results from the RetrieveDependenciesForDelete function.|

## Entities
Use the RetrieveDependenciesForDelete function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[dependency Entitytype](../entitytypes/dependency.md)|[!INCLUDE[../entitytypes/descriptions/dependency.md](../entitytypes/descriptions/dependency.md)]|

[!INCLUDE[./remarks/retrievedependenciesfordelete.md](./remarks/retrievedependenciesfordelete.md)]

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