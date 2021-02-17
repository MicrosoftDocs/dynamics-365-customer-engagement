---
title: "Sample: Fulfill a sales order (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The sample demonstrates how to create a sales order and then close it by fulfilling it."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
helpviewer_keywords: 
  - order entities sample, creating and closing sales orders
  - sample for creating and closing sales orders, order entities sample
ms.assetid: 21eb9416-6c1f-468e-98f6-96d098d23051
caps.latest.revision: 13
author: JimDaly
ms.author: jdaly
manager: amyla
search.audienceType: 
  - developer

---
# Sample: Fulfill a sales order

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample here [Business management samples](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/BusinessManagement). 

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]
   
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create a sales order and then close it by fulfilling it.  
  
## Example  
 [!code-csharp[BusinessManagement#FulfillSalesOrder](../snippets/csharp/CRMV8/businessmanagement/cs/fulfillsalesorder.cs#fulfillsalesorder)]  
  
### See also  
 [Sales Entities (Lead, Opportunity, Competitor, Quote, Order, Invoice)](sales-entities-lead-opportunity-competitor-quote-order-invoice.md)   
 [Quote, order, and invoice entities](quote-order-invoice-entities.md)   
 <xref:Microsoft.Crm.Sdk.Messages.FulfillSalesOrderRequest>


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]