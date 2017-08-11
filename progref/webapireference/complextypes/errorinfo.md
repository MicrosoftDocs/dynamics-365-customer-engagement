---
title: "ErrorInfo ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f5018b55-3229-4998-8846-e3ace1d99ca8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ErrorInfo ComplexType
[!INCLUDE[./descriptions/errorinfo.md](./descriptions/errorinfo.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|ResourceList|Collection([ResourceInfo ComplexType](../complextypes/ResourceInfo.md))||true|The array of information about a resource that has a scheduling problem for an appointment. | 
|ErrorCode|Edm.String|true|false|The reason for a scheduling failure. | 

## Used by
The following use the ErrorInfo ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[TraceInfo ComplexType](../complextypes/traceinfo.md)|Property|[!INCLUDE[../complextypes/descriptions/traceinfo.md](../complextypes/descriptions/traceinfo.md)]|

[!INCLUDE[./remarks/errorinfo.md](./remarks/errorinfo.md)]

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