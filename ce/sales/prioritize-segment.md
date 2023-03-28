---
title: Prioritize segments 
description: Learn how to prioritize segments to automatically group records in Dynamics 365 sales.
ms.date: 03/28/2023
author: udaykirang
ms.author: udag
manager: shujoshi
ms.topic: how-to
ms.custom: bap-template
---

# Prioritize segments

When a record is created or updated, it's connected to a matching segment based on the segment criteria. If the record matches multiple segments, it's connected to the segment with the highest priority. You can set the priority of a segment while creating it or after it's created by using the **Change priority** option. 

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sales Manager, or Sequence Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Set priority of a segment

When you change the priority of a segment, the records that are already connected to the segment remain connected. Only new or updated records are connected to the segment based on the set priority. To set the priority of a segment, follow these steps: 

1. Sign in to your Dynamics 365 Sales Hub app.
1. Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.
1. Under **Sales accelerator**, select **Segments** and then choose the type of record from **Record type**. 
1. Select the segment that you want to change the priority of, and then select **Change priority**. 
    
    > [!NOTE]
    > You can also prioritize inactive segments though the prioritization will not have effect on the assignment of records and only the active segments will be considered for assignment.  

    :::image type="content" source="media/segment-select-change-priority.png" alt-text="A screenshot of the segment page with the change priority option.":::

1. On the **Change priority** dialog box, enter the priority of the segment. 
1. Save the changes.

The priority of the segment is updated and it'll be used for connecting records in future.

### See also

[Manage segments](manage-segments.md)  
[Create and activate a segment](create-and-activate-a-segment.md)

