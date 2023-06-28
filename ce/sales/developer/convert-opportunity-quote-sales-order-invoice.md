---
title: Convert an opportunity to a quote, sales order, or invoice (Dynamics 365 Sales)
description: Learn about converting an opportunity to a quote, sales order, or invoice.
ms.date: 03/01/2023
ms.reviewer: lavanyakr
ms.topic: article
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
search.audienceType: 
  - developer

---
# Convert an opportunity to a quote, sales order or invoice

Opportunities, quotes, sales orders, and invoices are all part of the sales process. An opportunity is a possibility to sell products and services to a qualified customer. If an opportunity is won, you may convert it to a quote, or to a sales order or an invoice. The catalog products and write-in products that are included in an opportunity are added to a quote, a sales order, or an invoice during conversion. An opportunity, a quote, a sales order, and an invoice share common data that can be reused in the flow of the sales process. The shared data includes user information, product price and discounts, freight amount, total costs, and tax.  
  
## Converting an Opportunity to a Quote, a Sales Order, or an Invoice  
 The following table lists the messages that you can use to convert an opportunity to a quote, a sales order, or an invoice.  
  
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
  
### See also  
 [Opportunity Tables](opportunity-entities.md)   
 [Creating an Opportunity](create-opportunity.md)   
 [Quote, Order and Invoice Tables](quote-order-invoice-entities.md)   
 [Sales Tables](sales-entities-lead-opportunity-competitor-quote-order-invoice.md)   
 [Opportunity Table](entities/opportunity.md)

[!INCLUDE[footer-include](../../includes/footer-banner.md)]
