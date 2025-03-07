---
title: Let sellers set their availability
description: Learn how to allow sellers to set their work schedule in Outlook or the CRM calendar in Dynamics 365 Sales. You can also set their availability yourself.
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: how-to
ms.date: 03/15/2024
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/18/2023
---

# Let sellers set their availability

Assignment rules can assign new leads, opportunities, and insights to your sellers based on their availability, attributes, and capacity.

This article covers how to set your sales team's availability. You can [set sellers availability](#set-your-sellers-availability-yourself) yourself.
[Learn how to set seller attributes and capacity](./wa-manage-seller-attributes.md).

[!INCLUDE [sales-work-assignment](../includes/sales-work-assignment.md)]

> [!NOTE]
> Starting from  April 1, 2024, you can't set the seller's availability through Outlook. More information: [Deprecation of setting seller availability using Outlook calendar](deprecations-sales.md#set-seller-availability-using-outlook-calendar)

## Set your sellers' availability yourself

The Sales Hub app offers three ways to set your sales team's work hours yourself:

- [Set work hours in work assignment settings](#set-work-hours-in-work-assignment-settings).
- [Set their work hours with the calendar API](#set-work-hours-with-the-calendar-api).
- [Use an assignment rule and seller attributes](#set-availability-with-an-assignment-rule-and-seller-attributes).

To temporarily stop assigning sellers who are on vacation or otherwise unavailable, [change their availability in work assignment settings](./wa-work-assignment-manage-settings.md#stop-assigning-work-to-sellers).

### Set work hours in work assignment settings

Use the Work assignment settings to configure the sellers' work hours.

1. Go to **Sales insight settings** > **Sales accelerator** > **Work assignment** > **settings** .

1. In the **Work assignment settings** page, select the seller from the list and then select **Set availability**.

    >[!NOTE]
    >You can select only one seller at a time.

1. In the seller's calendar, select **New** and choose an option to configure the seller's calendar. For more information, see step 4 in [Through work list settings](personalize-sales-accelerator.md#through-work-list-settings).

The selected seller's calendar is updated according to your configurations. Also, the **Availability (Next 7 days)** column is updated with the seller's availability for the next seven days.

### Set work hours with the calendar API

Use the calendar API and enter `msdyn_extendedusersetting` as the value of the `EntityLogicalName` string. [Learn how to edit work hour calendars using APIs](/dynamics365/field-service/field-service-work-hours-calendar-api).

### Set availability with an assignment rule and seller attributes

In your assignment rules, create a seller attribute that's based on the seller's availability and assign it as needed. For example, you might create an attribute that has the values *Available* and *On vacation*. When a seller goes on vacation, select the attribute and assign the *On vacation* value to indicate the seller isn't available. [Learn how to set seller attributes and capacity](./wa-manage-seller-attributes.md).

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

- [Configure your work availability](personalize-sales-accelerator.md#configure-your-work-availability)
- [Set seller attributes](./wa-manage-seller-attributes.md)
- [Create and activate assignment rules](./wa-create-and-activate-assignment-rule.md)
