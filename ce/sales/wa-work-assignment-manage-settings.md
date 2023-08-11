---
title: Manage work assignment settings
description: Using the work assignment settings to configure required permissions, attributes, and capacity for sellers.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 08/11/2023
ms.custom: bap-template 
---

# Manage work assignment settings 

Using the work assignment settings, you can configure the following settings for your sales teams:

- [Add attributes to sellers](#add-attributes-to-sellers)  
- [Shortlist sellers through advanced filters](#shortlist-sellers-through-advanced-filters)  
- [Set capacity for sellers](#set-capacity-for-sellers)  
- [Turn off record assignment to sellers](#turn-off-record-assignment-to-sellers)  

Along with the above settings, you can also manage the following settings for your sales teams:
  
- [Configure security roles to assign records](wa-manage-sales-teams.md)  
- [Manage seller attributes](manage-seller-attributes.md)  
- [Manage seller availability](manage-seller-availability.md)

Before you configure, verify that the security roles that are assigned to your sellers were selected when the sales accelerator was configured. More information: step 4 in [Set up the sales accelerator](enable-configure-sales-accelerator.md)

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sequence Manager, or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Add attributes to sellers

Attributes define the characteristics of a seller, such as skills, location, and language. Before you apply attributes to sellers, verify that the attributes have been defined. More information: [Manage seller attributes](manage-seller-attributes.md)

You can apply attributes in bulk by selecting multiple sellers at a time.
<!--markdownlint-disable MD036-->
**To add attributes**

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.  
1. Under **Sales accelerator**, select **Work assignment**.  
1. On the **Work assignment** page, select **Settings**.  
1. From the **Sellers for assignment** section, select a team or sellers that you want to apply attributes for and then select **Apply attribute**.  
    
    >[!NOTE]
    >
    >- The list consists teams that include sellers whose security roles were configured during the initial setup of the sales accelerator.
    >- To bulk-apply the attributes, select multiple sellers.

    :::image type="content" source="media/sa-ar-sales-team-apply-attribute.png" alt-text="Screenshot of the work assignment settings page with selected seller attributes to apply.":::

1. On the **Apply attribute** pane, select **Add attribute**, and then choose the attribute and its corresponding values. Repeat this step for each attribute you want to add.

    > [!NOTE]
    >
    > If you're adding attributes to a seller who already has defined attributes, choose one of the following options and proceed with adding the attributes:
    > -	**Replace existing attributes with new attributes**: This option replaces the existing attributes that were already applied to the seller. If any leads were assigned to the seller based on the previous attributes, those leads won't be affected.
    > -	**Keep existing attributes and add more**: This option adds more attributes to the seller, in addition to the attributes that were already applied.

1.	Select **Apply**.

The attributes are applied to the sellers.

## Shortlist sellers through advanced filters

You can shortlist sellers from a huge list to apply attributes, set capacity, and more. The filters are based on the seller attributes such as account, city, country, region, sale amount, and other information. Only the sellers that match the criteria are displayed on the list, which helps in reducing the time taken to search for sellers.   
The filters you apply are available only for that session and can’t be saved. You must create a filter every time you sign in to your organization.

>[!NOTE]
>Before you apply the filters, verify that the sellers with required security roles are granted access to the auto-assignment of rules. More information: [Configure security roles to assign records](wa-manage-sales-teams.md) 

**To create and apply filters**

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.  
1. Under **Sales accelerator**, select **Work assignment**.    
1. On the **Work assignment** page, select **Settings**.  
1. On the **Settings** page, select **Advanced filters**.  
    The **Filter by seller properties** pane opens.
    
    :::image type="content" source="media/sa-ar-sales-team-advanced-filters-pane.png" alt-text="Screenshot of the filter by seller properties pane.":::
    
1. Select **Add** and then choose the filter options as described in the following table:

    | Filter option | Description |
    |---------------|-------------|
    | Add row | Add conditions for which the sellers should be listed. In the following example, we add a row to view sellers only from the city **Seattle**.<br>1.	Select the attribute **City** from the dropdown list in the first column.<br>2.	Select the operator as **Equals** from the dropdown list in the second column.<br>3. Enter the value as **Seattle** to filter by in the third column.<br>:::image type="content" source="media/sa-ar-sales-team-advanced-filters-add-row.png" alt-text="Screenshot showing to add a row to advanced filter." lightbox="media/sa-ar-sales-team-advanced-filters-add-row.png":::<br> Similarly, you can create more conditions to further filter the sellers as required. |
    | Add group | Add multiple conditions as a group to filter sellers by using more than one field: <br>1.	Select **And** or **Or** to group the conditions.<br>:::image type="content" source="media/sa-segment-condition-add-group.png" alt-text="Add conditions to the group." lightbox="media/sa-ar-sales-team-advanced-filters-add-row.png":::<br>2.	Select the conditions that you want to add to the group.<br>:::image type="content" source="media/sa-ar-sales-team-advanced-filters-group-add-and-condition.png" alt-text="Add a group condition to advanced filter." lightbox="media/sa-ar-sales-team-advanced-filters-group-add-and-condition.png":::<br>When you select **And**, the filter is applied to sellers that meet both criteria. When you select **Or**, the filter is applied to sellers that meet any of the filter criteria. For example, to filter sellers that were created by Kenny Smith and are from APAC region, select **And**.<br>Similarly, you can create multiple groups and further filter the leads based on the conditions defined in the groups. |
    | Add related entity | Add a condition based on the attributes of related entities. Select an attribute from the **Related Entity** list in the topmost field, and then choose **Contains data** or **Does not contain** data. This enables the condition section.<br>:::image type="content" source="media/sa-ar-sales-team-advanced-filters-group-add-related-entity-condition.png" alt-text="Add conditions through related entity." lightbox="media/sa-ar-sales-team-advanced-filters-group-add-related-entity-condition.png":::<br> |

    For more information on filters with grouped and nested conditions, see [Create or edit filters in model-driven app views](/powerapps/maker/model-driven-apps/create-edit-view-filters).
    
1. After you define the filter criterion, select **Apply**.  
    
    The list is filtered based on the selected criterion.

## Set capacity for sellers

When you set capacity, you set a combined upper limit of leads and opportunities that a seller can be assigned at any given time. When a seller reaches this limit, even though a lead or an opportunity record is created and ready to be automatically assigned to the seller, the record won't be assigned. You can view unassigned records for leads and opportunities in their respective open record views.

For example, Kenny is a seller whose capacity limit is set to 10. A new lead is generated, and the assignment rule qualifies the lead to be assigned to Kenny. However, Kenny is currently handling a maximum of 10, so the newly generated lead won't be assigned to Kenny.

**To set capacity**

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.  
1. Under **Sales accelerator**, select **Work assignment**.    
1. On the **Work assignment** page, select **Settings**.  
1. From the **Sellers for assignment** section, select a team or sellers that you want to apply attributes for and then select **Set capacity**.

    >[!NOTE]
    >
    >- The list consists teams that include sellers whose security roles were configured during the initial setup of the sales accelerator.
    >- To bulk-apply the attributes, select multiple sellers.

    The **Set maximum capacity** pane opens.

    :::image type="content" source="media/sa-ar-sales-team-enter-lead-capacity.png" alt-text="Screenshot to enter the maximum number of leads for a seller.":::

1. In **Set the maximum capacity of leads and opportunities for these sellers**, enter the value you want.  
1. Select **Apply**.

    >[!NOTE]
    >
    >If you're changing the existing maximum capacity, a confirmation message appears. Select **Override settings**.  
    >![Select override settings](media/sa-ar-sales-team-select-override-settings.png "Select override settings")  
  
The maximum capacity limit is set for the seller.  

## Turn off record assignment to sellers

When a seller is on vacation or otherwise unavailable, you can disable record assignment until the seller is available again. 

**To turn off assignment**
<!--markdownlint-enable MD036-->  
1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.  
1. Under **Sales accelerator**, select **Work assignment**.  
1. On the **Work assignment** page, select **Settings**.  
1. Under the **Assign records** column, turn off the toggle.  
1. In the confirmation message, select **Turn off availability**.  

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Configure security roles to assign records](wa-manage-sales-teams.md)  
[Manage seller attributes](wa-manage-seller-attributes.md)  
[Manage seller availability](wa-manage-seller-availability.md)
