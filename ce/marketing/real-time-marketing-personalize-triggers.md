---
title: "Personalize triggers using conditions (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to personalize triggers using attributes from tables one hop away in real-time journeys in Dynamics 365 Marketing."
ms.date: 12/16/2022
ms.custom: 
  - dyn365-admin
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
search.audienceType: 
  - admin
  - customizer
  - enduser
---

# Personalize triggers using conditions

[!INCLUDE[consolidated-sku-rtm-only](../includes/consolidated-sku-rtm-only.md)]

You can deliver more personalized experiences by accessing a rich set of trigger data for defining the journey entry/exit criteria, conditions/branches, and wait for branches. When you add any of these elements to the journey, you can use data attributes not only from the trigger’s core entity/table, but also from entities/tables directly related to those attributes.

For example, let’s create a journey to nurture new opportunities (using the “Opportunity created” trigger).

In the **Choose a trigger** dialogue, select the **Opportunity created** trigger.

> [!div class="mx-imgBorder"]
> ![Choose a trigger screenshot.](media/real-time-marketing-tile-choose-trigger.png "Choose a trigger screenshot")

Then, select **+Add condition** and search for the **budget** attribute from the Opportunity table.

> [!div class="mx-imgBorder"]
> ![Select the budget attribute.](media/real-time-marketing-tile-budget.png "Select the budget attribute")

This enables you to create [journey variations](real-time-marketing-edit-journey.md) for opportunities that are more likely to buy.

> [!div class="mx-imgBorder"]
> ![Create a variation based on the attribute.](media/real-time-marketing-tile-will-buy.png "Create a variation based on the attribute")

[!INCLUDE[footer-include](../includes/footer-banner.md)]
