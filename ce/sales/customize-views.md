---
title: Create and customize views
description: Explore how to customize views in Sales, create system views and personal views, and adjust column widths and filters for tailored data presentation.
ms.date: 03/29/2024
ms.topic: article
author: lavanyakr01
ms.author: lavanyakr
ms.reviewer: lavanyakr
ms.custom:
  - dyn365-sales
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:03/28/2024
---

# Customize views

In Dynamics 365 Sales, use views to define how a list of records for a specific entity is displayed.

## What's a view

A view defines:

- The columns to be displayed.
- The width of columns displayed.
- How the list of records is sorted by default.
- What default filters are applied to restrict which records will appear in the list.

The records that are visible in individual views are displayed in a list, sometimes called a grid, which frequently provides options so that people can change the default sorting, column widths, and filters to more easily see the data that’s important to them. Views also define the data source for charts that are used in the application.

## Types of views

There are two types of views in Dynamics 365 Sales:

- **System and public views**

     System and public views are views that are included with the app or that are created by customizers and made available to some or all users. As a system administrator or system customizer, you can edit these views. System or public views are special views the application depends on, which exist for system entities or are automatically created when you create custom entities.

- **Personal views**

     Personal views are created by individual users. They are visible only to that user or to other users they choose to share their personal views with. As a user, you can create a new personal view based on a system or public view. You can't create a system or public view based on a personal view. [Learn more about sharing personal views](/powerapps/user/grid-filters-advanced#manage-and-share-personal-views).

## Create a system view

Depending on the license you have, select one of the following tabs for more information:

# [Sales Premium and Sales Enterprise](#tab/SE)

1. Sign in to [Power Apps](https://make.powerapps.com/).
2. Follow the instructions in [Create and edit public or system model-driven app views](/power-apps/maker/model-driven-apps/create-or-edit-model-driven-app-view?context=/dynamics365/context/sales-context) to create or customize system views.

# [Sales Professional](#tab/SP)

This topic covers how to create system views as a customizer.

### Open a system view

1. In the Sales Professional site map, select **Sales Settings**.
2. Under **Customization**, select **Views**.

    :::image type="content" source="media/sales-settings-views.svg" alt-text="Screenshot of the Sales Settings page for Views":::

3. In the **Name** column, select a view to open it or search for a view in the **Filter by keyword** box.

### Create a system view

You can create your own views, specific to your organization's practices and processes.

1. In the Sales Professional site map, select **Sales Settings**.
2. Under **Customization**, select **Views**.
3. On the **Views** page, select **Create a view**.
4. Select the entity to use for the view.

    :::image type="content" source="media/select-entity-drop-down-list.png" alt-text="Screenshot of Select entity drop-down list":::

5. Select **Go to View Designer** at the bottom of the pane.

    :::image type="content" source="media/go-to-view-designer.png" alt-text="Screenshot of Go to View Designer button":::

6. To specify the view name:
    1. Expand the **Columns** section and select **Click to Add View Name**.
    2. Enter the name for your view. The name is set when you click or tab outside the text box. You can change the name later by clicking it again, or by changing it in the **Properties** tab.

### Add a column to your view

Views display records in a table that contains rows and columns. Each row is a record, and the fields from the records are determined by the columns you add to the view.

1. In the View Designer, select **Add** in the upper-left corner.
2. Select **Primary Entity** or **Related Entity** to display the list of available fields on the **Components** tab.
3. Do one of the following:
    - Double-click the name of the field you want to add. It will be added as the last column in the view.
    - Drag the field onto the grid. You can drag the field to position it before an existing column when you add it.
    - Select the field and press Enter.

- You can also move the columns around after they are added to your view.

### Set column width

After adding the columns, you can change the width of the column.

1. Select the column in the view.
2. In the **Properties** tab, set the width to the value you want by using the arrows to increase or decrease the column width.

### Set the primary and secondary column sort order

When a view is opened, the records displayed are sorted based on the order you set when creating the view. You can sort on a single column or two columns with a primary and secondary sort order. When the view is opened, the records are sorted by the column defined as the primary sort, and then by the column defined as the secondary sort.

>[!NOTE]
>You can only set primary and secondary sort on columns from the primary entity.

1. Select the column to use as the primary or secondary sort.
2. In the drop-down menu, select **Primary Sort** or **Secondary Sort**.

    :::image type="content" source="media/set-sort-order.png" alt-text="Screenshot of Set sort order":::

>[!NOTE]
>If you remove the column defined as the primary sort, the column defined as the secondary sort becomes the primary sort.

### Set the order for the primary sort

You can set the sort order to ascending or descending for the column defined as the primary sort column:

1. Select the column set as the primary sort.
2. Choose the arrow next to the name to change the order.

    :::image type="content" source="media/set-ascending-descending.png" alt-text="Screenshot of Set ascending or descending":::

When the arrow is pointing up, the sort order is ascending. When the arrow is pointing down, the sort order is descending.

### Rearrange columns in a view

You can change the order of the columns already included in your view.

1. Select the column you want to move.
2. Drag the column to the position you want to move it to. You will see a visual indicator when you hold the column over an allowed position.

    :::image type="content" source="media/rearrange-columns.png" alt-text="Screenshot of the view designer with columns being rearranged":::

>[!NOTE]
>You can also rearrange columns by using the Ctrl+X and Ctrl+V keyboard shortcuts.

### Remove a column from a view

You might want to remove a column from a default system view, or one that you added to a form but no longer want to use.

Select the column you want to remove and select **Remove Column**.

### Define filter criteria

You can set filter criteria so that only a subset of the records is displayed in a view. When someone opens the view, only the records that meet the defined filter criteria are displayed. You can select fields from both the primary and related entities to filter on.

1. In the designer, expand the **Filter Criteria** section.
2. Select **Add Filter**.
3. In the **Select** drop-down, select the field you want to filter on.
4. In the drop-down list in the second column, select the operator to use for the filter. The available operators depend on the selected field.

    :::image type="content" source="media/select-operator.png" alt-text="Screenshot of Select operator":::

5. Enter a value to filter on in the field in the third column.

### Group multiple filters

You can add multiple filters to your view if you want to filter records using more than one field, and then group on fields:

1. Select **Add Filter** to add an additional filter to your view.
2. Select the operator to use and enter a value to filter on.
3. Select the check box next to each row of filter criteria.

    :::image type="content" source="media/group-filters.png" alt-text="Screenshot of Group filters":::

4. Select **Group And** or **Group Or** to group the filters.

When you select **Group And**, records that meet both criteria are displayed in the view. When you select **Group Or**, records that meet any of the filter criteria are displayed. For example, in the preceding example, to show records for contacts with an address in Seattle or Portland, select **Group Or**.

### Remove a filter group

1. Select the check box for the group.
2. Choose **Ungroup**.

    :::image type="content" source="media/ungroup-filters.png" alt-text="Screenshot of Ungroup filters":::

### Save a view

As you are working on your view, save it often to avoid losing any changes.

- In the designer, choose one of the following in the upper-right corner:
  - To save without closing the designer, select **Save**
  - If you're finished customizing your view, select **Save and Close**.

>[!NOTE]
>To make a copy of your view, select **Save As** to save the current view with a different name.

### Publish a system view

When you're finished creating or updating a view, you need to publish it so people in your organization can use it:

1. Open the view you want to publish.
2. In the designer, select **Publish**.

---

## Create a personal view

Create personal views with columns and filters that are relevant for you. You can open an existing view and modify the columns, apply filters, and save it as a personal view.

More information:
- [Edit columns in the view](/powerapps/user/grid-filters-advanced#column-editor)
- [Apply filters](/powerapps/user/grid-filters-advanced#filter-editor)
- [Create a personal view](/powerapps/user/grid-filters-advanced#create-personal-views)


[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

[Customize forms](customize-forms.md)  
[Customize business process flows](customize-business-process-flows.md)
