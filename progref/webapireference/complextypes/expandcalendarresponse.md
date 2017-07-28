---
title: "ExpandCalendarResponse ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: dc566f93-e32f-431c-ac44-0ed258eef50f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ExpandCalendarResponse ComplexType
[!INCLUDE[./descriptions/expandcalendarresponse.md](./descriptions/expandcalendarresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|result|Collection([TimeInfo ComplexType](../complextypes/TimeInfo.md))||true|A set of time blocks with appointment information | 

## Used by
The following use the ExpandCalendarResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[ExpandCalendar Function](../functions/expandcalendar.md)|ReturnType|[!INCLUDE[../functions/descriptions/expandcalendar.md](../functions/descriptions/expandcalendar.md)]|

[!INCLUDE[./remarks/expandcalendarresponse.md](./remarks/expandcalendarresponse.md)]

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