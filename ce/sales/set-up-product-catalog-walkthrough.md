---
title: Set up a product catalog walkthrough
description: Make it easier for your sales reps to increase their sales by creating a product catalog in Dynamics 365 Sales.
ms.date: 10/16/2024
ms.topic: overview
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom: 
  - dyn365-sales
  - bap-template
ai-usage: ai-assisted
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

A well-organized product catalog streamlines your sales process, reduces errors, and ensures consistent pricing across your organization. By setting up units, pricing, discounts, and product classifications, your sellers can quickly add products to opportunities and orders—saving time and improving accuracy. For example, if you sell software licenses by user seats with volume discounts, a configured catalog lets your sellers instantly apply the correct pricing for any quantity without manual calculations.

## Overview

A product catalog is a collection of products and their pricing information. To set up pricing, you need to:

- Define the units in which you sell your products
- Set the amount to charge for each unit
- Configure discounts based on volume purchased

> [!NOTE]
> Product families are only available in the Sales Hub app.

Watch this video to understand the components of a product catalog and how to set them up:

> [!VIDEO https://www.youtube.com/embed/AljnXxF6qwg]

Your product catalog also supports product taxonomy, which lets you create a rich classification of products. This ensures that your customers receive the most appropriate and complete solution.

## Set up your product catalog in sequence

Because units, discounts, and prices are connected to each other, you must create each component in the following order:

| Step | What you do | Learn more |
|------|------------|------------|
| 1. | Create discount lists so you can offer your products and services at different prices based on quantity purchased. | [Set up a discount list](set-up-discount-list.md) |
| 2. | Define the measurements or quantities your products are available in. | [Create a unit group and add units to that group](create-unit-group-add-units-that-group.md) |
| 3. | Create products for the items you sell. You can create a standalone product or a product inside a family. Each product links to a unit group and default unit. You can also create a standalone bundle or a bundle inside a product family. | [Create a product family](create-product-family.md) |
| 4. | Define the pricing for your products. | [Create price lists and price list items to define pricing of products](create-price-lists-price-list-items-define-pricing-products.md) |
| 5. | Add price list items to define the price per unit of a product. Add each new product to one or more price lists as price list items. You can do this from the product form or the price list form. | [Create a product family](create-product-family.md) or [Create price lists and price list items to define pricing of products](create-price-lists-price-list-items-define-pricing-products.md) |
| 6. | Select one of the price lists where you added the product as the default price list. [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)] uses the default price list for calculations when the associated price list in the opportunity or order doesn't contain a price definition for the product. | [Create a product family](create-product-family.md) |

:::image type="content" source="media/v7-set-up-product-catalog.png" alt-text="Flow diagram showing the steps for setting up a product catalog":::

## Related information

- [Create a product family](create-product-family.md)
- [Learn the basics of [!INCLUDE[pn-dyn-365-sales](../includes/pn-dyn-365-sales.md)]](user-guide-learn-basics.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
