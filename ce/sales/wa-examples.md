---
title: Example for assignment rules and segments
description: Learn how to create assignment rules and segments for a specific scenario with examples.  
author: udaykirang
ms.author: udag
ms.reviewer: shujoshi
ms.topic: how-to 
ms.date: 11/08/2023
ms.custom: bap-template
---

# Examples for assignment rules and segments

This section explains how to create assignment rules and segments for a specific scenario with examples. The following examples are explained in this section:

- [Assign lead to the account owner](#assign-lead-to-the-account-owner)
- [Assign lead to a seller who has required skill or relevant qualifications](#assign-lead-to-a-seller-who-has-required-skill-or-relevant-qualifications)
- [Assign a seller who lives in the same postal code as the lead](#assign-a-seller-who-lives-in-the-same-postal-code-as-the-lead)
- [Skip rules for self-created leads](#skip-rules-for-self-created-leads)
- [Assign leads generated from a campaign to product specific sales teams](#assign-leads-generated-from-a-campaign-to-product-specific-sales-teams)

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/), or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) |
| **Security roles** | [System Administrator, Sequence Manager, or Sales Manager](security-roles-for-sales.md) |

## Assign lead to the account owner

There are two ways to automate this assignment:

1. [Segment leads from accounts and create an assignment rule to owner](#segment-leads-from-accounts-and-create-an-assignment-rule-to-owner).
2. [Filter leads from existing account and assign the lead to account](#filter-leads-from-existing-account-and-assign-the-lead-to-account).

Let's look at each option in detail.

### Segment leads from accounts and create an assignment rule to owner

Segment all leads from existing accounts and then create an assignment rule to find the account owner.

1. Create the **Leads from existing accounts** segment, which takes in all leads with a parent account associated with them. More information: 

    :::image type="content" source="media/wa-example-segment-parent-account-lead-row-added.png" alt-text="Screenshot that shows a row added for parent account for lead.":::

2. Create an assignment rule to identify the owner of the account and assign the lead to account owner. While choosing sellers, add the condition through the related entity **Account (Owning User)** where the **Account** equals to **Lead.Parent Account for lead**.
 
    :::image type="content" source="media/wa-example-ar-assign-account-owner.png" alt-text="Screenshot that shows creating an assignment to assign to an account owner.":::

3. Save and activate the **Leads from existing accounts** segment.

    Any new lead that is from an existing account will automatically come into this segment and assignment rules configured to this segment will be executed.

### Filter leads from existing account and assign the lead to account

Create an assignment rules to filter leads from existing account and than assign the lead to an account.

1. Select the segment for which you want to assign leads to account owners. Here, we are using the default segment.

2. Create an assignment rule as follows:

    1. In **Eligible leads for this rule** section, select **Parent account for lead** > **Contains data**. This condition will consider leads with a parent account and ignores leads without account.  

        :::image type="content" source="media/wa-example-ar-eligible-leads-parent-account-contains.png" alt-text="Screenshot that shows adding a condition for parent account for leads that contains data.":::

    2. In the **Assign these leads to a seller, team, or queue** section, add the condition through the related entity **Account (Owning User)** where the **Account** equals to **Lead.Parent Account for lead**. This condition identifies the owner of the account and assign the lead to account owner.
    
        :::image type="content" source="media/wa-example-ar-assign-leads-account-lead-parent-account.png" alt-text="Screenshot that shows adding a condition for choosing the account owning user related entity with account equals to lead's parent account.":::

    By using this option, the assignment rule will be over-loaded and the execution will be delayed. We recommended to use the [Segment leads from accounts and create an assignment rule to owner](#segment-leads-from-accounts-and-create-an-assignment-rule-to-owner) option when you have a large number of leads for better performance where conditions are distributed between segment and assignment rules. 

## Assign lead to a seller who has required skill or relevant qualifications



## Assign a seller who lives in the same postal code as the lead



## Skip rules for self-created leads



## Assign leads generated from a campaign to product specific sales teams.



### See also

[Create and activate assignment rules](wa-create-and-activate-assignment-rule.md)  
[Create and activate segments](wa-create-and-activate-a-segment.md)  
