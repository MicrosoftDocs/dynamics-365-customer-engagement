---
title: "Create a new version of a customer journey (Dynamics 365 Marketing) | Microsoft Docs"
description: "Learn how to create a new version of a real-time marketing journey in Dynamics 365 Marketing."
ms.date: 10/20/2021
ms.service: dynamics-365-marketing
ms.custom: 
  - dyn365-marketing
ms.topic: article
author: alfergus
ms.author: alfergus
manager: shellyha
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Mktg
---

# Create a new version of a customer journey

If you want to modify a live customer journey in real-time marketing, you will need to create a new version of the journey. 

## Creating a new version

To create a new version, open the customer journey you want to modify, then select the **Create a new version** button in the top-right corner of the journey editor.

> [!div class="mx-imgBorder"]
> ![Create a new version button.](media/real-time-marketing-create-version.png "Create a new version button")

After editing the journey, select **Publish**. A window will pop up asking if you are ready to publish your changes.

> [!div class="mx-imgBorder"]
> ![Screenshot of the Ready to publish window.](media/real-time-marketing-ready-to-publish.png "Screenshot of the Ready to publish window")

- To push the changes live, select the **Publish** button.
- To discard the changes, select **Cancel** and then **Discard changes** in the journey editor.

Once you've published the journey, customers will enter the newest version of the journey. Customers who have already entered the previous version of the journey will complete their original journey.

For repeating journeys, customers will enter the latest version of the journey.

For static segment-based journeys, all customers will repeat the newest version of the journey.

## Updates to the journey status

A newly published journey version will be marked as **Live**, while the original journey version will have a **Completing** status until the last customer exits the journey. After the last customer exits, the original journey will switch to a **Completed** status.

To learn more about journey statuses, see [Publish records through the go-live process](go-live.md#real-time-marketing-go-live-operations-and-status).