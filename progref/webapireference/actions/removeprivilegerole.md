---
title: "RemovePrivilegeRole Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 27dcf697-2340-4d9e-9f52-0c802987644b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RemovePrivilegeRole Action
[!INCLUDE[./descriptions/removeprivilegerole.md](./descriptions/removeprivilegerole.md)]

The RemovePrivilegeRole action does not return a value.

## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[role Entitytype](../entitytypes/role.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Privilege|[privilege EntityType](../entitytypes/privilege.md)|false|true|The privilege that is to be removed from the existing role. |





[!INCLUDE[./remarks/removeprivilegerole.md](./remarks/removeprivilegerole.md)]

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