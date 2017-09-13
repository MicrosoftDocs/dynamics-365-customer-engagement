---
title: "ValidateResponse ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 623ee39d-a3b4-4ca8-93cf-f8c52718fed7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ValidateResponse ComplexType
[!INCLUDE[./descriptions/validateresponse.md](./descriptions/validateresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Result|Collection([ValidationResult ComplexType](../complextypes/ValidationResult.md))||true|the results of the validate operation. | 

## Used by
The following use the ValidateResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[Validate Action](../actions/validate.md)|ReturnType|[!INCLUDE[../actions/descriptions/validate.md](../actions/descriptions/validate.md)]|

[!INCLUDE[./remarks/validateresponse.md](./remarks/validateresponse.md)]

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