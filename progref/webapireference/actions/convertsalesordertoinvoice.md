---
title: "ConvertSalesOrderToInvoice Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 7ecfa2c6-d4c8-470d-9e5d-ff96e97140af
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ConvertSalesOrderToInvoice Action
[!INCLUDE[./descriptions/convertsalesordertoinvoice.md](./descriptions/convertsalesordertoinvoice.md)]

The ConvertSalesOrderToInvoice action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|SalesOrderId|Edm.Guid|false|true|The ID of the sales order (order) to convert. |
|ColumnSet|[ColumnSet ComplexType](../complextypes/ColumnSet.md)|true|true|Collection of attributes to retrieve from the resulting invoice.|
|ProcessInstanceId|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|true|true|TODO: Add description for ConvertSalesOrderToInvoice ProcessInstanceId parameter.|

## Return Type
The ConvertSalesOrderToInvoice action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[invoice EntityType](../entitytypes/invoice.md)|false|Contains the response from ConvertSalesOrderToInvoice action. |

## Entities
Use the ConvertSalesOrderToInvoice action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[salesorder Entitytype](../entitytypes/salesorder.md)|[!INCLUDE[../entitytypes/descriptions/salesorder.md](../entitytypes/descriptions/salesorder.md)]|

[!INCLUDE[./remarks/convertsalesordertoinvoice.md](./remarks/convertsalesordertoinvoice.md)]

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