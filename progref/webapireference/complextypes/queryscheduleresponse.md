---
title: "QueryScheduleResponse ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 8ea5f8ac-5e96-4f58-8d11-43b8226fc9ac
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# QueryScheduleResponse ComplexType
[!INCLUDE[./descriptions/queryscheduleresponse.md](./descriptions/queryscheduleresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|TimeInfos|Collection([TimeInfo ComplexType](../complextypes/TimeInfo.md))||true|A set of possible time slots for the resource. | 

## Used by
The following use the QueryScheduleResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[QuerySchedule Function](../functions/queryschedule.md)|ReturnType|[!INCLUDE[../functions/descriptions/queryschedule.md](../functions/descriptions/queryschedule.md)]|

[!INCLUDE[./remarks/queryscheduleresponse.md](./remarks/queryscheduleresponse.md)]

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