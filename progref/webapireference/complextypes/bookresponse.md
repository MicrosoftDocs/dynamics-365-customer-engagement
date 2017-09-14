---
title: "BookResponse ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: b5107e11-b04b-4aae-a0ac-4e1e59542eef
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# BookResponse ComplexType
[!INCLUDE[./descriptions/bookresponse.md](./descriptions/bookresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Notifications|Collection([BusinessNotification ComplexType](../complextypes/BusinessNotification.md))||true|For internal use only. | 
|ValidationResult|[ValidationResult ComplexType](../complextypes/ValidationResult.md)|true|true|The appointment validation results. | 

## Used by
The following use the BookResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[Book Action](../actions/book.md)|ReturnType|[!INCLUDE[../actions/descriptions/book.md](../actions/descriptions/book.md)]|

[!INCLUDE[./remarks/bookresponse.md](./remarks/bookresponse.md)]

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