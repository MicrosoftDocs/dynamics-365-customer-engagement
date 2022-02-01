---
title: "Understand the sequence stats page"
description: "View and understand the sequence's success rate and the state of records that are connected. "
ms.date: 12/10/2021
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Preview: Understand the sequence stats page

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The stats about sequences provide insights on the performance of a sequence, such as success rate and the state of records that are connected. The data helps you view the sequences that are doing better and emerging with high conversion rates. 

## License and role requirements

| &nbsp; | &nbsp; |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | Sales Manager or Sequence Manager <br>  Go to [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Who can view the stats page?

By default, the users with sales manager and sequence manager roles can view the stats page. For other roles to view the reporting page, contact your administrator to get read access at the organizational level for the sales acceleration reports table. More information: [Security roles and privileges](/power-platform/admin/security-roles-privileges)

## View the sequence stats page

>[!NOTE]
>-	Verify that an administrator has enabled the sales acceleration reporting preview in your organization. More information: [Enable the Sales accelerator reports preview](enable-configure-sales-accelerator.md#enable-sales-accelerator-reports)
>-	After an administrator enables reporting, the application might take up to 24 hours to display data on the stats page for the first time. Subsequently, data in the stats page is refreshed every four hours. 

**To view the sequence stats**

1.	Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.
2.	Under **Sales accelerator**, select **Sequence**.
3.	On the **Sequences** page, select the **Sequence stats** tab.
    The **Sequences** tab opens.

    >[!div class="mx-imgBorder"]
    >![The sequence stats page.](media/sa-sequence-stats-page.png "The sequence stats page")

## Understand the sequence stats page

The **Sequence stats** page consists of information on data related to each sequence that's available in your organization and the timeframe for which you want to view the data.

### Select the timeframe  

Select the timeframe for which you want to view the data. When you've made your selection, the table is refreshed to show data for that timeframe. By default, the timeframe is selected as 30 days, but  you can choose from the following timeframes:

-	30 days
-	90 days
-	180 days
-	1 year
-	2 years

>[!div class="mx-imgBorder"]
>![Choose a timeframe to view data.](media/sa-sequence-stats-page-choose-time.png "Choose a timeframe to view data")

For example, if you want to view the data for the last 90 days, select **Last 90 days** from the date dropdown list. The table will be refreshed to show data for the last 90 days.

### Sequence stats list

The sequence stats list consists of sequences—including inactive ones—that are available in your organization, for all record types. For the timeframe you selected, you can view information such as targets created and success rate.   

-	The **Target Created** column contains information on the total number of records that are linked to the sequence in the selected timeframe, with their status. Hover over the column to view information on the number of records that have the status of completed, in-progress, or disconnected.

    >[!div class="mx-imgBorder"]
    >![The Target created column.](media/sa-sequence-stats-page-column-target-created.png "The target created column")
 
-	The **Success Rate** column displays the trend of the sequence with its successful conversion rate for the connected records in the selected timeframe. 

    >[!NOTE]
    >The **Success Rate** column is available only for lead and opportunity record types.  

    >[!div class="mx-imgBorder"]
    >![The Success rate column.](media/sa-sequence-stats-page-column-success-rate.png "The success rate column")  
 
    The trend shows how a sequence is performing in the selected timeframe compared to that of the previous timeframe. For example, if you select 30 days and a sequence related to the lead record type shows an upward trend (green), this shows that the sequence has performed better in converting leads into opportunities in the current 30 days when compared to the previous 30 days. Green indicates improvement, red indicates a downward trend, and orange indicates that there has been no change in the success rate.

    The percentage shows the average number of records that are successfully converted into win deals or opportunities when compared to the previous timeframe.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Enable the sales accelerator reports preview](enable-configure-sales-accelerator.md#enable-sales-accelerator-reports)    
[Understand sales acceleration reporting](understand-sales-acceleration-reporting.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
