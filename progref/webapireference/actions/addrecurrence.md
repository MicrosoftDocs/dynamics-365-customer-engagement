---
title: "AddRecurrence Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 46b8f960-b8d1-4ede-8904-495737d9631f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# AddRecurrence Action
[!INCLUDE[./descriptions/addrecurrence.md](./descriptions/addrecurrence.md)]



## Bound Entities 
Bound actions are invoked by appending the action name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[appointment Entitytype](../entitytypes/appointment.md)|entity|

## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Target|[recurringappointmentmaster EntityType](../entitytypes/recurringappointmentmaster.md)|false|true|The recurring appointment master record to which the appointment is converted. |

## Return Type
The AddRecurrence action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[recurringappointmentmaster EntityType](../entitytypes/recurringappointmentmaster.md)|false|Contains the response from AddRecurrence action. |

## Entities
Use the AddRecurrence action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[recurringappointmentmaster Entitytype](../entitytypes/recurringappointmentmaster.md)|[!INCLUDE[../entitytypes/descriptions/recurringappointmentmaster.md](../entitytypes/descriptions/recurringappointmentmaster.md)]|

[!INCLUDE[./remarks/addrecurrence.md](./remarks/addrecurrence.md)]

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