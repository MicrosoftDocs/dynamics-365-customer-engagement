---
title: Convert an opportunity to a quote, sales order, or invoice
description: Learn about converting an opportunity to a quote, sales order, or invoice.
ms.date: 04/30/2026
ms.topic: how-to
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.audienceType: 
  - developer

---

# Convert an opportunity to a quote, sales order, or invoice

Opportunities, quotes, sales orders, and invoices are all part of the sales process. An opportunity is a possibility to sell products and services to a qualified customer. If you win an opportunity, you can convert it to a quote, sales order, or invoice. During conversion, the catalog products and write-in products that are included in an opportunity are added to a quote, sales order, or invoice. An opportunity, a quote, a sales order, and an invoice share common data that you can reuse in the flow of the sales process. The shared data includes user information, product price and discounts, freight amount, total costs, and tax.  
  
## Converting an Opportunity to a Quote, a Sales Order, or an Invoice

 The following table lists the messages that you can use to convert an opportunity to a quote, sales order, or invoice.  
  
|Message|Description|  
|-------------|-----------------|  
|<xref:Microsoft.Crm.Sdk.Messages.GenerateQuoteFromOpportunityRequest>|Generates a quote from an opportunity.|  
|<xref:Microsoft.Crm.Sdk.Messages.GenerateSalesOrderFromOpportunityRequest>|Generates a sales order from an opportunity.|  
|<xref:Microsoft.Crm.Sdk.Messages.GenerateInvoiceFromOpportunityRequest>|Generates an invoice from an opportunity.|  
  
## Copying Products from an Opportunity to a Quote, a Sales Order, or on Invoice

 The following table lists the messages that you can use to add products from a new opportunity to existing quotes, invoices, or sales orders.  
  
|Message|Description|  
|-------------|-----------------|  
|<xref:Microsoft.Crm.Sdk.Messages.GetQuoteProductsFromOpportunityRequest>|Retrieves the products from an opportunity and copies them to the specified quote.|  
|<xref:Microsoft.Crm.Sdk.Messages.GetSalesOrderProductsFromOpportunityRequest>|Retrieves the products from an opportunity and copies them to the specified sales order.|  
|<xref:Microsoft.Crm.Sdk.Messages.GetInvoiceProductsFromOpportunityRequest>|Retrieves the products from an opportunity and copies them to the specified invoice.|  
  
## Related information

 [Opportunity Tables](opportunity-entities.md)   
 [Creating an Opportunity](create-opportunity.md)   
 [Quote, Order and Invoice Tables](quote-order-invoice-entities.md)   
 [Sales Tables](sales-entities-lead-opportunity-competitor-quote-order-invoice.md)   
 [Opportunity table](../../developer/reference/entities/opportunity.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
