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
- [Assign lead to sellers with relevant skills or qualifications](#assign-lead-to-sellers-with-relevant-skills-or-qualifications)
- [Assign a seller who lives in the same postal code as the lead](#assign-a-seller-who-lives-in-the-same-postal-code-as-the-lead)
- [Skip rules for self-created leads](#skip-rules-for-self-created-leads)
- [Assign leads generated from a campaign to product specific sales teams](#assign-leads-generated-from-a-campaign-to-product-specific-sales-teams)

## License and role requirements

| Requirement type | You must have |
|-----------------------|---------|
| **License** | [Dynamics 365 Sales Premium, Dynamics 365 Sales Enterprise](https://dynamics.microsoft.com/sales/pricing/), or [Microsoft Relationship Sales](https://dynamics.microsoft.com/en-in/sales/relationship-sales/) |
| **Security roles** | [System Administrator, Sequence Manager, or Sales Manager](security-roles-for-sales.md) |

## Assign lead to the account owner

There are two ways to automate:

1. [Segment leads from accounts and create an assignment rule to owner](#segment-leads-from-accounts-and-create-an-assignment-rule-to-owner).
1. [Filter leads from existing account and assign the lead to account](#filter-leads-from-existing-account-and-assign-the-lead-to-account).

Let's look at each option in detail.

### Segment leads from accounts and create an assignment rule to owner

Segment all leads from existing accounts and then create an assignment rule to find the account owner.

1. Create the **Segment leads from existing accounts** segment, which takes in all leads with a parent account associated with them. More information: 

    :::image type="content" source="media/wa-example-segment-parent-account-lead-row-added.png" alt-text="Screenshot that shows a row added for parent account for lead.":::

1. Create an assignment rule to identify the owner of the account and assign the lead to account owner. While choosing sellers, add the condition through the related entity **Account (Owning User)** where the **Account** equals to **Lead.Parent Account for lead**.
 
    :::image type="content" source="media/wa-example-ar-assign-account-owner.png" alt-text="Screenshot that shows creating an assignment to assign to an account owner.":::

1. Save and activate the **Segment leads from existing accounts** segment.

    Any new lead that is from an existing account automatically comes into this segment and assignment rules configured to this segment will be executed.

### Filter leads from existing account and assign the lead to account

Create an assignment rule to filter leads from existing account and then assign the lead to an account.

1. Select the segment for which you want to assign leads to account owners. Here, we're using the default segment.

1. Create an assignment rule as follows:

    1. In **Eligible leads for this rule** section, select **Parent account for lead** > **Contains data**. This condition considers leads with a parent account and ignores leads without account.  

        :::image type="content" source="media/wa-example-ar-eligible-leads-parent-account-contains.png" alt-text="Screenshot that shows adding a condition for parent account for leads that contains data.":::

    1. In the **Assign these leads to a seller, team, or queue** section, add the condition through the related entity **Account (Owning User)** where the **Account** equals to **Lead.Parent Account for lead**. This condition identifies the owner of the account and assigns the lead to account owner.
    
        :::image type="content" source="media/wa-example-ar-assign-leads-account-lead-parent-account.png" alt-text="Screenshot that shows adding a condition for choosing the account owning user related entity with account equals to lead's parent account.":::

> [!NOTE]
> We recommended to use the [Segment leads from accounts and create an assignment rule to owner](#segment-leads-from-accounts-and-create-an-assignment-rule-to-owner) option when dealing with a large number of leads. This approach can enhance performance, especially when conditions are distributed between segments and assignment rules.

## Assign lead to sellers with relevant skills or qualifications

Let's consider that you're a sales manager from a financial institution, responsible for selling insurance plans, credit cards, and other financial products to customers. When leads come in for insurance policy, you want to automatically assign the leads to qualified sellers who possess a minimum of an **Insurance Level 1 certification** and hold a **Diploma or degree in finance**. 

> [!NOTE]
> Here we are considering the default segment while creating the assignment rule.

1. Create seller attributes for **Insurance Level 1 certification** and **Diploma or degree in finance**. Here we've created **Insurance Certificate** and **Academic qualification**, and added values as per the business requirement. More information: [Set seller attributes and capacity](wa-manage-seller-attributes.md)

1. Apply the created attributes to the respective sellers. More information: [Assign attributes and capacity to sellers](wa-manage-seller-attributes.md#assign-attributes-and-capacity-to-sellers)

1. Create an assignment rule to assign leads related to insurance to sellers with the required certificate and qualification.
    
    1. In the **Eligible leads for this rule** section, create a condition where **Lead category** equals to **Insurance** to filter leads with insurance.

        :::image type="content" source="media/wa-example-ar-assign-leads-account-rsq.png" alt-text="Screenshot that shows adding a condition with lead category equals to insurance.":::

    1. In the **Assign these leads to a seller, team, or queue** section, select **Sellers with matching criteria** from the dropdown list and then select the **Use seller attributes defined for assignment rules** option.
    
    1. Create the following conditions as per the business rule: 
        - **Insurance Certificate** > **Equals** > **Level 1**, **Level 2**, and **Level 3**. 
            >[!NOTE]
            >If the other certificate levels are more than **Level 1**, you can include those levels as the **Level 1** insurance certificate is a minimum requirement.  
        - **Academic qualification** > **Equals** > **Diploma - Finance**, **Graduate - Finance**, and **PG - Finance**.

        :::image type="content" source="media/wa-example-ar-assign-leads-account-rsq-select-attributes.png" alt-text="Screenshot that shows adding a condition for insurance and academic qualification.":::

    Any new lead that is related to insurance automatically comes into this assignment rule. 

## Assign a seller who lives in the same postal code as the lead

You want to route leads to sellers who share the same postal code. Here, we use the dynamic matching criteria to assign leads to sellers who live in the same postal code as the lead. For example, if your organization is serving 150 regions, and creating assignment rule for each region is difficult to manage. With dynamic matching criteria, you can create a single rule to assign leads to sellers who live in the same postal code as the lead though the value *Lead.Country* (the **Country** value is defined in [global option set](/powerapps/maker/data-platform/custom-picklists) for both lead and [system user](/power-apps/developer/data-platform/webapi/reference/systemuser?view=dataverse-latest&viewFallbackFrom=dynamics-ce-odata-9) entities).

> [!NOTE]
> Here we are considering the default segment while creating the assignment rule.

1. Create the assignment rule and in the **Assign these leads to a seller, team, or queue** section, configure the section as described:

    - Select **Sellers with matching criteria** from the dropdown list.  
    - Select the **Use seller attributes defined for assignment rules** option.  
    - Add the condition through the add row option, **ZIP/Postal Code** > **Equals** > **$(address_1_postalcode)**.  
        Here, we're using the string type field (a single line of text) and is the logical name on the selected attribute. The **ZIP/Postal Code** attribute is a system user field that needs to match with the lead field called **address_1_postalcode**, which is the logical name for the field **ZIP/Postal Code** in lead entity. 

    :::image type="content" source="media/wa-example-ar-assign-leads-same-postalcode.png" alt-text="Screenshot that shows adding a condition for postal code.":::

## Skip rules for self-created leads

In your organization, leads come from different sources, such as marketing campaigns, visitors from website, partners, and your sales people. The Work assignment feature automatically distribute leads to eligible sellers based on the rules that includes leads that were created by sellers. Most often, the leads created by your sellers are routed to another seller based on the assignment rules. However, if you prefer the leads to be assigned to the sellers who actually generate them, you can implement rules to filter out leads created by other sellers. You can achieve this through the following process.

1. Customize lead form to add a field to route to another seller.  
    Create and add a custom field to the lead from to indicate whether the lead should be routed to another seller. For example, you can add a field called **Route to another seller** with values **Yes** or **No**.
    
    :::image type="content" source="media/wa-example-ar-skip-rules-custom-field-leads-form.png" alt-text="Screenshot that shows adding the custom field added to lead form.":::
    
    Set the value for the field to **No** for leads that shouldn't be routed to another seller.

1. Categorize all leads containing the custom file to route to another seller as **No** into the **Do not route leads** segment.  
    Create the **Do not route leads** segment and then define the condition as **Route to another seller** > **Equals** > **No**. This condition filters out leads that shouldn't be routed to another seller.
    
    :::image type="content" source="media/wa-example-segment-filter-leads-routing-no.png" alt-text="Screenshot that shows adding the condition to segment leads that aren't routed to another sellers.":::

    New or updated leads fall into their respective segments.

1. Set highest priority to the segment with no assignment rules.  
    If a lead satisfies conditions for multiple segments, then the segment with highest priority takes precedence. To ensure that leads remain with the seller who created the lead, set highest priority the **Do not route leads** segment.   

    :::image type="content" source="media/wa-example-segment-set-highest-priority.png" alt-text="Screenshot that shows setting highest priority to the Do not route leads segment.":::

## Assign leads generated from a campaign to product specific sales teams.



### See also

[Create and activate assignment rules](wa-create-and-activate-assignment-rule.md)  
[Create and activate segments](wa-create-and-activate-a-segment.md)  
[Set seller attributes and capacity](wa-manage-seller-attributes.md)