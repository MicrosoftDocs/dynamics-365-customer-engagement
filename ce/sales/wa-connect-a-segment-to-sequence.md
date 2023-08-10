---
title: "Connect a segment to a sequence"
description: "Connect a segment to a sequence based on the entity that the sequence is created in the sales accelerator in Dynamics 365 Sales."
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 08/11/2023
ms.custom: bap-template 
---

# Connect a segment to a sequence 

After you create and activate a segment, you connect the segment to a sequence depending on the entity that you've created the sequence for.

> [!NOTE]
>  
> You can also use sequences designer to connect segments to a sequence. Open the sequences to view their details, and then add segments to them. More information: [View details of a sequence and its connected records](view-sequence-details-connected-records.md).  

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sequence Manager, or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

<!--markdownlint-disable MD036-->
## To connect a segment to a sequence
<!--markdownlint-enable MD036-->
>[!NOTE]
>In this procedure, we are using leads as example.

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.
1. Under **Sales accelerator**, select **work assignment**.  
1. From the **Record type** list, choose **Leads** and then open the segment.
1. On the segment page, go to the **Attached sequence** tab and select **Connect sequence**.  

    :::image type="content" source="media/wa-segment-attach-sequence-tab.png" alt-text="Screenshot of the Attached sequence tab.":::

1. From the list of sequences, select the sequence that you want to connect and then select **Connect**. 

    >[!NOTE]
    >
    >If no sequences are available, select **Create new sequence** to create a sequence. More information: [Create and activate a sequence](create-and-activate-a-sequence.md).
    
    The sequence is connected to the segment. 

If you want to connect a different sequence to the segment, you must first disconnect the current sequence and subsequently connect the new sequence. 

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Create and activate a segment](wa-create-and-activate-a-segment.md)  
[Edit a segment](wa-edit-a-segment.md)
[View and edit properties of a segment](wa-view-details-segment.md)
