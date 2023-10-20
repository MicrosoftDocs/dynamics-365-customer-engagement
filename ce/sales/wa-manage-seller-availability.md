---
title: Let sellers set their availability
description: Learn how to allow sellers to set their work schedule in Outlook or the CRM calendar in Dynamics 365 Sales. You can also set their availability yourself.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
<<<<<<< HEAD
ms.topic: how-to
ms.collection:
ms.date: 08/11/2023
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/18/2023
=======
ms.topic: how-to 
ms.collection: 
ms.date: 10/19/2023
ms.custom: bap-template 
>>>>>>> c226aeec818d54ae9ce0c31c73bfffd29ac6920f
---

# Let sellers set their availability

Assignment rules can assign new leads, opportunities, and insights to your sellers based on their availability, attributes, and capacity.

This article covers how to set your sales team's availability. Sellers can [set their own availability](#let-your-sellers-set-their-availability) or you can [set their availability](#set-your-sellers-availability-yourself) yourself. [Learn how to set seller attributes and capacity](./wa-manage-seller-attributes.md).

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

<<<<<<< HEAD
1. Select **Settings**.
=======
1.	On the **Seller availability** dialog box, configure the following options:  
    - Turn on **Seller availability settings** to enable sellers to configure work hours.
    - From the **Select a calendar** option, choose one of the following calendar types that sellers can use to configure work hours and vacation days. Once configured, leads and opportunities are assigned based on seller availability. 
        - **CRM calendar**: : Allows sellers to configure work hours and vacation days using the Dynamics 365 calendar in personal settings. By default, this option is selected. More information [Configure your work availability](personalize-sales-accelerator.md#configure-your-work-availability). 
        - **Outlook**: Allows sellers to configure work hours and vacation days through the Outlook calendar. Sellers should have an Exchange license to use this option.
>>>>>>> c226aeec818d54ae9ce0c31c73bfffd29ac6920f

1. In the **Availability and calendar** section, select **Manage**.

1. Turn on **Seller availability settings**, and then select either **CRM Calendar** or **Outlook**.

    :::image type="content" source="media/sa-ar-sales-team-define-seller-availability-configuration.png" alt-text="Screenshot of seller availability settings.":::

1. Select **Save**.

<<<<<<< HEAD
Sellers can then [enter their work schedule](./personalize-sales-accelerator.md#configure-your-work-availability) in Outlook, if they have an Exchange license, or in the Dynamics 365 calendar.

## Set your sellers' availability yourself

The Sales Hub app offers three ways to set your sales team's work hours yourself:

- [Set their work hours in advanced settings](#set-work-hours-in-advanced-settings).
- [Set their work hours with the calendar API](#set-work-hours-with-the-calendar-api).
- [Use an assignment rule and seller attributes](#set-availability-with-an-assignment-rule-and-seller-attributes).
=======
- **Work assignment settings**: Update the sellers' work hours through the seller's calendar.
 
    1. Go to **Sales insight settings** > **Sales accelerator** > **Work assignment** > **settings** .
    1. In the **Work assignment settings** page, select the seller from the list and then select **Set availability**.

        >[!NOTE]
        >You can select only one seller at a time.

    1. In the seller's calendar, select **New** and choose an option to configure the seller's calendar. For more information, see step 4 in [Through work list settings](personalize-sales-accelerator.md#through-work-list-settings-sales-premium).
    
    The selected seller's calendar is updated according to your configurations. Also, the **Availability (Next 7 days)** column is updated with the seller's availability for the next seven days.
>>>>>>> c226aeec818d54ae9ce0c31c73bfffd29ac6920f

To temporarily stop assigning sellers who are on vacation or otherwise unavailable, [change their availability in work assignment settings](./wa-work-assignment-manage-settings.md#turn-off-record-assignment-to-sellers).

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

In your assignment rules, create a seller attribute that's based on the seller's availability and assign it as needed. For example, you might create an attribute that has the values *Available* and *On vacation*. When a seller goes on vacation, select the attribute and assign the *On vacation* value to indicate the seller isn't available. [Learn how to manage seller attributes in assignment rules](./wa-manage-seller-attributes.md).

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

- [Configure your work availability](personalize-sales-accelerator.md#configure-your-work-availability)
- [Set seller attributes](./wa-manage-seller-attributes.md)
- [Create and activate assignment rules](./wa-create-and-activate-assignment-rule.md)
