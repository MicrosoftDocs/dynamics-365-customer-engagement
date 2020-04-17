---
title: "How prices are calculated for product bundles? (Dynamics 365 Sales) | MicrosoftDocs"
description: "Understand how pricing of product bundles is determined in Dynamics 365 Sales."
ms.date: 04/17/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: get-started-article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# How prices are calculated for product bundles?

Typically, the pricing of products in bundles is different than the individual products. You can set a total and potentially discounted price for the bundle, or if the bundle has optional products, add those products to the price list as price list items. 

While adding a product bundle to an opportunity, quote, order, or invoice, a required product in the bundle uses the bundle price for price calculations. If the bundle added to the opportunity, quote, order, or invoice has optional products, then the total price is calculated by adding up the optional products' price to the price of the bundle product. 

Let's understand this with an example. Let's say you have a bundle product priced at $500 with the following products added to it: 

| Product  | Unit  | Price per unit  |
| -------- | ----- | --------------- |
| Required Product A | 5  | 50  |
| Required Product B | 5  | 70  |

In this case, when this bundle is added to an opportunity, the total price of the bundle product would be $500 (the price set for the bundle product).

Now, let's see how the calculation differs if the bundle product priced at $500 has the following optional products:

| Product  | Unit  | Price per unit  |
| -------- | ----- | --------------- |
| Required Product A | 5  | 50  |
| Required Product B | 5  | 70  |
| Optional Product C | 5  | 40  |
| Optional Product D | 5  | 50  |

In this case, when this bundle is added to an opportunity, the total price of the bundle product would be:

| Bundle product price  | +  | Sum of optional products' price  | Total  |
| -------- | ----- | ----- | --------------- |
| 500     | +  | (5x40) + (5x50) = 450 | 950 | 

When you try to update the required product of a bundle that's added to an Opportunity, Quote, Order, or Invoice record, you might get an error in Dynamics 365 Sales: You can't update this bundle item because it's a required product in the bundle. 

Because the required products in product bundle items aren't used in price calculations, updating any price-related fields isn't allowed and an error is shown if you try to update such fields. 

The pricing-related fields in a product that can't be modified are: Unit, Existing Product, Pricing, Price Per Unit, Volume Discount, Quantity, Amount, Manual Discount, Tax, Extended Amount, Product Type code, Transaction Currency, Parent Bundle.


### See also

[Set up product bundles to sell multiple items together](create-product-bundles-sell-multiple-items-together.md)