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

1. [Schedule the forecast](#schedule-the-forecast), as described in the following section. You must add at least one forecast period to go to the next step.

1. When you've finished scheduling, select **Next**.

## Schedule the forecast

In the **Scheduling** section, add forecast periods to match the forecast periods in your organization and how often you want to generate the forecast. Each forecast configuration can have multiple forecast periods with different period types.

### Quick example

Let's say your organization's fiscal year runs from January 1 to December 31. To schedule a monthly forecast for the fiscal year 2023, select the values as follows:

- **Scheduling format**: **Gregorian**
- **Period start date**: **Jan 1, 2023**
- **Forecast period**: **Monthly**
- **Fiscal year**: **FY2023**
- **Start this forecast**: **January**
- **Number of periods**: **12**
  
:::image type="content" source="media/forecast-general-tab-scheduling-section.svg" alt-text="Screenshot of the Scheduling section of the forecast." lightbox="media/forecast-scheduling-fullscreen.svg":::

When you add the above schedule, 12 forecast periods are added to the **Periods for this forecast** table on the right side. Select the image to see the full screen view. For information about each of the above fields, see [Manage forecast periods](manage-forecast-periods.md).



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
[Forecast period rules](forecast-periods.md#forecast-period-rules)  
[Work with fiscal year settings](/power-platform/admin/work-fiscal-year-settings)  
[Troubleshooting forecasts](ts-forecasts.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
