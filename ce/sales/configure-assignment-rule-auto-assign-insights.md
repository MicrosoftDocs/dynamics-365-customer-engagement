---
title: Configure assignment rule to auto assign insights 
description: Create assignment rules to assign insights to sellers so that the insights displayed to the sellers are relevant for them.
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.collection: 
ms.date: 06/09/2023
ms.custom: bap-template 
---

# Configure assignment rule to auto assign insights (preview)

[!INCLUDE [cc-beta-prerelease-disclaimer](../includes/cc-beta-prerelease-disclaimer.md)]

Create assignment rules to assign insights to sellers so that the insights displayed to the sellers are relevant for them. These rules also prevent displaying all insights to every seller.

For the **Seller insights** option to appear in assignment rules, ensure that the **Insights** record type, and the **Insights** form is added to the sales accelerator workspace. More information: [Add record type and form](enable-configure-sales-accelerator.md#choose-content-and-layout).

> [!NOTE]
> To know more about assignment rules, see [Manage assignment rules for routing](create-manage-assignment-rules.md).

## License and role requirements

| Requirement type | You must have |  
|-----------------------|---------|
| **License** | Dynamics 365 Sales Premium or Dynamics 365 Sales Enterprise <br>More information: [Dynamics 365 Sales pricing](https://dynamics.microsoft.com/sales/pricing/) |
| **Security roles** | System Administrator <br>  More information: [Predefined security roles for Sales](security-roles-for-sales.md)|

## Configure assignment rule 

1.	Sign into your sales app. In the lower-left corner of the page, go to **Change area** > **Sales Insights settings**.
1.	Under **Sales accelerator**, select **Assignment rules**.
1.	In the **Assignment rules** page, from the **Select type** list, select **Insights (preview)**.
1.	Select **+ New rule**.  
    The **Create assignment rule pane** opens.  
1.	Enter the following information:  
    - Under **Rule name**, enter a name for the rule.
    - Under **Select eligible assign insights to a seller or a team for this rule**, select a segment from the **Choose segment** list to group the insights.  
        If a segment doesn’t exist, from the **Choose segment** list, select **+ New segment**. To know more about creating segments, see [Segment creation and activation in sales accelerator](create-and-activate-a-segment.md).  
        While creating segments for insights use the **Record type** as **Insights**. This helps in selecting the attributes related to the `msdyn_salessuggestion` entity. 
    - Under **Assign insights to a seller or a team**, choose the ownership type and sellers to assign the insights to.  
        
        | Ownership type | Description |
        |----------------|-------------|
        | Accounts team | Assign insights based on existing account ownership. If a seller already has an established relationship with a particular account, it’s beneficial to assign insights from that account to the same seller.<br>Choose the attribute from the **Within accounts team, assign insights to** list, based on how you want to assign the insights. |
        | Access team | Assign insights based on individuals who are granted specific access and permissions to collaborate on customer accounts.<br>Access teams are used to facilitate teamwork, information sharing, and coordination among sellers. |  
        
        After you’ve selected the ownership, select **Seller attributes** to add owners to the rules. This determines the primary and secondary owners for the rule, to whom the insights are assigned.  
        **Primary owner**:
        - Identified by the star icon corresponding to the name.
        - Each rule can have only one primary owner at a time. 
        - Always gets the insights displayed in the records they are assigned to and can do the following tasks:  
            - View and accept the insights.
            - Decline the insights.
            - Assign insights to secondary owners or other sellers.

        **Secondary owner**:  
        - In the account team, the secondary owners can view the insights but can’t work on them until they are assigned by the primary owner. 
        - You can add multiple secondary owners to the rule or assign a security role as the secondary owner.

1.	Select **Create rule**.  
    The rule is created, and appropriate insights are displayed to the respective sellers or team.

## Examples

To understand the suggestion rules, let’s look at some examples with scenarios.

### Scenario 1: Account has a single owner or a team

Assign the Contoso insights for an account where potential revenue is between 0 to 30,000 US Dollars to the account owner. A single owner will be assigned to the relevant insights, and primary ownership will be given to the first identified seller.

- **Rule name**: Contoso insight rule
- **Create a segment to select eligible insights**:
    1. Enter the name as **Contoso insights** and provide a description.
    1. Select **+ Add** and enter the following conditions:
        - Suggestion > Equals > Contoso 
        - Potential revenue > Is less than or equal to > 30,000
    1. Select **Create segment**.
- **Select ownership type and owner to display insights**:
    For a single user or a team, select the attribute type as **Owner** from the **Within accounts team, assign insights to** list.

> [!NOTE]
> -	The account entity includes attributes related to users, including custom attributes. You can choose any attribute that references a single user or a team.
> -	Assumption is that the **Owner** attribute is mapped to an individual user or a team. Also, we are configuring the rule for an individual or a team, so it’s not necessary to include **Seller attributes**. 

### Scenario 2: Specific sellers to receive insights in a team

Assign the Contoso insights for an account with potential revenue between 0 to 30,000 US Dollars to the following members in a team: Area manager (primary ownership), Specialist, and Sales representative (secondary ownership).

- **Rule name**: Contoso insight rule
- **Create a segment to select eligible insights**:
    
    1. Enter the name as **Contoso insights** and provide a description.
    1. Select **+ Add** and enter the following conditions:
        - Suggestion > Equals > Contoso 
        - Potential revenue > Is less than or equal to > 30,000
        - Account. segment > Equals > Enterprise account
    1. Select **Create segment**.

- **Select ownership type and owner to display insights**:

    1. Select the attribute as Owning Team from the Within accounts team, assign insights to list.  
        
        > [!NOTE]
        > Assumption is that the **Owner Team** attribute is mapped to a team.  
        
    1. To add the seller attributes, select **+ Seller attributes**.
    1. Enter a name and add row as Title > Equal > Area manager.
    1. Repeat the step 3 and add the rows as defined:
        - Title > Equal > Specialist
        - Title > Equal > Sales representative

        Here, the area manager role can have multiple users in the team where a user is picked randomly to assign insights as a primary owner, and other users in the same group will be secondary. Similarly, Specialist and Sales representative roles may have multiple users and they are all considered secondary.

### See also

[Enable seller insights](enable-seller-insights.md)  
[Manage assignment rules for routing](create-manage-assignment-rules.md)  
[Group records based on segments](manage-segments.md)
