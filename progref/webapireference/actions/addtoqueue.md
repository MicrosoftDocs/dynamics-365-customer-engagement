---
title: "AddToQueue Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: b0871fcd-bf63-41dc-81c8-a6dd2df1a39e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AddToQueue Action
[!INCLUDE[./descriptions/addtoqueue.md](./descriptions/addtoqueue.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[queue Entitytype](../entitytypes/queue.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Target|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The destination queue. |
|SourceQueue|[queue EntityType](../entitytypes/queue.md)|true|true|The source queue. |
|QueueItemProperties|[queueitem EntityType](../entitytypes/queueitem.md)|true|true|Properties required to create a queue item in the destination queue.|

## Return Type
The AddToQueue action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[AddToQueueResponse ComplexType](../complextypes/AddToQueueResponse.md)|false|Contains the response from AddToQueue action.|

## Entities
Use the AddToQueue action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[queueitem Entitytype](../entitytypes/queueitem.md)|[!INCLUDE[../entitytypes/descriptions/queueitem.md](../entitytypes/descriptions/queueitem.md)]|

[!INCLUDE[./remarks/addtoqueue.md](./remarks/addtoqueue.md)]

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