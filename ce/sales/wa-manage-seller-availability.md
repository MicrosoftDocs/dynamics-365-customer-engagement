---
title: Manage seller availability
description: Manage sellers' availability to provide a more flexible and accommodating work environment.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 08/11/2023
ms.custom: bap-template 
---

# Manage seller availability

Enable the seller availability option to let sellers configure their work hours through Outlook or CRM calendar.  
Also, you can manage the availability of your sales team according to the needs of your business. In this way, you create a more flexible and accommodating work environment, where team members can take time off or switch shifts as needed. By helping your sales team become more productive, you can also help improve customer satisfaction and increase sales.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Sales Manager<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Enable seller availability

Enable the seller availability option to let sellers configure their work hours through Outlook or CRM calendar.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.  
1. Under **Sales accelerator**, select **work assignment**.  
1. On the **work assignment** page, select **Settings**.  
1. On the **Work assignment settings** page, select **Settings**.  
    The **Seller availability** dialog box opens.  

    :::image type="content" source="media/sa-ar-sales-team-define-seller-availability.png" alt-text="Screenshot of the seller availability dialog box.":::    

1.	On the **Seller availability** dialog box, configure the following options:  
    - Turn on **Seller availability settings** to enable sellers to configure work hours.
    - From the Select a calendar option, choose one of the following calendar types that sellers can use to configure work hours and vacation days. Once configured, leads and opportunities are assigned based on seller availability. 
        - **CRM calendar**: : Allows sellers to configure work hours and vacation days using the Dynamics 365 calendar in personal settings. By default, this option is selected. More information [Configure your work availability](personalize-sales-accelerator.md#configure-your-work-availability). 
        - **Outlook**: Allows sellers to configure work hours and vacation days through the Outlook calendar. Sellers should have an Exchange license to use this option.

    :::image type="content" source="media/sa-ar-sales-team-define-seller-availability-configuration.png" alt-text="Screenshot of configuring seller availability settings page.":::            

1.	Select **Save**.

## How can I manage seller availability?

As a sales manager, you can manage sellers' availability in the following ways:

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
[Manage seller attributes](manage-seller-attributes.md)
