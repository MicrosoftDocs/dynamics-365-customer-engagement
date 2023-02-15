---
title: "Sample: Process quotes, sales orders, and invoices (Dynamics 365 Sales)"
description: "The sample demonstrates how to convert an opportunity that is won to a quote, then convert a quote to a sales order, and then convert a sales order to an invoice."
ms.custom: 
ms.date: 01/02/2020
ms.reviewer: 

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: sample
applies_to: 
  - Dynamics 365 Sales
helpviewer_keywords: 
  - sales entities sample, converting opportunities to sales orders
  - quote; order; and invoice entities sample, locking and unlocking sales orders and invoice prices
  - sample for converting opportunities to sales orders, sales entities sample
  - sample for locking and unlocking sales orders and invoice prices, quote; order; and invoice entities
ms.assetid: 7cf7de1a-789b-4c87-a6c3-6410a68369a1
author: KumarVivek
ms.author: kvivek
manager: shujoshie
search.audienceType: 
  - developer
---
# Sample: Process quotes, sales orders and invoices

This sample code is for Dynamics 365 Sales. Download the complete sample here [Business management samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/sales/ProcessQuotesSalesOrdersInvoices).   

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
   
## Requirements  

[!INCLUDE [sdk-seeconnectionhelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to convert an opportunity that is won to a quote, then convert a quote to a sales order, and then convert a sales order to an invoice. It also shows how to lock and unlock the sales order and the invoice prices.  
  
## Example  
 [!code-csharp[BusinessManagement#ProcessingQuotesAndSalesOrders](../../snippets/csharp/CRMV8/businessmanagement/cs/processingquotesandsalesorders.cs#processingquotesandsalesorders)]  
  
### See also  
 [Sales Tables (Lead, Opportunity, Competitor, Quote, Order, Invoice)](sales-entities-lead-opportunity-competitor-quote-order-invoice.md)   
 [Quote, Order and Invoice Tables](quote-order-invoice-entities.md)   
 [Sample: Fulfill a Sales Order](sample-fulfill-sales-order.md)   
 <xref:Microsoft.Crm.Sdk.Messages.WinQuoteRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.ConvertQuoteToSalesOrderRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.UnlockSalesOrderPricingRequest>   
 <xref:Microsoft.Crm.Sdk.Messages.LockSalesOrderPricingRequest>


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
