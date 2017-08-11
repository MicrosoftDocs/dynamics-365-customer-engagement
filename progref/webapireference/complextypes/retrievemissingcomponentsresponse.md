---
title: "RetrieveMissingComponentsResponse ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 3bd4d425-df8d-4d12-9a14-b5c526749b4b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveMissingComponentsResponse ComplexType
[!INCLUDE[./descriptions/retrievemissingcomponentsresponse.md](./descriptions/retrievemissingcomponentsresponse.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|MissingComponents|Collection([MissingComponent ComplexType](../complextypes/MissingComponent.md))||true|An array of MissingComponent records. | 

## Used by
The following use the RetrieveMissingComponentsResponse ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[RetrieveMissingComponents Function](../functions/retrievemissingcomponents.md)|ReturnType|[!INCLUDE[../functions/descriptions/retrievemissingcomponents.md](../functions/descriptions/retrievemissingcomponents.md)]|

[!INCLUDE[./remarks/retrievemissingcomponentsresponse.md](./remarks/retrievemissingcomponentsresponse.md)]

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