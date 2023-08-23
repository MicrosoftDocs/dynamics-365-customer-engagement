---
title: "Maintain up-to-date forecast data (Dynamics 365 Sales) | MicrosoftDocs"
description: "Maintain up-to-date forecast data in Dynamics 365 Sales."
ms.date: 03/29/2023
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.custom: 
  - dyn365-sales
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-msdyn_forecastinstance
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---
# Maintain up-to-date forecast data 

Forecast data is automatically recalculated after every 24 hours to keep the data current. You can also trigger a manual calculation if you want a change to be immediately reflected in the forecast.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|


## Recalculate and refresh forecast data manually

Forecast data is automatically recalculated after every 24 hours. The **Last updated** label on the command bar shows the time when the forecast was last recalculated successfully.

If you know that the underlying data has changed, you can trigger a manual recalculation.

1. [Open the forecast](view-forecasts.md).

1. Select **Recalculate data**.
    :::image type="content" source="media/forecast-select-recalculate.png" alt-text="Screenshot of the Recalculate data option in the forecast.":::

    A notification appears at the top of the screen, confirming the recalculation. Recalculation happens in the background, and you can continue to work while recalculation is in progress.

    > [!div class="mx-imgBorder"]
    > ![Notification to confirm recalculation.](media/forecast-recalculate-data-toast-notification.png "Notification to confirm recalculation")

2. After the application recalculates the forecast data, a notification appears to refresh the data. On the notification, select **Refresh page**. You'll notice the following updates to the forecast:

    -	The aggregation and roll-ups for the underlying data are recalculated.
    
    -	Any target or quota changes are checked and updated.
    
    -	Any other changes affecting the forecast values (excluding hierarchy changes) are refreshed.
    
    -	Only the current forecast period is recalculated.
    - No changes are made to the forecast values that were manually adjusted.
    - No changes are made to the **Prediction** column. Predictions are only recalculated after every seven days. Hover over the information icon on the column header to view the last recalculation date.
    
[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)<br>

[View a forecast](view-forecasts.md)<br>

[Analyze revenue outcome by using predictive forecasting](/dynamics365/ai/sales/analyze-revenue-outcome-using-predictive-forecasting)

[Troubleshooting forecasts](ts-forecasts.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
