---
title: Manage seller availability
description: Manage sellers' availability to provide a more flexible and accommodating work environment.
author: udaykirang 
ms.author: udag 
ms.reviewer: shujoshi
ms.topic: how-to 
ms.date: 03/21/2023
ms.custom: bap-template 
---

# Manage seller availability

As a sales manager, you can manage the availability of your sales team according to the needs of your business. In this way, you create a more flexible and accommodating work environment, where team members can take time off or switch shifts as needed. By helping your sales team become more productive, you can also help improve customer satisfaction and increase sales.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Sales Manager<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## How can I manage seller availability?

You can manage sellers' availability in the following ways:

- **Advance settings**: Update the sellers' work hours through the advanced settings.
 
    1. Go to **Advanced Settings** > **Settings** > **System** > **Security** > **Users**.
    1. Open the user record that you want to set work hours for.
    1. At the top of the page, select the arrow next to the user name, and then select **Work Hours**.

        :::image type="content" source="media/manage-seller-availability-select-chevron.png" alt-text="Screenshot that shows the arrow next to the user name being selected to open the menu that includes the Work Hours button.":::

    1. On the **Monthly View** tab, select **Set Up** > **Time Off**.
    1. In the **Schedule Time Off** dialog box, enter the information for the time off, and then select **OK**.

    The time off for the selected user is added to the calendar.

- **Calendar API**: Use the calendar API, and enter `msdyn_extendedusersetting` as the value of the `EntityLogicalName` string. [Learn how to edit work hour calendars by using APIs.](/dynamics365/field-service/field-service-work-hours-calendar-api)
- **Assignment rules**: In assignment rules, create a seller attribute that's based on seller availability. Then apply appropriate values to sellers, based on their availability. For example, create an attribute that has the values *Available* and *On vacation*. Then, when a seller goes on vacation, select the attribute, and assign the *On vacation* value to notify other users that the seller isn't available. [Learn how to manage seller attributes in assignment rules.](manage-seller-attributes.md)

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Configure your work availability](personalize-sales-accelerator.md#configure-your-work-availability)   
[Manage seller attributes in assignment rules](manage-seller-attributes.md)
