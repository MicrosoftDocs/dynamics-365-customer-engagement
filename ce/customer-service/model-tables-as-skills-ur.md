---
title: Model existing tables as skills
description: Learn how you can use existing tables to model as skills and use in unified routing in Dynamics 365 Customer Service.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 05/12/2023
ms.custom: bap-template
---

# Model existing tables as skills

Organizations can use existing data tables and model them as skills to perform skill-based routing. With this approach, you can avoid recreating data definitions as skills in Dynamics 365, and you won't need to write classification rules to stamp skills on the incoming work items. By modeling existing tables as skills, managing data becomes easier.  The following examples illustrate two common scenarios.

- **Example 1**: Use an existing system table to model a skill

   A customer calls a company's support line for help with a product. An agent creates a case in Dynamics 365 Customer Service. The case is created with “Product” as one of the fields. The relationship between product name and product type is already established in the system. Agents are trained to troubleshoot issues with the company's products&mdash;that is, they're "skilled" on the product. Therefore, the company can model "Product" in the Cases table as a skill and assign product types as skills to its agents.

- **Example 2**: Use an existing custom table to model a skill

   A company has created a column called "Operating market" in a [custom table](/power-apps/maker/data-platform/data-platform-create-entity) in live chat. Whenever a customer starts a chat with a support agent, "Operating market" automatically stores the customer's location. Agents are trained to manage the expectations and requirements of customers in specific operating markets&mdash;that is, they're "skilled" on those markets. Therefore, the company can model "Operating market" in the custom table as a skill and assign markets as skills to its agents.

## How modeling tables as skills differs from traditional skill-based routing

Say you have multiple product categories and attributes already configured in your system, such as all your cases populated with "Product" and "Customer" information. To use traditional skill-based routing, you would:

- Enter all your products and customers as skills.
- Assign those skills to agents.
- Create classification rules to add "product" and "customer" skills to incoming work items.

Whenever you added a new product or customer, you'd have to:

- Create a new skill for the new product or customer.
- Assign the new skill to agents.
- Update your classification rules.

Traditional skill-based routing results in duplicated data and effort because you're creating skills from product and customer data you've already entered.

However, if you model the "Product" and "Customer" columns in your tables as skills, you eliminate duplication of both data and effort&mdash;and you don't need to write classification rules.

## How to model a table as a skill

To model data in a table as a skill, you'll need to do the following steps:

1. Create a column for the new skill.
1. Add the column to the Skill Main form so that it's visible in the Customer Service admin center app.
1. Assign a value to the skill and assign the skill to agents.
1. Finally, add the skill as a condition in an assignment rule.

In this example, we model a skill on data in the **Products** table.

### Create a skill column

1. Sign in to [Power Apps](https://make.powerapps.com), and then select the environment that contains your default solution.
1. In the left navigation pane, select **Solutions**, and then select **Default Solution**.
1. In the left panel, select the **Tables** object, and then select the **Characteristic** table.
1. Under **Schema**, select **Columns**.
1. Select **New column**.
1. Enter a name and description. In this example, we've named the column **Skill (Product)** to indicate the skill is based on products, but you can enter any name that's meaningful.
1. In the **Data type** list, select **Lookup** > **Lookup**.
1. In the **Related table** list, select the table that contains the column you use to model the new skill.

    :::image type="content" source="media/custom-skill-new-column.png" alt-text="Screenshot of creating a column to model a skill on products." lightbox="media/custom-skill-new-column.png":::

1. Save the new column.
1. Return to the **Solutions** page and select **Publish all customizations**.

### Add the column to the Skill Main form

1. In Power Apps, in the left navigation pane, select **Tables**, and then select the **Characteristic** table.
1. Under **Data experiences**, select **Forms**, and then select the **Skill Main Form**.
1. Drag the new column from the list of table columns in the left panel to the form.

    :::image type="content" source="media/custom-skill-add-column-to-form.png" alt-text="Screenshot of a skill column added to the skills form." lightbox="media/custom-skill-add-column-to-form.png":::

1. Save and publish the form.

### Assign a value to the skill

1. Open Customer Service admin center. Under **Customer Support**, select **User management**.
1. To the right of **Skills**, select **Manage** to open the **Active Characteristics** view.
1. Select **New**.
1. Enter a name, and optionally a description, for the new skill.
1. In the **Type** list, select **Skill**.
1. In the skill column lookup, search for and select a value. In our example, we've selected the product **AssemblyMaestro 100**.

    :::image type="content" source="media/custom-skill-added.png" alt-text="Screenshot of a product assigned to the new skill column." lightbox="media/custom-skill-added.png":::

1. Select **Save**.
1. [Assign the skill to agents](setup-skills-assign-agents.md#assign-agents-to-skill) as needed.

Finally, add a condition based on the new skill to an [assignment rule](configure-assignment-rules.md).

:::image type="content" source="media/custom-skill-assignment-condition.png" alt-text="Screenshot of a custom skill used as an assignment condition." lightbox="media/custom-skill-assignment-condition.png":::

## Model other data as skills

You can model as a skill any attribute or category you like and match agents with work items using them. You won't have to write classification rules for each skill, saving time and effort in maintenance, especially when attributes or categories change frequently. Using this approach, you can maintain the modeled skills at agent level and change the lookup to the new or updated value when it changes.  

## Things to consider

- [Intelligent skill finder](set-up-skill-based-routing.md#create-skill-finder-models) doesn't predict custom attributes that are modeled as skills.
- Modeled skills aren't included in skill analysis reports and they don't appear as skills in the [agent skill control](manage-skills.md).
- [Out-of-the-box assignment methods](assignment-methods.md#types-of-assignment-methods) don't support skill match for modeled skills.
- [Routing diagnostics](unified-routing-diagnostics.md) don't display modeled skills that were matched during assignment.
- Modeled skills must be of the "lookup" data type.

## Next steps

[Overview of skill-based routing](overview-skill-work-distribution.md)  
[Set up skills, create a rating model, and assign agents](setup-skills-assign-agents.md)  
