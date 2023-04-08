---
title: Model existing data tables as skills
description: Learn how you can use custom data tables to model them as skills in unified routing.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 03/08/2023
ms.custom: bap-template
---

# Model existing data tables as skills

Organizations can use existing data tables and model them as skills to perform skill-based routing. With this approach, you can avoid recreating data definitions as skills in Dynamics 365, and you won't need to write classification rules to stamp skills on the incoming work items. By modeling existing tables as skills, data management and maintenance becomes easier.

The following examples help understand the scenarios.

**Example 1**: Use an existing system table to model as a custom skill

- A customer creates a support ticket with Contoso Coffee for a product they're having issues with.
- In Customer Service, a case is created with “Product” as one of the fields. There could be thousands of product types (or values), such as Café A-100, Café A-200, and Smart Brew 300.
- The relationship between product and the product types already exists in your system.
- Contoso’s workforce is trained to handle queries on these “Products”, and thus are “skilled” on the product. Contoso can model "Product" as a skill and assign different product types as skills to different agents.
- Similarly, they can model more attributes as skills and use custom skill match logic to find the right agents.

**Example 2**: Use a custom table to model as a custom skill

- Contoso Coffee has configured “Operating market” as a [custom table](/power-apps/maker/data-platform/data-platform-create-entity) in live chat. Whenever a customer starts a chat with Contoso, the "Operated market” field is auto-populated with the customer’s location.
- The data for "Operating market" is maintained in Contoso. The data is updated whenever Contoso onboards a new market or updates an existing one.
- Contoso’s workforce is trained for different “Operating markets”, and is “skilled” to handle customer expectations and requirements for specific markets. Contoso can model "Operating market" as a custom skill and assign different markers as skills to their agents.

## How using custom tables as skills differs from default skill-based routing

Say you have multiple product categories and attributes already configured in your system, such as all your cases populated with "Product" and "Customer" information. To use skill-based routing, you'll take the following actions:
- Create all the "Product" and "Customer" values as skills
- Assign those skills to agents
- Write classification rules to stamp "Product" and "Customer" as skills for the incoming work item

When a new value is added to either "Product" or "Customer" fields, you'll take the following actions:
- Create new skills corresponding to each value
- Manually update the newly created skills
- Update your classification rules with those new values

With this method, there's duplication of data because you'll maintain the data on your end and in Dynamics 365.

However, if you model "Product" and "Customer" fields as custom skills, you'll create new skills for those values only and point to the data or values that exist in your system instead of manually adding them. You can maintain all your data at a single place, and you won’t need to write classification rules.  

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
- The modeled skills won’t be present in skill analysis reports.
- [Out-of-the-box assignment methods](assignment-methods.md#types-of-assignment-methods) don't support skill match for custom skills.
- The custom skills won't show up as skills in the [agent skill control](manage-skills.md).
- [Routing diagnostics](unified-routing-diagnostics.md) won't display the “custom skills” that were matched during assignment.
- The custom skills setup will work on the "Lookup" datatype only.

## Next steps

[Overview of skill-based routing](overview-skill-work-distribution.md)  
[Set up skills, create a rating model, and assign agents](setup-skills-assign-agents.md)  
