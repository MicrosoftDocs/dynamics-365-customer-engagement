---
title: Understand the sequence stats page
description: View and understand the sequence's success rate and the state of records that are connected.
ms.date: 04/30/2026
ms.topic: concept-article
author: udaykirang
ms.author: udag
ms.reviewer: udag
---

# Understand the sequence stats page

The sequence stats provide insights on the performance of a sequence, such as success rate and the state of records that are connected. The data helps you view the sequences that are doing better and emerging with high conversion rates. 

## Who can view the stats page?

>[!VIDEO https://learn-video.azurefd.net/vod/player?id=dd7439b0-227c-4159-9bc2-f83f96fde185]

By default, users with sales manager and sequence manager roles can view the stats page. For other roles to view the reporting page, contact your administrator to get read access at the organizational level for the sales acceleration reports table. For more information, see [Security roles and privileges](/power-platform/admin/security-roles-privileges).

## View the sequence stats page

>[!NOTE]
>-	Verify that an administrator enables the sales acceleration reporting in your organization. For more information, see [Sequence reporting](customize-sales-accelerator-sellers.md#sequence-reporting).
>-	After an administrator enables reporting, the application might take up to 24 hours to display data on the stats page for the first time. Subsequently, data in the stats page refreshes every four hours. 

**To view the sequence stats**

1.	Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.
1.	Under **Sales accelerator**, select **Sequences**.
1.	On the **Sequences** page, select the **Sequence stats** tab.

    :::image type="content" source="media/sa-sequence-stats-page.png" alt-text="Screenshot of the sequence stats page.":::

## Understand the sequence stats page

The **Sequence stats** page consists of information on data related to each sequence that's available in your organization and the timeframe for which you want to view the data.

### Select the timeframe  

Select the timeframe for which you want to view the data. When you make your selection, the table refreshes to show data for that timeframe. By default, the timeframe is 30 days, but you can choose from the following timeframes:

-	30 days
-	90 days
-	180 days
-	1 year
-	2 years

:::image type="content" source="media/sa-sequence-stats-page-choose-time.png" alt-text="Screenshot of choosing a timeframe to view data.":::

For example, if you want to view the data for the last 90 days, select **Last 90 days** from the date dropdown list. The table refreshes to show data for the last 90 days.

### Sequence stats list

The sequence stats list shows sequences, including inactive ones, that are available in your organization for all record types. For the timeframe you select, you can view information such as the success rate.   

The **Success Rate** column displays the trend of the sequence with its successful conversion rate for the connected records in the selected timeframe. 

>[!NOTE]
>The **Success Rate** column is available only for lead and opportunity record types.  

:::image type="content" source="media/sa-sequence-stats-page-column-success-rate.png" alt-text="Screenshot of the Success Rate column in the sequence stats page.":::    
 
The trend shows how a sequence is performing in the selected timeframe compared to that of the previous timeframe. For example, if you select 30 days and a sequence related to the lead record type shows an upward trend (green), this trend shows that the sequence performs better in converting leads into opportunities in the current 30 days when compared to the previous 30 days. Green indicates improvement, red indicates a downward trend, and orange indicates that there's no change in the success rate.

The percentage shows the average number of records that are successfully converted into win deals or opportunities when compared to the previous timeframe.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Sequence reporting](customize-sales-accelerator-sellers.md#sequence-reporting)    
[Understand sales acceleration reporting](understand-sales-acceleration-reporting.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
