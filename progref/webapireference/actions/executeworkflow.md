---
title: "ExecuteWorkflow Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 83c32c87-5b62-47a4-91f4-f7fa69abf741
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ExecuteWorkflow Action
[!INCLUDE[./descriptions/executeworkflow.md](./descriptions/executeworkflow.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[workflow Entitytype](../entitytypes/workflow.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|EntityId|Edm.Guid|false|true|The ID of the record on which the workflow executes|
|InputArguments|[InputArgumentCollection ComplexType](../complextypes/InputArgumentCollection.md)|true|true|For internal use only.|

## Return Type
The ExecuteWorkflow action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[asyncoperation EntityType](../entitytypes/asyncoperation.md)|false|Contains the response from the ExecuteWorkflow Action|



[!INCLUDE[./remarks/executeworkflow.md](./remarks/executeworkflow.md)]

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