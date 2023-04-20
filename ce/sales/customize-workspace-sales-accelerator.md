---
title: Customize the workspace for sales accelerator
description: Customize filtering, sorting, and work item appearance in the Dynamics 365 sales accelerator.
ms.date: 10/19/2022
ms.topic: article
author: udaykirang
ms.author: udag
---

# Customize the sales accelerator workspace

Customize the sales accelerator workspace by configuring filters, sorting, and the appearance of work items.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/sales/relationship-sales/)<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Sequence Manager<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Customize the workspace for sellers

After the [first-run setup of the sales accelerator](enable-configure-sales-accelerator.md#first-run-setup), you can customize the workspace to meet your sellers' needs. For example, if sellers want to filter work items based on currency type for leads, add a filter with the record type **Lead** and the field **Currency**. [Learn how sellers can use custom filters](prioritize-sales-pipeline-through-work-list.md#custom-filters).

1. Sign in to the Sales Hub app. In the lower-left corner of the page, go to **Change area** ![change area.](media/change-area-icon.png) > **Sales Insights settings**.

1. Under **Sales accelerator**, select **Workspace**.

    :::image type="content" source="media/sa-setup-page.png" alt-text="Screenshot of the Sales accelerator workspace settings page.":::

1. In the **Customize workspace** section, select **Filtering and sorting**.

    The **Filters** page opens. Here you can do the following tasks:

    - [Manage filters](#manage-filters)
    - [Manage sorting](#manage-sorting)

    :::image type="content" source="media/sa-filters-page.png" alt-text="Screenshot of the Filtering and sorting page.":::

## Manage filters

Filters help your sellers target specific work items in the sales accelerator workspace. In the **Filter** tab of the **Filtering and sorting** page, you can:

- [Add basic and advanced filters](#add-basic-and-advanced-filters)
- [Add groups](#add-groups)
- [Hide filters](#hide-filters)
- [Edit custom filters and groups](#edit-custom-filters-and-groups)
- [Move filters to a group](#move-filters-to-a-group)
- [Delete custom filters and groups](#delete-custom-filters-and-groups)

### Add basic and advanced filters

You can create two types of filters:

- **Basic filters**: Filters based on simple expressions
- **Advanced filters**: Filters based on complex expressions that combine multiple fields using the AND operator

1. In the **Filter** tab, select **New filter**.

    :::image type="content" source="media/sa-filters-select-new-filter.png" alt-text="Screenshot of the Filtering and sorting page, with the Filter tab and New filter highlighted.":::

1. In the **Create a new filter** pane, select the following options as required.

    - <a name="sa-basic-filter"></a>**For a basic filter**, enter the following information:

        | Parameter | Description |
        |-----------|-------------|
        | Record | Select the type of record that you want to use to filter the work list. You can select only the record types that you added during the content and layout configuration when you set up the sales accelerator.<br>For more information, go to step 7 in [First-run set up](enable-configure-sales-accelerator.md#first-run-set-up).<br>The parameters **Field** and **Filter name** won't be active until you choose the record type. |
        | Field | Select the field that you want to use to filter the work list. The fields in the list are the basic attributes of the record type you selected. |
        | Filter name | Enter a name for the filter. By default, the name is *record type.field*; for example, **Lead.Currency**. |
        | Add filter to a group | Select a group to add the filter to. Grouping filters helps sellers to easily identify and apply them. If you don't select a group, the filter is added to the default **More filters** group. [Learn how to add groups](#add-groups). |

        :::image type="content" source="media/sa-filters-new-filter.png" alt-text="Screenshot of the basic filter settings tab.":::

    - <a name="sa-advanced-filter"></a>**For an advanced filter**, select the **Advanced filter** tab and enter the following information:

        | Parameter | Description |
        |-----------|-------------|
        | Record | Select the type of record that you want to use to filter the work list. You can select only the record types that you added during the content and layout configuration when you set up the sales accelerator.<br>For more information, go to step 7 in [First-run set up](enable-configure-sales-accelerator.md#first-run-set-up).<br>The parameters **Field** and **Filter name** won't be active until you choose the record type. |
        | Field | Select **Add**. In the field options, select the field, operator, and value. To filter the work list on multiple fields using the AND operator, select **Add** and enter more filter conditions. The fields in the list are the basic attributes of the record type you selected.<br>The following screenshot is an example of an advanced filter with multiple fields:<br>:::image type="content" source="media/sa-filters-advanced-filter-multiple fields.png" alt-text="Screenshot of an advanced filter with multiple fields."::: |
        | Filter name | Enter a name for the filter. |
        | Add filter to a group | Select a group to add the filter to. Grouping filters helps sellers to easily identify and apply them. If you don't select a group, the filter is added to the default **More filters** group. [Learn how to add groups](#add-groups). |

        :::image type="content" source="media/sa-filters-new-advanced-filter.png" alt-text="Screenshot of the advanced filter settings tab.":::

1. Save and publish the filter.

### Add groups

Filter groups allow you to organize filters so that sellers can easily identify them.

1. Use one of the following methods to create a filter group:

    - In the **Filter** tab, select **New group**.
    - While creating a filter, in the **Add filter to a group** list, select **Create a new filter group**.

1. Under **New filter group**, enter the name of the new group.

    :::image type="content" source="media/sa-filters-new-groups.png" alt-text="Screenshot of creating a new filter group.":::  

1. Save and publish the group.

### Hide filters

You can hide any filter to prevent it from appearing in the filter list. You can hide an entire group of filters, too.

1. In the **Filter** tab, under **Show in workspace**, turn off the filter or group you want to hide.

    :::image type="content" source="media/sa-filters-hide-filter.png" alt-text="Screenshot of hiding a filter.":::  

1. Select **Publish**.  

The filter is hidden from the list that sellers use. However, the filter is still available in the application and you can turn it on again at any time.

### Edit custom filters and groups<a name="edit-name-of-custom-filters-and-groups"></a>

You can edit filters and groups that you created. You can't edit the out-of-the-box filters that are listed under the **Default filters** group.

1. In the **Filter** tab, hover over the filter or group and select **More options** > **Edit** (![Edit filter icon.](media/edit-icon.png "Edit filter icon")).

    :::image type="content" source="media/sa-filters-edit-filter.png" alt-text="Screenshot of editing a basic filter.":::  

1. Update the filter as required, and then save and publish.

### Move filters to a group

You can move filters that you created to a different group. You can't move the out-of-the-box filters to a custom group or move custom filters to the **Default filters** group.

1. In the **Filter** tab, select the filter, and then select **Move to** (![Move filter icon.](media/move-icon.png "Move filter icon")).

    :::image type="content" source="media/sa-filters-select-filter-move.png" alt-text="Screenshot of selecting a filter to move.":::  

1. In the **Filter group** list, select the group you want to move the filter to.

    :::image type="content" source="media/sa-filters-move-filter-dialog.png" alt-text="Screenshot of choosing a group to move the filter to.":::  

1. Select **Move** and then publish the filter list.

### Delete custom filters and groups

You can delete filters and groups that you created if your organization no longer needs them. You can't delete the filters that are available out-of-the-box under the **Default filters** group.

> [!NOTE]
> When you delete a group, all filters in the group are also deleted.

1. In the **Filter** tab, select one or more filters or groups.

1. Select **Delete** (![Delete filter icon.](media/delete-icon.png "Delete filter icon")).

    :::image type="content" source="media/sa-filters-delete-filter.png" alt-text="Screenshot of deleting filters.":::

1. In the confirmation message, select **Delete permanently**.

1. Select **Publish**.

## Manage sorting

Sorting determines the order in which sellers view their work items. By default, sellers can sort work items by activity type, due date, name, record type, score, and sequence name.

In the **Sort** tab of the **Filtering and sorting** page, you can:

- [Add a custom sort](#add-a-custom-sort)
- [Choose a sort type as the default](#choose-a-sort-type-as-the-default)
- [Edit a sort type](#edit-a-sort-type)
- [Hide a sort](#hide-a-sort)
- [Change the sort order](#change-the-sort-order)
- [Delete a sort](#delete-a-sort)

### Add a custom sort

You can create sorts based on your sellers' requirements.

1. In the **Sort** tab, select **New sort**.

    :::image type="content" source="media/sa-sort-select-new-sort.png" alt-text="Screenshot of the Filtering and sorting page to create a new sort.":::

1. In the **Create new sort** pane, enter the following information as required.

    | Parameter | Description |
    |-----------|-------------|
    | Record | Select the type of record that you want to use to sort the work list. You can select only the record types that you added during the content and layout configuration when you set up the sales accelerator.<br>For more information, go to step 7 in [First-run set up](enable-configure-sales-accelerator.md#first-run-set-up).<br>The parameters **Field** and **Sort name** won't be active until you choose the record type. |
    | Field | Select a field to use to sort the work list. The fields in the list are the basic attributes of the selected record type. |
    | Sort name | Enter a name for the sort. By default, the name is *record type.field*; for example, **Lead.Name**. |
    | Make this the default sort | Select this option to make this sort the default for the work list when sellers open the sales accelerator. |

    :::image type="content" source="media/sa-sort-enter-values-sort.png" alt-text="Screenshot of creating a new sort.":::

1. Select **Save**.

### Choose a sort type as the default

You can choose a sort as the default for work items when sellers open the sales accelerator workspace. You can edit, but not delete or hide, a default sort type. A check mark indicates the default sort type.

1. In the **Sort** tab, select the sort type that you want to set as the default.

    :::image type="content" source="media/sa-sort-select-sort-type.png" alt-text="Screenshot of choosing a sort type to set as default.":::

1. Select **Make default**.

    > [!NOTE]
    > You can also hover over a sort type and select **More options** > **Make default**.

    :::image type="content" source="media/sa-sort-set-default-sort-type.png" alt-text="Screenshot of a sort type set as the default.":::

1. Select **Publish**.

### Edit a sort type

You can edit sort types that you created. You can't edit the out-of-the-box sort types.  

1. In the **Sort** tab, select the sort type, and then select **Edit**.

    > [!NOTE]
    > You can also hover over the sort type and select **More options** > **Edit** (![Edit filter icon.](media/edit-icon.png "Edit filter icon")).

    :::image type="content" source="media/sa-sort-edit-sort.png" alt-text="Screenshot of editing a sort type.":::  

1. Update the sort as required, and then save and publish.

### Hide a sort

You can hide a sort to prevent it from appearing in the sort list. You can't hide the default sort type.

1. In the **Sort** tab, under **Show in workspace**, turn off the sort you want to hide.

    :::image type="content" source="media/sa-sort-hide-sort.png" alt-text="Screenshot of hiding a sort.":::  

1. Select **Publish**.  

The sort is hidden from the list that sellers use. However, the sort is still available in the application and you can turn it on again at any time.

### Change the sort order

You can arrange the list of sort types in the order you want them to appear to sellers when they open the sales accelerator workspace.

1. In the **Sort** tab, select a sort type.

1. Use the up and down arrows to change its position in the list.

    :::image type="content" source="media/sa-sort-select-sort-move.png" alt-text="Screenshot of moving a sort up or down in the list of sort types.":::  

1. Select **Publish**.

### Delete a sort

You can delete sort types that you created if your organization no longer needs them. You can't delete the out-of-the-box sort types.

1. In the **Sort** tab, select one or more sort types.

1. Select **Delete** (![Delete filter icon.](media/delete-icon.png "Delete filter icon")).

    :::image type="content" source="media/sa-sort-delete-sort.png" alt-text="Screenshot of deleting sort types.":::

1. In the confirmation message, select **Delete permanently**.

1. Select **Publish**.

## Configure work item appearance

The work list in the sales accelerator helps sellers to prioritize their time and effort. Customize work items to display the most relevant and important information in the work list. You can customize work items for each entity type that your sellers work with. [Learn how to customize the appearance of work items](customize-work-list-card.md).

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[What is the sales accelerator?](sales-accelerator-intro.md)  
[Configure the sales accelerator](enable-configure-sales-accelerator.md)  
[Manage access and record types](manage-access-record-type-sales-accelerator.md)
