---
title: "Price calculation for opportunity, quote, order, and invoice records (Dynamics 365 Sales) | MicrosoftDocs"
description: "This article explains how prices are calculated for price-related fields in the opportunity, quote, order, and invoice records in Dynamics 365 Sales."
ms.date: 06/15/2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
searchScope:
  - D365-App-msdynce_saleshub
  - D365-Entity-opportunity
  - D365-Entity-quote
  - D365-Entity-salesorder
  - D365-Entity-invoice
  - D365-Entity-quoteproduct
  - D365-Entity-salesorderproduct
  - D365-Entity-invoiceproduct
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---

# Price calculation for opportunity, quote, order, and invoice records

System price calculation is used to calculate values for the price-related fields of the opportunity, quote, order, and invoice records such as price per unit, volume discount, manual discount, or extended amount. An administrator or system customizer can set the preference for using system pricing calculations in **System Settings**. More information: [System Settings Sales tab](https://docs.microsoft.com/power-platform/admin/system-settings-dialog-box-sales-tab)

> [!TIP]
> Developers can also set system pricing calculation using the OOBPriceCalculationEnabled field of the Organization entity. More information: [OOBPriceCalculationEnabled](https://docs.microsoft.com/powerapps/developer/common-data-service/reference/entities/organization#BKMK_OOBPriceCalculationEnabled)


If the **Use system pricing calculation** option is set to **Yes**, price calculation happens when an opportunity, order, quote, or invoice record is opened, created, or updated or when products are added, updated, or deleted from the entity record.

## How price per unit is calculated for existing products in the product catalog

When you add an existing product to an opportunity, quote, order, or invoice record, and select a unit, you're adding a price list item. This price list item could be associated with a price list set on the opportunity, quote, order, or invoice record or to the default price list that's set on the product.

The Price Per Unit field on the price list item is calculated only when an existing product that's associated with a price list is added to an opportunity, quote, order, or invoice record. Otherwise, it is set to 0.

The price per unit is calculated based on the pricing method that you select while adding the product/price list item.

The following table lists the formula used for calculating the Price Per Unit field for each pricing method.

| Pricing method       | PricePerUnit formula  |
|----------------------| ----------------------|
| Amount               | The price is specified for each unit of measure for each product. <br />Price = amount                |
| Percent list price   | The price is calculated based on the manufacturer's or distributor's list price. <br /> Calculated price = list price x percentage  |
| Margin current cost  | The price is based on the profit percentage you want to achieve and your current cost for the item. <br />Calculated price = current cost + [(current cost x percentage)/(100% - percentage)]   |
| Markup current cost  | The price is calculated as a percentage of your current cost for the item. <br /> Calculated price = current cost x 100% + percentage   |
| Margin standard cost | The price is based on the profit percentage you want to achieve and the standard cost of the item. <br /> Calculated price = standard cost + [(standard cost x percentage)/(100% - percentage)] <br /> Because the standard cost is updated periodically, the standard cost amount in this equation is an average and will not always be the same as the amount you paid most recently for the item.  |
| Markup standard cost | The price is calculated as a percentage of the standard cost of the item. <br /> Calculated price = standard cost x 100% + percentage. <br /> Because the standard cost is updated periodically, the standard cost amount in this equation is an average and will not always be the same as the amount you paid most recently for the item.  |

The final price per unit is derived by applying the rounding options (as defined in the price list item record) on the calculated value.

> [!NOTE]
> List Price, Standard Cost, and Current Cost fields are not present on the product form by default. To see them on the form, a system customizer must add these fields to the product form.


## Price calculation when price list is mandatory versus optional

Price calculations depend on whether a price list is mandatory while adding products or whether your organization has made price lists optional.

When price list is mandatory, price calculation won't happen if:

- You haven't selected a price list on the opportunity, quote, order, or invoice records.

- You've selected a price list on the opportunity, quote, order, or invoice record, but you're adding a product that doesn't belong to the selected price list.

- You've selected a price list on the opportunity, quote, order, or invoice record, but: 

    - The price list item for the product's default price list isn't present.

    - The currency of the product's default price list doesn't match the currency on the quote product, order product, or invoice product.

When price list is optional, price calculation happens. If the product you're adding is associated with a price list, the price per unit is calculated and populated from the price list item. Otherwise, the price per unit is set to 0. To learn how to make the price list optional, see [Make price list optional](make-price-list-optional.md).

## Price calculations for volume discount

Volume discount is calculated only when the quantity of the opportunity product, quote product, order product, or invoice product is changed (even when the parent entities are locked).

When a price list item is added as a product in opportunity, quote, order or invoice, the discount list defined in the price list item is used to calculate the volume discount.  

> [!NOTE]
> Discount is calculated even when a discount list is inactive. 


### See also
[Define product pricing with price lists and price list items](create-price-lists-price-list-items-define-pricing-products.md)  
[Add products to an opportunity](add-products-opportunity.md)  
[Add products to quotes, orders, or invoices](add-product-quote-order-invoice.md)



[!INCLUDE[footer-include](../includes/footer-banner.md)]