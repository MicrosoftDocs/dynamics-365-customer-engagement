---
title: "Decimal precision in currency and pricing (Dynamics 365 Sales) | MicrosoftDocs"
description: "Learn how decimal precision is used in currency and pricing in Dynamics 365 Sales."
ms.date: 06-17-2020
ms.service:
  - "dynamics-365-sales"
ms.topic: article
author: shubhadaj
ms.author: shujoshi
manager: annbe
---

# Decimal precision in currency and pricing

Decimal precision plays an important role in determining the number of decimal places to be used with field type **Currency** in Dynamics 365 Sales. It also affects rounding in calculations.

Decimal precision can be used with the following three levels:

- **Pricing decimal precision.** This is an organization-level setting used for pricing precisions.

- **Currency precision.** This option applies the precision defined for the currency in the record.

- **Field-level precision.** This is used to define a specific set precision using values between 0 and 4.


These precision levels are set while configuring currency fields. More information: [Create and edit fields for Common Data Service using Power Apps solution explorer](/powerapps/maker/common-data-service/create-edit-field-solution-explorer)

## Pricing decimal precision 

This setting allows you to enable and set decimal precision for all supported price-related fields in the system. Pricing decimal precision can be defined in the **Settings** &gt; **Administration** &gt; **System Settings** &gt; **General** tab. More information: [System Settings General tab](/power-platform/admin/system-settings-dialog-box-general-tab).

> [!NOTE]
> This setting supports values between 0 and 4.

This precision setting is applied to any currency field whose precision is set to **Pricing Decimal Precision** in the field properties. To see the field properties, go to **Settings** &gt; **Customizations** &gt; **Entity** &gt; **Fields**. Open the currency field to see the properties.

> [!div class="mx-imgBorder"]
> ![Precision set to Pricing Decimal Precision](media/set-precision-pricing-decimal-precision.png "Precision set to Pricing Decimal Precision")

By default, the following fields support pricing decimal precision:

- Product
  - List Price
  - Standard Cost
  - Current Cost

- Price List Item
    -   Amount
    -   Rounding Amount

-   Opportunity Product, Quote Product, Order Product, and Invoice Product
    -   Price Per Unit

## Currency precision 

This option allows you to enable and set decimal precision to individual currencies. To define this setting, go to **Settings** &gt; **Business Management** &gt; **Currencies**. Open the currency record and define the precision for currency. More information: [Manage transactions with multiple currencies](https://docs.microsoft.com/en-us/power-platform/admin/manage-transactions-with-multiple-currencies)

> [!NOTE]
> This setting supports values between 0 and 4.


This precision setting is applied to any currency field whose precision is set to **Currency Precision** in the field properties. To see the field properties, go to **Settings** &gt; **Customizations** &gt; **Entity** &gt; **Fields**. Open the currency field to see the properties.

> [!div class="mx-imgBorder"]
> ![Precision set to Currency Precision](media/set-precision-currency-precision.png "Precision set to Currency Precision")

All currency fields except for the ones listed under the **Pricing decimal precision** section support currency precision.

## Field-level precision

This setting allows you to define the precision to individual currency fields.

To apply this precision setting to any of the currency field in the system, go to **Settings** &gt; **Customizations** &gt; **Entity** &gt; **Fields**. Then, open a currency field and define the precision.

> [!div class="mx-imgBorder"]
> ![Field-level precision](media/field-level-precision.png "Field-level precision")

> [!NOTE]
> This setting supports values between 0 and 4.


## Troubleshooting 

### Issue: List Price, Standard Cost, or Current Cost fields don't honor Decimal Supported field precision value.

**Resolution**

There's no relation between the **Decimal Supported** and the **List Price** field. The value defined in the **Decimal Supported** field doesn't impact the precision value of the **List Price** field. The decimal precision value on the **List Price**, **Standard Cost**, or **Current Cost** field is controlled by the **Pricing Decimal Precision** setting. By default, **Pricing Decimal Precision** is set to **2**. For more information about this setting, see [System Settings General tab](https://docs.microsoft.com/power-platform/admin/system-settings-dialog-box-general-tab).

### Issue: I get an error when setting the Quantity field to a decimal value in the Order Product, Quote Product, Invoice Product records.

**Resolution**

The **Quantity Selling Option** field of the price list item record decides whether the product or service can be ordered in whole, partial, or both types of quantities. To be able to enter decimal values in the **Quantity** field, make sure the **Quantity Selling Option** field isn't set to **Whole**. More information: [Define product pricing with price lists and price list items](https://docs.microsoft.com/en-us/dynamics365/sales-enterprise/create-price-lists-price-list-items-define-pricing-products)

### Issue: I get an error while opening or saving a Product record when the Decimal Supported field has value > 2. 

**Resolution**
 
If the **Quantity On Hand** field is used on the form, the value for the **Decimal Supported** field must not be greater than the precision of **Quantity On Hand**.

To fix this, go to **Settings** &gt; **Customizations** &gt; **Entities** &gt; **Fields** &gt; **Quantity On Hand**. Make sure the **Precision** value is the same as the **Decimal Supported** value.

