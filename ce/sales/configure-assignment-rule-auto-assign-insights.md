---
title: Configure assignment rules to automatically assign insights
description: Learn how to create assignment rules to assign insights to sellers, so that the insights that are displayed to the sellers are relevant to them.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 06/09/2023
ms.custom: bap-template 
---

# Configure assignment rules to automatically assign insights (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Create assignment rules to assign insights to sellers. In this way, you ensure that the insights that are displayed to the sellers are relevant to them. These rules also prevent every insight from being displayed to every seller.

For the **Seller insights** option to appear in assignment rules, the **Insights** record type and the **Insights** form must be added to the sales accelerator workspace. [Learn how to add a record type and form.](enable-configure-sales-accelerator.md#choose-content-and-layout)

> [!NOTE]
> To learn more about assignment rules, go to [Manage assignment rules for routing](create-manage-assignment-rules.md).

## License and role requirements

| Requirement type | You must have |
|------------------|---------------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise<br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator<br>More information: [Predefined security roles for Sales](security-roles-for-sales.md) |

## Configure an assignment rule

1. Sign in to your sales app.
1. In the lower-left corner of the page, go to **Change area** \> **Sales Insights settings**.
1. Under **Sales accelerator**, select **Assignment rules**.
1. On the **Assignment rules** page, in the **Select type** list, select **Insights (preview)**.
1. Select **\+ New rule**.
1. In the **Create assignment rule** dialog box, enter the following information:

    - Under **Rule name**, enter a name for the rule.
    - Under **Select eligible assign insights to a seller or a team for this rule**, in the **Choose segment** list, select a segment to group the insights.

        If a segment doesn't exist, select **\+ New segment** in the **Choose segment** list. When you create segments for insights, select **Insights** as the record type to help when you select the attributes that are related to the `msdyn_salessuggestion` entity. [Learn more about how to create segments.](create-and-activate-a-segment.md)

    - Under **Assign insights to a seller or a team**, select the ownership type and sellers to assign the insights to.

        | Ownership type | Description |
        |----------------|-------------|
        | Accounts team | <p>Assign insights based on existing account ownership. If a seller already has an established relationship with a specific account, it's beneficial to assign insights from that account to the same seller.</p><p>Select the attribute in the **Within accounts team, assign insights to** list, based on how you want to assign the insights.</p> |
        | Access team | <p>Assign insights based on individuals who have specific access and permissions to collaborate on customer accounts.</p><p>Access teams are used to facilitate teamwork, information sharing, and coordination among sellers.</p> |

        After you've selected the ownership, select **\+ Seller attributes** to add the primary and secondary owners for the rule. In this way, you define who the insights are assigned to.

        **Primary owner**:

        - The primary owner is identified by a star next to the name.
        - Each rule can have only one primary owner at a time. 
        - Insights are always displayed in the records that the primary owner is assigned to, and the primary owner can perform the following tasks:

            - View and accept the insights.
            - Decline the insights.
            - Assign the insights to secondary owners or other sellers.

        **Secondary owner**:

        - In the account team, secondary owners can view the insights but can't work on them until they are assigned by the primary owner.
        - You can add multiple secondary owners to the rule, or you can assign a security role as the secondary owner.

1. Select **Create rule**. The rule is created, and appropriate insights are displayed to the appropriate sellers or team.

## Examples

This section provides some example scenarios to help you understand the suggestion rules.

### Scenario 1: An account has a single owner or a team

Assign the Contoso insights for an account where potential revenue is between 0 (zero) and 30,000 US dollars (USD) to the account owner. A single owner is assigned to the relevant insights, and primary ownership will be given to the first identified seller.

Configure the rule as follows for this scenario:

- Under **Rule name**, enter *Contoso insight rule*.
- Create a segment to select eligible insights:

    1. Enter the name as *Contoso insights*, and provide a description.
    1. Select **\+ Add**, and enter the following conditions:

        - *Suggestion* – *Equals* – *Contoso*
        - *Potential revenue* – *Is less than or equal to* – *30,000*

    1. Select **Create segment**.

- Select an ownership type and owner to display insights. For a single user or a team, select **Owner** as the attribute type in the **Within accounts team, assign insights to** list.

> [!NOTE]
> - The account entity includes attributes that are related to users. Those attributes include custom attributes. You can select any attribute that references a single user or a team.
> - The assumption is that the **Owner** attribute is mapped to a single user or a team. In addition, because you're configuring the rule for a single user or a team, you don't have to include seller attributes.

### Scenario 2: Specific sellers should receive insights in a team

Assign the Contoso insights for an account that has potential revenue between 0 (zero) and 30,000 USD to the following members of a team: area manager (primary ownership), specialist (secondary ownership), and sales representative (secondary ownership).

Configure the rule as follows for this scenario:

- Under **Rule name**, enter *Contoso insight rule*.
- Create a segment to select eligible insights:

    1. Enter the name as *Contoso insights*, and provide a description.
    1. Select **\+ Add**, and enter the following conditions:

        - *Suggestion* – *Equals* – *Contoso*
        - *Potential revenue* – *Is less than or equal to* – *30,000*
        - *Account. segment* – *Equals* – *Enterprise account*

    1. Select **Create segment**.

- Select an ownership type and owner to display insights:

    1. In the **Within accounts team, assign insights to** list, select **Owning Team** as the attribute.

        > [!NOTE]
        > The assumption is that the **Owner Team** attribute is mapped to a team.

    1. To add the seller attributes, select **\+ Seller attributes**.
    1. Enter a name, add a row, and define it as *Title* – *Equals* – *Area manager*.
    1. Repeat the previous step, and add rows that are defined as follows:

        - *Title* – *Equals* – *Specialist*
        - *Title* – *Equals* – *Sales representative*

        Here, the area manager role can have multiple users in the team. One user is randomly selected as the primary owner to assign insights to. All other users in the same group are secondary owners. The specialist and sales representative roles can also have multiple users. They are all considered secondary owners.

### See also

[Enable seller insights](enable-seller-insights.md)  
[Manage assignment rules for routing](create-manage-assignment-rules.md)  
[Group records based on segments](manage-segments.md)
