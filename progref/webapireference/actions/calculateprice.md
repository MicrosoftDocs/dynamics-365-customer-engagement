---
title: "CalculatePrice Action| MicrosoftDocs"
ms.date: "2017-07-10"
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: dce4b9bf-9787-4ea2-a477-e546fe06e4b7
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# CalculatePrice Action
[!INCLUDE[./descriptions/calculateprice.md](./descriptions/calculateprice.md)]

The CalculatePrice action:
* Is not bound to any entity types.
* Does not return a value.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|Target|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|true|For internal use only. |
|ParentId|Edm.Guid|true|true|For internal use only.|



## Entities
Use the CalculatePrice action with the following entity types:
|EntityType |Description| 
|----------|-----------------|    
|[invoice Entitytype](../entitytypes/invoice.md)|[!INCLUDE[../entitytypes/descriptions/invoice.md](../entitytypes/descriptions/invoice.md)]|
|[invoicedetail Entitytype](../entitytypes/invoicedetail.md)|[!INCLUDE[../entitytypes/descriptions/invoicedetail.md](../entitytypes/descriptions/invoicedetail.md)]|
|[opportunity Entitytype](../entitytypes/opportunity.md)|[!INCLUDE[../entitytypes/descriptions/opportunity.md](../entitytypes/descriptions/opportunity.md)]|
|[opportunityproduct Entitytype](../entitytypes/opportunityproduct.md)|[!INCLUDE[../entitytypes/descriptions/opportunityproduct.md](../entitytypes/descriptions/opportunityproduct.md)]|
|[quote Entitytype](../entitytypes/quote.md)|[!INCLUDE[../entitytypes/descriptions/quote.md](../entitytypes/descriptions/quote.md)]|
|[quotedetail Entitytype](../entitytypes/quotedetail.md)|[!INCLUDE[../entitytypes/descriptions/quotedetail.md](../entitytypes/descriptions/quotedetail.md)]|
|[salesorder Entitytype](../entitytypes/salesorder.md)|[!INCLUDE[../entitytypes/descriptions/salesorder.md](../entitytypes/descriptions/salesorder.md)]|
|[salesorderdetail Entitytype](../entitytypes/salesorderdetail.md)|[!INCLUDE[../entitytypes/descriptions/salesorderdetail.md](../entitytypes/descriptions/salesorderdetail.md)]|

[!INCLUDE[./remarks/calculateprice.md](./remarks/calculateprice.md)]

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