---
title: "View and understand drill down in a forecast (Dynamics 365 Sales) | MicrosoftDocs"
description: "View and understand drill down in a forecast in Dynamics 365 Sales."
ms.date: 09/18/2020
ms.service: 
  - dynamics-365-sales
ms.custom: 
  - dyn365-sales
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---


<!-- editor comment: The title appears to use "drill down" as a noun, but the style guide shows it only as a verb (two words) or an adjective (hyphenated). Perhaps it could change to "by drilling down" or "by using the drill-down feature." -->



# View and understand data through drill down

[!INCLUDE [cc-early-access](../includes/cc-early-access.md)]

Through a forecast, you'll have visibility into the pipeline amounts that your sellers are projecting for the period. Now you might want to know which accounts contribute to a specific seller’s Committed value or maybe you want to know which products are contributing to a different seller’s Won value. The drill-down feature allows you to break down your seller’s forecast projections as a function of the contributing factors that you care about such as Account and Product. The drill-down feature looks at the underlying records that are contributing to the value of the rollup column and groups them according to the selected drill-down data.

<!-- please note the wording change at the end of the previous sentence. -->


By viewing drill-down data, you can understand how the records in each group are performing and set the next course of action. This helps you to plan better and achieve the targets as set in the forecast.


<!-- Please ensure that Amber Rodriguez and Kevin Smith are from an approved fictitious names list. -->


Let’s look at an example. **Amber Rodriguez** is a seller who's associated with four accounts. Her projected revenue for the current period is $400,000. **Kevin Smith**, her sales manager, wants to understand how her revenue of $400,000 is broken down by each account. On the forecast page, Kevin chooses the Account drill-down option from the drop-down menu. Then he selects the drill-down icon beside Amber’s record to view a list of accounts that make each of Amber’s forecast pipeline values.

> [!div class="mx-imgBorder"]
> ![Forecast drill-down view](media/forecast-drill-down-view.png "Forecast drill-down view")


<!-- Please review the wording changes to "drill down" in the next two paragraphs. -->

Before you start using the feature, an administrator or forecast manager must add the drill-down options to the forecast. To learn more, go to [Configure and manage drill downs](configure-manage-drill-downs.md).

When a drill-down option is added to your forecast, a drop-down list is displayed below the **Grid** tab. The following screenshot is an example:

> [!div class="mx-imgBorder"]
> ![Drill-down option in forecast](media/forecast-drill-down-sample-screen.png "Drill-down option in forecast")

## Select a drill-down option

By default, when you open a forecast, no drill-down choice is selected and the icon corresponding to each row is disabled. To enable and view the details, you must select a drill-down option. That enables the icons corresponding to each row. Select the icon to view the forecast data in a drill-down mode. To select a drill-down option, follow these steps:


<!-- please check wording change in step 1. -->


1.	Open a forecast with the drill-down feature added.


<!-- Wondering if "break down" the data is better wording. --> 


2.	Select the **Drill down by** list and choose the drill-down option on which you want to break the data. For example, **Account**.
 
    > [!div class="mx-imgBorder"]
    > ![Select Account as drill-down choice](media/forecast-drill-down-selection.png "Select Account as drill-down choice")

    The icon corresponding to each row turns blue and is now active. The data in the forecast is broken down into multiple groups according to the drill-down selection (**Account**).

    > [!div class="mx-imgBorder"]
    > ![Drill-down choice is active](media/forecast-drill-down-active.png "Drill-down choice is active")

## View and understand the drill-down data

After you have selected a drill-down category, the icon for each row is active and the data is grouped according to the drill-down selection. 

For example, select the drill-down option as Account and the data in the forecast is grouped according to the accounts that are associated with the opportunities. Here we want to view the contribution of each account to the value of each category of **Kenny Smith**. 

Select the drill-down icon corresponding to **Kenny Smith**. All the accounts with values that are contributing to Kenny’s forecast are displayed. 

For simple column types such as **Quota**, the values are displayed as **Not applicable** because these values are uploaded manually to forecast. Also, for the **Prediction** column, the values are displayed as **Not applicable** because the prediction values are not based on a drill-down entity.

At the bottom of the table, a **blank** row is created with values for the opportunities that are not related to any account.
 
> [!div class="mx-imgBorder"]
> ![View account drill-down details](media/forecast-drill-down-account-drill-down.png "View account drill-down details")

To view the opportunities that are affecting the forecast values of an account, do one of the following:

-	Select an account row to show all opportunities, regardless of forecast category.
-	Select a cell of an account to show only the opportunities that are affecting roll-up column value.


<!-- please check rewording in the Note. -->

> [!NOTE]
> If you edit the underlying opportunities in drill-down view, the updated values won't show in the drill-down selection. To view the updated values, close the drill-down selection and open it again. 

To learn more about the underlying opportunities, go to [View and manage underlying opportunities](view-and-manage-underlying-opportunities.md).

## See also

[Project accurate revenue with sales forecasting](project-accurate-revenue-sales-forecasting.md) 

[Configure and manage drill downs](configure-manage-drill-downs.md)
