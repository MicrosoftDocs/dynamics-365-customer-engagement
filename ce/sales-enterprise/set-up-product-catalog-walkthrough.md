---
title: "Set up a product catalog  Walkthrough (Dynamics 365 Sales) | MicrosoftDocs"
description: "Make it easier for your sales reps to increase their sales by creating a product catalog in Dynamics 365 Sales."
ms.date: 10/01/2019
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: get-started-article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Set up a product catalog 

Make it easier for your sales reps to increase their sales by creating a product catalog. The product catalog is a collection of products and their pricing information. To set up pricing, you need to define the units in which your products are sold, the amount to charge for each unit, and the discounts you want to offer based on volume purchased.  

 Other than setting up the pricing for products, product catalog also supports product taxonomy that lets you create a rich classification of products. This helps ensure that your customers receive the most appropriate and complete solution.   

 Because of how units, discounts, and prices are tied together, it's important that you create each of these components in a product catalog in the following sequence:  


|                                 Step                                  |                                                                                                                                                                  Description                                                                                                                                                                   |                                                                                                                   Related topics                                                                                                                   |
|-----------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| ![Step 1](../sales-enterprise/media/walkthrough-green-1.png "Step 1") |                                                                                                              Create discount lists to offer your products and services at different prices, depending on the quantity purchased.                                                                                                               |                                                                                                 [Set up a discount list](set-up-discount-list.md)                                                                                                  |
| ![Step 2](../sales-enterprise/media/walkthrough-green-2.png "Step 2") |                                                                                                                                   Define the measurements or quantities your products will be available in.                                                                                                                                    |                                                                            [Create a unit group and add units to that group](create-unit-group-add-units-that-group.md)                                                                            |
| ![Step 3](../sales-enterprise/media/walkthrough-green-3.png "Step 3") |        Create products for the items you sell. You can create a standalone product or a product inside a family depending on how you want to organize and classify your products. Each product you create will be linked to a unit group and default unit. You can also create a standalone bundle or a bundle inside a product family.        |                                                                                      [Create a product family](../sales-enterprise/create-product-family.md)                                                                                       |
| ![Step 4](../sales-enterprise/media/walkthrough-green-4.png "Step 4") |                                                                                                                                                       Define pricing for your products.                                                                                                                                                        |                                                      [Create price lists and price list items to define pricing of products](create-price-lists-price-list-items-define-pricing-products.md)                                                       |
| ![Step 5](../sales-enterprise/media/walkthrough-green-5.png "Step 5") |                                                           Add price list items. A price list item defines the price per unit of a product. Add each new product to one or more price lists as price list items. You can do this either from the product form or the price list form.                                                           | [Create a product family](../sales-enterprise/create-product-family.md)<br /><br /> **- OR -**<br /><br /> [Create price lists and price list items to define pricing of products](create-price-lists-price-list-items-define-pricing-products.md) |
| ![Step 6](../sales-enterprise/media/walkthrough-green-6.png "Step 6") | Select one of the price lists to which you added the product as the default price list for the product. [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] uses the default price list for calculations when the associated price list in the opportunity or order for the product doesn't contain a price definition of the product. |                                                                                      [Create a product family](../sales-enterprise/create-product-family.md)                                                                                       |

 ![Set up product catalog components in Dynamics 365 Sales](../sales-enterprise/media/v7-set-up-product-catalog.png "Set up product catalog components in Dynamics 365 Sales")

### See Also
 [Create a product family](../sales-enterprise/create-product-family.md)  
 [Overview of Sales](../sales-enterprise/user-guide.md)
