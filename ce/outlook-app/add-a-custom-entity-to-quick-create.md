---
title: "Add a custom table to the quick create menu in Dynamics 365 App for Outlook  (Dynamics 365 apps) | MicrosoftDocs"
ms.custom: 
description: Add a custom table to appear to the quick create menu in Dynamics 365 App for Outlook.
ms.date: 04/28/2021
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
# Customize which tables appear in quick create  

An app maker can enable a table or custom table that you create to appear in the create **New** menu (quick create menu) in Dynamics 365 App for Outlook. 


In the **Before** you can see 

|**Before**  |**After** |
|---------|---------|
| ![Quick create menu before adding a new table](user/media/custom-table-before.png)     |     ![A custom table has been added to the quick create menu](user/media/custom-table-after.png "Power Apps mobile user interface with model-driven and canvas apps")  |



Legend:

1. **New** (quick create) button.
2. Tables that are enabled for quick create.
3. App maker has enanbled a custom table to appear in the quick create menu.





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
