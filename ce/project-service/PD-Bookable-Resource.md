---
title: Bookable Resource as a Pricing Dimension (Dynamics 365 for Project Service) | MicrosoftDocs
description: Setup required for using Bookable Resource as a pricing dimension in project service solution 
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


**1. Create a pricing dimension solution:**
As a first step, we will need to create a Solution for the Pricing dimensions. If you already have a pricing dimension solution, then you can make your changes in that solution. If you have not created a new Pricing Dimension solution for your Organization, follow all of the instructions in Create a solution for pricing dimension changes: and Add all the required PSA entities and related components to the Pricing Dimension Solution
**2. Add Bookable Resource to forms and views**
The next step is to make these fields visible on the UI in Pricing dimension solution. For this, you will need to walkthrough all the forms and views of the key Project Service entities and add these fields to the forms and views of those entities.
Below is the comprehensive list of the out-of-thebox forms and views by entity that will need to be updated with the new fields. -If you have any additional views or forms in your customizations on these entities, please add the new fields to those as well.

Open the Solution Explorer for the pricing dimension solution and “Publish All Customizations.”

**3. Set up bookable resource as a pricing dimension**
Navigate to Project Service->Settings->Parameters and open the Parameter page. Then open the tab “Amount-Based Pricing Dimensions.” The grid on the tab shows the records in the Pricing Dimensions entity in Project Service. Add Bookable Resource to this list of Pricing Dimensions with applicable to cost and applicable to sale set to “Yes”. Dimension Type should be “amount-based”. Decide the priority for Bookable Resource in the cost and sales context. Usually when present as a pricing dimension, Bookable Resource has the highest priority so setting this to 1 (or 0 depending on how you count the priority) would ensure that behavior.
