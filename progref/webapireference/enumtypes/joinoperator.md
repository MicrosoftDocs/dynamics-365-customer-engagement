---
title: "JoinOperator EnumType| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 95fc87e3-dac1-495d-b3d1-9ca3449eb8a1
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# JoinOperator EnumType
[!INCLUDE[./descriptions/joinoperator.md](./descriptions/joinoperator.md)]

## Members
Members define the discrete options for the enumeration type.
|Name|Value|Description|
|---|---|---|
|Inner|0|The values in the attributes being joined are compared using a comparison operator. | 
|LeftOuter|1|All instances of the entity in the FROM clause are returned if they meet WHERE or HAVING search conditions.| 
|Natural|2|Only one value of the two joined attributes is returned if an equal-join operation is performed and the two values are identical. | 

## Used by
The following use the JoinOperator enum type.
|Name|How used|Description|
|---|---|---|
|[LinkEntity ComplexType](../complextypes/linkentity.md)|Property|[!INCLUDE[../complextypes/descriptions/linkentity.md](../complextypes/descriptions/linkentity.md)]|

[!INCLUDE[./remarks/joinoperator.md](./remarks/joinoperator.md)]

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