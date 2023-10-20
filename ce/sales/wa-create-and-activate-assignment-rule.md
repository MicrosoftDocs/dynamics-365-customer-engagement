---
title: Create and activate assignment rules
description: Learn how to create and use assignment rules in Dynamics 365 Sales to automatically route new leads, opportunities, and insights to the right sellers or sales teams.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
<<<<<<< HEAD
ms.topic: how-to
ms.date: 08/11/2023
ms.custom:
  - bap-template
  - ai-gen-docs-bap
  - ai-gen-desc
  - ai-seo-date:10/16/2023
=======
ms.topic: how-to 
ms.collection: 
ms.date: 10/19/2023
ms.custom: bap-template 
>>>>>>> c226aeec818d54ae9ce0c31c73bfffd29ac6920f
---

# Create and activate assignment rules

Assignment rules automatically route new leads and opportunities to the right sellers or sales teams. Create an assignment rule for lead, opportunity, and seller insights records by defining conditions, such as the segment, sellers, and distribution. After a rule is activated, any record that satisfies the conditions that are defined for the rule is automatically assigned to a seller. Sales managers spend less time and effort in manual assignment, leads and opportunities don't go overlooked, and assignments are balanced among your salespeople.

A rule considers only the records that are created or updated after it's activated. When a lead, opportunity, or seller insight record is created, assignment rules are applied in the order they're listed, starting from the top. If the record satisfies the conditions that are defined for a rule, that rule is applied to the record and no following rules are considered. By default, rules are listed in the order they were created, with the most recently created one at the bottom. However, you can [change the order of your assignment rules](./wa-edit-assignment-rule.md) at any time.

Watch this brief video to learn more about assignment rules in sales accelerator:

>[!VIDEO https://www.microsoft.com/en-us/videoplayer/embed/RE4VjOo]

[!INCLUDE [sales-work-assignment](../includes/sales-work-assignment.md)]

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
<<<<<<< HEAD
| **License** | [Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/), or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) |
| **Security roles** | [System Administrator, Sequence Manager, or Sales Manager](security-roles-for-sales.md) |
=======
| **License** | Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise, or [Microsoft Relationship Sales](https://dynamics.microsoft.com/sales/relationship-sales/) <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator, Sequence Manager, or Sales Manager <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Introduction

You create an assignment rule for lead, opportunity, and seller insights records by defining different conditions, such as the segment, sellers, and lead or opportunity distribution. After a rule is activated, any record that satisfies the conditions that are defined for the rule is automatically assigned to a seller. When records are created in Dynamics 365 Sales, you don't have to manually assign them to sellers.

> [!NOTE]
> A rule considers only the records that are created or updated after it's activated.

When a lead, opportunity, or seller insight record is created in an organization, assignment rules are applied in the order that they're listed in, starting from the top. If the record satisfies the conditions that are defined for a rule, that rule is applied to the record.

By default, rules are listed in the order that they were created in, and the most recently created rule is at the bottom of the list. However, you can drag the rules into any order that you want.
>>>>>>> c226aeec818d54ae9ce0c31c73bfffd29ac6920f

## Prerequisites

Before you start creating assignment rules, make sure you've [identified the security roles](wa-manage-sales-teams.md) that can be automatically assigned records.

## Create an assignment rule

1. Sign in to your Dynamics 365 Sales Hub app.

1. In the lower-left corner of the page, select **Change area** > **Sales Insights settings**.

1. Under **Sales accelerator**, select **Work assignment**.

1. Select a **Record type**, and then select **Add assignment rule**.

    :::image type="content" source="media/wa-new-assignment-rule-pane.png" alt-text="Screenshot of the Add assignment rule pane.":::

1. In section 1, **Rule name**, enter a meaningful **Name** for the rule.

1. In section 2, **Eligible *record type* for this rule**, select the segment the rule applies to.

    By default, the rule runs on all records of this type. If an appropriate segment doesn't exist, select **+ New segment** and create it.

### Add conditions to filter the records

You can add up to 10 conditions, including conditions in groups and related entities. If you need more, contact Microsoft Support.

1. Select **+ Add conditions**.

1. Select **+ Add**, and then use the following options to build the conditions of the rule:

    - **Add row**: Add a condition. Select an attribute, an operator, and a value; for example, *Created by* *Equals* *John Thomas*.

      :::image type="content" source="media/sa-segment-condition-add-row.png" alt-text="Screenshot that shows a condition row that filters for leads where the value of the Created By attribute equals John Thomas.":::

    - **Add group**: Add a group of conditions to filter records using multiple attributes that are combined by **And** or **Or**. If you select **And**, records must meet all the conditions in the group. If you select **Or**, records can meet any condition in the group.

    - **Add related entity**: Add a condition that's based on the attributes of related tables. Select an attribute in the **Related Entity** list, then select **Contains data** or **Does not contain data**, and then define the condition.

      :::image type="content" source="media/sa-segment-condition-add-related-entity.png" alt-text="Screenshot that shows a condition added for a related entity.":::

1. To impose a time limit on assigning a seller to the records the rule applies to, select **Consider leads created in the last**. Then, select the number of hours a record can remain unassigned after it's created.

    If no seller is available to take the record within that time, the record is marked overdue. [The status reason](wa-manage-unassigned-records.md#reason-for-unassigned-records) is set to *Seller not assigned as record is older than the set timeframe*.

### Select sellers or a sales team to assign

1. In section 3, **Assign these *record type* to sellers or a team**, select one of the following options in the list:

    - **Any seller**: Assign the records to any seller who is available and has the capacity.

    - **Sellers with matching attributes**: Assign the records to sellers who satisfy the conditions you set using either information about them in Dynamics 365 or [seller attributes that you define](wa-manage-seller-attributes.md) for assignment rules.

<<<<<<< HEAD
        For example, to assign the records to sellers who are based in Seattle, select **Use existing fields from seller records in Dynamics 365**, and then select **+ Add** \> **Add row**. Enter the condition as *City* (attribute) *Equals* (condition) *Seattle* (value).

        You can have up to five conditions. Only one row can be defined as a related entity condition. If you need more, contact Microsoft Support.

    - **Specific sellers**: Assign the records to the sellers you select. The sellers must have a [security role that grants them permissions](wa-manage-sales-teams.md) to be assigned by a rule.

    - **Specific teams**: Assign the records to the sales team you select. Any member of the team can pick up the records. The teams must be defined in your organization and have a [security role that grants them permissions](wa-manage-sales-teams.md) to be assigned by a rule.
=======
1. Under the **Assign these leads to sellers, team, or a queue** section, select one of the following options in the dropdown list.

    | Option | Description |
    |--------|-------------|
    | Any seller | Assign leads to any seller, based on their availability, capacity, or distribution pattern. |
    | Sellers with matching attributes | <p>Assign leads to sellers who satisfy the conditions that are defined through attributes that are selected from Dynamics 365 or assignment rules. The following options are available:</p><ul><li>**Use existing fields from seller records in Dynamics 365**</li><li>**Use seller attributes defined for assignment rules** ([Learn how to define and manage seller attributes.](wa-manage-seller-attributes.md))</li></ul><p>For example, you want to assign leads to sellers who are based in Seattle. Select the **Use existing fields from seller records in Dynamics 365** option, and then select **Add** \> **Add row**. Enter the condition as *City* (attribute) *Equals* (condition) *Seattle* (value).</p><p>![Screenshot of the example for assigning leads to sellers who have matching attributes.](media/sa-ar-seller-with-matching-attributes.png "Screenshot of the example for assigning leads to sellers who have matching attributes")</p><p>**Note**: You can have a maximum of five conditions at any time, and only one row can be defined under a related entity condition.</p><p>[Learn more about conditions in assignment rules.](#conditions-in-assignment-rules)</p> |
    | Specific sellers | <p>Assign leads to specific sellers. Select the sellers in the **Choose sellers** lookup.</p><p>**Note**: The security roles for the sellers in the list were added by defining team access. [Learn more about how to grant permissions to use assignment rules.](wa-manage-sales-teams.md)</p><p>![Screenshow that shows specific sellers selected.](media/sa-ar-select-specific-sellers.png "Screenshow that shows specific sellers selected")</p> |
    | Teams with matching attributes | Assign leads to teams that satisfy the conditions that are defined through the condition builder.<p>**Note**: You can have a maximum of five conditions at any time, and only one row can be defined under a related entity condition.</p><p>When you make this selection, the **Distribute leads by section** displays options to either assign them to any seller from the team or not assign them to any team at all.</p>|
    | Specific team| Assign leads to specific team. Select the teams in the **Choose a team** lookup.</p><p>The lead is available for all members of the team that you select. The teams must be defined in your organization, and you must add them to security roles by defining team access. [Learn more about how to grant permissions to use assignment rules.](wa-manage-sales-teams.md)</p><p>If you select this option, the **Distribute leads by** section isn't shown.</p> |
    | Queues with matching attributes |  Assign leads to queues that satisfy the conditions that are defined through the condition builder.<p>**Note**: You can have a maximum of five conditions at any time, and only one row can be defined under a related entity condition.</p><p>When you make this selection, the **Distribute leads by section** displays options to either assign them to any seller from the queue or not assign them to any queue at all.</p><p>The queue must be enabled and defined in your organization. [Learn more about how to enable queue for an entity.](/dynamics365/customer-service/enable-entities-for-queues#enable-a-table-for-queues-). |
    | Specific queue | Assign leads to specific queue. Select a queue from the **Choose queue** list. <p>**Note**: The list only displays queues that are marked as public. Also, the queue must be enabled and defined in your organization. [Learn more about how to enable queue for an entity.](/dynamics365/customer-service/enable-entities-for-queues#enable-a-table-for-queues-).</p><p>If you select this option, the **Distribute leads by** section isn't shown.</p> |

    **Dynamic attributes in condition builder**: When creating conditions in the condition builder, you can utilize dynamic attributes to minimize the number of conditions required for a specific attribute. For example, if you wish to assign leads from the United States to sellers from the same country, and likewise for India, Japan, and Brazil, you would need to create four separate conditions for this. However, by using dynamic attributes, you can consolidate this into a single condition as follows: **Country** > **Equals** > **Lead.Country**, where, if a lead's country matches the country of the seller, it will automatically be assigned to the corresponding seller from that country. For more information, see [Route leads with dynamic assignment rules](https://cloudblogs.microsoft.com/dynamics365/it/2021/08/26/route-leads-by-using-assignment-rules-to-dynamically-match-system-user-fields/)  

    
1. <a name="distributeLeadsBy"></a>Under **Distribute leads by**, select one of the following options. [Learn more about lead distributions in assignment rules.](understand-lead-distributions-assignment-rules.md)

    > [!NOTE]
    > This section is available only if you selected one of the seller options in the **Assign these leads to** section (**Any seller**, **Seller with matching attributes**, or **Specific sellers**). It isn't available for options **Teams** and **Queues**, and the records are assigned randomly or will be unassigned.
>>>>>>> c226aeec818d54ae9ce0c31c73bfffd29ac6920f

### Select how records should be distributed

If you assign the records to a sales team, this section isn't shown because the rule doesn't distribute them to individual sellers. Instead, the team members effectively distribute the records among themselves.

<<<<<<< HEAD
1. In section 4, **Distribute *record type* by**, select how the rule should distribute the records to your sellers. [Learn more about lead distribution in assignment rules](understand-lead-distributions-assignment-rules.md).

    - **Round robin**: The records are distributed evenly in turn to sellers who are qualified to receive them based on the conditions of the assignment rule.
    - **Load balancing**: Leads are distributed to sellers based on their workload, so that all sellers are equally busy.

1. (Optional) To consider the [seller's work schedule](personalize-sales-accelerator.md#configure-your-work-availability) when records are assigned, select **Assign if seller is available within**. Then, select the number of hours that a record can wait to be assigned, up to 120 hours.

    - If you [set a time limit](#add-conditions-to-filter-the-records) on how long records can remain unassigned, the rule first checks to make sure the record is still within that time. Then it considers seller availability.
=======
        To assign leads, the application first considers those sellers who are currently available to work on the lead records. If no seller is currently available (because of a day off or because the time is outside of working hours), the application considers sellers who will be available within the specified hours.

        If sellers don't update their [work availability](personalize-sales-accelerator.md#configure-your-work-availability), the application considers them always available and assigns leads to them.

        For example, if you select 10 hours, the application considers sellers who will be available within 10 hours for record assignment. If no seller is available within the 10-hour limit, the record isn't assigned and is marked as overdue. [Learn how to manage overdue records.](wa-manage-unassigned-records.md)

        If you selected the [Consider leads created in the last](#considerLeadsCreated) checkbox in step 7, the rule first checks for the configured timeframe to assign the record. It then considers seller availability.
>>>>>>> c226aeec818d54ae9ce0c31c73bfffd29ac6920f

    - The rule first considers sellers who are available to work on the records. If sellers don't set their [work availability](personalize-sales-accelerator.md#configure-your-work-availability), the rule considers them always available.

<<<<<<< HEAD
    - If no seller is available&mdash;perhaps because of a day off or the time is outside working hours&mdash;the rule considers sellers who will be available within the number of hours you selected in step 2.

    - If no seller is available within that time, the record is [left unassigned and marked overdue](wa-manage-unassigned-records.md).
=======
1. Select **Save**.
>>>>>>> c226aeec818d54ae9ce0c31c73bfffd29ac6920f

1. (Optional) To consider the [maximum number of records that a seller can handle](wa-work-assignment-manage-settings.md#set-capacity-for-sellers) at a time, select **Assign leads based on seller capacity**.

1. Select **Save** to create and activate the rule.

Assignment rules run in the order they're listed. By default, they're listed in ascending order by creation date, with the newest rule at the bottom.

### Recommendations for adding conditions to assignment rules

We limit the number of conditions you can add to your assignment rules to help the rules run faster and more efficiently. Here are some suggestions for when you need more conditions than the limit allows.

- **Split conditions between assignment rules and segments.** Move some conditions to the segment. For example, if you have 15 conditions in the **Eligible *record type* for this rule** section, move five of them to the associated segment.

- **Create rollup attributes**: Use rollup attributes to avoid performance issues when you add conditions that involve related tables. Rollup attributes are calculated fields that aggregate values from related records. For example, you can create a rollup attribute that counts the number of contacts that are associated with a lead. [Learn how to define rollup attributes](/power-apps/maker/data-platform/define-rollup-fields).

- **Avoid duplicate conditions.** Don't include attributes that are already included in the segment. For example, if you have a segment that has the condition *City* (attribute) *Equals* (condition) *Seattle* (value), avoid using the same *City* attribute in the assignment rule.

- **Use the expression builder only**: Always use the expression builder to define or update the rules. Don't update them through Dataverse, the underlying data platform of Dynamics 365. It might cause unexpected behavior that affects the records that are related to the assignment rules.

[!INCLUDE [cant-find-option](../includes/cant-find-option.md)]

### See also

- [Understand record distribution in assignment rules](understand-lead-distributions-assignment-rules.md)
- [View and assign unassigned records](wa-manage-unassigned-records.md)
- [Select security roles to assign records to](wa-manage-sales-teams.md)
- [Set seller attributes and capacity](wa-manage-seller-attributes.md)
