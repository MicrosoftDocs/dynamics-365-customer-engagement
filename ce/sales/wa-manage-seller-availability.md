---
title: Let sellers set their availability
description: Learn how to allow sellers to configure their work hours and vacation days in Microsoft Outlook or the CRM calendar in Dynamics 365 Sales.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.collection:
ms.date: 08/11/2023
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/18/2023
---

# Let sellers set their availability

Assignment rules can assign new leads and opportunities to your sellers based on their availability, capacity, and attributes.

This article covers how to turn on the seller availability feature in Dynamics 365 Sales so that sellers can [set their work hours](./personalize-sales-accelerator.md#configure-your-work-availability) themselves. [Learn how to set seller attributes and capacity](./wa-manage-seller-attributes.md).

[!INCLUDE [sales-work-assignment](../includes/sales-work-assignment.md)]

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [Sales Manager](security-roles-for-sales.md) |

## Let your sellers set their availability

1. Sign in to your Sales Hub app.

1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.

1. Under **Sales accelerator**, select **Work assignment**.

1. Select **Settings**.

1. In the **Availability and calendar** section, select **Manage**.

1. Turn on **Seller availability settings**, and then select either **CRM Calendar** or **Outlook**.

    :::image type="content" source="media/sa-ar-sales-team-define-seller-availability-configuration.png" alt-text="Screenshot of seller availability settings.":::

1. Select **Save**.

Sellers can then [set their availability](./personalize-sales-accelerator.md#configure-your-work-availability) in Outlook, if they have an Exchange license, or in the Dynamics 365 calendar.

## Set your sellers' availability yourself

If you choose not to let your sales team enter their working hours and time off, the Sales Hub app offers three ways to set their availability yourself.

### Set work hours in advanced settings

1. Sign in to your Sales Hub app and select **Settings** (the gear icon) > **Advanced Settings**.

1. On the **Advanced Settings** page, select **Settings** > **System** > **Security** > **Users**.

1. Open the record of the seller whose work hours you want to set.

1. At the top of the page, select the arrow next to the user name, and then select **Work Hours**.

    :::image type="content" source="media/manage-seller-availability-select-chevron.png" alt-text="Screenshot of the user settings page, with the arrow next to the user name and the Work Hours button highlighted.":::

1. On the **Monthly View** tab, select **Set Up** > **Time Off**.

1. Enter the seller's time off information, and then select **OK**.

### Set work hours with the calendar API

Use the calendar API and enter `msdyn_extendedusersetting` as the value of the `EntityLogicalName` string. [Learn how to edit work hour calendars using APIs](/dynamics365/field-service/field-service-work-hours-calendar-api).

### Set availability with an assignment rule and seller attributes

In your assignment rules, create a seller attribute that's based on the seller's availability and assign it as needed. For example, you might create an attribute that has the values *Available* and *On vacation*. When a seller goes on vacation, select the attribute and assign the *On vacation* value to indicate the seller isn't available. [Learn how to manage seller attributes in assignment rules](manage-seller-attributes.md).

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

- [Configure your work availability](personalize-sales-accelerator.md#configure-your-work-availability)
- [Set seller attributes](manage-seller-attributes.md)
