---
title: Quote, order, and invoice tables (Dynamics 365 Sales)
description: Learn about quote, sales order (order), and invoice building.
ms.date: 01/28/2025
ms.topic: concept-article
author: udaykirang
ms.author: udag
ms.reviewer: udag
search.audienceType: 
  - developer

---
# Quote, order, and invoice tables

Dynamics 365 Sales supports robust *quote*, *sales order (order)*, and *invoice* building. You can build a quote by selecting products directly from the product catalog, specifying the price list (such as wholesale or retail), and entering the requested number of units. If you have permission, you can also apply discounts. Multiple pricing models are supported, such as wholesale versus retail, and discounting can be done by line item based on volume or manual override. In addition, overall discounts can be applied to the whole quote.  
  
 A quote is a formal offer for products or services proposed at specific prices and related payment terms that are sent to a prospective customer. You can create a quote, save it as a draft, and specify whether it's active (presented to the customer) or closed (completed, either as an order or not). A quote can have a due date (when it was promised to the customer), effective dates (when it must be accepted or rejected by), and the requested delivery dates. In addition, a quote can contain many "ship to" addresses (by line item) or a "will call" setting for items to be picked up by the customer.  
  
 If a quote is created from an opportunity, Dynamics 365 Sales uses the products associated with the opportunity as the basis for the draft. When a quote is converted to an order, the user can keep the opportunity open or close it. If the user closes it, the final revenue amount is recorded.  
  
 A quote can be associated with the following tables:  
  
- One or more products and one price list  
  
- One or more competitors  
  
- An opportunity  
  
- A customer  
  
- One or more notes and attachments  
  
- One or more customer addresses  
  
  The `quote detail (quote product)` entity represents a line item in a quote. Each quote can have multiple quote detail (quote product) records.  
  
  The `quote close activity` entity represents an activity that is generated when a quote is closed.  
  
  A sales order (entity name: order) is a quote that has been accepted. When the order is fulfilled, you close the order and mark the status as fulfilled. More information: [Sample: Fulfill a sales order](sample-fulfill-sales-order.md)

  > [!NOTE]
  > You can't set the status of multiple orders to fulfilled at one go. 

  An invoice is an order that has been billed.  
  
## Related information  

 [Quote table](../../developer/reference/entities/quote.md)   
 [Quote Product (QuoteDetail) table](../../developer/reference/entities/quotedetail.md)   
 [Quote Close (QuoteClose) table](../../developer/reference/entities/quoteclose.md)   
 [Order (SalesOrder) table](../../developer/reference/entities/salesorder.md)   
 [Order Product (SalesOrderDetail) table](../../developer/reference/entities/salesorderdetail.md)   
 [Order Close (OrderClose) table](../../developer/reference/entities/orderclose.md)   
 [Invoice table](../../developer/reference/entities/invoice.md)   
 [Invoice Product (InvoiceDetail) table](../../developer/reference/entities/invoicedetail.md)   
 [Sample: Set Negative Prices in Opportunities, Quotes, and Sales Orders](sample-set-negative-prices-opportunities-quotes-sales-orders.md)   
 [Sample: Process Quotes, Sales Orders and Invoices](sample-process-quotes-sales-orders-invoices.md)   
 [Sample: Fulfill a Sales Order](sample-fulfill-sales-order.md)   
 [Opportunity Tables](opportunity-entities.md)   
 [Sales Tables](sales-entities-lead-opportunity-competitor-quote-order-invoice.md)   
 [Set default price level for opportunity, quote, order, invoice](set-default-price-level-for-opportunity-quote-order-invoice.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
