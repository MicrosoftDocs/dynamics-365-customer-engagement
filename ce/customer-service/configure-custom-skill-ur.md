---
title: Configure skill-based routing using existing data
description: Learn how you can use your existing data to model them as skills and use in skill-based routing.
author: neeranelli
ms.author: nenellim
ms.reviewer: shujoshi
ms.topic: how-to
ms.date: 02/06/2023
ms.custom: bap-template
---

# Configure skill-based routing using existing data

You can use your existing data and model them as skills to perform skill-based routing. You can avoid recreating data definitions as skills in Dynamics 365. You also won't need to write classification rules to stamp skills on the incoming work items. You can manage and maintain your data in an easier manner.

## How is skill-based routing using existing data different from default skill-based routing

If you have multiple product categories and attributes already configured in your system.

For example, all your cases are populated with "Product" and "Customer" information. To use skill-based routing, you will need to,
- create all the "Product" and "Customer" values as skills
- assign those skills to agents
- write classification rules to stamp "Product" and "Customer" as skills to the incoming work item

When a new value is added to either "Product" or "Customer" fields, you will need to,
- create new skills corresponding to each value
- manually update the newly-created skills
- update your classification rules with those new values

With this method, there's duplication of data because you will maintain the data at two places.

However, if you model "Product" and "Customer" fields as custom skills, you will create new skills for those values and point to the data or values that exist in your system instead of manually adding them. You can maintain all your data at a single place. And, you won’t need to write classification rules.  

The two scenarios in the following sections will help you understand how you can use your existing data models.

### Use an existing system entity to model as a custom skill

Customer creates a support ticket with Contoso Coffee for a product they are having issues with.

In Customer Service, a case is created with “Product” as one of the fields. There could be thousands of product types (or values) such as Café A-100, Café A-200, and Smart Brew 300.

The relationship between product and the product types already exists in your system.

Contoso’s workforce is trained to handle queries on these “Products” and thus are “skilled” for that product. They can model "Product" as a skill and assign different product types as skills to different agents.

Similarly, they can model more attributes as skills, and use custom skill match logic to find the right agents.

### Use a custom entity to model as a custom skill

Contoso Coffee has configured “Operating market” as a custom entity in the live chat. Whenever a customer starts a chat with Contoso, the "Operated market” field gets auto populated with the customer’s location.

The data for "Operating market" is maintained in Contoso and gets updated whenever they onboard a new market or update an existing one.

Contoso’s workforce is trained for different “Operating markets” and are “skilled” to handle customer expectations and requirements for specific markets. Contoso can model "Operating market" as a custom skill and assign different markers as skills to their agents.

## How to model custom entities as skills and configure skill-based routing

1. Sign in to [Power Apps](https://make.powerapps.com). 
1. Go to the **Default Solution** > **Tables**, and select **Characteristic**.
1. Select **Columns** > **New column**.
1. Enter data for the required boxes and ensure that you select the datatype as lookup.
1. Choose a value in **Related table** for which the skill will be modeled, for example, **Product**.
1. Save and publish the customization.
1. In the left pane, select **Forms** under the **Characteristic** node, and open **Skill Main Form**.
1. Drag the newly created custom field from the right panel to the skill form so that it shows up in the UI.
1. Save and publish the customization.
1. In Customer Service admin center, go to **User management** > **Skills**. The new skill will be available on the **New Characteristic** page. .
1. Select a value for the new skill and assign the skill to agents according to your business use case.

   :::image type="content" source="media/custom-skill-routing.png" alt-text="Add a custom entity and use in skill-based routing.":::

1. Go to the assignment rule that you want to update and define a condition on the new skill category as seen in the following screenshot.

   :::image type="content" source="media/use-custom-skill-assignmemt-condition.png" alt-text="Define custom entity as a skill"::: 

## When to use existing data models as skills

When you have multiple attributes or categories and want to match agents with work items using these custom attributes. You can model each custom attribute as a skill. You will not have to write different classification rules corresponding to each skill you want to identify, thus saving yourself from maintenance hassle especially when the custom attribute values are evolving frequently. 

Using this approach, you can just maintain the modeled skills at agent level and change the lookup to the new or updated value when those values change.  


## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
