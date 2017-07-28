---
title: "RetrieveMissingDependencies Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d161c5d0-3d2d-429d-9d54-cee0fd64d9ca
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveMissingDependencies Function
[!INCLUDE[./descriptions/retrievemissingdependencies.md](./descriptions/retrievemissingdependencies.md)]

The RetrieveMissingDependencies function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|SolutionUniqueName|Edm.String|false|false|The unique name of the solution. |

## Return Type
The RetrieveMissingDependencies function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))|false|Contains the results from the RetrieveMissingDependencies function. |

## Entities
Use the RetrieveMissingDependencies function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[dependency Entitytype](../entitytypes/dependency.md)|[!INCLUDE[../entitytypes/descriptions/dependency.md](../entitytypes/descriptions/dependency.md)]|

[!INCLUDE[./remarks/retrievemissingdependencies.md](./remarks/retrievemissingdependencies.md)]

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