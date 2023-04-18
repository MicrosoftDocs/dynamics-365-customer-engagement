---
title: "View forecast projection through trend charts"
description: "Use the trend charts to understand how each forecast amount is trending over time, comparing it against the period end prediction and quota."
ms.date: 04/18/2023
ms.custom: 
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
---
# Understand forecast projections by using trend charts 

The **Trend** chart shows how each forecast amount is trending over time, comparing it against the period end prediction and quota. A separate predicted realization line is automatically created to project future revenue over time.  

> [!NOTE]
> The **Trend** chart is available as part of the predictive forecasting feature. Verify that predictive forecasting is enabled for your organization. To learn more, see [About premium forecasting](configure-premium-forecasting.md).

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|


## View trend charts

1.	Sign in to the Sales Hub app.

2.	At the bottom of the site map, select the **Change area** icon, and then select **Sales**.  

3.	Under **Performance**, select **Forecasts**.

4.	Select a forecast, and choose a forecast period for the forecast.

5.	Select the **Trend** tab.

    A line chart is displayed with the comparison between the forecast categories until the present day.

## Understand trend charts

> [!NOTE]
> Columns available for trending can be configured in the forecast configuration. To learn more, see [configure columns](/dynamics365/sales-enterprise/choose-layout-and-columns-forecast#configure-columns).

The following screenshot shows an example of a trend chart.

> [!div class="mx-imgBorder"]
> ![Trend chart](media/predictive-forecasting-trend-chart.png "Trend chart")

The categories displayed on the trend chart depend on the forecast grid columns that your administrator has configured and the prediction columns. For more information on configuring forecast grid columns, see [Configure columns](/dynamics365/sales-enterprise/choose-layout-and-columns-forecast#configure-columns).

The Predicted Realization line displays a solid line for the time period until the last prediction date and a dotted line for the time period after that.  

- The solid line indicates the actual revenue calculated from opportunities that were closed as won.  

- The dotted line indicates the projected revenue for the rest of the forecast period. The projected revenue is calculated using the following formula:
Closed won revenue + (Predicted from open + Predicted from new) 

For more information on prediction columns, see [Analyze revenue outcome by using predictive forecasting](analyze-revenue-outcome-using-predictive-forecasting.md).

When you hover over a forecast category in the legend, the trend line of the forecast category gets highlighted.

You can also view the summary of a forecast category at a given time by hovering over the trend line. The summary displays the date, forecast category, and aggregated opportunity amount.

If you don't want to view any forecast category on the chart, select the forecast category on the legend and the forecast category will be grayed out. To view it again on the chart, select the forecast category.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Analyze revenue outcome by using predictive forecasting](analyze-revenue-outcome-using-predictive-forecasting.md)<br>
[About premium forecasting](configure-premium-forecasting.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
