---
title: "TraceInfo ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: d2deb945-10dc-4bfd-ad92-4d7d4f0a1d15
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# TraceInfo ComplexType
[!INCLUDE[./descriptions/traceinfo.md](./descriptions/traceinfo.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|ErrorInfoList|Collection([ErrorInfo ComplexType](../complextypes/ErrorInfo.md))||true|The list of error information for the scheduling operation.| 

## Used by
The following use the TraceInfo ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[SearchResults ComplexType](../complextypes/searchresults.md)|Property|[!INCLUDE[../complextypes/descriptions/searchresults.md](../complextypes/descriptions/searchresults.md)]|
|[ValidationResult ComplexType](../complextypes/validationresult.md)|Property|[!INCLUDE[../complextypes/descriptions/validationresult.md](../complextypes/descriptions/validationresult.md)]|

[!INCLUDE[./remarks/traceinfo.md](./remarks/traceinfo.md)]

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