---
title: "Manage sample data (Dynamics 365 Marketing) | Microsoft Docs"
description: "For administrators: Add or remove sample data for Dynamics 365 Marketing."
ms.date: 02/25/2021
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

# Manage sample data in Dynamics 365 Marketing

Sample data gives you something to experiment with as you learn, and helps you see how data is organized in the system. If sample data isn't installed on your trial or sandbox instance, you might want to add it for training purposes. 

To manage your sample data, go to **Settings** > **Other settings** > **Sample data**. From here, you can see if you have sample data installed and choose whether to add or remove it.

> [!IMPORTANT]
> To help prevent unwanted results, you should avoid mixing sample and production data. We recommend that you only install the sample data on trial, preview, or sandbox instances&mdash;not on production instances. Note also that although a command to remove the sample data is provided, it may still leave some sample data behind, so you might still need to manually delete some records.

> [!NOTE]
> The sample data includes sample designs for marketing-automation features such as marketing emails, marketing pages, customer journeys, and more. These elements are all provided in a draft state, which means that you need to activate each relevant record by opening it and choosing **Go Live** before you can use it. Customer journeys in particular, which combine many of these elements, will generate several warning messages on error check to remind you to activate each relevant element. These warnings are normal and to be expected, so just read the messages and go live with each listed record as needed.

[!INCLUDE[footer-include](../includes/footer-banner.md)]