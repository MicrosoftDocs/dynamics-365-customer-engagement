---
title: "RemoveSolutionComponent Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: fc7c8ee7-75ee-46a8-bc3a-fed182443f97
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RemoveSolutionComponent Action
[!INCLUDE[./descriptions/removesolutioncomponent.md](./descriptions/removesolutioncomponent.md)]

The RemoveSolutionComponent action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|SolutionComponent|[solutioncomponent EntityType](../entitytypes/solutioncomponent.md)|false|true|Solution component to add. |
|ComponentType|Edm.Int32|false|true|The type of solution component. |
|SolutionUniqueName|Edm.String|false|false|Unique name of the solution. |

## Return Type
The RemoveSolutionComponent action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[RemoveSolutionComponentResponse ComplexType](../complextypes/RemoveSolutionComponentResponse.md)|false|Contains the response from the RemoveSolutionComponent Action. |

## Entities
Use the RemoveSolutionComponent action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[solutioncomponent Entitytype](../entitytypes/solutioncomponent.md)|[!INCLUDE[../entitytypes/descriptions/solutioncomponent.md](../entitytypes/descriptions/solutioncomponent.md)]|

[!INCLUDE[./remarks/removesolutioncomponent.md](./remarks/removesolutioncomponent.md)]

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