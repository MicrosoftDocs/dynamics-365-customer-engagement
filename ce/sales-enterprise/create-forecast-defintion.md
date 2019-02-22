---
title: "Create a forecast definition (Dynamics 365 for Sales) | MicrosoftDocs"
description: "Define the data and period to use for the purpose of forecasting in Dynamics 365 for Sales."
keywords: ""
ms.date: 02/28/2019
ms.service:
  - "dynamics-365-sales"
ms.custom:
  - "dyn365-sales"
ms.topic: article
applies_to:
  - "Dynamics 365 for Customer Engagement"
  - "Dynamics 365 for Customer Engagement apps version 9.1"
ms.assetid: 1517b3d4-639b-4fec-bbbc-8474320d1867
author: shubhadaj
ms.author: shujoshi
manager: annbe
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
topic-status: Tech Reviewing
---

# Create a forecast definition

1.	Make sure that you have the System Administrator, System Customizer, Sales Manager, Forecast manager, Vice President of Sales, Vice President of Marketing, or CEO-Business Manager security role or equivalent permissions.

2.  Select the site map icon ![Icon to open site map](media/site-map-new.png "Icon to open site map"), and in the lower left in the site map, select the **Change area** icon ![Icon to change the work area](media/change-area-icon.png "Icon to change the work area"), and then select **App Settings** area.	

3.	In the site map, select **Forecast definitions**.
 
4.	On the command bar, select **New**.

5.	In the **General** section of the Forecast definition record, enter the following information:

    -  **Forecast name**. Enter a descriptive name that explains what the forecast is about. For example, My team’s forecast.

    -  **Forecast metric**. Select a metric for forecasting. It is a look up to the “Goal metric” entity. The field that you select here is used in aggregating data for the forecast. Only the opportunity fields of type amount (revenue) are available for selection. 
    
    -  **Quota source**. Select whether the targets used for the purpose of forecasting will be based on existing goals or manual targets. If this is set to Goal based, then when the forecast is being generated, the system looks up for the matching goal based on the forecast metric and rollup query In-progress(Money) you’ve selected and the Goal owner, and uses the quota/target defined in the goal.

    - **Rollup query**. It is a look up to the **Rollup query** entity. Select a rollup query to define which records to consider for forecasting. For example, to include only the opportunities coming from the East region in the forecast, you can create a rollup query to filter only the opportunities with accounts in 
    the East region and use it in the forecast definition.

        > [!NOTE]
        > Only the rollup queries with opportunity as the parent entity are available/valid for selection.

    ![Forecast definition record](media/forecast-definition-form.png "Forecast defnition record")

6.  In the **Scheduling**section of the Forecast definition form, enter the following:

    -  **Forecast period**. Select whether the forecast is to be generated monthly, quarterly or for a custom period. Quarterly is selected by default.

    -  **Fiscal year**. Select the fiscal year for the forecast. This is populated based on the org’s fiscal year settings.

    -  **Start month/Start quarter**. Select when to start forecasting. If you select the forecast period as Monthly, select the month from which you want to start forecasting. If you select the forecast period as Quarterly, select the quarter from which forecasting should start.

    -  **No. of forecasts**. Enter the number of forecasts that need to be generated. You can only create one forecast when the Forecast period is custom. 

        > [!NOTE]
        > If you select the Forecast period as monthly, Fiscal year as FY19, Start month as January, and No. of forecasts as 4, the forecasts that are generated are grouped by four months, January, February, March, and April. In such case, the Forecast start and end date is automatically set to Jan 1, 2019 and April 30, 2019, respectively.

    -  **Start date**. If you selected **Custom** in **Forecast period**, select the start date to identify the date when the forecasting should start.

    -  **End date**. If you selected **Custom** in **Forecast period**, select the start date to identify the date when the forecasting should start.

7.	Select **Save**.

8.	To generate forecasts based on this definition, publish the forecast definition. On the command bar, select **Publish**. After a forecast definition is published, it becomes read-only.
 
Generating a forecast is a background process. After all the forecasts are generated, the forecast definition’s state and status is set to Published and Success respectively.

![Published forecast defnition](media/published-forecast-definitions.png "Published forecast defnition")


### See also
[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)  
