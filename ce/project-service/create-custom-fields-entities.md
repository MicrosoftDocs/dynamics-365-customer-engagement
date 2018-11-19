---
title: Create custom fields and entities 
description: Thus page explains how to create option sets and entities in your own solution in the Power Apps platform  
author: Rumant
manager: eichimur
ms.custom:
  - dyn365-projectservice
ms.date: 11/19/2018
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

# Create custom fields and entities 

Complete the following steps any time you want to create a custom option set or entity on the PowerApps platform.  
The procedures in this topic should be completed using the web interface of Project Service Automation (PSA).

> [!IMPORTANT]
> We recommend that you make all custom pricing dimension changes in a separate solution. This important best practice guideline provides flexibility in the future to update or remove changes as needed, will help with re-use of your work, and makes it easier to port these changes to another instance. After you have made all of the required changes, export this solution as a **Managed solution** and import it into other instances to reuse your pricing setup.


## Create a custom solution for pricing dimensions
1. In PSA, click **Settings** > **Solutions**, and then click **New** to create a new solution. 
2. Name the solution, **\<your organization name> pricing dimensions**, enter the remaining required information, and then click **Save**.

> ![Creating a custom solution for pricing dimensions](media/Creation-of-custom-pricing-dimension-solution.png)
  
## Create custom fields and option sets in the pricing dimension solution
A pricing dimension can be an option set or an entity. Both must be created in your pricing solution. The steps in this procedure explain how to create Let’s work with an example for this flow. In this walkthrough, we will create 3 pricing dimensions for a fictious company called Contoso:

a. Entity-based dimension called “Standard Title” that has all the standard titles that Contoso uses.

*Standard Title entity definition*
> ![Standard title entity definition](media/Standard-Title-entity-definition.png)


b. Option-set based dimension called “Resource Work Location” where Contoso would like to track the price of “Home” location work and “Onsite” work.

*Resource Work Location definition*
> ![Option set based pricing dimension called Resource Work Location ](media/Option-set-PD-called-Resource-Work-Location.png)



c. Option-set based dimension called “Resource Work hours” with values “Regular” and “Overtime” where Contoso can apply a markup when work is done.

*Resource Work Hours definition*
> ![Option set based pricing dimension called Resource Work Hours ](media/Option-set-PD-called-Resource-Work-Hours.png)


## Create data for your entity-based dimensions:
This can be done manually or by using Excel import or service calls. For this walkthrough, we have used “Standard Title” as an entity-based dimension. Let’s create 2 standard titles: Systems Engineer and Senior Systems Engineer. If the data to create is small as in the example, you can use a standard form.

*Sample Data for Standard Title entity*
> ![Sample Data for Standard Title entity ](media/ST-data.png)

## Add all the required PSA entities and related components to the Pricing Dimension Solution
As a next step, you will need to add the following entities in the Project Service to your pricing solution. This step will allow us to make some important schema changes in the pricing solution so that these entities become aware of our new pricing dimensions.

**List of entities to add**
1. Actual
2. Bookable Resource
3. Estimate Line
4. Invoice Line Detail
5. Journal Line
6. Project Contract Line Detail
7. Project Team Member
8. Quote Line Detail
9. Role Price Markup
10. Role Price 
11. Time Entry 

*Add Existing Entities to the Pricing Dimensions Solution*

> ![Add existing entities to the pricing dimensions solution](media/Existing-entities-to-PD-solution.png)

*Select solution components*

> ![Select solution components](media/Dimension-Components.png)

**Note: Make sure to include all forms and views for each of the entities selected.**
On the last step, the platform will prompt you to include any dependent entities for the entities we selected above. Choose the option “No”.

*Do not include all related components*
> ![Do not include all related components](media/Do-not-include-required.png)


