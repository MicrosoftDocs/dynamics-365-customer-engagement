---
title: "QueryMultipleSchedules Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3568413e-1ed1-482a-8718-87fbf35dbd16
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# QueryMultipleSchedules Function
[!INCLUDE[./descriptions/querymultipleschedules.md](./descriptions/querymultipleschedules.md)]

The QueryMultipleSchedules function is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Resource|Collection([resource EntityType](../entitytypes/resource.md))|false|true|Specifies the resources.|
|Start|Edm.DateTimeOffset|false|true|The start of the time slot.|
|End|Edm.DateTimeOffset|false|true|The end time for the scheduled block of time.|
|TimeCodes|Collection([TimeCode EnumType](../enumtypes/TimeCode.md))|false|true|The timecodes to look for that correspond to the resource IDs.|

## Return Type
The QueryMultipleSchedules function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[QueryMultipleSchedulesResponse ComplexType](../complextypes/QueryMultipleSchedulesResponse.md)|false|Contains the results from the QueryMultipleSchedules function.|



[!INCLUDE[./remarks/querymultipleschedules.md](./remarks/querymultipleschedules.md)]

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