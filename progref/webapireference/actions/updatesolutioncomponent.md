---
title: "UpdateSolutionComponent Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 575c57a4-882b-459a-8c73-63499214ed0c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# UpdateSolutionComponent Action
[!INCLUDE[./descriptions/updatesolutioncomponent.md](./descriptions/updatesolutioncomponent.md)]

The UpdateSolutionComponent action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ComponentId|Edm.Guid|false|true|The unique identifier of the component to update.|
|ComponentType|Edm.Int32|false|true|The type of component being updated. |
|SolutionUniqueName|Edm.String|false|false|The unique name of the solution where the component should exist.|
|IncludedComponentSettingsValues|Collection(Edm.String)||false|Any settings to be included in the component update.|



## Entities
Use the UpdateSolutionComponent action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[solutioncomponent Entitytype](../entitytypes/solutioncomponent.md)|[!INCLUDE[../entitytypes/descriptions/solutioncomponent.md](../entitytypes/descriptions/solutioncomponent.md)]|

[!INCLUDE[./remarks/updatesolutioncomponent.md](./remarks/updatesolutioncomponent.md)]

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