---
title: Edit a segment
description: Update the conditions in the segment to modify your process for choosing the records you want as members of a segment.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 08/11/2023
ms.custom: bap-template 
---

# Edit a segment  

To modify your process for choosing the records, you want as members of a segment, you can update the conditions that you've defined in the segment.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sequence Manager, or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## To edit a segment 

>[!NOTE]
>In this procedure, we are using leads as example.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.  
1. Under **Sales accelerator**, select **work assignment**.  
1. From the **Record type** list, choose **Leads** and then open the segment.  
1. On the segment page, under the **Segment definition** tab, select **Edit**. 
    
    > [!NOTE]
    >  
    > If you are editing an active segment, you will see a confirmation message. Select **Edit** to continue.  
    > :::image type="content" source="media/sa-segment-edit-lead-edit-confirmation.png" alt-text="Screenshot of edit confirmation message.":::
  
1. Edit the conditions and then select **Save**.

    :::image type="content" source="media/sa-segment-edit-lead-edit-save-confirmation.png" alt-text="Screenshot of confirmation message to save the edits.":::

The changes will be applied to records that are created in the future in the application. The records that the segment has already been applied to won't change.

>[!NOTE]
>From the 9.3 release, all segments that are related to a primary entity (such as lead or opportunity) run every time you update the attributes of the primary entity that are added to the conditions.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Create and activate a segment](create-and-activate-a-segment.md)  

[!INCLUDE[footer-include](../includes/footer-banner.md)]
