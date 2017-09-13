---
title: "Reschedule Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 81e6b169-6074-4f05-ba5d-86b5a32ceaab
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Reschedule Action
[!INCLUDE[./descriptions/reschedule.md](./descriptions/reschedule.md)]

The Reschedule action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Target|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The target of the reschedule operation.|
|ReturnNotifications|Edm.Boolean|true|true|For internal use only. |

## Return Type
The Reschedule action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[RescheduleResponse ComplexType](../complextypes/RescheduleResponse.md)|false|Contains the response from Reschedule Action. |

## Entities
Use the Reschedule action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[appointment Entitytype](../entitytypes/appointment.md)|[!INCLUDE[../entitytypes/descriptions/appointment.md](../entitytypes/descriptions/appointment.md)]|
|[recurringappointmentmaster Entitytype](../entitytypes/recurringappointmentmaster.md)|[!INCLUDE[../entitytypes/descriptions/recurringappointmentmaster.md](../entitytypes/descriptions/recurringappointmentmaster.md)]|
|[serviceappointment Entitytype](../entitytypes/serviceappointment.md)|[!INCLUDE[../entitytypes/descriptions/serviceappointment.md](../entitytypes/descriptions/serviceappointment.md)]|

[!INCLUDE[./remarks/reschedule.md](./remarks/reschedule.md)]

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