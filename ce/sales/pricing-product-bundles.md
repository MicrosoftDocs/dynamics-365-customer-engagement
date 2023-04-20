---
title: "How are prices calculated for product bundles? (Dynamics 365 Sales) | MicrosoftDocs"
description: "Calculate prices for bundled products with optional items in the Sales app."
ms.date: 02/28/2023
ms.topic: get-started-article
author: lavanyakr01
ms.author: lavanyakr
---
# How are prices calculated for product bundles?

Typically, the pricing of products in bundles is different than for individual products. You can set a total, potentially discounted, price for the bundle. Or&mdash;if the bundle includes optional products&mdash;you can add those products to the price list as price list items.

When a product bundle is added to an opportunity, quote, order, or invoice, the bundle price is calculated based on the required products in the bundle. When the bundle includes optional products, the total price is calculated by adding the total price of the optional products and the price of the product bundle.

Let's understand this with an example. You have a product bundle priced at $600, with the following products included in it: 

| Products in the bundle  | Unit  | Price per unit  |
| -------- | ----- | --------------- |
| Required product A | 5  | $50  |
| Required product B | 5  | $70  |

This bundle will be added to an opportunity with a price of $600.

Now, let's see how the calculation differs if the product bundle priced at $600 includes the following required and optional products:

| Product bundle  | Unit  | Price per unit  |
| -------- | ----- | --------------- |
| Required product A | 5  | $50  |
| Required product B | 5  | $70  |
| Optional product C | 5  | $40  |
| Optional product D | 5  | $50  |

When this bundle is added to an opportunity, its price will be calculated as follows:

| Product bundle price  | +  | Sum of optional products' price  | Total  |
| -------- | ----- | ----- | --------------- |
| $600     | +  | (5 &times; $40) + (5 &times; $50) = $450 | $1050 | 

When you try to update a product that's a required item in a bundle that has been added to an opportunity, quote, order, or invoice record, you might get an error in Dynamics 365 Sales: "You can't update this bundle item because it's a required product in the bundle."

Because the pricing-related fields for a product that's required for the bundle aren't used in price calculations, you can't modify these fields. The pricing-related fields are: Unit, Existing Product, Pricing, Price Per Unit, Volume Discount, Quantity, Amount, Manual Discount, Tax, Extended Amount, Product Type code, Transaction Currency, and Parent Bundle. You can modify fields other than these pricing-related fields.

### See also

[Set up product bundles to sell multiple items together](create-product-bundles-sell-multiple-items-together.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
