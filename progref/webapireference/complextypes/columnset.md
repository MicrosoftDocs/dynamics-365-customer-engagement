---
title: "ColumnSet ComplexType | MicrosoftDocs"
ms.date: 07/10/2017
ms.service: "crm-online"
ms.topic: "reference"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: f70d43cd-d6a6-415e-9d41-8ad37fafbd41
author: "jimdaly"
ms.author: "jdaly"
manager: "jdaly"
---
# ColumnSet ComplexType
[!INCLUDE[./descriptions/columnset.md](./descriptions/columnset.md)]



## Properties
The properties of a complex type contain the structured data of the type.
|Name|Type|Nullable|Unicode|Description| 
|----|----|--------|-------|-----------| 
|AllColumns|Edm.Boolean|true|true|Whether to retrieve all the attributes of a record. | 
|Columns|Collection(Edm.String)||false|The collection of Strings containing the names of the attributes to be retrieved from a query.| 

## Used by
The following use the ColumnSet ComplexType.

|Name|How used|Description| 
|----------|-----------------|-----------------|    
|[ConvertQuoteToSalesOrder Action](../actions/convertquotetosalesorder.md)|Parameter|[!INCLUDE[../actions/descriptions/convertquotetosalesorder.md](../actions/descriptions/convertquotetosalesorder.md)]|
|[ConvertSalesOrderToInvoice Action](../actions/convertsalesordertoinvoice.md)|Parameter|[!INCLUDE[../actions/descriptions/convertsalesordertoinvoice.md](../actions/descriptions/convertsalesordertoinvoice.md)]|
|[GenerateInvoiceFromOpportunity Action](../actions/generateinvoicefromopportunity.md)|Parameter|[!INCLUDE[../actions/descriptions/generateinvoicefromopportunity.md](../actions/descriptions/generateinvoicefromopportunity.md)]|
|[GenerateQuoteFromOpportunity Action](../actions/generatequotefromopportunity.md)|Parameter|[!INCLUDE[../actions/descriptions/generatequotefromopportunity.md](../actions/descriptions/generatequotefromopportunity.md)]|
|[GenerateSalesOrderFromOpportunity Action](../actions/generatesalesorderfromopportunity.md)|Parameter|[!INCLUDE[../actions/descriptions/generatesalesorderfromopportunity.md](../actions/descriptions/generatesalesorderfromopportunity.md)]|
|[ReviseQuote Action](../actions/revisequote.md)|Parameter|[!INCLUDE[../actions/descriptions/revisequote.md](../actions/descriptions/revisequote.md)]|
|[RetrieveEntityChanges Function](../functions/retrieveentitychanges.md)|Parameter|[!INCLUDE[../functions/descriptions/retrieveentitychanges.md](../functions/descriptions/retrieveentitychanges.md)]|
|[QueryExpression ComplexType](../complextypes/queryexpression.md)|Property|[!INCLUDE[../complextypes/descriptions/queryexpression.md](../complextypes/descriptions/queryexpression.md)]|
|[LinkEntity ComplexType](../complextypes/linkentity.md)|Property|[!INCLUDE[../complextypes/descriptions/linkentity.md](../complextypes/descriptions/linkentity.md)]|

[!INCLUDE[./remarks/columnset.md](./remarks/columnset.md)]

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