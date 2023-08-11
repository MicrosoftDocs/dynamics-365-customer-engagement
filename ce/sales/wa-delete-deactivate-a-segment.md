---
title: Delete or deactivate a segment
description: Permanently delete a segment that is no longer required in your organization, or deactivate to retain the segment in the application in inactive mode.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 08/11/2023
ms.custom: bap-template 
---

# Delete or deactivate a segment 

You can deactivate or delete a segment that's no longer required in your organization. Deactivation retains the segment in the application, the records that were already connected to it remain connected but future records won't be connected to it. When a segment is deleted, segment records that are already connected to a sequence won't be affected. 

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sequence Manager, or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## To delete or deactivate a segment 

1. In the Sales Hub app, go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.  
1. Under **Sales accelerator**, select **work assignment**.  
1. From the **Record type** list, choose a record type from the **Record type** list.  
    The **Work assignment** page opens with the list of available segments for the selected record type.  

    :::image type="content" source="media/sa-segment-edit-list-lead-segments.png" alt-text="Screenshot of segment page with a list of segments for the selected record type."::: 

4.	Hover over the segment, select **More options**, and then do one of the following:

    -	Select **Deactivate segment**, and in the confirmation message that appears, select **Deactivate**.

        >[!NOTE]
        >If there are any sequences attached to the segment, the names of the sequences are displayed in the message.

        The segment is deactivated in the application.

    -	Select **Delete**, and in the confirmation message that appears, select **Delete permanently**.

        >[!NOTE]
        >If there are any sequences attached to the segment, the names of the sequences are displayed in the message.

        The segment is removed permanently from the application.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)] 

### See also

[Create and activate a segment](wa-create-and-activate-a-segment.md)   
