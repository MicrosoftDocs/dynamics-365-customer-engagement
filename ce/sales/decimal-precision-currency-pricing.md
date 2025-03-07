---
title: Decimal precision in currency and pricing
description: Explore the role of decimal precision in currency and pricing, including its impact on rounding calculations and field-level precision.
ms.date: 01/31/2025
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
searchScope:
  - D365-App-msdynce_saleshub
  - D365-App-msdynce_salespro
  - D365-Entity-pricelevel
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
ms.custom:
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:05/08/2024
---
# Decimal precision in currency and pricing 

Decimal precision plays an important role in determining the number of decimal places to be used with field type **Currency** in Dynamics 365 Sales. It also affects rounding in calculations.

Decimal precision can be used at the following three levels:  

- **Pricing decimal precision.** This is an organization-level setting used for pricing precisions.  
- **Currency precision.** This option applies the precision defined for the currency in the record.  
- **Field-level precision.** This is used to define a specific set precision using values between 0 and 4.  

These precision levels are set while configuring currency fields. More information: [Create and edit fields for Microsoft Dataverse using Power Apps solution explorer](/powerapps/maker/common-data-service/create-edit-field-solution-explorer)

## Pricing decimal precision 

This setting allows you to enable and set decimal precision for all supported price-related fields in the system. To configure the pricing decimal precision setting:  

1. In the sales app, go to **Settings** > **Advanced Settings**.
1. Go to **System** > **Administration** > **General**.

1. Under the **Set the currency precision that is used for pricing throughout the system** section, select a value for **Pricing Decimal Precision**.  

    > [!NOTE]
    > The pricing decimal precision setting supports values between 0 and 4 only.

    This precision setting is applied to the relevant currency fields. By default, the following fields support pricing decimal precision:

    | Table | Field |
    |-------|-------|
    |Product| - List Price <br> - Standard Cost <br> - Current Cost|
    |Price List Item| - Amount <br> - Rounding Amount|
    |Opportunity Product, Quote Product, Order Product, and Invoice Product| Price Per Unit|

## Currency precision 

This option allows you to enable and set decimal precision to individual currencies. To configure the currency precision setting:

1. In the sales app, go to **Settings** > **Advanced Settings**.
1. Go to **Business** > **Business Management** > **Currencies**.
1. Open the currency record and enter the **Currency Precision** value. The value must be between 0 and 4.  
    More information: [Manage transactions with multiple currencies](/power-platform/admin/manage-transactions-with-multiple-currencies)

1. Save and close the settings.

    This precision setting is applied to the relevant currency fields. All currency fields except for the ones listed in the [Pricing decimal precision](#pricing-decimal-precision) section support currency precision.

## Field-level precision

This setting allows you to define the precision to individual currency fields. To apply this precision setting to any of the currency field in the system:

1. In the sales app, go to **Settings** > **Advanced Settings**.  
1. Go to **Customization** > **Customizations** > **Customize the System**.  
1. In the left pane, expand **Tables** and then the entity you want, and select **Forms**.  
    >[!NOTE]
    >If you are using the classic view, under **Components**, expand **Entities**, and then the entity you want, and select **Forms**.  
1. Open the form you want to edit and then select the currency field.  

1. On the **PowerApps** home page, select **Tables** &gt; ***Table*** and then, select the currency field.
1. On the **Edit column** pane, select **Advanced options** and then configure the following values:
    - **Precision source** as **Precision property**.  
    - **Decimal places** as required and must be between 0 to 4.
1. Save and close the settings.  

## Related information

[Define product pricing with price lists and price list items](create-price-lists-price-list-items-define-pricing-products.md)  
[Manage transactions with multiple currencies](/power-platform/admin/manage-transactions-with-multiple-currencies)  
[Troubleshoot issues with products](/troubleshoot/dynamics-365/sales/troubleshoot-products-issues)  
