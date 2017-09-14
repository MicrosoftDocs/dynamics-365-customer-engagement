---
title: "TimeInfo ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d8f916f9-57d1-40d1-81e1-c626d2b6aa29
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# TimeInfo ComplexType
[!INCLUDE[./descriptions/timeinfo.md](./descriptions/timeinfo.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Start|Edm.DateTimeOffset|true|true|The start time for the block.| 
|End|Edm.DateTimeOffset|true|true|The end time for the block.| 
|TimeCode|[TimeCode EnumType](../enumtypes/TimeCode.md)|true|true|Indicates whether the time block is available, busy, filtered or unavailable.| 
|SubCode|[SubCode EnumType](../enumtypes/SubCode.md)|true|true|Information about the time block such as whether it is an appointment, break, or holiday. | 
|SourceId|Edm.Guid|true|true|The ID of the record referred to in the time block. | 
|CalendarId|Edm.Guid|true|true|The ID of the calendar for this block of time.| 
|SourceTypeCode|Edm.Int32|true|true|The type of entity referred to in the time block. | 
|IsActivity|Edm.Boolean|true|true|Indicates whether the block of time refers to an activity.| 
|ActivityStatusCode|Edm.Int32|true|true|The status of the activity. | 
|Effort|Edm.Double|true|true|The amount of effort required for this block of time.| 
|DisplayText|Edm.String|true|false|The display text shown in the calendar for the time block. | 

## Used by
The following use the TimeInfo ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[ExpandCalendarResponse ComplexType](../complextypes/expandcalendarresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/expandcalendarresponse.md](../complextypes/descriptions/expandcalendarresponse.md)]|
|[QueryScheduleResponse ComplexType](../complextypes/queryscheduleresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/queryscheduleresponse.md](../complextypes/descriptions/queryscheduleresponse.md)]|
|[TimeInfoCollection ComplexType](../complextypes/timeinfocollection.md)|Property|[!INCLUDE[../complextypes/descriptions/timeinfocollection.md](../complextypes/descriptions/timeinfocollection.md)]|

[!INCLUDE[./remarks/timeinfo.md](./remarks/timeinfo.md)]

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