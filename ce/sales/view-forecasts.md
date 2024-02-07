---
title: View a forecast 
description: Learn how to review forecasts in Dynamics 365 Sales to know the health of your pipeline or to track how your sales team is doing against their quota or target.
ms.date: 09/01/2023
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - dyn365-sales
  - bap-template
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-msdyn_forecastinstance
  - D365-Entity-forecastdefinition
  - D365-Entity-msdyn_forecastconfiguration
  - D365-Entity-msdyn_forecastdefinition
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---
# View a forecast

Forecasts help you to see the health of your pipeline or to see how your sales team is doing against their quota or target.

The forecast feature isn't supported on mobile devices.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>For more information, see [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/).
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  For more information, see [Primary sales roles](security-roles-for-sales.md#primary-sales-roles).

## Open and view a forecast

Bottoms-up forecasting is the projection of what a salesperson, team, or organization sells in a given predefined period (week, month, quarter, or annual). Sellers can also use forecasts to track their performance by using assigned sales targets or quotas.

**To view a forecast**

1. [Review the prerequisites](project-accurate-revenue-sales-forecasting.md#review-prerequisites).

1. Sign in to the Sales Hub app.

1. At the bottom of the site map, select **Change area** ![Change area icon.](media/change-area-icon.png "Change area icon"), and then select **Sales**.

    > [!div class="mx-imgBorder"]
    > ![Icon to change area in the site map.](media/site-map-area.png "Icon to change an area of the site map")

1. Under **Performance**, select **Forecasts**.

1. On the grid page, complete the following actions:
    - Select a forecast from the dropdown list on the left. Any forecasts for which you have permissions appear here.

    - Choose the forecast period you want to see from the dropdown list on the right.
        - Options in the dropdown list reflect the number of forecast periods defined in the forecast configuration. The default is the current period.
        - To rearrange the forecast periods in the dropdown list, contact your administrator. For more information, see [Rearrange forecast periods](manage-forecast-periods.md#rearrange-forecast-periods).

    :::image type="content" source="media/forecast-view-drop-down.png" alt-text="Screenshot of the forecast view with the forecast and forecast period drop-down lists highlighted.":::

1. Verify the **Last updated** time stamp to see when the forecast was last recalculated successfully. When you make any adjustments to the forecast or changes to the underlying records on the **Forecasts** page, the forecast is immediately recalculated. However, if you're updating the underlying records on the opportunities page or updating the forecast hierarchy, select **Recalculate data** to manually recalculate the forecast and refresh the page. For more information, see [Maintain up-to-date forecast data](keep-forecast-data-up-to-date.md).  

    The forecast grid displays all relevant columns as defined in the forecast configuration. The system aggregates the totals by user or by territory at each level of the hierarchy and for each period according to the forecast column attributes.

   The values displayed in the grid are based on the fields configured in your forecast. If these values don't match the values you expected, verify the [fields used for aggregation](choose-layout-and-columns-forecast.md#configure-columns).

    For example, if you're using the out-of-the-box **Forecast category** on an org chart forecast, the grid displays the following information:

    - **Users**: Shows the hierarchy of users as defined by the **Manager** field. To learn more, see [Forecasts and sales hierarchy](#forecasts-and-sales-hierarchy).

    - **Quota**: A target amount set for a specific owner over a given time frame. The progress bar is calculated against this value.

    - **Committed**: Shows the aggregated (rolled-up) value of estimated revenue for all open opportunities that have the forecast category set as **Committed** (high confidence). This value can be adjusted during forecast.

    - **Best case**: Shows the aggregated (rolled-up) value of estimated revenue of all open opportunities that have the forecast category set as **Best Case** (medium confidence). This value can be adjusted during forecast.

    - **Pipeline**: Shows the aggregated (rolled-up) value of estimated revenue for all open opportunities that have the forecast category set as **Pipeline** (low confidence). This value can be adjusted during forecast.

    - **Omitted**: Shows the aggregated (rolled-up) value of excluded revenue for all open opportunities that have the forecast category set as **Omitted**.

    - **Won**: Shows the aggregated (rolled-up) value of revenue generated for all won opportunities with the forecast category set as **Won**.

    - **Lost**: Shows the aggregated (rolled-up) value of revenue lost for all lost opportunities with the forecast category set as **Lost**.

   The permissions granted during the forecast configuration affect who can view the forecast values. To learn more, see [Provide viewing permissions](provide-permissions-forecast.md).

## Forecasts and sales hierarchy

Every forecast is attached to an organization-defined hierarchy that rolls up the values level by level. If the **Org chart forecast** template is used, the forecast is created based on the sales team hierarchy as defined by the manager role on the **User** record. Similarly, if the **Territory forecast** template is used, the hierarchy is based on the **Territory manager** lookup field.

For example, you created a forecast by using the **Org chart forecast** template. The hierarchy is defined based on the **User** record. If Alyce Durham is a sales manager with one direct report, and is designated as manager in the direct report's **User** record, Alyce sees a forecast for both users. Because Alyce Durham reports to Samuel Strom, Samuel sees their own forecasts along with the rolled-up forecasts of their direct reports, including Alyce's.

> [!div class="mx-imgBorder"]
> ![Forecasts for a manager and direct reports.](media/forecast-for-team-hierarchy.png "Forecasts for a manager and direct reports")

To see the rolled-up forecast for everyone in the hierarchy, expand a specific forecast.

## Select a currency

When your sales teams are spread across different regions, it might be confusing for users in different regions to analyze and understand the forecast if viewing the forecast using the organization's base currency. The multi-currency selection option allows the sales teams to choose and convert the forecast data in real time based on the latest exchange rate to the currencies defined in your organization. This feature aids in better planning, organization, and understanding of the current forecast state.

The real time conversion of forecast data always takes place based on the latest exchange rate defined in your organization.

For example, you have sales teams in the US and Europe. The base currency for your organization is defined as US Dollar and also, Euro is defined as one of the currencies. When you create forecast with multi currency enabled, sales teams open the forecast the data is displayed in Dollar. Sales teams in Europe can select currency as Euro and the forecast data is displayed in Euro. The conversion of currency happens in real time based on the current exchange rate. Also, manual adjustments can be made on the chosen currency.

> [!div class="mx-imgBorder"]
> ![Select currency drop-down.](media/forecast-multi-currency-select.png "Select currency drop-down")

Administrator or forecast manager must enable the option to select currency. For more information, see [Turn on multi-currency selection](forecast-configure-advanced-settings.md#turn-on-multi-currency-selection).

## Tasks you can do on the forecast grid

With the forecast grid, you can do the following tasks:

- [View and manage underlying opportunities](view-and-manage-underlying-opportunities.md)

- [Adjust values in a forecast](adjust-values-in-forecast.md)

- [Maintain up-to-date forecast data](keep-forecast-data-up-to-date.md)

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)<br>
[Configure a forecast](configure-forecast.md)<br>
[Analyze revenue outcome by using predictive forecasting](/dynamics365/ai/sales/analyze-revenue-outcome-using-predictive-forecasting)<br>
[Forecasting FAQs](faqs-sales.md#forecasting)
[Troubleshoot issues with forecasting](/troubleshoot/dynamics-365/sales/troubleshoot-forecast-issues)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
