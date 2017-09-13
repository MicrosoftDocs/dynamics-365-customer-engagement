---
title: "RemoveMembersTeam Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 3d428ccb-9fc9-4b46-b68c-047bce369b2a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RemoveMembersTeam Action
[!INCLUDE[./descriptions/removemembersteam.md](./descriptions/removemembersteam.md)]

The RemoveMembersTeam action does not return a value.

## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[team Entitytype](../entitytypes/team.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Members|Collection([systemuser EntityType](../entitytypes/systemuser.md))|false|true|The members to remove.|





[!INCLUDE[./remarks/removemembersteam.md](./remarks/removemembersteam.md)]

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