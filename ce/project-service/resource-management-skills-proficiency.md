---
title: Skills and proficiency models 
description: This topic provides information about how to use the skills and proficiency models.
author: ruhercul
manager: kfend
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-projectservice
ms.date: 03/13/2019
ms.topic: article
ms.prod: 
ms.technology: 
ms.author: ruhercul
audience: Admin
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365PS
---

# Skills and proficiency models

[!INCLUDE[cc-applies-to-psa-app-3.x](../includes/cc-applies-to-psa-app-3x.md)]

Skills are resource characteristics that are shared between Dynamics 365 Project Service Automation and if present, Dynamics 365 Field Service. 

To maintain the repository of skills in Project Service Automation, go to **Resources** \> **Resource Skills**. 

> ![Resource Skills](media/Resource-Management-image84.png)

## Use proficiency models to rate resources

Skills for resources are rated by proficiency models. The individual ratings are in a proficiency model. 

1. To create a proficiency model, go to **Resources** \> **Proficiency Models**, and then select **New**.
2. In the new rating model, specify the minimum rating value, the maximum rating value, and the entity that is being rated.
3. In the **Rating Values** sub-grid, you can define the different rating values, from the minimum to the maximum.

> ![Minimum and maximum ratings defined](media/Resource-Management-image85.png)

These rating values are shown on the **Resource Requirements**, **Schedule Board**, and **Schedule Assistant** filters.
