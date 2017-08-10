---
title: "AddSolutionComponent Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 1a24ced2-806b-4649-a5b6-ca155b7bd87e
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AddSolutionComponent Action
[!INCLUDE[./descriptions/addsolutioncomponent.md](./descriptions/addsolutioncomponent.md)]

The AddSolutionComponent action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ComponentId|Edm.Guid|false|true|ID of the solution component.|
|ComponentType|Edm.Int32|false|true|The solution component to add to the unmanaged solution.|
|SolutionUniqueName|Edm.String|false|false|Unique name of the solution. |
|AddRequiredComponents|Edm.Boolean|false|true|Indicates whether other solution components that are required by the solution component should also be added to the unmanaged solution. |
|DoNotIncludeSubcomponents|Edm.Boolean|true|true|Indicates whether the subcomponents should be included.|
|IncludedComponentSettingsValues|Collection(Edm.String)||false|Any settings to be included with the component.|

## Return Type
The AddSolutionComponent action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[AddSolutionComponentResponse ComplexType](../complextypes/AddSolutionComponentResponse.md)|false|Contains the response from AddSolutionComponent action.|

## Entities
Use the AddSolutionComponent action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[solutioncomponent Entitytype](../entitytypes/solutioncomponent.md)|[!INCLUDE[../entitytypes/descriptions/solutioncomponent.md](../entitytypes/descriptions/solutioncomponent.md)]|

[!INCLUDE[./remarks/addsolutioncomponent.md](./remarks/addsolutioncomponent.md)]

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