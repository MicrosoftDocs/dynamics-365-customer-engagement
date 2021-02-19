---
title: "System Settings dialog box - Sales tab  | MicrosoftDocs"
description: "Learn about the system-level settings for Dynamics 365 Sales."
ms.date: 04/17/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# System Settings dialog box - Sales tab

Learn about the system-level settings for Dynamics 365 Sales.  
  
 
1. Make sure that you have the System Administrator or System Customizer security role or equivalent permissions.  
  
2. In your app, select the **Settings** icon, and then select **Advanced Settings**.

    > [!div class="mx-imgBorder"]  
    > ![Advanced Settings link in the site map](media/advanced-settings-option.png "Advanced Settings link in the site map")

    The **Business Management settings** page opens in a new browser tab.

3. On the navigation bar, select **Settings**, and then under **System**, select **Administration**.

4. Select **System Settings**.

  
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
 [Create price lists and price list items to define pricing of products](create-price-lists-price-list-items-define-pricing-products.md)   
 [Set up a discount list](set-up-discount-list.md)   
 [Create product bundles to sell multiple items together](create-product-bundles-sell-multiple-items-together.md)   
 [Use properties to describe a product](use-properties-describe-product.md)  
 [Administrator and Sales Manager Guide](admin-guide.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]