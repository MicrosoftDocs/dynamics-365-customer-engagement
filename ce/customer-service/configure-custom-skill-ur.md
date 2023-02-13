---
title: Model custom entities as skills
description: Learn how you can use custom entities to model them as skills in unified routing.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 02/08/2023
ms.custom: bap-template
---

# Model custom entities as skills

By using your existing entities and modeling them as skills to perform skill-based routing, you can avoid recreating data definitions as skills in Dynamics 365. You also won't need to write classification rules to stamp skills on the incoming work items. You can manage and maintain your data in an easier manner.

The following examples help understand the scenarios.

**Example 1**: Use an existing system entity to model as a custom skill

- A customer creates a support ticket with Contoso Coffee for a product they're having issues with.
- In Customer Service, a case is created with “Product” as one of the fields. There could be thousands of product types (or values) such as Café A-100, Café A-200, and Smart Brew 300.
- The relationship between product and the product types already exists in your system.
- Contoso’s workforce is trained to handle queries on these “Products” and thus are “skilled” on the product. They can model "Product" as a skill and assign different product types as skills to different agents.
- Similarly, they can model more attributes as skills, and use custom skill match logic to find the right agents.

**Example 2**: Use a custom entity to model as a custom skill

- Contoso Coffee has configured “Operating market” as a [custom entity](/power-apps/maker/data-platform/data-platform-create-entity) in live chat. Whenever a customer starts a chat with Contoso, the "Operated market” field gets auto populated with the customer’s location.
- The data for "Operating market" is maintained in Contoso. The data is updated whenever Contoso onboards a new market or updates an existing one.
- Contoso’s workforce is trained for different “Operating markets” and are “skilled” to handle customer expectations and requirements for specific markets. Contoso can model "Operating market" as a custom skill and assign different markers as skills to their agents.

## How is using custom entities as skills different from default skill-based routing

If you have multiple product categories and attributes already configured in your system.

For example, all your cases are populated with "Product" and "Customer" information. To use skill-based routing, you'll,
- create all the "Product" and "Customer" values as skills
- assign those skills to agents
- write classification rules to stamp "Product" and "Customer" as skills to the incoming work item

When a new value is added to either "Product" or "Customer" fields, you'll,
- create new skills corresponding to each value
- manually update the newly created skills
- update your classification rules with those new values

With this method, there's duplication of data because you'll maintain the data at your end and in Dynamics 365.

However, if you model "Product" and "Customer" fields as custom skills, you'll create new skills for those values only and point to the data or values that exist in your system instead of manually adding them. You can maintain all your data at a single place. And, you won’t need to write classification rules.  

## How to model custom entities as skills

1. Sign in to [Power Apps](https://make.powerapps.com).
1. Go to the **Default Solution** > **Tables**, and select **Characteristic**.
1. Select **Columns** > **New column**.
1. Enter data for the required boxes and ensure that you select the datatype as **Lookup**.
1. Choose a value in **Related table** for which the skill will be modeled, for example, **Product**.
1. Save and publish the customization.
1. In the left pane, select **Forms** under the **Characteristic** node, and open **Skill Main Form**.
1. Drag the newly created custom field from the right panel to the skill form so that it shows up in the UI.
1. Save and publish the customization.
1. In Customer Service admin center, go to **User management** > **Skills**. The new skill will be available on the **New Characteristic** page.
1. Select a value for the new skill and assign the skill to agents according to your business use case.

   :::image type="content" source="media/custom-skill-routing.png" alt-text="Add a custom entity and use in skill-based routing.":::

1. Go to the assignment rule that you want to update and define a condition on the new skill category as seen in the following screenshot.

   :::image type="content" source="media/use-custom-skill-assignmemt-condition.png" alt-text="Define custom entity as a skill":::

   Unified routing evaluates the condition in the assignment rule when a work item arrives.

## When to use existing data models as skills

When you have multiple attributes or categories and want to match agents with work items using these custom attributes. You can model each custom attribute as a skill. You won't have to write different classification rules corresponding to each skill you want to identify, thus saving yourself from maintenance hassle, especially when the custom attribute values are evolving frequently.

Using this approach, you can maintain the modeled skills at agent level and change the lookup to the new or updated value when those values change.  

### Things to consider

- Intelligent skill finder doesn't predict custom attributes that are modeled as skills because they aren't real skills and hence won’t be present in skill analysis reports but still give you the power of skill-based routing.
- Out-of-the-box assignment methods don't support skill match for custom skills.
- The custom skills won't show up as skills in agent skill control.
- Routing diagnostics won't display the “custom skills” that were matched during assignment.
- The custom skills setup will work on "Lookup" datatype only.

## Next steps

[Overview of skill-based routing](overview-skill-work-distribution.md)  
[Set up skills, create a rating model, and assign agents](setup-skills-assign-agents.md)  
