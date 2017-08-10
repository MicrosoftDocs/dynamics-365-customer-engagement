---
title: "LinkEntity ComplexType | MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 53055fcf-8742-4aaf-8584-e15693771012
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# LinkEntity ComplexType
[!INCLUDE[./descriptions/linkentity.md](./descriptions/linkentity.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|LinkFromAttributeName|Edm.String|true|false|The logical name of the attribute of the entity that you are linking from.| 
|LinkFromEntityName|Edm.String|true|false|The logical name of the entity that you are linking from. | 
|LinkToEntityName|Edm.String|true|false|The logical name of the entity that you are linking to.| 
|LinkToAttributeName|Edm.String|true|false|The logical name of the attribute of the entity that you are linking to.| 
|JoinOperator|[JoinOperator EnumType](../enumtypes/JoinOperator.md)|true|true|The join operator.| 
|LinkCriteria|[FilterExpression ComplexType](../complextypes/FilterExpression.md)|true|true|The complex condition and logical filter expressions that filter the results of the query.| 
|LinkEntities|Collection([LinkEntity ComplexType](../complextypes/LinkEntity.md))||true|The links between multiple entity types.| 
|Columns|[ColumnSet ComplexType](../complextypes/ColumnSet.md)|true|true|The column set.| 
|EntityAlias|Edm.String|true|false|The alias for the entity. | 
|Orders|Collection([OrderExpression ComplexType](../complextypes/OrderExpression.md))||true|The order expressions to apply to the query.| 

## Used by
The following use the LinkEntity ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[QueryExpression ComplexType](../complextypes/queryexpression.md)|Property|[!INCLUDE[../complextypes/descriptions/queryexpression.md](../complextypes/descriptions/queryexpression.md)]|
|[LinkEntity ComplexType](../complextypes/linkentity.md)|Property|[!INCLUDE[../complextypes/descriptions/linkentity.md](../complextypes/descriptions/linkentity.md)]|

[!INCLUDE[./remarks/linkentity.md](./remarks/linkentity.md)]

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