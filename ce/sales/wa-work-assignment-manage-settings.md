---
title: Configure work assignment
description: Learn how to configure Dynamics 365 Sales to automatically assign work to your sales teams.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
<<<<<<< HEAD
ms.topic: how-to
ms.collection:
ms.date: 08/11/2023
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/19/2023
=======
ms.topic: how-to 
ms.collection: 
ms.date: 10/19/2023
ms.custom: bap-template 
>>>>>>> c226aeec818d54ae9ce0c31c73bfffd29ac6920f
---

# Configure work assignment

Work assignment is a feature of Dynamics 365 Sales that removes the burden of manually assigning leads, opportunities, and other work to your sales team. Using assignment rules that can consider sellers' attributes, availability, and capacity, the sales accelerator automatically assigns the right salesperson at the right time to the right leads and opportunities.

[!INCLUDE [sales-work-assignment](../includes/sales-work-assignment.md)]

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/), or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) |
| **Security roles** | [System Administrator, Sequence Manager, or Sales Manager](security-roles-for-sales.md) |

## Configure work assignment for your sales team

Configuring work assignment is simple:

1. [Select the security roles that assignment rules can automatically assign records to](./wa-manage-sales-teams.md).
1. [Create segments to group incoming leads and opportunities](./wa-create-and-activate-a-segment.md).
1. [Create sequences to automate the steps of your sales process](./create-and-activate-a-sequence.md).
1. [Connect segments to sequences](./wa-connect-a-segment-to-sequence.md).
1. [Set sellers' attributes and capacity](./wa-manage-seller-attributes.md).
1. [Determine how your sellers' availability is set and which calendar to use](./wa-manage-seller-availability.md).
1. [Create and activate assignment rules](./wa-create-and-activate-assignment-rule.md).

## Change work assignment settings

After you configure work assignment for your organization, you can make adjustments as needed:

- [Stop assigning work to sellers](#stop-assigning-work-to-sellers) who are on vacation or otherwise unavailable.
- [Change the priority of your assignment rules](wa-change-priority-assignment-rule.md).
- [Edit your assignment rules](wa-edit-assignment-rule.md) if you need to more extensive changes.
- [Delete or deactivate assignment rules](wa-delete-deactivate-assignment-rule.md) you no longer need.
- [Edit segments](wa-edit-a-segment.md) to fine-tune the records that get connected to them.
- [Delete or deactivate segments](wa-delete-deactivate-a-segment.md) that are no longer useful.

## Stop assigning work to sellers

While sellers are on vacation or are otherwise unavailable, you can stop new records from being assigned to them automatically. Turn assignment on the same way when they're back at work.

1. Sign in to your Sales Hub app.

1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.

1. Under **Sales accelerator**, select **Work assignment**.

1. Select **Settings**.

1. (Optional) If the list of sellers is long, [use filters to focus on the ones you want](./wa-manage-seller-attributes.md#shortlist-sellers-using-search-and-advanced-filters).

1. Turn off the toggle in the **Assign records** column and confirm when you're prompted to do so.

<<<<<<< HEAD
[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]
=======
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

## Set a seller availability

To set a seller's availability, select the seller and then select **Set availability**. The seller's calendar opens, where you can configure the seller's work hours and vacation days. For more information, see [How can I manage seller availability?](wa-manage-seller-availability.md#how-can-i-manage-seller-availability).

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
>>>>>>> c226aeec818d54ae9ce0c31c73bfffd29ac6920f
