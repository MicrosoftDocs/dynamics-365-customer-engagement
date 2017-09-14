---
title: "TimeCode EnumType| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 86914701-ab09-436c-8430-3d6ffdeaa81a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# TimeCode EnumType
[!INCLUDE[./descriptions/timecode.md](./descriptions/timecode.md)]

## Members
Members define the discrete options for the enumeration type.
|Name|Value|Description|
|---|---|---|
|Available|0|The time is available within the working hours of the resource.| 
|Busy|1|The time is committed to an activity.| 
|Unavailable|2|The time is unavailable. | 
|Filter|3|Use additional filters for the time block such as service cost or service start time.| 

## Used by
The following use the TimeCode enum type.
|Name|How used|Description|
|---|---|---|
|[QueryMultipleSchedules Function](../functions/querymultipleschedules.md)|Parameter|[!INCLUDE[../functions/descriptions/querymultipleschedules.md](../functions/descriptions/querymultipleschedules.md)]|
|[QuerySchedule Function](../functions/queryschedule.md)|Parameter|[!INCLUDE[../functions/descriptions/queryschedule.md](../functions/descriptions/queryschedule.md)]|
|[TimeInfo ComplexType](../complextypes/timeinfo.md)|Property|[!INCLUDE[../complextypes/descriptions/timeinfo.md](../complextypes/descriptions/timeinfo.md)]|

[!INCLUDE[./remarks/timecode.md](./remarks/timecode.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)   
 [Web API EntityType Reference](../entitytypereference.md)   
 [Web API Action Reference](../actionreference.md)   
 [Web API Function Reference](../functionreference.md)   
 [Web API Query Function Reference](../queryfunctionreference.md)   
 [Web API EnumType Reference](../enumtypereference.md)   
 [Web API ComplexType Reference](../complextypereference.md)   
 [Web API Metadata EntityType Reference](../entitytypereference.md)   
 [Web API Solutions Reference](../solutionreference.md)