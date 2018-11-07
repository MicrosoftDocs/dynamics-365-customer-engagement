---
title: Using custom fields or entities as resource pricing dimensions | MicrosoftDocs
description: 9-step walkthrough for using custom fields and/or custom entities as pricing dimensions  
author: Rumant
manager: eichimur
ms.custom:
  - dyn365-projectservice
ms.date: 11/06/2018
ms.topic: article
ms.prod: Project Service
ms.service: business-applications
ms.author: rumant
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
    - D365PS
---


Below is a step-by-step walk-through of how to setup custom fields/entities as pricing dimensions.

**Important: It is highly recommended that you make all the changes for custom pricing dimensions in a separate solution as shown here. This is an important best practice guideline that can give you a lot of flexibility on removing these changes in the future if you need to and will also help with re-use of your work and make it easy to port these changes to another instance. Once you have made all the required changes, export this solution as a Managed solution and import it into other instances to reuse your pricing setup.**

**1. Create a solution for pricing dimension changes:**

Using the web interface, create a new solution from the Solutions page: Settings->Solutions. Enter all the required fields and save the solution. You can name the solution “<your organization name> Pricing Dimensions.”
  
**2. Create custom fields and Options sets in the pricing dimension solution**

Your pricing dimension may be an option set or an entity. In either case, create them in your pricing solution. Let’s work with an example for this flow. In this walkthrough, we will create 3 pricing dimensions for a fictious company called Contoso:

a. Entity-based dimension called “Standard Title” that has all the standard titles that Contoso uses.
b. Option-set based dimension called “Resource Work Location” where Contoso would like to track the price of “Home” location work and “Onsite” work.
c. Option-set based dimension called “Resource Work hours” with values “Regular” and “Overtime” where Contoso can apply a markup when work is done.

**3. Create data for your entity-based dimensions:**
This can be done manually or by using Excel import or service calls. For this walkthrough, we have used “Standard Title” as an entity-based dimension. Let’s create 2 standard titles: Systems Engineer and Senior Systems Engineer. If the data to create is small as in the example, you can use a standard form.

**4. Add all the required PSA entities and related components to the Pricing Dimension Solution**
As a next step, you will need to add the following entities in the Project Service to your pricing solution. This step will allow us to make some important schema changes in the pricing solution so that these entities become aware of our new pricing dimensions.

**Note: Make sure to include all forms and views for each of the entities selected.**
On the last step, the platform will prompt you to include any dependent entities for the entities we selected above. Choose the option “No”.

**5. Add custom pricing dimension fields to price setup and transactional entities**
Once custom fields and entities have been created, the next step is make Project Service price setup and business transactional entities aware of your pricing dimensions. Depending on whether your pricing dimensions list includes option set dimensions or entity dimensions or both, follow only the steps in Option set custom pricing dimensions, only Entity-based custom pricing dimensions, or both.
a. Option-set based custom pricing dimensions
  In the scenario where the custom pricing dimension is an option-set, you will simply be adding it as a field to the key Project     Service entities. In our example scenario, Resource Work Location and Resource Work Hours are our Option-set based pricing dimensions. We will first need to add these as fields to the Project Service Pricing entities: Role Price and Role Price Markup entities.
**Important: When you add fields on the entities, it is important to keep the field name the same across all the entities that you will be adding it to. This will help to simplify the setup.**
In the sales and estimation phases for a project, we will need to estimate work effort required to be done “Local” and “Onsite,” and in “Regular hours” and “Overtime hours” to estimate the value of the Quote/Project accurately. So, we will need to add “Resource Work Location” and “Resource Work Hours” as fields to each of these estimation entities in Project Service: Quote line Detail, Contract line detail, Project Team Member, and Estimate Line.

Taking the scenario through to Delivery and Invoicing phases, we need to price the work done accurately based on whether it was “Local” or “Onsite” performed during “Regular hours” or “Overtime” on the Project Actuals. We will need to add “Resource Work Location” and “Resource Work hours” as fields to Time Entry, Approval, Actual, Invoice Line Detail, and Journal Line entities.
This completes the schema changes required for Option-set based custom dimensions
