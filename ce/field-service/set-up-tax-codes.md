---
title: Create tax codes
description: Learn how to set up tax codes in Dynamics 365 Field Service.
ms.date: 07/28/2025
ms.topic: how-to
ms.author: jacoh
author: jasonccohen
ms.custom: bap-template
---

# Create tax codes

If your organization must calculate tax and want to use the Field Service tax logic, an administrator must enable tax calculations. Then, set up tax codes and specify how much tax to apply to your products, agreements, and services.

Calculating tax is off by default in Field Service and the tax-related fields are hidden. For many field service organizations, tax calculation isn't an important factor for the following reasons:

- The services aren't provided to an external customer.
- The tax calculation and application rules are complex enough that they're handled in a related enterprise resource planning (ERP) system.

## Enable tax calculation

1. In Field Service, select the **Settings** area and then select **Field Service Settings**.

1. Select the **Work Order / Booking** tab and set the **Calculate Tax** field to **Yes**.

1. Select **Save & Close**.

When calculating tax is enabled, the following tables and fields are shown, and the logic is enabled.

| Table | Affected fields |
|---|---|
| Work Order | Taxable, Tax Code, Tax Amount, Subtotal Amount |
| Work Order Type | Taxable |
| Work Order Product | Taxable |
| Work Order Service | Taxable |
| Account | Tax Exempt, Tax Exempt Number, Sales Tax Code |
| Agreement | Taxable, Tax Code |
| Purchase Order Bill | Tax Amount, Tax Code |
| Product | Taxable |
| Return merchandise authorization (RMA) | Taxable, Tax Code |
| RMA Product | Taxable |
| Quote Detail | Taxable, Tax Code |

## Set up tax codes

Each tax code can contain multiple child tax codes. In this case, the total of all children determines the parent tax rate.

If an area has more than one type of tax (such as state tax and county tax), use the **Tax Group** option to combine several tax codes into one group. For example, if the state of California has a state tax and a county tax, you might have a tax group that is named *California, Alameda County*. The tax group has two tax codes: one for overall California state tax and one for Alameda County local tax.

1. In Field Service, select the **Settings** area.

1. Under **General**, select **Tax Codes**, then choose **New**.

1. If this tax code is part of a tax group, go to the [Set up a tax group](#set-up-a-tax-group) section. Otherwise, move on to the next step.

1. Use the tooltips to help fill in your information.

1. Select **Save & Close**.

### Set up a tax group

1. Set the **Act as tax Group** field to **Yes**.

1. In the **Tax Code Details** section, select **New Tax Code Detail**.

1. Enter the following information:

    - **Tax Code**: Enter the name of the tax code. Set up a new tax code with a tax rate if it isn't already set up.
    - **Tax on tax**: If the government agency charges tax above the local tax, set this field to **Yes**.

        For example, the Canadian government charges Provincial Sales Tax (PST) and Goods and Services Tax (GST). If the work order total equals $100, the first tax code in the group is calculated on $100. If the tax rate of the tax code is 5 percent, the total is now $105. If the rate of the second code in the tax group is 10 percent, and the code is marked as a tax on tax, the 10 percent is calculated on $105 instead of $100. In this case, the total is now $110. However, if the second code isn't marked as a tax on tax, the 10 percent is calculated on the initial work order amount of $100.

    - **Line Order**: Specify the order that the system should calculate the multiple tax codes.

1. Select **Save**.

1. Set up other tax code details for the tax group, and then select **Save & Close**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
