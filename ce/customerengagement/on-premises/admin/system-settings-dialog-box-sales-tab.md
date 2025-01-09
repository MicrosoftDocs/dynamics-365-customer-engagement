---
title: "Sales settings tab in Dynamics 365 Customer Engagement (on-premises)"
description: "From the System Settings Sales tab in Dynamics 365 Customer Engagement (on-premises), set preferences related to pricing, product bundles, and more."
keywords: 

ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 08b3057d-03ad-41d0-a6b3-4770add682b2
author: Mattp123
ms.author: matp
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
caps.latest.revision: 14
---
# Customize system settings from the Sales tab

::: moniker range="op-9-1"
[!INCLUDE [cc-use-advanced-settings](../includes/cc-use-advanced-settings.md)]
::: moniker-end

Use the settings on this page to configure system-level settings for the sales area of Dynamics 365 Customer Engagement (on-premises).  
  
 
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    Check your security role  
  
   - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
2. If you are using a Sales web application, go to **Settings** > **Administration** > **System Settings**, and then select the **Sales** tab.

   OR

   If you are using the Sales Hub App, select the Site map icon ![Site map icon](../../../sales/media/site-map-icon.png "Site map icon"), then select ellipsis ![Ellipsis to open more options](../../../sales/media/ellipsis-more-options.png "Ellipsis to open more options") , then select **App Settings**, and then select **Product Catalog Settings**.

  
  |                                            Settings                                             |                                                                                                                                                                                             Description                                                                                                                                                                                              |
|-------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                **Select whether products should be created in the active state**                |                                                                                                                                                                                                                                                                                                                                                                                                      |
|                                 Create products in active state                                 |                                                                                           To set the products to active state by default after creation, click **Yes**. This option applies only to products that don’t have a parent product family. To create products in the Draft state, click **No**.                                                                                           |
| **Set whether the default pricelist for an opportunity should be selected via an inbuilt rule** |                                                                                                                                                                                                                                                                                                                                                                                                      |
|              Allow selection of default pricelist for opportunity via inbuilt rule              |                                                                                                  Click **Yes** if you want the default price list to be selected for an opportunity based on the inbuilt rule (based on the default price lists defined for territories). Otherwise, click **No**.                                                                                                   |
|                         **Set maximum number of products in a bundle**                          |                                                                                                                                                                                                                                                                                                                                                                                                      |
|                             Maximum number of products in a bundle                              |                                                                                                                                                                        Type the maximum number of products a bundle can have.                                                                                                                                                                        |
|                             **Set pricing calculation preference**                              |                                                                                                                                                                                                                                                                                                                                                                                                      |
|                                 Use system pricing calculations                                 |                                                      Click **Yes** to use the pricing calculations of Customer Engagement (on-premises). To use custom pricing by using a plug-in, click **No**. When set to **No**, the default pricing calculations won’t be done on opportunity, quote, order and invoice records.                                                      |
|                **Set whether a discount is applied as a line item or per unit**                 |                                                                                                                                                                                                                                                                                                                                                                                                      |
|                                   Discount calculation method                                   |                                                             Select **Per unit** if you want the pricing engine to calculate the discount based on the prices per unit instead of a line item. By default, the calculations are done on a line item-basis. \*See the table below that shows the difference between the two calculations.                                                              |
|              **Set maximum number of properties allowed for a product or bundle**               |                                                                                                                                                                                                                                                                                                                                                                                                      |
|              Maximum number of properties that are allowed for a product or bundle              | Type the maximum number of properties (specifications) a product or bundle can have. Product properties are added to a product family record, and all the child products and bundles under the product family inherit the properties added to the parent product family. The number specified in this setting is applied only when you publish a product or a bundle with the associated properties. |

*Table: Difference between calculations

|Discount method|Product|Price per unit|Quantity|Discount|Amount|  
|---------------------|-------------|--------------------|--------------|--------------|------------|  
|Line item|Product 1|100|11|10|(100*11)-10=1090|  
|Per unit|Product 2|100|11|10|(100-10)*11=990|  
  
  
          


  
### See also  
 [Set up a product catalog: Walkthrough](../../../sales/set-up-product-catalog-walkthrough.md)   
 [Create price lists and price list items to define pricing of products](../../../sales/create-price-lists-price-list-items-define-pricing-products.md)   
 [Set up a discount list](../../../sales/set-up-discount-list.md)   
 [Create product bundles to sell multiple items together](../../../sales/create-product-bundles-sell-multiple-items-together.md)   
 [Use properties to describe a product](../../../sales/use-properties-describe-product.md)  
 [Administrator and Sales Manager Guide](../../../sales/admin-guide.yml)  


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]
