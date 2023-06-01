---
title: Personalize the opportunity pipeline view
description: Personalize the pipeline view to see what you want to see and organize opportunities in a way that makes sense to you.
ms.date: 05/11/2023
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.custom: bap-template
---

# Personalize the opportunity pipeline view

Personalize the pipeline view to organize opportunities in a way that makes sense to you and to make it easy to update information on the fly, add notes and tasks, and more:

- Add, remove, rearrange, and sort columns in the editable grid.
- Apply filters to view records that are important to you.
- Change the layout of the view to list (grid only) or combo (grid and chart).
- Change the metrics displayed at the top of the view.

You can also ask your administrator to customize the experience further to improve your productivity.

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | Salesperson or higher<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Personalize metrics

The opportunity pipeline view lists important metrics related to the sales pipeline at the top of the view. You can personalize this space to view metrics that you want to track.

> [!NOTE]
> Personalized metrics are only available until you log out. The current release doesn't support saving changes you make to metrics.

1. Open the [opportunities pipeline view](use-opportunity-pipeline-view.md#open-the-opportunity-pipeline-view).
1. Select **Combo** > **Edit Metrics**.

   In the **Edit metrics** side panel, you can create, update, remove, or delete a metric.

    :::image type="content" source="media/deal-manager-editmetrics-small.png" alt-text="Screenshot illustrating the Edit metrics option in deal manager and the edit metrics side panel with the Create a metric option and the list of metrics." lightbox="media/deal-manager-editmetrics.png":::

- To create a metric:
    1. Select **Create a Metric**.
    1. Select the field and the aggregate function that you want to use for calculating the metric.
       The **Field** list displays all the numerical fields in the opportunity entity.
    1. (Optional) Add filters to calculate metrics from specific records. For example, if you want to view the estimated revenue of all opportunities created this year and are in the **Develop** stage, create a metric with the following values:
        - **Field:** Est. Revenue
        - **Aggregate function:** Sum
        - **Filters**
            - **Created On**: This year  
            - **Sales Stage**: Develop  

- To edit a metric, hover over the metric and select the **Edit** icon.
- To remove a metric temporarily, clear the checkbox against the metric.

## Personalize the side panel

Personalize the side panel to view it in different modes, depending on the details you'd like to see and your screen size.  

1. In the opportunity pipeline view, select an opportunity from the grid to open the side panel.
1. Select the wand icon to switch to one of the following modes:
    - **Compact:** This is the default mode. It displays the most important fields in the opportunity table but doesn't include the business process flow.
    - **Show BPF:** While you're in the compact mode, select this option to view the business process flow.
    - **Extended:**  This model is ideal for large screens. It displays the business process flow and all the fields in the opportunity table.  

    :::image type="content" source="media/side-panel-modes.PNG" alt-text="Screenshot of the side panel modes.":::

    The selected mode is saved until you change it.

## Personalize the grid

Personalize the grid to include columns that you want to see and update quickly.

1. In the opportunity pipeline view, select **Edit columns** to add, remove, hide, show, or rearrange columns.
1. In the **Edit columns: Opportunities** side panel:
    - To add a column, select **Add column**.
    - To show or hide columns, select or clear the checkboxes. You can't delete the default columns from the grid; however, you can hide them.
    - To rearrange columns, drag the columns in the **Edit columns: Opportunities** panel.
1. To sort columns, select the column list and select the sort option.

## Apply filters

1. In the opportunity pipeline view, select **Edit filters**.
1. In the **Edit filters: Opportunities** panel, select **Add** > **Add row** to add a condition based on fields in the opportunity table.

You can add multiple conditions by adding more rows. The conditions are validated with the AND operator.

To specify a condition with the OR operator:

1. Select **Add group** in the **Add** list.

    :::image type="content" source="media/filter-add-group.PNG" alt-text="Screenshot of the Add group option in the More filters panel.":::

    > [!NOTE]
    > Although the **Add** list displays **Add related entity**, this option isn't supported in this release.

1. Select the **Or** operator in the list next to the group filter checkbox, and specify the condition.

[Learn how to create filters with grouped and nested conditions in model-driven app views](/powerapps/maker/model-driven-apps/create-edit-view-filters).

## Save personalizations to a new view

After you personalize the pipeline view, you can save your changes to a new view. An asterisk next to the view name indicates that the view has unsaved changes.

Select the **My Open Opportunities** view list, and then select **Save as new view**.

:::image type="content" source="media/save-as-new-view.png" alt-text="Screenshot of the Save as new option in the views list.":::

To set the new view as your default, select **Set as default view**.

## Switch to a view

You can create multiple views with different personalizations and switch between them.

From the view list, select the view that you want to switch to.

:::image type="content" source="media/views-dropdown.PNG" alt-text="Screenshot highlighting the views list in the Opportunity pipeline view.":::

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]
