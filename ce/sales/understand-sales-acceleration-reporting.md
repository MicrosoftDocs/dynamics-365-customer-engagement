---
title: "View and understand sales acceleration reporting"
description: "View and understand the report for sales acceleration to get a broad overview of the sequences related to leads and opportunities in your organization."
ms.date: 12/10/2021
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Preview: View and understand sales acceleration reporting

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

View and understand the report for sales acceleration to get a broad overview of the sequences related to leads and opportunities in your organization.

## License and role requirements

| &nbsp; | &nbsp; |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | Sales Manager or Sequence Manager <br>  See [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## What is sales acceleration reporting?

The sales acceleration reporting gives you a broad overview of the sequences related to leads and opportunities in your organization. The reports use AI to provide insights into which sequences are doing better and emerging with highest successful conversions rate. Also, you can analyze the metrics and KPIs to identify areas for improvement that can have the greatest affect on sales growth.

>[!NOTE]
>After your administrator enables reporting, the application may take up to 24 hours to display the data in the reports. When the reports are being provisioned for the first time, the following message is displayed:
>![Reports provisioning message](media/sa-sequence-reporting-provisioning-message.png "Reports provisioning message")    
>Subsequently, the reports refresh every 24 hours. You can view the last updated date on the upper-right corner of the page.

## Who can view the reporting page?

By default, the users with sales manager and sequence manager roles can view the reporting page. For other roles to view the reporting page, contact your administrator to get read access at organizational level for the **Sales acceleration reports** table. More information: [Security roles and privileges](/power-platform/admin/security-roles-privileges).

## View sales acceleration reporting

1.	Go to the lower-left corner of the page and select **Change area** > **Sales**.
2.	On the site map, under **Sales Analytics**, select **Sales Acceleration Reporting**. 
    The reporting page opens.
 
    >[!div class="mx-imgBorder"]
    >![The sales acceleration reporting page](media/sa-sales-acceleration-reporting-page.png "The sales acceleration reporting page")

## Understand sales acceleration reporting

By default, the report displays KPIs for all sequences that are related to leads and opportunities in the past one month. The reporting view can be categorized into the following sections:
-	[Data filters](#data-filters)
-	[KPI summary charts](#kpi-summary-charts)
-	[Metric charts](#metric-charts)

### Data filters

The data filtering options allow you to select data for specific time periods, entity type, sequence name, sequence owner, seller, and territory. To filter data by duration, channel, queue, or agent, select a value from the respective drop-down list. 

>[!div class="mx-imgBorder"]
>![The sales acceleration reporting data filters section](media/sa-sales-acceleration-reporting-data-filters.png "The sales acceleration reporting data filters section")

### KPI summary charts

The KPI summary charts summarize the key performance indicators for the specified time period and the percent change during the period. You can further filter these areas by entity type, sequence name, sequence owner, seller, and territory. Also, a trend is displayed corresponding to the value specifying how the KPI is doing in the selected time frame when compared with the previous time frame. The up arrow (Green) indicates an improvement in score and down arrow (Red) indicates a decline in score.

>[!div class="mx-imgBorder"]
>![The sales acceleration reporting KPI summary charts section](media/sa-sales-acceleration-reporting-kpi-summary-charts.png "The sales acceleration reporting KPI summary charts section")
 
The following table shows the key performance indicators that are displayed in the report:

| KPI | Description |
|-----|-------------|
| Lead conversion rate | The percentage of leads in a sequence that are successfully converted into opportunities. |
| Avg.time (in days) for lead conversion | The average number of data a lead takes to convert to an opportunity when it's connected to a sequence. |
| Avg.time (in days) for sequence completion | The average number of days that are taken for a sequence to complete in an attached record. |
| Opportunity-to-win ratio | The percentage of opportunities in a sequence that are successfully converted into win deals. |
| Avg.time (in days) for opportunity conversion | The average number of days that are taken for an opportunity in a sequence to convert into a win deal. |

### Metric charts

The metric chart provides a detailed view into the individual values of a sequence such as, status, number of steps, and status of the steps.
To view specific data that is related to a value in the charts, select the value. Also, other metric charts in the report are refreshed to show the data that is related to the selected value. The drill-down of the values helps you to identify the areas of improvements for the sequence.   

>[!div class="mx-imgBorder"]
>![The sales acceleration reporting metric charts section](media/sa-sales-acceleration-reporting-metric-charts.png "The sales acceleration reporting metric charts section")
  
The following metrics are displayed in the charts:

| Metric chart | Description |
|--------------|-------------|
| Sequence success rate | A breakdown of sequences that are active in your organization with the percentage of records that are successfully converted. |
| Associated leads/opportunities with sequence | A breakdown of sequences with the status of their associated lead or opportunity records. The statuses are:<br>•	Completed<br>•	Connected<br>•	Disconnected  |
| Sequence status | A breakdown of sequences by their status. The statuses are:<br>•	Completed<br>•	Disconnected<br>•	Connected  |
| Sequence steps | A breakdown of sequence steps that are added to active sequence in your organization. |
| Sequence steps by status | A breakdown of sequences steps by their status in all the sequences that they are added to. The statuses are:<br>•	Completed<br>•	Canceled<br>•	Skipped<br>•	Open |
| Email engagement | A breakdown of emails with status that are linked to sequences through email steps. The status displayed in the chart is based on status that is defined in the Email engagement feature. More information: [Use email engagement to view message interactions](email-engagement.md). |

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Enable the sales accelerator reports preview](enable-configure-sales-accelerator.md#enable-sales-accelerator-reports)    
[Understand the sequence stats page](understand-sequence-stats.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
