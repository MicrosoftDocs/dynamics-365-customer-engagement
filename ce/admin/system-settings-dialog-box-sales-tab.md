---
title: "System Settings dialog box - Sales tab for Dynamics 365 Customer Engagement | MicrosoftDocs"
ms.custom: ""
ms.date: 09/30/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
  - "Dynamics 365 Version 9.x"
ms.assetid: 08b3057d-03ad-41d0-a6b3-4770add682b2
caps.latest.revision: 14
author: "jimholtz"
ms.author: "jimholtz"
manager: "brycho"
---
# System Settings dialog box - Sales tab

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Use the settings on this page to configure system-level settings for the sales area of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)].  
  
 
1. [!INCLUDE[proc_permissions_system_admin_and_customizer](../includes/proc-permissions-system-admin-and-customizer.md)]  
  
    Check your security role  
  
    - [!INCLUDE[proc_follow_steps_in_link](../includes/proc-follow-steps-in-link.md)]  
  
2. [!INCLUDE[proc_settings_administration](../includes/proc-settings-administration.md)]  
  
3.  Click **System Settings** and then select the **Sales** tab.  

|Settings|Description|  
|--------------|-----------------|  
|**Select whether products should be created in the active state**||
|Create products in active state|To set the products to active state by default after creation, click **Yes**. This option applies only to products that don’t have a parent product family. To create products in the Draft state, click **No**.  |
|**Set whether the default pricelist for an opportunity should be selected via an inbuilt rule**||
|Allow selection of default pricelist for opportunity via inbuilt rule|Click **Yes** if you want the default price list to be selected for an opportunity based on the inbuilt rule (based on the default price lists defined for territories). Otherwise, click **No**.  |
|**Set maximum number of products in a bundle**||
|Maximum number of products in a bundle|Type the maximum number of products a bundle can have.  |
|**Set pricing calculation preference**||
|Use system pricing calculations|Click **Yes** to use the pricing calculations of [!INCLUDE[pn_microsoftcrm](../includes/pn-microsoftcrm.md)]. To use custom pricing by using a plug-in, click **No**. When set to **No**, the default pricing calculations won’t be done on opportunity, quote, order and invoice records. |
|**Set whether a discount is applied as a line item or per unit**||
|Discount calculation method|Select **Per unit** if you want the pricing engine to calculate the discount based on the prices per unit instead of a line item. By default, the calculations are done on a line item-basis. *See the table below that shows the difference between the two calculations. |
|**Set maximum number of properties allowed for a product or bundle**||
|Maximum number of properties that are allowed for a product or bundle|Type the maximum number of properties (specifications) a product or bundle can have. Product properties are added to a product family record, and all the child products and bundles under the product family inherit the properties added to the parent product family. The number specified in this setting is applied only when you publish a product or a bundle with the associated properties. |

*Table: Difference between calculations

|Discount method|Product|Price per unit|Quantity|Discount|Amount|  
|---------------------|-------------|--------------------|--------------|--------------|------------|  
|Line item|Product 1|100|11|10|(100*11)-10=1090|  
|Per unit|Product 2|100|11|10|(100-10)*11=990|  
  
  
          


  
### See also  
 [Set up a product catalog: Walkthrough](../sales-enterprise/set-up-product-catalog-walkthrough.md)   
 [Create price lists and price list items to define pricing of products](../sales-enterprise/create-price-lists-price-list-items-define-pricing-products.md)   
 [Set up a discount list](../sales-enterprise/set-up-discount-list.md)   
 [Create product bundles to sell multiple items together](../sales-enterprise/create-product-bundles-sell-multiple-items-together.md)   
 [Use properties to describe a product](../sales-enterprise/use-properties-describe-product.md)
