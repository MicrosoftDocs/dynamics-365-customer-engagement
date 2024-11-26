---
title: Create segments and connect them to sequences
description: Learn how to use work assignment in Dynamics 365 Sales to group records based on conditions, and then connect these segments to sequences of automated actions.
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: how-to
ms.collection:
ms.date: 09/20/2024
ms.custom:
- bap-template
- ai-gen-docs-bap
- ai-gen-desc
- ai-seo-date:10/12/2023
---

# Create segments and connect them to sequences

Work assignment is a feature of Dynamics 365 Sales that helps you automate your sales team's activities. You can use work assignment to create segments of records based on conditions and connect them to sequences that perform actions on those records.

A *segment* is a group of records that meet criteria that you define. For example, you can create a segment of leads that come from a certain source, such as your website or trade shows. A *sequence* is a set of actions that are performed automatically on the records in a segment, such as sending emails, making calls, or creating tasks. For example, you can create a sequence that sends a welcome email to new leads and then schedules a follow-up call.

In this article, you'll learn how to create and activate segments in work assignment and connect them to sequences.

[!INCLUDE [sales-work-assignment](../includes/sales-work-assignment.md)]

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/) or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) |
| **Security roles** | [System Administrator, Sequence Manager, or Sales Manager](security-roles-for-sales.md) |

## Create and activate a segment

You can assign only active records to segments. For example, when a lead is qualified, it becomes a read-only record and creates an opportunity record. Since the lead is no longer active, it can't be connected to a segment.

Your organization can have up to 250 active segments at one time. A segment can have any number of assignment rules, but only 10 rules can be active at one time. If you need more, contact Microsoft Support.

1. Sign in to your Sales Hub app.  
1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.  
1. Under **Sales accelerator**, select **Work assignment**.  
1. Select a **Record type**.  
    The lead and opportunity record types are available by default. The list also includes other record types that are selected in the [sales accelerator configuration](enable-configure-sales-accelerator.md#choose-content-and-layout).

1. Select **+ New segment**.  
1. Enter a **Name** and, optionally, a **Description** of the segment.  
1. Enter the segment's **Priority**.  
    The priority determines which segment records are assigned to when they meet the criteria for more than one. The segment with the highest priority takes precedence. By default, the priority is initially set to the priority of the last segment that was created. The default, out-of-the-box segment always has the lowest priority.  
    Set a priority for every segment. You can change the priority of a segment at any time.

1. Select **Next** to open the segment condition builder page.  

    :::image type="content" source="media/wa-segment-condition-builder-home-page.png" alt-text="Screenshot of the segment condition builder page.":::

    On this page, define the conditions that are used to evaluate records for assignment to the segment. You can add up to 10 conditions in a segment, including conditions that are based on groups and related entities. If you need more, contact Microsoft Support. [Read our recommendations for adding conditions](#recommendations-for-adding-conditions).

1. Select **Add**, and then use the following options to build the conditions of the segment:  
    - **Add row**: Add a condition. Select an attribute, an operator, and a value; for example, *Created by* *Equals* *John Thomas*.

      :::image type="content" source="media/sa-segment-condition-add-row.png" alt-text="Screenshot that shows a condition row that filters for leads where the value of the Created By attribute equals John Thomas.":::

        Add more conditions as needed, for a total of 10, to further filter the records that should be assigned to the segment.

    - **Add group**: Add a group of conditions to filter records using multiple attributes that are combined by **And** or **Or**. If you select **And**, leads must meet all the conditions in the group. If you select **Or**, leads can meet any condition in the group.  
    - **Add related entity**: Add a condition that's based on the attributes of related tables. Select an attribute in the **Related Entity** list, then select **Contains data** or **Does not contain data**, and then define the condition.  

      :::image type="content" source="media/sa-segment-condition-add-related-entity.png" alt-text="Screenshot that shows a condition added for a related entity.":::

1. (Optional) When you've finished defining the conditions, select **Simulate results** to view a list of records that satisfy the conditions.  
    These results are simulated. They might not reflect the actual records that the segment can be applied to.  
1. Select **Save**, and then select **Activate**.

> [!NOTE]
> All segments that are related to a primary entity (such as lead or opportunity) run every time you update the attributes of the primary entity that are added to the conditions.

## Recommendations for adding conditions

A segment can have up to 10 conditions at one time. To optimize the performance and efficiency of segments, follow these recommendations when you add conditions:

- **Distribute the segments**: Create multiple segments with fewer conditions rather than one segment with many conditions. You can connect multiple segments to the same or different sequences and assignment rules. This helps improve the speed and accuracy of connecting sequences and assignment rules to records.

- **Create rollup attributes**: Use rollup attributes to avoid performance issues when you add conditions that involve related tables. Rollup attributes are calculated fields that aggregate values from related records. For example, you can create a rollup attribute that counts the number of contacts that are associated with a lead. [Learn how to define rollup attributes](/power-apps/maker/data-platform/define-rollup-fields).

- **Use the expression builder only**: Always use the expression builder to define or update the segments. Don't update segments through Dataverse, the underlying data platform of Dynamics 365. It might cause unexpected behavior that affects the records that are related to the segment and the subsequent automations, such as connecting sequences and assignment rules.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

## Next steps

- [Connect segments to sequences](wa-connect-a-segment-to-sequence.md).
- [Create and activate assignment rules](wa-create-and-activate-assignment-rule.md).

## Related information

- [Edit segments](wa-edit-a-segment.md)
