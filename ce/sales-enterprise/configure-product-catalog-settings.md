---
title: "Configure product catalog settings (Dynamics 365 Sales) | MicrosoftDocs"
description: "Configure the settings to change the seller experience while selecting products from the catalog."
ms.date: 03/17/2021
ms.service: dynamics-365-sales
ms.topic: article
author: lavanyakr01 
ms.author: lavanyakr
manager: shujoshi

---
# Configure product catalog settings

A product catalog includes the list of products and services that your company sells. Sellers choose products from the catalog when they are creating an opportunity, quote, invoice, or order. Configure the product catalog settings to change the seller experience while selecting products from the catalog. For example, you can choose whether the price list selection is mandatory when creating an opportunity, quote, invoice, or order.

**To configure the product catalog settings:**

1.  In the Sales Hub app, select the **Change area** icon
    ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area")
     at the bottom-left of the page and then select **App Settings**.

2.  Under **Product Catalog**, select **Product Catalog Settings**.

3.  In the **Product Catalog Settings** page, set the appropriate values
    for the following settings and save the changes:

| **Setting** | **Description** |
|-------------------------|-------------------------|
| **Adding products (preview)** | Turn on this option to enable the enhanced Add products dialog that lets sellers to efficiently search, compare, and select products while they are creating an opportunity, quote, invoice, or order.</br>When you turn on this option, you will see additional customization options that let you customize the information you need in the **Add products** dialog. You can either add more columns to the dialog or add more information to the Product column. For more information, see [Preview: Customize the Add Products dialog box](customize-add-products-dialog-box.md).</br>  |
| **Create products in active state** | Turn on this option to set the products to `active` state upon creation. This option applies only to products that don't have a parent product family. To create products in the `draft` state, turn it off. |
| **Allow selection of default price list** | Turn on this option if you want the default price list to be selected for an opportunity based on the inbuilt rule (using the default price lists defined for territories). Otherwise, turn it off. |
| **Use system pricing calculation** | Turn on this option to use the system pricing engine to calculate prices for opportunities, quotes, orders, and invoices. Turn it off to use custom pricing. For more information about custom pricing, see [Use custom pricing for products](https://docs.microsoft.com/dynamics365/customerengagement/on-premises/developer/use-custom-pricing-products). |
| **Make pricing list optional** | Turn it on if you want to allow sellers to add products to opportunities, quotes, invoices, or orders, without associating a price list. |
| **Maximum number of products in a bundle** | Specify the maximum number of products that can be added in a bundle.</br>**Default**: 15 |
| **Maximum number of properties that are allowed for a product or bundle** | Specify the maximum number of properties that can be associated with a product or bundle.<br /></br>Product properties are added to a product family record, and all the child products and bundles under the product family inherit the properties added to the parent product family.</br>**Note:** The number specified in this setting comes into effect only when you publish a product or a bundle with the associated properties, and not at the time when you add the properties to a draft product family record.</br>**Default**: 50 |
|  
| **Discount calculation method** | Select **Per unit** if you want the pricing engine to calculate the discount based on the prices per unit instead of a line item. By default, the calculations are done on a line item-basis. See the table below that shows the difference between the two calculations. |

*Table: Difference between calculations

|Discount method|Product|Price per unit|Quantity|Discount|Amount|  
|---------------------|-------------|--------------------|--------------|--------------|------------|  
|Line item|Product 1|100|11|10|(100*11)-10=1090|  
|Per unit|Product 2|100|11|10|(100-10)*11=990| 

### See also
[Set up a product catalog](set-up-product-catalog-walkthrough.md)
[Preview: Enable the enhanced experience of adding products (Sales Hub)](enable-enhanced-add-product-experience.md)  


