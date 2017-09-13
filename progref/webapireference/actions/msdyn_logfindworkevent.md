---
title: "msdyn_LogFindWorkEvent Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 1ddc14f2-53e5-449a-8e16-14e1d7232298
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# msdyn_LogFindWorkEvent Action
[!INCLUDE[./descriptions/msdyn_logfindworkevent.md](./descriptions/msdyn_logfindworkevent.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[systemuser Entitytype](../entitytypes/systemuser.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|WorkId|[msdyn_projectteam EntityType](../entitytypes/msdyn_projectteam.md)|false|true|TODO: Add description for msdyn_LogFindWorkEvent WorkId parameter.|
|Type|Edm.Int32|false|true|TODO: Add description for msdyn_LogFindWorkEvent Type parameter.|
|Value|Edm.String|false|false|TODO: Add description for msdyn_LogFindWorkEvent Value parameter.|
|Timestamp|Edm.DateTimeOffset|false|true|TODO: Add description for msdyn_LogFindWorkEvent Timestamp parameter.|

## Return Type
The msdyn_LogFindWorkEvent action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[msdyn_LogFindWorkEventResponse ComplexType](../complextypes/msdyn_LogFindWorkEventResponse.md)|false|TODO: Add description for msdyn_LogFindWorkEvent return type.|



[!INCLUDE[./remarks/msdyn_logfindworkevent.md](./remarks/msdyn_logfindworkevent.md)]

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