---
title: Create and activate assignment rules for routing
description: Learn how to create and activate assignment rules for leads and opportunities, so that records that satisfy defined conditions in Dynamics 365 Sales are automatically assigned to sellers.
ms.date: 05/26/2023
ms.topic: article
author: udaykirang
ms.author: udag
---

# Create and activate assignment rules for routing

Create and activate assignment rules for leads and opportunities, so that records that satisfy defined conditions in Dynamics 365 Sales are automatically assigned to sellers.

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator or Sequence Manager<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Introduction

As a sequence manager, you create an assignment rule for lead and opportunity records by defining different conditions, such as the segment, sellers, and lead or opportunity distribution. After a rule is activated, any record that satisfies the conditions that are defined for the rule is automatically assigned to a seller. When records are created in Dynamics 365 Sales, you don't have to manually assign them to sellers.

> [!NOTE]
> A rule considers only the records that are created or updated after it's activated.

When a lead or opportunity record is created in an organization, assignment rules are applied in the order that they are listed in, starting from the top. If the record satisfies the conditions that are defined for a rule, that rule is applied to the record.

By default, rules are listed in the order that they were created in, and the most recently created rule is at the bottom of the list. However, you can drag the rules into any order that you want.

## Create and activate an assignment rule

> [!NOTE]
> This procedure provides an example that shows how to create a *lead* assignment rule. However, you use the same basic steps to create an *opportunity* assignment rule.

1. Sign in to your Dynamics 365 Sales Hub app.
1. In the lower-left corner of the page, go to **Change area**, and select **Sales Insights settings**.
1. Under **Sales accelerator**, select **Assignment rules**.
1. On the **Assignment rules** page, on the **Rule** tab, select **New rule** \> **Lead assignment rule**.

    > [!div class="mx-imgBorder"]
    > ![Screenhot that shows the Lead assignment rule command being selected on the New rule menu button.](media/sa-ar-create-assignment-rule-select-lead.png "Screenhot that shows the Lead assignment rule command being selected on the New rule menu button")

    The **Create assignment rule** dialog box opens.

1. Under **Rule name**, enter a name for the rule.
1. <a name="setSegment"></a>Under **Select eligible leads for this rule**, select one of the following options.

    > [!div class="mx-imgBorder"]
    > ![Screenshot that shows the options in the Select eligible leads for this rule section of the Create assignment rule dialog box.](media/sa-segment-assignment-rule-specific-lead.png "Screenshot that shows the options in the Select eligible leads for this rule section of the Create assignment rule dialog box")

    - **All incoming leads**: All new leads that are created will be assigned to sellers according to the conditions that are defined in this rule.
    - **Specific leads**: Select a segment in the **Choose segment** list. Leads that are available in the segment will be assigned to sellers according to the conditions that are defined in this rule. The list includes all the active segments that are related to leads. To create a segment that is specific to this rule, select **New segment**. [Learn more about how to create and activate a segment.](create-and-activate-a-segment.md)

        > [!NOTE]
        > If no segment is selected for a rule, or if no segment is defined in the application, you can select **None**.

        You can configure more settings to define how the leads in the segment are assigned to sellers. Select **Additional condition**, and then select **Add**. Use the following options to define conditions:

        - **Add row**: Add conditions that define when the segment should be applied. In the following example, the row specifies that the segment should be applied to leads that are created by the user John Thomas:

            1. In the first column, select an attribute in the list. (For example, select *Created by*.)
            1. In the second column, select an operator in the list. (For example, select *Equals*.)
            1. In the third column, enter a value to filter by. (For example, enter *John Thomas*.)

            > [!div class="mx-imgBorder"]
            > ![Screenshot that shows a condition row that filters for leads where the value of the Created By attribute equals John Thomas.](media/sa-segment-condition-add-row.png "Screenshot that shows a condition row that filters for leads where the value of the Created By attribute equals John Thomas")

            You can create more conditions to further filter the leads that the segment should be applied to.

        - **Add group**: Add multiple conditions as a group if you want to filter leads by using more than one field.

            1. In the list in the upper-left corner, select **And** or **Or** to group the conditions.

                If you select **And**, the segment is applied only to leads that meet all the conditions in the group. If you select **Or**, the segment is applied to leads that meet any condition in the group. For example, to apply the segment to leads that are created by Kenny Smith *and* that have the company name Contoso, select **And**.

                > [!div class="mx-imgBorder"]
                > ![Screenshot that shows a condition group being added.](media/sa-segment-condition-add-group.png "Screenshot that shows a condition group being added")

            1. Define the conditions to add to the group.

                > [!div class="mx-imgBorder"]
                > ![Screenshot that shows conditions added to the group.](media/sa-segment-condition-add-group-select-condition.png "Screenshot that shows conditions added to the group")

            You can create multiple groups and further filter the leads based on the conditions that are defined in the groups.

        - **Add related entity**: Add a condition that is based on the attributes of related entities.

            1. In the **Related Entity** list in the upper left, select an attribute. 
            1. In the list to the right, select either **Contains data** or **Does not contain data**.
            1. Define the condition.

            > [!div class="mx-imgBorder"]
            > ![Screenshot that shows a condition added for a related entity.](media/sa-segment-condition-add-related-entity.png "Screenshot that shows a condition added for a related entity")

    > [!NOTE]
    > You can have a maximum of 10 conditions in a rule. [Learn more about conditions in assignment rules.](#conditions-in-assignment-rules)

1. <a name="considerLeadsCreated"></a>To assign records that are created in the application during a specific timeframe to sellers, select the **Consider leads created in the last** checkbox, and then select a timeframe in the list.

    If no seller is available to take the record during the specified timeframe, the record is marked as overdue, and the status reason is *Seller not assigned as record is older than the set timeframe*. [Learn more about unassigned records and status reasons.](manage-unassigned-records.md#view-unassigned-records)

1. Under **Assign these leads to sellers or a team**, select one of the following options in the dropdown list.

    | Option | Description |
    |--------|-------------|
    | Any seller | Assign leads to any seller, based on their availability, capacity, or distribution pattern. |
    | Seller with matching attributes | <p>Assign leads to sellers who satisfy the conditions that are defined through attributes that are selected from Dynamics 365 or assignment rules. The following options are available:</p><ul><li>**Use existing fields from seller records in Dynamics 365**</li><li>**Use seller attributes defined for assignment rules** ([Learn how to define and manage seller attributes.](manage-seller-attributes.md))</li></ul><p>For example, you want to assign leads to sellers who are based in Seattle. Select the **Use existing fields from seller records in Dynamics 365** option, and then select **Add** \> **Add row**. Enter the condition as *City* (attribute) *Equals* (condition) *Seattle* (value).</p><p>![Screenshot of the example for assigning leads to sellers who have matching attributes.](media/sa-ar-seller-with-matching-attributes.png "Screenshot of the example for assigning leads to sellers who have matching attributes")</p><p>**Note**: You can have a maximum of five conditions at any time, and only one row can be defined under a related entity condition.</p><p>[Learn more about conditions in assignment rules.](#conditions-in-assignment-rules)</p> |
    | Specific sellers | <p>Assign leads to specific sellers. Select the sellers in the **Choose sellers** lookup.</p><p>**Note**: The security roles for the sellers in the list were added by defining team access. [Learn more about how to grant permissions to use assignment rules.](manage-sales-teams.md#grant-permissions-to-use-assignment-rules)</p><p>![Screenshow that shows specific sellers selected.](media/sa-ar-select-specific-sellers.png "Screenshow that shows specific sellers selected")</p> |
    | Specific teams | <p>Assign leads to a specific team. The lead is available for all members of the team that you select. The teams must be defined in your organization, and you must add them to security roles by defining team access. [Learn more about how to grant permissions to use assignment rules.](manage-sales-teams.md#grant-permissions-to-use-assignment-rules)</p><p>If you select this option, the **Distribute leads by** section isn't shown, because leads are assigned to teams. |


1. <a name="distributeLeadsBy"></a>Under **Distribute leads by**, select one of the following options. [Learn more about lead distributions in assignment rules.](understand-lead-distributions-assignment-rules.md)

    > [!NOTE]
    > This section is available only if you selected one of the seller options in the **Assign these leads to** section (**Any seller**, **Seller with matching attributes**, or **Specific sellers**). It isn't available for teams.

    - **Round robin**: Leads are distributed on a cyclical basis to sellers who are qualified to receive the lead based on the conditions of the assignment rule.
    - **Load balancing**: Leads are distributed among sellers based on their current workload. This option helps ensure that all sellers are equally busy.

1. (Optional) To consider the seller's work schedule when leads are assigned, select the **Assign if seller is available within** checkbox. Then, in the list, select the number of hours that a lead record that is created in the application can wait to be assigned to a seller or a team. You can select a maximum of 120 hours. [Learn more how to configure work availability.](personalize-sales-accelerator.md#configure-your-work-availability)

     To assign leads, the application first considers those sellers who are currently available to work on the lead records. If no seller is currently available (because of a day off or because the time is outside of working hours), the application considers sellers who will be available within the specified hours.

    If sellers don't update their [work availability](personalize-sales-accelerator.md#configure-your-work-availability), the application considers them always available and assigns leads to them.

    For example, if you select 10 hours, the application considers sellers who will be available within 10 hours for record assignment. If no seller is available within the 10-hour limit, the record isn't assigned and is marked as overdue. [Learn how to manage overdue records.](manage-unassigned-records.md)

    If you selected the [Consider leads created in the last](#considerLeadsCreated) checkbox in step 7, the rule first checks for the configured timeframe to assign the record. It then considers seller availability.

1. (Optional) To consider the maximum number of leads that a seller can handle at a time, select the **Assign leads based on seller capacity** checkbox. [Learn more about how to set lead capacity for sellers.](manage-sales-teams.md#set-capacity-for-sellers)

    > [!div class="mx-imgBorder"]
    > ![Screenshot that shows the Assign leads based on seller capacity checkbox selected in the Distribute leads by section.](media/sa-ar-distribute-leads-by.png "Screenshot that shows the Assign leads based on seller capacity checkbox selected in the Distribute leads by section")

1. Select **Create rule**.

The rule is created and activated. It's then listed in the **Rules** section, which is organized in ascending order by date. The most recently created rule is always listed at the bottom of the list unless you move it.

## Conditions in assignment rules

A condition limit is added to optimize the runtime experience and therefore ensure faster execution and improved efficiency. The condition limit is applicable to the following configurations:

- If you select the **Specific \<*entities*\>** option in the **Select eligible \<*entities*\> for this rule** section of the **Create assignment rule** dialog box, a maximum of 10 conditions are allowed. This number includes conditions in groups and related entities.
- If you select the **Sellers with matching attributes** option in the **Assign these \<*entities*\> to sellers or a team** section, a maximum of five conditions are allowed. This number includes conditions in groups and related entities.

If you exceed the limit, a message informs you that the limit has been reached and the rule can't be saved.

> [!NOTE]
> To increase the limit for conditions, contact Microsoft Support for help.

### Recommendations for adding conditions

- **Split condition between assignment rules and segments**: If you exceed the condition limit, move some conditions to segments to help improve the runtime efficiency of assignment rules. For example, if you have 15 conditions in the **Select eligible \<*entities*\> for this rule** section of an assignment rule, move five conditions to the associated segment. This approach helps streamline the conditions in the assignment rule and improve overall performance.
- **Create rollup attributes**: You might experience performance issues when you use conditions that involve related entities. By using rollup attributes, you can avoid adding conditions that involve related entities that have many-to-many relationships, one-to-many relationships, or nested related entities. [Learn more about how to define rollup columns that aggregate values.](/power-apps/maker/data-platform/define-rollup-fields)
- **Avoid duplicate conditions**: Avoid using attributes in conditions that are already used in the connected segment. For example, if you have a segment that has the condition *City* (attribute) *Equals* (condition) *Seattle* (value), avoid using the same *City* attribute in the assignment rule.
- **Use expression builder only**: Always use the expression builder in the user interface (UI) to define or update assignment rules. Don't update assignment rules through Dataverse. Otherwise, unexpected behavior can occur that affects the records that are related to the assignment rules. As a result, the records might remain unassigned.

[!INCLUDE[cant-find-option](../includes/cant-find-option.md)]

### See also

[Manage assignment rules](create-manage-assignment-rules.md)  
[Understand lead distributions in assignment rules](understand-lead-distributions-assignment-rules.md)

[!INCLUDE[footer-include](../includes/footer-banner.md)]
