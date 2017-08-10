---
title: "OrderExpression ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: bad0ed0c-af0c-4b7b-bf6e-4a6cf17f0f2a
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# OrderExpression ComplexType
[!INCLUDE[./descriptions/orderexpression.md](./descriptions/orderexpression.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|AttributeName|Edm.String|true|false|The name of the attribute in the order expression.| 
|OrderType|[OrderType EnumType](../enumtypes/OrderType.md)|true|true|The order, ascending or descending.| 

## Used by
The following use the OrderExpression ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[QueryExpression ComplexType](../complextypes/queryexpression.md)|Property|[!INCLUDE[../complextypes/descriptions/queryexpression.md](../complextypes/descriptions/queryexpression.md)]|
|[LinkEntity ComplexType](../complextypes/linkentity.md)|Property|[!INCLUDE[../complextypes/descriptions/linkentity.md](../complextypes/descriptions/linkentity.md)]|

[!INCLUDE[./remarks/orderexpression.md](./remarks/orderexpression.md)]

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