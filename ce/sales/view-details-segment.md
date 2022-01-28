---
title: "View details of a segment in the sales accelerator"
description: "View the details of a segment such as, connected sequences, segment members, and assignment rules."
ms.date: 12/16/2021
ms.topic: article
author: udaykirang
ms.author: udag
manager: shujoshi
---

# View details of a segment

You can view the details of a segment, such as connected sequences, segment members, and assignment rules. 

## License and role requirements

| &nbsp; | &nbsp; |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security Role** | System Administrator or Sequence Manager <br>  Go to [Predefined security roles for Sales](security-roles-for-sales.md)|
|||

## Open and view details of a segment

1.	Sign in to your Dynamics 365 Sales Hub app.   

2.	Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.

3.	Under **Sales accelerator**, select **Segments**.   

    The **Segments** page opens with the list of available segments with details such as status, record type, and owner. The status of a segment specifies whether the segment is active, inactive, or paused. If a segment is paused, it means that the record type of the segment has been deleted from the sales accelerator configuration. You can't activate a paused segment. Add the record type to the configuration to move the segment back to its previous state (active or inactive). For more information about the record type configuration, go to [Choose content and layout](enable-configure-sales-accelerator.md#choose-content-and-layout). 
    
    >[!NOTE]
    >The lead and opportunity record types won't be paused. By default, the lead and opportunity record types are always available in segments even if they're not added as record types.

    >[!div class="mx-imgBorder"]
    >![Segments page with a list of segments.](media/sa-segment-edit-list-lead-segments.png "Segments page with a list of segments")  

4.	Open a segment, and then select the **Details** tab. In this example, **Seattle leads** is selected.

    >[!div class="mx-imgBorder"]
    >![Select and open a lead.](media/sa-segment-select-lead.png "Select and open a lead")  

    The following information about the segment is displayed:

    - **Record type**: The type of record that the segment supports.
    - **Connected sequence**: The sequence that the segment is connected to. When you select the connected sequence, the sequence opens in the sequence editor. You can view details of the connected sequence and perform actions such as adding records and segments. For more information, go to [Manage sequences](create-manage-sequences.md).<!--note from editor: Note that the "More information:" format must occur at the end of a paragraph. That's why it's never followed by a period.-->
        When you select **Back** on the **Sequences** page, you're directed back to the segment details page. 
    - **Assignment rules**: The assignment rule that the segment is connected to. When you select the assignment rule, the rule opens in the editor. You can edit and update the rule as required. For more information, go to [Edit an assignment rule](edit-assignment-rule.md).
        When you save or cancel, you're directed back to the segment details page.   
    - **Segment members**: A list of records that are associated with the segment. You can edit the records without moving away from the details page. Select the record, and the record opens in a dialog. More information: [Edit a segment](edit-a-segment.md). 

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Manage segments](manage-segments.md)    
[Create and activate a segment](create-and-activate-a-segment.md)   


[!INCLUDE[footer-include](../includes/footer-banner.md)]
 











