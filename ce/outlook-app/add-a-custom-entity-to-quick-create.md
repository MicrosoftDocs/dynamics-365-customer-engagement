---
title: "Add a custom entity to quick create in Dynamics 365 App for Outlook  (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
ms.date: 01/09/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: Dynamics 365 apps
ms.assetid: 0dfd6100-b4ed-4959-9acb-cc0a1dbbb6d6
caps.latest.revision: 99
author: mduelae
ms.author: mkaur
manager: kvivek
search.audienceType: 
  - admin
  - customizer
  - enduser
search.app: 
  - D365CE
  - D365Outlook
---
# Customize which entities appear in Quick create  

Follow these steps to enable a custom entity to appear in Quick create. Note, this example shows addition of custom entity but it can be used to add any entity.

![Custom entity in Quick create](media/custom-entity-quick-create.png) 

1. In your app, go to **Settings** > **Customizations** > **Customize the System**.
2. Choose the custom entity. Under **Data Services**, enable **Allow quick create**. Under **Outlook & Mobile**, enable **Enable for mobile**.

   ![Enable entity settings for quick create display](media/settings-enabled.png "Enable entity settings for quick create display")
3. Verify the custom entity has a quick create form. Chose **Forms** and browse for form type **Quick Create**. Create a quick create form if needed.

   ![Quick create form](media/quick-create-form.png "Quick create form")
4. Verify the custom entity is added to the app designer. Choose **Apps**, and then open **App for Outlook**.

   ![Apps for Outlook in Apps](media/apps-for-outlook-in-apps.png)
5. In the app designer, choose **Entities** and browse to find your custom entity.

   ![Custom entity in app designer](media/custom-entity-app-designer.png)



[!INCLUDE[footer-include](../includes/footer-banner.md)]