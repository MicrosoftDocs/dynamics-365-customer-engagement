---
title: "Maintain up-to-date forecast data (Dynamics 365 Sales) | MicrosoftDocs"
description: "Maintain up-to-date forecast data in Dynamics 365 Sales."
ms.date: 10/26/2020
ms.service: dynamics-365-sales
ms.custom: dyn365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
searchScope:
  - D365-App-msdynce_saleshub
  - D365-Entity-msdyn_forecastinstance
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement

---

# Maintain up-to-date forecast data

Forecast data is kept up to date by being automatically recalculated at regular intervals. If you're actively interacting with the forecast, a recalculation is triggered when the data is found to be more than 10 minutes old. After the recalculation, you'll be prompted to refresh the forecast grid to show the latest data.

If you're not actively interacting with the forecast, the data is recalculated every hour. The **Last recalculated** label on the command bar shows the time when the forecast was last recalculated successfully.

If you know that the underlying data has changed, you can select **Recalculate** to manually recalculate, and then refresh to view the updated values. When you recalculate: 

-	The aggregation and roll-ups for the underlying data are recalculated.

-	Any target or quota changes are checked and updated.

-	Any other changes affecting the forecast values (excluding hierarchy changes) are refreshed.

-	Only the current forecast period is recalculated.

> [!NOTE]
> The **Recalculate** command doesn't change any value that was manually adjusted.

**To recalculate and refresh forecast data manually**

1. Select **Recalculate** on the command bar.

    > [!div class="mx-imgBorder"]
    > ![Select Recalculate](media/forecast-select-recalculate.png "Select Recalculate")
    
    A notification appears at the bottom of the screen, confirming the recalculation. Recalculation happens in the background, and you can continue to work while recalculation is in progress.

    > [!div class="mx-imgBorder"]
    > ![Notification to confirm recalculation](media/forecast-recalculate-data-toast-notification.png "Notification to confirm recalculation")

2. After the application recalculates the forecast data, a notification appears to refresh the data. On the notification, select **Refresh page**.


    > [!div class="mx-imgBorder"]
    > ![Notification to refresh page](media/forecast-refresh-data-toast-notification.png "Notification to refresh the page")

    > [!NOTE]
    > You can cancel the notification and refresh the data later. Select **Refresh** on the command bar.

After recalculation, the data in the forecast reflects the latest opportunity and hierarchical changes.

### See also

[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)<br>

[View a forecast](view-forecasts.md)<br>

[Analyze revenue outcome by using predictive forecasting](/dynamics365/ai/sales/analyze-revenue-outcome-using-predictive-forecasting)

[Troubleshooting forecasts](ts-forecasts.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]