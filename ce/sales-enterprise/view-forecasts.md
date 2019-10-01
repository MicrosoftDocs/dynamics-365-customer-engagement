---
title: "View forecasts (Dynamics 365 Sales) | MicrosoftDocs"
description: "See forecasts in Dynamics 365 Sales to know the health of your pipeline or to track how your sales team is performing against their quota or target. Define the data and period to use for the purpose of forecasting in Dynamics 365 Sales."
<<<<<<< HEAD
keywords: ""
ms.date: 04/23/2019
=======
ms.date: 10/01/2019
>>>>>>> 4278d76b7a5c73ae8005957ff730a7629d0d23c7
ms.service: dynamics-365-sales
ms.custom: dyn365-sales
ms.topic: article
ms.assetid: 956295f7-b4d4-49b9-954b-677c5fbf703d
<<<<<<< HEAD
author: udaykirang
ms.author: udag
manager: shujoshi
ms.reviewer: 
ms.suite: 
ms.tgt_pltfrm: 
=======
author: shubhadaj
ms.author: shujoshi
manager: annbe
>>>>>>> 4278d76b7a5c73ae8005957ff730a7629d0d23c7
---

# View forecasts

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

> [!IMPORTANT]
> - [!INCLUDE[cc_preview_features_definition](../includes/cc-preview-features-definition.md)]  
> - [!INCLUDE[cc_preview_features_expect_changes](../includes/cc-preview-features-expect-changes.md)]
> - [!INCLUDE[cc-preview-features-no-ms-support](../includes/cc-preview-features-no-ms-support.md)]


Track your forecasts to project what a sales person, team, or organization will sell against a given target or in a given period such as quarterly or monthly. If you are a sales rep, you can also track forecasts to know how you are doing toward the quota or targets that are set for you.

> [!NOTE]
> To view the forecast, you must a user in the hierarchy for whom the forecast is configured.

1.	Select the site map icon ![Icon to open site map](media/site-map-new.png "Icon to open site map"), and check the lower left corner of the site map to ensure that you are in the **Sales** area. 

    > [!div class="mx-imgBorder"]
     ![Icon to change area in the site map](media/site-map-area.png "Icon to change area in the site map")

3. Select **Forecasts** under **Performance**.

    The forecasts view page displays. 

    > [!div class="mx-imgBorder"]
    > ![Forecast view page](media/forecast-view-page.png "Forecast view page")
    

4.	In the **Forecasts** home page, select the following:

    - **Forecast configuration**: Select a forecast from the drop-down to see the forecasts for it. You’ll see the forecasts that you own or the forecast hierarchy that you are a part of.

    - **Forecast period**: Select a forecast period form drop-down list depends. The list of forecast periods display in the drop-down depends on the number of forecast periods specified for selected forecast in the configuration.
 
    > [!div class="mx-imgBorder"]
    > ![Drop-down list to select forecast](media/forecast-view-drop-down.png "Drop-down list to select forecast")

6. The forecast grid displays the information on the quota and the columns that are defined to view the forecast. For example, while creating the forecast, if the default **Forecast category** option set is selected, then the forecast grid displays the following columns:   

    -	**Users**: Shows the hierarchy for which the forecast is defined for. The users include all the levels under the selected hierarchy. For example, owner of the records that are included in the forecast (participating records) or the name of the manager. To learn more, see [Forecasts and sales hierarchy](#forecasts-and-sales-hierarchy). 

    -	**Quota**: For the specific period and owner, this column shows the limit that an individual should achieve. The values for other columns are calculated based on the quota such as the revenue generation progress. 

    -	**Best case**: For the specific period and owner, this column shows the aggregated or rolled-up value of estimated revenue of all open opportunities that have the forecast category set to **Best case**. This value can be edited inline when the column is set as editable while configuring the forecast. The field becomes editable when you select.

    -  **Committed**: For the specific period and owner, this column shows the aggregated or rolled-up value of estimated revenue of all open opportunities that have the forecast category set to **Committed**. This value can be edited inline when the column is set as editable while configuring the forecast. The field becomes editable when you select. 

    -	**Omitted**: For the specific period and owner, this column shows the aggregated or rolled-up value of excluded revenue of all open opportunities that have the forecast category set to **Omitted**.

    -	**Won**: For the specific period and owner, this column shows the aggregated or rolled-up value of revenue generated of all won opportunities that have the forecast category set to **Won**.

    - **Lost**: For the specific period and owner, this column shows the aggregated or rolled-up value of revenue lost of all lost opportunities that have the forecast category set to **lost**.


## Forecasts and sales hierarchy

Forecasts are shown based on the sales team hierarchy. For example, if Wade Roque is a sales manager with five people reporting directly to him, and he is set as a manager in his direct reports' user records, he will see a forecast for himself and his five direct reports. 

> [!div class="mx-imgBorder"]
> ![Forecasts for a manager and direct reports](media/forecast-for-team-hierarchy.png "Forecasts for a manager and direct reports")

If Wade Roque reports to Bert Hair, Bert will see his own forecasts along with Wade's rolled-up forecast. Bert will not see the forecasts of Wade's direct reports.

To see the rolled-up forecast for everyone in the hierarchy, expand a specific forecast.

The parent row (for the manager) shows values rolled up from all the child records (for the direct reports and manager themselves if the manager is also owning some participating opportunities).
 
## See the participating opportunities

To know which opportunities are contributing to a certain forecast of a user, go to the user row. Hover the cursor over a column and then select the vertical ellipses and select **Show opportunities**.

> [!div class="mx-imgBorder"]
> ![Show opportunities button on the Forecast list](media/forecast-view-show-opportunities.png "Show opportunities button on the Forecast list")
 
The Forecast opportunities dialog box opens. It shows a list of opportunities that were used in forecasting.

> [!div class="mx-imgBorder"]
> ![Forecast opportunities  dialog box shows opportunities included in the forecast](media/forecast-view-opportunities.png "Forecast opportunities dialog box shows opportunities included in the forecast")


## Adjust forecasts

While configuring the forecast, enable the option **Allow adjustments** to make the column editable. This helps you to adjust the value of an opportunity while reviewing the forecasts. For example, if the sales manager thinks that one of his direct report's best case opportunities might not result in $60,000, they can change the value in the forecast to a different value. When you save the forecast after making the adjustment, the changes are rolled up to the parent record. 

Select the filed and the field becomes editable. Enter the value to adjust. In this example, The **Best case** column is configured as editable and you can see the value $500 is adjusted to $1000.

> [!div class="mx-imgBorder"]
> ![Adjusted amount in the forecast](media/forecast-view-adjust-opportunity.png "Adjusted amount in the forecast")

 
## Refresh forecast data

If you expect that the underlying data (participating opportunities) has changed, you can manually recalculate and refresh the forecast to show the updated values. By default, the application automatically recalculates data in the forecast every 10 minutes and toast notifications appear to display the status. The **Last recalculated** option on the command bar shows the time when the forecast was last recalculated successfully.  When you recalculate: 

-	The aggregation and rollups for the underlying data are recalculated.

-	Any forecast metric or rollup query changes are considered.

-	Any target/quota changes or goal references are checked and updated.

-	Any other changes impacting the forecast values (excluding hierarchy changes) are refreshed.

> [!NOTE]
> The Recalculate option doesn’t change any value that was manually adjusted.

To recalculate and refresh the data in the forecast manually, follow these steps:

1. Select **Recalculate** on the command bar.

    > [!div class="mx-imgBorder"]
    > ![Select recalculation](media/forecast-select-recalculate.png "Select recalculation")

2. On the confirmation message, select **Ok**.

    > [!div class="mx-imgBorder"]
    > ![Confirmation message to recalculate](media/forecast-recalculate-data-confirmation-message.png "Confirmation message to recalculate")

    A toast notification appears on the top confirming the recalculation. Recalculation happens in the background and you can continue to work while recalculation is happening.

    > [!div class="mx-imgBorder"]
    > ![Toast notification to confirm recalculation](media/forecast-recalculate-data-toast-notification.png "Toast notification to confirm recalculation")

3. After the application recalculates the forecast data a toast notification appears to refresh the data. On the toast notification, select **Refresh data**.

    > [!div class="mx-imgBorder"]
    > ![Toast notification to refresh data](media/forecast-refresh-data-toast-notification.png "Toast notification to refresh data")

    > [!NOTE]
    > You can cancel the toast notification and refresh the data later. Select **Refresh** on the command bar.

    The data in the forecast reflects the latest opportunity and hierarchical changes.

## See also

[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md)

[Configure forecast](configure-forecast.md)

[Entity reference for manual forecasting](developer/reference/manual-forecasting-entity-reference.md)
