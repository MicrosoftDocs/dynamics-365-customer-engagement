---
title: "TransformImport Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: e2f1ec4f-3c33-43eb-b996-1b80aee6fe85
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# TransformImport Action
[!INCLUDE[./descriptions/transformimport.md](./descriptions/transformimport.md)]

The TransformImport action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ImportId|Edm.Guid|false|true|The ID of the import (data import) that is associated with the asynchronous job that transforms the imported data. |

## Return Type
The TransformImport action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[asyncoperation EntityType](../entitytypes/asyncoperation.md)|false|Contains the response from the TransformImport Action. |

## Entities
Use the TransformImport action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[import Entitytype](../entitytypes/import.md)|[!INCLUDE[../entitytypes/descriptions/import.md](../entitytypes/descriptions/import.md)]|

[!INCLUDE[./remarks/transformimport.md](./remarks/transformimport.md)]

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