---
title: Use the opportunity pipeline view (Preview)
description: Use the opportunity pipeline view to visualize the opportunities in your pipeline, and prioritize and manage them effectively.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: how-to 
ms.date: 01/18/2023
ms.custom: bap-template 
---
# Preview: Use the opportunity pipeline view

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

The opportunity pipeline view (formerly knows as deal manager) helps you visualize the opportunities in your pipeline, and prioritize and manage them effectively. The charts in the view help you figure out which deals to follow up with next. The key KPIs help you understand where you stand in terms of the number of deals in the pipeline, deals won, and deals lost, and their respective revenues.


## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>  More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles)|

## Opportunity pipeline view (Preview)

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

Watch this short video to know how the opportunity pipeline view helps sellers be more productive and efficient.  

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RWONpe]

## Open the opportunity pipeline view  

1. From the Sales Hub sitemap, select **Opportunities**.  

    If your administrator has set the pipeline view as the default view, you'll see the pipeline view.  

1. If you're seeing a grid view, select **Show As** > **Pipeline view**.  
    :::image type="content" source="media/show-as-pipeline-view.png" alt-text="Screenshot of the menu option to switch to the pipeline view.":::

    The following screenshot illustrates the different aspects of the pipeline view:  

    :::image type="content" source="media/opportunity-pipeline-view.png" alt-text="Screenshot of the opportunity pipeline view with its components highlighted and numbered":::


    |Number  |Feature  |Description  |
    |---------|---------|---------|
    |1     |  Metrics       |View key metrics or KPIs that you want to track. You can modify the metrics in this section to meet your needs. More information: [Personalize the deal manager workspace](personalize-deal-manager.md#personalize-the-metrics)         |
    |2     |Charts         |Get a visual representation of the pipeline. <br><br>**Bubble chart** <br> The default bubble chart displays the following values:<ul><li>**x-axis:** Displays the opportunity score if you have Sales Insights; otherwise, it displays the deal probability.</li><li>**y-axis:** Displays the close date. A smart column that displays the actual close date or estimated close date, depending on whether the opportunity is closed.</li><li>**Size of the bubble:** Displays revenue. A smart column that displays the actual revenue or estimated revenue, depending on whether the opportunity is closed. More information: [What are smart columns?](personalize-deal-manager.md#what-are-smart-columns).</li><li> **Color of the bubble:** Indicates opportunity grade if you have Sales Insights; otherwise, it displays the pipeline phase.</li></ul> You can ask your administrator to customize the chart if you want to see different fields. More information: [Customize the deal manager workspace](customize-deal-manager.md) <br><br> **Sales funnel chart** <br> The Sales funnel chart displays the following values. <ul><li>**x-axis:** Displays the pipeline phases.</li><li>**y-axis**: Displays the estimated revenue. Customization of the Sales funnel isn't supported in this release.</li></ul> **Note:** The funnel chart can only display up to 50,000 records. When the number of records exceed this limit, a message is displayed. You can apply filters to reduce the record size. <br><br> When you filter the records, the chart is automatically updated.|
    |3     |Editable grid         |View a list of opportunities and edit them inline. Select any linked column&mdash;such as **Name**, **Potential Customer**, or **Contact**&mdash;to view and quickly edit details in the side panel.<br><br>You can personalize the grid: add, remove, resize, hide, rearrange, sort, and group columns on the fly. More information: [Personalize the deal manager workspace](personalize-deal-manager.md#personalize-the-grid)<br><br>You can also save the personalization in a view so that you can switch to it at anytime. More information: [Create a view](personalize-deal-manager.md#create-a-view) |
    |4     |Side panel         |View and quickly edit details for the linked values such as **Opportunity Name**, **Potential Customer**, or **Contact**. You can also navigate from one object to another in the side panel. For example, while you're looking at the opportunity, you can select a contact to view their details, quickly make updates, and then return to the opportunity. You can ask your administrator to customize the side panel if you want to be able to view or update other fields in the panel. |


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Preview: Personalize the deal manager workspace](personalize-deal-manager.md)
