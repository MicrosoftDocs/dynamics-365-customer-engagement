---
title: "FindParentResourceGroup Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: ab61d0c5-a8db-4b74-9aa7-b4652e021683
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# FindParentResourceGroup Function
[!INCLUDE[./descriptions/findparentresourcegroup.md](./descriptions/findparentresourcegroup.md)]



## Bound Entities 
Bound functions are invoked by appending the function name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[resourcegroup Entitytype](../entitytypes/resourcegroup.md)|entity|

## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Children|Collection([resourcegroup EntityType](../entitytypes/resourcegroup.md))|false|true|Specifies the children resource groups.|

## Return Type
The FindParentResourceGroup function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[FindParentResourceGroupResponse ComplexType](../complextypes/FindParentResourceGroupResponse.md)|false|Contains the response from the FindParentResourceGroupResponse function.|



[!INCLUDE[./remarks/findparentresourcegroup.md](./remarks/findparentresourcegroup.md)]

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