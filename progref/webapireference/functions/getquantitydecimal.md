---
title: "GetQuantityDecimal Function| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 1df0ff5f-66e9-4871-aac8-6d67196322cc
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# GetQuantityDecimal Function
[!INCLUDE[./descriptions/getquantitydecimal.md](./descriptions/getquantitydecimal.md)]



## Bound Entities 
Bound functions are invoked by appending the function name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[invoice Entitytype](../entitytypes/invoice.md)|entity|
|[opportunity Entitytype](../entitytypes/opportunity.md)|entity|
|[quote Entitytype](../entitytypes/quote.md)|entity|
|[salesorder Entitytype](../entitytypes/salesorder.md)|entity|

## Parameters 
Parameters allow for data to be passed to the function.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Product|[product EntityType](../entitytypes/product.md)|false|true|The product to get the quantity decimal value of.|
|UoM|[uom EntityType](../entitytypes/uom.md)|false|true|The unit of measure (unit). |

## Return Type
The GetQuantityDecimal function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[GetQuantityDecimalResponse ComplexType](../complextypes/GetQuantityDecimalResponse.md)|false|Contains the response from the GetQuantityDecimal function. |



[!INCLUDE[./remarks/getquantitydecimal.md](./remarks/getquantitydecimal.md)]

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