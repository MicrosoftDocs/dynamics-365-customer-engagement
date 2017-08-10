---
title: "ValidationResult ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 62ce2287-331d-4199-8b0b-9aa24a94a8b7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ValidationResult ComplexType
[!INCLUDE[./descriptions/validationresult.md](./descriptions/validationresult.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|ValidationSuccess|Edm.Boolean|true|true|Indicates whether the appointment or service appointment was validated successfully. | 
|TraceInfo|[TraceInfo ComplexType](../complextypes/TraceInfo.md)|true|true|The reasons for any scheduling failures.| 
|ActivityId|Edm.Guid|true|true|ID of the validated activity. | 

## Used by
The following use the ValidationResult ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[BookResponse ComplexType](../complextypes/bookresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/bookresponse.md](../complextypes/descriptions/bookresponse.md)]|
|[RescheduleResponse ComplexType](../complextypes/rescheduleresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/rescheduleresponse.md](../complextypes/descriptions/rescheduleresponse.md)]|
|[ValidateResponse ComplexType](../complextypes/validateresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/validateresponse.md](../complextypes/descriptions/validateresponse.md)]|

[!INCLUDE[./remarks/validationresult.md](./remarks/validationresult.md)]

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