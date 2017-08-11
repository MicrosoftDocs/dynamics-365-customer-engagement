---
title: "ReassignObjectsOwner Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 5c4c83b5-8011-481a-98b1-07b26855df3f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ReassignObjectsOwner Action
[!INCLUDE[./descriptions/reassignobjectsowner.md](./descriptions/reassignobjectsowner.md)]

The ReassignObjectsOwner action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|FromPrincipal|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The security principal (user or team) for which to reassign all records. |
|ToPrincipal|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The security principal (user or team) that will be the new owner for the records. |





[!INCLUDE[./remarks/reassignobjectsowner.md](./remarks/reassignobjectsowner.md)]

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