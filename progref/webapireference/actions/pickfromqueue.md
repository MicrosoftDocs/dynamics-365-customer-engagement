---
title: "PickFromQueue Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 1d21e305-3fd2-486d-bf46-f18c345251f6
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# PickFromQueue Action
[!INCLUDE[./descriptions/pickfromqueue.md](./descriptions/pickfromqueue.md)]

The PickFromQueue action does not return a value.

## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[queueitem Entitytype](../entitytypes/queueitem.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|SystemUser|[systemuser EntityType](../entitytypes/systemuser.md)|false|true|The user to assign the queue item to. |
|RemoveQueueItem|Edm.Boolean|false|true|The queue item to remove. |





[!INCLUDE[./remarks/pickfromqueue.md](./remarks/pickfromqueue.md)]

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