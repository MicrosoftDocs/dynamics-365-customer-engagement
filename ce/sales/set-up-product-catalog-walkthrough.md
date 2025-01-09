---
title: Set up a product catalog  Walkthrough
description: Make it easier for your sales reps to increase their sales by creating a product catalog in Dynamics 365 Sales.
ms.date: 10/16/2024
ms.topic: overview
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - dyn365-sales
  - bap-template
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-product
  - D365-Entity-discount
  - D365-Entity-discounttype
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---
# Set up a product catalog  

Set up the product catalog with the collection of products that you sell and their pricing information.

[!INCLUDE [trial-cta-note](../includes/trial-cta-note.md)]


## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or Dynamics 365 Sales Professional <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Process for setting up the product catalog

 A product catalog is a collection of products and their pricing information. To set up pricing, you need to define the units in which your products are sold, the amount to charge for each unit, and the discounts you want to offer based on volume purchased.  

> [!NOTE]
> Product families are only supported with Sales Enterprise and Sales Premium licenses.

Watch this video to understand the components of a product catalog and how to set them up:

> [!VIDEO https://www.youtube.com/embed/AljnXxF6qwg]

 Other than setting up the pricing for products, product catalog also supports product taxonomy that lets you create a rich classification of products. This helps ensure that your customers receive the most appropriate and complete solution.  
 
 As units, discounts, and prices are connected to each other, it's important that you create each of these components in a product catalog in the following sequence:  


| Step | Description | Related topics |
|------|-------------|----------------|
| 1 | Create discount lists to offer your products and services at different prices, depending on the quantity purchased. | [Set up a discount list](set-up-discount-list.md) |
| 2 | Define the measurements or quantities your products will be available in. | [Create a unit group and add units to that group](create-unit-group-add-units-that-group.md)  |
| 3 |  Create products for the items you sell. You can create a standalone product or a product inside a family depending on how you want to organize and classify your products. Each product you create will be linked to a unit group and default unit. You can also create a standalone bundle or a bundle inside a product family. | [Create a product family](create-product-family.md) |
| 4 | Define pricing for your products. | [Create price lists and price list items to define pricing of products](create-price-lists-price-list-items-define-pricing-products.md) |
| 5 |  Add price list items. A price list item defines the price per unit of a product. Add each new product to one or more price lists as price list items. You can do this either from the product form or the price list form. | [Create a product family](create-product-family.md)<br /><br /> **- OR -**<br /><br /> [Create price lists and price list items to define pricing of products](create-price-lists-price-list-items-define-pricing-products.md) |
| 6 | Select one of the price lists to which you added the product as the default price list for the product. [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] uses the default price list for calculations when the associated price list in the opportunity or order for the product doesn't contain a price definition of the product. | [Create a product family](create-product-family.md) |

:::image type="content" source="media/v7-set-up-product-catalog.png" alt-text="A flow diagram depicting the different steps in setting the product catalog":::

## Related information
 [Create a product family](create-product-family.md)  
 [Learn the basics of [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]](user-guide-learn-basics.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
