---
title: "ResourceInfo ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 153b4d60-9207-4a03-b045-42894ac4925c
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ResourceInfo ComplexType
[!INCLUDE[./descriptions/resourceinfo.md](./descriptions/resourceinfo.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Id|Edm.Guid|true|true| The ID of the record that has a scheduling problem.| 
|DisplayName|Edm.String|true|false|The display name for the resource. | 
|EntityName|Edm.String|true|false|The logical name of the entity. | 

## Used by
The following use the ResourceInfo ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[ErrorInfo ComplexType](../complextypes/errorinfo.md)|Property|[!INCLUDE[../complextypes/descriptions/errorinfo.md](../complextypes/descriptions/errorinfo.md)]|

[!INCLUDE[./remarks/resourceinfo.md](./remarks/resourceinfo.md)]

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