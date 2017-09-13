---
title: "CloneAsPatch Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 98223e6e-4a39-4cfc-bb32-2a153e4f9ae8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CloneAsPatch Action
[!INCLUDE[./descriptions/cloneaspatch.md](./descriptions/cloneaspatch.md)]

The CloneAsPatch action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ParentSolutionUniqueName|Edm.String|false|false|The unique name of the parent solution.|
|DisplayName|Edm.String|false|false|The name of the patch.|
|VersionNumber|Edm.String|false|false|The version number of the patch. The version must be greater than the parent solution but have the same major.minor number. |

## Return Type
The CloneAsPatch action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[CloneAsPatchResponse ComplexType](../complextypes/CloneAsPatchResponse.md)|false|Contains the response from CloneAsPatch action. |

## Entities
Use the CloneAsPatch action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[solution Entitytype](../entitytypes/solution.md)|[!INCLUDE[../entitytypes/descriptions/solution.md](../entitytypes/descriptions/solution.md)]|

[!INCLUDE[./remarks/cloneaspatch.md](./remarks/cloneaspatch.md)]

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