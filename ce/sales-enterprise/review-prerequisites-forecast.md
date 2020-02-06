---
title: "Prerequisites to configure a forecast (Dynamics 365 Sales) | MicrosoftDocs"
description: "Prerequisites to configure a forecast in Dynamics 365 Sales."
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


# Review prerequisites

Verify the following prerequisites:

- You have been assigned the **Administrator** or **Forecast manager** role that will allow you to perform the following tasks:

    -	Create, assign, and edit forecast configurations for your organization.

    -	Delete, activate, and deactivate forecast configurations that have been defined for your organization.

    > [!NOTE]
    > To learn more about assigning a role, see [Assign a security role to a user](/power-platform/admin/create-users-assign-online-security-roles#assign-a-security-role-to-a-user).

- Forecasting is enabled in your organization. To enable forecasting, follow these steps:

    1.	Sign in to the **Sales Hub** app.
    
    2.	At the bottom of the site map, select **Change area** ![Change area icon](media/change-area-icon.png "Change area icon"), and then select **App settings**.

        > [!div class="mx-imgBorder"]
        > ![Select app settings from change area](media/change-area-app-settings.png "Select App settings from the change area")
 
    3.	Under **Performance management**, select **Forecast configurations**.

        > [!div class="mx-imgBorder"]
        > ![Select enable forecast option](media/forecast-enable-select-enable.png "Select the Enable forecasting option")
 
    4.	Select **Enable forecasting**.

    5.	In the confirmation message, select **Enable**. 

    Forecasting is now enabled for your organization, and the following page is displayed:
 
     > [!div class="mx-imgBorder"]
     > ![Forecasting is enabled](media/forecast-enable-forecasting-enabled.png "Forecasting is enabled") 

    Also, when forecasting is enabled, the following changes appear in the **Sales Hub** app:

    -	**Forecasts** appears under **Performance** in the **Sales** site map.
    
        > [!div class="mx-imgBorder"]
        > ![Forecasts option in sales site map](media/forecast-select-sales-performance-forecasts.png "Forecasts option in the Sales site map")
 
    -	**Forecast category** appears on the **Opportunity** form. The categories define the confidence level of closing an opportunity. If necessary, you can add custom values specifically defined for your organization.

        > [!div class="mx-imgBorder"]
        > ![Forecast category option in opportunity form](media/capture-forecast-category-opportunity-form.png "Forecast category in an opportunity form")

        > [!NOTE]
        > **Forecast category** options consists of **Won** and **Lost** opportunity statuses. If an opportunity is set as **Won** or **Lost**, the forecast category automatically changes status through the **Opportunity Forecast Category Mapping Process** out-of-the-box workflow. <br>
        > To view the **Opportunity Forecast Category Mapping Process** workflow, go to **Settings** > **Process Center** > **Processes** and select **All Processes** view. Search and open the **Opportunity Forecast Category Mapping Process** workflow. You can customize or deactivate the workflow according to your organization's requirements. <br>
        > If you're using a custom option set instead of forecast category, you must create a workflow to automatically sync the opportunity status with your option set to ensure that the forecast is projecting accurate values. <br> 
        >  To learn more, see [Use Workflow processes to automate processes that don't require user interaction](/customize/workflow-processes).

<table>
<tr><td>

> [!div class="nextstepaction"] 
> [Next step: Select a template](select-template-forecast.md)
</td></tr>
</table>


### See also

[Configure a forecast in your organization](configure-forecast.md)