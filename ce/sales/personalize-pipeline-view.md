---
title: Personalize the opportunity pipeline view
description: As a seller, personalize the pipeline view depending on what you want to see, organize opportunities in a way that makes sense to you, and personalize your view.
ms.date: 02/06/2023
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
manager: shujoshi
---
# Personalize the opportunity pipeline view

[!INCLUDE[cc-early-access](../includes/cc-early-access.md)]

As a seller, you can personalize the pipeline view depending on what you want to see. You can organize opportunities in a way that makes sense to you, personalize your view, update information on the fly, add notes and tasks, and much more. You can also ask your administrator to customize the experience further to improve your productivity.  

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise  <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Salesperson or higher <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## What can you personalize?

You can:

- Add, remove, rearrange, and sort columns in editable grid.

- Apply filters to view records that are important to you.
- Change the layout of the view to either list (grid only) or combo (grid and chart).  
- Change the metrics displayed at the top of the view.

## Personalize metrics

The opportunity pipeline view lists important metrics related to the sales pipeline at the top of the view. You can personalize this space to view metrics that you want to track.  

> [!NOTE]
> Any personalized metrics are only available until you log out. The current release doesn't support saving the changes you make to metrics.

1. Open the [opportunities pipeline view](use-opportunity-pipeline-view.md#open-the-opportunity-pipeline-view). 
1. Select **Combo** > **Edit Metrics**.

   In the **Edit metrics** side panel, you can create, update, remove, or delete a metric.

    :::image type="content" source="media/deal-manager-editmetrics-small.png" alt-text="Screenshot illustrating the Edit metrics option in deal manager and the edit metrics side panel with the Create a metric option and the list of metrics." lightbox="media/deal-manager-editmetrics.png":::

1. To create a metric, perform the following steps:
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

Personalize the grid to include columns that you want to see and update quickly.

1. In the opportunity pipeline view, select **Edit columns** to add, remove, hide, show, or rearrange columns.
    The **Edit columns: Opportunities** side panel opens.
    
    1. To add a column, select **Add column**.

    1. To show or hide columns, select or clear the checkboxes. You can't delete the default columns from the grid; however, you can hide them.
    1. To rearrange columns, drag the columns in the **Edit columns: Opportunities** panel.

1. To sort columns, select the column dropdown menu and select the sort option.

## Apply filters

1. In the opportunity pipeline view, select **Edit filters**.

    The **Edit filters: Opportunities** panel displays the columns in your view.

1. Select **Add** > **Add row** to add a condition based on fields in the opportunity table.

    You can add multiple conditions by adding more rows. The conditions will be validated with the AND operation.  

1. To specify a condition with the OR operator, perform the following steps: 
    1. Select **Add group** in the **Add** dropdown menu.
    
        :::image type="content" source="media/filter-add-group.PNG" alt-text="Screenshot of the Add group option in the More filters panel.":::
       
       > [!NOTE]
       > Though the **Add** dropdown menu displays **Add related entity**, this option isn't supported in this release.
   
    1. Select the **Or** operator in the dropdown menu next to the group filter checkbox, and specify the condition.

For more information on filters with grouped and nested conditions, see [Create or edit filters in model-driven app views](/powerapps/maker/model-driven-apps/create-edit-view-filters).

## Save personalizations to a new view

After you personalize the pipeline view, you can save the changes to a new view. An asterisk next to the view name indicates that the view has unsaved changes.  

Select the **My Open Opportunities** view drop-down and select **Save as new view**. 

:::image type="content" source="media/save-as-new-view.png" alt-text="Screenshot of the save as new option in the views drop-down":::

You can set the new view as the default view by selecting **Set as default view**.

## Switch to a view

You can create multiple views with different personalizations and switch between them.

From the view drop-down, select the view that you want to switch to.

:::image type="content" source="media/views-dropdown.PNG" alt-text="Screenshot highlighting the views dropdown list in deal manager.":::
 
[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]




