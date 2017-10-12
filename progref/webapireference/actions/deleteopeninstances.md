---
title: "DeleteOpenInstances Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: e8405993-4e34-4a7f-9007-b00db726ac23
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# DeleteOpenInstances Action
[!INCLUDE[./descriptions/deleteopeninstances.md](./descriptions/deleteopeninstances.md)]

The DeleteOpenInstances action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Target|[recurringappointmentmaster EntityType](../entitytypes/recurringappointmentmaster.md)|false|true|The target record for the operation.  |
|SeriesEndDate|Edm.DateTimeOffset|false|true|The end date for the recurring appointment series.  |
|StateOfPastInstances|Edm.Int32|false|true|The value to be used to set the status of appointment instances that have already passed. |



## Entities
Use the DeleteOpenInstances action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[recurringappointmentmaster Entitytype](../entitytypes/recurringappointmentmaster.md)|[!INCLUDE[../entitytypes/descriptions/recurringappointmentmaster.md](../entitytypes/descriptions/recurringappointmentmaster.md)]|

[!INCLUDE[./remarks/deleteopeninstances.md](./remarks/deleteopeninstances.md)]

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