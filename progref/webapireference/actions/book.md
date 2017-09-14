---
title: "Book Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: b9f6555f-51a1-4424-8648-4d91b39bd890
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Book Action
[!INCLUDE[./descriptions/book.md](./descriptions/book.md)]

The Book action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Target|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true| The record that is the target of the book operation. |
|ReturnNotifications|Edm.Boolean|true|true|For internal use only.|

## Return Type
The Book action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[BookResponse ComplexType](../complextypes/BookResponse.md)|false|Contains the response from the Book action. |

## Entities
Use the Book action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[appointment Entitytype](../entitytypes/appointment.md)|[!INCLUDE[../entitytypes/descriptions/appointment.md](../entitytypes/descriptions/appointment.md)]|
|[recurringappointmentmaster Entitytype](../entitytypes/recurringappointmentmaster.md)|[!INCLUDE[../entitytypes/descriptions/recurringappointmentmaster.md](../entitytypes/descriptions/recurringappointmentmaster.md)]|
|[serviceappointment Entitytype](../entitytypes/serviceappointment.md)|[!INCLUDE[../entitytypes/descriptions/serviceappointment.md](../entitytypes/descriptions/serviceappointment.md)]|

[!INCLUDE[./remarks/book.md](./remarks/book.md)]

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