---
title: "ConditionExpression ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 186ea866-25b3-4605-8874-6f4a5e4d1b46
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ConditionExpression ComplexType
[!INCLUDE[./descriptions/conditionexpression.md](./descriptions/conditionexpression.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|EntityName|Edm.String|true|false|The entity name for the condition.| 
|AttributeName|Edm.String|true|false|The logical name of the attribute in the condition expression.| 
|Operator|[ConditionOperator EnumType](../enumtypes/ConditionOperator.md)|true|true|The condition operator. | 
|Values|Collection([Object ComplexType](../complextypes/Object.md))||true|The values for the attribute. | 

## Used by
The following use the ConditionExpression ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[FilterExpression ComplexType](../complextypes/filterexpression.md)|Property|[!INCLUDE[../complextypes/descriptions/filterexpression.md](../complextypes/descriptions/filterexpression.md)]|

[!INCLUDE[./remarks/conditionexpression.md](./remarks/conditionexpression.md)]

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