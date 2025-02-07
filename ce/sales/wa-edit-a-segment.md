---
title: Copy and edit segments
description: Learn how to change the conditions that determine which records to include in a segment, its assignment rules, the sequences that are connected to it, and its priority and other properties in Dynamics 365 Sales.
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: how-to
ms.date: 08/11/2023
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/16/2023
---

# Copy and edit segments

After you've [created a segment](./wa-create-and-activate-a-segment.md) and used it for a while, you might find you need to tweak it to get better results. To edit a segment, you can either create a copy or make changes to the original directly. You can then view or modify the following characteristics of the segment: 

- Definition, or the conditions that determine which records to include: View and edit
- Assignment rules: Add, edit, delete, change priority, schedule, and run
- Attached sequences: View and disconnect
- Segmented records, or the records that have been added to the segment: View
- Name and description: View and edit
- Priority, which determines which segment "wins" if a record matches more than one: View and edit
- Whether previously segmented records are allowed to move to this one and be automatically connected to a sequence or assigned by a rule: View and edit

[!INCLUDE [sales-work-assignment](../includes/sales-work-assignment.md)]

## Copy a segment

1. Sign in to your Dynamics 365 Sales Hub app.
1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.
1. Under **Sales accelerator**, select **Work assignment**.
1. Select a **Record type** and then select a segment of that type.
1. Select **Create a copy**.
1. Enter a **Name** and then choose a priority for the copied segment. If the original segment has any assignment rules, you can choose to copy them to the new segment.
1. Select **Create**.

The segment is created and opened in the edit mode.  

## Edit a segment

1. Sign in to your Dynamics 365 Sales Hub app.
1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.
1. Under **Sales accelerator**, select **Work assignment**.
1. Select a **Record type** and then open a segment of that type.
1. Select **Edit**, and then confirm that you want to edit the segment.
1. Make the necessary changes in the following tabs:
    - **Segment definition**: [Create segments and connect them to sequences](./wa-create-and-activate-a-segment.md#create-and-activate-a-segment)
    - **Assignment rules**: [Automatically assign leads and opportunities](wa-create-and-activate-assignment-rule.md)
    - **Attached sequence**: [Connect segments to sequences](wa-connect-a-segment-to-sequence.md)
    - **Segmented *record type***: You can't change anything here, but you can view the records that have been added to the segment. It's a good way to confirm the segment is defined correctly.
1. To modify the segment's priority, assignment schedule, and other characteristics, select **Segment properties**.
    - **Priority**: The priority determines which segment new and updated records are assigned to when they meet the criteria for more than one. The segment with the highest priority takes precedence. If you change the segment's priority, the records that are already connected to it remain connected.
    - **Previously-segmented *record type***: To allow records from another segment to move to this one, turn on **Previously-segmented *record type***. This option moves records that match this segment's criteria here. Then, the records follow this segment's sequence. The assignment rules don't change, though. To apply the current assignment rule to the added records, select **Run assignment rules when a lead moves into this segment**.
    - **Run assignment rules for unassigned *record type***: [Run assignment rules](wa-manage-unassigned-records.md#run-assignment-rules)
1. Select **Save changes**.

Your changes are applied to records that are connected to the segment going forward. Any records that were previously connected to the segment aren't affected.

> [!NOTE]
> When you update the primary entity's attributes (such as lead or opportunity) that are added to conditions, all the segments related to that primary entity will run again.
 

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Related information

- [Create and activate a segment](create-and-activate-a-segment.md)

[!INCLUDE [footer-include](../includes/footer-banner.md)]
