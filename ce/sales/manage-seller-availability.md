---
title: Manage seller availability
description: Manage sellers' availability to provide a more flexible and accommodating work environment.
author: udaykirang 
ms.author: udag 
ms.reviewer: shujoshi
ms.topic: how-to 
ms.date: 03/15/2023
ms.custom: bap-template 
---

# Manage seller availability

As a sales manager, you can manage the availability of your sales team according to the needs of your business. By doing so, you can create a more flexible and accommodating work environment, allowing your team to take time off or switch shifts as needed. This can result in a more productive sales team, which in turn can improve customer satisfaction and increase sales.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## How can I manage sellers availability?

You can manage sellers availability in the following ways:

- **Advance settings**: Update the sellers' work hours through the advanced settings. 
 
    1. Go to **Advanced Settings** > **Settings** > **System** > **Security** > **Users**.  

    1. Open the user record you want to set work hours for. 

    1. On the top, select the arrow next to the name of the user. 

    1. Select **Work Hours**.  

    1. On the **Monthly View** tab, double-click a date on the calendar that is the first day you want the new schedule to start, or any date that will be affected by the new schedule.

    1. In the **Edit Schedule** dialog box, select one of the following, and then select **OK**. 

        - **This date only**: This option changes only the date selected. Double-click the day, and then select **OK**. Then, perform step 11 in the procedure.
            
        - **From *this date* onward**: This option changes only the schedule going forward.
        
        - **Entire recurring weekly schedule from start to end**: This option changes this entire schedule from the start to end date.   
            Selecting this option might change past days, which could affect reports regarding hours worked in the past.

    1. In the **Weekly Schedule** dialog box, in the Set the recurring weekly schedule section, select one of the following:

        - **Are the same each day**: The new schedule is the same for every day of the week. After you select this option, select the days of the week that the resource is available.

        - **Vary by day**: The new schedule is different for one or more days of the week. After you select this option, select the days of the week that the resource is available.

        - **None. Resource is not working**: The new schedule includes time that the resource isn't working.
        
        Also, you can do any of the following:

        - If the schedule is for more than one day, select the days of the week that this schedule is effective.

        - If the resource doesn't work during business closures, select the Observe option.

        - Under **Date Range**, in the **Starting on** box, you can change the date the schedule starts.
        
            You can't change the date the schedule ends. To end a schedule, you must define a new schedule on that date.

    1. Choose the work hours link for the schedule you want to modify. 

        If work hours haven't been set previously, the link is displayed as "Set Work Hours."
    
    1. In the **Set Work Hours and Service Restrictions** dialog box, complete the following fields, and then select **OK**:

        - **Date**: Select a date from which the work hours for services are to be considered.

        - **Start**: Select the time the work day starts.

        - **End**: Select the time the work day ends.

        To add a break in the work hours, such as a lunch break, select Add Break, and then select the start and end time of the break.

    1. To define a time when a service won't be available, on the **Service Restrictions** tab, select **New**. In the **Edit a Service Restriction** dialog box, select the service, and select the start and end time between which the service will be unavailable, and then select **OK**.

    1. Select **Save and Close** to close the **Weekly Schedule** dialog box.

- **Calendar API**: Use the calendar API and enter the value of the ```EntityLogicalName``` string as ```msdyn_extendedusersetting```. More information: [Edit work hour calendars by using APIs](/dynamics365/field-service/field-service-work-hours-calendar-api). 
 
- **Assignment rules**: In Assignment rules, create a seller attribute based on seller availability and then apply appropriate values to the sellers based on their availability. For example, create an attribute with the values **Available** and **On vacation**. When a seller goes on vacation, you can select the attribute and assign the **On vacation** value to notify that the seller isn't available. More information: [Manage seller attributes in assignment rules](manage-seller-attributes.md) 

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Seller availability](customize-sales-accelerator-sellers.md#seller-availability)   
[Manage seller attributes in assignment rules](manage-seller-attributes.md)

