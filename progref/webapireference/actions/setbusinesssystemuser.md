---
title: "SetBusinessSystemUser Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 0e06bbd2-adbb-484d-b487-1fb0c8f0da67
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SetBusinessSystemUser Action
[!INCLUDE[./descriptions/setbusinesssystemuser.md](./descriptions/setbusinesssystemuser.md)]

The SetBusinessSystemUser action does not return a value.

## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[systemuser Entitytype](../entitytypes/systemuser.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|BusinessUnit|[businessunit EntityType](../entitytypes/businessunit.md)|false|true|The business unit to which the user needs to be moved. |
|ReassignPrincipal|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The target security principal (user) to which the instances of entities previously owned by the user are to be assigned.  |



## Entities
Use the SetBusinessSystemUser action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[equipment Entitytype](../entitytypes/equipment.md)|[!INCLUDE[../entitytypes/descriptions/equipment.md](../entitytypes/descriptions/equipment.md)]|

[!INCLUDE[./remarks/setbusinesssystemuser.md](./remarks/setbusinesssystemuser.md)]

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