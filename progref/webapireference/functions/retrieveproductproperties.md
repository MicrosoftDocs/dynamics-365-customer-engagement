---
title: "RetrieveProductProperties Function| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 759ef479-77df-4101-87f1-7cf442e3e753
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# RetrieveProductProperties Function
[!INCLUDE[./descriptions/retrieveproductproperties.md](./descriptions/retrieveproductproperties.md)]

The RetrieveProductProperties function does not require any parameters.

## Bound Entities 
Bound functions are invoked by appending the function name to the URI representing an entity or collection.
|EntityType|Binding Type|
|----------|-----------------|
|[opportunityproduct Entitytype](../entitytypes/opportunityproduct.md)|entity|
|[quotedetail Entitytype](../entitytypes/quotedetail.md)|entity|
|[salesorderdetail Entitytype](../entitytypes/salesorderdetail.md)|entity|
|[invoicedetail Entitytype](../entitytypes/invoicedetail.md)|entity|



## Return Type
The RetrieveProductProperties function returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|Collection([dynamicproperty EntityType](../entitytypes/dynamicproperty.md))|false|Contains the results from the RetrieveProductProperties function. |

## Entities
Use the RetrieveProductProperties function with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[dynamicpropertyinstance Entitytype](../entitytypes/dynamicpropertyinstance.md)|[!INCLUDE[../entitytypes/descriptions/dynamicpropertyinstance.md](../entitytypes/descriptions/dynamicpropertyinstance.md)]|

[!INCLUDE[./remarks/retrieveproductproperties.md](./remarks/retrieveproductproperties.md)]

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