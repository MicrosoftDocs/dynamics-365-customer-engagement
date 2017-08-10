---
title: "RollupType EnumType| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 9058a7a6-5697-45e0-9ec6-6b99727221c8
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RollupType EnumType
[!INCLUDE[./descriptions/rolluptype.md](./descriptions/rolluptype.md)]

## Members
Members define the discrete options for the enumeration type.
|Name|Value|Description|
|---|---|---|
|None|0|A rollup record is not requested. This member only retrieves the records that are directly related to a parent record. | 
|Related|1|A rollup record that is directly related to a parent record and to any direct child of a parent record. | 
|Extended|2|A rollup record that is directly related to a parent record and to any descendent record of a parent record, for example, children, grandchildren, and great-grandchildren records. | 

## Used by
The following use the RollupType enum type.
|Name|How used|Description|
|---|---|---|
|[Rollup Function](../functions/rollup.md)|Parameter|[!INCLUDE[../functions/descriptions/rollup.md](../functions/descriptions/rollup.md)]|

[!INCLUDE[./remarks/rolluptype.md](./remarks/rolluptype.md)]

### See also  
 [Use the Microsoft Dynamics CRM Web API](https://msdn.microsoft.com/library/mt593051.aspx)   
 [Web API EntityType Reference](../entitytypereference.md)   
 [Web API Action Reference](../actionreference.md)   
 [Web API Function Reference](../functionreference.md)   
 [Web API Query Function Reference](../queryfunctionreference.md)   
 [Web API EnumType Reference](../enumtypereference.md)   
 [Web API ComplexType Reference](../complextypereference.md)   
 [Web API Metadata EntityType Reference](../entitytypereference.md)   
 [Web API Solutions Reference](../solutionreference.md)