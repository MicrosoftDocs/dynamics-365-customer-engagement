---
title: "Sample: Fulfill a sales order (Dynamics 365 Sales)"
description: "The sample demonstrates how to create a sales order and then close it by fulfilling it."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke

ms.suite: 
ms.tgt_pltfrm: 
ms.topic: sample
applies_to: 
  - Dynamics 365 Sales
helpviewer_keywords: 
  - order entities sample, creating and closing sales orders
  - sample for creating and closing sales orders, order entities sample
ms.assetid: 21eb9416-6c1f-468e-98f6-96d098d23051
caps.latest.revision: 13
author: udaykirang
ms.author: udag
manager: shujoshi
search.audienceType: 
  - developer
---
# Sample: Fulfill a sales order

This sample code is for Dynamics 365 Sales. Download the complete sample here [Business management samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BusinessManagement). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]
   
## Requirements  
[!INCLUDE [sdk-seeconnectionhelper](../../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create a sales order and then close it by fulfilling it.  
  
## Example  
 [!code-csharp[BusinessManagement#FulfillSalesOrder](../../snippets/csharp/CRMV8/businessmanagement/cs/fulfillsalesorder.cs#fulfillsalesorder)]  
  
### See also  
 [Sales Tables (Lead, Opportunity, Competitor, Quote, Order, Invoice)](sales-entities-lead-opportunity-competitor-quote-order-invoice.md)   
 [Quote, order, and invoice tables](quote-order-invoice-entities.md)   
 <xref:Microsoft.Crm.Sdk.Messages.FulfillSalesOrderRequest>


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
