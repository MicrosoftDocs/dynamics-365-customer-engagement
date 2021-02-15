---
title: "How are prices calculated for product bundles? (Dynamics 365 Sales) | MicrosoftDocs"
description: "Understand how pricing of product bundles is determined in Dynamics 365 Sales."
ms.date: 04/22/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: get-started-article
author: shubhadaj
ms.author: shujoshi
manager: annbe
searchScope:
  - D365-App-msdynce_saleshub
  - D365-Entity-product
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---

# How are prices calculated for product bundles?

Typically, the pricing of products in bundles is different than for individual products. You can set a total, potentially discounted, price for the bundle. Or&mdash;if the bundle includes optional products&mdash;you can add those products to the price list as price list items. 

When a product bundle is added to an opportunity, quote, order, or invoice, a required product in the bundle uses the bundle price for price calculations. When the bundle added to the opportunity, quote, order, or invoice includes optional products, the total price is calculated by adding the total price of the optional products to the price of the product bundle. 

Let's understand this with an example. You have a product bundle priced at $500, with the following products included in it: 

| Products in the bundle  | Unit  | Price per unit  |
| -------- | ----- | --------------- |
| Required product A | 5  | $50  |
| Required product B | 5  | $70  |

This bundle will be added to an opportunity with a price of $500.

Now, let's see how the calculation differs if the product bundle priced at $500 includes the following required and optional products:

| Product bundle  | Unit  | Price per unit  |
| -------- | ----- | --------------- |
| Required product A | 5  | $50  |
| Required product B | 5  | $70  |
| Optional product C | 5  | $40  |
| Optional product D | 5  | $50  |

When this bundle is added to an opportunity, its price will be calculated as follows:

| Product bundle price  | +  | Sum of optional products' price  | Total  |
| -------- | ----- | ----- | --------------- |
| $500     | +  | (5 &times; $40) + (5 &times; $50) = $450 | $950 | 

When you try to update a product that's a required item in a bundle that has been added to an opportunity, quote, order, or invoice record, you might get an error in Dynamics 365 Sales: "You can't update this bundle item because it's a required product in the bundle."

Because the pricing-related fields for a product that's required for the bundle aren't used in price calculations, you can't modify these fields. The pricing-related fields are: Unit, Existing Product, Pricing, Price Per Unit, Volume Discount, Quantity, Amount, Manual Discount, Tax, Extended Amount, Product Type code, Transaction Currency, and Parent Bundle. You can modify fields other than these pricing-related fields.

### See also

[Set up product bundles to sell multiple items together](create-product-bundles-sell-multiple-items-together.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]