---
title: Create custom fields and entities 
description: Thus page explains how to create option sets and entities in your own solution in the Power Apps platform  
author: Rumant
manager: eichimur
ms.custom:
  - dyn365-projectservice
ms.date: 11/26/2018
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

Complete the following steps any time that you want to create a custom option set or entity on the PowerApps platform.  
The procedures in this topic should be completed using the web interface of Project Service Automation (PSA).

> [!IMPORTANT]
> We recommend that you make all custom pricing dimension changes in a separate solution. This important best practice guideline provides flexibility in the future to update or remove changes as needed, will help with re-use of your work, and makes it easier to port these changes to another instance. After you have made all of the required changes, export this solution as a **Managed solution** and import it into other instances to reuse your pricing setup.


## Create a custom solution for pricing dimensions
1. In PSA, click **Settings** > **Solutions**, and then click **New** to create a new solution. 
2. Name the solution, **\<your organization name> pricing dimensions**, enter the remaining required information, and then click **Save**.

> ![Creating a custom solution for pricing dimensions](media/Creation-of-custom-pricing-dimension-solution.png)
  
## Create custom fields and option sets in the pricing dimension solution

A pricing dimension can be an option set or an entity. Both must be created in your pricing solution. The steps in this procedures explain how to create entity-based dimensions and option set-based dimensions.

### Entity-based dimensions

1. In PSA, click **Settings** > **Solutions**, and then double-click **\<your organization name> pricing dimensions**.
2. In the left navigation In Solution Explorer, on the left nav pane, select  **Entities**.
3. Click **New** to create a new entity called **Standard Title**, enter the remaining required information, and then click **Save**.

> ![Standard title entity definition](media/Standard-Title-entity-definition.png)


### Option set-based dimensions 
You can create two option set-based dimensions. One,**Resource Work Location** you can track the price of **Home** location work and **Onsite** work and another, **Resource Work hours** with values **Regular** and **Overtime** where you can apply a markup when work is completed.


1. In PSA, click **Settings** > **Solutions**, and then double-click  **\<your organization name> pricing dimensions**. 
2. In Solution Explorer, on the left nav pane, select  **Option Sets**. 
3. Click **New** to create a new option set, enter the remaining required information, and then click **Save**.

> ![Option set based pricing dimension called Resource Work Location ](media/Option-set-PD-called-Resource-Work-Location.png)

> ![Option set based pricing dimension called Resource Work Hours ](media/Option-set-PD-called-Resource-Work-Hours.png)


## Create data for entity-based dimensions

YOu can create data for entity-based dimensions manually, or by using Microsoft Excel import or service calls. Use the steps in this procedure to create two standard titles, **Systems Engineer** and **Senior Systems Engineer** from the entity-based dimension, **Standard Title**. If the data to create is small as in the example, you can use a standard form.

1. In PSA, click **Advanced Find** > select the entity **Standard Title** and then click **Results**. All of the rows in the **Standard Title** entity will be shown.
2. Click **New**, and in the **Name** field, enter "Systems Engineer" and then click **Save**.
3. Close the form. 
4. Repeat steps 1 - 3 to create another standard title for "Senior Systems Engineer".

> ![Sample Data for Standard Title entity ](media/ST-data.png)

## Add all required PSA entities and related components to the Pricing Dimension Solution
You will need to add the following Project Service entities to your pricing solution. Use the steps in this procedure to make some important schema changes in the pricing solution so that the entities become aware of the new pricing dimensions.

1. In PSA, click **Settings** > **Solutions**, and then double-click **\<your organization name> pricing dimensions**. 
2. In Solution Explorer, on the left nav pane, select **Add Existing** > **Entities**.
3. In the **Solution Components** dialog, select the following entities:

- Actual
- Bookable Resource
- Estimate Line
- Invoice Line Detail
- Journal Line
- Project Contract Line Detail
- Project Team Member
- Quote Line Detail
- Role Price Markup
- Role Price 
- Time Entry 

> ![Add existing entities to the pricing dimensions solution](media/Existing-entities-to-PD-solution.png)

> ![Select solution components](media/Dimension-Components.png)

> [!NOTE]
> Make sure to include all forms and views for each of the entities selected.

4. When promoted to include any dependent entities for the entities selected above, click **Np**.

> ![Do not include all related components](media/Do-not-include-required.png)


