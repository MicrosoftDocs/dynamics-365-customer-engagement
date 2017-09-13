---
title: "SubCode EnumType| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f16aba61-8b49-4e1a-af63-2745a24f368b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# SubCode EnumType
[!INCLUDE[./descriptions/subcode.md](./descriptions/subcode.md)]

## Members
Members define the discrete options for the enumeration type.
|Name|Value|Description|
|---|---|---|
|Unspecified|0|Specifies free time with no specified restrictions.| 
|Schedulable|1|A schedulable block of time.| 
|Committed|2|A block of time that is committed to perform an action.| 
|Uncommitted|3|A block of time that is tentatively scheduled but not committed.| 
|Break|4|A block of time that cannot be committed due to a scheduled break.| 
|Holiday|5|A block of time that cannot be scheduled due to a scheduled holiday.| 
|Vacation|6|A block of time that cannot be scheduled due to a scheduled vacation.| 
|Appointment|7|A block of time that is already scheduled for an appointment.| 
|ResourceStartTime|8|Specifies to filter a resource start time.| 
|ResourceServiceRestriction|9|A restriction for a resource for the specified service.| 
|ResourceCapacity|10|Specifies the capacity of a resource for the specified time interval. | 
|ServiceRestriction|11|Specifies that a service is restricted during the specified block of time.| 
|ServiceCost|12|An override to the service cost for the specified time block.| 

## Used by
The following use the SubCode enum type.
|Name|How used|Description|
|---|---|---|
|[TimeInfo ComplexType](../complextypes/timeinfo.md)|Property|[!INCLUDE[../complextypes/descriptions/timeinfo.md](../complextypes/descriptions/timeinfo.md)]|

[!INCLUDE[./remarks/subcode.md](./remarks/subcode.md)]

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