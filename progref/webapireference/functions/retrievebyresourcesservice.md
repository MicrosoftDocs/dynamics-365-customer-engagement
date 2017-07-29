---
title: "RetrieveByResourcesService Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e08ea08d-3391-48e5-8f9f-626a6c71dee8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveByResourcesService Function
[!INCLUDE[./descriptions/retrievebyresourcesservice.md](./descriptions/retrievebyresourcesservice.md)]

The RetrieveByResourcesService function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Resource|Collection([resource EntityType](../entitytypes/resource.md))|false|true|The specified resource. |

## Return Type
The RetrieveByResourcesService function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([service EntityType](../entitytypes/service.md))|false|Contains the response from the RetrieveByResourcesService Function.|

## Entities
Use the RetrieveByResourcesService function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[service Entitytype](../entitytypes/service.md)|[!INCLUDE[../entitytypes/descriptions/service.md](../entitytypes/descriptions/service.md)]|

[!INCLUDE[./remarks/retrievebyresourcesservice.md](./remarks/retrievebyresourcesservice.md)]

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