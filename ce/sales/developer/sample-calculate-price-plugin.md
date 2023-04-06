---
title: "Sample: Calculate Price plug-in (Dynamics 365 Sales)"
description: Sample demonstrates how to write a plug-in that calculates the pricing of the opportunities, quotes, orders, and invoices based on your custom code.
ms.date: 03/01/2023
ms.topic: sample
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
ms.reviewer: lavanyakr
search.audienceType: 
  - developer
---

# Sample: Calculate Price plug-in

This sample code is for Dynamics 365 Sales. Download the sample: [Work with custom price plug-in](/previous-versions/dynamicscrm-2016/developers-guide/dn817877(v=crm.8)).

## Prerequisites
[!INCLUDE[sdk-prerequisite](../../includes/sdk-prerequisite.md)]

## Requirements  
 Ensure the following:  
  
-   Set the value of the `Organization.OOBPriceCalculationEnabled` column to `0` (false).  
  
-   Register the plug-in on the **CalculatePrice** message, **Post-operation** event stage, and **Synchronous** execution mode. For more information, see [Register and Deploy Plug-ins](\customerengagement\on-premises\developer\register-deploy-plugins.md).  
  
## Demonstrates  
 This sample shows how to write a plug-in that calculates the pricing of the opportunities, quotes, orders, and invoices based on your custom code. The discounts and taxes are calculated based on the total amount of all the product line items in an opportunity, quote, order, or invoice:  
  
- **Discount**: If the total amount is greater than 1000 and less than 5000, discount is 5%; if the total amount is 5000 or greater, discount is 10%.  
  
- **Tax**: Tax is applied on the amount that is effective after the discount is applied (total amount minus discount). If the effective amount is less than 5000, tax is 10%; otherwise, tax is 8%.  
  
  For more information, see [Use custom pricing for products](use-custom-pricing-products.md).  
  
## Example  
 [!code-csharp[Plug-Ins#CalculatePricePlugin](../../snippets/csharp/CRMV8/plug-ins/cs/calculatepriceplugin.cs#calculatepriceplugin)]  
  
### See also  
 [Use custom pricing for products](use-custom-pricing-products.md)   
 [Create and manage product families, products and bundles](create-manage-product-families-products-bundles-product-properties.md)   
 [Product catalog tables](product-catalog-entities.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]
