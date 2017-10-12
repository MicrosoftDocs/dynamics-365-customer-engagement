---
title: "FilterExpression ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: df44b2e1-d78b-446a-be13-c5da5a1ba051
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# FilterExpression ComplexType
[!INCLUDE[./descriptions/filterexpression.md](./descriptions/filterexpression.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|FilterOperator|[LogicalOperator EnumType](../enumtypes/LogicalOperator.md)|true|true|The logical AND/OR filter operator. | 
|FilterHint|Edm.String|true|false|TODO: Add description for FilterExpression.FilterHint property.| 
|Conditions|Collection([ConditionExpression ComplexType](../complextypes/ConditionExpression.md))||true|Condition expressions that include attributes, condition operators, and attribute values.| 
|Filters|Collection([FilterExpression ComplexType](../complextypes/FilterExpression.md))||true|A collection of condition and logical filter expressions that filter the results of the query. | 
|IsQuickFindFilter|Edm.Boolean|true|true|Indicates whether the expression is part of a quick find query. | 

## Used by
The following use the FilterExpression ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[QueryExpression ComplexType](../complextypes/queryexpression.md)|Property|[!INCLUDE[../complextypes/descriptions/queryexpression.md](../complextypes/descriptions/queryexpression.md)]|
|[FilterExpression ComplexType](../complextypes/filterexpression.md)|Property|[!INCLUDE[../complextypes/descriptions/filterexpression.md](../complextypes/descriptions/filterexpression.md)]|
|[LinkEntity ComplexType](../complextypes/linkentity.md)|Property|[!INCLUDE[../complextypes/descriptions/linkentity.md](../complextypes/descriptions/linkentity.md)]|

[!INCLUDE[./remarks/filterexpression.md](./remarks/filterexpression.md)]

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