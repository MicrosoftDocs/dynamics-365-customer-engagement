---
title: "RescheduleResponse ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d6adc4f9-757a-4e80-affb-0718930248c8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RescheduleResponse ComplexType
[!INCLUDE[./descriptions/rescheduleresponse.md](./descriptions/rescheduleresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|ValidationResult|[ValidationResult ComplexType](../complextypes/ValidationResult.md)|true|true|The validation results for the appointment, recurring appointment master, or service appointment (service activity).| 
|Notifications|Collection([BusinessNotification ComplexType](../complextypes/BusinessNotification.md))||true|For internal use only. | 

## Used by
The following use the RescheduleResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[Reschedule Action](../actions/reschedule.md)|ReturnType|[!INCLUDE[../actions/descriptions/reschedule.md](../actions/descriptions/reschedule.md)]|

[!INCLUDE[./remarks/rescheduleresponse.md](./remarks/rescheduleresponse.md)]

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