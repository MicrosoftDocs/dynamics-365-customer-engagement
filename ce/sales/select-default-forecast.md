---
title: "Select a default forecast (Preview)"
description: "When you have multiple forecast configurations, you can select the most used forecast configuration as the default."
ms.date: 02/24/2022
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
searchScope: 
  - D365-App-msdynce_saleshub
  - D365-Entity-msdyn_forecastconfiguration
  - D365-UI-*
  - Dynamics 365
  - Sales
  - Customer Engagement
---
# Preview: Select a default forecast 

When you have multiple forecast configurations, you can select the most used one as the default forecast. When a user opens the forecasts page, the default forecast is displayed until they switch to a different forecast.

> [!NOTE]
> You can also specify the default experience for the underlying records of the forecast. More information: [Preview: Set the default experience for underlying records](forecast-configure-advanced-settings.md#preview-set-the-default-experience-for-underlying-records).

## License and role requirements

| &nbsp; | &nbsp; |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Forecast Manager<br> See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## To select a default forecast

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]
  
1.  In the **Sales Hub** app, select the Change area icon ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area"), and then select **App Settings**.    

2.  Under **Performance management**, select **Forecast configurations**.     
    The forecast configuration page opens.
3.  Select the More options (three-dots icon) and select **Set as default (Preview)**.
    > [!NOTE]
    > This option is only displayed for active forecasts.

    :::image type="content" source="media/default-forecast.png" alt-text="Screenshot of the Set as default option."::: 
 
4. (Optional) To verify whether the selected forecast is set as the default, switch to the **Sales** area and open the Forecasts page from **Performance** > **Forecasts**.
    
    The forecast that you've selected as the default is displayed.
    > [!NOTE]
    > The most recent selection of the user overrides the default selection for that user. For example, if a user switches to a different forecast, that forecast is displayed when they access the forecasts page next time.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also
[View a forecast](view-forecasts.md)  

