---
title: "View and understand sales usage reports"
description: "View and understand sales usage reports to analyze the status of opportunities and leads in your organization."
ms.date: 11/22/2022
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# View and understand sales usage reports

The sales usage dashboard provides a snapshot view of the historical operational metrics and key performance indicators (KPIs) for opportunities and leads.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | Sales Manager <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|


## View sales usage reports

>[!NOTE]
>- Sales usage reports are not available on Government Community Cloud (GCC).
>- When the administrator enables the reports, the application can take up to 24 hours to display them. Thereafter, reports are refreshed every 24 hours. 

1.	Sign in to your sales app, and in the lower-left corner of the page, go to **Change area** > **Sales Insights settings**.    

2.	Under **Sales analytics**, select **Sales usage reports**.

    >[!div class="mx-imgBorder"]
    >![Select sales usage reports through the sales change area.](media/sales-usage-reports-view.png "Select sales usage reports through the sales change area")        
 
    Sales usage reports consist of the following dashboards:

    -	Opportunity usage reports
    -	Lead usage reports

## Understand the reports

The sales usage reports give you a broader overview of the performance of sales teams regarding leads and opportunities in your organization. The reports include KPIs and charts that show how leads and opportunities have performed over a period. 

The lead and opportunity dashboards can be categorized into the following sections:

-	[Data filters](#data-filters)
-	[KPI summary charts](#kpi-summary-charts)
-	[Metric charts](#metric-charts)

### Data filters

Use the data filtering options to select data for a specific time period, seller, sales manager, business unit, and role. By default, all data filters are selected and the date range covers the last 20 weeks.

>[!div class="mx-imgBorder"]
>![Data filters for sales usage reports.](media/sales-usage-reports-data-filter.png "Data filters for sales usage reports")   
 
### KPI summary charts

The KPI summary charts summarize KPIs for the specified date and the percent change during the period. You can further filter these areas by seller, sales manager, business unit, and role. Also, a trend is displayed corresponding to the value specifying how the KPI is doing in the selected timeframe when compared with the previous timeframe. A green upward triangle indicates an improvement in the score, and a red downward triangle indicates a decline in the score.

>[!div class="mx-imgBorder"]
>![KPI summary charts of sales usage reports.](media/sales-usage-reports-kpi-summary-charts.png "KPI summary charts of sales usage reports")  
 
The following table shows the KPIs that are displayed in the report (in this example, an opportunity usage report).

| KPI | Description |
|-----|-------------|
| Opportunities converted | The number of opportunities that were converted into won deals. |
| Opportunity conversion rate | The percentage of opportunities that were successfully converted into won deals. |
| Avg. time (in days) for opportunity conversion | The average number of days that it took for an opportunity to be converted into a won deal. |

### Metric charts

The metric charts provide a detailed view into the individual values of records, such as created date, status, and who created and converted them.

To view specific data that's related to a value in the charts, select the value. Other metric charts in the report will be refreshed to show data that's related to the value you select. Drilling down into these values helps you to identify the areas of improvement.

>[!div class="mx-imgBorder"]
>![Metric charts for sales usage reports.](media/sales-usage-reports-metric-charts.png "Metric charts for sales usage reports")  

The following table shows the metrics that are displayed in the report (in this example, an opportunity usage report).

| Metric chart | Description |
|--------------|-------------|
| Opportunities over time | A breakdown of how the opportunities are trending month-over-month in your organization. |
| Opportunity status | A breakdown of opportunities by their status:<br>• Open<br>• Won<br>• Lost |
| Top users for most opportunities created | A breakdown of users who created the most opportunities. |
| Top users for most opportunities converted | A breakdown of users who converted opportunities into won deals. |

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Enable sales usage reports](enable-sales-usage-reports.md)

