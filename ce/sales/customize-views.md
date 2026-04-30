---
title: Create and customize views
description: Learn how to create and customize system and personal views in Dynamics 365 Sales. Configure columns, filters, sort order, and column widths to display relevant sales data.
ms.date: 04/30/2026
ms.topic: how-to
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom:
  - dyn365-sales
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/28/2024
ai-usage:ai-assisted
---

# Customize views

Views in Dynamics 365 Sales help you control how records appear in lists. You can customize views to match your sales processes and priorities, displaying only the information your team needs. For example, you can create a view that shows only high-priority opportunities with expected close dates within the next 30 days, sorted by revenue potential.

## What is a view?

A view is a saved configuration of how records display in a table (also called a grid). Each view defines:

- **Columns**: The fields to display in the list
- **Column widths**: The size of each column
- **Sort order**: Primary and secondary sorting of records when the view opens
- **Filters**: Criteria that determine which records appear

Each row in a table represents one record. You can modify views by adjusting columns, sort order, column widths, and filters. Views also serve as data sources for charts throughout the application.

## Types of views

Dynamics 365 Sales includes two view types:

### System and public views

- **Created by**: Included with the app or created by administrators and customizers
- **Who can edit**: Administrators and customizers only
- **Scope**: Available to some or all users, depending on configuration
- **System views**: Special views that the application requires or automatically creates for custom entities

### Personal views

- **Created by**: Individual users for their own use
- **Visibility**: Only visible to the creator unless they share it with others
- **Based on**: System or public views as templates
- **Sharing**: You can share personal views with other users
- **Limitation**: You can't convert personal views to system or public views

[Learn more about sharing personal views](/powerapps/user/grid-filters-advanced#manage-and-share-personal-views)

## Create a system view

Select a tab based on the sales app that you use:

# [Sales Hub app](#tab/SE)

1. Sign in to [Power Apps](https://make.powerapps.com/).
1. Follow the instructions in [Create and edit public or system model-driven app views](/power-apps/maker/model-driven-apps/create-or-edit-model-driven-app-view?context=/dynamics365/context/sales-context) to create or customize system views.

# [Sales Professional app](#tab/SP)

This topic covers how to create system views as a customizer.

### Create a system view

Create views that match your organization's practices and processes.

1. In the Sales Professional site map, select **Sales Settings**.
2. Under **Customization**, select **Views**.
3. On the **Views** page, select **Create a view**.
4. Select the entity to use for the view.

    :::image type="content" source="media/select-entity-drop-down-list.png" alt-text="Screenshot of Select entity drop-down list":::

1. Select **Go to View Designer** at the bottom of the pane.

    :::image type="content" source="media/go-to-view-designer.png" alt-text="Screenshot of Go to View Designer button":::

1. To specify the view name:
    1. Expand the **Columns** section and select **Click to Add View Name**.
        1. Enter the name for your view. The name is set when you click or tab outside the text box. You can change the name later by clicking it again, or by changing it in the **Properties** tab.

### Add a column to your view

Views display records in a table that contains rows and columns. Each row is a record, and the fields from the records are determined by the columns you add to the view.

1. In the View Designer, select **Add** in the upper-left corner.
1. Select **Primary Entity** or **Related Entity** to display the list of available fields on the **Components** tab.
1. Do one of the following actions:
    - Double-click the name of the field you want to add. The field is added as the last column in the view.
    - Drag the field onto the grid. You can drag the field to position it before an existing column when you add it.
    - Select the field and press Enter.

- You can also move the columns around after you add them to your view.

### Set column width

After adding the columns, you can change the width of the column.

1. Select the column in the view.
1. In the **Properties** tab, set the width to the value you want by using the arrows to increase or decrease the column width.

### Set the primary and secondary column sort order

When you open a view, you see the records sorted based on the order you set when creating the view. You can sort on a single column or two columns with a primary and secondary sort order. When you open the view, the records are sorted by the column defined as the primary sort, and then by the column defined as the secondary sort.

>[!NOTE]
>You can only set primary and secondary sort on columns from the primary entity.

1. Select the column to use as the primary or secondary sort.
1. In the drop-down menu, select **Primary Sort** or **Secondary Sort**.

    :::image type="content" source="media/set-sort-order.png" alt-text="Screenshot of Set sort order":::

>[!NOTE]
>If you remove the column defined as the primary sort, the column defined as the secondary sort becomes the primary sort.

### Set the order for the primary sort

Set the sort order to ascending or descending for the column defined as the primary sort column:

1. Select the column set as the primary sort.
1. Choose the arrow next to the name to change the order.

    :::image type="content" source="media/set-ascending-descending.png" alt-text="Screenshot of Set ascending or descending":::

When the arrow points up, the sort order is ascending. When the arrow points down, the sort order is descending.

### Rearrange columns in a view

You can change the order of the columns already included in your view.

1. Select the column you want to move.
1. Drag the column to the position you want to move it to. You see a visual indicator when you hold the column over an allowed position.

    :::image type="content" source="media/rearrange-columns.png" alt-text="Screenshot of the view designer with columns being rearranged":::

>[!NOTE]
>You can also rearrange columns by using the Ctrl+X and Ctrl+V keyboard shortcuts.

### Remove a column from a view

You might want to remove a column from a default system view, or one that you added to a form but no longer want to use.

Select the column you want to remove and select **Remove Column**.

### Define filter criteria

Set filter criteria to display only a subset of records in a view. When someone opens the view, they see only the records that meet the defined filter criteria. You can select fields from both the primary and related entities to filter on.

1. In the designer, expand the **Filter Criteria** section.
1. Select **Add Filter**.
1. In the **Select** dropdown, select the field you want to filter on.
1. In the dropdown list in the second column, select the operator to use for the filter. The available operators depend on the selected field.

    :::image type="content" source="media/select-operator.png" alt-text="Screenshot of Select operator":::

1. Enter a value to filter on in the field in the third column.

### Group multiple filters

Add multiple filters to your view if you want to filter records by more than one field, and then group on fields:

1. Select **Add Filter** to add an extra filter to your view.
1. Select the operator to use and enter a value to filter on.
1. Select the check box next to each row of filter criteria.

    :::image type="content" source="media/group-filters.png" alt-text="Screenshot of Group filters":::

1. Select **Group And** or **Group Or** to group the filters.

When you select **Group And**, the view displays records that meet both criteria. When you select **Group Or**, the view displays records that meet any of the filter criteria. For example, in the preceding example, to show records for contacts with an address in Seattle or Portland, select **Group Or**.

### Remove a filter group

1. Select the check box for the group.
1. Choose **Ungroup**.

    :::image type="content" source="media/ungroup-filters.png" alt-text="Screenshot of Ungroup filters":::

### Save a view

As you work on your view, save it often to avoid losing any changes.

- In the designer, choose one of the following options in the upper-right corner:
  - To save without closing the designer, select **Save**.
  - If you're finished customizing your view, select **Save and Close**.

>[!NOTE]
>To make a copy of your view, select **Save As** to save the current view with a different name.

### Publish a system view

When you finish creating or updating a view, publish it so people in your organization can use it:

1. Open the view you want to publish.
1. In the designer, select **Publish**.

---

## Create a personal view

Create personal views with columns and filters that are relevant for you. You can open an existing view and modify the columns, apply filters, save it as a personal view, and share it with your team.

More information:
- [Edit columns in the view](/powerapps/user/grid-filters-advanced#column-editor)
- [Apply filters](/powerapps/user/grid-filters-advanced#filter-editor)
- [Create a personal view](/powerapps/user/grid-filters-advanced#create-personal-views)
- [Share a personal view](/power-apps/user/grid-filters-advanced#manage-and-share-personal-views)

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Customize forms](customize-forms.md)  
[Customize business process flows](customize-business-process-flows.md)
