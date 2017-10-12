---
title: "FulfillSalesOrder Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 8b3528dd-fa7e-48cf-8ea4-44a5da283074
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# FulfillSalesOrder Action
[!INCLUDE[./descriptions/fulfillsalesorder.md](./descriptions/fulfillsalesorder.md)]

The FulfillSalesOrder action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|OrderClose|[orderclose EntityType](../entitytypes/orderclose.md)|false|true|The order close activity associated with the sales order (order) to be fulfilled |
|Status|Edm.Int32|false|true|Status of the sales order (order).  |



## Entities
Use the FulfillSalesOrder action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[salesorder Entitytype](../entitytypes/salesorder.md)|[!INCLUDE[../entitytypes/descriptions/salesorder.md](../entitytypes/descriptions/salesorder.md)]|

[!INCLUDE[./remarks/fulfillsalesorder.md](./remarks/fulfillsalesorder.md)]

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