---
title: View snapshots of a forecast
description: Use the see forecast grid history page to view snapshots of a forecast in Dynamics 365 Sales Insights.
ms.date: 02/24/2023
author: lavanyakr01
ms.author: lavanyakr
ms.topic: how-to
ms.custom: bap-template
---
# View snapshots 

View a snapshot to see and understand the forecast data at the moment in time when the snapshot was taken, including underlying opportunities. Also, you can compare the data between your current forecast and the snapshot to understand how the forecast is doing.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|


## Prerequisites

Your administrator must have [enabled snapshots](manage-snapshots-forecast.md)

## Open and view snapshots

1.	Sign in to the **Sales Hub** app, and go to **Performance** > **Forecasts**.

2.	Select the forecast for which you want to view snapshots.

3.	Select **See forecast grid history**. 

    >[!NOTE]
    >The **See forecast grid history** option is inactive if there no snapshots available for the forecast.

    > [!div class="mx-imgBorder"]
    > ![Select See forecast grid history](media/predictive-forecasting-snapshot-select-forecast-grid-history.png "Select See forecast grid history")

    The latest snapshot for the forecast is displayed with information about forecast data at that point in time, along with name and date.

    > [!NOTE]
    > The values displayed in the snapshot are based on the fields configured in your forecast. If these values don't match the values you expected, verify the [fields used for aggregation](choose-layout-and-columns-forecast.md#configure-columns).

    > [!div class="mx-imgBorder"]
    > ![Forecast grid name and date](media/predictive-forecasting-snapshot-forecast-grid-name-date.png "Forecast grid name and date")

    The format of the snapshot date is based on your personal settings. In this example, the date format is **MM/DD/YY** (**07/27/20**).
  
4.	Select the calendar icon to know the dates for which snapshots are available. To view the snapshot from a specific date, select the date from the calendar.

    >[!NOTE]
    >If a date is inactive, there's no snapshot available for that date.

    > [!div class="mx-imgBorder"]
    > ![Select a date to view forecast history](media/predictive-forecasting-snapshot-select-date-forecast-history.png "Select a date to view forecast history")
 
    The data displayed in the snapshot is view-only and can't be modified.

## View underlying opportunities

For a snapshot, you can view the underlying opportunities of a column or the users who are influencing the displayed budget amount at that point in time. By viewing the opportunities, you can analyze and understand how they're trending.

1.	Open a snapshot.

2.	To see the underlying opportunities that are defining the value of a column at that point in time, select the column or user. In this example, Kenny Smith's **Committed** column is selected and the underlying opportunities that are contributing the value are displayed.

    > [!div class="mx-imgBorder"]
    > ![Select a column to view underlying opportunities](media/predictive-forecasting-snapshot-select-column-underlying-opportunities.png "Select a column to view underlying opportunities")

3.	To view the details of an underlying opportunity, under **Actions** column, select the navigate icon corresponding to the opportunity. 

    The opportunity opens in a pop-up window. The latest information will be displayed in the opportunity, not the information as of the date of the snapshot.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[About premium forecasting](configure-premium-forecasting.md)<br>
[Take snapshots automatically](manage-snapshots-forecast.md)<br>
[Analyze deals flow between snapshots](analyze-deals-flow-between-snapshots.md)


[!INCLUDE[footer-include](../includes/footer-banner.md)]
