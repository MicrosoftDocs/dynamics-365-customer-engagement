---
title: Recalculate forecasts manually
description: Trigger a manual recalculation to refresh forecast data immediately instead of waiting for automatic recalculation.
ms.date: 03/11/2025
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom:
  - dyn365-sales
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:09/01/2023
  - bap-template
searchScope:
  - D365-App-msdynce_saleshub
  - D365-Entity-msdyn_forecastinstance
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---

# Recalculate forecasts manually

You want the forecast data to be up-to-date to make informed decisions. Forecast data is automatically recalculated at regular intervals. However, you can trigger a manual recalculation when you want to recalculate the forecast data immediately. You can also trigger a manual recalculation for past and future periods as they aren't automatically recalculated. [Learn more about when and how forecast recalculation happens](forecast-recalculation-methods.md).

## Recalculate and refresh forecast data manually

1. [Open the forecast](view-forecasts.md). Verify the **Last updated** timestamp on the command bar to know when the forecast was last recalculated successfully.


1. Select **Recalculate data**.
    :::image type="content" source="media/forecast-select-recalculate.png" alt-text="Screenshot of the Recalculate data option in the forecast.":::

    A notification appears at the top of the screen, confirming the recalculation. Recalculation happens in the background, and you can continue to work while recalculation is in progress.

    :::image type="content" source="media/forecast-recalculate-data-toast-notification.png" alt-text="Screenshot of the notification to confirm recalculation.":::

2. After the application recalculates the forecast data, a notification appears to refresh the data. On the notification, select **Refresh page**. [Learn more about what happens during  recalculation](forecast-recalculation-methods.md#what-happens-during-recalculation).

  
[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

- [Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)<br>

- [View a forecast](view-forecasts.md)<br>

- [Analyze revenue outcome by using predictive forecasting](/dynamics365/ai/sales/analyze-revenue-outcome-using-predictive-forecasting)

- [Troubleshooting forecasts](ts-forecasts.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
