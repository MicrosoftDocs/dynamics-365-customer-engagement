---
title: "GenerateInvoiceFromOpportunity Action| MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to:
  - "Dynamics 365 (online)"
ms.assetid: 1b3fa6be-ca85-4beb-8519-a75b41c8a341
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# GenerateInvoiceFromOpportunity Action
[!INCLUDE[./descriptions/generateinvoicefromopportunity.md](./descriptions/generateinvoicefromopportunity.md)]

The GenerateInvoiceFromOpportunity action is not bound to any entity types.



## Parameters 
Parameters allow for data to be passed to the action.
|Name|Type|Nullable|Unicode|Description|
|----------|-----------------|----------|-----------------|-----------------|  
|OpportunityId|Edm.Guid|false|true|ID of the opportunity to be used as the basis for the new invoice. |
|ColumnSet|[ColumnSet ComplexType](../complextypes/ColumnSet.md)|true|true|Collection of attributes to retrieve from the resulting invoice.|

## Return Type
The GenerateInvoiceFromOpportunity action returns the following value.
|Type|Nullable|Description| 
|----------|-----------------|-----------------|    
|[crmbaseentity EntityType](../entitytypes/crmbaseentity.md)|false|Contains the response from the GenerateInvoiceFromOpportunity Action.|

## Entities
Use the GenerateInvoiceFromOpportunity action with this entity type:
|EntityType |Description| 
|----------|-----------------|    
|[invoice Entitytype](../entitytypes/invoice.md)|[!INCLUDE[../entitytypes/descriptions/invoice.md](../entitytypes/descriptions/invoice.md)]|

[!INCLUDE[./remarks/generateinvoicefromopportunity.md](./remarks/generateinvoicefromopportunity.md)]

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