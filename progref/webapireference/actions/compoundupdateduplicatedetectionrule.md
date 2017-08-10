---
title: "CompoundUpdateDuplicateDetectionRule Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: f32cedde-a25b-44ea-84f6-6a55b9c14df2
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CompoundUpdateDuplicateDetectionRule Action
[!INCLUDE[./descriptions/compoundupdateduplicatedetectionrule.md](./descriptions/compoundupdateduplicatedetectionrule.md)]

The CompoundUpdateDuplicateDetectionRule action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Entity|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The duplicate rule that you want updated. |
|ChildEntities|Collection([crmbaseentity EntityType](../entitytypes/crmbaseentity.md))|false|true|Collection of the duplicate rule conditions that is to be updated. |



## Entities
Use the CompoundUpdateDuplicateDetectionRule action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[duplicaterule Entitytype](../entitytypes/duplicaterule.md)|[!INCLUDE[../entitytypes/descriptions/duplicaterule.md](../entitytypes/descriptions/duplicaterule.md)]|
|[duplicaterulecondition Entitytype](../entitytypes/duplicaterulecondition.md)|[!INCLUDE[../entitytypes/descriptions/duplicaterulecondition.md](../entitytypes/descriptions/duplicaterulecondition.md)]|

[!INCLUDE[./remarks/compoundupdateduplicatedetectionrule.md](./remarks/compoundupdateduplicatedetectionrule.md)]

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