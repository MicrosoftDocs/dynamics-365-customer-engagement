---
title: "ExpandCalendar Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9a3a1189-7542-4e5c-bc68-617dedb6a59f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ExpandCalendar Function
[!INCLUDE[./descriptions/expandcalendar.md](./descriptions/expandcalendar.md)]



## Bound Entities 
Bound functions are invoked by appending the function name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[calendar Entitytype](../entitytypes/calendar.md)|entity|

## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Start|Edm.DateTimeOffset|false|true|the start of the period to expand.|
|End|Edm.DateTimeOffset|false|true|the end of the time period to expand. |

## Return Type
The ExpandCalendar function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[ExpandCalendarResponse ComplexType](../complextypes/ExpandCalendarResponse.md)|false|Contains the response from the ExpandCalendar function.|



[!INCLUDE[./remarks/expandcalendar.md](./remarks/expandcalendar.md)]

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