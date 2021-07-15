---
title: "Personalize deal manager - Sales Enterprise | MicrosoftDocs"
description: "As a seller, personalize the grid and apply filters to suit your needs."
ms.date: 07/15/2021
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---

# Personalize the deal manager workspace (Preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

[!INCLUDE [preview-disclaimer](../includes/preview-disclaimer.md)]

As a seller, you can personalize the deal manager workspace to suit your needs. You can,

- Personalize the grid by adding, removing, rearranging, sorting, and grouping columns.
- Apply filters to view records that are important to you.
- Change the layout of the workspace to either list (grid only) or combo (grid and chart).  
- Change the metrics displayed at the top of the workspace.

## Personalize the metrics 

The deal manager workspace lists important metrics related to the sales pipeline at the top of the workspace. You can personalize this space to view metrics that you want to track.  

> [!NOTE]
> Any personalized metrics are only available until you log out. The current release doesn't support saving the changes you make to metrics.

**To personalize the metrics**

1. In the Sales Hub site map, select **Deal manager (preview)**.
1. Select **Combo** > **Edit Metrics**.

   In the **Edit metrics** side panel, you can create, update, remove, or delete a metric.

    :::image type="content" source="media/deal-manager-editmetrics-small.png" alt-text="Screenshot illustrating the Edit metrics option in deal manager and the edit metrics side panel with the Create a metric option and the list of metrics." lightbox="media/deal-manager-editmetrics.png":::

1. To create a metric, do the following:
    1. Select **Create a Metric**.
    1. Select the field and the aggregate function that you want to use for calculating the metric.
       The **Field** list displays all the numerical fields in the opportunity entity. 
    1. (Optional) Add filters to calculate metrics from specific records. For example, if you want to view the estimated revenue of all opportunities created this year and are in the **Develop** stage, create a metric with the following values:

    - **Field:** Est. Revenue
    - **Aggregate function:** Sum
    - **Filters**
        - **Created On**: This year  
        - **Sales Stage**: Develop  

1. To edit a metric, hover over the metric and select the **Edit** icon.
1. To remove a metric temporarily, clear the checkbox against the metric.


## Personalize the grid

Personalize the grid to include columns that you want to see and update quickly. You can:

- Add or remove columns from the grid.
- Show or hide columns.
- Drag columns to rearrange them in the grid.
- Resize, sort, and group records by columns.  

> [!NOTE]
> The personalization changes explained in this section only persist until you sign out. If you want to save your changes, [create a view](#create-a-view).  

**To personalize the grid**

1. In the deal manager workspace, scroll down to the grid.

1. Select **Edit columns** to add, remove, hide, show, or rearrange columns.
    1. To add a column, select **Add column** in the **Edit columns** panel and select the column type as one of the following: 

        - **Basic column**    
          Lets you select a column from the opportunity or related entities such as account, contact, price list, and so on.
        - **Smart column**   
          Lets you select a column that performs certain computations on the records to display smart and actionable information. For more information, see [What are smart columns?](#what-are-smart-columns) later in this topic. 

          :::image type="content" source="media/deal-manager-editcolumns-small.png" alt-text="Screenshot illustrating the Edit columns option and the side panel." lightbox="media/deal-manager-editcolumns.png":::


    1. To show or hide columns, select or clear the checkboxes. You can't delete the default columns from the grid; however, you can hide them.
    1. To rearrange columns, drag the columns in the **Edit columns** panel or in the grid.

1. To sort columns, select the column dropdown menu and select the sort option.
1. To group the records by a column, select **Group by** and then select the column that you want to use for grouping. For example, to group opportunities based on different sales stages, group by the **Sales stage** column.
   
### What are smart columns?

A *smart column* performs certain computations on existing columns to display smart and actionable information. For example, the **Revenue** column displays the actual revenue if the opportunity is closed; otherwise, it displays the estimated revenue. These columns save you the trouble of manual computation and makes it easy for you to look at opportunities that need your attention. 

The following table lists the smart columns that are available.


|Name  |Computation  |Action  |
|---------|---------|---------|
|Close date     | Displays the actual close date if the opportunity is closed; otherwise, it displays the estimated close date.         |None         |
|Revenue     |Displays the actual revenue if the opportunity is closed; otherwise, it displays the estimated revenue.         |None         |

## Apply filters

As a seller, you want the workspace the display records that you're working on. As a manager, you want to view records that your team is working on. To view the records that you're interested in, you apply filters.

**To apply filters to the workspace**

1. In the deal manager workspace, select **Filters**.

    The **Filters** panel displays the columns in your view. 
1. Select **More filters**, and then do one of the following:
    - Select fields that aren't currently displayed in your view.
    - View or delete the existing filters.
1. To specify an OR condition, select **Add group** in the **Add** dropdown menu.
    :::image type="content" source="media/filter-add-group.PNG" alt-text="Screenshot of the Add group option in the More filters panel.":::
   > [!NOTE]
    > Though the **Add** dropdown menu displays **Add related entity**, this option isn't supported in this release.   
1. Select the **Or** operator in the dropdown menu next to the group filter checkbox.

## Create a view

The personalization changes that you directly make in the grid don't persist across sessions. If you want to save your changes permanently, create a view. You can personalize the following aspects of the grid in a view:

- Add or remove columns
- Resize or rearrange columns
- Apply filters

> [!NOTE]
> Currently, changes to metrics or other personalization changes to the grid can't be saved to the view.

**To create a view**

1. In the deal manager workspace, select **View** > **Create Personal View**.

1. In the **View Designer**, personalize the columns and apply filters to meet your needs.
    :::image type="content" source="media/view-designer.PNG" alt-text="Screenshot of the view designer in Power Apps.":::<!--note from editor: Should this say "in the deal manager workspace", or did we switch to the Power Apps UI here? -->

1. Save the changes.

## Edit a view

The option to edit a view isn't yet supported in the deal manager workspace. You can, however, edit the view in Power Apps.


## Switch to a view

You can create multiple views with different filter conditions or columns and switch between them.

In the deal manager workspace, select the views dropdown list and search for the view that you want to switch to.

:::image type="content" source="media/views-dropdown.PNG" alt-text="Screenshot highlighting the views dropdown list in deal manager.":::
 

### See also

[Access the deal manager workspace (Preview)](access-deal-manager.md)  
[Known issues with personalization](deal-manager-known-issues.md#personalization)


