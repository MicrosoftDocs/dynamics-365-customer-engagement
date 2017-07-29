---
title: "QuerySchedule Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f77eb2a1-c354-42ee-982a-9da5cad277d3
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# QuerySchedule Function
[!INCLUDE[./descriptions/queryschedule.md](./descriptions/queryschedule.md)]

The QuerySchedule function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|ResourceId|Edm.Guid|false|true|The resource. |
|Start|Edm.DateTimeOffset|false|true|The start time for the scheduled block of time.|
|End|Edm.DateTimeOffset|false|true|The end time for the scheduled block of time. |
|TimeCodes|Collection([TimeCode EnumType](../enumtypes/TimeCode.md))|false|true|The time codes to look for: Available, Busy, Unavailable, or Filter, which correspond to the resource IDs |

## Return Type
The QuerySchedule function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[QueryScheduleResponse ComplexType](../complextypes/QueryScheduleResponse.md)|false|Contains the response from the QuerySchedule function. |



[!INCLUDE[./remarks/queryschedule.md](./remarks/queryschedule.md)]

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