---
title: "CreateException Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 28cecd51-81fe-42d1-be78-61b77d0329e7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CreateException Action
[!INCLUDE[./descriptions/createexception.md](./descriptions/createexception.md)]

The CreateException action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Target|[appointment EntityType](../entitytypes/appointment.md)|false|true|The target appointment for the exception. |
|OriginalStartDate|Edm.DateTimeOffset|false|true|Original start date of the recurring appointment. |
|IsDeleted|Edm.Boolean|false|true|Specifies whether the appointment instance is deleted.  |

## Return Type
The CreateException action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[CreateExceptionResponse ComplexType](../complextypes/CreateExceptionResponse.md)|false|Contains the response from the CreateException action. |

## Entities
Use the CreateException action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[appointment Entitytype](../entitytypes/appointment.md)|[!INCLUDE[../entitytypes/descriptions/appointment.md](../entitytypes/descriptions/appointment.md)]|

[!INCLUDE[./remarks/createexception.md](./remarks/createexception.md)]

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