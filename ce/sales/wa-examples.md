---
title: Example for assignment rules and segments
description: Learn how to create assignment rules and segments for different scenarios through examples.  
author: udaykirang
ms.author: udag
ms.reviewer: udag
ms.topic: how-to
ms.date: 09/20/2024
---

# Examples for assignment rules and segments

In this section, we've used a few examples to explain how to create assignment rules and segments for different scenarios. 

## Assign a lead to the account owner

There are two ways to automate:

1. [Create a segment for leads with accounts and assign them to account owner](#create-a-segment-for-leads-with-accounts-and-assign-them-to-account-owner).
1. [Use assignment rules to filter leads with accounts and assign them to account owner](#use-assignment-rules-to-filter-leads-with-accounts-and-assign-them-to-account-owner).

Let's look at each option in detail.

### Create a segment for leads with accounts and assign them to account owner

In this approach, we'll filter the leads with accounts using segment and then assign these leads to the respective account owner using assignment rules. We recommend that you use this option when you're dealing with a large number of leads. It can enhance performance as conditions are distributed between segments and assignment rules.

1. Create the **Segment leads from existing accounts** segment, which only takes in leads with an associated parent account.  

    :::image type="content" source="media/wa-example-segment-parent-account-lead-row-added.png" alt-text="Screenshot that shows a row added for parent account for lead.":::

1. In the **Assignment rules** tab of the segment, create an assignment rule to identify the owner of the account and assign the lead to account owner. While choosing sellers, add the condition through the related entity **Account (Owning User)** where the **Account** equals to **Lead.Parent Account for lead**.

    :::image type="content" source="media/wa-example-ar-assign-account-owner.png" alt-text="Screenshot that shows creating an assignment to assign to an account owner.":::

1. Save and activate the **Segment leads from existing accounts** segment.

    All new leads from existing accounts automatically come into this segment and are assigned based on the configured assignment rule for this segment.

### Use assignment rules to filter leads with accounts and assign them to account owner

In this approach, we'll use the assignment rules for both filtering the leads with accounts and assigning them to account owners. 

1. Select the segment for which you want to assign leads to account owners. Here, we're using the default segment.

1. Create an assignment rule as follows:

    1. In the **Eligible leads for this rule** section, select **Parent account for lead** > **Contains data**. This condition considers leads with a parent account and ignores leads without account.  

        :::image type="content" source="media/wa-example-ar-eligible-leads-parent-account-contains.png" alt-text="Screenshot that shows adding a condition for parent account for leads that contains data.":::

    1. In the **Assign these leads to a seller, team, or queue** section, add the condition through the related entity **Account (Owning User)** where the **Account** equals to **Lead.Parent Account for lead**. This condition identifies the owner of the account and assigns the lead to account owner.

        :::image type="content" source="media/wa-example-ar-assign-leads-account-lead-parent-account.png" alt-text="Screenshot that shows adding a condition for choosing the account owning user related entity with account equals to lead's parent account.":::

## Assign a lead to sellers with relevant skills or qualifications

Let's consider that you're a sales manager from a financial institution, responsible for selling insurance plans, credit cards, and other financial products to customers. When leads come in for insurance policy, you want to automatically assign the leads to qualified sellers who possess a minimum of an **Insurance Level 1 certification** and hold a **Diploma or degree in finance**. 

> [!NOTE]
> Here we are considering the default segment while creating the assignment rule.

1. Create seller attributes for **Insurance Level 1 certification** and **Diploma or degree in finance**. Here we've created **Insurance Certificate** and **Academic qualification**, and added values as per the business requirement. More information: [Set seller attributes and capacity](wa-manage-seller-attributes.md)

1. Apply the created attributes to the respective sellers. More information: [Assign attributes and capacity to sellers](wa-manage-seller-attributes.md#assign-attributes-and-capacity-to-sellers)

1. Create an assignment rule to assign leads related to insurance to sellers with the required certificate and qualification.

    1. In the **Eligible leads for this rule** section, create a condition where **Lead category** equals to **Insurance** to filter leads with insurance. Here, we've customized the lead entity by adding **Insurance** as a category. 

        :::image type="content" source="media/wa-example-ar-assign-leads-account-rsq.png" alt-text="Screenshot that shows adding a condition with lead category equals to insurance.":::

    1. In the **Assign these leads to a seller, team, or queue** section, select **Sellers with matching criteria** from the dropdown list and then select the **Use seller attributes defined for assignment rules** option.

    1. Create the following conditions as per the business rule: 
        - **Insurance Certificate** > **Equals** > **Level 1**, **Level 2**, and **Level 3**. 
            >[!NOTE]
            >If the other certificate levels are more than **Level 1**, you can include those levels as the **Level 1** insurance certificate is a minimum requirement.  
        - **Academic qualification** > **Equals** > **Diploma - Finance**, **Graduate - Finance**, and **PG - Finance**.

        :::image type="content" source="media/wa-example-ar-assign-leads-account-rsq-select-attributes.png" alt-text="Screenshot that shows adding a condition for insurance and academic qualification.":::

    Any new lead that is related to insurance automatically comes into this assignment rule. 

## Assign a lead to the seller with matching business unit and lives in the same postal code  

You want to route leads to sellers who share the same postal code and match the business unit. If you have a large number of regions, creating assignment rules for each region is difficult to manage. By using the dynamic matching criteria, you can create a single rule to assign leads to sellers who live in the same postal code as the lead and matches business unit.  

> [!NOTE]
> Here we are considering the default segment while creating the assignment rule.

1. Create the assignment rule and in the **Assign these leads to a seller, team, or queue** section, configure the section as described:

    - Select **Sellers with matching criteria** from the dropdown list.  
    - Select the **Use seller attributes defined for assignment rules** option.  
    - Add the following conditions:
        - **ZIP/Postal Code** > **Equals** > **$(address_1_postalcode)**.  
            The **ZIP/Postal Code** field is a system user field that needs to match with the **ZIP/Postal Code** in lead entity. As the **ZIP/Postal Code** field is of type string (a single line of text), use the logical name of the **ZIP/Postal Code** field (**address_1_postalcode**) from the lead entity to match [system users](/power-apps/developer/data-platform/webapi/reference/systemuser?view=dataverse-latest&viewFallbackFrom=dynamics-ce-odata-9). The syntax to add a string value is **$(_Logical name of the field_)**.  

        - **Business Unit** > **Equals** > **Leads.Owning Business Unit**.  
            The **Business unit** field is an [option set](/powerapps/maker/data-platform/custom-picklists) that is available in both lead and system user. Select the **Leads.Owning Business Unit** value from the dropdown list. 

    :::image type="content" source="media/wa-example-ar-assign-leads-same-postalcode.png" alt-text="Screenshot that shows adding a condition for postal code.":::

    The created single rule automatically route every lead to the right seller in the right region.

## Skip rules for self-created leads

In your organization, leads come from various sources, such as marketing campaigns, visitors from website, partners, and your sales people. The Work assignment feature automatically distribute leads to eligible sellers based on the rules that include leads that were created by sellers. Most often, the leads created by your sellers are routed to another seller based on the assignment rules. However, if you prefer the leads to be assigned to the sellers who actually generate them, you can implement rules to filter out leads created by other sellers. You can achieve this through the following process.

1. Customize the lead form to add a field to route to another seller.  
    Create and add a custom field to the lead form to indicate whether the lead should be routed to another seller. For example, you can add a field called **Route to another seller** with values **Yes** or **No**.

    :::image type="content" source="media/wa-example-ar-skip-rules-custom-field-leads-form.png" alt-text="Screenshot that shows adding the custom field added to lead form.":::

    Set the value for the field to **No** for leads that shouldn't be routed to another seller.

1. Categorize all leads containing the custom field to route to another seller as **No** into the **Do not route leads** segment.  
    Create a segment called **Do not route leads** and then define the condition as **Route to another seller** > **Equals** > **No**. This condition filters out leads that shouldn't be routed to another seller.

    :::image type="content" source="media/wa-example-segment-filter-leads-routing-no.png" alt-text="Screenshot that shows adding the condition to segment leads that aren't routed to another sellers.":::

    New or updated leads fall into their respective segments.

1. Set highest priority to the segment with no assignment rules.  
    If a lead satisfies conditions for multiple segments, then the segment with highest priority takes precedence. To ensure that leads remain with the seller who created the lead, set highest priority the **Do not route leads** segment. More information: [Prioritize assignment rules](wa-change-priority-assignment-rule.md)

    :::image type="content" source="media/wa-example-segment-set-highest-priority.png" alt-text="Screenshot that shows setting highest priority to the Don't route leads segment.":::

## Assign leads generated from a campaign to product-specific sales teams

Your organization conducts an annual festive campaign that generates leads for the range of products offered by the organization. You've dedicated sales teams specializing in each product, and your objective is to ensure that the leads generated from the campaign are routed to the corresponding product specialist sales teams. You can achieve this through the following process.

1. Identify attributes between leads and team to match the products.  
    Every specialized sales team has the **Product Owned** attribute that has information about product that the sales team owns, and lead has the **Interested Product** attribute that has information about the potential customer’s interest. More information: [Set seller attributes and capacity](wa-manage-seller-attributes.md)

1. Filter leads with information about the product of interest that are coming from campaign and assigning them to the specialized sales team.  
   When the eligible leads are already filtered in the segment definition, then you may ignore this step. Otherwise, create an assignment rule for the segment and under the eligible leads section, define conditions as described:

    - In **Eligible leads for this rule** section, add the conditions.  

        -  **Interested Product** > **Contains data**.
            This condition considers leads with a product of interest.  

        - Source Campaign > Equals > **Annual Festive Campaign**.  
            This condition considers leads that are generated from the annual festive campaign.

    - In **Assign these leads to a seller, team, or queue** section, select **Teams with matching attributes** from the dropdown list and add the condition **Product Owned** > **Equals** > **Lead.Interested Product**.  
        This condition identifies the product owned by the team and assigns the lead to the team.

    :::image type="content" source="media/wa-example-ar-assign-leads-product-teams.png" alt-text="Screenshot that shows defining conditions to assign leads generated through annual festive campaign to product teams.":::

    This ensures that all leads coming from the campaign are automatically assigned to the most appropriate sales team and the sellers within the team can nurture them to closure.

## Related information

[Create and activate assignment rules](wa-create-and-activate-assignment-rule.md)  
[Create and activate segments](wa-create-and-activate-a-segment.md)  
[Set seller attributes and capacity](wa-manage-seller-attributes.md)