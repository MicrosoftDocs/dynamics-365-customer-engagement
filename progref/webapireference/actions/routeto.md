---
title: "RouteTo Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 7b6b5d73-be5b-4141-a9f9-5569abcbca0f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RouteTo Action
[!INCLUDE[./descriptions/routeto.md](./descriptions/routeto.md)]

The RouteTo action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Target|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The user, team or queue to which the queue item is routed to. |
|QueueItem|[queueitem EntityType](../entitytypes/queueitem.md)|true|true|The queue item to be routed. |



## Entities
Use the RouteTo action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[queueitem Entitytype](../entitytypes/queueitem.md)|[!INCLUDE[../entitytypes/descriptions/queueitem.md](../entitytypes/descriptions/queueitem.md)]|

[!INCLUDE[./remarks/routeto.md](./remarks/routeto.md)]

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