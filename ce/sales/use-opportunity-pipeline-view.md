---
title: Manage opportunities using pipeline view 
description: Learn how to use the opportunity pipeline view, formerly known as deal manager, to visualize, prioritize, and manage the opportunities in your pipeline.
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: shujoshi
ms.topic: how-to 
ms.date: 02/06/2023
ms.custom: bap-template 
---

# Manage opportunities using pipeline view

[!INCLUDE [cc-early-access](../includes/cc-early-access.md)]

The opportunity pipeline view in Dynamics 365 Sales, formerly known as deal manager, helps you visualize, prioritize, and manage the opportunities in your pipeline. The charts in the view help you figure out which deals to follow up with next. The metrics help you determine the current status of deals in the pipeline, including which were successfully closed and their revenue.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Any primary sales role, such as salesperson or sales manager<br>More information: [Primary sales roles](security-roles-for-sales.md#primary-sales-roles) |

## Video: Opportunity pipeline view

Watch this short video to learn how the opportunity pipeline view helps sellers be more productive and efficient.  

> [!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RWONpe]

[!INCLUDE [Lightbox tip](~/../shared-content/shared/lightbox-tip.md)]

## Open the opportunity pipeline view  

In the Sales Hub navigation panel, select **Opportunities**. If you don't see the opportunity pipeline view, select **Show As**, and then select **Pipeline view**.

:::image type="content" source="media/opportunity-pipeline-view.png" alt-text="Screenshot of the opportunity pipeline view with its components highlighted and numbered." lightbox="media/opportunity-pipeline-view.png":::<!-- EDITOR'S NOTE: Please revise the screenshot IAW the new [screenshot guidelines](/bacx/screenshots-for-bap?branch=main).-->

Legend:

1. Metrics: View the key metrics or KPIs that you want to track.
1. Charts: Get a visual representation of the pipeline.
1. Editable grid: View a list of opportunities and edit them inline. Select any linked column to view and edit details in the side panel.
1. Side panel: View and quickly edit details of the linked values. You can also navigate from one object to another in the side panel. For example, while you're looking at the opportunity, you can select a contact to view their details, quickly make updates, and then return to the opportunity.

You can [personalize the opportunity pipeline view](personalize-pipeline-view.md) to add, remove, resize, hide, rearrange, and sort the columns in the editable opportunity grid and select the metrics you want to track.

## Understand the opportunity pipeline charts

- **Bubble chart:** Ask your administrator to [customize the bubble chart](opportunity-pipeline-view-for-admins.md#customize-the-bubble-chart) if you want to change the data you see. By default, the bubble chart shows the following information:

  - **x-axis:** Displays the opportunity score if you have Sales Insights; otherwise, it displays the deal probability.
  - **y-axis:** Displays the close date. This is a smart column that displays the actual close date or estimated close date, depending on whether the opportunity is closed.
  - **Size of the bubble:** Displays revenue. This is a smart column that displays the actual revenue or estimated revenue, depending on whether the opportunity is closed.
  - **Color of the bubble:** Indicates the opportunity grade if you have Sales Insights; otherwise, it displays the pipeline phase.

- **Sales funnel chart:** Displays a funnel based on the sum of estimated revenues across different pipeline phases. Ask your administrator to [customize the funnel chart](opportunity-pipeline-view-for-admins.md#customize-the-funnel-chart) if you want to change the data you see.

  The funnel chart can display up to 50,000 records. You can apply filters to reduce the number of records in the chart.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

[Where is the deal manager workspace?](faq-sales.yml#where-is-the-deal-manager-workspace)  
[Personalize the opportunity pipeline view](personalize-pipeline-view.md)
