---
title: "Sample: Calculate Price plug-in (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Sample demonstrates how to write a plug-in that calculates the pricing of the opportunities, quotes, orders, and invoices based on your custom code."
keywords: 
ms.date: 10/31/2017
ms.service: crm-online
ms.custom: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 683204f7-570a-43ab-bf7e-a12d26cec214
author: KumarVivek
ms.author: kvivek
manager: jdaly
ms.reviewer: pehecke
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 12
topic-status: Drafting
search.audienceType: 
  - developer

---

# Sample: Calculate Price plug-in

This sample code is for Dynamics 365 Customer Engagement(on-premises). Download the sample: [Work with custom price plug-in](/previous-versions/dynamicscrm-2016/developers-guide/dn817877(v=crm.8)).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../includes/sdk-prerequisite.md)]

## Requirements  
 Ensure the following:  
  
-   Set the value of the `Organization.OOBPriceCalculationEnabled` attribute to `0` (false).  
  
-   Register the plug-in on the **CalculatePrice** message, **Post-operation** event stage, and **Synchronous** execution mode. For more information, see [Register and Deploy Plug-ins](register-deploy-plugins.md).  
  
## Demonstrates  
 This sample shows how to write a plug-in that calculates the pricing of the opportunities, quotes, orders, and invoices based on your custom code. The discounts and taxes are calculated based on the total amount of all the product line items in an opportunity, quote, order, or invoice:  
  
- **Discount**: If the total amount is greater than 1000 and less than 5000, discount is 5%; if the total amount is 5000 or greater, discount is 10%.  
  
- **Tax**: Tax is applied on the amount that is effective after the discount is applied (total amount minus discount). If the effective amount is less than 5000, tax is 10%; otherwise, tax is 8%.  
  
  For more information, see [Use custom pricing for products](use-custom-pricing-products.md).  
  
## Example  
 [!code-csharp[Plug-Ins#CalculatePricePlugin](../snippets/csharp/CRMV8/plug-ins/cs/calculatepriceplugin.cs#calculatepriceplugin)]  
  
### See also  
 [Use custom pricing for products](use-custom-pricing-products.md)   
 [Create and manage product families, products and bundles](create-manage-product-families-products-bundles-product-properties.md)   
 [Product catalog entities](product-catalog-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]