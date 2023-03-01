---
title: Product discounting methods (Dynamics 365 Sales)
description: "The Organization.DiscountCalculationMethod column specifies the discount method: either line item or unit level."
ms.date: 03/01/2023
ms.reviewer: lavanyakr
ms.topic: article
applies_to: 
  - Dynamics 365 Sales
author: udaykirang
ms.author: udag
manager: shujoshi
search.audienceType: 
  - developer

---
# Product discounting methods

Discounts can be applied either at the line item level or at per unit level. Use the `Organization.DiscountCalculationMethod` column to specify the discount method. Set the value of the column to:  
  
- **0** for discounting at line item level  
  
- **1** for discounting at per unit level  
  
  You can also use the **Sales** tab in the system settings area in the Dynamics 365 Sales or [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../includes/pn-microsoft-dynamics-crm-for-outlook.md)] to specify the discount calculation method. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Manage product catalog configuration](/previous-versions/dynamicscrm-2016/administering-dynamics-365/dn832125(v=crm.8))  
  
  To illustrate the discounting model with an example, consider the following product line item entry in an opportunity:  
  
|Product Name|Price Per Unit|Quantity|Discount|Extended Amount|  
|------------------|--------------------|--------------|--------------|---------------------|  
|Example Product|100|200|10|?|  
  
 **Extended Amount** for the product line item entry is calculated depending on your selected discounting model:  
  
- **Line item**: The discount applied is 10, and the **Extended Amount** is 19990 ((Price Per Unit * Quantity) – discount applied).  
  
- **Per unit**: The discount applied is 2000 (Quantity * Discount), and the **Extended Amount** is 18000 ((Price Per Unit * Quantity) – discount applied).  
  
> [!NOTE]
>  If you upgrade from a previous version of Dynamics 365 Sales to the current version, by default the value of the `Organization.DiscountCalculationMethod` column is set to **0** (line item) to support the old discounting behavior where discounts could only be applied at the line level.  
  
### See also

 [Discount Table](entities/discount.md)   
 [DiscountType Table](entities/discounttype.md)   
 [Product catalog tables](product-catalog-entities.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]