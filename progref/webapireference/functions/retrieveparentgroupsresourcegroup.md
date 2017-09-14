---
title: "RetrieveParentGroupsResourceGroup Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 98e07d93-0944-44a9-8dea-f893f13ec28e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveParentGroupsResourceGroup Function
[!INCLUDE[./descriptions/retrieveparentgroupsresourcegroup.md](./descriptions/retrieveparentgroupsresourcegroup.md)]

The RetrieveParentGroupsResourceGroup function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ResourceGroupId|Edm.Guid|false|true|The ID of the specified group. |

## Return Type
The RetrieveParentGroupsResourceGroup function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([resourcegroup EntityType](../entitytypes/resourcegroup.md))|false|Contains the results from the RetrieveParentGroupsResourceGroup function.|

## Entities
Use the RetrieveParentGroupsResourceGroup function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[resourcegroup Entitytype](../entitytypes/resourcegroup.md)|[!INCLUDE[../entitytypes/descriptions/resourcegroup.md](../entitytypes/descriptions/resourcegroup.md)]|

[!INCLUDE[./remarks/retrieveparentgroupsresourcegroup.md](./remarks/retrieveparentgroupsresourcegroup.md)]

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