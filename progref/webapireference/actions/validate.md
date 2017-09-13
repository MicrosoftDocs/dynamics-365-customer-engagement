---
title: "Validate Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 86e62035-e5f5-4890-8624-02d3ab03b46b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Validate Action
[!INCLUDE[./descriptions/validate.md](./descriptions/validate.md)]

The Validate action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Activities|Collection([activitypointer EntityType](../entitytypes/activitypointer.md))|false|true|The activities to validate. |

## Return Type
The Validate action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[ValidateResponse ComplexType](../complextypes/ValidateResponse.md)|false|Contains the response from the Validate Action. |

## Entities
Use the Validate action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[appointment Entitytype](../entitytypes/appointment.md)|[!INCLUDE[../entitytypes/descriptions/appointment.md](../entitytypes/descriptions/appointment.md)]|
|[savedquery Entitytype](../entitytypes/savedquery.md)|[!INCLUDE[../entitytypes/descriptions/savedquery.md](../entitytypes/descriptions/savedquery.md)]|
|[serviceappointment Entitytype](../entitytypes/serviceappointment.md)|[!INCLUDE[../entitytypes/descriptions/serviceappointment.md](../entitytypes/descriptions/serviceappointment.md)]|

[!INCLUDE[./remarks/validate.md](./remarks/validate.md)]

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