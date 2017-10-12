---
title: "BusinessNotification ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 7e3290cc-3f69-4326-a2dc-bc7fa5781d2f
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# BusinessNotification ComplexType
[!INCLUDE[./descriptions/businessnotification.md](./descriptions/businessnotification.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Severity|[BusinessNotificationSeverity EnumType](../enumtypes/BusinessNotificationSeverity.md)|true|true|For internal use only| 
|Message|Edm.String|true|false|For internal use only | 
|Parameters|Collection([BusinessNotificationParameter ComplexType](../complextypes/BusinessNotificationParameter.md))||true|For internal use only| 

## Used by
The following use the BusinessNotification ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[BookResponse ComplexType](../complextypes/bookresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/bookresponse.md](../complextypes/descriptions/bookresponse.md)]|
|[RescheduleResponse ComplexType](../complextypes/rescheduleresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/rescheduleresponse.md](../complextypes/descriptions/rescheduleresponse.md)]|

[!INCLUDE[./remarks/businessnotification.md](./remarks/businessnotification.md)]

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