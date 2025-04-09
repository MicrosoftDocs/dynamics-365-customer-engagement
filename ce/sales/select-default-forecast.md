---
title: "Select a default forecast (Preview)"
description: "When you have multiple forecast configurations, you can select the most used forecast configuration as the default."
ms.date: 01/03/2025
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-msdyn_forecastconfiguration
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---
# Select a default forecast (preview)

If your organization has configured multiple forecasts, save your users time and select one to be displayed by default when they open the Forecasts page.

> [!NOTE]
> You can also specify the default experience for the underlying records of the forecast. More information: [Configure advanced settings for forecasts](forecast-configure-advanced-settings.md).

## To select a default forecast

[!INCLUDE [preview-banner](~/../shared-content/shared/preview-includes/preview-banner-section.md)]

[!INCLUDE [cc-preview-note-sales](../includes/cc-preview-note-sales.md)]

## Select a forecast to be displayed by default
  
1. In the **Sales Hub** app, select the Change area icon ![Icon to change the work area](./media/change-area-icon.png "Icon to change the work area"), and then select **App Settings**.
1. Under **Performance management**, select **Forecast configurations**.
1. On a forecast, select **More actions** ![Vertical ellipsis icon to access more actions](./media/more-vertical-solid-icon.png "Vertical ellipsis icon to access more actions"), and then select **Set as default (Preview)**.

    >[!NOTE]
    >This option is only shown for active forecasts.

    :::image type="content" source="./media/default-forecast.png" alt-text="A screenshot of the Set as default option on the Forecast configuration page.":::

1. (Optional) To confirm that the forecast you selected is set as the default, change to the **Sales** area. Under **Performance**, select **Forecasts**.

>[!NOTE]
>If a user switches to a different forecast, that forecast is displayed instead of the default the next time they open the Forecasts page.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

## Related information

[View a forecast](view-forecasts.md)
