---
title: "Quote, order, and invoice entities (Developer Guide for Dynamics 365 Customer Engagement (on-premises)) | MicrosoftDocs"
description: "Learn about quote, sales order (order), and invoice building."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
helpviewer_keywords: 
  - sales order (order), definition
  - quote; order; and invoice entities, introduction
  - quote close activity, definition
  - quote, definition
  - invoice, definition
  - order entity, introduction
  - quote detail (quote product), definition
  - invoice entity, introduction
ms.assetid: 1ad567c4-6065-48ab-a277-15fbcc5a9d1a
caps.latest.revision: 21
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Quote, order, and invoice entities

Dynamics 365 Customer Engagement (on-premises) supports robust *quote*, *sales order (order)*, and *invoice* building. You can build a quote by selecting products directly from the product catalog, specifying the price list (such as wholesale or retail), and entering the requested number of units. If you have permission, you can also apply discounts. Multiple pricing models are supported, such as wholesale versus retail, and discounting can be done by line item based on volume or manual override. In addition, overall discounts can be applied to the whole quote.  
  
 A quote is a formal offer for products or services proposed at specific prices and related payment terms that is sent to a prospective customer. You can create a quote, save it as a draft, and specify whether it is active (presented to the customer) or closed (completed, either as an order or not). A quote can have a due date (when it was promised to the customer), effective dates (when it must be accepted or rejected by), and the requested delivery dates. In addition, a quote can contain many "ship to" addresses (by line item) or a "will call" setting for items to be picked up by the customer.  
  
 If a quote is created from an opportunity, Dynamics 365 Customer Engagement (on-premises) will use the products associated with the opportunity as the basis for the draft. When a quote is converted to an order, the user can keep the opportunity open or close it. If the user closes it, the final revenue amount is recorded.  
  
 A quote can be associated with the following entities:  
  
- One or more products and one price list  
  
- One or more competitors  
  
- An opportunity  
  
- A customer  
  
- One or more notes and attachments  
  
- One or more customer addresses  
  
  The `quote detail (quote product)` entity represents a line item in a quote. Each quote can have multiple quote detail (quote product) records.  
  
  The `quote close activity` entity represents an activity that is generated when a quote is closed.  
  
  A sales order (order) is a quote that has been accepted. This entity is called an order in Dynamics 365 Customer Engagement (on-premises).  
  
  An invoice is an order that has been billed.  
  
### See Also  
 [Quote Entity](entities/quote.md)   
 [QuoteDetail Entity](entities/quotedetail.md)   
 [QuoteClose Entity](entities/quoteclose.md)   
 [SalesOrder Entity](entities/salesorder.md)   
 [SalesOrderDetail Entity](entities/salesorderdetail.md)   
 [OrderClose Entity](entities/orderclose.md)   
 [Invoice Entity](entities/invoice.md)   
 [InvoiceDetail Entity](entities/invoicedetail.md)   
 [Sample: Set Negative Prices in Opportunities, Quotes and Sales Orders](sample-set-negative-prices-opportunities-quotes-sales-orders.md)   
 [Sample: Process Quotes, Sales Orders and Invoices](sample-process-quotes-sales-orders-invoices.md)   
 [Sample: Fulfill a Sales Order](sample-fulfill-sales-order.md)   
 [Opportunity Entities](opportunity-entities.md)   
 [Sales Entities](sales-entities-lead-opportunity-competitor-quote-order-invoice.md)   
 [Set default price level for opportunity, quote, order, invoice](set-default-price-level-for-opportunity-quote-order-invoice.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]