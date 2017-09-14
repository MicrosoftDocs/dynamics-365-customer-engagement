---
title: "RetrieveRequiredComponents Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: c1326b88-cd6a-44c9-80c1-2795aa20886a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveRequiredComponents Function
[!INCLUDE[./descriptions/retrieverequiredcomponents.md](./descriptions/retrieverequiredcomponents.md)]

The RetrieveRequiredComponents function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ObjectId|Edm.Guid|false|true|The ID of the solution component that you want to check.  |
|ComponentType|Edm.Int32|false|true|The solution component. |

## Return Type
The RetrieveRequiredComponents function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))|false|Contains the results from the RetrieveRequiredComponents function. |

## Entities
Use the RetrieveRequiredComponents function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[dependency Entitytype](../entitytypes/dependency.md)|[!INCLUDE[../entitytypes/descriptions/dependency.md](../entitytypes/descriptions/dependency.md)]|

[!INCLUDE[./remarks/retrieverequiredcomponents.md](./remarks/retrieverequiredcomponents.md)]

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