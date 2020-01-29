---
title: "Enable forecasting (Dynamics 365 Sales) | MicrosoftDocs"
description: "Define how to enable forecasting in Dynamics 365 Sales."
ms.date: 02/03/2020
ms.service: 
  - "dynamics-365-sales"
ms.custom: 
  - "dyn365-sales"
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Enable forecast

To use forecasting in your organization, an administrator must enable the feature through the **Forecast configurations** page. When the feature is enabled, the following changes appear in the **Sales Hub** app:

-	The **Forecasts** option is created under **Performance** in **Sales** site map.
    
    > [!div class="mx-imgBorder"]
    > ![Forecasts option in sales site map](media/forecast-select-sales-performance-forecasts.png "Forecasts option in sales site map")
 
-	The **Forecast category** option set field is displayed on the **Opportunity** form. These categories in the option set define the status of an opportunity. If required, you can add custom option values specifically defined for your organization.

    > [!div class="mx-imgBorder"]
    > ![Forecast category option in opportunity form](media/capture-forecast-category-opportunity-form.png "Forecast category option in opportunity form")

    > [!NOTE]
    > The **Forecast category** option set consists of **Won** and **Lost** opportunity statuses. If an opportunity is set as won or lost, the forecast category will automatically change to won or lost through an out-of-the-box workflow. <br>
    > If you’re using custom options set for the forecast category, you must create a workflow to automatically sync the opportunity status with your forecast category to ensure that the forecast is projecting accurate values. <br>
    > To learn more, see [Use Workflow processes to automate processes that don't require user interaction](/customize/workflow-processes).

To enable forecasting, follow these steps:

1.	Sign in to the **Sales Hub** app.

2.	At the bottom of the site map, select the **Change area** icon, and then select **App settings**.

    > [!div class="mx-imgBorder"]
    > ![Select app settings from change area](media/change-area-app-settings.png "Select app settings from change area")
 
3.	Under **Performance management**, select **Forecast configurations**.

    > [!div class="mx-imgBorder"]
    > ![Select enable forecast option](media/forecast-enable-select-enable.png "Select enable forecast option")
 
4.	Select **Enable forecasting**. A confirmation message is displayed.

5.	Select **Enable**. 

    Forecasting is now enabled for your organization and the following page is displayed:
 
    > [!div class="mx-imgBorder"]
    > ![Forecasting is enabled](media/forecast-enable-forecasting-enabled.png "Forecasting is enabled") 


<table>
<tr><td>

> [!div class="nextstepaction"] 
> [Previous step: Review prerequisites](configure-forecast.md#review-prerequisites)
</td><td>

> [!div class="nextstepaction"] 
> [Next step: Select a template](select-template-forecast.md)
</td></tr>
</table>


### See also

[Configure a forecast in your organization](configure-forecast.md)