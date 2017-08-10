---
title: "RetrieveUserQueues Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 4c0ea614-d596-4582-aa8c-7b8fd657ece4
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveUserQueues Function
[!INCLUDE[./descriptions/retrieveuserqueues.md](./descriptions/retrieveuserqueues.md)]



## Bound Entities 
Bound functions are invoked by appending the function name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[systemuser Entitytype](../entitytypes/systemuser.md)|entity|

## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|IncludePublic|Edm.Boolean|false|true|Whether the response should include public queues. |

## Return Type
The RetrieveUserQueues function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([queue EntityType](../entitytypes/queue.md))|false|Contains the results from the RetrieveUserQueuesResponse function. |

## Entities
Use the RetrieveUserQueues function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[queue Entitytype](../entitytypes/queue.md)|[!INCLUDE[../entitytypes/descriptions/queue.md](../entitytypes/descriptions/queue.md)]|

[!INCLUDE[./remarks/retrieveuserqueues.md](./remarks/retrieveuserqueues.md)]

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