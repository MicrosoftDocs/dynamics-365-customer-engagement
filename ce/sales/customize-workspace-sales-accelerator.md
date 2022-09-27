---
title: "Customize the workspace for sales accelerator"
description: "Customize filtering, sorting, and work item appearance tailored to your specific needs."
ms.date: 10/06/2022
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# Customize the workspace

Customize the workspace by configuring filters, sort, and work item appearances tailored to your specific needs in sales accelerator.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Enterprise, Dynamics 365 Sales Premium, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Sequence Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Customize the workspace for sellers

After the [first-run setup of the sales accelerator](enable-configure-sales-accelerator.md#first-run-setup), customize the workspace by configuring filters, sort, and work item appearances to short-list the ones that serve your sellers' specific needs.   

For example, if sellers want to filter work items based on currency type for leads, you can add a filter by selecting the record type as **Lead** and the field as **Currency**. Sellers can then use this filter to refine work items and view leads with a specific currency type, such as **US dollar**.

**To open the filtering and sorting configuration page**

1. Sign in to your sales app, and in the lower-left corner of the page, go to **Change area** ![change area.](media/change-area-icon.png) > **Sales Insights settings**.

2. Under **Sales accelerator**, select **Workspace**.

    The sales accelerator workspace setup page opens. 

    >[!div class="mx-imgBorder"]
    >![Sales accelerator setup page.](media/sa-setup-page.png "Sales accelerator setup page")   

3.	In the **Customize workspace** section, select **Filtering and sorting**.
    
    The **Filters** page opens.
    
    >[!div class="mx-imgBorder"]
    >![Filtering and sorting page.](media/sa-filters-page.png "Filtering and sorting page")   
    
    Through the Filtering and sorting, you can do the following tasks:
       - [Manage filters](#manage-filters)
       - [Manage sort](#manage-sort) 

## Manage filters

Filters help to refine the work item that your seller wants to see in the sales accelerator workspace. You can manage custom filters by doing the following tasks:

-	[Add basic and advanced filters](#add-basic-and-advanced-filters)
-	[Add groups](#add-groups)
-	[Hide filters](#hide-filters)
-	[Edit custom filters and groups](#edit-custom-filters-and-groups)
-	[Move filters to a group](#move-filters-to-a-group)
-	[Delete custom filters and groups](#delete-custom-filters-and-groups)

>[!NOTE]
>To know how sellers can use custom filters, go to [Custom filters](prioritize-sales-pipeline-through-work-list.md#custom-filters).   

### Add basic and advanced filters

You can create the filters based on your seller requirements such as, basic and advanced filters.

- **Basic filters**: Filter data by creating a simple filter expression.
- **Advanced filters**: Filter data by creating complex filter expressions by combining multiple fields through the AND function.

**To create filters**

1.	On the **Filtering and sorting** page, under the **Filter** tab, select **New filter**.
    
    :::image type="content" source="media/sa-filters-select-new-filter.png" alt-text="Screenshot of the filtering and sorting page to select a new filter.":::    
    
2.	In the **New create filter** pane, select the following options as required.
    
    - <a name="sa-basic-filter"></a>**For basic filter**, enter the following information:
        
        | Parameter | Description |
        |-----------|-------------|
        | Record | Select the type of record that you want to use to filter the work list. You can select only the record types that were added during content and layout configuration when you set up the sales accelerator.<br>For more information, go to step 7 in [First-run set up](enable-configure-sales-accelerator.md#first-run-set-up).<br>The parameters **Field** and **Filter name** won't be active until you choose the record type. |
        | Field | Select a field based on which sellers can enter a value to filter the work list. The fields displayed in the list are the basic attributes of the selected record type. |
        | Filter name | Enter a name for the filter. By default, the name is selected as *record type.field*. For example, **Lead.Currency**. | 
        | Add filter to a group | Select a group to which you want to add the filter. Grouping filters helps sellers to easily identify and apply filters. If you don't select a group, the filter is added to the default **More filters** group. To know how to create groups, go to [Add groups](#add-groups). |        

        :::image type="content" source="media/sa-filters-new-filter.png" alt-text="Screenshot of the basic filter side pane.":::    

    - <a name="sa-advanced-filter"></a>**For advanced filter**, go to the **Advanced filter** tab and enter the following information:
        
        | Parameter | Description |
        |-----------|-------------|
        | Record | Select the type of record that you want to use to filter the work list. You can select only the record types that were added during content and layout configuration when you set up the sales accelerator.<br>For more information, go to step 7 in [First-run set up](enable-configure-sales-accelerator.md#first-run-set-up).<br>The parameters **Field** and **Filter name** won't be active until you choose the record type. |
        | Field | Select **Add**. On the field options, select the field, operator and value. To add multiple fields, select **Add** and enter the required information. Based on the selected fields, sellers can enter a value to filter the work list. The fields displayed in the list are the basic attributes of the selected record type.<br>The following screenshot is an example of advanced filed with multiple fields:<br>:::image type="content" source="media/sa-filters-advanced-filter-multiple fields.png" alt-text="Screenshot of the advanced filter with multiple fields.":::|
        | Filter name | Enter a name for the filter. By default, the name is selected as *record type.field*. For example, **Lead.Currency**. | 
        | Add filter to a group | Select a group to which you want to add the filter. Grouping filters helps sellers to easily identify and apply filters. If you don't select a group, the filter is added to the default **More filters** group. To know how to create groups, go to [Add groups](#add-groups). |        

        :::image type="content" source="media/sa-filters-new-advanced-filter.png" alt-text="Screenshot of the advanced filter side pane.":::    

3.	Save and publish the filters.

The filter is created and added to the filters list.    

### Add groups

Filter groups help you to organize filters in a meaningful way for sellers to easily identify them.

1.	Use one of the following ways to create groups:

    -	On the **Filtering and sorting** page, select **New group**.
    -	While creating a filter, in the **Add filter to a group** dropdown list, select **Create a new filter group**.

2.	In the **Create new filter group** dialog box, enter the name of the group.  

    :::image type="content" source="media/sa-filters-new-groups.png" alt-text="Screenshot of the new filter group dialog box.":::  
 
3.	Save and publish the group.

The group is created, and you can add filters to the group.

### Hide filters

You can hide any filter from the filter list. After you hide a filter, sellers can't view the filter in their list. 

1.	On the **Filters** tab, go to the filter that you want to hide and turn off the toggle. 

    >[!NOTE]
    >To hide a group, turn off the toggle for the group.
 
    :::image type="content" source="media/sa-filters-hide-filter.png" alt-text="Screenshot of Turning off the toggle to hide a filter.":::  

2.	Select **Publish**.  

The filter is hidden from the list that sellers use. However, the filter will be available in the application, and you can turn on the toggle to activate it again.

### Edit custom filters and groups<a name="edit-name-of-custom-filters-and-groups"></a>

>[NOTE]
>You can't edit the out-of-the-box filters that are listed under the **Default filters** group.  

1.	On the **Filtering and sorting** page, select the filter or group.

    >[!NOTE]
    >Hover over the filter and select More options > **Edit** (![Edit filter icon.](media/edit-icon.png "Edit filter icon")).   

    The edit filter pane opens. In this example, a basic filter is opened for edit:

    :::image type="content" source="media/sa-filters-edit-filter.png" alt-text="Screenshot of editing a basic filter.":::  
    
2.	Update the filter as required, and then save and publish.

The filter is updated and available for sellers to use.

### Move filters to a group

>[!NOTE]
>- You can't move the out-of-the-box filters to a custom group.  
>- You can't move custom filters to the **Default filters** group.

1.	Select the filter, and then select **Move to** (![Move filter icon.](media/move-icon.png "Move filter icon")).

    :::image type="content" source="media/sa-filters-select-filter-move.png" alt-text="Screenshot of selecting a filter to move.":::  

2.	In the **Move filter to group** dialog box, from the **Filter group** list, choose the group name.

    :::image type="content" source="media/sa-filters-move-filter-dialog.png" alt-text="Screenshot of choosing a group to move.":::  
 
3.	Select **Move** and then publish the filter list.

The filter is moved to the filter list of the selected group.

### Delete custom filters and groups

You can delete filters that are no longer required in your organization.

>[!NOTE]
>You can't delete the filters that are available out-of-the-box under the **Default filters** group.

1.	On the **Filtering and sorting** page, select the filter or group.   
    You can also choose multiple filters and groups to delete.   

2. Select **Delete** (![Delete filter icon.](media/delete-icon.png "Delete filter icon")).
 
    >[!NOTE]
    >When you delete a group, all filters under the group will also be deleted.   

    :::image type="content" source="media/sa-filters-delete-filter.png" alt-text="Screenshot of deleting filters.":::      

2.	In the confirmation message, select **Delete permanently**.

3.	Select **Publish**.   

The filter is permanently deleted from the list. 

## Manage Sort

Sorting determines the order in which the sellers want to view the work items. By default, the following sorts are provided in sales accelerator&mdash;Activity type, Due date, Name, Record type, Score, and Sequence name.

You can manage custom sort by doing the following tasks: 

-	[Add custom sort](#add-custom-sort)
-	[Choose a sort type as default](#choose-a-sort-type-as-default)
-	[Edit a sort type](#edit-a-sort-type)
-	[Hide sort](#hide-sort)
-	[Change sort order](#change-sort-order)
-	[Delete sort](#delete-sort)

### Add custom sort

You can create sorts based on your seller requirements. 

1.	On the **Filtering and sorting** page, under the **Sort** tab, select **New sort**.
    
    :::image type="content" source="media/sa-sort-select-new-sort.png" alt-text="Screenshot of the filtering and sorting page to select a new sort.":::    
    
2. In the **Create new sort** pane, enter the following information as required.
    
    | Parameter | Description |
    |-----------|-------------|
    | Record | Select the type of record that you want to use to sort the work list. You can select only the record types that were added during content and layout configuration when you set up the sales accelerator.<br>For more information, go to step 7 in [First-run set up](enable-configure-sales-accelerator.md#first-run-set-up).<br>The parameters **Field** and **Sort name** won't be active until you choose the record type. |
    | Field | Select a field based on which sellers can sort the work list. The fields displayed in the list are the basic attributes of the selected record type. |
    | Sort name | Enter a name for the sort. By default, the name is selected as *record type.field*. For example, **Lead.Name**. |
    | Make this the default sort | Select the option to make this sort as default. When sellers open sales accelerator, work items are sorted according to the default sort. |

    :::image type="content" source="media/sa-sort-enter-values-sort.png" alt-text="Screenshot of the create new sort pane with sort values.":::    

3. Select **Save**.

The sort is created and added to the list.

### Choose a sort type as default

You can choose a sort type as default for sellers to view the order of work items when sales accelerator workspace is opened. However, you can't delete or hide a default sort type, but you can edit. 

The default sort type is always identified by a check mark corresponding to the sort name.

**To choose a default sort type**   

1.	On the **Filtering and sorting** page, go to the **Sort** tab, select the sort type that you want to set as default.

    :::image type="content" source="media/sa-sort-select-sort-type.png" alt-text="Screenshot of choosing a sort type to set as default.":::    

2. Select **Mark default**.

    >[!NOTE]
    >Also, you can select More option corresponding to the selected sort type and then select **Mark default**. 

    The selected sort type is marked as default.

    :::image type="content" source="media/sa-sort-set-default-sort-type.png" alt-text="Screenshot of a sort type set as default.":::    

3. Select **Publish**. 

The selected sort type is set as default and when sellers open their work list, the items are sorted according to the default sort type.

### Edit a sort type

>[NOTE]
>You can't edit the out-of-the-box sort types.  

1.	On the **Filtering and sorting** page, go to the **Sort** tab, select the sort type and then select **Edit**.

    >[!NOTE]
    >Hover over the filter and select **More options** > **Edit** (![Edit filter icon.](media/edit-icon.png "Edit filter icon")).   

    The **Edit sort** pane opens. 

    :::image type="content" source="media/sa-sort-edit-sort.png" alt-text="Screenshot of editing a sort type.":::  
    
2.	Update the sort as required, and then save and publish.

The filter is updated and available for sellers to use.

### Hide sort

You can hide any sort type from the sort list. After you hide a sort type, sellers can't view the sort in their list. 

>[!NOTE]
>You can't hide the default sort type.

1.	On the **Filtering and sorting** page, go to the **Sort** tab, go to the sort type that you want to hide and turn off the toggle. 

    :::image type="content" source="media/sa-sort-hide-sort.png" alt-text="Screenshot of turning off the toggle to hide a sort.":::  

2.	Select **Publish**.  

The sort is hidden from the list that sellers use. However, the sort type will be available in the application, and you can turn on the toggle to activate it again.

### Change sort order

You can arrange the sort in the order in which you want to display to the sellers in the sales accelerator workspace.

**To change the order**

1.	On the **Filtering and sorting** page, go to the **Sort** tab and select the sort type.

    >[!NOTE]
    >You can select only one sort type at a time. 

2. Use the up and down arrows corresponding to the sort type to change the order. 

    :::image type="content" source="media/sa-sort-select-sort-move.png" alt-text="Screenshot of selecting a sort to move.":::  
    
    >[!NOTE]
    >- The up arrow will be disabled for the sort type that is on the top of the list. 
    >- The down arrow will be disabled for the sort type that is at the bottom od the list.

3.	Select **Publish**.

### Delete sort

You can delete sort types that are no longer required in your organization.

>[!NOTE]
>You can't delete the out-of-the-box sort types.

1.	On the **Filtering and sorting** page, go to the **Sort** tab and select the sort type.   
    You can also choose multiple sort types to delete.   

2. Select **Delete** (![Delete filter icon.](media/delete-icon.png "Delete filter icon")).
 
    :::image type="content" source="media/sa-sort-delete-sort.png" alt-text="Screenshot of deleting sort types.":::      

2.	In the confirmation message, select **Delete permanently**.

3.	Select **Publish**.   

The sort type is permanently deleted from the list. 

## Configure work item appearance 

The work list in sales accelerator helps sellers prioritize their time and effort. Customize work items to display the most relevant and important information in the work list. You can customize work items for each entity type that you or your sellers work with.

More information: [Customize the appearance of work items](customize-work-list-card.md)


[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[What is the sales accelerator?](sales-accelerator-intro.md)      
[Configure sales accelerator](enable-configure-sales-accelerator.md)    
[Manage access and record type](manage-access-record-type-sales-accelerator.md) 