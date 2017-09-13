---
title: "AddMembersTeam Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 30946fa5-b0eb-4b4a-ae69-4d5cd9fe4334
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AddMembersTeam Action
[!INCLUDE[./descriptions/addmembersteam.md](./descriptions/addmembersteam.md)]

The AddMembersTeam action does not return a value.

## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[team Entitytype](../entitytypes/team.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Members|Collection([systemuser EntityType](../entitytypes/systemuser.md))|false|true|The users to be added to a team.  |





[!INCLUDE[./remarks/addmembersteam.md](./remarks/addmembersteam.md)]

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