---
title: Manage opportunities using pipeline view 
description: Use the opportunity pipeline view to visualize the opportunities in your pipeline, and prioritize and manage them effectively.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: how-to 
ms.date: 05/02/2023
ms.custom: bap-template 
---
# Manage opportunities using pipeline view

The opportunity pipeline view (formerly known as deal manager) helps you visualize the opportunities in your pipeline, and prioritize and manage them effectively. The charts in the view help you figure out which deals to follow up with next. The KPIs help determine the current status of deals in the pipeline, deals successfully closed, and deals lost, and their respective revenue.


## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

## Video: Opportunity pipeline view

Watch this short video to know how the opportunity pipeline view helps sellers be more productive and efficient.  

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RWONpe]

## Open the opportunity pipeline view  

1. From the Sales Hub sitemap, select **Opportunities**.  

    If your administrator has set the pipeline view as the default view, you'll see the pipeline view as shown in the following screenshot:

    :::image type="content" source="media/opportunity-pipeline-view.png" alt-text="Screenshot of the opportunity pipeline view with its components highlighted and numbered":::  

    If you're not seeing the pipeline view, select **Show As** > **Pipeline view**. More information: [Why can't I find the **Pipeline view** option?](faq-sales.yml#why-can-t-i-find-the-pipeline-view-option)

    :::image type="content" source="media/show-as-pipeline-view.png" alt-text="Screenshot of the menu option to switch to the pipeline view.":::

    The following table describes the different aspects of the pipeline view:  

    |Number in the screenshot  |Feature  |Description  |
    |---------|---------|---------|
    |1     |  Metrics       |View key metrics or KPIs that you want to track. You can modify the metrics in this section to meet your needs. More information: [Personalize the opportunity pipeline view](personalize-pipeline-view.md)         |
    |2     |Charts         |Get a visual representation of the pipeline. <br><br>**Bubble chart** <br> The default bubble chart displays the following values:<ul><li>**x-axis:** Displays the opportunity score if you have Sales Insights; otherwise, it displays the deal probability.</li><li>**y-axis:** Displays the close date. A smart column that displays the actual close date or estimated close date, depending on whether the opportunity is closed.</li><li>**Size of the bubble:** Displays revenue. A smart column that displays the actual revenue or estimated revenue, depending on whether the opportunity is closed. </li><li> **Color of the bubble:** Indicates opportunity grade if you have Sales Insights; otherwise, it displays the pipeline phase.</li></ul> You can ask your administrator to customize the chart if you want to see different fields. More information: [Customize the bubble chart](opportunity-pipeline-view-for-admins.md#customize-the-bubble-chart) <br><br> **Sales funnel chart** <br> The Sales funnel chart displays a funnel based on the sum of estimated revenues across different pipeline phases. You can ask your administrator to customize the chart if you want to see different fields. More information: [Customize the funnel chart](opportunity-pipeline-view-for-admins.md#customize-the-funnel-chart)</li></ul> **Note:** The funnel chart can only display up to 50,000 records. When the number of records exceed this limit, a message is displayed. You can apply filters to reduce the record size. <br><br> When you filter the records, the chart is automatically updated.|
    |3     |Editable grid         |View a list of opportunities and edit them inline. Select any linked column&mdash;such as **Name**, **Potential Customer**, or **Contact**&mdash;to view and quickly edit details in the side panel.<br><br>You can personalize the grid: add, remove, resize, hide, rearrange, and sort columns on-the-fly. More information: [Personalize the opportunity pipeline view](personalize-pipeline-view.md) |
    |4     |Side panel         |View and quickly edit details for the linked values such as **Opportunity Name**, **Potential Customer**, or **Contact**. You can also navigate from one object to another in the side panel. For example, while you're looking at the opportunity, you can select a contact to view their details, quickly make updates, and then return to the opportunity. |


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Where is the deal manager workspace?](faq-sales.yml#where-is-the-deal-manager-workspace)  
[Personalize the opportunity pipeline view](personalize-pipeline-view.md)