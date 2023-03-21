---
title: Model existing tables as skills
description: Learn how you can use existing tables to model skills in Dynamics 365 Customer Service unified routing.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 03/21/2023
ms.custom: bap-template
---

# Model existing tables as skills

Instead of [entering skills](setup-skills-assign-agents.md) from scratch to use with skill-based routing, model skills on your existing data to save time and effort. The following examples illustrate two common scenarios.

**Example 1**: Use an existing system table to model a skill

A customer calls a company's support line for help with a product. An agent creates a case in Dynamics 365 Customer Service. The case record includes the customer's product name and product type. The relationship between product name and product type is already established in the system. Agents are trained to troubleshoot issues with the company's products&mdash;that is, they're "skilled" on those product types. Therefore, the company can model "Product Type" as a skill and assign product types as skills to its agents.

**Example 2**: Use an existing custom table to model a skill

A company has created a column called "Operating market" in a [custom table](/power-apps/maker/data-platform/data-platform-create-entity) in live chat. Whenever a customer starts a chat with a support agent, "Operating market" automatically stores the customer's location. Agents are trained to manage the expectations and requirements of customers in specific operating markets&mdash;that is, they're "skilled" on those markets. Therefore, the company can model "Operating market" as a skill and assign markets as skills to its agents.

## How using tables as skills differs from traditional skill-based routing

You already have information about the customers you serve and the products you support in Customer Service. To use traditional skill-based routing, you would:

- Enter all your products and customers as skills.
- Assign those skills to agents.
- Create classification rules to add "product" and "customer" skills to incoming work items.

Whenever you added a new product or customer, you'd have to:

- Create a new skill for the new product or customer.
- Assign the new skill to agents.
- Update your classification rules.

This method results in duplicated data and effort&mdash;you're maintaining products and customers in tables and also creating skills for them.

However, if you model the "Product" and "Customer" columns in your tables as skills, you eliminate duplication. you'll create new skills for those values only and point to the data or values that exist in your system instead of manually adding them. You can maintain all your data at a single place, and you won't need to write classification rules.  

## How to model custom tables as skills

1. Sign in to [Power Apps](https://make.powerapps.com), and then do the following steps:
   1. Go to the **Default Solution**, select **Tables**, and then select **Characteristic**.
   1. Select **Columns** and then select **New column**.
      1. Enter data for the required boxes and ensure that you select the datatype as **Lookup**.
      1. Choose a value in **Related table** for which the skill will be modeled, for example, **Product**.
      1. Save and publish the customization.
   1. In the left pane, select **Forms** under the **Characteristic** node, and then open **Skill Main Form**.
      1. Drag the newly created custom field from the right panel to the skill form so that it shows up on the UI.
      1. Save and publish the customization.
1. In Customer Service admin center, go to **User management** > **Skills**. The new skill will be available on the **New Characteristic** page.
1. Select a value for the new skill, and then assign the skill to agents according to your business use case.

   :::image type="content" source="media/custom-skill-routing.png" alt-text="Add a custom table and use in skill-based routing.":::

1. Go to the assignment rule that you want to update and define a condition on the new skill category, as seen in the following screenshot. More information: [Configure assignment methods for queues](configure-assignment-rules.md)

   :::image type="content" source="media/use-custom-skill-assignmemt-condition.png" alt-text="Define custom table as a skill":::

   Unified routing evaluates the condition in the assignment rule when a work item arrives.

### When to model existing data as skills

Say you have multiple attributes or categories and want to match agents with work items using these custom attributes. You can model each custom attribute as a skill. You won't have to write different classification rules that correspond to each skill you want to identify, thus saving yourself from maintenance hassle, especially when the custom attribute values are evolving frequently.

Using this approach, you can maintain the modeled skills at agent level and change the lookup to the new or updated value when those values change.  

### Things to consider

- [Intelligent skill finder](set-up-skill-based-routing.md#create-skill-finder-models) doesn't predict custom attributes that are modeled as skills.
- The modeled skills won't be present in skill analysis reports.
- [Out-of-the-box assignment methods](assignment-methods.md#types-of-assignment-methods) don't support skill match for custom skills.
- The custom skills won't show up as skills in the [agent skill control](manage-skills.md).
- [Routing diagnostics](unified-routing-diagnostics.md) won't display the "custom skills" that were matched during assignment.
- The custom skills setup will work on the "Lookup" datatype only.

## Next steps

[Overview of skill-based routing](overview-skill-work-distribution.md)  
[Set up skills, create a rating model, and assign agents](setup-skills-assign-agents.md)  
