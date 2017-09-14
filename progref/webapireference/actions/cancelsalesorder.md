---
title: "CancelSalesOrder Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 4f122b13-c10e-4cd1-818b-e6bd90a2a4e0
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CancelSalesOrder Action
[!INCLUDE[./descriptions/cancelsalesorder.md](./descriptions/cancelsalesorder.md)]

The CancelSalesOrder action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|OrderClose|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|The close activity that is associated with the sales order (order) that is to be cancelled.  |
|Status|Edm.Int32|false|true|Status of the sales order. |



## Entities
Use the CancelSalesOrder action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[contract Entitytype](../entitytypes/contract.md)|[!INCLUDE[../entitytypes/descriptions/contract.md](../entitytypes/descriptions/contract.md)]|
|[salesorder Entitytype](../entitytypes/salesorder.md)|[!INCLUDE[../entitytypes/descriptions/salesorder.md](../entitytypes/descriptions/salesorder.md)]|

[!INCLUDE[./remarks/cancelsalesorder.md](./remarks/cancelsalesorder.md)]

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