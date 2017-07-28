---
title: "InputArgument ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 6a55818d-1182-433a-a175-8fe79611168b
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# InputArgument ComplexType
[!INCLUDE[./descriptions/inputargument.md](./descriptions/inputargument.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Count|Edm.Int32|true|true|The number of elements in the collection| 
|IsReadOnly|Edm.Boolean|true|true|Indicates whether the collection is read-only.| 
|Keys|Collection(Edm.String)|false|false|A collection containing the keys of the collection. | 
|Values|Collection([Object ComplexType](../complextypes/Object.md))||true|A collection containing the values in the collection. | 

## Used by
The following use the InputArgument ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[InputArgumentCollection ComplexType](../complextypes/inputargumentcollection.md)|Property|[!INCLUDE[../complextypes/descriptions/inputargumentcollection.md](../complextypes/descriptions/inputargumentcollection.md)]|

[!INCLUDE[./remarks/inputargument.md](./remarks/inputargument.md)]

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