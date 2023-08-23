---
title: Define forecast properties and scheduling
description: Define a forecast model using rollup and hierarchy entities and schedule how often to generate the forecast in Dynamics 365 Sales.
ms.date: 03/15/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - dyn365-sales
---

# Define forecast properties and scheduling

Use general properties and scheduling options to define a forecast model.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Forecast Manager<br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Define the forecast's general properties

1. In the **General** step of the **Forecast configuration** page, enter a descriptive name for the forecast. For example, *Kenny's Org FY2023 Forecast*.

1. Select a **Rollup entity**.

    The forecast is based on the gross rollup of the entity you select. Each forecast template starts with a default rollup entity:

    | Template | Default rollup entity |
    |----------|-----------------------|
    | Org chart forecast | Opportunity |
    | Product forecast | Opportunity Product |
    | Territory forecast | Opportunity |

    Choose a custom or out-of-the-box entity to support your organization's specific requirements if needed.

    Only entities that have **Change Tracking** turned on are listed. To learn more, see [Enable change tracking to control data synchronization](/power-platform/admin/enable-change-tracking-control-data-synchronization).

1. Select a **Hierarchy entity**.

    The forecast uses this entity to group your organization's data. Only entities that have a hierarchy are shown in the list.

    Each forecast template starts with a default hierarchy entity:

    | Template | Default hierarchy entity |
    |----------|--------------------------|
    | Org chart forecast | User |
    | Product forecast | Product |
    | Territory forecast | Territory |

1. Select a **Rollup to hierarchy relationship**.

    This step establishes a relationship between the rollup and hierarchy entities. Each forecast template starts with a default rollup to hierarchy relationship:

    | Template | Rollup to hierarchy relationship | Description |
    |----------|----------------------------------|-------------|
    | Org chart forecast | Opportunity > Owner (User) > User | The forecast hierarchy is defined based on the organizational hierarchy. |
    | Product forecast | Opportunity Product > Existing Product (Product) > Product | The forecast hierarchy is defined based on the product hierarchy. |
    | Territory forecast | Opportunity > Account (Account) > Territory (Territory) > Territory | The forecast hierarchy is defined based on the territory hierarchy. |

    Choose different values to support your organization's specific requirements if needed.

    In the following example, we selected **User** as the hierarchy entity. We can choose from fields in the **Opportunity** entity that are related to the **User** entity.

    :::image type="content" source="./media/forecast-relationship-entity-attribute.png" alt-text="A screenshot of the General step of the Forecast configuration page, with Hierarchy entity and Rollup to hierarchy relationship shown.":::

    Continuing our earlier example, we selected **Owner (User)** as the relationship. The relationship is mapped as *Opportunity > Owner (User) > User*. The mapping specifies that **Owner** is in the **Opportunity** entity that has a relationship with the **User** entity.

    :::image type="content" source="./media/forecast-relationship-entity-attribute-created-by.png" alt-text="A screenshot of the General step of the Forecast configuration page, with Rollup to hierarchy relationship mapped.":::

    What if there is no direct relationship between the rollup entity and the hierarchy entity? In that case, you can choose a field from a related entity to define an indirect relationship. Select the **Related** tab, and then choose a field from the list. Only fields in hierarchical entities are shown in the **Related** list.

    For example, if we selected **Opportunity** as the rollup entity and **Territory** as the hierarchy entity, we must select the **Related** tab as there's no direct relationship between opportunity and territory entities. However, they are indirectly related through the **Account** entity. In other words, **Account** is an intermediate entity for establishing a relationship between **Opportunity** and **Territory**.

    :::image type="content" source="./media/forecast-relationship-entity-related-attribute-account-user.png" alt-text="A screenshot of the General step of the Forecast configuration page, with the related field selected.":::

    The relationship is mapped as *Opportunity > Account (Account) > Territory (Territory) > Territory*. The mapping specifies that there's a field **Account** in the **Opportunity** entity that's related to the **Account** entity. The **Account** entity in turn has a **Territory** field that's related to the **Territory** entity. The rollup values in the forecast are based on the relationship defined through the **Territory** field.

1. In the **Top of hierarchy** list, select a value that will be at the top of this forecast hierarchy.

    The list of values depends on the hierarchy entity you selected. For example, if you select **User** as the hierarchy entity, the list displays active users in your organization.

    Let's say that Kenny Smith, a sales director, wants to see a forecast for the team. Kenny builds a forecast based on the **Org chart** template and selects their own name as the top of the hierarchy. The team's hierarchy is previewed to the right of the forecast options.

    :::image type="content" source="./media/forecast-general-tab-configuration-section.png" alt-text="A screenshot of the General step of the Forecast configuration page, with a preview of the selected hierarchy shown.":::

1. [Schedule the forecast](#schedule-the-forecast), as in the following section.

1. When you've finished scheduling, select **Next**.

## Schedule the forecast

In the **Scheduling** section, add forecast periods to match the forecast periods in your organization and how often you want to generate the forecast. Each forecast configuration can have multiple forecast periods.  

### Quick example

Let's say your organization's fiscal year runs from January 1 to December 30. To schedule a monthly forecast for the fiscal year 2023, select the values as follows:

- **Scheduling format**: **Gregorian**
- **Period start date**: **Jan 1, 2023**
- **Forecast period**: **Monthly**
- **Fiscal year**: **FY2023**
- **Start this forecast**: **January**
- **Number of periods**: **12**
  
:::image type="content" source="media/forecast-general-tab-scheduling-section.svg" alt-text="Screenshot of the Scheduling section of the forecast." lightbox="media/forecast-scheduling-fullscreen.svg":::

When you add the above schedule, 12 forecast periods will be added to the table on the right side. Select the image to see the full screen view. For more information about each of the fields, see [Scheduling options](#scheduling-options).

### Important considerations

Before adding and scheduling forecast periods, review the following pointers:

- You can add multiple periods, with different forecast frequency. For example, you can add a quarterly forecast for the first six months of the fiscal year and a monthly forecast for the remaining six months.

- You can have different forecast recurrences for the same period to track your team's forecast at multiple intervals. For example, towards the end of the quarter, you may want to track your team's forecast on a weekly basis, in addition to the monthly forecast. For example, you can have a monthly forecast for the month of September and a weekly forecast for the same month. However, you can't add duplicate periods with the same recurrence and period.  
- You can add up to 17 periods to a forecast configuration.
- You can add new periods to a forecast configuration at any time. If the forecast is already activated, you need to reactivate the forecast for the new periods to take effect.  
- You can't edit a forecast period after it's added. You can only delete the period and add a new one.

### Scheduling options

The following table describes the fields in the **Scheduling** section.

| Option | Description |Example scenario |
| --- | --- | --- |
| **Scheduling format** | Select a calendar template that corresponds to the number and grouping of accounting periods in your organization's calendar. [Learn more about the available calendar templates](#calendar-templates). | Select **Gregorian** if your organization uses the most-widely used Gregorian calender with 12 weeks per quarter. |
| **Period start date** | Select the date from when the forecast period starts. This date can be the date when your fiscal year starts. For Broadcast calender template, this value can't be changed as this value is already preset to the first Monday that contains January 1. | If your organization's fiscal year starts on July 1, select **July 1**. You'll then be able to create forecasts for the period from July 1 to June 30 of the following year. If you want to track your team's forecast a few weeks ahead of the organization's fiscal year, set the start date to a few weeks before the fiscal year start date.  |
| **Forecast period** | Select the frequency of the forecast. Specify whether you want a weekly, monthly, quarterly, or yearly forecast. The forecast period determines the granularity and recurrence of the forecast. | Select **Monthly** to generate a forecast for every month. |
| **Fiscal year** | Select the fiscal year for the forecast. | Select **FY2023** if you're creating a forecast for the fiscal year 2023. |
| **Start this forecast** | Select the exact week, month, quarter, or year for the forecast period.  | If you've selected **Monthly** as the forecast period, select **July** as the start month. |
| **Number of periods** | Enter the number of forecast periods to generate. Forecast periods can only span up to one year. | If you've selected monthly forecast and selected **July** as the start month, and number of periods as 6, then 6 forecast periods will be configured for the period from July to December. When you select **Add period**, a forecast for each month will be added to the table on the right side. |
| **Start this forecast on fiscal start month** | Applicable only for monthly forecasts. When you turn this option on, the period name will be based on the month in the **Period Start Date**. Otherwise, it'll be based on the month in the **Start this forecast** field. | For a period that's set to start on July 15, 2023 and forecast month set to August, the period name will be set as **FY2023 July** if this option is turned on. If it's turned off, the period name will be set as **FY2023 August**. |


### Calendar templates

The following table describes the calendar templates available for scheduling forecasts.

| Calendar template | Description |
| --- | --- |
| **Gregorian** | This template uses the most-widely used Gregorian calender with 12 weeks per quarter.  |
| **Broadcast Calendar** | In this pattern, every month has either four or five weeks that all start on Monday and end on Sunday. Broadcast calendar months have either 28 days or 35 days.<br>The key link between the broadcast and Gregorian calendars is that the first week of every broadcast month always contains the first day of the month on the Gregorian calendar. For example, if January 1 falls on a Saturday, the broadcast calendar year begins on the preceding Monday, December 27. Broadcast January has five weeks and ends on January 30. The four weeks of broadcast February begin on January 31. The number of weeks in a broadcast month is based on the number of Sundays that fall in that month. The period ends on the last Sunday of the month.<br>When you choose this option, the **Fiscal Year Start Date** is automatically set to the Monday in the week that contains January 1. To remained aligned with the established broadcast calendar logic, the start date can't be changed. |
| **3-3-3-4**, **3-3-4-3**, **3-4-3-3**, and **4-3-3-3**\* | This pattern divides a year into 13 months of 4 weeks each, with three 3-week months and one 4-week month in each quarter. For example, in the 4-3-3-3 and 3-3-3-4 calendars, the 4-week month falls at the start or end of the quarter, respectively. |
| **4-4-5**, **4-5-4**, and **5-4-4**\* | This pattern divides a year into four quarters of 13 weeks each, with two 4-week months and one 5-week month in each quarter. In the 5-4-4 and 4-4-5 patterns, the 5-week month falls at the start or end of the quarter, respectively. With 13-week quarters, the period always ends on the same day of the week. This pattern is useful for shift or manufacturing planning, because every period is the same length. |
| **Custom** |  If none of the predefined calendar templates match your organization's calendar, select **Custom** and specify the start date and end date of your forecast. The Period Name field is populated based on the start and end dates. You can edit the period name, but it'll not be localized. So, even your non-English users will see the period name in English. |

\*The 4-4-5/4-5-4/5-4-4 and 3-3-3-4/3-3-4-3/3-4-3-3/4-3-3-3 calendars have only 364 days (7 days &times; 52 weeks). You'll need to add a fifty-third week every five or six years, which might make year-on-year comparison difficult. Instead, you can add an extra week to a specific quarter or month each year. Select the **Custom** calender template from the **Scheduling format** list. Then, specify the start date and end date of the week.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

<table>
<tr><td>
> [!div class="nextstepaction"]
> [Previous step: Select a template](select-template-forecast.md)
</td><td>

> [!div class="nextstepaction"]
> [Next step: Provide viewing and adjustment privileges](provide-permissions-forecast.md)
</td></tr>
</table>

### See also

[Configure forecasts in your organization](configure-forecast.md)  
[Configure forecasts by using a custom rollup entity](configure-forecast-using-custom-rollup-entity.md)  
[Work with fiscal year settings](/power-platform/admin/work-fiscal-year-settings)  
[Troubleshooting forecasts](ts-forecasts.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
