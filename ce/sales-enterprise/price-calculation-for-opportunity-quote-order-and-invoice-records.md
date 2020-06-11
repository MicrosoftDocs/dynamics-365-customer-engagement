---
title: "Price calculation for Opportunity, Quote, Order, and Invoice records (Dynamics 365 Sales) | MicrosoftDocs"
description: "This article explains how prices are calculated for price-related fields in the opportunity, quote, order, and invoice records in Dynamics 365 Sales."
ms.date: 06/11/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Price calculation for Opportunity, Quote, Order, and Invoice records

System price calculation calculates values for the price-related fields of the Opportunity, Quote, Order, and Invoice records such as Price Per Unit, Volume Discount, Manual Discount, or Extended Amount. An administrator or system customizer can set the preference for using system pricing calculations in **System Settings**. More information: [System Settings Sales tab](https://docs.microsoft.com/en-us/power-platform/admin/system-settings-dialog-box-sales-tab).

> [!TIP]
> Developers can also set system pricing calculation using the OOBPriceCalculationEnabled field of the Organization entity. More information: [OOBPriceCalculationEnabled](https://docs.microsoft.com/powerapps/developer/common-data-service/reference/entities/organization#BKMK_OOBPriceCalculationEnabled)


If the **Use system pricing calculation** option is set to **Yes**, price calculation happens when an opportunity, order, quote, or invoice record is opened, created, or updated or when products are added, updated, or deleted from the entity record.

## 

## How price per unit is calculated for existing products in the product catalog

When you add an existing product to opportunity, quote, order, or invoice record, and select a unit, you're adding a price list item. This price list item could be associated with a price list set on the Opportunity, quote, order, or invoice record or to the default price list that's set on the product.

The Price Per Unit field on the price list item is calculated only when an existing product that's associated with a price list is added to a opportunity, quote, order, or invoice record. Otherwise, it is set to 0.

The price per unit is calculated based on the pricing method that you select while adding the product/price list item.

The following table lists the formula used for calculating the price per unit field for each pricing method:

| Pricing Method       | PricePerUnit Formula  |
|----------------------| ----------------------|
| Amount               | Amount                |
| Percent list price   | (UnitsPerPriceUnit x Product.ListPrice x PriceListItem.Percentage)/100  |
| Margin Current Cost  | (UnitsPerPriceUnit x Product.CurrentCost + ((UnitsPerPriceUnit x Product.CurrentCost x PriceListItem.Percentage) / (100 - PriceListItem.Percentage)))   |
| Markup Current Cost  | ((UnitsPerPriceUnit x Product.CurrentCost) x (100 + PriceListItem.Percentage)) / 100   |
| Margin Standard Cost | (UnitsPerPriceUnit x Product.StandardCost + ((UnitsPerPriceUnit x Product.StandardCost x PriceListItem.Percentage) / (100 - PriceListItem.Percentage))  |
| Markup Standard Cost | (UnitsPerPriceUnit x Product.StandardCost x (100 + PriceListItem.Percentage)) / 100  |

**Where**:

-  Product.ListPrice, Product.StandardCost and Product.CurrentCost refer to the List Price, Standard Cost, and Current Cost of the Product record respectively

-  PriceListItem.Percentage refers to the Percentage value on the Price List Item record

-  UnitsPerPriceUnit refers to the actual number of units (for the unit selected while adding existing product on Opportunity Product/Quote Product/Order Product/Invoice product)

The final price per unit is derived by applying the rounding options (as defined in the price list item record) on the calculated value.

> [!NOTE]
> List Price, Standard Cost and Current Cost fields are not present on the product form by default. To see them on the form, a system customizer must add these fields to the product form.


## Price calculation when price list is mandatory vs. optional

Price calculations depend on whether a price list is mandatory while adding products or whether your organization has made price lists optional.

When price list is mandatory, price calculation won't happen if:

- You haven't selected a price list on the Opportunity/Quote/Order/Invoice records.

- You've selected a price list on the Opportunity/Quote/Order/Invoice record, but you're adding a product that doesn't belong to the selected price list.

- You've selected a price list on the Opportunity/Quote/Order/Invoice record, but: 

    - the price list item for the product's default price list isn't present

    - the currency of product's default price list doesn't match the currency on the quote product, order product, or invoice product

When price list is optional, price calculation happens. If the product you're adding is associated with a price list, the price per unit is calculated and populated from the price list item. Else, price per unit is set to 0. To know how to make price list optional, see [Make price list optional](make-price-list-optional.md).

## Price calculations for volume discount

Volume discount is calculated only when the quantity of the opportunity product/quote product/order product/invoice product is changed (even when the parent entities are locked).

When a price list item is added as product in Opportunity, Quote, Order or Invoice, discount list defined in the price list item is used to calculate the volume discount.  

> [!NOTE]
> Discount is calculated even when a discount list is inactive. 


### See also
[Define product pricing with price lists and price list items](create-price-lists-price-list-items-define-pricing-products.md)  
[Add products to an opportunity](add-products-opportunity.md)  
[Add products to quotes, orders, or invoices](add-product-quote-order-invoice.md)

