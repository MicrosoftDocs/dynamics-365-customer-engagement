---
title: "CloneAsSolution Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 96f91a65-49e3-4943-8127-51b663e205a2
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CloneAsSolution Action
[!INCLUDE[./descriptions/cloneassolution.md](./descriptions/cloneassolution.md)]

The CloneAsSolution action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ParentSolutionUniqueName|Edm.String|false|false|The name of the parent solution. This name must be the same as the parent name in the original solution that was cloned.|
|DisplayName|Edm.String|false|false|The name of the cloned solution.|
|VersionNumber|Edm.String|false|false|The version number of the cloned solution. The cloned solution major.minor version number must be a higher than the original solution that was cloned.|

## Return Type
The CloneAsSolution action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[CloneAsSolutionResponse ComplexType](../complextypes/CloneAsSolutionResponse.md)|false|Contains the response from CloneAsSolution action. |

## Entities
Use the CloneAsSolution action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[solution Entitytype](../entitytypes/solution.md)|[!INCLUDE[../entitytypes/descriptions/solution.md](../entitytypes/descriptions/solution.md)]|

[!INCLUDE[./remarks/cloneassolution.md](./remarks/cloneassolution.md)]

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