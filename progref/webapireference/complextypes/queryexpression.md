---
title: "QueryExpression ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 1fafe641-bea4-4033-869c-593539b5a497
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# QueryExpression ComplexType
[!INCLUDE[./descriptions/queryexpression.md](./descriptions/queryexpression.md)]

This Web API complex type inherits from [QueryBase ComplexType](../complextypes/QueryBase.md).

## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|Distinct|Edm.Boolean|true|true|Whether the results of the query contain duplicate entity instances.| 
|NoLock|Edm.Boolean|true|true|Indicates that no shared locks are issued against the data that would prohibit other transactions from modifying the data in the records returned from the query. | 
|PageInfo|[PagingInfo ComplexType](../complextypes/PagingInfo.md)|true|true|The number of pages and the number of entity instances per page returned from the query. | 
|LinkEntities|Collection([LinkEntity ComplexType](../complextypes/LinkEntity.md))||true|A collection of the links between multiple entity types.| 
|Criteria|[FilterExpression ComplexType](../complextypes/FilterExpression.md)|true|true|The complex condition and logical filter expressions that filter the results of the query.| 
|Orders|Collection([OrderExpression ComplexType](../complextypes/OrderExpression.md))||true|The order in which the entity instances are returned from the query. | 
|EntityName|Edm.String|true|false|The logical name of the entity. | 
|ColumnSet|[ColumnSet ComplexType](../complextypes/ColumnSet.md)|true|true|The columns to include.| 
|TopCount|Edm.Int32|true|true|The number of rows to be returned. | 

## Used by
The following use the QueryExpression ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[BulkDelete Action](../actions/bulkdelete.md)|Parameter|[!INCLUDE[../actions/descriptions/bulkdelete.md](../actions/descriptions/bulkdelete.md)]|
|[FetchXmlToQueryExpressionResponse ComplexType](../complextypes/fetchxmltoqueryexpressionresponse.md)|Property|[!INCLUDE[../complextypes/descriptions/fetchxmltoqueryexpressionresponse.md](../complextypes/descriptions/fetchxmltoqueryexpressionresponse.md)]|

[!INCLUDE[./remarks/queryexpression.md](./remarks/queryexpression.md)]

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