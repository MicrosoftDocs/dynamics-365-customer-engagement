---
title: "QueryMultipleSchedulesResponse ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: e1d92433-0dd8-4549-8282-425183ee9611
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# QueryMultipleSchedulesResponse ComplexType
[!INCLUDE[./descriptions/querymultipleschedulesresponse.md](./descriptions/querymultipleschedulesresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|TimeInfos|Collection([TimeInfoCollection ComplexType](../complextypes/TimeInfoCollection.md))||true|A set of possible time block for each resource.| 

## Used by
The following use the QueryMultipleSchedulesResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[QueryMultipleSchedules Function](../functions/querymultipleschedules.md)|ReturnType|[!INCLUDE[../functions/descriptions/querymultipleschedules.md](../functions/descriptions/querymultipleschedules.md)]|

[!INCLUDE[./remarks/querymultipleschedulesresponse.md](./remarks/querymultipleschedulesresponse.md)]

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