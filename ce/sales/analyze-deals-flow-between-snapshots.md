---
title: Analyze deals flow between forecast snapshots
description: Use snapshots to visualize and analyze how deals are trending between two moments in time through a deal flow chart.
ms.date: 02/23/2023
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
ms.topic: how-to
ms.custom: bap-template
---
# Analyze deals flow between forecast snapshots

As a sales manager, analyzing the deals flow between snapshots helps you identify deals that are moving in the right direction and those deals that need attention to meet your sales forecast. You can drill in to specific deals that have contributed to the increase or decrease in your forecast commitment. This analysis enables you to follow up with your teams and coach them on how to improve your forecast accuracy.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|


## View deals flow between snapshots

**Prerequisite**

Verify that at least two snapshots are available for the forecast. More information: [View snapshots](view-snapshots.md)  

**View and understand a deals flow**  

1. In the **Sales Hub** app, go to **Performance** > **Forecasts**.  

2. Select a forecast, and then choose a forecast period for the forecast.  

3. Select the **Flow** tab.  The tab is available only if you have [enabled snapshots](manage-snapshots-forecast.md).

   A sankey chart is displayed with a comparison between the two latest snapshots for the forecast. The order of forecast categories depends on how the forecast columns are arranged in the grid view.  

   > [!div class="mx-imgBorder"]  
   > ![Deals flow sankey chart](media/predictive-forecasting-deal-flow-sankey-chart.png "Deals flow sankey chart") 

4. To compare snapshots, choose **Start** and **End** dates from the calendar. Select **Apply**.  
   
    The chart is updated to display the deal flow. The flow is determined based on the opportunity's forecast category between the start date and end date snapshots. For example, if an opportunity was in the **Committed** state on the start date and moved to **Won** on the end date, you'll see the opportunity flow from **Committed** to **Won** in the flow chart.  

   
   :::image type="content" source="media/predictive-forecasting-deal-flow-chart-between-dates.png" alt-text="Deals flow between two snapshots" lightbox="media/predictive-forecasting-deal-flow-chart-between-dates.png":::  

    The following categories in the deal flow are calculated based on the movement of deals. Let's understand them with an example scenario. Let's say your forecast is for a fiscal year with four quarters – starting from January-March(Q1), April-June(Q2), July-September(Q3), October-December(Q4). Let's compare the snapshots of July 1 and August 31.

    | **Forecast Category** | **Description** | **Example** |
    |-------------------------|-------------------------|-------------------------|
    | Pushed out or Pulled in | These categories include opportunities that were moved during the snapshot period for the following reasons:</br><ul></br><li>Opportunities that moved from one seller to another within the forecast hierarchy.</li></br><li>Opportunities that moved from one forecast period to another within the forecast date range.</li></br></ul> | **Ownership change:** Dustin Ochs and Amber Rodriguez are Sales Managers reporting into Kenny Smith. A few opportunities of Dustin were transferred to Amber in between the start date and end date snapshots. The transferred opportunities appear under the **Pushed out** category for Dustin and **Pulled in** category for Amber. However, there will be no change for Kenny as the movement is within the same hierarchy.</br>**Date change:**</br>A few opportunities of Kenny Smith that were estimated to close within Q3 as on July 1<sup>st</sup> have moved to Q4 as on August 31<sup>st</sup>. These opportunities are shown under the **Pushed out** category in the end date snapshot. |
    | New Deals | New opportunities that were added in between the snapshot start and end dates appear as New Deals in the Start date snapshot column. | Opportunities that were created between 1<sup>st</sup> July and 31<sup>st</sup> August. |
    | Removed | Opportunities that have moved out of the forecast due to one of the following reasons:</br><ul></br><li>Estimated close date of the opportunity has moved out of the forecast date range.</li></br><li>Opportunity is deleted.</li></br><li>Opportunity has moved out of the forecast hierarchy</li></br></ul> | <ul></br><li>Opportunities that were moved to the next fiscal year.</li></br><li>Opportunities that have moved from Kenny Smith's org to Olivia Wilson's org.</li></br></ul> |
5. Hover over a forecast category in the stack to see a summary of the category, including the forecast category with snapshot date, the aggregated budget amount, and the number of opportunities that are influencing the aggregated amount. Also, the flow is highlighted to show how the opportunities are trending between the snapshots.  
   
6. To view underlying opportunities, select a forecast category in the stack. The opportunities are displayed in a grid with side-by-side comparison of how the granular data for each opportunity—such as owner, value, date, and forecast category—is changing in columns from start date to end date.  

   > [!div class="mx-imgBorder"]  
   > ![Underlying opportunities of a forecast category](media/predictive-forecasting-deal-underlying-opportunities-forecast-category.png "Underlying opportunities of a forecast category")  

   You can't edit the opportunities inline. However, in the **Action** column, select the navigate icon corresponding to the opportunity that you want to edit. The saved changes won't affect the status of the opportunity in the snapshot, because the snapshots are taken at a moment in time by using frozen data.  

### Whose deals flow am I viewing?  

You can identify whether the selected flow is for a team or an individual by looking at the deals flow heading:  

-  If the heading name contains **Username (Group)**, you're looking at the deals flow of a user's team.  

-  If the heading name contains only **Username**, you're looking at the deals flow of an individual user.  

Seeing the deals flow of other users depends on the sales hierarchy defined for you. To learn more, see [Forecasts and sales hierarchy](/dynamics365/sales-enterprise/view-forecasts#forecasts-and-sales-hierarchy).  

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also  

[View snapshots](view-snapshots.md)  
[Take snapshots automatically](manage-snapshots-forecast.md)  
[About premium forecasting](configure-premium-forecasting.md)  


[!INCLUDE[footer-include](../includes/footer-banner.md)]
