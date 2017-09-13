---
title: "RetrieveDependenciesForUninstall Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8e3cb5a3-bf69-425a-be73-d309a238328c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveDependenciesForUninstall Function
[!INCLUDE[./descriptions/retrievedependenciesforuninstall.md](./descriptions/retrievedependenciesforuninstall.md)]

The RetrieveDependenciesForUninstall function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|SolutionUniqueName|Edm.String|false|false|The unique name of the managed solution. |

## Return Type
The RetrieveDependenciesForUninstall function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([dependency EntityType](../entitytypes/dependency.md))|false|Contains the results from the RetrieveDependenciesForUninstall function. |

## Entities
Use the RetrieveDependenciesForUninstall function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[dependency Entitytype](../entitytypes/dependency.md)|[!INCLUDE[../entitytypes/descriptions/dependency.md](../entitytypes/descriptions/dependency.md)]|

[!INCLUDE[./remarks/retrievedependenciesforuninstall.md](./remarks/retrievedependenciesforuninstall.md)]

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