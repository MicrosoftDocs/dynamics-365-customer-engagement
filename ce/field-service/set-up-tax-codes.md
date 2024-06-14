---
title: Create tax codes
description: Learn how to set up tax codes in Dynamics 365 Field Service
ms.date: 06/12/2024
ms.topic: how-to
ms.author: jacoh
author: jasonccohen
ms.custom: bap-template
---
# Create tax codes

Set up tax codes in Dynamics 365 Field Service and specify how much tax to apply to your products, agreements, and services.  
  
## Enable tax calculation

Field Service v8.8.39.37 introduced the **Calculate Tax** field in **Field Service Settings**. By default, for all new installations of Field Service v8.8.39.37 or higher, this field is set to **No**. For many Field Service organizations, tax calculation isn't an important factor because:

- The services aren't being provided to an external customer.
- The tax calculation and application rules are complex enough that they're handled in a related enterprise resource planning (ERP) system.
  
When an organization needs to calculate tax and the Field Service tax logic is sufficient, go to the **Settings** area and select **Field Service Settings**. In the **Work Order / Booking** section, set **Calculate Tax** to **Yes**.

When **Calculate Tax** is **Yes**, the following tables and fields are shown and the logic is enabled:

|Table|	Fields impacted|
|------|-------|
|Work Order|*Taxable*, *Tax Code*, *Tax Amount*, *Subtotal Amount*|
|Work Order Type|*Taxable*|
|Work Order Product|*Taxable*|
|Work Order Service|*Taxable*|
|Account|*Tax Exempt*, *Tax Exempt Number*, *Sales Tax Code*|
|Agreement|*Taxable*, *Tax Code*|
|Purchase Order Bill|*Tax Amount*, *Tax Code*|
|Product|*Taxable*|
|Return merchandise authorization (RMA)|*Taxable*, *Tax Code*|
|RMA Product|*Taxable*|
|Quote Detail|*Taxable*, *Tax Code*|

## Set up tax codes

Each tax code can contain multiple child tax codes. In this case, the total of all children determines the parent tax rate.  
  
If an area has more than one type of tax, for example, state and county tax, then use the **Tax Group** option to combine several tax codes into one group. For example, if the state of California has a state and county tax, then you might have a tax group called "California, Alameda County." The tax group has two tax codes: one for overall California state tax and one for Alameda County local tax.  
  
1. In Field Service, change to the **Settings** area. Under the **General** section, select **Tax Codes**.  
  
1. On the **Active Tax Codes** screen, select **New**.  
  
1. If this tax code is part of a tax group, go to [Set up a tax group](#set-up-a-tax-group). Otherwise, continue to the next step.

1. Use the tooltips to help fill in your information.  

1. Select **Save & Close**.

### Set up a tax group

1. Set **Act as tax Group** to **Yes**.

1. Select the **Tax Code Details** section and select **New Tax Code Detail**.  
  
1. Enter the following information:

   - **Tax Code**: Name of the tax code. Set up a new tax code with a tax rate if it isn't already set up.
   - **Tax on tax**: If the government agency charges tax above the local tax, set  to **Yes**.  
  
     For example, the Canadian government charges Provincial Sales Tax (PST) and Goods and Services Tax (GST). If the work order total equals $100, the first tax code in the group is calculated on $100. If the tax code is 5%, then the total is now $105. If the second code in the tax group is 10%, and it is marked as a tax on tax, the 10% is calculated on $105 instead of $100, which makes the total $110. However, if the second code isn't flagged as a tax on tax, then the 10% is calculated on the initial work order amount of $100.  
  
   - **Line Order**: The order of how the system should calculate the multiple tax codes.  
  
1. Select **Save**. Set up other tax code details for the tax group and then select **Save & Close**.

[!INCLUDE[footer-include](../includes/footer-banner.md)]
