---
title: Prioritize segments 
description: Learn how to prioritize segments to automatically group records in Dynamics 365 Sales.
ms.date: 03/28/2023
author: udaykirang
ms.author: udag
ms.topic: how-to
ms.custom: bap-template
---

# Prioritize segments

When a record is created or updated, it's connected to a matching segment based on the segment criteria. If the record matches multiple segments, it's connected to the segment that has the highest priority. You can set the priority of a segment when you create that segment, or you can set it later by using the **Change Priority** option. 

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sales Manager, or Sequence Manager<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Set the priority of a segment

When you change the priority of a segment, the records that are already connected to that segment remain connected. Only new or updated records are connected to the segment based on the new priority. To set the priority of a segment, follow these steps: 

1. Sign in to your Dynamics 365 Sales Hub app.
1. Go to **Change area** in the lower-left corner of the page, and select **Sales Insights settings**.
1. Under **Sales accelerator**, select **Segments**.
1. In the **Record type** list, select the type of record. 
1. Select the segment that you want to change the priority of, and then select **Change Priority**. 

    > [!NOTE]
    > If you change the priority of an inactive segment, there will be no effect on the assignment of records. Only active segments are considered for assignment.

    :::image type="content" source="media/segment-select-change-priority.png" alt-text="Screenshot that shows the Change Priority button being selected for a selected segment on the Segments page.":::

1. In the **Change priority** dialog box, enter the priority of the segment. 
1. Save your changes.

The priority of the segment is updated and will now be used to connect records.

### See also

[Manage segments](manage-segments.md)  
[Create and activate a segment](create-and-activate-a-segment.md)
