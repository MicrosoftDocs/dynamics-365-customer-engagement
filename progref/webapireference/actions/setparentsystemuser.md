---
title: "SetParentSystemUser Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 5a4d1065-09c4-4300-a2be-bb192dae5869
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SetParentSystemUser Action
[!INCLUDE[./descriptions/setparentsystemuser.md](./descriptions/setparentsystemuser.md)]

The SetParentSystemUser action does not return a value.

## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[systemuser Entitytype](../entitytypes/systemuser.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Parent|[systemuser EntityType](../entitytypes/systemuser.md)|false|true|The new parent user. |
|KeepChildUsers|Edm.Boolean|false|true|Indicates whether the child users are to be retained. |



## Entities
Use the SetParentSystemUser action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[businessunit Entitytype](../entitytypes/businessunit.md)|[!INCLUDE[../entitytypes/descriptions/businessunit.md](../entitytypes/descriptions/businessunit.md)]|
|[team Entitytype](../entitytypes/team.md)|[!INCLUDE[../entitytypes/descriptions/team.md](../entitytypes/descriptions/team.md)]|

[!INCLUDE[./remarks/setparentsystemuser.md](./remarks/setparentsystemuser.md)]

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