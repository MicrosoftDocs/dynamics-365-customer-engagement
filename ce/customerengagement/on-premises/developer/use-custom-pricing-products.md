---
title: "Use custom pricing for products (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "Use the CalculatePrice message to define custom pricing for products in opportunities, quotes, orders and invoices."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: b54fd2ea-811d-4b83-8638-86dd87038fd7
caps.latest.revision: 13
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer

---
# Use custom pricing for products

The pricing engine in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] supports a standard set of pricing and discounting methods, which might be limiting to your business depending on your specific requirements for applying taxation, discounts, and other pricing rules for your products. If you want to define custom pricing for your products in opportunities, quotes, orders and invoices, you can use the `CalculatePrice` message.  
  
 To use the custom pricing for your opportunities, quotes, orders, and invoices:  
  
1. Set the value of the `Organization.OOBPriceCalculationEnabled` attribute to `0` (false). You can also use the **Sales** tab in the system settings area in [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] or [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)] to disable system pricing. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure product catalog information](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn832125(v=crm.8))  
  
2. Create a plug-in that contains your custom pricing code for calculating the price for your opportunity, quote, order, or invoice.  
  
3. Register the plug-in on the `CalculatePrice` message.  
  
   When the `Organization.OOBPriceCalculationEnabled` attribute is set to `0`, every time an opportunity, quote, order, or invoice is created or changes, the plug-in registered on the `CalculatePrice` executes to calculate prices as specified in your custom code in the plug-in. The <xref:Microsoft.Crm.Sdk.Messages.CalculatePriceRequest> message doesn’t have any usage scenario of its own. It’s exposed so that you can plug in your own custom pricing calculation logic if you don’t want to use the out-of-box pricing provided by [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)].  
  
   For a sample plug-in that calculates custom pricing for opportunities, quotes, orders, and invoices, see [Sample: Calculate Price plug-in](sample-calculate-price-plugin.md).  
  
   If you want to revert to using the out-of-box pricing for your opportunities, quotes, orders, and invoices, set the value of the `Organization.OOBPriceCalculationEnabled` attribute to `1` (true). You can also use the **Sales** tab in the system settings area in [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] or [!INCLUDE[pn_crm_for_outlook_short](../includes/pn-crm-for-outlook-short.md)] to enable system pricing. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Configure product catalog information](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn832125(v=crm.8))  
  
### See also  
 [Product pricing methods](product-pricing-methods.md)   
 [Sample: Calculate Price plug-in](sample-calculate-price-plugin.md)   
 [Product catalog entities](product-catalog-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]