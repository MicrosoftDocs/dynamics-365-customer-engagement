---
title: Set seller availability
description: Learn how to set your sellers' availability in Dynamics 365 Sales Hub so that your assignment rules know whom they can assign new leads and opportunities to.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 03/21/2023
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/10/2023
---

# Set seller availability

As a sales manager, you can set your sellers' availability in Dynamics 365 Sales Hub to help you and your sales team plan and track time off, swap shifts with other sellers, and adjust working hours during peak seasons or for special events. Setting your sellers' availability also improves customer satisfaction and increases sales, because it lets you assign leads and opportunities to the most available and qualified sellers, avoid scheduling conflicts, and provide consistent and timely service to your customers.

[If you allow them to](./wa-manage-seller-availability.md), your sellers can also [set their own availability in the sales accelerator personal settings](./personalize-sales-accelerator.md).

[!INCLUDE [sales-work-assignment](../includes/sales-work-assignment.md)]

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | [Sales Manager](security-roles-for-sales.md) |

## Set your sellers' availability

The Sales Hub app offers three ways to set your sellers' availability.

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

- [Set your work availability](personalize-sales-accelerator.md#configure-your-work-availability)
