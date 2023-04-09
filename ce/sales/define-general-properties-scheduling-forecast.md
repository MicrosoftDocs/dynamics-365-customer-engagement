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

# Define a forecast's general properties and scheduling

Use general properties and scheduling options to define a forecast model.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Forecast Manager<br> More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## Define the forecast's general properties

1. In the **General** step of the **Forecast configuration** page, enter a descriptive name for the forecast. In our example, we'll enter *Kenny's Org FY2022 Forecast*.

    :::image type="content" source="./media/forecast-general-properties-forecast-name.png" alt-text="A screenshot of the General step of the Forecast configuration page, with the forecast name entered.":::

1. Select a **Rollup entity**.

    The forecast is based on the gross rollup of the entity you select. Each forecast template starts with a default rollup entity:

    | Template | Default rollup entity |
    |----------|-----------------------|
    | Org chart forecast | Opportunity |
    | Product forecast | Opportunity Product |
    | Territory forecast | Opportunity |

    Choose a custom or out-of-the-box entity to support your organization's specific requirements if needed.

    Only entities that have **Change Tracking** turned on are listed. To learn more, see [Enable change tracking to control data synchronization](/power-platform/admin/enable-change-tracking-control-data-synchronization).

    :::image type="content" source="./media/forecast-general-properties-rollup-entity.png" alt-text="A screenshot of the General step of the Forecast configuration page, with the rollup entity selected.":::

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

    In the following example, we selected **Opportunity** as the rollup entity and **Territory** as the hierarchy entity. Because there's no direct relationship between them, we must select the **Related** tab.

    :::image type="content" source="./media/forecast-relationship-entity-related-attribute-none.png" alt-text="A screenshot of forecast configuration General settings, showing that there's no direct relationship between the selected rollup and hierarchy entities.":::

    In our example, the **Territory** field in the **Related** list is indirectly related to **Opportunity** through the **Account** entity. In other words, **Account** is an intermediate entity for establishing a relationship between **Opportunity** and **Territory**.

    :::image type="content" source="./media/forecast-relationship-entity-related-attribute-account-user.png" alt-text="A screenshot of the General step of the Forecast configuration page, with the related field selected.":::

    The relationship is mapped as *Opportunity > Account (Account) > Territory (Territory) > Territory*. The mapping specifies that there's a field **Account** in the **Opportunity** entity that's related to the **Account** entity. The **Account** entity in turn has a **Territory** field that's related to the **Territory** entity. The rollup values in the forecast are based on the relationship defined through the **Territory** field.

1. In the **Top of hierarchy** list, select a value that will be at the top of this forecast hierarchy.

    The list of values depends on the hierarchy entity you selected. For example, if you select **User** as the hierarchy entity, the list displays active users in your organization.

    Let's say that Kenny Smith, a sales director, wants to see a forecast for his team. He builds a forecast based on the **Org chart** template and selects his name as the top of the hierarchy. His team's hierarchy is previewed to the right of the forecast options.

    :::image type="content" source="./media/forecast-general-tab-configuration-section.png" alt-text="A screenshot of the General step of the Forecast configuration page, with a preview of the selected hierarchy shown.":::

1. [Schedule the forecast](#schedule-the-forecast) using basic or advanced options, as in the following section.

1. When you've finished scheduling, select **Next**.

## Schedule the forecast

Basic scheduling uses the Gregorian calendar, with 12 weeks per quarter. Use [advanced scheduling](#advanced-scheduling) if your organization uses a different calendar.

### Basic forecast scheduling

1. In the **Scheduling** section, specify the following information.

    | Option | Description |
    | --- | --- |
    | **Forecast period** | Select whether the forecast is generated monthly or quarterly. By default, **Quarterly** is selected. |
    | **Fiscal year** | Select the fiscal year for the forecast. The fiscal year list is populated based on your organization's [fiscal year settings](/power-platform/admin/work-fiscal-year-settings). |
    | **Forecast starts at** | Select the time period to start forecasting. If you select **Monthly**, select the month you want to start forecasting. If you select **Quarterly**, select the quarter you want to start forecasting. |
    | **Number of periods** | Enter the number of forecast periods to generate. Forecasts can span up to one year. |
    | **Valid from** and **Valid to** | These settings are read-only. They identify the dates the forecast starts and ends and are taken from your organization's fiscal year settings. |

    :::image type="content" source="./media/forecast-general-tab-scheduling-section.png" alt-text="A screenshot of the General step of the Forecast configuration page, with the Scheduling options shown.":::

    Scheduling supports fiscal years that span multiple calendar years and fiscal months that span multiple calendar months. Let's say your organization's fiscal year runs from July 1 to June 30. To schedule a monthly forecast for the fiscal year 2022, select the values as follows:

    - **Forecast period**: **Monthly**
    - **Fiscal year**: **FY2022**
    - **Start this forecast**: **July**
    - **Number of periods**: **12**

    :::image type="content" source="./media/forecast-schedule-org-select-name.png" alt-text="A screenshot of the General step of the Forecast configuration page, with scheduling options set to create a monthly forecast for FY2022.":::

    When you select a monthly forecast period, another option, **Start this forecast on fiscal start date month**, becomes available. Turn on this setting if you want the forecast’s first month to be the **Valid from** month. If you leave it turned off, the forecast’s first month will be the month following the **Valid from** month.

## Advanced scheduling

Turn on **Enabled advanced scheduling** to create a forecast that's based on the calendar your organization uses.

:::image type="content" source="./media/forecast-adv-scheduling-enable-preview.png" alt-text="A screenshot of the General step of the Forecast configuration page, with advanced scheduling options shown.":::

More options are available when you turn on advanced scheduling:

- **Fiscal Year Start Date**: Select the date your organization's fiscal year starts.
- **Calendar Template**: Select the template that corresponds to the number and grouping of accounting periods in your organization's calendar.

    | Calendar template | Description |
    | --- | --- |
    | **4-4-5**, **4-5-4**, and **5-4-4**\* | This pattern divides a year into four quarters of 13 weeks each, with two 4-week months and one 5-week month in each quarter. In the 5-4-4 and 4-4-5 patterns, the 5-week month falls at the start or end of the quarter, respectively. With 13-week quarters, the period always ends on the same day of the week. This pattern is useful for shift or manufacturing planning, because every period is the same length. |
    | **Gregorian** | By default, this pattern is a 12-month period between January 1 and December 31. You can choose a different start and end date. |
    | **Broadcast Calendar** | In this pattern, every month has either four or five weeks that all start on Monday and end on Sunday. Broadcast calendar months have either 28 days or 35 days.<br>The key link between the broadcast and Gregorian calendars is that the first week of every broadcast month always contains the first day of the month on the Gregorian calendar. For example, if January 1 falls on a Saturday, the broadcast calendar year begins on the preceding Monday, December 27. Broadcast January has five weeks and ends on January 30. The four weeks of broadcast February begin on January 31. The number of weeks in a broadcast month is based on the number of Sundays that fall in that month. The period ends on the last Sunday of the month.<br>When you choose this option, the **Fiscal Year Start Date** is automatically set to the Monday in the week that contains January 1. To remained aligned with the established broadcast calendar logic, the start date can't be changed. |
    | **3-3-3-4**, **3-3-4-3**, **3-4-3-3**, and **4-3-3-3**\* | This pattern divides a year into 13 months of 4 weeks each, with three 3-week months and one 4-week month in each quarter. For example, in the 4-3-3-3 and 3-3-3-4 calendars, the 4-week month falls at the start or end of the quarter, respectively. |

    :::image type="content" source="./media/forecast-adv-scheduling-445-pattern.png" alt-text="A screenshot of advanced forecast scheduling options, with a 4-4-5 calendar pattern shown.":::

    \*The 4-4-5/4-5-4/5-4-4 and 3-3-3-4/3-3-4-3/3-4-3-3/4-3-3-3 calendars have only 364 days (7 days &times; 52 weeks). You'll need to add a fifty-third week every five or six years, which might make year-on-year comparison difficult.

    To add an extra week to a specific quarter or month, select the period in the preview, and then select **Add Week**.

    :::image type="content" source="./media/forecast-adv-scheduling-445-pattern-add-week.png" alt-text="A screenshot of advanced forecast scheduling options, with the first month in the forecast period selected to receive an extra week.":::

    To remove an extra week, select the period in the preview, and then select **Reset Added Week**.

    :::image type="content" source="./media/forecast-adv-scheduling-445-pattern-add-week-added.png" alt-text="A screenshot of advanced forecast scheduling options, with an extra week added to the first month in the forecast period.":::

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
