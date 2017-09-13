---
title: "msdyn_BulkCreatePredecessorsForTask Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 1dd246ee-5f0e-46ae-9fc8-1b8d982ac742
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_BulkCreatePredecessorsForTask Action
[!INCLUDE[./descriptions/msdyn_bulkcreatepredecessorsfortask.md](./descriptions/msdyn_bulkcreatepredecessorsfortask.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[msdyn_projecttask Entitytype](../entitytypes/msdyn_projecttask.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|MoveBookings|Edm.Boolean|false|true|TODO: Add description for msdyn_BulkCreatePredecessorsForTask MoveBookings parameter.|
|ProjectId|Edm.String|false|false|TODO: Add description for msdyn_BulkCreatePredecessorsForTask ProjectId parameter.|
|TasksUpdateList|Edm.String|true|false|TODO: Add description for msdyn_BulkCreatePredecessorsForTask TasksUpdateList parameter.|
|PredecessorTaskIds|Edm.String|true|false|TODO: Add description for msdyn_BulkCreatePredecessorsForTask PredecessorTaskIds parameter.|

## Return Type
The msdyn_BulkCreatePredecessorsForTask action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[msdyn_BulkCreatePredecessorsForTaskResponse ComplexType](../complextypes/msdyn_BulkCreatePredecessorsForTaskResponse.md)|false|TODO: Add description for msdyn_BulkCreatePredecessorsForTask return type.|



[!INCLUDE[./remarks/msdyn_bulkcreatepredecessorsfortask.md](./remarks/msdyn_bulkcreatepredecessorsfortask.md)]

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