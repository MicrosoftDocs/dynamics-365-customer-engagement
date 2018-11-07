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
Important: It is highly recommended that you make all the changes for custom pricing dimensions in a separate solution as shown here. This is an important best practice guideline that can give you a lot of flexibility on removing these changes in the future if you need to and will also help with re-use of your work and make it easy to port these changes to another instance. Once you have made all the required changes, export this solution as a Managed solution and import it into other instances to reuse your pricing setup.
1. Create a solution for pricing dimension changes:
Using the web interface, create a new solution from the Solutions page: Settings->Solutions. Enter all the required fields and save the solution. You can name the solution “<your organization name> Pricing Dimensions.”
