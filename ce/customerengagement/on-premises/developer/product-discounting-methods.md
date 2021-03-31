---
title: "Product discounting methods (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
description: "The Organization.DiscountCalculationMethod attribute specifies the discount method: either line item or unit level."
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 06c76a25-3bba-4d03-a37b-0f213a7576ca
caps.latest.revision: 11
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer

---
# Product discounting methods

Discounts can be applied either at the line item level or at per unit level. Use the `Organization.DiscountCalculationMethod` attribute to specify the discount method. Set the value of the attribute to:  
  
- **0** for discounting at line item level  
  
- **1** for discounting at per unit level  
  
  You can also use the **Sales** tab in the system settings area in the [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)] or [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../includes/pn-microsoft-dynamics-crm-for-outlook.md)] to specify the discount calculation method. [!INCLUDE[proc_more_information](../includes/proc-more-information.md)] [Manage product catalog configuration](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn832125(v=crm.8))  
  
  To illustrate the discounting model with an example, consider the following product line item entry in an opportunity:  
  
|Product Name|Price Per Unit|Quantity|Discount|Extended Amount|  
|------------------|--------------------|--------------|--------------|---------------------|  
|Example Product|100|200|10|?|  
  
 **Extended Amount** for the product line item entry is calculated depending on your selected discounting model:  
  
- **Line item**: The discount applied is 10, and the **Extended Amount** is 19990 ((Price Per Unit * Quantity) – discount applied).  
  
- **Per unit**: The discount applied is 2000 (Quantity * Discount), and the **Extended Amount** is 18000 ((Price Per Unit * Quantity) – discount applied).  
  
> [!NOTE]
>  If you upgrade from a previous version of [!INCLUDE[pn_crm_shortest](../includes/pn-crm-shortest.md)] to the current version, by default the value of the `Organization.DiscountCalculationMethod` attribute is set to **0** (line item) to support the old discounting behavior where discounts could only be applied at the line level.  
  
### See also

 [Discount Entity](entities/discount.md)   
 [DiscountType Entity](entities/discounttype.md)   
 [Product catalog entities](product-catalog-entities.md)


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]