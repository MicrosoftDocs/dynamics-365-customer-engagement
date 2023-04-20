---
title: Edit a segment in the sales accelerator
description: Update the conditions in the segment to modify your process for choosing the records you want as members of a segment.
ms.date: 03/28/2023
author: udaykirang
ms.author: udag
ms.topic: how-to
ms.custom: bap-template
---
# Edit a segment 

To modify your process for choosing the records you want as members of a segment, you can update the conditions that you've defined in the segment.

## License and role requirements
| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Sequence Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|


## To edit a segment 

1.	Sign in to your Dynamics 365 Sales Hub app.   
2.	Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.
3.	Under **Sales accelerator**, select **Segments**.   
4. On the **Segments** page, choose a record type from the **Record type** list.

    The **Segments** page opens with the list of available segments for the selected record type.   

    :::image type="content" source="media/sa-segment-edit-list-lead-segments.png" alt-text="Screenshot of segment page with a list of segments for the selected record type.":::

5.	Select and open the segment that you want to edit. In this example, **Accounts from USA** is selected.

    :::image type="content" source="media/sa-segment-edit-select-lead.png" alt-text="Screenshot of opening a segment to edit.":::
 
5.	Select **Edit**. 
6.	On the confirmation message, select **Edit**.

    :::image type="content" source="media/sa-segment-edit-lead-edit-confirmation.png" alt-text="Screenshot of edit confirmation message.":::
  
7.	Edit the conditions, select **Save**, and then in the confirmation message that appears, select **Update segment**.

    :::image type="content" source="media/sa-segment-edit-lead-edit-save-confirmation.png" alt-text="Screenshot of confirmation message to save the edits.":::

The changes will be applied to records that are created in the future in the application. The records that the segment has already been applied to won't change.

>[!NOTE]
>From the 9.3 release, all segments that are related to a primary entity (such as lead or opportunity) run every time you update the attributes of the primary entity that are added to the conditions.


[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Create and activate a segment](create-and-activate-a-segment.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]
