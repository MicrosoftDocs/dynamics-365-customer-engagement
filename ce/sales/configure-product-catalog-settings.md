---
title: Configure product catalog settings
description: Configure settings to change seller experience when selecting products from catalog.
ms.date: 10/28/2024
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/16/2023
---
# Configure product catalog settings

Configure the settings to change the seller experience while selecting products from the catalog.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Configure the settings

You can configure the product catalog settings to change the experience sellers have when they select products from the catalog. For example, you can choose whether they must select a price list when creating an opportunity, quote, invoice, or order.

To allow a security role to create products, you must assign the **Create** permission for the **Product** entity to the security role. Products can only be created at the organization-level. Even if you set the security role permissions to user level for the **Product** entity, products will be created at the organization level.


**To configure the product catalog settings**

1. In the Sales Hub app, select **Change area** ![Icon to change the work area.](media/change-area-icon.png "Icon to change the work area") in the lower-left corner, and then select **App Settings**.

2. Under **Product Catalog**, select **Product Catalog Settings**.

3. On the **Product catalog settings** page, set the appropriate values as described in the following table, and then save the changes.

[!INCLUDE [add-products-experience-on-mobile](../includes/add-products-experience-on-mobile.md)]

| **Setting** | **Description** |
|-------------------------|-------------------------|
| **Enhanced experience for adding products** | Turn on this option to enable the enhanced **Add products** dialog box that sellers can use to efficiently search, compare, and select products while they're creating an opportunity, quote, invoice, or order. </br> When you turn on this option, you'll see additional customization options you can use to customize the information you need in the **Add products** dialog box. You can either add more columns to the dialog box or add more information to the **Product** column. More information: [Preview: Customize the Add products dialog box](customize-add-products-dialog-box.md). |
| **Create product in active state** | Turn on this option to set the products to the `active` state upon creation. This option applies only to products that don't have a parent product family. To create products in the `draft` state, turn this option off. |
| **Allow selection of default pricelist** | Turn on this option if you want the default price list to be selected for an opportunity based on the inbuilt rule (that is, using the default price lists that have been defined for territories). Otherwise, turn this option off. |
| **System pricing calculation** | Turn on this option to use the system pricing engine to calculate prices for opportunities, quotes, orders, and invoices. Turn the option off to use custom pricing. More information: [Use custom pricing for products](developer/use-custom-pricing-products.md)  |
| **Make price list optional** | Turn on this option if you want to allow sellers to add products to opportunities, quotes, invoices, or orders without associating a price list. |
| **Max number of products in a bundle** | Specify the maximum number of products that can be added in a bundle.</br>**Default**: 15 |
| **Max number of properties of a product or bundle** | Specify the maximum number of properties that can be associated with a product or bundle.<br /></br>Product properties are added to the product family record, and all the child products and bundles under the product family inherit the properties added to the parent product family.</br>**Note:** The number specified in this setting comes into effect only when you publish a product or a bundle with the associated properties, and not at the time when you add the properties to a draft product family record.</br>**Default**: 50 | 
| **Discount calculation method** | Select **Per unit** if you want the pricing engine to calculate the discount based on the price per unit instead of a line item. By default, calculations are done on a line-item basis. See the following table. |

The following table shows the difference between discounts calculated for a line item versus price per unit.

|Discount<br>method|Product|Price per unit|Quantity|Discount|Amount|  
|---------------------|-------------|--------------------|--------------|--------------|------------|  
|Line item|Product 1|100|11|10|(100 &times; 11) &minus; 10 = 1,090|  
|Per unit|Product 2|100|11|10|(100 &minus; 10) &times; 11 = 990| 

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Set up a product catalog](set-up-product-catalog-walkthrough.md)  
[Enable the enhanced experience of adding products (Sales Hub)](enable-enhanced-add-product-experience.md)  


