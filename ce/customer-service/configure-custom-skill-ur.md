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

In Customer Service, a case is created with “Product” as one of the fields. Moreover, there could be thousands of product types (or values) such as Café A-100, Café A-200, and Smart Brew 300 .

The relationship between product and the product types already exists in your system.

Contoso’s workforce is trained to handle queries on these “Products” and thus are “skilled” for that product. They can model Product as a skill and assign different product types as skills to different agents  

Similarly, they can model more attributes as skills, and use custom skill match logic to find the right agents

### Use a custom entity to model as a custom skill

Contoso Coffee has configured “Operated market” as a custom entity in the Live chat. Whenever a customer starts a chat with Contoso, the "Operated market” field gets auto populated with the customer’s location.

The data for Operating market is maintained at Contoso’s end and gets updated whenever they onboard a new market or update an existing one.

Contoso’s workforce is trained for different “Operating markets” and are “skilled” to handle customer expectations and requirements for specific markets. Contoso can model Operating market as a custom skill and assign different markers as skills to their agents 

## How to model custom entities as skills

In advanced settings, go to the Characteristic entity, and create a new field. 
Select the datatype as lookup.
Choose target record type as the case field for which the skill be modeled, for example, Product.
Save and publish the customization.
Go to the Forms tab of the Characteristic entity and open the skill main form.
Drag the newly created custom field from the right panel to the skill form so that it shows up in the UI.
Save abd publish the customization.

Go to the skills page in Customer Service admin center. The new skill will be present on the skill form.



## Next steps

<!--Remove all the comments in this template before you sign-off or merge to the main branch.-->
