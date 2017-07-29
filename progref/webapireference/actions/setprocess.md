---
title: "SetProcess Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 74d2ec5c-4768-4db1-b752-d4298988ff90
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SetProcess Action
[!INCLUDE[./descriptions/setprocess.md](./descriptions/setprocess.md)]

The SetProcess action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Target|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The target entity.|
|NewProcess|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|true|true|The business process flow definition to be set to the target entity.|
|NewProcessInstance|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|true|true|The business process flow instance to be set as the active business process flow instance for the target entity. Optional. If you do not specify this parameter and there isn't any active business process flow instance for the target entity record and the specified business process flow definition, a new business process flow instance will be created and set as the active instance.|





[!INCLUDE[./remarks/setprocess.md](./remarks/setprocess.md)]

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